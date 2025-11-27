using UnityEngine;

public class ThrowGrenade : MonoBehaviour
{

    public float throw_force = 500;

    public GameObject grenade_prefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Throw();
        }
    }

    public void Throw()
    {

        SoundManager.Instance.PlayThrowingGrenadeSound();
        GameObject new_grande = Instantiate(grenade_prefab,transform.position,transform.rotation);

        new_grande.GetComponent<Rigidbody>().AddForce(transform.forward * throw_force);
    }
}
