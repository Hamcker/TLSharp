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
	[TLObject(-402498398)]
    public class TLSavedGifsNotModified : TLAbsSavedGifs
    {
        public override int Constructor
        {
            get
            {
                return -402498398;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsSavedGifsTypes.TLSavedGifsNotModified;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
