using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicManager : MonoBehaviour
{
    public int gamescore = 0;
    public Text scoreText;
    public GameObject gameOverPanel;
    [ContextMenu("addscore")]

    public void addscore(){
        gamescore++;
        scoreText.text = gamescore.ToString();
    }

    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void gameover(){
        gameOverPanel.SetActive(true);
    }
}
