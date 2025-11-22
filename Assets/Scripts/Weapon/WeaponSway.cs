using UnityEngine;

public class WeaponSway : MonoBehaviour
{
    private Quaternion start_rotation;

    public float sway_amount = 8;

    private void Start()
    {
        start_rotation = transform.localRotation;
    }

    private void Update()
    {

        Sway();
    }


    private void Sway()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Quaternion xAngle = Quaternion.AngleAxis(mouseX * -1.25f, Vector3.up);
        Quaternion yAngle = Quaternion.AngleAxis(mouseY * 1.25f, Vector3.left);

        Quaternion target_rotation = start_rotation * xAngle * yAngle;

        transform.localRotation =
            Quaternion.Lerp(transform.localRotation,target_rotation,
            Time.deltaTime*sway_amount);




    }

}
