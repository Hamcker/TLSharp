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
	[TLObject(-1131605573)]
    public class TLRequestGetPasswordSettings : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return -1131605573;
            }
        }

                public byte[] current_password_hash {get;set;}
        public Account.TLAbsPasswordSettings Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            current_password_hash = BytesUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            BytesUtil.Serialize(current_password_hash,bw);

        }
		public override void deserializeResponse(BinaryReader br)
		{
			Response = (Account.TLAbsPasswordSettings)ObjectUtils.DeserializeObject(br);

		}
    }
}
