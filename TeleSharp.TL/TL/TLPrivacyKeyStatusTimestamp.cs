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
	[TLObject(-1137792208)]
    public class TLPrivacyKeyStatusTimestamp : TLAbsPrivacyKey
    {
        public override int Constructor
        {
            get
            {
                return -1137792208;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsPrivacyKeyTypes.TLPrivacyKeyStatusTimestamp;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
