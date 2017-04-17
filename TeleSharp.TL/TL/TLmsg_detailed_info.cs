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
	[TLObject(661470918)]
    public class TLMsg_detailed_info : TLAbsMsgDetailedInfo
    {
        public override int Constructor
        {
            get
            {
                return 661470918;
            }
        }

             public long msg_id {get;set;}
     public long answer_msg_id {get;set;}
     public int bytes {get;set;}
     public int status {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            msg_id = br.ReadInt64();
answer_msg_id = br.ReadInt64();
bytes = br.ReadInt32();
status = br.ReadInt32();
Type = TLAbsMsgDetailedInfoTypes.TLMsg_detailed_info;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(msg_id);
bw.Write(answer_msg_id);
bw.Write(bytes);
bw.Write(status);

        }
    }
}
