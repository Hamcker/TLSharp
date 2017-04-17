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
	[TLObject(2059302892)]
    public class TLRequestPing : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return 2059302892;
            }
        }

                public long ping_id {get;set;}
        public TLAbsPong Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            ping_id = br.ReadInt64();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(ping_id);

        }
		public override void deserializeResponse(BinaryReader br)
		{
			Response = (TLAbsPong)ObjectUtils.DeserializeObject(br);

		}
    }
}
