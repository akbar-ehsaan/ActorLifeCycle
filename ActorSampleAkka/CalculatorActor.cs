using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActorSampleAkka
{
    public class CalculatorActor : ReceiveActor

    {

        public CalculatorActor()

        {

            Receive<Add>(add => Sender.Tell(new Answer(add.Term1 + add.Term2)));

        }

    }

    public class Answer

    {

        public Answer(double value)

        {

            Value = value;

        }

        public double Value;

    }

    public class Add

    {

        public Add(double term1, double term2)

        {

            Term1 = term1;

            Term2 = term2;

        }

        public double Term1;

        public double Term2;

    }
}
