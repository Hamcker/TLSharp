using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsDialogsTypes
	{
		TLDialogs,TLDialogsSlice
	}

    public abstract class TLAbsDialogs : TLObject
    {
		public TLAbsDialogsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsDialogs
        {
            return this as T;
        }

		public TLDialogs ToTLDialogs()
		{
			return this as TLDialogs;
		}

		public TLDialogsSlice ToTLDialogsSlice()
		{
			return this as TLDialogsSlice;
		}

    }
}
