namespace EjemplosEvents
{
    internal class User
    {
        public int pointsGlobal;

        public delegate void EnoughPointsHandler(int points);

        public event EnoughPointsHandler? EnoughPoints;

        public async void AddPoints(int points)
        {
            pointsGlobal =+ points;

            if(pointsGlobal >= 100)
            {
                Console.WriteLine($"Puntos: {pointsGlobal}");
                EnoughPoints.Invoke(pointsGlobal);
            }
        }
    }
}