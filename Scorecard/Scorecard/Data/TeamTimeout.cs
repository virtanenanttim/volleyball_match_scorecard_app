namespace Scorecard
{
    public class TeamTimeout
    {
        public TeamTimeout(int homePoints, int guestPoints)
        {
            this.GuestPoints = guestPoints;
            this.HomePoints = homePoints;
        }

        public int GuestPoints { get; internal set; }
        public int HomePoints { get; internal set; }
    }
}