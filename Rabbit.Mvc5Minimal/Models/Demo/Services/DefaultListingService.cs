using System;

namespace Rabbit.Mvc5Minimal.Models.Demo.Services
{
    public class DefaultListingService : IListingService
    {
        public int Count()
        {
            return new Random().Next(0, 101);
        }
    }
}