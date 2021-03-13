using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class ValidationManager : IValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.TcNo == "26153279120" && gamer.Name == "Ersin" && gamer.Surname == "Korkut" && gamer.BirthOfDay == "20.03.1993")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
