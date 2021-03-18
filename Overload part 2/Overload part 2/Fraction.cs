﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Overload
{
    class Fraction
    {
        int num = 0, denom = 0;

        public int Denom
        {
            get => denom;
            set => denom = value != 0 ? value : throw new Exception("Wrong denominator");
        }

        public int Num
        {
            get => num;
            set => num = value;
        }

        public Fraction(int num = 0, int denom = 1)
        {
            try
            {
                Denom = denom;
            }
            catch (Exception)
            {
                Denom = 1;
            }

            Num = num;
        }
        public override string ToString()
        {
            return $"{Num} / {Denom}";
        }
        public override bool Equals(object obj)
        {
            // 1 try
            //if (obj == null || !(obj is Fraction)) { return false; }
            //Fraction fr = (Fraction)obj;
            //return this.num * fr.denom == this.denom * fr.num;
            Fraction fr = obj as Fraction;

            if (fr == null)
            {
                return false;
            }
            return this.num * fr.denom == this.denom * fr.num;
        }
        public static Fraction operator +(Fraction one, Fraction two)
        {
            return new Fraction(num: one.num * two.denom + one.denom * two.num, denom: one.denom * two.denom);
        }
        public static Fraction operator -(Fraction one, Fraction two)
        {
            return new Fraction(num: one.num * two.denom - one.denom * two.num, denom: one.denom * two.denom);
        }
        public static bool operator ==(Fraction one, Fraction two)
        {
            if (ReferenceEquals(one, two))
            {
                return true;
            }
            if (one is null)
            {
                return false;
            }
            return one.Equals(two);
        }
        public static Fraction operator ++(Fraction one)
        {
            return new Fraction(one.num + one.denom, one.denom);
        }
        public static bool operator !=(Fraction one, Fraction two)
        {
            return !(one == two);
        }
        public override int GetHashCode()
        {
            return ((decimal)this.num / denom).ToString().GetHashCode();
        }
        public static /*implicit*/explicit operator double(Fraction one)
        {
            return (double)one.num / one.denom;
        }
        public static /*implicit*/explicit operator int(Fraction one)
        {
            return one.num / one.denom;
        }
        public static /*implicit*/explicit operator Fraction(int value)
        {
            return new Fraction(value, 1);
        }
        public static bool operator true(Fraction one)
        {
            return one.num != 0;
        }
        public static bool operator false(Fraction one)
        {
            return one.num == 0;
        }
        private bool IsValidIndex(int index) => index >= 0 && index <= 1;
        public int this[int index]
        {
            get
            {
                if (!IsValidIndex(index))
                {
                    throw new Exception($"Invalid index. ({index})");
                }
                if (index == 0)
                {
                    return num;
                }
                else
                {
                    return denom;
                }
            }
            set
            {
                if (!IsValidIndex(index))
                {
                    throw new Exception($"Invalid index. ({index})");
                }
                if (index == 0)
                {
                    num = value;
                }
                else
                {
                    Denom = value;
                }
            }
        }
        public int this[string index]
        {
            get
            {
                if (index.ToLower() == "num")
                {
                    return num;
                }
                else if (index.ToLower() == "denom")
                {
                    return denom;
                }
                throw new Exception($"Invalid index. ({index??"null"})");
            }
        }
    }
}