using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    bool gameIsEnded = false;
    public float restartDealy = 1.0f;

    public GameObject completeLevelUI;

    

    public void CompleteLevel()
    {
        //Debug.Log("Level Won");
        completeLevelUI.SetActive(true);

    }

	public void EndGame()
    {
        if(!gameIsEnded)
        {
            gameIsEnded = true;
            Debug.Log("GAME OVER!!!");
            Invoke("Restart", restartDealy);
            //Restart();

        }

 
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
