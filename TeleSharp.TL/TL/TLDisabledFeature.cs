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
	[TLObject(-1369215196)]
    public class TLDisabledFeature : TLAbsDisabledFeature
    {
        public override int Constructor
        {
            get
            {
                return -1369215196;
            }
        }

             public string feature {get;set;}
     public string description {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            feature = StringUtil.Deserialize(br);
description = StringUtil.Deserialize(br);
Type = TLAbsDisabledFeatureTypes.TLDisabledFeature;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            StringUtil.Serialize(feature,bw);
StringUtil.Serialize(description,bw);

        }
    }
}
