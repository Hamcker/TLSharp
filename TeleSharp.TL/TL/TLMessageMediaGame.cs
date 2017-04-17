using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;

namespace TeleSharp.TL
{
	[TLObject(-38694904)]
    public class TLMessageMediaGame : TLAbsMessageMedia
    {
        public override int Constructor
        {
            get
            {
                return -38694904;
            }
        }

             public TLAbsGame game {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            game = (TLAbsGame)ObjectUtils.DeserializeObject(br);
Type = TLAbsMessageMediaTypes.TLMessageMediaGame;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(game,bw);

        }
    }
}
