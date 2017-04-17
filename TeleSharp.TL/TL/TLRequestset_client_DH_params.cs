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
	[TLObject(-184262881)]
    public class TLRequestSet_client_DH_params : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return -184262881;
            }
        }

                public Int128 nonce {get;set;}
        public Int128 server_nonce {get;set;}
        public string encrypted_data {get;set;}
        public TLAbsSet_client_DH_params_answer Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            nonce = (Int128)ObjectUtils.DeserializeObject(br);
server_nonce = (Int128)ObjectUtils.DeserializeObject(br);
encrypted_data = StringUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(nonce,bw);
ObjectUtils.SerializeObject(server_nonce,bw);
StringUtil.Serialize(encrypted_data,bw);

        }
		public override void deserializeResponse(BinaryReader br)
		{
			Response = (TLAbsSet_client_DH_params_answer)ObjectUtils.DeserializeObject(br);

		}
    }
}
