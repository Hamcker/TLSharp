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
	[TLObject(297109817)]
    public class TLDocumentAttributeAnimated : TLAbsDocumentAttribute
    {
        public override int Constructor
        {
            get
            {
                return 297109817;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsDocumentAttributeTypes.TLDocumentAttributeAnimated;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
