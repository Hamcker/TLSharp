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
	[TLObject(1003222836)]
    public class TLDh_gen_ok : TLAbsSet_client_DH_params_answer
    {
        public override int Constructor
        {
            get
            {
                return 1003222836;
            }
        }

             public Int128 nonce {get;set;}
     public Int128 server_nonce {get;set;}
     public Int128 new_nonce_hash1 {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            nonce = (Int128)ObjectUtils.DeserializeObject(br);
server_nonce = (Int128)ObjectUtils.DeserializeObject(br);
new_nonce_hash1 = (Int128)ObjectUtils.DeserializeObject(br);
Type = TLAbsSet_client_DH_params_answerTypes.TLDh_gen_ok;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(nonce,bw);
ObjectUtils.SerializeObject(server_nonce,bw);
ObjectUtils.SerializeObject(new_nonce_hash1,bw);

        }
    }
}
