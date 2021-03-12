# Mediclick API

Mediclick is a API to get the users information.
It has two methods

### [Access to the publish API](https://mediclickapp.azurewebsites.net)

- To get all users:
```sh
/demo/v1/account
```
- To get user by id:
```sh
/demo/v1/account/{id}/record
```

## Features

- Create a HTML file to better experience
- Using SwaggerUI implementation 

## Installation

Mediclick requires [NetCore](https://dotnet.microsoft.com/download) v3.1+ to run.

## Development

Mediclick uses Azure for fast developing.

Open your favorite Terminal and run these commands.

First Tab:

```sh
dotnet publish --runtime win-x64
```

#### Building for source

For production release:

```sh
dotnet build -r win-x64 -c Release
```
