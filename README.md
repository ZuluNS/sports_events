# sports_events

An ASP.NET web application for capturing and managing different types of sports events and their participants. Organisers create and manage events, while public users browse upcoming events and view results from past events.

---

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [User Roles](#user-roles)
- [Tech Stack](#tech-stack)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
- [Configuration](#configuration)
- [Database](#database)
- [Usage](#usage)
- [Data Model](#data-model)
- [Roadmap](#roadmap)
- [Contributing](#contributing)
- [License](#license)

---

## Overview

sports_events provides a single place to:

- Capture details of different kinds of events (e.g. races, tournaments, competitions, workshops, meetups).
- Register and track participants for each event.
- Record and publish results once an event has finished.
- Let the public see what is coming up and how past events went.

---

## Features

### For Organisers
- Secure login to an organiser dashboard
- Create, edit, cancel, and delete events
- Categorise events by type
- Set date, time, venue, description, capacity, and registration deadline
- Capture and manage participants (add, edit, remove, check in)
- Capture and publish event results (positions, scores, times, notes)
- View an overview of upcoming, ongoing, and completed events
- Search, filter, and sort events and participants

### For Users (Public)
- Browse a list of upcoming events
- View full event details
- View results from past events
- Filter events by type, date, or location
- Responsive layout for desktop and mobile

---

## User Roles

| Role | Access |
|------|--------|
| **Visitor / User** | View upcoming events and past event results. Read-only. |
| **Organiser** | Full access to create and manage events, participants, and results. Requires login. |
| **Admin** *(optional)* | Manage organiser accounts and system settings. |

---

## Tech Stack

- **Framework:** ASP.NET Core (MVC / Razor Pages) *(update to match your project)*
- **Language:** C#
- **ORM:** Entity Framework Core
- **Database:** SQL Server *(or SQLite / PostgreSQL)*
- **Authentication:** ASP.NET Core Identity
- **Front end:** Razor views, Bootstrap, JavaScript
- **IDE:** Visual Studio 2022 / VS Code / JetBrains Rider

---

## Project Structure

```
sports_events/
├── Controllers/        # Request handling (Events, Participants, Results, Account)
├── Models/             # Entity classes and view models
├── Views/              # Razor views (public pages and organiser dashboard)
├── Data/               # DbContext, migrations, seed data
├── Services/           # Business logic
├── wwwroot/            # Static files (CSS, JS, images)
├── appsettings.json    # Application configuration
├── Program.cs          # Application entry point
└── README.md
```

*(Adjust folder names to match your actual solution.)*

---

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version matching your project, e.g. 8.0)
- SQL Server, SQL Server Express, or LocalDB
- Git
- Visual Studio 2022 or VS Code (optional)

### Installation

1. **Clone the repository**

   ```bash
   git clone https://github.com/your-username/sports_events.git
   cd sports_events
   ```

2. **Restore dependencies**

   ```bash
   dotnet restore
   ```

3. **Configure the database connection** (see [Configuration](#configuration))

4. **Apply database migrations**

   ```bash
   dotnet ef database update
   ```

5. **Run the application**

   ```bash
   dotnet run
   ```

6. Open your browser and go to `https://localhost:5001` (or the URL shown in the console).

---

## Configuration

Update `appsettings.json` with your connection string:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=SportsEventsDb;Trusted_Connection=True;"
  }
}
```

For sensitive values (passwords, API keys), use [User Secrets](https://learn.microsoft.com/aspnet/core/security/app-secrets) during development:

```bash
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "your-connection-string"
```

### Default Organiser Account

If seed data is enabled, a default organiser account is created on first run:

| Field | Value |
|-------|-------|
| Email | `organiser@example.com` |
| Password | `ChangeMe123!` |

> **Important:** Change these credentials immediately and never use defaults in production.

---

## Database

The application uses Entity Framework Core migrations.

```bash
# Add a new migration
dotnet ef migrations add MigrationName

# Apply migrations
dotnet ef database update

# Roll back to a previous migration
dotnet ef database update PreviousMigrationName
```

---

## Usage

### Organisers

1. Log in via the **Organiser Login** page.
2. From the dashboard, select **Create Event** and fill in the event details.
3. Open an event to add or manage participants.
4. After the event, open **Results** and capture each participant's outcome.
5. Publish the results so they become visible to the public.

### Users

1. Visit the home page to see **Upcoming Events**.
2. Click an event to view its details.
3. Go to **Past Events** to see completed events and their results.

---

## Data Model

| Entity | Key Fields |
|--------|-----------|
| **Event** | Id, Title, Description, EventType, Date, Location, Capacity, Status |
| **Participant** | Id, FullName, Email, Phone, EventId, RegistrationDate, CheckedIn |
| **Result** | Id, EventId, ParticipantId, Position, Score/Time, Notes, IsPublished |
| **EventType** | Id, Name |
| **User (Identity)** | Id, Email, Role |

**Relationships**
- An Event has many Participants.
- An Event has many Results.
- A Result belongs to one Participant and one Event.
- An Event belongs to one EventType.

---

## Roadmap

- [ ] Public participant self-registration
- [ ] Email confirmations and reminders
- [ ] Export participants and results (CSV / PDF)
- [ ] Event image uploads
- [ ] Calendar view and iCal export
- [ ] Leaderboards and participant history
- [ ] REST API for mobile apps

---

## Contributing

1. Fork the repository
2. Create a feature branch: `git checkout -b feature/your-feature`
3. Commit your changes: `git commit -m "Add your feature"`
4. Push to the branch: `git push origin feature/your-feature`
5. Open a Pull Request

---

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.

---

## Contact

Maintained by **Your Name** — your.email@example.com
