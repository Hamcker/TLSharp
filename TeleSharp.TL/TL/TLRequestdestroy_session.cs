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
	[TLObject(-414113498)]
    public class TLRequestDestroy_session : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return -414113498;
            }
        }

                public long session_id {get;set;}
        public TLAbsDestroySessionRes Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            session_id = br.ReadInt64();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(session_id);

        }
		public override void deserializeResponse(BinaryReader br)
		{
			Response = (TLAbsDestroySessionRes)ObjectUtils.DeserializeObject(br);

		}
    }
}
