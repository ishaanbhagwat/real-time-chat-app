# real-time-chat-app
## Description
A simple real-time chat application built with ASP.NET Core and SignalR that allows users to send and receive messages instantly, leveraging WebSockets for real-time communication. The application also integrates Redis as a backplane to scale the chat across multiple servers, ensuring smooth messaging in distributed environments.

### Real-time work flow
1. A client sends a message via Server instance A.
2. Server instance A pushes the message to Redis.
3. Redis distributes the message to Server instance B, Server instance C, etc.
4. These servers deliver the message to their connected clients.

Since WebSocket connections are server-specific, we use Backplane to synchronize messages across distributed servers.

A Backplane is a shared message store (Redis) to synchronize real-time messages across different server instances of this application.

### Demo
<img width="789" alt="Screenshot 2025-01-25 at 1 09 00 PM" src="https://github.com/user-attachments/assets/897950e7-8720-49fd-82cc-5ee11d914c92" />

## Technologies Used
- **ASP.NET Core**: Backend framework for building the API and real-time communication.
- **SignalR**: Library for real-time communication using WebSockets.
- **Redis**: In-memory data store used as the backplane for scaling SignalR.
- **HTML + JavaScript**: Simple frontend to interact with the chat server.

## Setup Instructions
### Installation
1. Install .NET SDK - [Apple Silicon Installation](https://download.visualstudio.microsoft.com/download/pr/96489126-b9ba-414a-a2d0-d8c5b61a22be/fe047e117e9cc43738ba2222f4769da2/dotnet-sdk-9.0.102-osx-arm64.pkg)
2. Optional - Install Docker and Pull latest Redis image
```bash
docker pull redis:latest
```
3. Clone this repository
```bash
git clone <https://github.com/ishaanbhagwat/real-time-chat-app>
cd RealTimeChatApp
```
### Application Startup
1. Start Redis
```bash
docker run -d -p 6379:6379 redis

```
2. Restore Dependencies and Build Application
```bash
dotnet restore
dotnet build
```
3. Run Application
```bash
dotnet run
```

4. Start chatting!
- Navigate to http://localhost:5076 on your machine.
