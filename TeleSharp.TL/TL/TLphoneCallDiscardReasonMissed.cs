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
	[TLObject(-2048646399)]
    public class TLPhoneCallDiscardReasonMissed : TLAbsPhoneCallDiscardReason
    {
        public override int Constructor
        {
            get
            {
                return -2048646399;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsPhoneCallDiscardReasonTypes.TLPhoneCallDiscardReasonMissed;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
