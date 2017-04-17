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
	[TLObject(-125240806)]
    public class TLPrivacyValueDisallowContacts : TLAbsPrivacyRule
    {
        public override int Constructor
        {
            get
            {
                return -125240806;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsPrivacyRuleTypes.TLPrivacyValueDisallowContacts;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
