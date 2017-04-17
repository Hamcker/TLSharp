using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsRpcDropAnswerTypes
	{
		TLRpc_answer_unknown,TLRpc_answer_dropped_running,TLRpc_answer_dropped
	}

    public abstract class TLAbsRpcDropAnswer : TLObject
    {
		public TLAbsRpcDropAnswerTypes Type { get; set; } 

		public T To<T>() where T : TLAbsRpcDropAnswer
        {
            return this as T;
        }

		public TLRpc_answer_unknown ToTLRpc_answer_unknown()
		{
			return this as TLRpc_answer_unknown;
		}

		public TLRpc_answer_dropped_running ToTLRpc_answer_dropped_running()
		{
			return this as TLRpc_answer_dropped_running;
		}

		public TLRpc_answer_dropped ToTLRpc_answer_dropped()
		{
			return this as TLRpc_answer_dropped;
		}

    }
}
