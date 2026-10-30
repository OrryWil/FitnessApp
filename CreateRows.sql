-- Coaches
INSERT INTO Coaches (FirstName, LastName, Email, PhoneNumber, PasswordHash)
VALUES ('Orry', 'Willems', 'orry@test.com', '1231231234', 'hashedpassword');

-- Athletes
INSERT INTO Athletes (CoachID, FirstName, LastName, Email)
VALUES (1, 'April', 'Smith', 'april@test.com');

-- Exercises
INSERT INTO Exercises (ExerciseName)
VALUES ('Bench Press'), ('Squat');

-- MuscleGroups
INSERT INTO MuscleGroup (MuscleName)
VALUES 
('Chest'), ('Back'), ('Biceps'), ('Triceps'), 
('Quadriceps'), ('Hamstrings'), ('Glutes'), ('Shoulders'), 
('Core'), ('Calves'), ('Forearms'), ('Abductors'), ('Adductors');

-- ExerciseMuscleGroup Links (Connecting Bench Press to Chest/Triceps, and Squats to Quads/Glutes)
-- Assumes auto-incremented IDs starting at 1
INSERT INTO ExerciseMuscleGroup (ExerciseID, MuscleGroupID)
VALUES 
(1, 1), -- Bench Press -> Chest
(1, 4), -- Bench Press -> Triceps
(2, 5), -- Squat -> Quadriceps
(2, 7); -- Squat -> Glutes

-- Workouts (Summary / Header Info)
INSERT INTO workoutinfo (CoachID, AthleteID, WorkoutID, WorkoutName, DayNumber, IsCompleted, WorkoutDate)
VALUES (1, 1, 1, 'LegDay1', 1, False, '2026-09-10');

-- Workout Details (Sets, Reps, Weight)
INSERT INTO workouts (WorkoutID, ExerciseID, SetNumber, Reps, Weight)
VALUES (1, 2, 1, 5, 10, 225);