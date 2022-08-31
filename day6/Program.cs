using System;

namespace day6
{
    public class genericclass<T>
    {
        public T msg;
        public int a = 10;
        public void genericmethod(T name, T location)
        {
            Console.WriteLine(msg);
            Console.WriteLine(name);
            Console.WriteLine(location);
            Console.WriteLine(a);

        }
        class Program
        {
            static void Main(string[] args)
            {
                genericclass<string> gc = new genericclass<string>();
                gc.msg = "Welcome ";
                gc.genericmethod("mansi", "aligarh");
            }
        }
    }
}
