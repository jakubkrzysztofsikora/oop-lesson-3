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
            throw new NotImplementedException();
        }

        public void DisplayPurr(string name)
        {
            throw new NotImplementedException();
        }

        public void DisplaySqueak(string name)
        {
            throw new NotImplementedException();
        }
    }
}
