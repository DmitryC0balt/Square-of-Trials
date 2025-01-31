using UnityEngine;

namespace Scripts.Root.GameEntryPoint
{
    public class GameMaster : MonoBehaviour
    {
        [Header("Sound settings")]
        [SerializeField,Range(0,10)]private int _musicValue;
        [SerializeField,Range(0,10)]private int _soundValue;


        [Header("Frame settings")]
        [SerializeField]private bool _highRate;


        internal uint GameFrameRate(bool isHigh)
        {
            if (isHigh)
            {
                return 60;
            }
            return 30;
        }

    }
}