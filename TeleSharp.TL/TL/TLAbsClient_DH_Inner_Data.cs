using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsClient_DH_Inner_DataTypes
	{
		TLClient_DH_inner_data
	}

    public abstract class TLAbsClient_DH_Inner_Data : TLObject
    {
		public TLAbsClient_DH_Inner_DataTypes Type { get; set; } 

		public T To<T>() where T : TLAbsClient_DH_Inner_Data
        {
            return this as T;
        }

		public TLClient_DH_inner_data ToTLClient_DH_inner_data()
		{
			return this as TLClient_DH_inner_data;
		}

    }
}
