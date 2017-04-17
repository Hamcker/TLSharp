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
	[TLObject(-1660057)]
    public class TLPhoneCall : TLAbsPhoneCall
    {
        public override int Constructor
        {
            get
            {
                return -1660057;
            }
        }

             public long id {get;set;}
     public long access_hash {get;set;}
     public int date {get;set;}
     public int admin_id {get;set;}
     public int participant_id {get;set;}
     public byte[] g_a_or_b {get;set;}
     public long key_fingerprint {get;set;}
     public TLAbsPhoneCallProtocol protocol {get;set;}
     public TLAbsPhoneConnection connection {get;set;}
     public TLVector<TLAbsPhoneConnection> alternative_connections {get;set;}
     public int start_date {get;set;}


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
g_a_or_b = BytesUtil.Deserialize(br);
key_fingerprint = br.ReadInt64();
protocol = (TLAbsPhoneCallProtocol)ObjectUtils.DeserializeObject(br);
connection = (TLAbsPhoneConnection)ObjectUtils.DeserializeObject(br);
alternative_connections = (TLVector<TLAbsPhoneConnection>)ObjectUtils.DeserializeVector<TLAbsPhoneConnection>(br);
start_date = br.ReadInt32();
Type = TLAbsPhoneCallTypes.TLPhoneCall;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(id);
bw.Write(access_hash);
bw.Write(date);
bw.Write(admin_id);
bw.Write(participant_id);
BytesUtil.Serialize(g_a_or_b,bw);
bw.Write(key_fingerprint);
ObjectUtils.SerializeObject(protocol,bw);
ObjectUtils.SerializeObject(connection,bw);
ObjectUtils.SerializeObject(alternative_connections,bw);
bw.Write(start_date);

        }
    }
}
