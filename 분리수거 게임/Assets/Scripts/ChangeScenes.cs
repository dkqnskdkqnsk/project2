using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
//게임 씬을 바꾸기위한 스크립트
public class ChangeScenes : MonoBehaviour {

	public void ChangeGameScene1() //1번으로
    {
        SceneManager.LoadScene(1);
    }
    public void ChangeGameScene2() //2번으로
    {
        SceneManager.LoadScene(2);
    }
    public void ChangeGameScene3() //3번으로
    {
        SceneManager.LoadScene(3);
    }
    public void ChangeGameScene4() //4번으로
    {
        SceneManager.LoadScene(4);
    }
    public void ChangeGameScene5() //5번으로
    {
        SceneManager.LoadScene(5);
    }
}
