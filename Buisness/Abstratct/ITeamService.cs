using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstratct
{
   public  interface ITeamService
    {
        public void AddTeam(Team team);
        public void DeleteTeam(int  Id);
        public void UpdateTeam(int Id,Team team);
        Team GetTeam(Func<Team, bool>? func = null);
        public List<Team> GetAllTeams(Func<Team,bool>? func=null);
    }
}
