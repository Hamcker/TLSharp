using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;

namespace TeleSharp.TL
{
	[TLObject(629866245)]
    public class TLKeyboardButtonUrl : TLAbsKeyboardButton
    {
        public override int Constructor
        {
            get
            {
                return 629866245;
            }
        }

             public string text {get;set;}
     public string url {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            text = StringUtil.Deserialize(br);
url = StringUtil.Deserialize(br);
Type = TLAbsKeyboardButtonTypes.TLKeyboardButtonUrl;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            StringUtil.Serialize(text,bw);
StringUtil.Serialize(url,bw);

        }
    }
}
