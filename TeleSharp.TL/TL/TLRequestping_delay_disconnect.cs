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
	[TLObject(-213746804)]
    public class TLRequestPing_delay_disconnect : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return -213746804;
            }
        }

                public long ping_id {get;set;}
        public int disconnect_delay {get;set;}
        public TLAbsPong Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            ping_id = br.ReadInt64();
disconnect_delay = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(ping_id);
bw.Write(disconnect_delay);

        }
		public override void deserializeResponse(BinaryReader br)
		{
			Response = (TLAbsPong)ObjectUtils.DeserializeObject(br);

		}
    }
}
