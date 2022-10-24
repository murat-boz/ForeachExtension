using System;

namespace ForeachExtension
{
    public static class Extensions
    {
        public static CustomIntEnumerator GetEnumerator(this Range range)
        {
            return new CustomIntEnumerator(range);
        }

        public static CustomIntEnumerator GetEnumerator(this int number)
        {
            return new CustomIntEnumerator(new Range(0, number));
        }
    }

    public struct CustomIntEnumerator
    {
        private int current;
        public int end;

        public int Current => current;

        public CustomIntEnumerator(Range range)
        {
            if (range.End.IsFromEnd)
            {
                throw new NotSupportedException();
            }

            this.current = range.Start.Value - 1;
            this.end     = range.End.Value;
        }

        public bool MoveNext()
        {
            this.current++;

            return this.current <= this.end;
        }
    }
}
