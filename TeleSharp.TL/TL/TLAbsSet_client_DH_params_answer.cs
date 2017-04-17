using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsSet_client_DH_params_answerTypes
	{
		TLDh_gen_ok,TLDh_gen_retry,TLDh_gen_fail
	}

    public abstract class TLAbsSet_client_DH_params_answer : TLObject
    {
		public TLAbsSet_client_DH_params_answerTypes Type { get; set; } 

		public T To<T>() where T : TLAbsSet_client_DH_params_answer
        {
            return this as T;
        }

		public TLDh_gen_ok ToTLDh_gen_ok()
		{
			return this as TLDh_gen_ok;
		}

		public TLDh_gen_retry ToTLDh_gen_retry()
		{
			return this as TLDh_gen_retry;
		}

		public TLDh_gen_fail ToTLDh_gen_fail()
		{
			return this as TLDh_gen_fail;
		}

    }
}
