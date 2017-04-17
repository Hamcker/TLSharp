using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsRichTextTypes
	{
		TLTextEmpty,TLTextPlain,TLTextBold,TLTextItalic,TLTextUnderline,TLTextStrike,TLTextFixed,TLTextUrl,TLTextEmail,TLTextConcat
	}

    public abstract class TLAbsRichText : TLObject
    {
		public TLAbsRichTextTypes Type { get; set; } 

		public T To<T>() where T : TLAbsRichText
        {
            return this as T;
        }

		public TLTextEmpty ToTLTextEmpty()
		{
			return this as TLTextEmpty;
		}

		public TLTextPlain ToTLTextPlain()
		{
			return this as TLTextPlain;
		}

		public TLTextBold ToTLTextBold()
		{
			return this as TLTextBold;
		}

		public TLTextItalic ToTLTextItalic()
		{
			return this as TLTextItalic;
		}

		public TLTextUnderline ToTLTextUnderline()
		{
			return this as TLTextUnderline;
		}

		public TLTextStrike ToTLTextStrike()
		{
			return this as TLTextStrike;
		}

		public TLTextFixed ToTLTextFixed()
		{
			return this as TLTextFixed;
		}

		public TLTextUrl ToTLTextUrl()
		{
			return this as TLTextUrl;
		}

		public TLTextEmail ToTLTextEmail()
		{
			return this as TLTextEmail;
		}

		public TLTextConcat ToTLTextConcat()
		{
			return this as TLTextConcat;
		}

    }
}
