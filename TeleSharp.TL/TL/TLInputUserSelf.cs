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
	[TLObject(-138301121)]
    public class TLInputUserSelf : TLAbsInputUser
    {
        public override int Constructor
        {
            get
            {
                return -138301121;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsInputUserTypes.TLInputUserSelf;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
