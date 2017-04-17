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
	[TLObject(-212740181)]
    public class TLSendMessageUploadAudioAction : TLAbsSendMessageAction
    {
        public override int Constructor
        {
            get
            {
                return -212740181;
            }
        }

             public int progress {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            progress = br.ReadInt32();
Type = TLAbsSendMessageActionTypes.TLSendMessageUploadAudioAction;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(progress);

        }
    }
}
