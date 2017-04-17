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
	[TLObject(-718310409)]
    public class TLSendMessageRecordAudioAction : TLAbsSendMessageAction
    {
        public override int Constructor
        {
            get
            {
                return -718310409;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsSendMessageActionTypes.TLSendMessageRecordAudioAction;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
