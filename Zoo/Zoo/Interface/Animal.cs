using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace Zoo
{
    public abstract class Animal 
    {
        public ISound soundAnimal;
        public IMovement moveAnimal;
        public string nameAnimal;
        public string NameAnimal
        {
            get
            {
                return nameAnimal;
            }
            set
            {
                nameAnimal = value;
            }
        }
        public ISound SountAnimal
        {
            get
            {
                return soundAnimal;
            }
            set
            {
               soundAnimal = value;
            }
        }
        public IMovement MoveAnimal
        {
            get
            {
                return moveAnimal;
            }
            set
            {
                moveAnimal = value;
            }

        }
    }
}
