using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    [SerializeField] private string nextScene;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() is not null)
        {
            StartCoroutine(MoveToNextScene());
        }
    }

    private IEnumerator MoveToNextScene()
    {
        if (nextScene.Equals("")){
            Debug.LogWarning("Next Scene Empty");
        }
        else
        {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(nextScene);
        }

    }

}
