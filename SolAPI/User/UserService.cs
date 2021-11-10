using System.Collections.Generic;
using MongoDB.Driver;
using Sol.Models;

namespace Sol.Services
{
    public interface IUserService {
        List<User> Get();
        User Get(string id);
    }

    public class UserService: IUserService
    {
        public readonly IMongoCollection<User> _users;

        public UserService()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("solcore");
            _users = database.GetCollection<User>("users");
        }

        public List<User> Get() =>
            _users.Find(user => true).ToList();

        public User Get(string id) =>
            _users.Find<User>(user => user.Id == id).FirstOrDefault();
    }
}