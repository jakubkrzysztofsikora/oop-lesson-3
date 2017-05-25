using System;
using MadScientistLab.Laboratory.Cli;

namespace MadScientistLab.Api
{
    public class ResponseMessages : ICommandInterface
    {
        public string Message { get; set; }

        public void DisplayError(string message)
        {
            Message = message;
        }

        public void DisplayInfo(string message)
        {
            Message = message;
        }

        public void DisplayBark(string name)
        {
            Message = $"{name} ouaf ouaf";
        }

        public void DisplayPurr(string name)
        {
            Message = $"{name} miaou miaou";
        }

        public void DisplaySqueak(string name)
        {
            Message = $"{name} crii crii";
        }
    }
}
