using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Auth
{
	public enum TLAbsExportedAuthorizationTypes
	{
		TLExportedAuthorization
	}

    public abstract class TLAbsExportedAuthorization : TLObject
    {
		public TLAbsExportedAuthorizationTypes Type { get; set; } 

		public T To<T>() where T : TLAbsExportedAuthorization
        {
            return this as T;
        }

		public TLExportedAuthorization ToTLExportedAuthorization()
		{
			return this as TLExportedAuthorization;
		}

    }
}
