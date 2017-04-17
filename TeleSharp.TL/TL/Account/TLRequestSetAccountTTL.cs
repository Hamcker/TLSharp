using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;


namespace TeleSharp.TL.Account
{
	[TLObject(608323678)]
    public class TLRequestSetAccountTTL : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return 608323678;
            }
        }

                public TLAbsAccountDaysTTL ttl {get;set;}
        public bool Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            ttl = (TLAbsAccountDaysTTL)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(ttl,bw);

        }
		public override void deserializeResponse(BinaryReader br)
		{
			Response = BoolUtil.Deserialize(br);

		}
    }
}
