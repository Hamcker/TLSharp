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
	[TLObject(1326562017)]
    public class TLUserProfilePhotoEmpty : TLAbsUserProfilePhoto
    {
        public override int Constructor
        {
            get
            {
                return 1326562017;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsUserProfilePhotoTypes.TLUserProfilePhotoEmpty;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
