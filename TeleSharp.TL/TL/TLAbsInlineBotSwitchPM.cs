using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsInlineBotSwitchPMTypes
	{
		TLInlineBotSwitchPM
	}

    public abstract class TLAbsInlineBotSwitchPM : TLObject
    {
		public TLAbsInlineBotSwitchPMTypes Type { get; set; } 

		public T To<T>() where T : TLAbsInlineBotSwitchPM
        {
            return this as T;
        }

		public TLInlineBotSwitchPM ToTLInlineBotSwitchPM()
		{
			return this as TLInlineBotSwitchPM;
		}

    }
}
