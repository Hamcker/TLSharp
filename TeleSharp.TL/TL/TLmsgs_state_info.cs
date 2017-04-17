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
	[TLObject(81704317)]
    public class TLMsgs_state_info : TLAbsMsgsStateInfo
    {
        public override int Constructor
        {
            get
            {
                return 81704317;
            }
        }

             public long req_msg_id {get;set;}
     public string info {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            req_msg_id = br.ReadInt64();
info = StringUtil.Deserialize(br);
Type = TLAbsMsgsStateInfoTypes.TLMsgs_state_info;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(req_msg_id);
StringUtil.Serialize(info,bw);

        }
    }
}
