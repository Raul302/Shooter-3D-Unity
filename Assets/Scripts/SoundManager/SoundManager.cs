using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource gun_shot_source ,throwing_grenade_source,grenade_explosion_source,open_door_source,hit_source,switch_source,ammo_source;
    public AudioClip gun_shot_sound,throwing_grenade_sound,grenade_explosion_sound,open_door_sound,hit_sound,switch_sound,ammo_sound;
    public static SoundManager Instance { get; private set; }


    private void Awake()
    {
        Instance = this;
        //bullet_text = GameObject.Find("Bullets_Quantity").GetComponent<TMP_Text>();
        //cartridge_text = GameObject.Find("Cartridge_Quantity").GetComponent<TMP_Text>();
    }

    public void PlayAmmoReload()
    {
        ammo_source.PlayOneShot(ammo_sound);
    }
    public void PlaySwitchOnOff()
    {
        switch_source.PlayOneShot(switch_sound);
    }
    public void PlayHitSound()
    {
        hit_source.PlayOneShot(hit_sound);
    }

    public void PlayOpenDoorSound()
    {
        open_door_source.PlayOneShot(open_door_sound);
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
