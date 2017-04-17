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
	[TLObject(1653390447)]
    public class TLSendMessageChooseContactAction : TLAbsSendMessageAction
    {
        public override int Constructor
        {
            get
            {
                return 1653390447;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsSendMessageActionTypes.TLSendMessageChooseContactAction;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
