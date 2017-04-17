using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;


namespace TeleSharp.TL.Contest
{
	[TLObject(-1705021803)]
    public class TLRequestSaveDeveloperInfo : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return -1705021803;
            }
        }

                public int vk_id {get;set;}
        public string name {get;set;}
        public string phone_number {get;set;}
        public int age {get;set;}
        public string city {get;set;}
        public bool Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            vk_id = br.ReadInt32();
name = StringUtil.Deserialize(br);
phone_number = StringUtil.Deserialize(br);
age = br.ReadInt32();
city = StringUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(vk_id);
StringUtil.Serialize(name,bw);
StringUtil.Serialize(phone_number,bw);
bw.Write(age);
StringUtil.Serialize(city,bw);

        }
		public override void deserializeResponse(BinaryReader br)
		{
			Response = BoolUtil.Deserialize(br);

		}
    }
}
