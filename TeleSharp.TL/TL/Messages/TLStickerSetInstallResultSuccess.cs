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
	[TLObject(946083368)]
    public class TLStickerSetInstallResultSuccess : TLAbsStickerSetInstallResult
    {
        public override int Constructor
        {
            get
            {
                return 946083368;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsStickerSetInstallResultTypes.TLStickerSetInstallResultSuccess;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
