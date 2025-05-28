# ScoreSite

This repository contains a very small example of a website project with a Vue.js frontend and a C# .NET backend.

```
frontend/ - Simple Vue.js single page
backend/  - Minimal ASP.NET Core API
```

## Running the frontend
Open `frontend/index.html` in a browser. It loads Vue from a CDN and displays a greeting.

## Running the backend
You need the .NET SDK installed. Run the following command from the repository root:

```bash
dotnet run --project backend/ScoreSiteApi/ScoreSiteApi.csproj
```

