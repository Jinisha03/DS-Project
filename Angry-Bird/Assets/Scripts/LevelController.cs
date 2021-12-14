using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private Enemy[] _enemies;
    //[] means that there is an array
    private static int _nextLevelIndex = 1;

    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Enemy enemy in _enemies)
        {
            if(enemy != null)
            {
                return;
                // will return if all monster do not die
            }

            Debug.Log("You killed all enemies");

                _nextLevelIndex++;
                string nextLevelName = "Level" + _nextLevelIndex;
                SceneManager.LoadScene(nextLevelName);
        }
    }
}
