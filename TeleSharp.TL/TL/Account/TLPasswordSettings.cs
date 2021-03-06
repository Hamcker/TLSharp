using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;

namespace TeleSharp.TL.Account
{
	[TLObject(-1212732749)]
    public class TLPasswordSettings : TLAbsPasswordSettings
    {
        public override int Constructor
        {
            get
            {
                return -1212732749;
            }
        }

             public string email {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            email = StringUtil.Deserialize(br);
Type = TLAbsPasswordSettingsTypes.TLPasswordSettings;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            StringUtil.Serialize(email,bw);

        }
    }
}
