using UnityEngine;

public class AmmoBox : MonoBehaviour
{

    public int ammo = 10;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("AmmoBox Executed");
            //SoundManager.Instance.PlayAmmoReload();
        }
    }
}
