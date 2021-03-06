using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;


namespace TeleSharp.TL.Auth
{
	[TLObject(1319464594)]
    public class TLRequestRecoverPassword : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return 1319464594;
            }
        }

                public string code {get;set;}
        public Auth.TLAbsAuthorization Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            code = StringUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            StringUtil.Serialize(code,bw);

        }
		public override void deserializeResponse(BinaryReader br)
		{
			Response = (Auth.TLAbsAuthorization)ObjectUtils.DeserializeObject(br);

		}
    }
}
