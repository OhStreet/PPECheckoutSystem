# PPE Checkout System

ASP.NET Core MVC application for tracking PPE and equipment checkout/check-in records.

## Requirements

- Visual Studio 2022 or later
- .NET SDK installed
- SQL Server LocalDB
- Git

## Setup Instructions

1. Clone the repository:

   ```bash
   git clone <repo-url>
   cd PpeCheckoutSystem
   ```

2. Restore dependencies:

   ```bash
   dotnet restore
   ```

3. Install or update the EF Core CLI tool:

   ```bash
   dotnet tool install --global dotnet-ef
   ```

   If `dotnet-ef` is already installed, update it instead:

   ```bash
   dotnet tool update --global dotnet-ef
   ```

4. Create the local database from migrations:

   ```bash
   dotnet ef database update
   ```

5. Run the application:

   ```bash
   dotnet run
   ```

6. Open the local URL shown in the terminal.

## Branch Workflow

Before starting work, pull the latest version of `main`:

```bash
git checkout main
git pull
```

Create a new branch for your work:

```bash
git checkout -b feature/short-description
```

Example:

```bash
git checkout -b feature/add-employee-form
```

After making changes:

```bash
git add .
git commit -m "Add employee create form"
git push -u origin feature/add-employee-form
```

Then open a pull request on GitHub.

## Team Rules

- Do not commit `bin/`, `obj/`, `.vs/`, or local database files.
- Commit migration files when the database schema changes.
- Run `dotnet ef database update` after pulling new migrations.
- Work on feature branches, not directly on `main`.
- Keep commits focused on one feature or fix when possible.

## Common Commands

Run the project:

```bash
dotnet run
```

Create a new migration after changing models:

```bash
dotnet ef migrations add MigrationName
```

Apply migrations to the local database:

```bash
dotnet ef database update
```

Check Git status:

```bash
git status
```

Pull latest changes:

```bash
git pull
```
