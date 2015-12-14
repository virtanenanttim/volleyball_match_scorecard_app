namespace Scorecard
{
    internal class PlayerExchange
    {
        public PlayerExchange(Player playerOut, Player playerIn, int homePoints, int guestPoints)
        {
            this.PlayerOut = playerOut;
            this.PlayerIn = playerIn;
            this.HomePoints = homePoints;
            this.GuestPoints = guestPoints;
        }

        public int GuestPoints { get; internal set; }
        public int HomePoints { get; internal set; }
        internal Player PlayerIn { get; set; }
        internal Player PlayerOut { get; set; }
    }
}