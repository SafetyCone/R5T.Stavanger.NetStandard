using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using R5T.Chalandri.DropboxRivetTestingData;
using R5T.Evosmos.CDriveTemp;
using R5T.Richmond;

using R5T.Stavanger.Default;


namespace R5T.Stavanger.NetStandard.Construction
{
    public class Startup : StartupBase
    {
        public Startup(ILogger<Startup> logger) : base(logger)
        {
        }

        protected override void ConfigureServicesBody(IServiceCollection services)
        {
            services
                .AddSingleton<Program>()
                .AddNetStandardShortcutOperator(
                    services.AddDefaultShortcutPathConventionsAction())
                .AddTestingDataDirectoryContentPathsProvider()
                .AddTemporaryDirectoryFilePathProvider()
                ;
        }
    }
}
