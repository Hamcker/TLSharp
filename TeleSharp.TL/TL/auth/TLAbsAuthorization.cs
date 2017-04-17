using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Auth
{
	public enum TLAbsAuthorizationTypes
	{
		TLAuthorization
	}

    public abstract class TLAbsAuthorization : TLObject
    {
		public TLAbsAuthorizationTypes Type { get; set; } 

		public T To<T>() where T : TLAbsAuthorization
        {
            return this as T;
        }

		public TLAuthorization ToTLAuthorization()
		{
			return this as TLAuthorization;
		}

    }
}
