using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18PatternsAndAntipatterns
{
    class DownloadVideo : Command
    {
        Receiver receiver;
        string videoUrl;

        public DownloadVideo(Receiver receiver, string videoUrl)
        {
            this.receiver = receiver;
            this.videoUrl = videoUrl;
        }

        public async override Task Run()
        {
            receiver.DownloadVideo(videoUrl);
        }

        public override void Cancel()
        { }
    }
}
