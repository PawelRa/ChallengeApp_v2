using Dzień_6___lekcje;
// Klasy

User user1 = new User("Adam", "0123456789");
User user2 = new User("Zuzia", "0123456789");
User user3 = new User("Monika", "0123456789");
User user4 = new User("Damian", "0123456789");

var name = user1.Login;
user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);

var gameName = User.GameName;
var pi = Math.PI;
