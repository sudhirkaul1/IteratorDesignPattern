using IteratorDesignPattern.Aggregate;
using IteratorDesignPattern.Iterator;
using IteratorDesignPattern.Model;

IAggregate<User> users = new Aggregate<User>();
users[0] = new User("User1", 1);
users[1] = new User("User2", 2);

var user = users.Iterator;

while(user.HasNext())
{
    Console.WriteLine(user.MoveNext());
    
}