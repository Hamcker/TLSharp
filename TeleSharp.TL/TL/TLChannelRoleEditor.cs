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
	[TLObject(-2113143156)]
    public class TLChannelRoleEditor : TLAbsChannelParticipantRole
    {
        public override int Constructor
        {
            get
            {
                return -2113143156;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsChannelParticipantRoleTypes.TLChannelRoleEditor;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
