using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Updates
{
	public enum TLAbsChannelDifferenceTypes
	{
		TLChannelDifferenceEmpty,TLChannelDifferenceTooLong,TLChannelDifference
	}

    public abstract class TLAbsChannelDifference : TLObject
    {
		public TLAbsChannelDifferenceTypes Type { get; set; } 

		public T To<T>() where T : TLAbsChannelDifference
        {
            return this as T;
        }

		public TLChannelDifferenceEmpty ToTLChannelDifferenceEmpty()
		{
			return this as TLChannelDifferenceEmpty;
		}

		public TLChannelDifferenceTooLong ToTLChannelDifferenceTooLong()
		{
			return this as TLChannelDifferenceTooLong;
		}

		public TLChannelDifference ToTLChannelDifference()
		{
			return this as TLChannelDifference;
		}

    }
}
