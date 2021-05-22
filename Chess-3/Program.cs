using System;

namespace Chess_3
{
    class Program
    {
        static void Main()
        {
            //Rook
            Rook rook = new Rook(4, 4);
            Console.WriteLine(rook.Move(5, 5));

            //King
            King king = new King(4, 4);
            Console.WriteLine(king.Move(5, 5));

            //Queen
            Queen queen = new Queen(1, 1);
            Console.WriteLine(queen.Move(2, 2));

            //Bishop
            Bishop bishop = new Bishop(4, 4);
            Console.WriteLine(bishop.Move(5, 5));

            //Knight
            Knight knight = new Knight(1, 1);
            Console.WriteLine(knight.Move(1, 4));
        }
    }

    class Figure
    {
        protected int X;
        protected int Y;

        public Figure(int newX, int newY)
        {
            X = newX;
            Y = newY;
        }

        public virtual bool Move(int newX, int newY)
        {
            return false;
        }
    }

    class Rook : Figure
    {
        public Rook(int newX, int newY) : base(newX, newY) { }

        public override bool Move(int newX, int newY)
        {
            if (X == newX || Y == newY)
            {
                X = newX;
                Y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class King : Figure
    {
        public King(int newX, int newY) : base(newX, newY) { }

        public override bool Move(int newX, int newY)
        {
            if ((Math.Abs(newX - X) <= 1) && (Math.Abs(newY - Y) <= 1))
            {
                X = newX;
                Y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Queen : Figure
    {
        public Queen(int newX, int newY) : base(newX, newY) { }

        public override bool Move(int newX, int newY)
        {
            if ((X == newX) || (Y == newY) || (Math.Abs(X - newX) == Math.Abs(Y - newY)))
            {
                X = newX;
                Y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Bishop : Figure
    {
        public Bishop(int newX, int newY) : base(newX, newY) { }

        public override bool Move(int newX, int newY)
        {
            if ((Math.Abs(newX - X) == Math.Abs(newY - Y)))
            {
                X = newX;
                Y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Knight : Figure
    {
        public Knight(int newX, int newY) : base(newX, newY) { }

        public override bool Move(int newX, int newY)
        {
            if ((Math.Abs(X - newX) == 2) && (Math.Abs(Y - newY) == 1) ||
                (Math.Abs(X - newX) == 1) && (Math.Abs(Y - newY) == 2))
            {
                X = newX;
                Y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
