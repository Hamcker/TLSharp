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
	[TLObject(-527056480)]
    public class TLPhoneCallDiscardReasonDisconnect : TLAbsPhoneCallDiscardReason
    {
        public override int Constructor
        {
            get
            {
                return -527056480;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsPhoneCallDiscardReasonTypes.TLPhoneCallDiscardReasonDisconnect;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
