using EjemplosEvents;

User user = new User();

user.EnoughPoints += OnEnoughPoints;

user.AddPoints(20);
user.AddPoints(40);
user.AddPoints(50);

static void OnEnoughPoints()
{
    Console.WriteLine("You got the necessary points");
}

