using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Model.ObjectPool
{
    [System.Serializable]
    public class PoolPreset<Formular> where Formular : Transform
    {
        [Header("Pool preset")]
        [SerializeField]private string _poolName;
        [SerializeField]private Formular _formular;
        [SerializeField]private Transform _container;
        [SerializeField]private bool _isExpandable;
        [SerializeField]private int _count;

        internal string poolName => _poolName;
        internal Formular formular => _formular;
        internal Transform container => _container;
        internal bool isExpandable => _isExpandable;
        internal int count => _count;
    }
}

