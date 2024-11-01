
public static class UserQueries
{
    public static string Create = "insert into Users (UserName,Password,Status) values (@UserName,@Password,@Status);";
    public static string GetByUsername = "SELECT * FROM Users WHERE UserName = @UserName";
    public static string GetAll = "SELECT * FROM Users";
    public static string Delete = "delete Users WHERE UserName = @UserName";
    public static string Update = "UPDATE Users SET UserName=@UserName , Password=@Password , Status=@Status WHERE Id = @Id";

}

