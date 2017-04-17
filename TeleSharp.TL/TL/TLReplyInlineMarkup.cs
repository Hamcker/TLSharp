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
	[TLObject(1218642516)]
    public class TLReplyInlineMarkup : TLAbsReplyMarkup
    {
        public override int Constructor
        {
            get
            {
                return 1218642516;
            }
        }

             public TLVector<TLAbsKeyboardButtonRow> rows {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            rows = (TLVector<TLAbsKeyboardButtonRow>)ObjectUtils.DeserializeVector<TLAbsKeyboardButtonRow>(br);
Type = TLAbsReplyMarkupTypes.TLReplyInlineMarkup;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(rows,bw);

        }
    }
}
