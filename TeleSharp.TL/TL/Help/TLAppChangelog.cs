using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;

namespace TeleSharp.TL.Help
{
	[TLObject(705920636)]
    public class TLAppChangelog : TLAbsAppChangelog
    {
        public override int Constructor
        {
            get
            {
                return 705920636;
            }
        }

             public string message {get;set;}
     public TLAbsMessageMedia media {get;set;}
     public TLVector<TLAbsMessageEntity> entities {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            message = StringUtil.Deserialize(br);
media = (TLAbsMessageMedia)ObjectUtils.DeserializeObject(br);
entities = (TLVector<TLAbsMessageEntity>)ObjectUtils.DeserializeVector<TLAbsMessageEntity>(br);
Type = TLAbsAppChangelogTypes.TLAppChangelog;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            StringUtil.Serialize(message,bw);
ObjectUtils.SerializeObject(media,bw);
ObjectUtils.SerializeObject(entities,bw);

        }
    }
}
