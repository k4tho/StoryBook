using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviousPage : MonoBehaviour
{
    public Chapter chapter;
    public GameObject PreviousButton;
    public NextPage NextButton;


    public void OnClick()
    {
        GoToPrevious();                 //returns to the previous chapter
        chapter.ShowChapter();      //shows content of the chapter
    }


    /**
     * Current page flips to the previous page
     * Previous/next buttons are hidden/shown
    */
    public void GoToPrevious()
    {
        Chapter.currentPage -= 1;
        print(Chapter.currentPage);

        ShowPreviousButton();
        NextButton.ShowNextButton();
    }


    /**
     * If the current page is the first page,
     * the previous button will disappear
    */
    public void ShowPreviousButton()
    {
        if (chapter.IsFirstPage() == false)
        {
            PreviousButton.SetActive(true);
        }
        else
        {
            PreviousButton.SetActive(false);
        }
    }
    
}
