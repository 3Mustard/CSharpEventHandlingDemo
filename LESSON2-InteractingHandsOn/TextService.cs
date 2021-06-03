using System;

namespace LESSON2_InteractingHandsOn
{
    class TextService
    {
        public void OnVideoEncoded(Object source, VideoEventArgs ev)
        {
            Console.WriteLine("TextService: Text sent... " + ev.Video.Title);
        }
    }
}
