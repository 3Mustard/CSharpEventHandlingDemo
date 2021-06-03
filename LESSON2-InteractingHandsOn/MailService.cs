using System;

namespace LESSON2_InteractingHandsOn
{
    class MailService
    {
        public void OnVideoEncoded(Object source, VideoEventArgs ev)
        {
            Console.WriteLine("MailService: Email sent... " + ev.Video.Title);
        }
    }
}
