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
	[TLObject(-1378534221)]
    public class TLPeerNotifyEventsEmpty : TLAbsPeerNotifyEvents
    {
        public override int Constructor
        {
            get
            {
                return -1378534221;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsPeerNotifyEventsTypes.TLPeerNotifyEventsEmpty;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
