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
	[TLObject(258170395)]
    public class TLRequestGetInlineGameHighScores : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return 258170395;
            }
        }

                public TLAbsInputBotInlineMessageID id {get;set;}
        public TLAbsInputUser user_id {get;set;}
        public Messages.TLAbsHighScores Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            id = (TLAbsInputBotInlineMessageID)ObjectUtils.DeserializeObject(br);
user_id = (TLAbsInputUser)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(id,bw);
ObjectUtils.SerializeObject(user_id,bw);

        }
		public override void deserializeResponse(BinaryReader br)
		{
			Response = (Messages.TLAbsHighScores)ObjectUtils.DeserializeObject(br);

		}
    }
}
