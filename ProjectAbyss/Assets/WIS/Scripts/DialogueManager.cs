using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    [Space()]
    public GameObject choice01;
    public Text text01;
    private Dialogue dialogueChoice01;
    [Space()]
    public GameObject choice02;
    public Text text02;
    private Dialogue dialogueChoice02;
    [Space()]
    public GameObject choice03;
    public Text text03;
    private Dialogue dialogueChoice03;

    private Queue<string> sentences;

    private Dialogue currentDialogue;
    
    // Start is called before the first frame update
    void Start()
    {

        sentences = new Queue<string>();

        
    }



    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartDialogue(Dialogue dialogue)
    {
        currentDialogue = dialogue;
        DesactiveChoices();

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {

            sentences.Enqueue(sentence);

        }

        DiplayNextSentence();

    }

    public void StartDialogueChoice01()
    {
        StartDialogue(dialogueChoice01);
    }

    public void StartDialogueChoice02()
    {
        StartDialogue(dialogueChoice02);
    }

    public void StartDialogueChoice03()
    {
        StartDialogue(dialogueChoice03);
    }

    public void DiplayNextSentence()
    {

        if (sentences.Count == 0)
        {

            EndDialogue();
            return;

        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

    }

    void EndDialogue()
    {

        Debug.Log("End Of Conversation");
        //dialogueText.text = "";


        ActiveChoices();

    }

    IEnumerator TypeSentence (string sentence)
    {

        dialogueText.text = "";

        foreach (char letter in sentence.ToCharArray())
        {

            dialogueText.text += letter;
            yield return null;


        }



    }

    void ActiveChoices()
    {
        //Fonction qui active chaque choix et y met les valeurs approriés.

        if (currentDialogue.active01)
        {
            if (currentDialogue.checkCondition(1) == false) { return; }
            

            text01.text = currentDialogue.choice01Name;
            dialogueChoice01 = currentDialogue.choice01Dialogue;
            choice01.SetActive(true);

        }

        if (currentDialogue.active02)
        {
            if (currentDialogue.checkCondition(2) == false) { return; }


            text02.text = currentDialogue.choice02Name;
            dialogueChoice02 = currentDialogue.choice02Dialogue;
            choice02.SetActive(true);

        }

        if (currentDialogue.active03)
        {
            if (currentDialogue.checkCondition(3) == false) { return; }


            text03.text = currentDialogue.choice03Name;
            dialogueChoice03 = currentDialogue.choice03Dialogue;
            choice03.SetActive(true);

        }



    }

    void DesactiveChoices()
    {
        choice01.SetActive(false);
        choice02.SetActive(false);
        choice03.SetActive(false);

    }

}
