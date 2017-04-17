using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsMsgResendReqTypes
	{
		TLMsg_resend_req
	}

    public abstract class TLAbsMsgResendReq : TLObject
    {
		public TLAbsMsgResendReqTypes Type { get; set; } 

		public T To<T>() where T : TLAbsMsgResendReq
        {
            return this as T;
        }

		public TLMsg_resend_req ToTLMsg_resend_req()
		{
			return this as TLMsg_resend_req;
		}

    }
}
