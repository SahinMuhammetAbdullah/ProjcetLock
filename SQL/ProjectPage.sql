-- ProjectPage
--string getDataQuery
SELECT
    P.ProjectId,
    P.ProjectName,
    P.ProjectBeginDate,
    P.ProjectEndDate,
    U.UserName,
    T.TaskName,
    E.EmployeeFirstName
FROM
    projectlock.Project P
    LEFT JOIN projectlock.Users U ON P.UserId = U.UserId
    LEFT JOIN projectlock.Task T ON P.TaskId = T.TaskId
    LEFT JOIN projectlock.Employee E ON P.UserId = E.UserId
    AND T.EmployeeId = E.EmployeeId
WHERE
    P.UserId = @userId;

--fillComboBoxQuery
SELECT
    *
FROM
    Task
WHERE
    UserId = @userId;

--addNewProjectQuery 
INSERT INTO
    Project (
        ProjectName,
        ProjectBeginDate,
        ProjectEndDate,
        TaskId,
        UserId
    )
VALUES
    (
        @ProjectName,
        @ProjectBeginDate,
        @ProjectEndDate,
        @TaskId,
        @UserId
    );

--isValidTaskIdQuery
SELECT
    COUNT(*)
FROM
    task
WHERE
    TaskId = @TaskId;

--getValidTaskIdFromDatabaseQuery 
SELECT
    TaskId
FROM
    task
LIMIT
    1;

--deleteQuery 
DELETE FROM
    project
WHERE
    ProjectId = @ProjectId;

--updateProjectQuery 
UPDATE
    Project
SET
    ProjectEndDate = @ProjectEndDate,
    TaskId = @TaskId
WHERE
    ProjectId = @ProjectId;