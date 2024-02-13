namespace HelloWorld
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a txt message..." + args.Video.Title);
        }
    }
}
