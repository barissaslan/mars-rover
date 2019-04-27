namespace MarsRover
{
    public class Plateau
    {
        public Point upperRightCoordinates;
        public Point lowerLeftCoordinates;

        public Plateau(int upperRightX, int upperRightY)
        {
            upperRightCoordinates = new Point(upperRightX, upperRightY);
            lowerLeftCoordinates = new Point(0, 0);
        }
    }
}