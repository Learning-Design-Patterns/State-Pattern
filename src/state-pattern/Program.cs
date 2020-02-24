using System;

namespace state_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var directionService = new DirectionService(new DrivingMode());
            Console.WriteLine(directionService.GetDirection());
            Console.WriteLine(directionService.GetEta());
        }
    }
}