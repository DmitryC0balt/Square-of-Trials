using UnityEngine;

namespace Scripts.Model.ObjectPool
{
    [System.Serializable]
    public class PoolPreset
    {
        [Header("Pool preset")]
        [SerializeField]private string _poolName;
        [SerializeField]private Transform _formular;
        [SerializeField]private Transform _container;
        [SerializeField]private bool _isExpandable;
        [SerializeField]private int _count;
        [SerializeField]private int _maxCount;


        internal string poolName => _poolName;
        internal Transform formular => _formular;
        internal Transform container => _container;
        internal bool isExpandable => _isExpandable;
        internal int count => _count;
        internal int maxCount => _maxCount;
    }
}

