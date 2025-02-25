using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Model.ObjectPool
{
    public class PoolBuilder : MonoBehaviour
    {
        [SerializeField]private PoolPreset[] _poolPresets;

        private Dictionary<string,Pool<Transform>> _objectPools;
        internal IReadOnlyDictionary<string,Pool<Transform>> objectPools => _objectPools;


        internal void Init()
        {
            _objectPools = new Dictionary<string, Pool<Transform>>();

            for (var i = 0; i < _poolPresets.Length; i++)
            {
                _objectPools.Add(_poolPresets[i].poolName,PoolInit(_poolPresets[i]));
            }
        }


        private Pool<Transform> PoolInit(PoolPreset _poolPreset)
        {
            var pool = new Pool<Transform>
            (
                _poolPreset.formular,
                _poolPreset.container,
                _poolPreset.isExpandable,
                _poolPreset.count
            );

            return pool;
        }

    }
}