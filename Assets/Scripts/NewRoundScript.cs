using UnityEngine;
using UnityEngine.SceneManagement;

public class NewRoundScript : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
