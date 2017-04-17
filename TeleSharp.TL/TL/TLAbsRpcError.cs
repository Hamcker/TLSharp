using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsRpcErrorTypes
	{
		TLRpc_error
	}

    public abstract class TLAbsRpcError : TLObject
    {
		public TLAbsRpcErrorTypes Type { get; set; } 

		public T To<T>() where T : TLAbsRpcError
        {
            return this as T;
        }

		public TLRpc_error ToTLRpc_error()
		{
			return this as TLRpc_error;
		}

    }
}
