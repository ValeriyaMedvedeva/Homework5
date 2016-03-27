using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Interface
{
    public interface IMovement
    {
        string Move { get; }
    }
    public class Fly : IMovement
    {
        public string Move
        {
            get { return "Летать"; }
        }
    }
    public class Run : IMovement
    {
        public string Move
        {
            get { return "Бежать"; }
        }
    }
    public class Swim : IMovement
    {
        public string Move
        {
            get { return "Плавать"; }
        }
    }
    public class Jump : IMovement
    {
        public string Move
        {
            get { return "Прыгать"; }
        }
    }
}
