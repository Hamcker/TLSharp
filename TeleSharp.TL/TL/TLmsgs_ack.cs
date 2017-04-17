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
	[TLObject(1658238041)]
    public class TLMsgs_ack : TLAbsMsgsAck
    {
        public override int Constructor
        {
            get
            {
                return 1658238041;
            }
        }

             public TLVector<long> msg_ids {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            msg_ids = (TLVector<long>)ObjectUtils.DeserializeVector<long>(br);
Type = TLAbsMsgsAckTypes.TLMsgs_ack;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(msg_ids,bw);

        }
    }
}
