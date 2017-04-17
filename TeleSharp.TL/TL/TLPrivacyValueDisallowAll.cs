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
	[TLObject(-1955338397)]
    public class TLPrivacyValueDisallowAll : TLAbsPrivacyRule
    {
        public override int Constructor
        {
            get
            {
                return -1955338397;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsPrivacyRuleTypes.TLPrivacyValueDisallowAll;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
