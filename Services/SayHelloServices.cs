using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestTAsControllerQuiz.Models;

namespace BestTAsControllerQuiz.Services
{
    public class SayHelloServices : ISayHelloServices
    {
        private readonly List<SayHelloTwo> aSayHello;

        public List<SayHelloTwo> GetSayHelloTwos()
        {
            return aSayHello;
        }

        public SayHelloServices()
        {
            aSayHello = new List<SayHelloTwo>
            {
                new SayHelloTwo {Id = 1, SayHello1 = "Hello"}
            };
        }

        public SayHelloTwo? Update(int id, SayHelloTwo updated)
        {
            SayHelloTwo? hello = aSayHello.FirstOrDefault(c => c.Id == id);

            if(hello == null)
            {
                return null;
            }
            hello.SayHello1 = updated.SayHello1;

            return hello;
        }
    }
}