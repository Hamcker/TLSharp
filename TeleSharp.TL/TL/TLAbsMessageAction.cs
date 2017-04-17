using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsMessageActionTypes
	{
		TLMessageActionEmpty,TLMessageActionChatCreate,TLMessageActionChatEditTitle,TLMessageActionChatEditPhoto,TLMessageActionChatDeletePhoto,TLMessageActionChatAddUser,TLMessageActionChatDeleteUser,TLMessageActionChatJoinedByLink,TLMessageActionChannelCreate,TLMessageActionChatMigrateTo,TLMessageActionChannelMigrateFrom,TLMessageActionPinMessage,TLMessageActionHistoryClear,TLMessageActionGameScore,TLMessageActionPhoneCall
	}

    public abstract class TLAbsMessageAction : TLObject
    {
		public TLAbsMessageActionTypes Type { get; set; } 

		public T To<T>() where T : TLAbsMessageAction
        {
            return this as T;
        }

		public TLMessageActionEmpty ToTLMessageActionEmpty()
		{
			return this as TLMessageActionEmpty;
		}

		public TLMessageActionChatCreate ToTLMessageActionChatCreate()
		{
			return this as TLMessageActionChatCreate;
		}

		public TLMessageActionChatEditTitle ToTLMessageActionChatEditTitle()
		{
			return this as TLMessageActionChatEditTitle;
		}

		public TLMessageActionChatEditPhoto ToTLMessageActionChatEditPhoto()
		{
			return this as TLMessageActionChatEditPhoto;
		}

		public TLMessageActionChatDeletePhoto ToTLMessageActionChatDeletePhoto()
		{
			return this as TLMessageActionChatDeletePhoto;
		}

		public TLMessageActionChatAddUser ToTLMessageActionChatAddUser()
		{
			return this as TLMessageActionChatAddUser;
		}

		public TLMessageActionChatDeleteUser ToTLMessageActionChatDeleteUser()
		{
			return this as TLMessageActionChatDeleteUser;
		}

		public TLMessageActionChatJoinedByLink ToTLMessageActionChatJoinedByLink()
		{
			return this as TLMessageActionChatJoinedByLink;
		}

		public TLMessageActionChannelCreate ToTLMessageActionChannelCreate()
		{
			return this as TLMessageActionChannelCreate;
		}

		public TLMessageActionChatMigrateTo ToTLMessageActionChatMigrateTo()
		{
			return this as TLMessageActionChatMigrateTo;
		}

		public TLMessageActionChannelMigrateFrom ToTLMessageActionChannelMigrateFrom()
		{
			return this as TLMessageActionChannelMigrateFrom;
		}

		public TLMessageActionPinMessage ToTLMessageActionPinMessage()
		{
			return this as TLMessageActionPinMessage;
		}

		public TLMessageActionHistoryClear ToTLMessageActionHistoryClear()
		{
			return this as TLMessageActionHistoryClear;
		}

		public TLMessageActionGameScore ToTLMessageActionGameScore()
		{
			return this as TLMessageActionGameScore;
		}

		public TLMessageActionPhoneCall ToTLMessageActionPhoneCall()
		{
			return this as TLMessageActionPhoneCall;
		}

    }
}
