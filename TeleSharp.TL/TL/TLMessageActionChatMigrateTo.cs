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
	[TLObject(1371385889)]
    public class TLMessageActionChatMigrateTo : TLAbsMessageAction
    {
        public override int Constructor
        {
            get
            {
                return 1371385889;
            }
        }

             public int channel_id {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            channel_id = br.ReadInt32();
Type = TLAbsMessageActionTypes.TLMessageActionChatMigrateTo;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(channel_id);

        }
    }
}
