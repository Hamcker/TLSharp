using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;

namespace TeleSharp.TL.Messages
{
	[TLObject(364538944)]
    public class TLDialogs : TLAbsDialogs
    {
        public override int Constructor
        {
            get
            {
                return 364538944;
            }
        }

             public TLVector<TLAbsDialog> dialogs {get;set;}
     public TLVector<TLAbsMessage> messages {get;set;}
     public TLVector<TLAbsChat> chats {get;set;}
     public TLVector<TLAbsUser> users {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            dialogs = (TLVector<TLAbsDialog>)ObjectUtils.DeserializeVector<TLAbsDialog>(br);
messages = (TLVector<TLAbsMessage>)ObjectUtils.DeserializeVector<TLAbsMessage>(br);
chats = (TLVector<TLAbsChat>)ObjectUtils.DeserializeVector<TLAbsChat>(br);
users = (TLVector<TLAbsUser>)ObjectUtils.DeserializeVector<TLAbsUser>(br);
Type = TLAbsDialogsTypes.TLDialogs;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(dialogs,bw);
ObjectUtils.SerializeObject(messages,bw);
ObjectUtils.SerializeObject(chats,bw);
ObjectUtils.SerializeObject(users,bw);

        }
    }
}
