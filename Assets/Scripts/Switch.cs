using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Switch : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {     
    }

    public void OnPointerClick(PointerEventData eventdata){
    	Debug.Log($"オブジェクト{name}がクリックされました");
    }

}
