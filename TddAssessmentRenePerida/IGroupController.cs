using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode
{
    public interface IGroupController
    {
        Dictionary<string, Trainee> GetAllTrainees();

        void AddTrainee(Trainee trainee);

        void RemoveTraineeByUsername(string username);
    }
}
