using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Help
{
	public enum TLAbsTermsOfServiceTypes
	{
		TLTermsOfService
	}

    public abstract class TLAbsTermsOfService : TLObject
    {
		public TLAbsTermsOfServiceTypes Type { get; set; } 

		public T To<T>() where T : TLAbsTermsOfService
        {
            return this as T;
        }

		public TLTermsOfService ToTLTermsOfService()
		{
			return this as TLTermsOfService;
		}

    }
}
