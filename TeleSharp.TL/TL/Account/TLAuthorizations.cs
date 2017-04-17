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
	[TLObject(307276766)]
    public class TLAuthorizations : TLAbsAuthorizations
    {
        public override int Constructor
        {
            get
            {
                return 307276766;
            }
        }

             public TLVector<TLAbsAuthorization> authorizations {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            authorizations = (TLVector<TLAbsAuthorization>)ObjectUtils.DeserializeVector<TLAbsAuthorization>(br);
Type = TLAbsAuthorizationsTypes.TLAuthorizations;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(authorizations,bw);

        }
    }
}
