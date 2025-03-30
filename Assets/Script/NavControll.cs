using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavControll : MonoBehaviour
{
    IEnumerator playSound(int sceneNumber) {
        yield return new WaitForSeconds(0.08f);
        SceneManager.LoadScene(sceneNumber);
    }
    public void LoadMyScene(int sceneNumber) {
        //Unity won't wait the sound played and then change the scene
        //so i need to wait the sound finished first
        StartCoroutine(playSound(sceneNumber));
    }
    
     
    public void LoadMyScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    

}
