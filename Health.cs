using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private readonly float maxHp = 100;
    [SerializeField]
    GameObject hpObj;
    Image hpBar;
    [SerializeField]
    Vector3 hpBarOffset;
    [SerializeField] 
    private float currHp;

    private void LateUpdate() {
         hpObj.transform.position = transform.position + hpBarOffset;
    }
    
    void Start()
    {
        currHp = maxHp;
        hpBar = hpObj.GetComponent<Image>();
    }

    public void DecreaseHp(float value)
    {
        currHp -= value;
        hpBar.fillAmount = currHp / maxHp;
        Debug.Log($"현재 체력 {currHp}");
        if(currHp <= 0) 
            gameObject.SetActive(false);
    }
}
