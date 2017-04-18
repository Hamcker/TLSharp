using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Models;

namespace TLGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileAddress;
            byte fileType = 0; // 1 json; 2 tl

            if (args.Length == 0 || string.IsNullOrEmpty(args[0]))
            {
                var tlFiles = Directory.GetFiles(Environment.CurrentDirectory, "*.tl", SearchOption.TopDirectoryOnly);

                if (!tlFiles.Any())
                {
                    var jsonFiles = Directory.GetFiles(Environment.CurrentDirectory, "*.json", SearchOption.TopDirectoryOnly);

                    if (!jsonFiles.Any())
                    {
                        throw new Exception("There is no *.tl or *.json file in direcory or any argument.");
                    }
                    else
                    {
                        fileAddress = jsonFiles.First();
                        fileType = 1;
                    }
                }
                else
                {
                    fileAddress = tlFiles.First();
                    fileType = 2;
                }
            }
            else
            {
                fileAddress = args[0];
                if (args[0].EndsWith("json")) fileType = 1;
                else if (args[0].EndsWith("tl")) fileType = 2;
                else throw new Exception("Invalid file type. Json or Tl expected.");
            }

            switch (fileType)
            {
                case 1:
                    ParseJsonByFile(fileAddress);
                    break;

                case 2:
                    ParseTL(fileAddress);
                    break;
            }

        }

        public static void ParseJsonByFile(string FileAddress)
        {
            string json = File.ReadAllText(FileAddress);
            ParseJson(json);
        }

        public static void ParseTL(string FileAddress)
        {
            string source = File.ReadAllText(FileAddress);
            IEnumerable<string> sourceLines = source.Split('\n');

            //remove comments and empty lines
            sourceLines = sourceLines.Where(x => !x.StartsWith("//") && !string.IsNullOrEmpty(x) && !string.IsNullOrWhiteSpace(x));

            //remove semicolons & Carriage Returns
            sourceLines = sourceLines.Select(x => x.Replace(";", "").Replace("\r", "")).ToList();

            byte section = 1; // 1 types; 2 functions
            Models.Schema schema = new Models.Schema();

            foreach (string line in sourceLines)
            {
                switch (line)
                {
                    case "---types---":
                        section = 1;
                        continue;

                    case "---functions---":
                        section = 2;
                        continue;
                }

                List<string> lineParts = line.Split(' ').ToList();
                string constHeader = lineParts[0];
                string constNameAssembly = constHeader.Split('#')[0];
                string constAssembly = constNameAssembly.Contains(".") ? constNameAssembly.Split('.')[0] : "";
                string constName = constNameAssembly.Contains(".") ? constNameAssembly.Split('.')[1] : constNameAssembly;
                string constId = constHeader.Split('#')[1];

                if (constNameAssembly.Contains("vector"))
                {
                    continue;
                }

                int equalIndex = lineParts.ToList().IndexOf("=");

                if (section == 1) // types (contsructors)
                {
                    Models.Constructor @const = new Models.Constructor { id = int.Parse(constId, System.Globalization.NumberStyles.HexNumber), predicate = constNameAssembly, type = lineParts[equalIndex + 1] };

                    if (equalIndex > 1)
                    {
                        for (int i = 1; i < equalIndex; i++)
                        {
                            string constParam = lineParts[i];

                            if (constParam != "{X:Type}")
                            {
                                @const.Params.Add(new Models.Param { name = constParam.Split(':')[0], type = constParam.Split(':')[1] });
                            }
                        }
                    }

                    schema.constructors.Add(@const);
                }
                else if (section == 2) // functions
                {
                    Models.Method @const = new Models.Method { id = int.Parse(constId, System.Globalization.NumberStyles.HexNumber), method = constNameAssembly, type = lineParts[equalIndex + 1] };

                    if (equalIndex > 1)
                    {
                        for (int i = 1; i < equalIndex; i++)
                        {
                            string constParam = lineParts[i];

                            if (constParam != "{X:Type}")
                            {
                                @const.Params.Add(new Models.Param { name = constParam.Split(':')[0], type = constParam.Split(':')[1] });
                            }
                        }
                    }

                    schema.methods.Add(@const);
                }
            }

            File.WriteAllText("schema.json", JsonConvert.SerializeObject(schema));

            ParseObject(schema);
        }



        /***********************************************/
        static List<string> keywords = new List<string>(new string[] { "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit", "in", "in", "int", "interface", "internal", "is", "lock", "long", "namespace", "new", "null", "object", "operator", "out", "out", "override", "params", "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual", "void", "volatile", "while", "add", "alias", "ascending", "async", "await", "descending", "dynamic", "from", "get", "global", "group", "into", "join", "let", "orderby", "partial", "partial", "remove", "select", "set", "value", "var", "where", "where", "yield" });
        static List<string> interfacesList = new List<string>();
        static List<string> classesList = new List<string>();

        public static void ParseJson(string JSonString)
        {
            Models.Schema obj = JsonConvert.DeserializeObject<Models.Schema>(JSonString);
            ParseObject(obj);
        }

        public static void ParseObject(Models.Schema schema)
        {
            string AbsStyle = File.ReadAllText("ConstructorAbs.tmp");
            string NormalStyle = File.ReadAllText("Constructor.tmp");
            string MethodStyle = File.ReadAllText("Method.tmp");
            string ToStyle = File.ReadAllText("ToMethod.tmp");

            foreach (Constructor c in schema.constructors)
            {
                interfacesList.Add(c.type);
                classesList.Add(c.predicate);
            }

            //interfacesList = interfacesList.Distinct().ToList();

            // Creating TLAbs*.cs files
            foreach (var c in schema.constructors)
            {
                string path = (GetNameSpace(c.type).Replace("TeleSharp.TL", "TL\\").Replace(".", "") + "\\" + GetNameofClass(c.type, true) + ".cs").Replace("\\\\", "\\");
                FileStream classFile = MakeFile(path);
                using (StreamWriter writer = new StreamWriter(classFile))
                {
                    string nspace = (GetNameSpace(c.type).Replace("TeleSharp.TL", "TL\\").Replace(".", "")).Replace("\\\\", "\\").Replace("\\", ".");
                    if (nspace.EndsWith("."))
                        nspace = nspace.Remove(nspace.Length - 1, 1);
                    string temp = AbsStyle.Replace("/* NAMESPACE */", "TeleSharp." + nspace);
                    temp = temp.Replace("/* NAME */", GetNameofClass(c.type, true));
                    temp = temp.Replace("/*TYPES*/", string.Join(",", schema.constructors.Where(x => x.type == c.type).Select(x => GetNameofClass(x.predicate)).ToArray()));
                    temp = temp.Replace("/*Tos*/", string.Join("\n", schema.constructors.Where(x => x.type == c.type).Select(x => ToStyle.Replace("/*Type*/", GetNameofClass(x.predicate)))));
                    writer.Write(temp);
                    writer.Close();
                    classFile.Close();
                }
            }

            // Creating TL.s files
            foreach (var c in schema.constructors)
            {
                string path = (GetNameSpace(c.predicate).Replace("TeleSharp.TL", "TL\\").Replace(".", "") + "\\" + GetNameofClass(c.predicate, false) + ".cs").Replace("\\\\", "\\");
                FileStream classFile = MakeFile(path);
                using (StreamWriter writer = new StreamWriter(classFile))
                {
                    #region About Class
                    string nspace = (GetNameSpace(c.predicate).Replace("TeleSharp.TL", "TL\\").Replace(".", "")).Replace("\\\\", "\\").Replace("\\", ".");
                    if (nspace.EndsWith("."))
                        nspace = nspace.Remove(nspace.Length - 1, 1);
                    string temp = NormalStyle.Replace("/* NAMESPACE */", "TeleSharp." + nspace);
                    //temp = (c.type == "himself") ? temp.Replace("/* PARENT */", "TLObject") : temp.Replace("/* PARENT */", GetNameofClass(c.type, true));
                    temp = temp.Replace("/* PARENT */", GetNameofClass(c.type, true));
                    temp = temp.Replace("/*Constructor*/", c.id.ToString());
                    temp = temp.Replace("/* NAME */", GetNameofClass(c.predicate, false));
                    #endregion
                    #region Fields
                    string fields = "";
                    foreach (var tmp in c.Params)
                    {
                        fields += $"     public {CheckForFlagBase(tmp.type, GetTypeName(tmp.type))} {CheckForKeyword(tmp.name)} " + "{get;set;}" + Environment.NewLine;
                    }
                    temp = temp.Replace("/* PARAMS */", fields);
                    #endregion
                    #region ComputeFlagFunc
                    if (!c.Params.Any(x => x.name == "flags")) temp = temp.Replace("/* COMPUTE */", "");
                    else
                    {
                        var compute = "flags = 0;" + Environment.NewLine;
                        foreach (var param in c.Params.Where(x => IsFlagBase(x.type)))
                        {
                            if (IsTrueFlag(param.type))
                            {
                                compute += $"flags = {CheckForKeyword(param.name)} ? (flags | {GetBitMask(param.type)}) : (flags & ~{GetBitMask(param.type)});" + Environment.NewLine;
                            }
                            else
                            {
                                compute += $"flags = {CheckForKeyword(param.name)} != null ? (flags | {GetBitMask(param.type)}) : (flags & ~{GetBitMask(param.type)});" + Environment.NewLine;
                            }
                        }
                        temp = temp.Replace("/* COMPUTE */", compute);
                    }
                    #endregion
                    #region SerializeFunc
                    var serialize = "";

                    if (c.Params.Any(x => x.name == "flags")) serialize += "ComputeFlags();" + Environment.NewLine + "bw.Write(flags);" + Environment.NewLine;
                    foreach (var p in c.Params.Where(x => x.name != "flags"))
                    {
                        serialize += WriteWriteCode(p) + Environment.NewLine;
                    }
                    temp = temp.Replace("/* SERIALIZE */", serialize);
                    #endregion
                    #region DeSerializeFunc
                    var deserialize = "";

                    foreach (var p in c.Params)
                    {
                        deserialize += WriteReadCode(p) + Environment.NewLine;
                    }
                    deserialize += $"Type = {GetNameofClass(c.type, true)}Types.{GetNameofClass(c.predicate)};";
                    temp = temp.Replace("/* DESERIALIZE */", deserialize);
                    #endregion
                    writer.Write(temp);
                    writer.Close();
                    classFile.Close();
                }
            }

            // creating TLRequest*.cs files
            foreach (var c in schema.methods)
            {
                string path = (GetNameSpace(c.method).Replace("TeleSharp.TL", "TL\\").Replace(".", "") + "\\" + GetNameofClass(c.method, false, true) + ".cs").Replace("\\\\", "\\");
                FileStream classFile = MakeFile(path);
                using (StreamWriter writer = new StreamWriter(classFile))
                {
                    #region About Class
                    string nspace = (GetNameSpace(c.method).Replace("TeleSharp.TL", "TL\\").Replace(".", "")).Replace("\\\\", "\\").Replace("\\", ".");
                    if (nspace.EndsWith("."))
                        nspace = nspace.Remove(nspace.Length - 1, 1);
                    string temp = MethodStyle.Replace("/* NAMESPACE */", "TeleSharp." + nspace);
                    temp = temp.Replace("/* PARENT */", "TLMethod");
                    temp = temp.Replace("/*Constructor*/", c.id.ToString());
                    temp = temp.Replace("/* NAME */", GetNameofClass(c.method, false, true));
                    #endregion
                    #region Fields
                    string fields = "";
                    foreach (var tmp in c.Params)
                    {
                        fields += $"        public {CheckForFlagBase(tmp.type, GetTypeName(tmp.type))} {CheckForKeyword(tmp.name)} " + "{get;set;}" + Environment.NewLine;
                    }
                    fields += $"        public {CheckForFlagBase(c.type, GetTypeName(c.type))} Response" + "{ get; set;}" + Environment.NewLine;
                    temp = temp.Replace("/* PARAMS */", fields);
                    #endregion
                    #region ComputeFlagFunc
                    if (!c.Params.Any(x => x.name == "flags")) temp = temp.Replace("/* COMPUTE */", "");
                    else
                    {
                        var compute = "flags = 0;" + Environment.NewLine;
                        foreach (var param in c.Params.Where(x => IsFlagBase(x.type)))
                        {
                            if (IsTrueFlag(param.type))
                            {
                                compute += $"flags = {CheckForKeyword(param.name)} ? (flags | {GetBitMask(param.type)}) : (flags & ~{GetBitMask(param.type)});" + Environment.NewLine;
                            }
                            else
                            {
                                compute += $"flags = {CheckForKeyword(param.name)} != null ? (flags | {GetBitMask(param.type)}) : (flags & ~{GetBitMask(param.type)});" + Environment.NewLine;
                            }
                        }
                        temp = temp.Replace("/* COMPUTE */", compute);
                    }
                    #endregion
                    #region SerializeFunc
                    var serialize = "";

                    if (c.Params.Any(x => x.name == "flags")) serialize += "ComputeFlags();" + Environment.NewLine + "bw.Write(flags);" + Environment.NewLine;
                    foreach (var p in c.Params.Where(x => x.name != "flags"))
                    {
                        serialize += WriteWriteCode(p) + Environment.NewLine;
                    }
                    temp = temp.Replace("/* SERIALIZE */", serialize);
                    #endregion
                    #region DeSerializeFunc
                    var deserialize = "";

                    foreach (var p in c.Params)
                    {
                        deserialize += WriteReadCode(p) + Environment.NewLine;
                    }
                    temp = temp.Replace("/* DESERIALIZE */", deserialize);
                    #endregion
                    #region DeSerializeRespFunc
                    var deserializeResp = "";
                    Param p2 = new Param() { name = "Response", type = c.type };
                    deserializeResp += WriteReadCode(p2) + Environment.NewLine;
                    temp = temp.Replace("/* DESERIALIZEResp */", deserializeResp);
                    #endregion
                    writer.Write(temp);
                    writer.Close();
                    classFile.Close();
                }
            }
        }


        public static string FormatName(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");

            if (input.Contains(" "))
                input = input.Split(' ')[0];

            if (input.IndexOf('.') != -1)
            {
                input = input.Replace(".", " ");
                var temp = "";
                foreach (var s in input.Split(' '))
                {
                    temp += FormatName(s) + " ";
                }
                input = temp.Trim();
            }
            return input.First().ToString().ToUpper() + input.Substring(1);
        }
        public static string CheckForKeyword(string name)
        {
            if (keywords.Contains(name)) return "@" + name;
            return name;
        }
        public static string GetNameofClass(string type, bool isinterface = false, bool ismethod = false)
        {
            if (!ismethod)
            {
                if (type.IndexOf('.') != -1 && type.IndexOf('?') == -1)
                    return isinterface ? "TLAbs" + FormatName(type.Split('.')[1]) : "TL" + FormatName(type.Split('.')[1]);
                else if (type.IndexOf('.') != -1 && type.IndexOf('?') != -1)
                    return isinterface ? "TLAbs" + FormatName(type.Split('?')[1]) : "TL" + FormatName(type.Split('?')[1]);
                else
                    return isinterface ? "TLAbs" + FormatName(type) : "TL" + FormatName(type);
            }
            else
            {
                if (type.IndexOf('.') != -1 && type.IndexOf('?') == -1)
                    return "TLRequest" + FormatName(type.Split('.')[1]);
                else if (type.IndexOf('.') != -1 && type.IndexOf('?') != -1)
                    return "TLRequest" + FormatName(type.Split('?')[1]);
                else
                    return "TLRequest" + FormatName(type);
            }
        }
        private static bool IsFlagBase(string type)
        {
            return type.IndexOf("?") != -1;
        }
        private static int GetBitMask(string type)
        {
            return (int)Math.Pow((double)2, (double)int.Parse(type.Split('?')[0].Split('.')[1]));
        }
        private static bool IsTrueFlag(string type)
        {
            return type.Split('?')[1] == "true";
        }
        public static string GetNameSpace(string type)
        {
            if (type.IndexOf('.') != -1)
                return "TeleSharp.TL" + FormatName(type.Split('.')[0]);
            else
                return "TeleSharp.TL";
        }
        public static string CheckForFlagBase(string type, string result)
        {
            if (type.IndexOf('?') == -1)
                return result;
            else
            {
                string innerType = type.Split('?')[1];
                if (innerType == "true") return result;
                else if ((new string[] { "bool", "int", "uint", "long", "double" }).Contains(result)) return result + "?";
                else return result;
            }
        }
        public static string GetTypeName(string type)
        {
            switch (type.ToLower())
            {
                case "#":
                case "int":
                    return "int";
                case "uint":
                    return "uint";
                case "long":
                    return "long";
                case "double":
                    return "double";
                case "string":
                    return "string";
                case "bytes":
                    return "byte[]";
                case "true":
                case "bool":
                    return "bool";
                case "!x":
                    return "TLObject";
                case "x":
                    return "TLObject";
                case "int128":
                    return "Int128";
                case "int256":
                    return "Int256";
            }

            if (type.ToLower().StartsWith("vector"))
                return "TLVector<" + GetTypeName(type.Replace("vector<", "").Replace("Vector<", "").Replace(">", "")) + ">";

            //if (type.ToLower().Contains("inputcontact"))
            //    return "TLInputPhoneContact";


            if (type.IndexOf('.') != -1 && type.IndexOf('?') == -1)
            {

                if (interfacesList.Any(x => x.ToLower() == (type).ToLower()))
                    return FormatName(type.Split('.')[0]) + "." + "TLAbs" + type.Split('.')[1];
                else if (classesList.Any(x => x.ToLower() == (type).ToLower()))
                    return FormatName(type.Split('.')[0]) + "." + "TL" + type.Split('.')[1];
                else
                    return FormatName(type.Split('.')[1]);
            }
            else if (type.IndexOf('?') == -1)
            {
                if (interfacesList.Any(x => x.ToLower() == type.ToLower()))
                    return "TLAbs" + FormatName(type);
                else if (classesList.Any(x => x.ToLower() == type.ToLower()))
                    return "TL" + FormatName(type);
                else
                    return type;
            }
            else
            {
                return GetTypeName(type.Split('?')[1]);
            }


        }
        public static string LookTypeInLists(string src)
        {
            if (interfacesList.Any(x => x.ToLower() == src.ToLower()))
                return "TLAbs" + FormatName(src);
            else if (classesList.Any(x => x.ToLower() == src.ToLower()))
                return "TL" + FormatName(src);
            else
                return src;
        }
        public static string WriteWriteCode(Param p, bool flag = false)
        {
            switch (p.type.ToLower())
            {
                case "#":
                case "int":
                    return flag ? $"bw.Write({CheckForKeyword(p.name)}.Value);" : $"bw.Write({CheckForKeyword(p.name)});";
                case "long":
                    return flag ? $"bw.Write({CheckForKeyword(p.name)}.Value);" : $"bw.Write({CheckForKeyword(p.name)});";
                case "string":
                    return $"StringUtil.Serialize({CheckForKeyword(p.name)},bw);";
                case "bool":
                    return flag ? $"BoolUtil.Serialize({CheckForKeyword(p.name)}.Value,bw);" : $"BoolUtil.Serialize({CheckForKeyword(p.name)},bw);";
                case "true":
                    return $"BoolUtil.Serialize({CheckForKeyword(p.name)},bw);";
                case "bytes":
                    return $"BytesUtil.Serialize({CheckForKeyword(p.name)},bw);";
                case "double":
                    return flag ? $"bw.Write({CheckForKeyword(p.name)}.Value);" : $"bw.Write({CheckForKeyword(p.name)});";
                default:
                    if (!IsFlagBase(p.type))
                        return $"ObjectUtils.SerializeObject({CheckForKeyword(p.name)},bw);";
                    else
                    {
                        if (IsTrueFlag(p.type))
                            return $"";
                        else
                        {
                            Param p2 = new Param() { name = p.name, type = p.type.Split('?')[1] };
                            return $"if ((flags & {GetBitMask(p.type).ToString()}) != 0)" + Environment.NewLine +
                                WriteWriteCode(p2, true);
                        }
                    }
            }
        }
        public static string WriteReadCode(Param p)
        {
            switch (p.type.ToLower())
            {
                case "#":
                case "int":
                    return $"{CheckForKeyword(p.name)} = br.ReadInt32();";
                case "long":
                    return $"{CheckForKeyword(p.name)} = br.ReadInt64();";
                case "string":
                    return $"{CheckForKeyword(p.name)} = StringUtil.Deserialize(br);";
                case "bool":
                case "true":
                    return $"{CheckForKeyword(p.name)} = BoolUtil.Deserialize(br);";
                case "bytes":
                    return $"{CheckForKeyword(p.name)} = BytesUtil.Deserialize(br);";
                case "double":
                    return $"{CheckForKeyword(p.name)} = br.ReadDouble();";
                default:
                    if (!IsFlagBase(p.type))
                    {
                        if (p.type.ToLower().Contains("vector"))
                        {
                            return $"{CheckForKeyword(p.name)} = ({GetTypeName(p.type)})ObjectUtils.DeserializeVector<{GetTypeName(p.type).Replace("TLVector<", "").Replace(">", "")}>(br);";
                        }
                        else return $"{CheckForKeyword(p.name)} = ({GetTypeName(p.type)})ObjectUtils.DeserializeObject(br);";
                    }
                    else
                    {
                        if (IsTrueFlag(p.type))
                            return $"{CheckForKeyword(p.name)} = (flags & {GetBitMask(p.type).ToString()}) != 0;";
                        else
                        {
                            Param p2 = new Param() { name = p.name, type = p.type.Split('?')[1] };
                            return $"if ((flags & {GetBitMask(p.type).ToString()}) != 0)" + Environment.NewLine +
                                WriteReadCode(p2) + Environment.NewLine +
                            "else" + Environment.NewLine +
                                $"{CheckForKeyword(p.name)} = null;" + Environment.NewLine;
                        }
                    }
            }
        }
        public static FileStream MakeFile(string path)
        {
            if (!Directory.Exists(Path.GetDirectoryName(path)))
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            if (File.Exists(path))
                File.Delete(path);
            return File.OpenWrite(path);
        }

    }
}
