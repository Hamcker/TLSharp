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
	[TLObject(-1370486635)]
    public class TLFuture_salts : TLAbsFutureSalts
    {
        public override int Constructor
        {
            get
            {
                return -1370486635;
            }
        }

             public long req_msg_id {get;set;}
     public int now {get;set;}
     public TLVector<TLFuture_salt> salts {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            req_msg_id = br.ReadInt64();
now = br.ReadInt32();
salts = (TLVector<TLFuture_salt>)ObjectUtils.DeserializeVector<TLFuture_salt>(br);
Type = TLAbsFutureSaltsTypes.TLFuture_salts;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(req_msg_id);
bw.Write(now);
ObjectUtils.SerializeObject(salts,bw);

        }
    }
}
