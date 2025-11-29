using UnityEngine;

public class F2F_Sms_testing : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        F2F_SMS.instance.AddMessage(true, "Hi I'm batpan");
        F2F_SMS.instance.AddMessage(false, "That's cool");

    }
}
