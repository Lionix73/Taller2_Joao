using EjemplosEvents;

User user = new User();

user.EnoughPoints += OnEnoughPoints;

user.AddPoints(30);
user.AddPoints(40);
user.AddPoints(50);

static void OnEnoughPoints(int points)
{
    Console.WriteLine("Has conseguido los suficientes puntos");
}