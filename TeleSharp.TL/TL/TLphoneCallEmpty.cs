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
	[TLObject(1399245077)]
    public class TLPhoneCallEmpty : TLAbsPhoneCall
    {
        public override int Constructor
        {
            get
            {
                return 1399245077;
            }
        }

             public long id {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            id = br.ReadInt64();
Type = TLAbsPhoneCallTypes.TLPhoneCallEmpty;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(id);

        }
    }
}
