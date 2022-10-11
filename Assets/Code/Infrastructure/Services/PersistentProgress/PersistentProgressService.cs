using Code.Data;

namespace Code.Infrastructure.Services.PersistentProgress
{
    public sealed class PersistentProgressService : 
        IPersistentProgressService
    {
        public PlayerProgress Progress { get; set; }
    }
}