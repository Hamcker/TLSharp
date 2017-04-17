using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Account
{
	public enum TLAbsAuthorizationsTypes
	{
		TLAuthorizations
	}

    public abstract class TLAbsAuthorizations : TLObject
    {
		public TLAbsAuthorizationsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsAuthorizations
        {
            return this as T;
        }

		public TLAuthorizations ToTLAuthorizations()
		{
			return this as TLAuthorizations;
		}

    }
}
