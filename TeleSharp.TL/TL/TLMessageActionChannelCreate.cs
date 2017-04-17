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
	[TLObject(-1781355374)]
    public class TLMessageActionChannelCreate : TLAbsMessageAction
    {
        public override int Constructor
        {
            get
            {
                return -1781355374;
            }
        }

             public string title {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            title = StringUtil.Deserialize(br);
Type = TLAbsMessageActionTypes.TLMessageActionChannelCreate;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            StringUtil.Serialize(title,bw);

        }
    }
}
