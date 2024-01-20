-- EmployeeDetail
-- getDataQuery 
SELECT
    e.EmployeeId,
    e.EmployeeNumberOfTasksCompleted,
    e.EmployeeNumberOngoingTasks,
    t.TaskName,
    t.TaskBeginDate,
    t.ManDayValue,
    t.TaskEndDate,
    t.TaskState,
    p.ProjectName
FROM
    projectlock.Task t
    LEFT JOIN projectlock.Employee e ON t.EmployeeId = e.EmployeeId
    LEFT JOIN projectlock.Project p ON p.TaskId = t.TaskId
WHERE
    t.EmployeeId = @EmployeeId;

-- updateTaskQuery 
UPDATE
    Employee
SET
    EmployeeNumberOfTasksCompleted = @EmployeeNumberOfTasksCompleted,
    EmployeeNumberOngoingTasks = @EmployeeNumberOngoingTasks
WHERE
    EmployeeId = @EmployeeId;