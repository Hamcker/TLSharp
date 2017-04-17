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
	[TLObject(-236044656)]
    public class TLTermsOfService : TLAbsTermsOfService
    {
        public override int Constructor
        {
            get
            {
                return -236044656;
            }
        }

             public string text {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            text = StringUtil.Deserialize(br);
Type = TLAbsTermsOfServiceTypes.TLTermsOfService;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            StringUtil.Serialize(text,bw);

        }
    }
}
