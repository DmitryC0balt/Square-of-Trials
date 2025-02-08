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

            _prefabList = new List<Formular>();
        }


        private void CreatePool()
        {

        }


        private void CreateElement()
        {

        }



    }
}