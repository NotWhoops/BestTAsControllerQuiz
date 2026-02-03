using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestTAsControllerQuiz.Models;

namespace BestTAsControllerQuiz.Services
{
    public class SayHelloServices
    {
        private readonly List<SayHelloTwo> aSayHello;

        public List<SayHelloTwo> GetSayHelloTwos()
        {
            return aSayHello;
        }
    }
}