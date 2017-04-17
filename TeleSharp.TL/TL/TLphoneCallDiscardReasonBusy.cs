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
	[TLObject(-84416311)]
    public class TLPhoneCallDiscardReasonBusy : TLAbsPhoneCallDiscardReason
    {
        public override int Constructor
        {
            get
            {
                return -84416311;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsPhoneCallDiscardReasonTypes.TLPhoneCallDiscardReasonBusy;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
