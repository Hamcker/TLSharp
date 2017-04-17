using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsPrivacyRuleTypes
	{
		TLPrivacyValueAllowContacts,TLPrivacyValueAllowAll,TLPrivacyValueAllowUsers,TLPrivacyValueDisallowContacts,TLPrivacyValueDisallowAll,TLPrivacyValueDisallowUsers
	}

    public abstract class TLAbsPrivacyRule : TLObject
    {
		public TLAbsPrivacyRuleTypes Type { get; set; } 

		public T To<T>() where T : TLAbsPrivacyRule
        {
            return this as T;
        }

		public TLPrivacyValueAllowContacts ToTLPrivacyValueAllowContacts()
		{
			return this as TLPrivacyValueAllowContacts;
		}

		public TLPrivacyValueAllowAll ToTLPrivacyValueAllowAll()
		{
			return this as TLPrivacyValueAllowAll;
		}

		public TLPrivacyValueAllowUsers ToTLPrivacyValueAllowUsers()
		{
			return this as TLPrivacyValueAllowUsers;
		}

		public TLPrivacyValueDisallowContacts ToTLPrivacyValueDisallowContacts()
		{
			return this as TLPrivacyValueDisallowContacts;
		}

		public TLPrivacyValueDisallowAll ToTLPrivacyValueDisallowAll()
		{
			return this as TLPrivacyValueDisallowAll;
		}

		public TLPrivacyValueDisallowUsers ToTLPrivacyValueDisallowUsers()
		{
			return this as TLPrivacyValueDisallowUsers;
		}

    }
}
