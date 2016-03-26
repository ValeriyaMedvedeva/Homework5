using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace Zoo.Animals
{
    public class Eagle : Animal
    {
        public Eagle():this(new Fly(),new Shout())
        {
        }
        public Eagle(IMovement move, ISound sound)
        {
            nameAnimal = "Орел";
            IMovement m = new Fly();
            ISound s = new Shout();
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
