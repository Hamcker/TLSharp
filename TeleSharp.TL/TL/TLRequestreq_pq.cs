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
	[TLObject(1615239032)]
    public class TLRequestReq_pq : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return 1615239032;
            }
        }

                public Int128 nonce {get;set;}
        public TLAbsResPQ Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            nonce = (Int128)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(nonce,bw);

        }
		public override void deserializeResponse(BinaryReader br)
		{
			Response = (TLAbsResPQ)ObjectUtils.DeserializeObject(br);

		}
    }
}
