

using Dapper;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

public class UserReppository : IUserReppository
{
    public void Add(User user)
    {
        using (IDbConnection db = new SqlConnection(Configuration.ConnectionString))
        {
            db.Execute(UserQueries.Create, new { user.UserName, user.Password, user.Status });
        }
    }
    public List<User> GetAll()
    {
        using (IDbConnection db = new SqlConnection(Configuration.ConnectionString))
        {
            return db.Query<User>(UserQueries.GetAll).ToList();
        }
    }

    public User Get(string username)
    {

        using (IDbConnection db = new SqlConnection(Configuration.ConnectionString))
        {
            return db.QueryFirstOrDefault<User>(UserQueries.GetByUsername, new { UserName = username });
        }

    }

    public void Update(User user)
    {
        using (IDbConnection db = new SqlConnection(Configuration.ConnectionString))
        {
            db.Execute(UserQueries.Update, new { Id = user.Id, UserName = user.UserName, Password = user.Password, Status = user.Status });
        }
    }
    public void Delete(string userName)
    {

        using (IDbConnection db = new SqlConnection(Configuration.ConnectionString))
        {
            db.Execute(UserQueries.Delete, new { UserName = userName });

        }
    }



}
