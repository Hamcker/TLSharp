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
	[TLObject(-302170017)]
    public class TLAllStickers : TLAbsAllStickers
    {
        public override int Constructor
        {
            get
            {
                return -302170017;
            }
        }

             public int hash {get;set;}
     public TLVector<TLAbsStickerSet> sets {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            hash = br.ReadInt32();
sets = (TLVector<TLAbsStickerSet>)ObjectUtils.DeserializeVector<TLAbsStickerSet>(br);
Type = TLAbsAllStickersTypes.TLAllStickers;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(hash);
ObjectUtils.SerializeObject(sets,bw);

        }
    }
}
