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
	[TLObject(1891070632)]
    public class TLTopPeers : TLAbsTopPeers
    {
        public override int Constructor
        {
            get
            {
                return 1891070632;
            }
        }

             public TLVector<TLAbsTopPeerCategoryPeers> categories {get;set;}
     public TLVector<TLAbsChat> chats {get;set;}
     public TLVector<TLAbsUser> users {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            categories = (TLVector<TLAbsTopPeerCategoryPeers>)ObjectUtils.DeserializeVector<TLAbsTopPeerCategoryPeers>(br);
chats = (TLVector<TLAbsChat>)ObjectUtils.DeserializeVector<TLAbsChat>(br);
users = (TLVector<TLAbsUser>)ObjectUtils.DeserializeVector<TLAbsUser>(br);
Type = TLAbsTopPeersTypes.TLTopPeers;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(categories,bw);
ObjectUtils.SerializeObject(chats,bw);
ObjectUtils.SerializeObject(users,bw);

        }
    }
}
