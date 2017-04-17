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
	[TLObject(313694676)]
    public class TLStickerPack : TLAbsStickerPack
    {
        public override int Constructor
        {
            get
            {
                return 313694676;
            }
        }

             public string emoticon {get;set;}
     public TLVector<long> documents {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            emoticon = StringUtil.Deserialize(br);
documents = (TLVector<long>)ObjectUtils.DeserializeVector<long>(br);
Type = TLAbsStickerPackTypes.TLStickerPack;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            StringUtil.Serialize(emoticon,bw);
ObjectUtils.SerializeObject(documents,bw);

        }
    }
}
