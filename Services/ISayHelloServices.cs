using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestTAsControllerQuiz.Models;

namespace BestTAsControllerQuiz.Services
{
    public interface ISayHelloServices
    {
        List<SayHelloTwo> GetSayHelloTwos();
    }
}