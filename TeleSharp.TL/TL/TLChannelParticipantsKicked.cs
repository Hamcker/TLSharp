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
	[TLObject(1010285434)]
    public class TLChannelParticipantsKicked : TLAbsChannelParticipantsFilter
    {
        public override int Constructor
        {
            get
            {
                return 1010285434;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsChannelParticipantsFilterTypes.TLChannelParticipantsKicked;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
