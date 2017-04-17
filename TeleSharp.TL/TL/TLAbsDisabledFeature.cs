using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsDisabledFeatureTypes
	{
		TLDisabledFeature
	}

    public abstract class TLAbsDisabledFeature : TLObject
    {
		public TLAbsDisabledFeatureTypes Type { get; set; } 

		public T To<T>() where T : TLAbsDisabledFeature
        {
            return this as T;
        }

		public TLDisabledFeature ToTLDisabledFeature()
		{
			return this as TLDisabledFeature;
		}

    }
}
