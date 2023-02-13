using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter : MonoBehaviour
{
    public static int currentPage;
    public NextPage next;
    public PreviousPage previous;
    public ChapterImage sprite;
    public ChapterText text;

    public CanvasGroup nextButton;
    public CanvasGroup previousButton;
    

    public 


    /**
     * Chapter begins at the first page
     * Previous/Next buttons are hidden/shown
     * First chapter's images and texts are displayed
    */
    void Start()
    {
        currentPage = 0;

        next.ShowNextButton();
        previous.ShowPreviousButton();
        ShowChapter();
    }


    /**
     * Shows the image and text for the chapter
    */
    public void ShowChapter()
    {
        sprite.ShowSprite();
        text.ShowText();
    }

    /**
     * Checks if the chapter is first page
     * Removes previous button if first page
    */
    public bool IsFirstPage()
    {
        if (currentPage == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /**
     * Checks if the chapter is last page
     * Removes next button if last page
    */
    public bool IsLastPage()
    {
        if (currentPage == 7)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /**
     * instead of setActive() 
    */
    public void ShowCanvasGroup(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
    }
    public void HideCanvasGroup(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }
}
