using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Pupil_IEnumerable 
{
    class Pupil : IEnumerable
    {
        public string Name { get; set; }
        public List<int> Marks { get; set; } = new List<int>();
        public List<int> Exams { get; set; } = new List<int>();
        public IEnumerable<int> GetAllExams()
        {
            foreach (int m in Exams)
            {
                yield return m;
            }
            // return 
        }
        public IEnumerable<int> GetMarksHigher(int limit)
        {
            foreach (int m in Marks)
            {
                if (m >= limit)
                {
                    yield return m;
                }
            }
        }
        public IEnumerator GetEnumerator()
        {
            // return Marks.GetEnumerator();
            foreach (int m in Marks)
            {
                yield return m;
            }
            foreach  (int m in Exams)
            {
                yield return m;
            }
        }
    }
}
