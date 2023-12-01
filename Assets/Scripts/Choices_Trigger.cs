using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using PathCreation;

public class Choices_Trigger : MonoBehaviour
{
    public Canvas Choice_Canvas;
    public Button Btn_Service1;
    public Button Btn_Service2;
    public Button Btn_Service3;
    public AudioSource Raudio;
    [SerializeField] private Animator QEmployee;
    [SerializeField] string videoFileName;
    public VideoPlayer vidPlayer;
    public GameObject Trail;
    public GameObject Trail2;
    public GameObject Trail3;
    bool VidPlayed;

    void Start()
    {
        Choice_Canvas.enabled = false;
        QEmployee.SetBool("PlayPoint", false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Trail.SetActive(false);
        Trail2.SetActive(false);
        Trail3.SetActive(false);
        VidPlayed = false;
    }

    void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            Choice_Canvas.enabled = true;
            Raudio.Play();
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;

            if (VidPlayed == false)
            {
                string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, videoFileName);
                Debug.Log(videoPath);
                vidPlayer.url = videoPath;
                vidPlayer.Play();
            }
        }
    }

    public void Service1()
    {
        Choice_Canvas.enabled = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        QEmployee.SetBool("PlayPoint", true);
        Trail.SetActive(true);
    }

    public void Service2()
    {
        Choice_Canvas.enabled = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Trail.SetActive(false);
        Trail2.SetActive(true);
        Trail3.SetActive(false);
    }

    public void Service3()
    {
        Choice_Canvas.enabled = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Trail.SetActive(false);
        Trail2.SetActive(false);
        Trail3.SetActive(true);
    }

    void OnTriggerExit(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            Choice_Canvas.enabled = false;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            VidPlayed = true;
        }
    }
}
