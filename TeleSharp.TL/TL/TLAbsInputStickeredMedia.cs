using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInputStickeredMediaTypes
	{
		TLInputStickeredMediaPhoto,TLInputStickeredMediaDocument
	}

    public abstract class TLAbsInputStickeredMedia : TLObject
    {
		public TLAbsInputStickeredMediaTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInputStickeredMedia
        {
            return this as T;
        }

		public TLInputStickeredMediaPhoto ToTLInputStickeredMediaPhoto()
		{
			return this as TLInputStickeredMediaPhoto;
		}

		public TLInputStickeredMediaDocument ToTLInputStickeredMediaDocument()
		{
			return this as TLInputStickeredMediaDocument;
		}

    }
}
