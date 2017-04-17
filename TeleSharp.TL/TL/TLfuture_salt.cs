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
	[TLObject(155834844)]
    public class TLFuture_salt : TLAbsFutureSalt
    {
        public override int Constructor
        {
            get
            {
                return 155834844;
            }
        }

             public int valid_since {get;set;}
     public int valid_until {get;set;}
     public long salt {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            valid_since = br.ReadInt32();
valid_until = br.ReadInt32();
salt = br.ReadInt64();
Type = TLAbsFutureSaltTypes.TLFuture_salt;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(valid_since);
bw.Write(valid_until);
bw.Write(salt);

        }
    }
}
