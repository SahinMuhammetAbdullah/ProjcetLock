-- RegisterPage
INSERT INTO
    Users (
        UserFirstName,
        UserLastName,
        UserName,
        UserPassword
    )
VALUES
    (
        @UserFirstName,
        @UserLastName,
        @UserName,
        @UserPassword
    );