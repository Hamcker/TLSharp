using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsMsgsStateInfoTypes
	{
		TLMsgs_state_info
	}

    public abstract class TLAbsMsgsStateInfo : TLObject
    {
		public TLAbsMsgsStateInfoTypes Type { get; set; } 

		public T To<T>() where T : TLAbsMsgsStateInfo
        {
            return this as T;
        }

		public TLMsgs_state_info ToTLMsgs_state_info()
		{
			return this as TLMsgs_state_info;
		}

    }
}
