using Code.Data;

namespace Code.Infrastructure.Services.SaveLoad
{
    public interface ISaveLoadService :
        IService
    {
        void WriteProgress();
        PlayerProgress ReadProgress();
    }
}