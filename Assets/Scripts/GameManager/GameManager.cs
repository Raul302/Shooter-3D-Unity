using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TMP_Text bullet_text;
    public TMP_Text cartridge_text;
    public TMP_Text health_text;

    public int healt = 100;

    public static GameManager Instance { get; private set; }

    public int gunAmmo = 10;

    private void Awake()
    {
        Instance = this;
        //bullet_text = GameObject.Find("Bullets_Quantity").GetComponent<TMP_Text>();
        //cartridge_text = GameObject.Find("Cartridge_Quantity").GetComponent<TMP_Text>();
    }


    private void Update()
    {
        if (gunAmmo > 0) {

            if(gunAmmo / 5 >= 0)
            {
            cartridge_text.text = (gunAmmo / 5).ToString();
            }
            bullet_text.text = gunAmmo.ToString();
        }

        health_text.text = healt.ToString();
       
    }

    public void LoseHealth( int health_to_reduce)
    {

        healt -= health_to_reduce;
        CheckHealth();

    }

    public void CheckHealth()
    {
        if (healt <= 0)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}
