using UnityEngine;
using UnityEngine.InputSystem;

public class Explore : Quests
{


    void Start()
    {
        questActive = false;
        Name = "Explore";

        Debug.Log("Quest: " + Name);

    }
    public override void Reward()
    {
        base.Reward();
        Debug.Log("You feel rewared");
    }

    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
            { 
            questActive = true;
            }
        if (questActive == true)
               {
            Debug.Log("Explore the world!");
            Reward();
            questActive = false;
               }


    }
}
