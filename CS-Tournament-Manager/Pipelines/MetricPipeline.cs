using System.Diagnostics;
using MediatR;

namespace CS_Tournament_Manager.Pipelines;

public class MetricPipeline<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : notnull
{
    private readonly ILogger<MetricPipeline<TRequest, TResponse>> _logger;
    public MetricPipeline(ILogger<MetricPipeline<TRequest, TResponse>> logger) => _logger = logger;

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var start = Stopwatch.GetTimestamp();
        var response = await next();
        var elapsedTime = Stopwatch.GetElapsedTime(start);
        _logger.LogInformation("Request {Handler} took {ElapsedTime}ms", typeof(TRequest).Name, elapsedTime);
        return response;
    }
}