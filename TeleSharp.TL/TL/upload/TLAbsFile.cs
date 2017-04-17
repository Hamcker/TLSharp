using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Upload
{
	public enum TLAbsFileTypes
	{
		TLFile
	}

    public abstract class TLAbsFile : TLObject
    {
		public TLAbsFileTypes Type { get; set; } 

		public T To<T>() where T : TLAbsFile
        {
            return this as T;
        }

		public TLFile ToTLFile()
		{
			return this as TLFile;
		}

    }
}
