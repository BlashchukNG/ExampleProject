using Code.Data;

namespace Code.Infrastructure.Services.PersistentProgress
{
    public interface ISavedProgressReader
    {
        void ReadProgress(PlayerProgress progress);
    }
}