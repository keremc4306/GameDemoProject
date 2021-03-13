using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class NewEstateUserValidationManager : IValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true; //test amaçlı doğrulamanın başarılı olduğunu kabul edelim.
        }
    }
}
