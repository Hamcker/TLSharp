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
	[TLObject(537022650)]
    public class TLUserEmpty : TLAbsUser
    {
        public override int Constructor
        {
            get
            {
                return 537022650;
            }
        }

             public int id {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            id = br.ReadInt32();
Type = TLAbsUserTypes.TLUserEmpty;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(id);

        }
    }
}
