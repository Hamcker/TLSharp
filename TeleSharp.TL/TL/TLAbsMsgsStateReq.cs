using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsMsgsStateReqTypes
	{
		TLMsgs_state_req
	}

    public abstract class TLAbsMsgsStateReq : TLObject
    {
		public TLAbsMsgsStateReqTypes Type { get; set; } 

		public T To<T>() where T : TLAbsMsgsStateReq
        {
            return this as T;
        }

		public TLMsgs_state_req ToTLMsgs_state_req()
		{
			return this as TLMsgs_state_req;
		}

    }
}
