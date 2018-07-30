using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonClick : MonoBehaviour {
    
    public GameObject[] arrayObjects; //버튼이 클릭되면 활성화 될 오브젝트
  
    public void Onclick()  //버튼을 클릭하면 호출되는 함수
    {
        for(int i=0; i<7; i++) //모든 오브젝트를 활성화 시키기위해 오브젝트 갯수만큼 for문
        {
            if (arrayObjects[i].transform.localPosition.y > -500) //오브젝트의 y좌표가 -500보다 크면 계속 내려가게 한다.
            {
                arrayObjects[i].transform.localPosition -= new Vector3(0, 200, 0); //200씩내려감
            }
            else if (arrayObjects[i].transform.localPosition.y <= -500) //-500보다 작으면 
            {
                arrayObjects[i].transform.localPosition = new Vector3(0, 700, 0); //맨위 자리인 700으로 넘어간다.
                Transform GetChild = arrayObjects[i].transform.GetChild(0);
                Destroy(GetChild.gameObject);

                
                    
                  
                    
                
                //GameObject[] trans = GetComponentsInChildren(arrayObjects[i]);
            }
        }
        
        int j = Random.Range(0, 4); //랜덤 변수 생성
        GameObject child = Instantiate(arrayObjects[j], arrayObjects[i].transform.position, Quaternion.identity, arrayObjects[i].transform) as GameObject;
    }
}
