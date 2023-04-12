using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public class Countdown : MonoBehaviour
    {
        [SerializeField]
        private Text _title;

        public void Start()
        {
            _title.text = "Your new text is here";
        }
    }
}
