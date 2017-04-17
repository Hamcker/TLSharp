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
	[TLObject(195371015)]
    public class TLInputPrivacyValueDisallowContacts : TLAbsInputPrivacyRule
    {
        public override int Constructor
        {
            get
            {
                return 195371015;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsInputPrivacyRuleTypes.TLInputPrivacyValueDisallowContacts;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
