using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorecard
{
    public class Player
    {
        #region Properties
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Number { get; private set; }
        #endregion

        #region Constructors
        public Player(string firstName, string lastName, int number)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Number = number;
        }
        #endregion

    }
}
