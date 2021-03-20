using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IClonable_demo
{
    class Pupil : ICloneable, IComparable, IComparable<Pupil>
    {
        public string Name { get; set; } = "NONAME";
        private List<int> marks;
        // public double AvgScore => marks.Average();

        public Pupil(string Name, params int[] marks)
        {
            this.Name = Name;
            this.marks = new List<int>(marks);
        }
        public override string ToString()
        {
            return $"Pupil : {Name}\nMarks : {String.Join(",", marks)}";
        }
        public void changeMark(int index, int mark)
        {
            if (index >= 0 && index < marks.Count)
            {
                marks[index] = mark;
            }
        }
        public object Clone()
        {
            Pupil pupil = new Pupil(this.Name, this.marks.ToArray());
            return pupil;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Pupil))
            {
                throw new FormatException("obj isn't Pupil");
            }
            return this.Name.CompareTo(((Pupil)(obj)).Name);
        }

        public int CompareTo([AllowNull] Pupil other)
        {
            return -this.Name.CompareTo(other.Name);
        }
    }
    class CmpAvgScorePupil : IComparable<Pupil>
    {
        public int CompareTo([AllowNull] Pupil x, [AllowNull] Pupil y)
        {
            return x.AvgScore.CompareTo(y.AvgScore);
        }
    }
}
