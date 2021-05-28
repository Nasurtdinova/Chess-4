using System;
using System.Collections.Generic;
using System.Text;

namespace ClassCore
{
    public class Figure
    {
        protected int X;
        protected int Y;

        public Figure(int x1, int y1)
        {
            X = x1;
            Y = y1;
        }

        public virtual bool Move(int x2, int y2)
        {
            return false;
        }
    }

    public class King : Figure
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

    public class Queen : Figure
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

    public class Rook : Figure
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

    public class Bishop : Figure
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

    public class Knight : Figure
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

