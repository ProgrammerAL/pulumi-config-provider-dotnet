using Pulumi;
using System;
using System.Collections.Generic;

return await Pulumi.Deployment.RunAsync(() =>
{
    return new Dictionary<string, object?>
    {
        ["Version"] = "abc123",
        ["LastRun"] = DateTime.Now.ToString()
    };
});
