using Code.Data;

namespace Code.Infrastructure.Services.PersistentProgress
{
    public interface ISavedProgressWriter
    {
        void WriteProgress(PlayerProgress progress);
    }
}