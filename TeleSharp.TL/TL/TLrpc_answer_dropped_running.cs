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
	[TLObject(-847714938)]
    public class TLRpc_answer_dropped_running : TLAbsRpcDropAnswer
    {
        public override int Constructor
        {
            get
            {
                return -847714938;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsRpcDropAnswerTypes.TLRpc_answer_dropped_running;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
