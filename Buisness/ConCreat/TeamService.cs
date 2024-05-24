using Buisness.Abstratct;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.ConCreat
{
    public class TeamService : ITeamService
    {
        private readonly ITeamService _service;

        public TeamService(ITeamService service)
        {
            _service = service;
        }

        public void AddTeam(Team team)
        {
            throw new NotImplementedException();
        }

        public void DeleteTeam(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Team> GetAllTeams(Func<Team, bool>? func = null)
        {
            throw new NotImplementedException();
        }

        public Team GetTeam(Func<Team, bool>? func = null)
        {
            throw new NotImplementedException();
        }

        public void UpdateTeam(int Id, Team team)
        {
            throw new NotImplementedException();
        }
    }
}
