
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

