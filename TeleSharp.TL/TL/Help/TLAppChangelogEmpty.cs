using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;

namespace TeleSharp.TL.Help
{
	[TLObject(-1350696044)]
    public class TLAppChangelogEmpty : TLAbsAppChangelog
    {
        public override int Constructor
        {
            get
            {
                return -1350696044;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsAppChangelogTypes.TLAppChangelogEmpty;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
