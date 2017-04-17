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
	[TLObject(2043348061)]
    public class TLServer_DH_params_fail : TLAbsServer_DH_Params
    {
        public override int Constructor
        {
            get
            {
                return 2043348061;
            }
        }

             public Int128 nonce {get;set;}
     public Int128 server_nonce {get;set;}
     public Int128 new_nonce_hash {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            nonce = (Int128)ObjectUtils.DeserializeObject(br);
server_nonce = (Int128)ObjectUtils.DeserializeObject(br);
new_nonce_hash = (Int128)ObjectUtils.DeserializeObject(br);
Type = TLAbsServer_DH_ParamsTypes.TLServer_DH_params_fail;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(nonce,bw);
ObjectUtils.SerializeObject(server_nonce,bw);
ObjectUtils.SerializeObject(new_nonce_hash,bw);

        }
    }
}
