using Elsa.ActivityResults;
using Elsa.Services;
using Elsa.Services.Models;

namespace Elsa.Server.Activities
{
    public class ChangeBody : Activity
    {
        protected override IActivityExecutionResult OnExecute(ActivityExecutionContext context)
        {
            context.GetVariable<dynamic>("Document")!.Body = "Test";

            return Done();
        }
    }
}
