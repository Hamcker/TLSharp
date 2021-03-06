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
	[TLObject(548253432)]
    public class TLInputPeerChannel : TLAbsInputPeer
    {
        public override int Constructor
        {
            get
            {
                return 548253432;
            }
        }

             public int channel_id {get;set;}
     public long access_hash {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            channel_id = br.ReadInt32();
access_hash = br.ReadInt64();
Type = TLAbsInputPeerTypes.TLInputPeerChannel;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(channel_id);
bw.Write(access_hash);

        }
    }
}
