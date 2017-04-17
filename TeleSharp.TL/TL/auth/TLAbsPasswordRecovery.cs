using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Auth
{
	public enum TLAbsPasswordRecoveryTypes
	{
		TLPasswordRecovery
	}

    public abstract class TLAbsPasswordRecovery : TLObject
    {
		public TLAbsPasswordRecoveryTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPasswordRecovery
        {
            return this as T;
        }

		public TLPasswordRecovery ToTLPasswordRecovery()
		{
			return this as TLPasswordRecovery;
		}

    }
}
