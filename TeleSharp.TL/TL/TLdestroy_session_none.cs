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
	[TLObject(1658015945)]
    public class TLDestroy_session_none : TLAbsDestroySessionRes
    {
        public override int Constructor
        {
            get
            {
                return 1658015945;
            }
        }

             public long session_id {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            session_id = br.ReadInt64();
Type = TLAbsDestroySessionResTypes.TLDestroy_session_none;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(session_id);

        }
    }
}
