using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour {
    public GameObject loadingScreen;
    public Slider slider;
	// Use this for initialization
	public void loadLevel (int sceneIndex) {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }



    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 9f);
            Debug.Log(operation.progress);
            slider.value = progress;
            yield return null;

        }
    }
	 
}
