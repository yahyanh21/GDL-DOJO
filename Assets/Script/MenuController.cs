
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    string[] Anggota = { "Fikri", "Sara", "Yahya" };
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Debug.Log($"Nama Anggota {i + 1} : {Anggota[i]}");
        }
    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
}
