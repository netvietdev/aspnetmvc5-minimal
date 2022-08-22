using System;

namespace Rabbit.Business.DbTest
{
    public class NoDbRunnerService : ISimpleRunnerService
    {
        public string Run()
        {
            return string.Format("{0} found {1} items from database at {2}",
                typeof(NoDbRunnerService).Name,
                0,
                DateTime.Now);
        }
    }
}