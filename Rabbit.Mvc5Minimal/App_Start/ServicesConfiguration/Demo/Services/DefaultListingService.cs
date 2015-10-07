using System;

namespace Rabbit.Mvc5Minimal.App_Start.ServicesConfiguration.Demo.Services
{
    public class DefaultListingService : IListingService
    {
        public int Count()
        {
            return new Random().Next(0, 101);
        }
    }
}