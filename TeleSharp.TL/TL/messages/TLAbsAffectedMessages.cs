using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Messages
{
	public enum TLAbsAffectedMessagesTypes
	{
		TLAffectedMessages
	}

    public abstract class TLAbsAffectedMessages : TLObject
    {
		public TLAbsAffectedMessagesTypes Type { get; set; } 

		public T To<T>() where T : TLAbsAffectedMessages
        {
            return this as T;
        }

		public TLAffectedMessages ToTLAffectedMessages()
		{
			return this as TLAffectedMessages;
		}

    }
}
