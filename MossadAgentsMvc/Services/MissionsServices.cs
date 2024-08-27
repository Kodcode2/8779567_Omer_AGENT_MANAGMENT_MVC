using MossadAgentsMvc.Models;

namespace MossadAgentsMvc.Services
{
    public class MissionsServices
    {
        public int GetNumOfMissions(Mission[] missions)
        {
            return missions.Length;
        }

       
    }
}
