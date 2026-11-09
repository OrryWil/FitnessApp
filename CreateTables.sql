CREATE TABLE Coaches (
	CoachID int PRIMARY KEY,
	FirstName varchar(64) NOT NULL,
	LastName varchar(64) NOT NULL,
	Email varchar(254) NOT NULL,
	PhoneNumber varchar(100) NOT NULL
	Company varchar(255),
	createdate TIMESTAMP WITH TIME ZONE DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Athletes (
	AthleteID int PRIMARY KEY,
	CoachID int FOREIGN KEY,
	FirstName varchar(64) NOT NULL,
	LastName varchar(64) NOT NULL,
	email varchar(254) NOT NULL,
	createdate TIMESTAMP WITH TIME ZONE DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Exercises(
	ExerciseID int PRIMARY KEY,
	ExerciseName var(255) NOT NULL,
	videourl text,
	description text
);

CREATE TABLE MuscleGroup(
	MuscleGroupID int PRIMARY KEY,
	MuscleName text
);

CREATE TABLE ExerciseMuscleGroup (
	ExerciseID int PRIMARY KEY,
	MuscleGroupID int
);

CREATE TABLE WorkoutInfo (
	WorkoutInfoId int PRIMARY KEY,
	WorkoutId int NOT NULL,
	CoachId int NOT NULL,
	WorkoutName varchar(254) NOT NULL,
	athleteId int NOT NULL,
	Completed boolean NOT NULL,
	WorkoutDate date NOT NULL
);

CREATE TABLE Workouts(
	WorkoutId int PRIMARY KEY,
	WorkoutGroup int NOT NULL,
	ExerciseId int NOT NULL,
	WorkoutSets int NOT NULL,
	WorkoutReps int NOT NULL,
	Weight int NOT NULL
);