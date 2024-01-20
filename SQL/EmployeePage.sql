--EmployeePage
--addEmployeeQuery 
INSERT INTO
    Employee (EmployeeFirstName, EmployeeLastName, UserId)
VALUES
    (@EmployeeFirstName, @EmployeeLastName, @UserId);

-- getDataQuery 
SELECT
    E.EmployeeId,
    E.EmployeeFirstName,
    E.EmployeeLastName,
    U.UserName
FROM
    projectlock.employee E
    JOIN projectlock.users U ON E.UserId = U.UserId
WHERE
    E.UserId = @userId;

-- deleteEmployeeQuery 
DELETE FROM
    Employee
WHERE
    EmployeeId = @EmployeeId;

-- updateEmployeeQuery 
UPDATE
    Employee
SET
    EmployeeFirstName = @EmployeeFirstName,
    EmployeeLastName = @EmployeeLastName
WHERE
    EmployeeId = @EmployeeId;