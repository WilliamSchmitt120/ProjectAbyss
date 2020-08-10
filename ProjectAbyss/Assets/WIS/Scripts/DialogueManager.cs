using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    [Header("UI Choix")]
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

    [Header("Emplacements de Personnages")]
    public GameObject characterEmplacement01;
    public GameObject characterEmplacement02;
    public GameObject characterEmplacement03;
    public GameObject characterEmplacement04;

    private Sentence[] sentences;

    private Dialogue currentDialogue;
    private int currentDialogueIndex;

    
    // Start is called before the first frame update
    void Start()
    {

        

        
    }



    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartDialogue(Dialogue dialogue)
    {
        currentDialogue = dialogue;
        DesactiveChoices();

        currentDialogueIndex = 0;

        sentences = currentDialogue.sentences;

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

        if (sentences.Length <= currentDialogueIndex)
        {

            EndDialogue();
            return;

        }

        DiplayCharacter(sentences[currentDialogueIndex]);

        nameText.text = sentences[currentDialogueIndex].mainCharacter.name;

        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentences[currentDialogueIndex].phrase));
        currentDialogueIndex += 1;

    }

    void EndDialogue()
    {

        Debug.Log("End Of Conversation");
        //dialogueText.text = "";
        nameText.text = "";

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

    public void DiplayCharacter(Sentence currentSentence)
    {
        //On commence par effacer tous les emplacement le temps de changer les images.

        characterEmplacement01.SetActive(false);
        characterEmplacement02.SetActive(false);
        characterEmplacement03.SetActive(false);
        characterEmplacement04.SetActive(false);


        //Ensuite, pour chaque potentiel peronnage présent, on charge son image dans la scène avec de réactiver son emplacement afin qu'il soit visible.

        if (currentSentence.mainCharacter != null)
        {

            switch (currentSentence.emplacementMain)
            {
                case Sentence.Emplacement.Gauche:
                    characterEmplacement01.GetComponent<Image>().sprite = currentSentence.mainCharacter.image;
                    characterEmplacement01.SetActive(true);
                    break;

                case Sentence.Emplacement.CentreGauche:
                    characterEmplacement02.GetComponent<Image>().sprite = currentSentence.mainCharacter.image;
                    characterEmplacement02.SetActive(true);
                    break;

                case Sentence.Emplacement.CentreDroit:
                    characterEmplacement03.GetComponent<Image>().sprite = currentSentence.mainCharacter.image;
                    characterEmplacement03.SetActive(true);
                    break;

                case Sentence.Emplacement.Droite:
                    characterEmplacement04.GetComponent<Image>().sprite = currentSentence.mainCharacter.image;
                    characterEmplacement04.SetActive(true);
                    break;

                default:
                    break;
            }


        }

        if (currentSentence.character1 != null)
        {

            switch (currentSentence.emplacement1)
            {
                case Sentence.Emplacement.Gauche:
                    characterEmplacement01.GetComponent<Image>().sprite = currentSentence.character1.image;
                    characterEmplacement01.SetActive(true);
                    break;

                case Sentence.Emplacement.CentreGauche:
                    characterEmplacement02.GetComponent<Image>().sprite = currentSentence.character1.image;
                    characterEmplacement02.SetActive(true);
                    break;

                case Sentence.Emplacement.CentreDroit:
                    characterEmplacement03.GetComponent<Image>().sprite = currentSentence.character1.image;
                    characterEmplacement03.SetActive(true);
                    break;

                case Sentence.Emplacement.Droite:
                    characterEmplacement04.GetComponent<Image>().sprite = currentSentence.character1.image;
                    characterEmplacement04.SetActive(true);
                    break;

                default:
                    break;
            }


        }

        if (currentSentence.character2 != null)
        {

            switch (currentSentence.emplacement2)
            {
                case Sentence.Emplacement.Gauche:
                    characterEmplacement01.GetComponent<Image>().sprite = currentSentence.character2.image;
                    characterEmplacement01.SetActive(true);
                    break;

                case Sentence.Emplacement.CentreGauche:
                    characterEmplacement02.GetComponent<Image>().sprite = currentSentence.character2.image;
                    characterEmplacement02.SetActive(true);
                    break;

                case Sentence.Emplacement.CentreDroit:
                    characterEmplacement03.GetComponent<Image>().sprite = currentSentence.character2.image;
                    characterEmplacement03.SetActive(true);
                    break;

                case Sentence.Emplacement.Droite:
                    characterEmplacement04.GetComponent<Image>().sprite = currentSentence.character2.image;
                    characterEmplacement04.SetActive(true);
                    break;

                default:
                    break;
            }


        }

        if (currentSentence.character3 != null)
        {

            switch (currentSentence.emplacement2)
            {
                case Sentence.Emplacement.Gauche:
                    characterEmplacement01.GetComponent<Image>().sprite = currentSentence.character3.image;
                    characterEmplacement01.SetActive(true);
                    break;

                case Sentence.Emplacement.CentreGauche:
                    characterEmplacement02.GetComponent<Image>().sprite = currentSentence.character3.image;
                    characterEmplacement02.SetActive(true);
                    break;

                case Sentence.Emplacement.CentreDroit:
                    characterEmplacement03.GetComponent<Image>().sprite = currentSentence.character3.image;
                    characterEmplacement03.SetActive(true);
                    break;

                case Sentence.Emplacement.Droite:
                    characterEmplacement04.GetComponent<Image>().sprite = currentSentence.character3.image;
                    characterEmplacement04.SetActive(true);
                    break;

                default:
                    break;
            }


        }


    }

}
