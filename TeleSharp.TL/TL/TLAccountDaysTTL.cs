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
	[TLObject(-1194283041)]
    public class TLAccountDaysTTL : TLAbsAccountDaysTTL
    {
        public override int Constructor
        {
            get
            {
                return -1194283041;
            }
        }

             public int days {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            days = br.ReadInt32();
Type = TLAbsAccountDaysTTLTypes.TLAccountDaysTTL;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(days);

        }
    }
}
