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
	[TLObject(-1268741783)]
    public class TLChannelParticipantsAdmins : TLAbsChannelParticipantsFilter
    {
        public override int Constructor
        {
            get
            {
                return -1268741783;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsChannelParticipantsFilterTypes.TLChannelParticipantsAdmins;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
