using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsServer_DH_inner_dataTypes
	{
		TLServer_DH_inner_data
	}

    public abstract class TLAbsServer_DH_inner_data : TLObject
    {
		public TLAbsServer_DH_inner_dataTypes Type { get; set; } 

		public T To<T>() where T : TLAbsServer_DH_inner_data
        {
            return this as T;
        }

		public TLServer_DH_inner_data ToTLServer_DH_inner_data()
		{
			return this as TLServer_DH_inner_data;
		}

    }
}
