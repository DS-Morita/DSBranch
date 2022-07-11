    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.SceneManagement;
     
    public class ChangeNightToDay : MonoBehaviour {
     
        // Use this for initialization
        void Start () {
           // Invoke("ChangeScene", 1.5f);
        	SceneManager.LoadScene("branchday");
        }
        
        // Update is called once per frame
        void Update () {
            
        }
     
        void NightToDay()
        {
           // SceneManager.LoadScene("branchday");
        }
    }