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
	[TLObject(-1933520591)]
    public class TLMsgs_all_info : TLAbsMsgsAllInfo
    {
        public override int Constructor
        {
            get
            {
                return -1933520591;
            }
        }

             public TLVector<long> msg_ids {get;set;}
     public string info {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            msg_ids = (TLVector<long>)ObjectUtils.DeserializeVector<long>(br);
info = StringUtil.Deserialize(br);
Type = TLAbsMsgsAllInfoTypes.TLMsgs_all_info;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(msg_ids,bw);
StringUtil.Serialize(info,bw);

        }
    }
}
