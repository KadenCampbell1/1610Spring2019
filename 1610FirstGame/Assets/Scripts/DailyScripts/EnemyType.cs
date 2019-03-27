using UnityEngine;

namespace DailyScripts
{
    [CreateAssetMenu]
    public class EnemyType : ScriptableObject
    {
        public string enemyTypeName;
        public int powerLevel;
        public int difficultyLevel;
        public int enemySpeed;

    }
}
