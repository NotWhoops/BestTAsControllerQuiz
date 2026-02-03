using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestTAsControllerQuiz.Models;
using BestTAsControllerQuiz.Services;
using Microsoft.AspNetCore.Mvc;

namespace BestTAsControllerQuiz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BestTAsController : ControllerBase
    {
        [HttpGet("AddingTwoNumbers/{num1}/{num2}")]
        public int AddingTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
        [HttpGet]
        [Route("ReverseIt/{words}")]
        public string ReverseIt(string words)
        {
           string reversedWord = "";

            for (int i = words!.Length - 1; i >= 0; i--)
            {
                reversedWord += words[i];
            }

            return $"Your input was {words} and this is the reversed {reversedWord}";
        }
        [HttpGet]
        [Route("SayHello/{name}")]
        public string SayHello(string name)
        {
            return $"Hello {name}!";
        }
        private readonly ISayHelloServices _SayHelloService;
        public BestTAsController(ISayHelloServices sayHelloService)
        {
            _SayHelloService = sayHelloService;
        }
        [HttpGet]
        public List<SayHelloTwo> GetAllHellos()
        {
            return _SayHelloService.GetSayHelloTwos();
        }
    }
}