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
	[TLObject(-1073693790)]
    public class TLSentCodeTypeSms : TLAbsSentCodeType
    {
        public override int Constructor
        {
            get
            {
                return -1073693790;
            }
        }

             public int length {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            length = br.ReadInt32();
Type = TLAbsSentCodeTypeTypes.TLSentCodeTypeSms;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(length);

        }
    }
}
