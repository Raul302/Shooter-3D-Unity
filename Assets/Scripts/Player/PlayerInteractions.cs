using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{

    public Transform start_position;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GunAmmo"))
        {

            GameManager.Instance.gunAmmo += other.gameObject.GetComponent<AmmoBox>().ammo;

            Destroy(other.gameObject);

        }

        if (other.gameObject.CompareTag("DeathFloor"))
        {
            //Perder vida y respawnear player

            Debug.Log("DeathFloor");

            GameManager.Instance.LoseHealth(30);

            GetComponent<CharacterController>().enabled = false;
            gameObject.transform.position = start_position.position;
            GetComponent<CharacterController>().enabled = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            GameManager.Instance.LoseHealth(10);
        }
    }
}
