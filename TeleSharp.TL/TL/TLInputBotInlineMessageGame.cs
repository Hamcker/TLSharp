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
	[TLObject(1262639204)]
    public class TLInputBotInlineMessageGame : TLAbsInputBotInlineMessage
    {
        public override int Constructor
        {
            get
            {
                return 1262639204;
            }
        }

             public int flags {get;set;}
     public TLAbsReplyMarkup reply_markup {get;set;}


		public void ComputeFlags()
		{
			flags = 0;
flags = reply_markup != null ? (flags | 4) : (flags & ~4);

		}

        public override void DeserializeBody(BinaryReader br)
        {
            flags = br.ReadInt32();
if ((flags & 4) != 0)
reply_markup = (TLAbsReplyMarkup)ObjectUtils.DeserializeObject(br);
else
reply_markup = null;

Type = TLAbsInputBotInlineMessageTypes.TLInputBotInlineMessageGame;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ComputeFlags();
bw.Write(flags);
if ((flags & 4) != 0)
ObjectUtils.SerializeObject(reply_markup,bw);

        }
    }
}
