using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsReportReasonTypes
	{
		TLInputReportReasonSpam,TLInputReportReasonViolence,TLInputReportReasonPornography,TLInputReportReasonOther
	}

    public abstract class TLAbsReportReason : TLObject
    {
		public TLAbsReportReasonTypes Type { get; set; } 

		public T To<T>() where T : TLAbsReportReason
        {
            return this as T;
        }

		public TLInputReportReasonSpam ToTLInputReportReasonSpam()
		{
			return this as TLInputReportReasonSpam;
		}

		public TLInputReportReasonViolence ToTLInputReportReasonViolence()
		{
			return this as TLInputReportReasonViolence;
		}

		public TLInputReportReasonPornography ToTLInputReportReasonPornography()
		{
			return this as TLInputReportReasonPornography;
		}

		public TLInputReportReasonOther ToTLInputReportReasonOther()
		{
			return this as TLInputReportReasonOther;
		}

    }
}
