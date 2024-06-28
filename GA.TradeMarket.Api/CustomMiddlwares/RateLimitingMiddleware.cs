﻿using System.Net;

namespace GA.TradeMarket.Api.CustomMiddlwares
{
    public class RateLimitingMiddleware
    {
        private readonly RequestDelegate _next;

        private static Dictionary<string, ClientRequestInfo> _clients = new Dictionary<string, ClientRequestInfo>();

        private readonly int _maxRequests = 10;
        private readonly TimeSpan _timeWindow = TimeSpan.FromMinutes(1);

        public RateLimitingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var clientIp = context.Connection.RemoteIpAddress.ToString();

            if (!_clients.ContainsKey(clientIp))
            {
                _clients[clientIp] = new ClientRequestInfo
                {
                    RequestCount = 1,
                    ExpiryTime = DateTime.Now.Add(_timeWindow)
                };
            }
            else
            {
                var clientInfo = _clients[clientIp];

                if (clientInfo.ExpiryTime > DateTime.Now)
                {
                    if (clientInfo.RequestCount >= _maxRequests)
                    {
                        context.Response.StatusCode = (int)HttpStatusCode.TooManyRequests;
                        await context.Response.WriteAsync("Rate limit exceeded. Try again later.");
                        return;
                    }
                    else
                    {
                        clientInfo.RequestCount++;
                    }
                }
                else
                {
                    clientInfo.RequestCount = 1;
                    clientInfo.ExpiryTime = DateTime.Now.Add(_timeWindow);
                }
            }

            await _next(context);
        }

        private class ClientRequestInfo
        {
            public int RequestCount { get; set; }
            public DateTime ExpiryTime { get; set; }
        }
    }
}
