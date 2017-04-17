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
	[TLObject(590459437)]
    public class TLPhotoEmpty : TLAbsPhoto
    {
        public override int Constructor
        {
            get
            {
                return 590459437;
            }
        }

             public long id {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            id = br.ReadInt64();
Type = TLAbsPhotoTypes.TLPhotoEmpty;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(id);

        }
    }
}
