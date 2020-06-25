using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fenatureData : MonoBehaviour
{
    public List<Sprite> sprites;
    public Sprite image; 

    private int spriteIndex = 0;

    public void rotateRight()
    {
        spriteIndex++;
        if (spriteIndex > sprites.Count-1)
        {
            spriteIndex = 0;
        }

        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[spriteIndex];
    }

    public void rotateLeft()
    {
        spriteIndex--;
        if (spriteIndex < 0)
        {
            spriteIndex = sprites.Count-1;
        }

        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[spriteIndex];
    }
    public void Destroy()
    {
        Object.Destroy(this.gameObject);
    }
}
