using System;

namespace MarsRover
{
    public class DirectionUtils
    {
        public static Direction strToDirection(string direction)
        {
            switch (direction)
            {
                case "N":
                    return Direction.NORTH;
                case "E":
                    return Direction.EAST;
                case "S":
                    return Direction.SOUTH;
                case "W":
                    return Direction.WEST;
                default:
                    throw new Exception();
            }
        }

        public static string directionToStr(Direction direction)
        {
            switch (direction)
            {
                case Direction.NORTH:
                    return "N";
                case Direction.EAST:
                    return "E";
                case Direction.SOUTH:
                    return "S";
                case Direction.WEST:
                    return "W";
                default:
                    throw new Exception();
            }
        }
    }

    public enum Direction
    {
        NORTH,
        EAST,
        SOUTH,
        WEST
    }
}
