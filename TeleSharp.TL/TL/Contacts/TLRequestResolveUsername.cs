using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;


namespace TeleSharp.TL.Contacts
{
	[TLObject(-113456221)]
    public class TLRequestResolveUsername : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return -113456221;
            }
        }

                public string username {get;set;}
        public Contacts.TLAbsResolvedPeer Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            username = StringUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            StringUtil.Serialize(username,bw);

        }
		public override void deserializeResponse(BinaryReader br)
		{
			Response = (Contacts.TLAbsResolvedPeer)ObjectUtils.DeserializeObject(br);

		}
    }
}
