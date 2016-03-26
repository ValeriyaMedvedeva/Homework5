using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace Zoo.Animals
{
    public class Cat : Animal
    {
        public Cat()
        {
        }
        public Cat(IMovement move, ISound sound)
        {
            nameAnimal = "Кот";
            IMovement m = new Run();
            ISound s = new Meow();
            if (!move.Move.Contains(m.Move))
                throw new Exceptions(this, move);
            else
                moveAnimal = move;
            if (!sound.Sound.Contains(s.Sound))
                throw new Exceptions(this, sound);
            else
                soundAnimal = sound;
        }
    }
   
}
