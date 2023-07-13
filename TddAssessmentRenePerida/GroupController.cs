using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode
{
    public class GroupController : IGroupController
    {
        private Dictionary<string, Trainee> _group;
        public IDatabaseReader? _reader { get; set; }
        public IDatabaseWriter? _writer { get; set; }

        public GroupController(IDatabaseReader reader, IDatabaseWriter writer)
        { 
            _group = new Dictionary<string, Trainee>();
            _reader = reader;
            _writer = writer;
        }

        public void AddTrainee(Trainee trainee)
        {
            _writer.AddTrainee(trainee);
        }

        public Dictionary<string, Trainee> GetAllTrainees()
        {
            if (!object.ReferenceEquals(_reader, null))
            {
                _group = _reader.ReadGroup();
            }
            return _group;
        }

        public void RemoveTraineeByUsername(string username)
        {
            _writer.DeleteTraineeByUsername(username);
        }


    }
}
