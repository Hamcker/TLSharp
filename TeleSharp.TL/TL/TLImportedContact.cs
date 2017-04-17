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
	[TLObject(-805141448)]
    public class TLImportedContact : TLAbsImportedContact
    {
        public override int Constructor
        {
            get
            {
                return -805141448;
            }
        }

             public int user_id {get;set;}
     public long client_id {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            user_id = br.ReadInt32();
client_id = br.ReadInt64();
Type = TLAbsImportedContactTypes.TLImportedContact;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(user_id);
bw.Write(client_id);

        }
    }
}
