using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using ATH.TestTaskPlatform.Backend.Domain.Services;
using Functional.Fluent.Extensions;
using Functional.Fluent.Helpers;

namespace ATH.TestTaskPlatform.Backend.Filters
{
    public class ScopeFilterAttribute : Attribute, IActionFilter
    {
        private IScopeService _scopeService;

        public IScopeService ScopeService
        {
            get {  return _scopeService;}
            set { _scopeService = value; }
        }

        public bool AllowMultiple { get; } = false;

        public async Task<HttpResponseMessage> ExecuteActionFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
        {
            var scopeId = (Guid) actionContext.ActionArguments["scopeId"];
            var scope = _scopeService.ById(scopeId);
            if (scope.IsFailed || !scope.Value.Active)
                return new HttpResponseMessage(HttpStatusCode.Forbidden);

            int delay = scope.PureSuccess(v =>
            {
                if (v.MinDelay != null && v.MaxDelay != null)
                {
                    return (int) (new Random().NextDouble()*(v.MaxDelay.Value - v.MinDelay.Value) + v.MinDelay.Value);
                }
                return 0;
            }).PureFail(0);

            if (delay > 0)
                Thread.Sleep(delay);

            scope.Success(v =>
            {
                if (v.PhantomError != null)
                {
                    if (new Random().NextDouble() < v.PhantomError.Value)
                        throw new PhantomErrorException();
                }
                return Result.Success();
            });

            return await continuation();
        }
    }
}