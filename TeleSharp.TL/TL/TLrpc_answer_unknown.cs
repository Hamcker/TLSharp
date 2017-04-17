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
	[TLObject(1579864942)]
    public class TLRpc_answer_unknown : TLAbsRpcDropAnswer
    {
        public override int Constructor
        {
            get
            {
                return 1579864942;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsRpcDropAnswerTypes.TLRpc_answer_unknown;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
