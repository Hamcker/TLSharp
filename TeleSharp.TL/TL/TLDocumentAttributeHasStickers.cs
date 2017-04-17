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
	[TLObject(-1744710921)]
    public class TLDocumentAttributeHasStickers : TLAbsDocumentAttribute
    {
        public override int Constructor
        {
            get
            {
                return -1744710921;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsDocumentAttributeTypes.TLDocumentAttributeHasStickers;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
