# Broker Pattern example in .NET remoting


## Build

This example has been developed using Visual Studio 2017 Enterprise Edition

Open Broker-Sample.sln to build and run
The output of Debug mode will be in <Solution_Dir>\bin\Debug


## Deployment & Usage

### Broker application
- Broker.exe
- IService.dll
```
$ Broker.exe
```

### Server application
- Server.exe
- IService.dll

```
$ Server.exe [port_number]
```

### Client application
- Client.exe
- IService.dll

```
$ Client.exe
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)