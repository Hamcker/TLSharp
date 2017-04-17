using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsMessageEntityTypes
	{
		TLMessageEntityUnknown,TLMessageEntityMention,TLMessageEntityHashtag,TLMessageEntityBotCommand,TLMessageEntityUrl,TLMessageEntityEmail,TLMessageEntityBold,TLMessageEntityItalic,TLMessageEntityCode,TLMessageEntityPre,TLMessageEntityTextUrl,TLMessageEntityMentionName,TLInputMessageEntityMentionName
	}

    public abstract class TLAbsMessageEntity : TLObject
    {
		public TLAbsMessageEntityTypes Type { get; set; } 

		public T To<T>() where T : TLAbsMessageEntity
        {
            return this as T;
        }

		public TLMessageEntityUnknown ToTLMessageEntityUnknown()
		{
			return this as TLMessageEntityUnknown;
		}

		public TLMessageEntityMention ToTLMessageEntityMention()
		{
			return this as TLMessageEntityMention;
		}

		public TLMessageEntityHashtag ToTLMessageEntityHashtag()
		{
			return this as TLMessageEntityHashtag;
		}

		public TLMessageEntityBotCommand ToTLMessageEntityBotCommand()
		{
			return this as TLMessageEntityBotCommand;
		}

		public TLMessageEntityUrl ToTLMessageEntityUrl()
		{
			return this as TLMessageEntityUrl;
		}

		public TLMessageEntityEmail ToTLMessageEntityEmail()
		{
			return this as TLMessageEntityEmail;
		}

		public TLMessageEntityBold ToTLMessageEntityBold()
		{
			return this as TLMessageEntityBold;
		}

		public TLMessageEntityItalic ToTLMessageEntityItalic()
		{
			return this as TLMessageEntityItalic;
		}

		public TLMessageEntityCode ToTLMessageEntityCode()
		{
			return this as TLMessageEntityCode;
		}

		public TLMessageEntityPre ToTLMessageEntityPre()
		{
			return this as TLMessageEntityPre;
		}

		public TLMessageEntityTextUrl ToTLMessageEntityTextUrl()
		{
			return this as TLMessageEntityTextUrl;
		}

		public TLMessageEntityMentionName ToTLMessageEntityMentionName()
		{
			return this as TLMessageEntityMentionName;
		}

		public TLInputMessageEntityMentionName ToTLInputMessageEntityMentionName()
		{
			return this as TLInputMessageEntityMentionName;
		}

    }
}
