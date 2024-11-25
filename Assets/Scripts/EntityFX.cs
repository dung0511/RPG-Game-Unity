using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityFX : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    [Header("Flash FX")]
    private Material oriMat;
    [SerializeField] private Material hitMat;

    private void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        oriMat = spriteRenderer.material;
    }

    private IEnumerator FlashFX()
    {
        spriteRenderer.material = hitMat;
        yield return new WaitForSeconds(.2f);
        spriteRenderer.material = oriMat;   
    }

    private void RedColorBlink()
    {
        if(spriteRenderer.color != Color.white)
        {
            spriteRenderer.color = Color.white;
        }
        else
        {
            spriteRenderer.color = Color.red;
        }
    }

    private void CancelRedBlink()
    {
        CancelInvoke();
        spriteRenderer.color = Color.white;
    }
}
