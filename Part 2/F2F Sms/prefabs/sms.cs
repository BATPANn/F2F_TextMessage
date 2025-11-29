using UnityEngine;

public class sms : MonoBehaviour
{

    public static sms instance;

    public Transform Content_Parent;

    public GameObject Incoming_Ins;
    public GameObject Outcoming_Ins;

    private void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        AddMessage(true, "Hello everyone");
        AddMessage(true, "Hello everyone");
        AddMessage(true, "Hello everyone");
        AddMessage(false, "Hello batpan");
        AddMessage(false, "Hello batpan");
        AddMessage(false, "Hello batpan");
        AddMessage(false, "Hello batpan");
        AddMessage(false, "Hello batpan");
        AddMessage(false, "Hello batpan");
        AddMessage(false, "Hello batpan");
        AddMessage(false, "Hello batpan");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddMessage(bool Sender_Player, string message)
    {

        if (Sender_Player)
        {
            GameObject g = Instantiate(Incoming_Ins, Content_Parent.transform.position, Quaternion.identity);
            g.transform.SetParent(Content_Parent, false);

            var childfinder = g.GetComponent<TextFinder>();

            var t = childfinder.Text_Child;

            t.text = message;

        }
        else
        {
            GameObject d = Instantiate(Outcoming_Ins, Content_Parent.transform.position, Quaternion.identity);
            d.transform.SetParent(Content_Parent, false);

            var childfinder = d.GetComponent<TextFinder>();

            var t = childfinder.Text_Child;

            t.text = message;

        }

    }

}
