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
	[TLObject(1490799288)]
    public class TLInputReportReasonSpam : TLAbsReportReason
    {
        public override int Constructor
        {
            get
            {
                return 1490799288;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsReportReasonTypes.TLInputReportReasonSpam;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
