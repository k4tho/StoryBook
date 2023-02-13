using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChapterImage : MonoBehaviour
{
    public List<Sprite> storySprites;

    public Image StoryImage;

    public void ShowSprite()
    {
        StoryImage.sprite = storySprites[Chapter.currentPage];
    }

}
