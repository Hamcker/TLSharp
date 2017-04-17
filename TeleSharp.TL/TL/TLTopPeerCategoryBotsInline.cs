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
	[TLObject(344356834)]
    public class TLTopPeerCategoryBotsInline : TLAbsTopPeerCategory
    {
        public override int Constructor
        {
            get
            {
                return 344356834;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsTopPeerCategoryTypes.TLTopPeerCategoryBotsInline;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
