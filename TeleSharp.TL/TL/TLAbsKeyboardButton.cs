using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsKeyboardButtonTypes
	{
		TLKeyboardButton,TLKeyboardButtonUrl,TLKeyboardButtonCallback,TLKeyboardButtonRequestPhone,TLKeyboardButtonRequestGeoLocation,TLKeyboardButtonSwitchInline,TLKeyboardButtonGame
	}

    public abstract class TLAbsKeyboardButton : TLObject
    {
		public TLAbsKeyboardButtonTypes Type { get; set; } 

		public T To<T>() where T : TLAbsKeyboardButton
        {
            return this as T;
        }

		public TLKeyboardButton ToTLKeyboardButton()
		{
			return this as TLKeyboardButton;
		}

		public TLKeyboardButtonUrl ToTLKeyboardButtonUrl()
		{
			return this as TLKeyboardButtonUrl;
		}

		public TLKeyboardButtonCallback ToTLKeyboardButtonCallback()
		{
			return this as TLKeyboardButtonCallback;
		}

		public TLKeyboardButtonRequestPhone ToTLKeyboardButtonRequestPhone()
		{
			return this as TLKeyboardButtonRequestPhone;
		}

		public TLKeyboardButtonRequestGeoLocation ToTLKeyboardButtonRequestGeoLocation()
		{
			return this as TLKeyboardButtonRequestGeoLocation;
		}

		public TLKeyboardButtonSwitchInline ToTLKeyboardButtonSwitchInline()
		{
			return this as TLKeyboardButtonSwitchInline;
		}

		public TLKeyboardButtonGame ToTLKeyboardButtonGame()
		{
			return this as TLKeyboardButtonGame;
		}

    }
}
