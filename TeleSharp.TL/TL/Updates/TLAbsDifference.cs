using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Updates
{
	public enum TLAbsDifferenceTypes
	{
		TLDifferenceEmpty,TLDifference,TLDifferenceSlice,TLDifferenceTooLong
	}

    public abstract class TLAbsDifference : TLObject
    {
		public TLAbsDifferenceTypes Type { get; set; } 

		public T To<T>() where T : TLAbsDifference
        {
            return this as T;
        }

		public TLDifferenceEmpty ToTLDifferenceEmpty()
		{
			return this as TLDifferenceEmpty;
		}

		public TLDifference ToTLDifference()
		{
			return this as TLDifference;
		}

		public TLDifferenceSlice ToTLDifferenceSlice()
		{
			return this as TLDifferenceSlice;
		}

		public TLDifferenceTooLong ToTLDifferenceTooLong()
		{
			return this as TLDifferenceTooLong;
		}

    }
}
