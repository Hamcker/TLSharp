using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsDialogTypes
	{
		TLDialog
	}

    public abstract class TLAbsDialog : TLObject
    {
		public TLAbsDialogTypes Type { get; set; } 

		public T To<T>() where T : TLAbsDialog
        {
            return this as T;
        }

		public TLDialog ToTLDialog()
		{
			return this as TLDialog;
		}

    }
}
