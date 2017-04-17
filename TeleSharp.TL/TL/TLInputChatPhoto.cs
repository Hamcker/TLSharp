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
	[TLObject(-1991004873)]
    public class TLInputChatPhoto : TLAbsInputChatPhoto
    {
        public override int Constructor
        {
            get
            {
                return -1991004873;
            }
        }

             public TLAbsInputPhoto id {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            id = (TLAbsInputPhoto)ObjectUtils.DeserializeObject(br);
Type = TLAbsInputChatPhotoTypes.TLInputChatPhoto;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(id,bw);

        }
    }
}
