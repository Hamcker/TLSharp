using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;


namespace TeleSharp.TL.Updates
{
	[TLObject(-304838614)]
    public class TLRequestGetState : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return -304838614;
            }
        }

                public Updates.TLAbsState Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
		public override void deserializeResponse(BinaryReader br)
		{
			Response = (Updates.TLAbsState)ObjectUtils.DeserializeObject(br);

		}
    }
}
