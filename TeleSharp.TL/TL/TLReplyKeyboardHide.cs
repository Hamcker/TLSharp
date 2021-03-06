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
	[TLObject(-1606526075)]
    public class TLReplyKeyboardHide : TLAbsReplyMarkup
    {
        public override int Constructor
        {
            get
            {
                return -1606526075;
            }
        }

             public int flags {get;set;}
     public bool selective {get;set;}


		public void ComputeFlags()
		{
			flags = 0;
flags = selective ? (flags | 4) : (flags & ~4);

		}

        public override void DeserializeBody(BinaryReader br)
        {
            flags = br.ReadInt32();
selective = (flags & 4) != 0;
Type = TLAbsReplyMarkupTypes.TLReplyKeyboardHide;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ComputeFlags();
bw.Write(flags);


        }
    }
}
