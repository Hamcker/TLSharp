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
	[TLObject(1996904104)]
    public class TLInputAppEvent : TLAbsInputAppEvent
    {
        public override int Constructor
        {
            get
            {
                return 1996904104;
            }
        }

             public double time {get;set;}
     public string type {get;set;}
     public long peer {get;set;}
     public string data {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            time = br.ReadDouble();
type = StringUtil.Deserialize(br);
peer = br.ReadInt64();
data = StringUtil.Deserialize(br);
Type = TLAbsInputAppEventTypes.TLInputAppEvent;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(time);
StringUtil.Serialize(type,bw);
bw.Write(peer);
StringUtil.Serialize(data,bw);

        }
    }
}
