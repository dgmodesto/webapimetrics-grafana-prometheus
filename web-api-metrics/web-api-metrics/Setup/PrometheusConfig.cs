using Microsoft.AspNetCore.Builder;
using Prometheus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_api_metrics.Setup
{
    public static class PrometheusConfig
    {

        public static IApplicationBuilder UsePrometheusConfiguration(this IApplicationBuilder app)
        {
            /*INICIO DA CONFIGURAÇÃO - PROMETHEUS*/

            // Custom Metrics to count requests for each endpoint and the method
            var counter = Metrics.CreateCounter("webapimetric", "Counts requests to the WebApiMetrics API endpoints",
                new CounterConfiguration
                {
                    LabelNames = new[] { "method", "endpoint" }
                });

            app.Use((context, next) =>
            {
                counter.WithLabels(context.Request.Method, context.Request.Path).Inc();
                return next();
            });

            // Use the prometheus middleware
            app.UseMetricServer();
            app.UseHttpMetrics();

            /*FIM DA CONFIGURAÇÃO - PROMETHEUS*/

            return app;

        }
    }
}
