# Example Application

This is a demo application using `Io.Gate.GateApi` to show how Gate APIv4 works. 
Instead of running it, it is recommended to read the source code to get a general idea of
how this SDK is used. However, you can modify this code directly to implement your own logic.

## Build

1. Clone this SDK project and run `dotnet build` in the cloned project to build the library.
    
    > default target framework is `netstandard2.0`, you can change it into local framework
    > available, but [framework supported](../README.md#frameworks-supported) must be satisfied.

2. Create our demo project directory along side the SDK project like the following:

    ```bash
    mkdir GateApiDemo && cd GateApiDemo
    dotnet new console -lang C#
    ```
   
3. Copy all the files in the example directory to `GateApiDemo` project created above.
4. Edit the `GateApiDemo.csproj` file; change the `TargetFramework` to the target framework used 
   in building the SDK; Change the `HintPath` to the path of SDK dll file generated in step 1
5. Run `dotnet build` to build the demo application, which will probably be generated at 
   `bin/Debug/<framework-used>/GateApiDemo.dll`

## Run

**READ THIS BEFORE YOU RUN ANYTHING**

**This application is shown for demo only. It will try to use your input API key and secret to
trade, lend and borrow, etc. Make sure you know exactly what it does before running it.**

> Examples shown below use `dotnet run` to run the application without explicit building.
> You can change to `dotnet /path/to/your/demo/dll` after `dotnet build` to avoid building every time
> before running.

```bash
# run futures demo against TestNet
dotnet run futures -k <YOUR_TESTNET_API_KEY> -s <YOUR_TESTNET_API_SECRET> -u fx-api-testnet.gateio.ws

# run futures demo against real trading
dotnet run futures -k <YOUR_API_KEY> -s <YOUR_API_SECRET>

# run spot demo
dotnet run spot -k <YOUR_API_KEY> -s <YOUR_API_SECRET>

# run margin demo
dotnet run margin -k <YOUR_API_KEY> -s <YOUR_API_SECRET>
```
