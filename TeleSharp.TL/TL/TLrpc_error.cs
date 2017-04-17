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
	[TLObject(558156313)]
    public class TLRpc_error : TLAbsRpcError
    {
        public override int Constructor
        {
            get
            {
                return 558156313;
            }
        }

             public int error_code {get;set;}
     public string error_message {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            error_code = br.ReadInt32();
error_message = StringUtil.Deserialize(br);
Type = TLAbsRpcErrorTypes.TLRpc_error;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(error_code);
StringUtil.Serialize(error_message,bw);

        }
    }
}
