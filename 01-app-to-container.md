# VM to Windows Container

## Start with sample .net framework app running on a vm

1. What is the overhead? (cpu and memory utilization)

### Migrate application in windows container

1. Microsoft provides supported containers for the latest versions of dotnet framework on docker hub and hosts them via MCR (Microsoft Container Registry):

    | Version       | Container location                         |
    |---------------|--------------------------------------------|
    | 4.8           | mcr.microsoft.com/dotnet/framework/sdk:4.8 |
    | 3.5           | mcr.microsoft.com/dotnet/framework/sdk:3.5 |
    | 5.0 (Current) | mcr.microsoft.com/dotnet/runtime:5.0       |
    | 3.1 (LTS)     | mcr.microsoft.com/dotnet/runtime:3.1       |

2. Install dotnet framework application into windows container
3. Apply health checks
