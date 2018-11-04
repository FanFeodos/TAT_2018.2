//my class of pair. I help C# be useful
namespace task_DEV_5
{
    public class Pair<T, K>
    {
        public Pair (T f, K s)
        {
            First = f;
            Second = s;
        }
            public T First { get; set; }
            public K Second { get; set; }
    }
}
