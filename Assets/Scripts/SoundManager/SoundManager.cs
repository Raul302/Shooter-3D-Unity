using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource gun_shot_source ,throwing_grenade_source,grenade_explosion_source;
    public AudioClip gun_shot_sound,throwing_grenade_sound,grenade_explosion_sound;

    void Start()
    {
        
    }

    public void PlayGrenadeExplosionSound()
    {
        grenade_explosion_source.PlayOneShot(grenade_explosion_sound);
    }
    public void PlayThrowingGrenadeSound()
    {
        throwing_grenade_source.PlayOneShot(throwing_grenade_sound);
    }
    public void PlayGunShotSound()
    {
        gun_shot_source.PlayOneShot(gun_shot_sound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
