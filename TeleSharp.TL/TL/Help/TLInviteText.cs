using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;

namespace TeleSharp.TL.Help
{
	[TLObject(415997816)]
    public class TLInviteText : TLAbsInviteText
    {
        public override int Constructor
        {
            get
            {
                return 415997816;
            }
        }

             public string message {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            message = StringUtil.Deserialize(br);
Type = TLAbsInviteTextTypes.TLInviteText;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            StringUtil.Serialize(message,bw);

        }
    }
}
