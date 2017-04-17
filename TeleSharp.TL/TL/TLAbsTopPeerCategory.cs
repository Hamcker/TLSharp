using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	public enum TLAbsTopPeerCategoryTypes
	{
		TLTopPeerCategoryBotsPM,TLTopPeerCategoryBotsInline,TLTopPeerCategoryCorrespondents,TLTopPeerCategoryGroups,TLTopPeerCategoryChannels
	}

    public abstract class TLAbsTopPeerCategory : TLObject
    {
		public TLAbsTopPeerCategoryTypes Type { get; set; } 

		public T To<T>() where T : TLAbsTopPeerCategory
        {
            return this as T;
        }

		public TLTopPeerCategoryBotsPM ToTLTopPeerCategoryBotsPM()
		{
			return this as TLTopPeerCategoryBotsPM;
		}

		public TLTopPeerCategoryBotsInline ToTLTopPeerCategoryBotsInline()
		{
			return this as TLTopPeerCategoryBotsInline;
		}

		public TLTopPeerCategoryCorrespondents ToTLTopPeerCategoryCorrespondents()
		{
			return this as TLTopPeerCategoryCorrespondents;
		}

		public TLTopPeerCategoryGroups ToTLTopPeerCategoryGroups()
		{
			return this as TLTopPeerCategoryGroups;
		}

		public TLTopPeerCategoryChannels ToTLTopPeerCategoryChannels()
		{
			return this as TLTopPeerCategoryChannels;
		}

    }
}
