using System;

namespace Scripts.Model.Experience
{
    public class ExperienceMaster
    {
        //internal event Action<int> LevelChanged;

        private int _currentLvl;
        private int _maxLvl;


        private int _currentExp;
        private int _maxExp;


        internal ExperienceMaster(int value)
        {
            _maxLvl = value;
            _currentLvl = 1;
        }
    }
}