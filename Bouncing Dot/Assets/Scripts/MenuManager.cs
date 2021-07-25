using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MenuManager : MonoBehaviour
{
    public TMP_Text _highScoreText;
    void Start() {
        _highScoreText.text = PlayerPrefs.GetInt("_highScore").ToString();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            SceneManager.LoadScene(1);
        }
    }
}
