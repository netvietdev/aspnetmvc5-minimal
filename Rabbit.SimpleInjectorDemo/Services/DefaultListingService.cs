using System;

namespace Rabbit.SimpleInjectorDemo.Services
{
    public class DefaultListingService : IListingService
    {
        public int Count()
        {
            return new Random().Next(0, 101);
        }
    }
}