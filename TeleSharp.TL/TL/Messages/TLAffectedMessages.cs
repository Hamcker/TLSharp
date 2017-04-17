using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;

namespace TeleSharp.TL.Messages
{
	[TLObject(-2066640507)]
    public class TLAffectedMessages : TLAbsAffectedMessages
    {
        public override int Constructor
        {
            get
            {
                return -2066640507;
            }
        }

             public int pts {get;set;}
     public int pts_count {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            pts = br.ReadInt32();
pts_count = br.ReadInt32();
Type = TLAbsAffectedMessagesTypes.TLAffectedMessages;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(pts);
bw.Write(pts_count);

        }
    }
}
