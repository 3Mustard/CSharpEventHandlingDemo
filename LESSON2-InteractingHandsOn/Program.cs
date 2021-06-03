namespace LESSON2_InteractingHandsOn
{
    // START HERE OR LINE 16 IN VIDEOENCODER.CS
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Objects
            Video video = new Video("Vid1");
            VideoEncoder videoEncoder = new VideoEncoder(); //publisher
            MailService mailService = new MailService(); //subscriber One
            TextService textService = new TextService(); //subscriber Two

            // Add subscribers to events, in this example the event is VideoEncoded in the VideoEncoder Class
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // EX ~ a reference/pointer to mailService.OnVideoEncoded is added to the event vEncoder.VideoEncoded
            videoEncoder.VideoEncoded += textService.OnVideoEncoded;

            // Call the Encode method in the VideoEncoder Class, passing the Video as a parameter
            videoEncoder.Encode(video);
        }
    }
}
