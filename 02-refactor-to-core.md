
# Refactor to .NET Core

## Why Refactor

WIP

### Analyze for .NET core

1. Microsoft provides a great tool for this here: [DotNet upgrade assistant](https://dotnet.microsoft.com/platform/upgrade-assistant) which currently supports ASP.NET MVC, Windows Forms, and Windows Presentation Foundation (WPF)
2. Install dotnet on your workstation [Microsoft instructions here.](https://dotnet.microsoft.com/download)
  
3. Once you have dotnet installed install the opensource upgrade assistant:

    ```shell
    dotnet tool install -g upgrade-assistant
    ```

### Convert to .NET core

1. Do S2I build to Dev
2. Run integration tests
3. Scale up and down
4. Notice resource requirements
5. Simulate load

### Convert to serverless using knative

1. Enable serverless builds
2. Simulate load, watch it scale
3. Add health checks in code and K8
4. Re-deploy and watch it use health checks and liveness

### CI/CD 🎉Secure, Healthy, Autoscaling🎉

1. Plug everything above into a sample pipeline
2. Use Sonarqube to check code smell
3. Check ACS in pipeline to validate container security
