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
	[TLObject(236446268)]
    public class TLPhotoSizeEmpty : TLAbsPhotoSize
    {
        public override int Constructor
        {
            get
            {
                return 236446268;
            }
        }

             public string type {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            type = StringUtil.Deserialize(br);
Type = TLAbsPhotoSizeTypes.TLPhotoSizeEmpty;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            StringUtil.Serialize(type,bw);

        }
    }
}
