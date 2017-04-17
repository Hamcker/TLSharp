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
	[TLObject(-1734268085)]
    public class TLUpdateChannelMessageViews : TLAbsUpdate
    {
        public override int Constructor
        {
            get
            {
                return -1734268085;
            }
        }

             public int channel_id {get;set;}
     public int id {get;set;}
     public int views {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            channel_id = br.ReadInt32();
id = br.ReadInt32();
views = br.ReadInt32();
Type = TLAbsUpdateTypes.TLUpdateChannelMessageViews;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(channel_id);
bw.Write(id);
bw.Write(views);

        }
    }
}
