﻿using System;
using System.Collections.Generic;
using System.Text;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Logging.Serilog.Enrichers;
using Umbraco.Infrastructure.Logging.Serilog.Enrichers;

namespace Umbraco.Infrastructure.Logging.Serilog
{
    public class SerilogComposer : ICoreComposer
    {
        public void Compose(Composition composition)
        {
            composition.RegisterUnique<ThreadAbortExceptionEnricher>();
            composition.RegisterUnique<HttpSessionIdEnricher>();
            composition.RegisterUnique<HttpRequestNumberEnricher>();
            composition.RegisterUnique<HttpRequestIdEnricher>();
        }
    }    
}
