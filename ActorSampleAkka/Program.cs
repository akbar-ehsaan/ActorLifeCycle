// See https://aka.ms/new-console-template for more information
//using Akka.Actor;

//Console.WriteLine("Hello, World!");
//ActorSystem system = ActorSystem.Create("my-first-akka");

//IActorRef typedActor = system.ActorOf<MyTypedActor>();
//IActorRef untypedActor = system.ActorOf<MyUntypedActor>();


//Props typedActorProps =Props.Create<MyTypedActor>();

//Props untypedActorProps = Props.Create<MyUntypedActor>();

//IActorRef typedActor = system.ActorOf(typedActorProps);

//IActorRef untypedActor = system.ActorOf(untypedActorProps);
////-----------------------------------

//Props props1 = Props.Create(typeof(MyTypedActor));

//Props props2 = Props.Create(() => new MyTypedActor("arg"));

//Props props3 = Props.Create<MyTypedActor>();

//Props props4 = Props.Create(typeof(MyTypedActor), "arg");




//public class MyUntypedActor : UntypedActor

//{

//    protected override void OnReceive(object message)

//    {

//        /* some code goes here */

//    }

//}

//public class MyTypedActor : ReceiveActor

//{

//    public MyTypedActor( )

//    {

//        {

//            Receive<GreetingMessage>(message => GreetingMessageHandler(message));

//            Receive<string>(message => GreetingMessageHandler(message));

//        }
//    }

//}
//public class GreetingMessage

//{

//    public GreetingMessage(string greeting)

//    {

//        Greeting = greeting;

//    }

//    public string Greeting { get; private set; }

//}
using ActorSampleAkka;
using Akka.Actor;
using Akka.DI.AutoFac;
using Akka.DI.Core;
using Autofac;


//ActorSystem system = ActorSystem.Create("html-download-system");

//IActorRef receiveAsyncActor = system.ActorOf<DownloadHtmlActor>("html-actor ");

//receiveAsyncActor.Tell("https://www.agile-code.com");

//receiveAsyncActor.Tell("https://www.microsoft.com");

//receiveAsyncActor.Tell("https://www.syncfusion.com");

//---------------------------------
//ActorSystem system = ActorSystem.Create("html-download-system");

//Props props3 = Props.Create<DownloadHtmlActor>();
//IActorRef untypedActor = system.ActorOf(props3);
//untypedActor.Tell("https://www.asriran.com");

//untypedActor.Tell("https://www.asriran.com");

//untypedActor.Tell("https://www.asriran.com");
//Console.ReadLine();
//public class DownloadHtmlActor : ReceiveActor

//{

//    public DownloadHtmlActor()

//    {

//        ReceiveAsync<string>(async url => await GetPageHtmlAsync(url));

//    }

//    private async Task GetPageHtmlAsync(string url)

//    {

//        var html = await new System.Net.WebClient().DownloadStringTaskAsync(url);

//        Console.WriteLine("\n=====================================");

//        Console.WriteLine($"Data for {url}");

//        Console.WriteLine(html.Trim().Substring(0, 100));

//    }

//}
//-----------------------------------------------
//var builder = new Autofac.ContainerBuilder();

//builder.RegisterType<MusicSongService>().As<IMusicSongService>();

//builder.RegisterType<MusicActor>().AsSelf();

//var container = builder.Build();

////2. Create the ActorSystem and Dependency Resolver.

//var system = ActorSystem.Create("MySystem");

//var propsResolver = new AutoFacDependencyResolver(container, system);

////3. Create an Actor reference.

//IActorRef musicAct = system.ActorOf(system.DI().Props<MusicActor>(), "MusicActor");

//musicAct.Tell("Bohemian Rhapsody");

//Console.Read();

//system.Terminate();
//------------------------
//ActorSystem system = ActorSystem.Create("calc-system");

//IActorRef calculator = system.ActorOf<CalculatorActor>("calculator");
//IActorRef calculator2 = system.ActorOf<EmailSenderActor>("emailSender");

//Answer result = calculator.Ask<Answer>(new Add(1, 2)).Result;



//Console.WriteLine("Addition result: " + result.Value);

//system.Terminate();
//------------------


ActorSystem system = ActorSystem.Create("my-first-akka");

IActorRef emailSender = system.ActorOf<EmailSenderActor>("emailSender");

//send an invalid message (null content).
EmailMessage validEmail = new EmailMessage("from@mail.com", "to@mail.com", "Hi");

EmailMessage invalidEMail = new EmailMessage("from@mail.com", "to@mail.com", null);


emailSender.Tell(validEmail);

emailSender.Tell(invalidEMail);

emailSender.Tell(validEmail);

Console.Read();

system.Terminate();