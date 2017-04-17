using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsKeyboardButtonRowTypes
	{
		TLKeyboardButtonRow
	}

    public abstract class TLAbsKeyboardButtonRow : TLObject
    {
		public TLAbsKeyboardButtonRowTypes Type { get; set; } 

		public T To<T>() where T : TLAbsKeyboardButtonRow
        {
            return this as T;
        }

		public TLKeyboardButtonRow ToTLKeyboardButtonRow()
		{
			return this as TLKeyboardButtonRow;
		}

    }
}
