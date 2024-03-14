using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    public Button meetNova_button;
    public GameObject keyboard, videoPlayer, canvas, leftRay, rightRay;
    public TMP_InputField inputField;
    bool textIsFull;

    void Start()
    {
        meetNova_button.gameObject.SetActive(false);
        keyboard.SetActive(false);
        textIsFull = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(inputField.text.Length >= 4)
            textIsFull = true;
        else textIsFull = false;

        if(inputField.text == "4153"){
            meetNova_button.gameObject.SetActive(true);

        }else meetNova_button.gameObject.SetActive(false);
    }

    public void inputField_select(){
        keyboard.SetActive(true);
    }

    public void meetNova_bttn(){
        leftRay.SetActive(false);
        rightRay.SetActive(false);
        canvas.SetActive(false);
        videoPlayer.GetComponent<UnityEngine.Video.VideoPlayer>().Play();
    }

    public void close_bttn(){
        keyboard.SetActive(false);
    }

    private void instert_char(string c){
        inputField.text += c;
    }

    private void check_pin(){
        if(inputField.text == "4153"){
            meetNova_button.gameObject.SetActive(true);
            keyboard.SetActive(false);
        }
    } 

    public void key1_bttn(){
        if(!textIsFull)
            instert_char("1");
        check_pin();
    }

    public void key2_bttn(){
        if(!textIsFull)
            instert_char("2");
        check_pin();
    }

    public void key3_bttn(){
        if(!textIsFull)
            instert_char("3");
        check_pin();
    }

    public void key4_bttn(){
        if(!textIsFull)
            instert_char("4");
        check_pin();
    }

    public void key5_bttn(){
        if(!textIsFull)
            instert_char("5");
        check_pin();
    }

    public void key6_bttn(){
        if(!textIsFull)
            instert_char("6");
        check_pin();
    }

    public void key7_bttn(){
        if(!textIsFull)
            instert_char("7");
        check_pin();
    }

    public void key8_bttn(){
        if(!textIsFull)
            instert_char("8");
        check_pin();
    }

    public void key9_bttn(){
        if(!textIsFull)
            instert_char("9");
        check_pin();
    }

    public void key0_bttn(){
        if(!textIsFull)
            instert_char("0");
        check_pin();
    }

    public void erase_bttn(){
        int l = inputField.text.Length;
        string newText = "";
        for (int i = 0; i < l-1; i++)
            newText += inputField.text[i].ToString();
        inputField.text = newText;
    }
}
