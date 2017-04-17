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
	[TLObject(1868782349)]
    public class TLMessageEntityHashtag : TLAbsMessageEntity
    {
        public override int Constructor
        {
            get
            {
                return 1868782349;
            }
        }

             public int offset {get;set;}
     public int length {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            offset = br.ReadInt32();
length = br.ReadInt32();
Type = TLAbsMessageEntityTypes.TLMessageEntityHashtag;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(offset);
bw.Write(length);

        }
    }
}
