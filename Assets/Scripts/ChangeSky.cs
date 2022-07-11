using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSky : MonoBehaviour
{
	//Unity上で使用するマテリアル変数の宣言
	//日中用のスカイボックスと夜用スカイボックスを用意
	public Material Dayskybox;
	public Material Nightskybox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  	
		//キーボードで「C」が押されたら動作する
        if(Input.GetKeyDown(KeyCode.G)){
        	if(RenderSettings.skybox==Nightskybox){
	        	//現状のスカイボックス設定が夜用の場合は昼用に変更
				RenderSettings.skybox = Dayskybox;
        	} else {
				//現状のスカイボックス設定が昼用の場合は夜用に変更
	        	RenderSettings.skybox = Nightskybox;
        	}
        }
    }

}
