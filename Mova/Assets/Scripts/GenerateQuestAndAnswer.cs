using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GenerateQuestAndAnswer : MonoBehaviour
{
    private int CountQust;
    private  string[] Quest;
    private  string[][] Answer;

    private void basicInitialization(){
        CountQust = 4;
        Quest = new string[] {"quest0", "quest1", "quest2", "quest3"};
        Answer = new string[][] {
        new string[] {"TrueAnswer0", "FalseAnswer0", "FalseAnswer0","FalseAnswer0"},
        new string[] {"FalseAnswer1", "FalseAnswer1", "TrueAnswer1","FalseAnswer1"},
        new string[] {"FalseAnswer2", "FalseAnswer2", "TrueAnswer2","FalseAnswer2"},
        new string[] {"FalseAnswer3","TrueAnswer3","FalseAnswer3","FalseAnswer3"}};
    }

    void Start(){
        basicInitialization();
    }

    public void Generate()
    {
        // Найдем компонент TextQuest
        Transform TextQuest = transform.Find("Quest/TextQuest");
        Transform TextAnswer0 = transform.Find("Quest/Answer0/TextAnswer0");
        Transform TextAnswer1 = transform.Find("Quest/Answer1/TextAnswer1");
        Transform TextAnswer2 = transform.Find("Quest/Answer2/TextAnswer2");
        Transform TextAnswer3 = transform.Find("Quest/Answer3/TextAnswer3");
        int value = Random.Range(0, CountQust);
        TextQuest.GetComponent<TMP_Text>().text = Quest[value];
        TextAnswer0.GetComponent<TMP_Text>().text = Answer[value][0];
        TextAnswer1.GetComponent<TMP_Text>().text = Answer[value][1];
        TextAnswer2.GetComponent<TMP_Text>().text = Answer[value][2];
        TextAnswer3.GetComponent<TMP_Text>().text = Answer[value][3];

    }
}
