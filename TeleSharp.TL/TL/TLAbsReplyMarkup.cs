using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsReplyMarkupTypes
	{
		TLReplyKeyboardHide,TLReplyKeyboardForceReply,TLReplyKeyboardMarkup,TLReplyInlineMarkup
	}

    public abstract class TLAbsReplyMarkup : TLObject
    {
		public TLAbsReplyMarkupTypes Type { get; set; } 

		public T To<T>() where T : TLAbsReplyMarkup
        {
            return this as T;
        }

		public TLReplyKeyboardHide ToTLReplyKeyboardHide()
		{
			return this as TLReplyKeyboardHide;
		}

		public TLReplyKeyboardForceReply ToTLReplyKeyboardForceReply()
		{
			return this as TLReplyKeyboardForceReply;
		}

		public TLReplyKeyboardMarkup ToTLReplyKeyboardMarkup()
		{
			return this as TLReplyKeyboardMarkup;
		}

		public TLReplyInlineMarkup ToTLReplyInlineMarkup()
		{
			return this as TLReplyInlineMarkup;
		}

    }
}
