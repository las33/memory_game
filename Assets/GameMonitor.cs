using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMonitor : MonoBehaviour {


    private bool marker1, marker2, marker3, marker4, marker5, marker6, marker7, marker8, marker9, marker10;
    private bool dupla1, dupla2, dupla3, dupla4, dupla5;
    private Rect mButtonRect;   
    private string info;



    private bool showText = false;
    private float currentTime = 0.0f, executedTime = 0.0f, timeToWait = 5.0f;


    // Use this for initialization
    void Start () {
        marker1 = marker2 = marker3 = marker4 = marker5 = marker6 = marker7 = marker8 = marker9 = marker10 = false;
        dupla1 = dupla2 = dupla3 = dupla4 = dupla5 = false;
        info = "";
        mButtonRect = new Rect(50, 50, 150, 60);
    }	

    public void ReportTargetFound(string x)
    {

        switch(x){
           case  "marker1":
                marker1 = true;
                break;
            case "marker2":
                marker2 = true;
                break;
            case "marker3":
                marker3 = true;
                break;
            case "marker4":
                marker4 = true;
                break;
            case "marker5":
                marker5 = true;
                break;
            case "marker6":
                marker6 = true;
                break;
            case "marker7":
                marker7 = true;
                break;
            case "marker8":
                marker8 = true;
                break;
            case "marker9":
                marker9 = true;
                break;
            case "marker10":
                marker10 = true;
                break;
        }

        status();

    }


    void Update()
    {
        currentTime = Time.time;
        

        if (executedTime != 0.0f)
        {
            if (currentTime - executedTime > timeToWait)
            {
                executedTime = 0.0f;
                showText = false;
            }
        }
    }


    public void ReportTargetNotFound(string x)
    {

        switch (x)
        {
            case "marker1":
                marker1 = false;
                break;
            case "marker2":
                marker2 = false;
                break;
            case "marker3":
                marker3 = false;
                break;
            case "marker4":
                marker4 = false;
                break;
            case "marker5":
                marker5 = false;
                break;
            case "marker6":
                marker6 = false;
                break;
            case "marker7":
                marker7 = false;
                break;
            case "marker8":
                marker8 = false;
                break;
            case "marker9":
                marker9 = false;
                break;
            case "marker10":
                marker10 = false;
                break;
        }

        status();

    }


    private void status()
    {

        if (dupla1 == false && marker1 == true && marker2 == true) { dupla1 = true; info = "Dupla 1 encontrada!"; executedTime = Time.time; showText = true; }
        if (dupla2 == false && marker3 == true && marker4 == true) { dupla2 = true; info = "Dupla 2 encontrada!"; executedTime = Time.time; showText = true; }
        if (dupla3 == false && marker5 == true && marker6 == true) { dupla3 = true; info = "Dupla 3 encontrada!"; executedTime = Time.time; showText = true; }
        if (dupla4 == false && marker7 == true && marker8 == true) { dupla4 = true; info = "Dupla 4 encontrada!"; executedTime = Time.time; showText = true; }
        if (dupla5 == false && marker9 == true && marker10 == true) { dupla5 = true; info = "Dupla 5 encontrada!"; executedTime = Time.time; showText = true; }

        if (dupla1 && dupla2 && dupla3 && dupla4 && dupla5) { info = " Você Ganhou!"; executedTime = Time.time; showText = true; }

    }
    void OnGUI()
    {

        if (showText) { 
            // draw the GUI button
            if (GUI.Button(mButtonRect, info))
            {
               
            }
        }
    }
}


