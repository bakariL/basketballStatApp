using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_roster
{
    class Player
    {
        //feilds
        private string firstName;
        private string lastName;
        private int madeShots;
        private int shotAttempts;
        private int fgPercentage;
        private bool shooter;

        //properties
        public string fName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string Name
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int mShots
        {
            get { return this.madeShots; }
            set { this.madeShots = value; }
        }

        public int sAttempts
        {
            get { return this.shotAttempts; }
            set { this.shotAttempts = value; }
        }

        public int fPercentage 
        {
            get { return this.fgPercentage; }
            set { this.fgPercentage = value; }
        }

        public bool sShooter
        {
            get { return this.shooter; }
            set { this.shooter = value; }
        }

        public Player()
        {
        }

        public Player(string firstName, string lastName, int madeShots, int shotAttempts, int fgPercentage, bool shooter)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.madeShots = madeShots;
            this.shotAttempts = shotAttempts;
            this.fgPercentage = fgPercentage;
            this.shooter = shooter;
        }
        //constructors/behaviors


        //methods
    }
}
