using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager gameManager;

    // Start is called before the first frame update
    void Awake()
    {
        if (gameManager == null) {
            gameManager = gameObject.GetComponent<GameManager>();
        } else {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void gameOver() {
        SceneManager.LoadScene("GameOver");
    }
}
