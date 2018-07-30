using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    public GameObject[] arrayObject; //오브젝트를 배열에 집어넣기 위해 퍼블릭으로 생성
    public int position;  
    public GameObject GameObject;
  

     
// Use this for initialization
void Start () {
        int i = Random.Range(0, 4); //랜덤 변수 생성
        GameObject hitClone=Instantiate(arrayObject[i],GameObject.transform.position,Quaternion.identity,GameObject.transform) as GameObject;
    }

    
}
