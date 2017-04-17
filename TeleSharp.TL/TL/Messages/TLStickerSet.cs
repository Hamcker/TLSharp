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
	[TLObject(-1240849242)]
    public class TLStickerSet : TLAbsStickerSet
    {
        public override int Constructor
        {
            get
            {
                return -1240849242;
            }
        }

             public TLAbsStickerSet @set {get;set;}
     public TLVector<TLAbsStickerPack> packs {get;set;}
     public TLVector<TLAbsDocument> documents {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            @set = (TLAbsStickerSet)ObjectUtils.DeserializeObject(br);
packs = (TLVector<TLAbsStickerPack>)ObjectUtils.DeserializeVector<TLAbsStickerPack>(br);
documents = (TLVector<TLAbsDocument>)ObjectUtils.DeserializeVector<TLAbsDocument>(br);
Type = TLAbsStickerSetTypes.TLStickerSet;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(@set,bw);
ObjectUtils.SerializeObject(packs,bw);
ObjectUtils.SerializeObject(documents,bw);

        }
    }
}
