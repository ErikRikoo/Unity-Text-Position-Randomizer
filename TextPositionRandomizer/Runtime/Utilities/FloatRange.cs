using System;
using Random = UnityEngine.Random;

namespace TextPositionRandomizer.Runtime.Utilities
{
    [Serializable]
    struct FloatRange
    {
        public float Min;
        public float Max;

        public float Range()
        {
            return Random.Range(Min, Max);
        }
    }
}