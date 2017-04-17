using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsServer_DH_ParamsTypes
	{
		TLServer_DH_params_fail,TLServer_DH_params_ok
	}

    public abstract class TLAbsServer_DH_Params : TLObject
    {
		public TLAbsServer_DH_ParamsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsServer_DH_Params
        {
            return this as T;
        }

		public TLServer_DH_params_fail ToTLServer_DH_params_fail()
		{
			return this as TLServer_DH_params_fail;
		}

		public TLServer_DH_params_ok ToTLServer_DH_params_ok()
		{
			return this as TLServer_DH_params_ok;
		}

    }
}
