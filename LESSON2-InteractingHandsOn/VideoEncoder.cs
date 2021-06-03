using System;
using System.Threading;

// START AT LINE 16 OR PROGRAM.CS
namespace LESSON2_InteractingHandsOn
{
    // This class represents parameters sent when an event is called
    // in addidtion to EventArgs I want to send a Video object with my event
    class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    class VideoEncoder
    {
        // ~START~
        // Create an event with custom arguements(VideoEventArgs line 9)
        // Two ways to do this

        // Method One
        // 1. define a delegate
        // public delegate void VideoEncodedEventHandler(Object source, VideoEventArgs args);
        // 2. define an event based on that delegate
        // public event VideoEncodedEventHandler VideoEncoded;

        // Method Two
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("encoding video...");
            Thread.Sleep(3000);

            // 3. Raise the event
            OnVideoEncoded(video);
        }

        // Method that will invoke the event VideoEncoded
        protected virtual void OnVideoEncoded(Video video)
        {
            // 4. Check for event subsribers (MailService,TextService, ect..)
            // check program.cs for list of subscribers and how they are added
            if (VideoEncoded != null)
            {
                // Create the event arguements
                VideoEventArgs videoEventArgs = new VideoEventArgs() { Video = video };

                // 5. Call Event
                VideoEncoded(this, videoEventArgs);
            }
        }
    }
}
