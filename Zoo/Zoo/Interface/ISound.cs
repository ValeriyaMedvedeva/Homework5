using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Interface
{
    public interface ISound
    {
        string Sound { get; }
    }
    public class Croak : ISound
    {
        public string Sound
        {
            get { return "Квакать"; }
        }
    }
    public class Growl : ISound
    {
        public string Sound
        {
            get { return "Рычать"; }
        }
    }

    public class Meow : ISound
    {
        public string Sound
        {
            get { return "Мяукать"; }
        }
    }

    public class Shout : ISound
    {
        public string Sound
        {
            get { return "Кричать"; }
        }
    }
    public class Silent : ISound
    {
        public string Sound
        {
            get { return "Молчать"; }
        }
    }
}
