using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsUpdateTypes
	{
		TLUpdateNewMessage,TLUpdateMessageID,TLUpdateDeleteMessages,TLUpdateUserTyping,TLUpdateChatUserTyping,TLUpdateChatParticipants,TLUpdateUserStatus,TLUpdateUserName,TLUpdateUserPhoto,TLUpdateContactRegistered,TLUpdateContactLink,TLUpdateNewEncryptedMessage,TLUpdateEncryptedChatTyping,TLUpdateEncryption,TLUpdateEncryptedMessagesRead,TLUpdateChatParticipantAdd,TLUpdateChatParticipantDelete,TLUpdateDcOptions,TLUpdateUserBlocked,TLUpdateNotifySettings,TLUpdateServiceNotification,TLUpdatePrivacy,TLUpdateUserPhone,TLUpdateReadHistoryInbox,TLUpdateReadHistoryOutbox,TLUpdateWebPage,TLUpdateReadMessagesContents,TLUpdateChannelTooLong,TLUpdateChannel,TLUpdateNewChannelMessage,TLUpdateReadChannelInbox,TLUpdateDeleteChannelMessages,TLUpdateChannelMessageViews,TLUpdateChatAdmins,TLUpdateChatParticipantAdmin,TLUpdateNewStickerSet,TLUpdateStickerSetsOrder,TLUpdateStickerSets,TLUpdateSavedGifs,TLUpdateBotInlineQuery,TLUpdateBotInlineSend,TLUpdateEditChannelMessage,TLUpdateChannelPinnedMessage,TLUpdateBotCallbackQuery,TLUpdateEditMessage,TLUpdateInlineBotCallbackQuery,TLUpdateReadChannelOutbox,TLUpdateDraftMessage,TLUpdateReadFeaturedStickers,TLUpdateRecentStickers,TLUpdateConfig,TLUpdatePtsChanged,TLUpdateChannelWebPage,TLUpdatePhoneCall,TLUpdateDialogPinned,TLUpdatePinnedDialogs
	}

    public abstract class TLAbsUpdate : TLObject
    {
		public TLAbsUpdateTypes Type { get; set; } 

		public T To<T>() where T : TLAbsUpdate
        {
            return this as T;
        }

		public TLUpdateNewMessage ToTLUpdateNewMessage()
		{
			return this as TLUpdateNewMessage;
		}

		public TLUpdateMessageID ToTLUpdateMessageID()
		{
			return this as TLUpdateMessageID;
		}

		public TLUpdateDeleteMessages ToTLUpdateDeleteMessages()
		{
			return this as TLUpdateDeleteMessages;
		}

		public TLUpdateUserTyping ToTLUpdateUserTyping()
		{
			return this as TLUpdateUserTyping;
		}

		public TLUpdateChatUserTyping ToTLUpdateChatUserTyping()
		{
			return this as TLUpdateChatUserTyping;
		}

		public TLUpdateChatParticipants ToTLUpdateChatParticipants()
		{
			return this as TLUpdateChatParticipants;
		}

		public TLUpdateUserStatus ToTLUpdateUserStatus()
		{
			return this as TLUpdateUserStatus;
		}

		public TLUpdateUserName ToTLUpdateUserName()
		{
			return this as TLUpdateUserName;
		}

		public TLUpdateUserPhoto ToTLUpdateUserPhoto()
		{
			return this as TLUpdateUserPhoto;
		}

		public TLUpdateContactRegistered ToTLUpdateContactRegistered()
		{
			return this as TLUpdateContactRegistered;
		}

		public TLUpdateContactLink ToTLUpdateContactLink()
		{
			return this as TLUpdateContactLink;
		}

		public TLUpdateNewEncryptedMessage ToTLUpdateNewEncryptedMessage()
		{
			return this as TLUpdateNewEncryptedMessage;
		}

		public TLUpdateEncryptedChatTyping ToTLUpdateEncryptedChatTyping()
		{
			return this as TLUpdateEncryptedChatTyping;
		}

		public TLUpdateEncryption ToTLUpdateEncryption()
		{
			return this as TLUpdateEncryption;
		}

		public TLUpdateEncryptedMessagesRead ToTLUpdateEncryptedMessagesRead()
		{
			return this as TLUpdateEncryptedMessagesRead;
		}

		public TLUpdateChatParticipantAdd ToTLUpdateChatParticipantAdd()
		{
			return this as TLUpdateChatParticipantAdd;
		}

		public TLUpdateChatParticipantDelete ToTLUpdateChatParticipantDelete()
		{
			return this as TLUpdateChatParticipantDelete;
		}

		public TLUpdateDcOptions ToTLUpdateDcOptions()
		{
			return this as TLUpdateDcOptions;
		}

		public TLUpdateUserBlocked ToTLUpdateUserBlocked()
		{
			return this as TLUpdateUserBlocked;
		}

		public TLUpdateNotifySettings ToTLUpdateNotifySettings()
		{
			return this as TLUpdateNotifySettings;
		}

		public TLUpdateServiceNotification ToTLUpdateServiceNotification()
		{
			return this as TLUpdateServiceNotification;
		}

		public TLUpdatePrivacy ToTLUpdatePrivacy()
		{
			return this as TLUpdatePrivacy;
		}

		public TLUpdateUserPhone ToTLUpdateUserPhone()
		{
			return this as TLUpdateUserPhone;
		}

		public TLUpdateReadHistoryInbox ToTLUpdateReadHistoryInbox()
		{
			return this as TLUpdateReadHistoryInbox;
		}

		public TLUpdateReadHistoryOutbox ToTLUpdateReadHistoryOutbox()
		{
			return this as TLUpdateReadHistoryOutbox;
		}

		public TLUpdateWebPage ToTLUpdateWebPage()
		{
			return this as TLUpdateWebPage;
		}

		public TLUpdateReadMessagesContents ToTLUpdateReadMessagesContents()
		{
			return this as TLUpdateReadMessagesContents;
		}

		public TLUpdateChannelTooLong ToTLUpdateChannelTooLong()
		{
			return this as TLUpdateChannelTooLong;
		}

		public TLUpdateChannel ToTLUpdateChannel()
		{
			return this as TLUpdateChannel;
		}

		public TLUpdateNewChannelMessage ToTLUpdateNewChannelMessage()
		{
			return this as TLUpdateNewChannelMessage;
		}

		public TLUpdateReadChannelInbox ToTLUpdateReadChannelInbox()
		{
			return this as TLUpdateReadChannelInbox;
		}

		public TLUpdateDeleteChannelMessages ToTLUpdateDeleteChannelMessages()
		{
			return this as TLUpdateDeleteChannelMessages;
		}

		public TLUpdateChannelMessageViews ToTLUpdateChannelMessageViews()
		{
			return this as TLUpdateChannelMessageViews;
		}

		public TLUpdateChatAdmins ToTLUpdateChatAdmins()
		{
			return this as TLUpdateChatAdmins;
		}

		public TLUpdateChatParticipantAdmin ToTLUpdateChatParticipantAdmin()
		{
			return this as TLUpdateChatParticipantAdmin;
		}

		public TLUpdateNewStickerSet ToTLUpdateNewStickerSet()
		{
			return this as TLUpdateNewStickerSet;
		}

		public TLUpdateStickerSetsOrder ToTLUpdateStickerSetsOrder()
		{
			return this as TLUpdateStickerSetsOrder;
		}

		public TLUpdateStickerSets ToTLUpdateStickerSets()
		{
			return this as TLUpdateStickerSets;
		}

		public TLUpdateSavedGifs ToTLUpdateSavedGifs()
		{
			return this as TLUpdateSavedGifs;
		}

		public TLUpdateBotInlineQuery ToTLUpdateBotInlineQuery()
		{
			return this as TLUpdateBotInlineQuery;
		}

		public TLUpdateBotInlineSend ToTLUpdateBotInlineSend()
		{
			return this as TLUpdateBotInlineSend;
		}

		public TLUpdateEditChannelMessage ToTLUpdateEditChannelMessage()
		{
			return this as TLUpdateEditChannelMessage;
		}

		public TLUpdateChannelPinnedMessage ToTLUpdateChannelPinnedMessage()
		{
			return this as TLUpdateChannelPinnedMessage;
		}

		public TLUpdateBotCallbackQuery ToTLUpdateBotCallbackQuery()
		{
			return this as TLUpdateBotCallbackQuery;
		}

		public TLUpdateEditMessage ToTLUpdateEditMessage()
		{
			return this as TLUpdateEditMessage;
		}

		public TLUpdateInlineBotCallbackQuery ToTLUpdateInlineBotCallbackQuery()
		{
			return this as TLUpdateInlineBotCallbackQuery;
		}

		public TLUpdateReadChannelOutbox ToTLUpdateReadChannelOutbox()
		{
			return this as TLUpdateReadChannelOutbox;
		}

		public TLUpdateDraftMessage ToTLUpdateDraftMessage()
		{
			return this as TLUpdateDraftMessage;
		}

		public TLUpdateReadFeaturedStickers ToTLUpdateReadFeaturedStickers()
		{
			return this as TLUpdateReadFeaturedStickers;
		}

		public TLUpdateRecentStickers ToTLUpdateRecentStickers()
		{
			return this as TLUpdateRecentStickers;
		}

		public TLUpdateConfig ToTLUpdateConfig()
		{
			return this as TLUpdateConfig;
		}

		public TLUpdatePtsChanged ToTLUpdatePtsChanged()
		{
			return this as TLUpdatePtsChanged;
		}

		public TLUpdateChannelWebPage ToTLUpdateChannelWebPage()
		{
			return this as TLUpdateChannelWebPage;
		}

		public TLUpdatePhoneCall ToTLUpdatePhoneCall()
		{
			return this as TLUpdatePhoneCall;
		}

		public TLUpdateDialogPinned ToTLUpdateDialogPinned()
		{
			return this as TLUpdateDialogPinned;
		}

		public TLUpdatePinnedDialogs ToTLUpdatePinnedDialogs()
		{
			return this as TLUpdatePinnedDialogs;
		}

    }
}
