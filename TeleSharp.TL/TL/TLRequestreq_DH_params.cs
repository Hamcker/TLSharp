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
	[TLObject(-686627650)]
    public class TLRequestReq_DH_params : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return -686627650;
            }
        }

                public Int128 nonce {get;set;}
        public Int128 server_nonce {get;set;}
        public string p {get;set;}
        public string q {get;set;}
        public long public_key_fingerprint {get;set;}
        public string encrypted_data {get;set;}
        public TLAbsServer_DH_Params Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            nonce = (Int128)ObjectUtils.DeserializeObject(br);
server_nonce = (Int128)ObjectUtils.DeserializeObject(br);
p = StringUtil.Deserialize(br);
q = StringUtil.Deserialize(br);
public_key_fingerprint = br.ReadInt64();
encrypted_data = StringUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(nonce,bw);
ObjectUtils.SerializeObject(server_nonce,bw);
StringUtil.Serialize(p,bw);
StringUtil.Serialize(q,bw);
bw.Write(public_key_fingerprint);
StringUtil.Serialize(encrypted_data,bw);

        }
		public override void deserializeResponse(BinaryReader br)
		{
			Response = (TLAbsServer_DH_Params)ObjectUtils.DeserializeObject(br);

		}
    }
}
