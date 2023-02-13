using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChapterText : MonoBehaviour
{
    public List<string> storyTexts = new List<string>();

    public Text currentText;

    void Start()
    {
        storyTexts.Add("Boy finds a mysterious box.");
        storyTexts.Add("It looks magical. He was curious and so, he opened it.");
        storyTexts.Add("It was a shit load of money. ");
        storyTexts.Add("He tried giving the box to a girl");
        storyTexts.Add("She doesn't want it, and he gets sad.");
        storyTexts.Add("That awakens his inner demons, and he is scared");
        storyTexts.Add("The demon starts to cause mayhem.");
        storyTexts.Add("He gives the box to someone else, so he won't have to deal with it.");
    }

    
    public void ShowText()
    {
        currentText.text = storyTexts[Chapter.currentPage];
    }
}
