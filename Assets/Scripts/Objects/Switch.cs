using UnityEngine;

public class Switch : MonoBehaviour
{

    public GameObject luz;

    public bool status = false;
    public static Switch Instance { get; private set; }


    private void Awake()
    {
        Instance = this;
       
    }
    public void OnOffLight()
    {

        SoundManager.Instance.PlaySwitchOnOff();

        if (status)
        {
            luz.SetActive(false);

        } else
        {
            luz.SetActive(true);

        }

        status = !status;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
