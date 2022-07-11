    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.SceneManagement;

     
    public class ChangeDayToNight : MonoBehaviour {
        public void  OnCollisionEnter(Collision col)
        {
            SceneManager.LoadScene("branchnight");
        }
    }