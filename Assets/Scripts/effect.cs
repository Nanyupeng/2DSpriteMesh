using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effect : MonoBehaviour
{
    public SpriteRenderer[] sprites;
    float currtime = 0.1f;
    int index = 0;

    void LateUpdate()
    {
        if (currtime > 0)
        {
            currtime -= Time.deltaTime;
            if (currtime <= 0)
            {
                StartCoroutine(ieffect(sprites[index]));
                currtime = 0.1f;
            }
        }
    }

    IEnumerator ieffect(SpriteRenderer sprite)
    {
        index++;
        sprite.enabled = false;
        yield return new WaitForSeconds(0.2f);
        sprites[index - 1].enabled = true;
        if (index == sprites.Length)
            index = 0;
    }
}
