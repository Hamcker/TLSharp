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
	[TLObject(218751099)]
    public class TLInputPrivacyValueAllowContacts : TLAbsInputPrivacyRule
    {
        public override int Constructor
        {
            get
            {
                return 218751099;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsInputPrivacyRuleTypes.TLInputPrivacyValueAllowContacts;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
