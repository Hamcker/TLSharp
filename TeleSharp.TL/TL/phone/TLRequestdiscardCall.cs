using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;


namespace TeleSharp.TL.Phone
{
	[TLObject(1576783324)]
    public class TLRequestDiscardCall : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return 1576783324;
            }
        }

                public TLAbsInputPhoneCall peer {get;set;}
        public int duration {get;set;}
        public TLAbsPhoneCallDiscardReason reason {get;set;}
        public long connection_id {get;set;}
        public bool Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            peer = (TLAbsInputPhoneCall)ObjectUtils.DeserializeObject(br);
duration = br.ReadInt32();
reason = (TLAbsPhoneCallDiscardReason)ObjectUtils.DeserializeObject(br);
connection_id = br.ReadInt64();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(peer,bw);
bw.Write(duration);
ObjectUtils.SerializeObject(reason,bw);
bw.Write(connection_id);

        }
		public override void deserializeResponse(BinaryReader br)
		{
			Response = BoolUtil.Deserialize(br);

		}
    }
}
