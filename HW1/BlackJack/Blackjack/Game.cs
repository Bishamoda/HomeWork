using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    
    public class Game
    {
        private Player _player;

        public Game()
        {
            _player = new Player();
            
        }
        public class User
        {
            private int _score;
            public int GetScore()
            {

            }
        }

        public class Player : User
        {
            private string _name;
            public string GetName()
            {
                return _name;
            }

            
        }
        public class Computer : User
        {
            private string _name;
            private string GetName()
            {
                return _name;
            }


        }
    }

    
}
