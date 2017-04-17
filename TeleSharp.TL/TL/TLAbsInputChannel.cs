using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputChannelTypes
	{
		TLInputChannelEmpty,TLInputChannel
	}

    public abstract class TLAbsInputChannel : TLObject
    {
		public TLAbsInputChannelTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputChannel
        {
            return this as T;
        }

		public TLInputChannelEmpty ToTLInputChannelEmpty()
		{
			return this as TLInputChannelEmpty;
		}

		public TLInputChannel ToTLInputChannel()
		{
			return this as TLInputChannel;
		}

    }
}
