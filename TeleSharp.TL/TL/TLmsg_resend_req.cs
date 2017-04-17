using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;

namespace TeleSharp.TL
{
	[TLObject(2105940488)]
    public class TLMsg_resend_req : TLAbsMsgResendReq
    {
        public override int Constructor
        {
            get
            {
                return 2105940488;
            }
        }

             public TLVector<long> msg_ids {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            msg_ids = (TLVector<long>)ObjectUtils.DeserializeVector<long>(br);
Type = TLAbsMsgResendReqTypes.TLMsg_resend_req;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(msg_ids,bw);

        }
    }
}
