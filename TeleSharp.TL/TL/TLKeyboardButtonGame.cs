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
	[TLObject(1358175439)]
    public class TLKeyboardButtonGame : TLAbsKeyboardButton
    {
        public override int Constructor
        {
            get
            {
                return 1358175439;
            }
        }

             public string text {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            text = StringUtil.Deserialize(br);
Type = TLAbsKeyboardButtonTypes.TLKeyboardButtonGame;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            StringUtil.Serialize(text,bw);

        }
    }
}
