using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShut : MonoBehaviour
{
    public GameObject bullet;

    public Transform startPos;
    
    public int maxAmmo = 3;
    
    public int currentAmmo;

    // Start is called before the first frame update
    void Start()
    {
        currentAmmo = maxAmmo;
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        if (context.started && currentAmmo > 0)
        {
            GameObject bulletClone = Instantiate(bullet, startPos.position, startPos.rotation);
            Destroy(bulletClone, 1f);

            currentAmmo--; // 🔥 resta munición
            Debug.Log("Balas: " + currentAmmo);
        }
    }
}
