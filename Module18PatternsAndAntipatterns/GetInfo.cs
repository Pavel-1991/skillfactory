using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18PatternsAndAntipatterns
{
    class GetInfo : Command
    {
        Receiver receiver;
        string videoUrl;

        public GetInfo(Receiver receiver, string videoUrl)
        {
            this.receiver = receiver;
            this.videoUrl = videoUrl;
        }

        public async override Task Run()
        {
            receiver.GetInfo(videoUrl);
        }

        public override void Cancel()
        { }
    }
}
