using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIScript : MonoBehaviour
{
    bool boyDetected = false;

    bool girlDetected = false;

    private Label nameLabel;

    public Animator animGirl;

    public Animator animBoy;

    private void OnEnable()
    {

        var rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

        //fetch label
        nameLabel = rootVisualElement.Q<Label>("NameLabel");

    }


    private void Update()
    {
        if (girlDetected == true && boyDetected == false) {
            nameLabel.text = "Lele";
            animBoy.SetBool("Meet", false);
            animGirl.SetBool("Meet", false);
        }

        else if (girlDetected == false && boyDetected == true)
        {
            nameLabel.text = "Zack";
            animBoy.SetBool("Meet", false);
            animGirl.SetBool("Meet", false);

        }
        else if (girlDetected == true && boyDetected == true)
        {
                nameLabel.text = "Lele && Zack";
                
        }
        else {
            nameLabel.text = "";
            animBoy.SetBool("Meet", false);
            animGirl.SetBool("Meet", false);
        }
        
    }

    void GT()
    {
        girlDetected = true;
    }


    void GF() {
        girlDetected = false;
    }


    void BT() {
        boyDetected = true;
    }

    void BF() {
        boyDetected = false;
    }

}
