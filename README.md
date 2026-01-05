# Task Scheduler

A comprehensive backend application built with .NET to learn full-stack C# development fundamentals.

## Project Vision

This project serves as a complete learning platform covering all essential areas of modern backend development. By implementing a task scheduler system, you'll gain hands-on experience with core C# concepts, architectural patterns, and production-ready practices.

## Learning Objectives

Master the following C# and .NET concepts:
- Language fundamentals (syntax, types, generics, null-coalescing, pattern matching)
- Object-oriented and functional programming patterns
- Async/await and concurrent programming
- Dependency injection and inversion of control
- Entity Framework Core (database ORM)
- ASP.NET Core (REST API development)
- Authentication and authorization
- Background job processing and scheduling
- Logging and observability
- Error handling and resilience patterns
- Unit and integration testing
- Configuration management across environments

## Features (Planned)

### Phase 1: Core CRUD & Data Persistence
- [ ] Task entity model and database schema
- [ ] User entity model with roles
- [ ] Create, read, update, delete operations
- [ ] Data validation and error handling
- [ ] Repository pattern implementation

### Phase 2: REST API
- [ ] RESTful endpoints for task management
- [ ] RESTful endpoints for user management
- [ ] Request/response DTOs (Data Transfer Objects)
- [ ] Proper HTTP status codes and error responses
- [ ] Input validation and sanitization

### Phase 3: Authentication & Authorization
- [ ] User registration and login
- [ ] JWT token-based authentication
- [ ] Role-based authorization
- [ ] Secure password handling

### Phase 4: Task Scheduling & Execution
- [ ] Task scheduling logic (one-time, recurring patterns)
- [ ] Background worker service
- [ ] Task execution engine
- [ ] State management during execution

### Phase 5: Task History & Auditing
- [ ] Execution history tracking
- [ ] Audit logging
- [ ] Task result persistence
- [ ] Error tracking and debugging information

### Phase 6: Notifications & Events
- [ ] Event-driven architecture
- [ ] Task completion notifications
- [ ] Failure alerts
- [ ] Extensible notification system

### Phase 7: Resilience & Reliability
- [ ] Retry policies for failed tasks
- [ ] Timeout handling
- [ ] Dead letter queues for failed items
- [ ] Circuit breaker patterns

### Phase 8: Testing
- [ ] Unit tests for business logic
- [ ] Integration tests for API endpoints
- [ ] Database testing strategies
- [ ] Mocking and test fixtures

### Phase 9: Documentation & Configuration
- [ ] Swagger/OpenAPI documentation
- [ ] Environment-based configuration
- [ ] Deployment readiness

## Tech Stack (Planned)

- **Runtime**: .NET 10
- **Web Framework**: ASP.NET Core
- **Database**: SQL Server (or PostgreSQL)
- **ORM**: Entity Framework Core
- **Logging**: Serilog
- **Testing**: xUnit, Moq
- **Job Scheduling**: Quartz.NET or similar
- **Authentication**: JWT (System.IdentityModel.Tokens.Jwt)

## Prerequisites

- .NET 10 SDK
- A code editor (VS Code, Visual Studio, or similar)
- Git

## Getting Started

(To be filled in as project develops)

```bash
# Build the project
dotnet build

# Run the application
dotnet run

# Run tests
dotnet test
```

## Project Structure

```
task-scheduler/
├── src/
│   ├── TaskScheduler.API/          # ASP.NET Core API
│   ├── TaskScheduler.Core/         # Business logic and domain models
│   ├── TaskScheduler.Infrastructure/ # Database, external services
│   └── TaskScheduler.Common/       # Shared utilities
├── tests/
│   ├── TaskScheduler.Tests/        # Unit tests
│   └── TaskScheduler.Integration.Tests/
├── README.md
└── task-scheduler.sln
```

(To be refined as the project develops)

## Learning Path

Start with Phase 1 to establish core C# fundamentals, then progress sequentially through each phase, pausing to research and understand concepts before implementation.

---

**Status**: Project initialization phase
**Last Updated**: January 5, 2026
