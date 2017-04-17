using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsP_Q_inner_dataTypes
	{
		TLP_q_inner_data
	}

    public abstract class TLAbsP_Q_inner_data : TLObject
    {
		public TLAbsP_Q_inner_dataTypes Type { get; set; } 

		public T To<T>() where T : TLAbsP_Q_inner_data
        {
            return this as T;
        }

		public TLP_q_inner_data ToTLP_q_inner_data()
		{
			return this as TLP_q_inner_data;
		}

    }
}
