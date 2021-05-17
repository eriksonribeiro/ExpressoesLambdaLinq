using System;

namespace AdvancedConceptsMosh
{
    partial class Program
    {
        static void Main(string[] args)
        {
            #region Delegate
            Console.WriteLine("Using Delegate with Lambda Expression to Calculate a square");
            DelegatesConcepts.FuncWithLambdaExpression();
            #endregion

            #region LambdaExpression
            Console.WriteLine("\nUsing LambdaExpression");
            LambdaExpressionConcepts.CheapBooks();
            #endregion

            #region EventAndDelegate
            //Events and Delegate
            Console.WriteLine("\nUsing EventAndDelegate Concepts");
            var video = new Video() { Title = "RuPaul Great Finally" };
            var videoEncoder = new VideoEncoder();     // publisher
            var mailService = new MailService();       // subscriber
            var messageService = new MessageService(); // subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
            #endregion

            #region ExtensionMethods
            Console.WriteLine("\nUsing Extension Methods");
            string post = "This is supported to be a very long blog";
            var shortenedPost = post.Shorten(3);
            Console.WriteLine(shortenedPost);
            #endregion

            #region Task
            //Tarefas.ShowTasks();
            #endregion

            #region Struct
            Console.WriteLine("\nUsing Struct");
            NewStruct struct1 = new NewStruct() { publicNumber = 10 };
            struct1.ShowNumber();
            #endregion

            #region Exception Handling
            Console.WriteLine("\nUsing Exception Treatement");
            ExceptionTreatement.DivisionByZero();
            ExceptionTreatement.UsingStatement();

            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("erikson");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion

            #region eNum
            Console.WriteLine("\nUsing Enum");
            var myEnum = new UsingEnum();
            myEnum.weekDay = WeekDays.Friday;
            myEnum.ShowEnum();
            #endregion

            #region LINQ
            Console.WriteLine("\nUsing Linq");
            WorkingWithLinq.LinqResults();
            #endregion

            #region Nullable Type
            Console.WriteLine("\nNullAbleType");
            WorkingWithNullableType.ShowResult();
            #endregion

            #region Dynamic
            #endregion



            Console.ReadKey();
        }
    }
}
