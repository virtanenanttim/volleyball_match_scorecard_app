using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorecard
{
    internal class Player
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

        #region Overrides
        public override bool Equals(object obj)
        {
            if (obj is Player)
            {
                var that = obj as Player;
                return this.FirstName == that.FirstName && this.LastName == that.LastName && this.Number == that.Number;

            }

            return false;
        }
        #endregion
    }
}
