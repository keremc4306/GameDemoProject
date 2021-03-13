using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IValidationService
    {
        bool Validate(Gamer gamer);
    }
}
