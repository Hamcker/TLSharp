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
	[TLObject(-307542917)]
    public class TLBad_server_salt : TLAbsBadMsgNotification
    {
        public override int Constructor
        {
            get
            {
                return -307542917;
            }
        }

             public long bad_msg_id {get;set;}
     public int bad_msg_seqno {get;set;}
     public int error_code {get;set;}
     public long new_server_salt {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            bad_msg_id = br.ReadInt64();
bad_msg_seqno = br.ReadInt32();
error_code = br.ReadInt32();
new_server_salt = br.ReadInt64();
Type = TLAbsBadMsgNotificationTypes.TLBad_server_salt;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(bad_msg_id);
bw.Write(bad_msg_seqno);
bw.Write(error_code);
bw.Write(new_server_salt);

        }
    }
}
