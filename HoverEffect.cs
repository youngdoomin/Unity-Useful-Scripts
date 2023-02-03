using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 호버 효과 스크립트
/// </summary>
public class HoverEffect : MonoBehaviour
{
    [SerializeField]
    float amplitude;
    [SerializeField]
    float frequency;

    void Update()
    {
        transform.position += amplitude * (Mathf.Sin(2 * Mathf.PI * frequency * Time.time) - Mathf.Sin(2 * Mathf.PI * frequency * (Time.time - Time.deltaTime))) * transform.up;
    }
}
