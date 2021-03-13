using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IGamerService
    {
        void Add(List<Gamer> gamers);
        void Delete(List<Gamer> gamers);
        void Update(List<Gamer> gamers);
    }
}
