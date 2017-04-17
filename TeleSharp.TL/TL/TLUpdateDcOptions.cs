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
	[TLObject(-1906403213)]
    public class TLUpdateDcOptions : TLAbsUpdate
    {
        public override int Constructor
        {
            get
            {
                return -1906403213;
            }
        }

             public TLVector<TLAbsDcOption> dc_options {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            dc_options = (TLVector<TLAbsDcOption>)ObjectUtils.DeserializeVector<TLAbsDcOption>(br);
Type = TLAbsUpdateTypes.TLUpdateDcOptions;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(dc_options,bw);

        }
    }
}
