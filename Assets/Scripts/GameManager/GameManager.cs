using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public TMP_Text name_object_interactive;
    public TMP_Text bullet_text;
    public TMP_Text cartridge_text;
    public TMP_Text health_text;

    public Image key_image;

    public int healt = 100;
    public int gunAmmo = 10;

    public static GameManager Instance { get; private set; }


    private void Awake()
    {
        Instance = this;
        //bullet_text = GameObject.Find("Bullets_Quantity").GetComponent<TMP_Text>();
        //cartridge_text = GameObject.Find("Cartridge_Quantity").GetComponent<TMP_Text>();
    }


    public void ShowKey()
    {
        Color color_key = key_image.color;
        color_key.a = 1;
        key_image.color = color_key;

    }
    public void DisplayText( string name_object)
    {

        if (!string.IsNullOrEmpty(name_object))
        {
           name_object_interactive.text = "Interactuar con  " + name_object;

        } else
        {
            name_object_interactive.text = "";
        }


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
