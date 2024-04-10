namespace EjemplosEvents
{
    internal class User
    {
        public int pointsGlobal;

        public delegate void EnoughPointsHandler(int points);

        public event EnoughPointsHandler? EnoughPoints;

        public async void AddPoints(int points)
        {
            pointsGlobal += points;
            Console.WriteLine($"Puntos: {pointsGlobal}");

            if(pointsGlobal >= 100)
            {
                
                EnoughPoints?.Invoke(pointsGlobal);
            }
        }
    }
}