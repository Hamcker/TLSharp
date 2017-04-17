using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;

namespace TeleSharp.TL.Auth
{
	[TLObject(1948046307)]
    public class TLCodeTypeCall : TLAbsCodeType
    {
        public override int Constructor
        {
            get
            {
                return 1948046307;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsCodeTypeTypes.TLCodeTypeCall;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
