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
	[TLObject(2002815875)]
    public class TLKeyboardButtonRow : TLAbsKeyboardButtonRow
    {
        public override int Constructor
        {
            get
            {
                return 2002815875;
            }
        }

             public TLVector<TLAbsKeyboardButton> buttons {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            buttons = (TLVector<TLAbsKeyboardButton>)ObjectUtils.DeserializeVector<TLAbsKeyboardButton>(br);
Type = TLAbsKeyboardButtonRowTypes.TLKeyboardButtonRow;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(buttons,bw);

        }
    }
}
