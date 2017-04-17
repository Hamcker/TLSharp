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
	[TLObject(-1631450872)]
    public class TLNew_session_created : TLAbsNewSession
    {
        public override int Constructor
        {
            get
            {
                return -1631450872;
            }
        }

             public long first_msg_id {get;set;}
     public long unique_id {get;set;}
     public long server_salt {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            first_msg_id = br.ReadInt64();
unique_id = br.ReadInt64();
server_salt = br.ReadInt64();
Type = TLAbsNewSessionTypes.TLNew_session_created;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(first_msg_id);
bw.Write(unique_id);
bw.Write(server_salt);

        }
    }
}
