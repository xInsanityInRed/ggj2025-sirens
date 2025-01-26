using System.Collections.Generic;
using Ink.Runtime;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class DialogScript : MonoBehaviour
{

    public TextAsset inkJSON;
    private Story story;

    public Text textPrefab;
    public Text namePrefab;
    public Button buttonPrefab;

    public Button continueButtonPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        story = new Story(inkJSON.text);
        story.ChoosePathString("loremaster");

        refreshUI();

    }

    void refreshUI()
    {

        eraseUI();

        Text storyText = Instantiate(textPrefab);
        Text nameText = Instantiate(namePrefab);

        // storyText.text = loadStoryChunk();
        storyText.text = loadStoryText();
        //get current tags
        List<string> tags = story.currentTags;

        if(tags.Count > 0) {
            if (tags.Count > 1) {
                nameText.text = tags[1];
            }
            else {
                nameText.text = tags[0];
            }
        }
        // get dialog container
        Transform dialogContainer = transform.Find("DialogContainer");

        storyText.transform.SetParent(dialogContainer, false);
        nameText.transform.SetParent(dialogContainer, false);

        if(story.currentChoices.Count == 0) {
            createContinueButton();
        }
        else {
            createChoiceButtons();
        }

        // // get choices
        // foreach (Choice choice in story.currentChoices) {
        //     Button choiceButton = Instantiate(buttonPrefab);
        //     Text choiceText = choiceButton.GetComponentInChildren<Text>();
        //     choiceText.text = choice.text;
            
        //     // get choice canvas
        //     Transform choiceContainer = transform.Find("ChoiceCanvas");

        //     // set parent
        //     choiceButton.transform.SetParent(choiceContainer, false);

        //     // onClick
        //     choiceButton.onClick.AddListener(delegate {
        //         chooseChoice(choice);
        //     });
        // }
    }

    void createContinueButton()
    {
        Button continueButton = Instantiate(continueButtonPrefab);
        Transform dialogContainer = transform.Find("DialogContainer"); 
        continueButton.transform.SetParent(dialogContainer, false);

        continueButton.onClick.AddListener(delegate{
            refreshUI();
        });
    }

    void createChoiceButtons()
    {
        // get choices
        foreach (Choice choice in story.currentChoices) {
            Button choiceButton = Instantiate(buttonPrefab);
            Text choiceText = choiceButton.GetComponentInChildren<Text>();
            choiceText.text = choice.text;
            
            // get choice canvas
            Transform choiceContainer = transform.Find("ChoiceCanvas");

            // set parent
            choiceButton.transform.SetParent(choiceContainer, false);

            // onClick
            choiceButton.onClick.AddListener(delegate {
                chooseChoice(choice);
            });
        }
    }

    void eraseUI()
    {
        // erase children of DialogContainer
        Transform dialogContainer = transform.Find("DialogContainer");
        foreach(Transform child in dialogContainer.transform) {
            Destroy(child.gameObject);
        }

        // erase children of ChoiceCanvas
        Transform choiceContainer = transform.Find("ChoiceCanvas");
        foreach(Transform child in choiceContainer.transform) {
            Destroy(child.gameObject);
        }
    }

    void chooseChoice(Choice choice)
    {
        story.ChooseChoiceIndex(choice.index);
        refreshUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string loadStoryChunk()
    {

        string text = "";

        if (story.canContinue) {
            text = story.ContinueMaximally();
        }

        return text;
    }

    string loadStoryText()
    {
        string text = "";

        if (story.canContinue) {
            text = story.Continue();
        }

        return text;
    }
}
