using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Model.ObjectPool
{
    public class Pool<Formular> where Formular : Transform
    {
        private Formular _formular;
        private Transform _container;
        private bool _isExpandable;
        private int _count;


        private List<Formular> _prefabList;


        internal Pool(Formular formular,Transform container,bool isExpandable,int count)
        {
            _formular = formular;
            _container = container;
            _isExpandable = isExpandable;
            _count = count;

            CreatePool();
        }


        private void CreatePool()
        {
            _prefabList = new List<Formular>();
            for (var i = 0; i < _count; i++)
            {
                CreateElement();
            }
        }


        private Formular CreateElement(bool isActive = false)
        {
            var element = Object.Instantiate(_formular,_container);
            element.gameObject.SetActive(isActive);
            _prefabList.Add(element);
            return element;
        }


        private bool HasFreeElement(out Formular element)
        {
            element = null;

            foreach(var prefab in _prefabList)
            {
                if (!prefab.gameObject.activeInHierarchy)
                {
                    element = prefab;
                    prefab.gameObject.SetActive(true);
                    return true;
                }
            }

            return false;
        }


        internal Formular GetFreeElement()
        {
            if (HasFreeElement(out var element))
            {
                return element;
            }

            if (_isExpandable)
            {
                return CreateElement();
            }

            throw new System.Exception("No more elements in pool");
        }

    }
}