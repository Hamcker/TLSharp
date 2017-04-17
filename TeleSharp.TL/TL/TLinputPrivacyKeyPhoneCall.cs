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
	[TLObject(-88417185)]
    public class TLInputPrivacyKeyPhoneCall : TLAbsInputPrivacyKey
    {
        public override int Constructor
        {
            get
            {
                return -88417185;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsInputPrivacyKeyTypes.TLInputPrivacyKeyPhoneCall;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
