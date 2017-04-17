using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;


namespace TeleSharp.TL.Phone
{
	[TLObject(571411232)]
    public class TLRequestAcceptCall : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return 571411232;
            }
        }

                public TLAbsInputPhoneCall peer {get;set;}
        public byte[] g_b {get;set;}
        public long key_fingerprint {get;set;}
        public TLAbsPhoneCallProtocol protocol {get;set;}
        public Phone.TLAbsPhoneCall Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            peer = (TLAbsInputPhoneCall)ObjectUtils.DeserializeObject(br);
g_b = BytesUtil.Deserialize(br);
key_fingerprint = br.ReadInt64();
protocol = (TLAbsPhoneCallProtocol)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(peer,bw);
BytesUtil.Serialize(g_b,bw);
bw.Write(key_fingerprint);
ObjectUtils.SerializeObject(protocol,bw);

        }
		public override void deserializeResponse(BinaryReader br)
		{
			Response = (Phone.TLAbsPhoneCall)ObjectUtils.DeserializeObject(br);

		}
    }
}
