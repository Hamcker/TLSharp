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
	[TLObject(-1707344487)]
    public class TLHighScores : TLAbsHighScores
    {
        public override int Constructor
        {
            get
            {
                return -1707344487;
            }
        }

             public TLVector<TLAbsHighScore> scores {get;set;}
     public TLVector<TLAbsUser> users {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            scores = (TLVector<TLAbsHighScore>)ObjectUtils.DeserializeVector<TLAbsHighScore>(br);
users = (TLVector<TLAbsUser>)ObjectUtils.DeserializeVector<TLAbsUser>(br);
Type = TLAbsHighScoresTypes.TLHighScores;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(scores,bw);
ObjectUtils.SerializeObject(users,bw);

        }
    }
}
