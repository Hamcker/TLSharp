using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputFileTypes
	{
		TLInputFile,TLInputFileBig
	}

    public abstract class TLAbsInputFile : TLObject
    {
		public TLAbsInputFileTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputFile
        {
            return this as T;
        }

		public TLInputFile ToTLInputFile()
		{
			return this as TLInputFile;
		}

		public TLInputFileBig ToTLInputFileBig()
		{
			return this as TLInputFileBig;
		}

    }
}
