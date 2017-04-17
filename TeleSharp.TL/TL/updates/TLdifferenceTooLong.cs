using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;

namespace TeleSharp.TL.Updates
{
	[TLObject(1258196845)]
    public class TLDifferenceTooLong : TLAbsDifference
    {
        public override int Constructor
        {
            get
            {
                return 1258196845;
            }
        }

             public int pts {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            pts = br.ReadInt32();
Type = TLAbsDifferenceTypes.TLDifferenceTooLong;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(pts);

        }
    }
}
