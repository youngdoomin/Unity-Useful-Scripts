using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ȣ�� ȿ�� ��ũ��Ʈ
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
