using DockerSampleAPI.Models;

namespace DockerSampleAPI.Interfaces
{
    public interface IMsgRepository
    {
        ICollection<Msg> GetMsgs();
    }
}
