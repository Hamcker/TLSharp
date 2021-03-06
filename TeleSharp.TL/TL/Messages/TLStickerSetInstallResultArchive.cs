using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;

namespace TeleSharp.TL.Messages
{
	[TLObject(904138920)]
    public class TLStickerSetInstallResultArchive : TLAbsStickerSetInstallResult
    {
        public override int Constructor
        {
            get
            {
                return 904138920;
            }
        }

             public TLVector<TLAbsStickerSetCovered> sets {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            sets = (TLVector<TLAbsStickerSetCovered>)ObjectUtils.DeserializeVector<TLAbsStickerSetCovered>(br);
Type = TLAbsStickerSetInstallResultTypes.TLStickerSetInstallResultArchive;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(sets,bw);

        }
    }
}
