using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardController : MonoBehaviour
{
    public Assignment assignmentType;
    public DiffAssignments assignment;
    public bool isCardActivated = false;
    public int cardGroupIndex;
    [SerializeField] string answer;

    private void Start()
    {
        if (this != CardManager.selectedCard)
        {
            gameObject.GetComponent<Button>().interactable = false;
            isCardActivated = false;
        }
        else
        {
            gameObject.GetComponent<Button>().interactable = true;
            isCardActivated = true;
        }
    }

    public void Setup(CardGroup_SO group, Assignment typeOfAssignment, DiffAssignments assignments, int index)
    {
        assignmentType = typeOfAssignment;
        assignment = assignments;
        this.GetComponentInChildren<Image>().color = group.groupColor;
        cardGroupIndex = index;
    }



    public void ActivateUIPanel()
    {
        if (this == CardManager.selectedCard)
        {


            if (assignmentType == Assignment.Assignment_With_Answer_Options && assignment.assignmentWithAnswers != null)
            {
                UI_Assignment_With_Answers.Instance.ActivateUIPanel(assignment.assignmentWithAnswers.Question, assignment.assignmentWithAnswers.Answers[0], assignment.assignmentWithAnswers.Answers[1], assignment.assignmentWithAnswers.Answers[2], assignment.assignmentWithAnswers.sprite);
                answer = assignment.assignmentWithAnswers.IndexOfRightAnswer.ToString();
            }
            else if (assignmentType == Assignment.Assignment_With_Number_Input)
            {
                UI_Assignment_WithInput.Instance.ActivateUIPanel(assignment.assignmentWithUserInput_Number.Question, assignment.assignmentWithUserInput_Number.sprite);
                answer = assignment.assignmentWithUserInput_Number.RightNumber.ToString();

            }
            else if (assignmentType == Assignment.Assignment_With_Text_Input)
            {
                UI_Assignment_WithInput.Instance.ActivateUIPanel(assignment.assignmentWithUserInput_Text.Question, assignment.assignmentWithUserInput_Text.sprite);
                answer = assignment.assignmentWithUserInput_Text.RightAnswer;
            }
        }
    }

    public void ActivateCard()
    {
        if (this == CardManager.selectedCard)
        {
            gameObject.GetComponent<Button>().interactable = true;
            isCardActivated = true;
        }
    }

    public void DeactivateCard()
    {

        gameObject.GetComponent<Button>().interactable = false;
        isCardActivated = false;

    }

    public void DestroyCard()
    {

        Destroy(gameObject);

    }
}