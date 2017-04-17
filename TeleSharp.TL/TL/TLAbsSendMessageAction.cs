using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsSendMessageActionTypes
	{
		TLSendMessageTypingAction,TLSendMessageCancelAction,TLSendMessageRecordVideoAction,TLSendMessageUploadVideoAction,TLSendMessageRecordAudioAction,TLSendMessageUploadAudioAction,TLSendMessageUploadPhotoAction,TLSendMessageUploadDocumentAction,TLSendMessageGeoLocationAction,TLSendMessageChooseContactAction,TLSendMessageGamePlayAction
	}

    public abstract class TLAbsSendMessageAction : TLObject
    {
		public TLAbsSendMessageActionTypes Type { get; set; } 

		public T To<T>() where T : TLAbsSendMessageAction
        {
            return this as T;
        }

		public TLSendMessageTypingAction ToTLSendMessageTypingAction()
		{
			return this as TLSendMessageTypingAction;
		}

		public TLSendMessageCancelAction ToTLSendMessageCancelAction()
		{
			return this as TLSendMessageCancelAction;
		}

		public TLSendMessageRecordVideoAction ToTLSendMessageRecordVideoAction()
		{
			return this as TLSendMessageRecordVideoAction;
		}

		public TLSendMessageUploadVideoAction ToTLSendMessageUploadVideoAction()
		{
			return this as TLSendMessageUploadVideoAction;
		}

		public TLSendMessageRecordAudioAction ToTLSendMessageRecordAudioAction()
		{
			return this as TLSendMessageRecordAudioAction;
		}

		public TLSendMessageUploadAudioAction ToTLSendMessageUploadAudioAction()
		{
			return this as TLSendMessageUploadAudioAction;
		}

		public TLSendMessageUploadPhotoAction ToTLSendMessageUploadPhotoAction()
		{
			return this as TLSendMessageUploadPhotoAction;
		}

		public TLSendMessageUploadDocumentAction ToTLSendMessageUploadDocumentAction()
		{
			return this as TLSendMessageUploadDocumentAction;
		}

		public TLSendMessageGeoLocationAction ToTLSendMessageGeoLocationAction()
		{
			return this as TLSendMessageGeoLocationAction;
		}

		public TLSendMessageChooseContactAction ToTLSendMessageChooseContactAction()
		{
			return this as TLSendMessageChooseContactAction;
		}

		public TLSendMessageGamePlayAction ToTLSendMessageGamePlayAction()
		{
			return this as TLSendMessageGamePlayAction;
		}

    }
}
