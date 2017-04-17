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
	[TLObject(-59151553)]
    public class TLKeyboardButtonRequestGeoLocation : TLAbsKeyboardButton
    {
        public override int Constructor
        {
            get
            {
                return -59151553;
            }
        }

             public string text {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            text = StringUtil.Deserialize(br);
Type = TLAbsKeyboardButtonTypes.TLKeyboardButtonRequestGeoLocation;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            StringUtil.Serialize(text,bw);

        }
    }
}
