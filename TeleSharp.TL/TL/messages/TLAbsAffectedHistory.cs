using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsAffectedHistoryTypes
	{
		TLAffectedHistory
	}

    public abstract class TLAbsAffectedHistory : TLObject
    {
		public TLAbsAffectedHistoryTypes Type { get; set; } 

		public T To<T>() where T : TLAbsAffectedHistory
        {
            return this as T;
        }

		public TLAffectedHistory ToTLAffectedHistory()
		{
			return this as TLAffectedHistory;
		}

    }
}
