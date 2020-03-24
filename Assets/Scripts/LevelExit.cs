using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    [SerializeField] float LevelLoadDelay = 2f;

    void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(LoadNextLevel());
    }

    IEnumerator LoadNextLevel()
    {
        yield return new WaitForSecondsRealtime(LevelLoadDelay);
        var currentSceneIndex = SceneManager.GetActiveScene(). buildIndex;
        Destroy(FindObjectOfType<ScenePersists>());
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
