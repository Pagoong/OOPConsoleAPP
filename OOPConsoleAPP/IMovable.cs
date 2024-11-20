using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleAPP
{
    public interface IMovable
    {
        void Move();
    }


    public class Cars : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The car is moving. ");
        }
    }
}
