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
	[TLObject(972174080)]
    public class TLPageBlockCover : TLAbsPageBlock
    {
        public override int Constructor
        {
            get
            {
                return 972174080;
            }
        }

             public TLAbsPageBlock cover {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            cover = (TLAbsPageBlock)ObjectUtils.DeserializeObject(br);
Type = TLAbsPageBlockTypes.TLPageBlockCover;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(cover,bw);

        }
    }
}
