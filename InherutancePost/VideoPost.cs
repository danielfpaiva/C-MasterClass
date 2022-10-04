using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InheritancePost
{
    class VideoPost : Post
    {
        protected bool isPlaying = false;
        protected int duration = 0;
        protected Timer timer;

        protected string videoURL;

        protected int length;

        public VideoPost(string title,string sendByUsername, string videoURL, int length, bool isPublic)
        {
            this.id = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            this.videoURL = videoURL;
            this.length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                Console.WriteLine("Playing...");
                timer = new Timer(TimerCallback, null, 0, 1000);

            }
            
        }

        private void TimerCallback(Object o)
        {
            if (duration < length)
            {
                duration++;
                Console.WriteLine("Video at {0}s", duration);
                GC.Collect();
            } else
            {
                Stop();
            }
        }

        public void Stop()
        {
            Console.WriteLine("Stopped at {0}s", duration);
            duration = 0;
            timer.Dispose();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - duration: {3} - by {4}", id, Title, videoURL, length, SendByUsername);
        }
    }
}
