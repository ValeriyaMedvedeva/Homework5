using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace Zoo.Animals
{
    public class Frog : Animal
    {
            public Frog()
            {
            }
            public Frog(IMovement move, ISound sound)
            {
                nameAnimal = "Лягушка";
                IMovement m = new Jump();
                ISound s = new Croak();
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

