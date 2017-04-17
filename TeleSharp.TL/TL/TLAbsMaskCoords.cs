using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsMaskCoordsTypes
	{
		TLMaskCoords
	}

    public abstract class TLAbsMaskCoords : TLObject
    {
		public TLAbsMaskCoordsTypes Type { get; set; } 

		public T To<T>() where T : TLAbsMaskCoords
        {
            return this as T;
        }

		public TLMaskCoords ToTLMaskCoords()
		{
			return this as TLMaskCoords;
		}

    }
}
