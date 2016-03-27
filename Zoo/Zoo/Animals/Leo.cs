using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace Zoo.Animals
{
    public class Leo : Animal
    {
        public Leo() :this(new Run(),new Growl())
        {
        }
        public Leo(IMovement move,ISound sound){
            nameAnimal="Лев";
            IMovement m = new Run();
            ISound s = new Growl();
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
