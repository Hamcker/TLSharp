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
	[TLObject(-790100132)]
    public class TLServer_DH_params_ok : TLAbsServer_DH_Params
    {
        public override int Constructor
        {
            get
            {
                return -790100132;
            }
        }

             public Int128 nonce {get;set;}
     public Int128 server_nonce {get;set;}
     public string encrypted_answer {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            nonce = (Int128)ObjectUtils.DeserializeObject(br);
server_nonce = (Int128)ObjectUtils.DeserializeObject(br);
encrypted_answer = StringUtil.Deserialize(br);
Type = TLAbsServer_DH_ParamsTypes.TLServer_DH_params_ok;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(nonce,bw);
ObjectUtils.SerializeObject(server_nonce,bw);
StringUtil.Serialize(encrypted_answer,bw);

        }
    }
}
