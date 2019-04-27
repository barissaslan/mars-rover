using System;

namespace MarsRover
{
    public class MarsRover : IRobot
    {
        private Point location;
        private Direction direction;
        private Plateau plateau;

        public MarsRover(int x, int y, string direction, Plateau plateau)
        {
            this.location = new Point(x, y);
            this.direction = DirectionUtils.strToDirection(direction);
            this.plateau = plateau;
        }

        public void move()
        {
            switch (this.direction)
            {
                case Direction.NORTH:
                    if (location.Y < plateau.upperRightCoordinates.Y)
                        location.Y++;
                    break;
                case Direction.EAST:
                    if (location.X < plateau.upperRightCoordinates.X)
                        location.X++;
                    break;
                case Direction.SOUTH:
                    if (location.Y > plateau.lowerLeftCoordinates.Y)
                        location.Y--;
                    break;
                case Direction.WEST:
                    if (location.X > plateau.lowerLeftCoordinates.X)
                        location.X--;
                    break;
                default:
                    throw new Exception();
            }
        }

        public void turn(string rotation)
        {
            if (rotation == "L") {
                this.turnLeft();
            } else if (rotation == "R") {
                this.turnRight();
            } else {
                throw new Exception();
            }
        }

        private void turnRight()
        {
            this.direction = (int)this.direction >= (int)Direction.WEST ?
                Direction.NORTH : (Direction)((int)++this.direction);
        }

        private void turnLeft()
        {
            this.direction = (int)this.direction <= (int)Direction.NORTH ?
                Direction.WEST : (Direction)((int)--this.direction);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.location.X, this.location.Y, DirectionUtils.directionToStr(this.direction));
        }
    }
}
