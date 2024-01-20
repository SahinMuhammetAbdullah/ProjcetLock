-- TaskPage
-- getDataQuery
SELECT 
    T.TaskId,
    T.TaskName,
    T.TaskBeginDate,
    T.ManDayValue,
    T.TaskEndDate,
    T.TaskState,
    E.EmployeeFirstName,
    U.UserName
FROM
    projectlock.Task T
    JOIN projectlock.Users U ON T.UserId = U.UserId
    JOIN projectlock.Employee E ON T.EmployeeId = E.EmployeeId
WHERE
    T.UserId = @userId;

-- fillComboBoxQuery
SELECT
    *
FROM
    employee
WHERE
    UserId = @userId;

-- addTaskQuery
INSERT INTO
    Task (
        TaskName,
        TaskBeginDate,
        ManDayValue,
        TaskEndDate,
        TaskState,
        EmployeeId,
        UserId
    )
VALUES
    (
        @TaskName,
        @TaskBeginDate,
        @ManDayValue,
        @TaskEndDate,
        @TaskState,
        @EmployeeId,
        @UserId
    );

-- isValidEmployeeIdQuery
SELECT
    COUNT(*)
FROM
    Employee
WHERE
    EmployeeId = @EmployeeId
    AND UserId = @UserId;

-- deleteTaskQuery
DELETE FROM
    task
WHERE
    TaskId = @TaskId;

-- updateTaskQuery
UPDATE
    Task
SET
    TaskEndDate = @TaskEndDate,
    ManDayValue = @ManDayValue,
    TaskState = @TaskState
WHERE
    TaskId = @TaskId;

