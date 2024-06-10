using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using DockerSampleAPI.Data;
using DockerSampleAPI.Models;
using DockerSampleAPI.Interfaces;

namespace DockerSampleAPI.Repository
{
    public class MsgRepository : IMsgRepository
    {
        private readonly DatabaseContext _databaseContext;
        public MsgRepository(DatabaseContext context)
        {
            _databaseContext = context;
        }

        public ICollection<Msg> GetMsgs()
        {
            return _databaseContext.Msgs.OrderBy(m => m.Id).ToList();
        }
    }
}
