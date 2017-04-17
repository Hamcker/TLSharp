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
	[TLObject(1753886890)]
    public class TLUpdateNewStickerSet : TLAbsUpdate
    {
        public override int Constructor
        {
            get
            {
                return 1753886890;
            }
        }

             public Messages.TLAbsStickerSet stickerset {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            stickerset = (Messages.TLAbsStickerSet)ObjectUtils.DeserializeObject(br);
Type = TLAbsUpdateTypes.TLUpdateNewStickerSet;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(stickerset,bw);

        }
    }
}
