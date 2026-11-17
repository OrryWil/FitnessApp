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
/*INSERT INTO MuscleGroup (MuscleName)
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
(1,8),  -- Bench Press -> Shoulders
(2, 5), -- Squat -> Quadriceps
(2,6),  -- Squat -> Hamstrings
(2, 7); -- Squat -> Glutes
*/
-- Workouts 
INSERT INTO workoutinfo(coachid, workoutname, workoutdate)
VALUES(1,'LegDay1','2027-09-10');

-- Workout Details 
INSERT INTO workouts(workoutinfoid, workoutgroup, exerciseid, workoutsets, workoutreps)
VALUES(1,1,2,5,10);

-- Workout Assignment 
INSERT INTO workoutassignments(workoutinfoid, athleteid)
VALUES(1,1);

--Workout results
INSERT INTO workoutresults(workoutid, assignmentid, askedweight, actualweightdone, completed)
VALUES(1,1,225,NULL, FALSE);
