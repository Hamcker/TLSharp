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
	[TLObject(-1798033689)]
    public class TLChannelMessagesFilterEmpty : TLAbsChannelMessagesFilter
    {
        public override int Constructor
        {
            get
            {
                return -1798033689;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsChannelMessagesFilterTypes.TLChannelMessagesFilterEmpty;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
