using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsMsgDetailedInfoTypes
	{
		TLMsg_detailed_info,TLMsg_new_detailed_info
	}

    public abstract class TLAbsMsgDetailedInfo : TLObject
    {
		public TLAbsMsgDetailedInfoTypes Type { get; set; } 

		public T To<T>() where T : TLAbsMsgDetailedInfo
        {
            return this as T;
        }

		public TLMsg_detailed_info ToTLMsg_detailed_info()
		{
			return this as TLMsg_detailed_info;
		}

		public TLMsg_new_detailed_info ToTLMsg_new_detailed_info()
		{
			return this as TLMsg_new_detailed_info;
		}

    }
}
