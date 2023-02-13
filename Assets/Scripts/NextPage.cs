using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPage : MonoBehaviour
{
    public Chapter chapter;
    public GameObject NextButton;
    public PreviousPage PreviousButton;
    public ChapterText testtext;


    public void OnClick()
    {
        GoToNext();                         //skips to next chapter
        chapter.ShowChapter();          //shows the contents of that chapter
    }

    /**
     * Current page flips to the next page
     * Previous/next buttons are hidden/shown
    */
    public void GoToNext()
    {
        Chapter.currentPage += 1;
        print(Chapter.currentPage);

        ShowNextButton();
        PreviousButton.ShowPreviousButton();
    }


    /**
     * If the current page is the last page,
     * the next button will disappear
    */
    public void ShowNextButton()
    {
        if (chapter.IsLastPage() == false)
        {
            NextButton.SetActive(true);
        }
        else
        {
            NextButton.SetActive(false);
        }
    }

}

