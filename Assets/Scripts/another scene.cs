using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneswitcher : MonoBehaviour
{
    public string Restart { get; private set; }

    public void LoadNextSceneByName(string sceneName)
    {
        SceneManager.LoadScene(Restart);
    }

    public void LoadNextSceneByIndex(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void LoadSceneAsyncByName(string ECO)
    {
        StartCoroutine(LoadSceneAsync(ECO));
    }

    IEnumerator LoadSceneAsync(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        while (!operation.isDone)
        {
            Debug.Log("Loading progress: " + operation.progress);
            yield return null;
        }
    }
}
