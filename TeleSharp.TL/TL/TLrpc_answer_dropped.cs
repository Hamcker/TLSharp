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
	[TLObject(-1539647305)]
    public class TLRpc_answer_dropped : TLAbsRpcDropAnswer
    {
        public override int Constructor
        {
            get
            {
                return -1539647305;
            }
        }

             public long msg_id {get;set;}
     public int seq_no {get;set;}
     public int bytes {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            msg_id = br.ReadInt64();
seq_no = br.ReadInt32();
bytes = br.ReadInt32();
Type = TLAbsRpcDropAnswerTypes.TLRpc_answer_dropped;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(msg_id);
bw.Write(seq_no);
bw.Write(bytes);

        }
    }
}
