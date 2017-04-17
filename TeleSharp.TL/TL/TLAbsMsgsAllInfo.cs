using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsMsgsAllInfoTypes
	{
		TLMsgs_all_info
	}

    public abstract class TLAbsMsgsAllInfo : TLObject
    {
		public TLAbsMsgsAllInfoTypes Type { get; set; } 

		public T To<T>() where T : TLAbsMsgsAllInfo
        {
            return this as T;
        }

		public TLMsgs_all_info ToTLMsgs_all_info()
		{
			return this as TLMsgs_all_info;
		}

    }
}
