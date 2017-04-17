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
	[TLObject(-1837345356)]
    public class TLInputChatUploadedPhoto : TLAbsInputChatPhoto
    {
        public override int Constructor
        {
            get
            {
                return -1837345356;
            }
        }

             public TLAbsInputFile file {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            file = (TLAbsInputFile)ObjectUtils.DeserializeObject(br);
Type = TLAbsInputChatPhotoTypes.TLInputChatUploadedPhoto;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(file,bw);

        }
    }
}
