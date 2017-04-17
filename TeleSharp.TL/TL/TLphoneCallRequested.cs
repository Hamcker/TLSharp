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
	[TLObject(1816431336)]
    public class TLPhoneCallRequested : TLAbsPhoneCall
    {
        public override int Constructor
        {
            get
            {
                return 1816431336;
            }
        }

             public long id {get;set;}
     public long access_hash {get;set;}
     public int date {get;set;}
     public int admin_id {get;set;}
     public int participant_id {get;set;}
     public byte[] g_a {get;set;}
     public TLAbsPhoneCallProtocol protocol {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            id = br.ReadInt64();
access_hash = br.ReadInt64();
date = br.ReadInt32();
admin_id = br.ReadInt32();
participant_id = br.ReadInt32();
g_a = BytesUtil.Deserialize(br);
protocol = (TLAbsPhoneCallProtocol)ObjectUtils.DeserializeObject(br);
Type = TLAbsPhoneCallTypes.TLPhoneCallRequested;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(id);
bw.Write(access_hash);
bw.Write(date);
bw.Write(admin_id);
bw.Write(participant_id);
BytesUtil.Serialize(g_a,bw);
ObjectUtils.SerializeObject(protocol,bw);

        }
    }
}
