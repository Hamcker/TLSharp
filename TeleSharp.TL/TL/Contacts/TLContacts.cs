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
	[TLObject(1871416498)]
    public class TLContacts : TLAbsContacts
    {
        public override int Constructor
        {
            get
            {
                return 1871416498;
            }
        }

             public TLVector<TLAbsContact> contacts {get;set;}
     public TLVector<TLAbsUser> users {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            contacts = (TLVector<TLAbsContact>)ObjectUtils.DeserializeVector<TLAbsContact>(br);
users = (TLVector<TLAbsUser>)ObjectUtils.DeserializeVector<TLAbsUser>(br);
Type = TLAbsContactsTypes.TLContacts;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(contacts,bw);
ObjectUtils.SerializeObject(users,bw);

        }
    }
}
