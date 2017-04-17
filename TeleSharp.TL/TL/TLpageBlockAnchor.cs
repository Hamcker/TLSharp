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
	[TLObject(-837994576)]
    public class TLPageBlockAnchor : TLAbsPageBlock
    {
        public override int Constructor
        {
            get
            {
                return -837994576;
            }
        }

             public string name {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            name = StringUtil.Deserialize(br);
Type = TLAbsPageBlockTypes.TLPageBlockAnchor;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            StringUtil.Serialize(name,bw);

        }
    }
}
