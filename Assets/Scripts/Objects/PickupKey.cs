using UnityEngine;

public class PickupKey : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            SoundManager.Instance.PlaySwitchOnOff();
            GameManager.Instance.ShowKey();

            Destroy(gameObject); // Elimina la llave del mundo
        }
    }
}
