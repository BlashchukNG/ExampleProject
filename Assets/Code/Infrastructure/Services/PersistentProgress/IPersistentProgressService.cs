using Code.Data;

namespace Code.Infrastructure.Services.PersistentProgress
{
    public interface IPersistentProgressService :
        IService
    {
        PlayerProgress Progress { get; set; }
    }
}