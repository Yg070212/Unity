using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] GameObject[] weapons;
    [SerializeField] List<Weapon> weaponsList;

    [SerializeField] Transform parentPosition;

    void Start()
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            // Instantiate(prefab, parentPosition);

        }
    }
}
