using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Storage
{
	public enum TLAbsFileTypeTypes
	{
		TLFileUnknown,TLFileJpeg,TLFileGif,TLFilePng,TLFilePdf,TLFileMp3,TLFileMov,TLFilePartial,TLFileMp4,TLFileWebp
	}

    public abstract class TLAbsFileType : TLObject
    {
		public TLAbsFileTypeTypes Type { get; set; } 

		public T To<T>() where T : TLAbsFileType
        {
            return this as T;
        }

		public TLFileUnknown ToTLFileUnknown()
		{
			return this as TLFileUnknown;
		}

		public TLFileJpeg ToTLFileJpeg()
		{
			return this as TLFileJpeg;
		}

		public TLFileGif ToTLFileGif()
		{
			return this as TLFileGif;
		}

		public TLFilePng ToTLFilePng()
		{
			return this as TLFilePng;
		}

		public TLFilePdf ToTLFilePdf()
		{
			return this as TLFilePdf;
		}

		public TLFileMp3 ToTLFileMp3()
		{
			return this as TLFileMp3;
		}

		public TLFileMov ToTLFileMov()
		{
			return this as TLFileMov;
		}

		public TLFilePartial ToTLFilePartial()
		{
			return this as TLFilePartial;
		}

		public TLFileMp4 ToTLFileMp4()
		{
			return this as TLFileMp4;
		}

		public TLFileWebp ToTLFileWebp()
		{
			return this as TLFileWebp;
		}

    }
}
