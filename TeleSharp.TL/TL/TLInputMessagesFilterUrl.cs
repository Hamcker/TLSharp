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
	[TLObject(2129714567)]
    public class TLInputMessagesFilterUrl : TLAbsMessagesFilter
    {
        public override int Constructor
        {
            get
            {
                return 2129714567;
            }
        }

        

		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Type = TLAbsMessagesFilterTypes.TLInputMessagesFilterUrl;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            
        }
    }
}
