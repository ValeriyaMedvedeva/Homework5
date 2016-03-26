using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace Zoo.Animals
{
    public class Shark: Animal
    {
        public Shark()
        {
        }
        public Shark(IMovement move, ISound sound)
        {
            nameAnimal = "Акула";
            IMovement m = new Swim();
            ISound s = new Silent();
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
