using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    [SerializeField]
    GameObject bulletPrefab;
    readonly static int maxMagazine = 10;
    [SerializeField]
    int currMagazine = maxMagazine;
    readonly static float shootCoolTime = 0.3f;
    WaitForSeconds shootWait = new WaitForSeconds(shootCoolTime);
    readonly static float reloadCoolTime = 2f;
    WaitForSeconds reloadWait = new WaitForSeconds(reloadCoolTime);

    bool isWait = false;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);       // only touch 0 is used

            if (touch.phase != TouchPhase.Ended)
            {
                StartCoroutine(SpawnBullet());
            }
        }
        else if (Input.GetMouseButton(0))
        {
            StartCoroutine(SpawnBullet());
        }
    }

    
    IEnumerator SpawnBullet()
    {
        if(isWait) yield break;
        isWait = true;
        Instantiate(bulletPrefab);
        currMagazine--;
        if(currMagazine <= 0)
        {
            yield return reloadWait;
            currMagazine = maxMagazine;
        }
        else
            yield return shootWait;
        isWait = false;
    }
}
