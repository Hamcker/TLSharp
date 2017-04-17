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
	[TLObject(1889961234)]
    public class TLPeerNotifySettingsEmpty : TLAbsPeerNotifySettings
    {
        public override int Constructor
        {
            get
            {
                return 1889961234;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsPeerNotifySettingsTypes.TLPeerNotifySettingsEmpty;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
