
using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActorSampleAkka
{
    public class EmailMessage

    {

        public EmailMessage(string from, string to, string content)

        {

            From = from;

            To = to;

            Content = content;

        }

        public string From { get; }

        public string To { get; }

        public string Content { get; }

    }
    public class EmailSenderActor : ReceiveActor

    {

        public EmailSenderActor()

        {

            Console.WriteLine("Constructor() -> EmailSenderActor");

            Receive<EmailMessage>(message => HandleEmailMessage(message));

        }

        private void HandleEmailMessage(EmailMessage message)

        {

            if (string.IsNullOrEmpty(message.Content))

            {

                throw new ArgumentException("Cannot handle the empty content");

            }

            Console.WriteLine($"email sent from {message.From} to {message.To} with content :{message.Content}");
        }

        protected override void PreStart()

        {

            Console.WriteLine("PreStart() -> EmailSenderActor");



        }

        protected override void PreRestart(Exception reason, object message)

        {

            Console.WriteLine("PreRestart() -> EmailSenderActor");

            /* base.PreRestart(reason, message); */

        }

        protected override void PostRestart(Exception reason)

        {

            Console.WriteLine("PostRestart() -> EmailSenderActor");

            base.PostRestart(reason);

        }

        protected override void PostStop()

        {

            Console.WriteLine("PostStop() -> EmailSenderActor");

        }

    }
}
