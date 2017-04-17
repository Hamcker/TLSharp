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
	[TLObject(324435594)]
    public class TLPageBlockUnsupported : TLAbsPageBlock
    {
        public override int Constructor
        {
            get
            {
                return 324435594;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsPageBlockTypes.TLPageBlockUnsupported;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
