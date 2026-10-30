
# FitnessApp

## Project Overview

FitnessApp is a fitness management application designed to help coaches and personal trainers assign and manage workouts for their athletes.

The application provides a digital alternative to traditional paper-based workout plans, allowing athletes to access their assigned workouts directly through the application. This makes it easier for athletes to follow their training programs during regular practices, breaks, or individual training sessions without needing physical workout sheets.

The long-term goal is to make workout instructions more accessible by potentially incorporating instructional videos that demonstrate how to properly perform different exercises.



## Technologies Used

- **C#** – Main programming language used for application logic.
- **ASP.NET Core MVC** – Framework used to build the application using the Model-View-Controller architecture.
- **PostgreSQL** – Relational database used to store application data.
- **Entity Framework Core** – ORM used to interact with the database and manage data operations.
- **HTML** – Used to structure the application's user interface.

## Project Structure

The application follows the ASP.NET Core MVC architecture.

- **Controllers/** – Handles application requests and business logic.
- **Models/** – Contains the data models used by the application.
- **Views/** – Contains the Razor views used to display the user interface.
- **Data/** – Contains the Entity Framework Core database context.
- **SQL/** – Contains SQL scripts for creating database tables and inserting sample data.
- **wwwroot/** – Contains static files such as CSS and JavaScript.

## Features


### Currently Implemented
- Coach login functionality.
- Coaches can view their associated athletes.
- Coaches can add new athletes to their accounts.
- Coaches can view the available exercise list.

### Planned Features
- Allow coaches to add new exercises to the exercise database.
- Allow coaches to create and assign workouts to athletes.
- Allow athletes to log in and view their assigned workouts.
- Allow athletes to record completed workouts.
- Workout history and progress tracking.
- Progress graphs and visualizations.
- Instructional exercise videos.



## Database Structure

FitnessApp uses PostgreSQL as its relational database management system.

The database currently includes the following tables:

- **Coaches** – Stores coach information, including names and contact details.
- **Athletes** – Stores athlete information.
- **Exercises** – Stores available exercises that can be used when creating workouts.
- **WorkoutInfo** – Stores workout information, including the coach, athlete, workout name, completion status, and workout date.
- **Workouts** – Stores individual workout details, including exercises, sets, repetitions, and weight.

Entity Framework Core is used to interact with the database through the application's data models and database context.

### SQL Scripts

The repository includes two SQL scripts:

- **CreateTables.sql** – Contains the SQL statements to create the database tables and their relationships.
- **InsertRows.sql** – Contains SQL INSERT statements to populate the database with sample records.

These scripts can be executed in PostgreSQL when setting up the database.

### Database Configuration

Update the connection string in `appsettings.json` to match your local PostgreSQL configuration.

Do not commit passwords or other sensitive credentials to the repository.

### Running the Application

1. Open the solution in Visual Studio.
2. Restore NuGet packages if necessary.
3. Verify that PostgreSQL is running.
4. Build the solution.
5. Run the application using Visual Studio.
