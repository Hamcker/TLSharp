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
	[TLObject(164646985)]
    public class TLUserStatusEmpty : TLAbsUserStatus
    {
        public override int Constructor
        {
            get
            {
                return 164646985;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsUserStatusTypes.TLUserStatusEmpty;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
