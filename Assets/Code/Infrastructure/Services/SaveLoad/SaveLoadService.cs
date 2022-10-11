using Code.Data;
using Code.Extensions;
using UnityEngine;

namespace Code.Infrastructure.Services.SaveLoad
{
    public sealed class SaveLoadService :
        ISaveLoadService
    {
        private const string KEY_PROGRESS = "Progress";

        public void WriteProgress()
        {
        }

        public PlayerProgress ReadProgress() => PlayerPrefs.GetString(KEY_PROGRESS)?.FromJson<PlayerProgress>();
    }
}