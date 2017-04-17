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
	[TLObject(1491380032)]
    public class TLRequestRpc_drop_answer : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return 1491380032;
            }
        }

                public long req_msg_id {get;set;}
        public TLAbsRpcDropAnswer Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            req_msg_id = br.ReadInt64();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(req_msg_id);

        }
		public override void deserializeResponse(BinaryReader br)
		{
			Response = (TLAbsRpcDropAnswer)ObjectUtils.DeserializeObject(br);

		}
    }
}
