--LoginPage
-- loginQuery 
SELECT
    *
FROM
    Users
WHERE
    UserName = @UserName
    AND UserPassword = @UserPassword;