using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;


namespace TeleSharp.TL.Photos
{
	[TLObject(1328726168)]
    public class TLRequestUploadProfilePhoto : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return 1328726168;
            }
        }

                public TLAbsInputFile file {get;set;}
        public Photos.TLAbsPhoto Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            file = (TLAbsInputFile)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(file,bw);

        }
		public override void deserializeResponse(BinaryReader br)
		{
			Response = (Photos.TLAbsPhoto)ObjectUtils.DeserializeObject(br);

		}
    }
}
