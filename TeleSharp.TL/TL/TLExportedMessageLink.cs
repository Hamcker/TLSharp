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
	[TLObject(524838915)]
    public class TLExportedMessageLink : TLAbsExportedMessageLink
    {
        public override int Constructor
        {
            get
            {
                return 524838915;
            }
        }

             public string link {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            link = StringUtil.Deserialize(br);
Type = TLAbsExportedMessageLinkTypes.TLExportedMessageLink;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            StringUtil.Serialize(link,bw);

        }
    }
}
