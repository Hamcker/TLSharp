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
	[TLObject(-2083955988)]
    public class TLP_q_inner_data : TLAbsP_Q_inner_data
    {
        public override int Constructor
        {
            get
            {
                return -2083955988;
            }
        }

             public string pq {get;set;}
     public string p {get;set;}
     public string q {get;set;}
     public Int128 nonce {get;set;}
     public Int128 server_nonce {get;set;}
     public Int256 new_nonce {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            pq = StringUtil.Deserialize(br);
p = StringUtil.Deserialize(br);
q = StringUtil.Deserialize(br);
nonce = (Int128)ObjectUtils.DeserializeObject(br);
server_nonce = (Int128)ObjectUtils.DeserializeObject(br);
new_nonce = (Int256)ObjectUtils.DeserializeObject(br);
Type = TLAbsP_Q_inner_dataTypes.TLP_q_inner_data;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            StringUtil.Serialize(pq,bw);
StringUtil.Serialize(p,bw);
StringUtil.Serialize(q,bw);
ObjectUtils.SerializeObject(nonce,bw);
ObjectUtils.SerializeObject(server_nonce,bw);
ObjectUtils.SerializeObject(new_nonce,bw);

        }
    }
}
