using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathUI : MonoBehaviour
{
    public void Trigger()
    {
        gameObject.SetActive(true);// open the UI screen
    }

   public void TryAgain()
   {
        SceneManager.LoadScene("GameScene");// restart the game
        gameObject.SetActive(false);// close the UI screen
   }
}
