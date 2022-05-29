using Atturra.Assignment.Services;
using Atturra.Assignment.Services.Factory;
using Atturra.Assignment.Services.Factory.Interface;
using Atturra.Assignment.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace Atturra.Assignment
{
    public static class AppConfiguration
    {
        public static ServiceProvider ConfigureServices()
        {
            //set up dependancies with required services
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<IIncomeTaxService, IncomeTaxService>()
                .AddSingleton<IMedicareLevyService, MedicareLevyService>()
                .AddSingleton<IBudgetRepairLevyService, BudgetRepairLevyService>()
                .AddSingleton<IIncomeCalculatorFactory, IncomeCalculatorFactory>()
                .BuildServiceProvider();


            return serviceProvider;
        }
    }
}
