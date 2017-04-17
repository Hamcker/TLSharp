using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using BigMath;

namespace TeleSharp.TL.Channels
{
    [TLObject(-791039645)]
    public class TLChannelParticipant : TLAbsChannelParticipant
    {
        public override int Constructor
        {
            get
            {
                return -791039645;
            }
        }

        public TLAbsChannelParticipant participant { get; set; }
        public TLVector<TLAbsUser> users { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            participant = (TLAbsChannelParticipant)ObjectUtils.DeserializeObject(br);
            users = (TLVector<TLAbsUser>)ObjectUtils.DeserializeVector<TLAbsUser>(br);
            Type = TLAbsChannelParticipantTypes.TLChannelParticipant;
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(participant, bw);
            ObjectUtils.SerializeObject(users, bw);

        }
    }
}
