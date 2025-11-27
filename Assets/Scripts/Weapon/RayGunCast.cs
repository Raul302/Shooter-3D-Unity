using UnityEngine;

public class RayGunCast : MonoBehaviour
{
    public float ray_distance = 3f;
    public LayerMask layermask;
    private float checkRate = 0.05f; 
    private float nextCheck = 0f;

    private void Update()
    {
        if (Time.time >= nextCheck)
        {
            nextCheck = Time.time + checkRate;
            CheckRayCastObject();

        }



    }

    private void CheckRayCastObject()
    {
        RaycastHit hit;
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;



        if (Physics.Raycast(origin, direction, out hit, ray_distance, layermask))
        {
            if (hit.collider.CompareTag("Switch"))
            {

                if (Input.GetButtonDown("Fire2"))
                {

                    Switch.Instance.OnOffLight();

                    Debug.Log("Golpee el Switch");
                }

                GameManager.Instance.DisplayText(hit.collider.tag);
            }

            if (hit.collider.CompareTag("Door"))
            {

                if (Input.GetButtonDown("Fire2"))
                {

                    Door door = hit.collider.GetComponent<Door>();
                    door.OpenDoor();

                    Debug.Log("Golpee la Door");
                }
                GameManager.Instance.DisplayText(hit.collider.tag);
            }
        }
        else
        {
            GameManager.Instance.DisplayText("");


        }

    }
}
