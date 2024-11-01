
public interface IUserReppository
{
    public void Add(User user);
    public List<User> GetAll();
    public User Get(string username);
    public void Update(User user);
    public void Delete(string userName);

}

