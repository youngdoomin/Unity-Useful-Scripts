using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector2 screen = new Vector2(Screen.width / 2, Screen.height / 2);
    Rigidbody rigid;
    [SerializeField]
    LayerMask layerMask;
    [SerializeField]
    float damage;


    private void OnEnable()
    {
        var ray = Camera.main.ScreenPointToRay(new Vector3(screen.x, screen.y, 0));
        rigid.velocity = ray.direction * 120;
    }

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();

    }

    private void OnTriggerEnter(Collider other) {
        if(LayerTools.LayerInLayerMask(other.gameObject.layer, layerMask))
        {
            Health health = other.GetComponent<Health>();
            if(health)
                health.DecreaseHp(damage);
        }
    }
}
