rem API Key �� nuget.org ����擾���� nuget setApiKey xxxx �ŃZ�b�g���Ă�������
dotnet nuget push ..\LivetCask.Extensions\bin\Release\LivetExtensions.*.nupkg -s https://www.nuget.org/api/v2/package
dotnet nuget push ..\LivetCask.EventListeners\bin\Release\LivetCask.EventListeners.*.nupkg -s https://www.nuget.org/api/v2/package
dotnet nuget push ..\LivetCask.Converters\bin\Release\LivetCask.Converters.*.nupkg -s https://www.nuget.org/api/v2/package
dotnet nuget push ..\LivetCask.Behaviors\bin\Release\LivetCask.Behaviors.*.nupkg -s https://www.nuget.org/api/v2/package
dotnet nuget push ..\LivetCask\bin\Release\LivetCask.*.nupkg -s https://www.nuget.org/api/v2/package
