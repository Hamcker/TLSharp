using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsChatsTypes
	{
		TLChats,TLChatsSlice
	}

    public abstract class TLAbsChats : TLObject
    {
		public TLAbsChatsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsChats
        {
            return this as T;
        }

		public TLChats ToTLChats()
		{
			return this as TLChats;
		}

		public TLChatsSlice ToTLChatsSlice()
		{
			return this as TLChatsSlice;
		}

    }
}
