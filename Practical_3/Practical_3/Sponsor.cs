
namespace Practical_3
{
    public class Sponsor
    {
        protected string Owner = "Rakuteen";
    }
    public class Team : Sponsor
    {
        private readonly string _teamName;
        public Team(string teamName)
        {
            this._teamName = teamName;
        }
        public string PrintInfo()
        {
           return ($"{Owner} {_teamName}");
        }
    }
}
