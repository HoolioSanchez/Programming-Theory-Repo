using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private Player player;
    // Start is called before the first frame update
    public void GameOver() {
        SceneManager.LoadScene("titleScene");
    }

    public void Play() {
        SceneManager.LoadScene("SampleScene");
    }
}
