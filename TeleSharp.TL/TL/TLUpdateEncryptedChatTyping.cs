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
	[TLObject(386986326)]
    public class TLUpdateEncryptedChatTyping : TLAbsUpdate
    {
        public override int Constructor
        {
            get
            {
                return 386986326;
            }
        }

             public int chat_id {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            chat_id = br.ReadInt32();
Type = TLAbsUpdateTypes.TLUpdateEncryptedChatTyping;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(chat_id);

        }
    }
}
