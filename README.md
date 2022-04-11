# DaprResearch
  
## Initialise Dapr
  
Follow the Dapr documentation to initialise Dapr  
  
> https://docs.dapr.io/getting-started/
  
## About Dapr

Dapr is a tool that simplifies microservice connectivity. It handles all the complex activities regarding microservice management, allowing developers to focus on business logic.

## Publisher & Subscriber Test
  
One of the many applications of Dapr is message handling. This means that one service can publish a message to a queue and another can subscribe to this queue and understand the message. All of this is handled by the Dapr sidecar and configured simply using one .yaml file.  
  
This repo contains two services:
- DaprSubscriber
- DaprPublisher

### Run Subscriber Project

Ensure Dapr container is running by following Getting Started guide  
  
Run the following commands  

> cd [RepoDirectory]/DaprResearch/DaprSubscriber  
> dapr run --app-id DaprSubscriber --components-path ../../components --app-port 7001 -- dotnet run

### Run Publisher Project

Ensure Dapr container is running by following Getting Started guide  

Run the following commands

> cd [RepoDirectory]/DaprResearch/DaprPublisher  
> dapr run --app-id DaprPublisher --components-path ../../components -- dotnet run