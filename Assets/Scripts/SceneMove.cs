using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    // Start is called before the first frame update
	//スクリプト起動時の処理
    void Start()
    {
        Debug.Log("script started");
    }
    
    //操作が生じた場合に随時行なう処理
    void Update()
    {
    	//Debug.Log("Swicth Pushed");
    	//背景の編集
    	//　夜：StarSkybox04
    	//　昼：CasualDay
		if(Input.GetKeyDown(KeyCode.Q)){
		//	RenderSettings.skybox = sky;
		}
    }
    
    public void ChangeSky()
    {
		Debug.Log("Execute ChangeSky");  
	}
}