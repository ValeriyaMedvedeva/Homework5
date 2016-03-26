using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace Zoo.Interface
{
    class Exceptions : Exception
    {
        public Exceptions(Animal animal, IMovement movement) :
            base(animal.nameAnimal + " не может " + movement.Move)
        { }
        public Exceptions(Animal animal, ISound sound) :
            base(animal.nameAnimal + " не может " + sound.Sound)
        { }
    }
}
