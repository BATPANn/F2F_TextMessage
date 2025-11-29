using UnityEngine;
using TMPro;

public class F2F_SMS : MonoBehaviour
{


    public static F2F_SMS instance;


    public Transform Content_Parent;


    public Transform Content_Parent2;



    public GameObject Playersms_Ins;
    public GameObject ContactSms_Ins;



    private void Awake()
    {
        
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        



    }

    public void AddMessage(bool Sender_Player, string Message)
    {

        if (Sender_Player == true)
        {

            // add player message

            GameObject go = Instantiate(Playersms_Ins, Content_Parent.transform.position, Quaternion.identity);

            go.transform.SetParent(Content_Parent2.transform, false);

            F2F_Sms_TmproRefrence t_Ref = go.GetComponent<F2F_Sms_TmproRefrence>();

            TextMeshProUGUI txt = t_Ref.Text_Refrence;

            txt.text = Message;


        }
        else if(Sender_Player == false)
        {

            // add contact message

            GameObject go = Instantiate(ContactSms_Ins, Content_Parent.transform.position, Quaternion.identity);

            go.transform.SetParent(Content_Parent2.transform, false);

            F2F_Sms_TmproRefrence t_Ref = go.GetComponent<F2F_Sms_TmproRefrence>();

            TextMeshProUGUI txt = t_Ref.Text_Refrence;

            txt.text = Message;


        }

    }

}
