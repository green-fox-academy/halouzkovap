using System;

namespace Comparable
{

    public class Domino : IComparable
    {
        private readonly int[] values;

        public Domino(int valueA, int valueB)
        {
            if (valueA < valueB)
            {
                values = new int[] { valueA, valueB };
            }
            else
            {
                values = new int[] { valueB, valueA };
            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Domino otherDomino = obj as Domino;
            if (otherDomino != null)
            {
                int compareValue0 = values[0] - otherDomino.values[0];
                int compareValue1 = values[1] - otherDomino.values[1];

                if (compareValue0 != 0)
                {
                    return compareValue0;
                }
                else
                {
                    return compareValue1;
                }

                /*
                if (values[0] == otherDomino.values[0])
                {
                    return values[1] - otherDomino.values[1];
                }
                else
                {
                    return values[0] - otherDomino.values[0];
                }
                */
                /*
                if (values[0] == otherDomino.values[0])
                {
                    return values[1] - otherDomino.values[1];
                }
                else if (values[0] < otherDomino.values[0])
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
                */
                /*
                if (values[0] == otherDomino.values[0])
                {
                    return values[1].CompareTo(otherDomino.values[1]);
                }
                else
                {
                    if (values[0] < otherDomino.values[0])
                    {
                        return -1;
                    }
                    return 1;
                }
                */
                //this.values[0].CompareTo(otherDomino.values[0]);
                //return values[0] - otherDomino.values[0];
                //if (values[0] == otherDomino.values[0])
                //{
                //    return this.values[1].CompareTo(otherDomino.values[1]);
                //}


            }
            else
                throw new ArgumentException("Object is not a Domino");
        }

        public int[] GetValues()
        {
            return values;
        }
    }
}


