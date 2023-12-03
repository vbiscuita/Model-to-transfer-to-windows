using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

public class MRIToggle : MonoBehaviour
{

    public Toggle axial;
    public Toggle coronal;
    public Toggle sagittal;

    public Slider scroll;

    public int axialMax;
    public int coronalMax;
    public int sagittalMax;

    public Toggle skull;

    public GameObject networking;
    public GameObject model;

    public Material[] allMat = new Material[13]; 

    // Use this for initialization
    void Start()
    {
        //turn off all MRI toggles and hide the scroll bar. Make sure all materials are opaque not transparent
        axial.isOn = false;
        coronal.isOn = false;
        sagittal.isOn = false;
        scroll.gameObject.SetActive(false);
        for (int i = 0; i < allMat.Length; i++)
        {
            allMat[i] = MakeOpaque(allMat[i]);
        }
    }

    //All three toggles have the same set up
    public void axialToggle()
    {
        //axial toggle turned on 
        if (axial.isOn)
        {
            skull.GetComponent<ToggleButtons>().toggleSkullOnClick();
            skull.isOn = false;//skull is off

            coronal.isOn = false; //turn off coronal and sagittal
            sagittal.isOn = false;

            scroll.maxValue = axialMax; //adjust scrollbar to the number of slices in axial view

            scroll.GetComponent<MRIScroll>().SwitchAxial();
        }
        //axial toggle turned off
        else
        {
            scroll.GetComponent<MRIScroll>().AxialOff();
        }
        networking.GetComponent<NetworkService>().RecordMouse("ToggleAxial", 1); //record toggle click
        checkScrollVis(); 
    }

    public void coronalToggle()
    {
        if (coronal.isOn)
        {
            skull.GetComponent<ToggleButtons>().toggleSkullOnClick();
            skull.isOn = false;

            axial.isOn = false;
            sagittal.isOn = false;

            if (scroll.value > 19) 
                scroll.value = 19; 
            scroll.maxValue = coronalMax;

            scroll.GetComponent<MRIScroll>().SwitchCoronal();
        }
        else
        {
            scroll.GetComponent<MRIScroll>().CoronalOff();
        }
        networking.GetComponent<NetworkService>().RecordMouse("ToggleCoronal", 1);
        checkScrollVis();
    }

    public void sagittalToggle()
    {
        if (sagittal.isOn)
        {
            skull.GetComponent<ToggleButtons>().toggleSkullOnClick();
            skull.isOn = false;

            coronal.isOn = false;
            axial.isOn = false;

            if (scroll.value > 20) //sagittal has less slices than the other two views. Changes scrollbar to a lower value 
                scroll.value = 20; //when axial/coronal is selected before had and then swithced to sagittal.
            scroll.maxValue = sagittalMax;

            scroll.GetComponent<MRIScroll>().SwitchSag();
        }
        else
        {
            scroll.GetComponent<MRIScroll>().SagOff();
        }

        networking.GetComponent<NetworkService>().RecordMouse("ToggleSagg", 1);
        checkScrollVis();
    }

    void checkScrollVis()
    {
        //if all toggles are off, scroll bar is off
        if (axial.isOn == false && coronal.isOn == false && sagittal.isOn == false)
        {
            scroll.gameObject.SetActive(false);
            for (int i = 0; i < allMat.Length; i++)
            {
                allMat[i] = MakeOpaque(allMat[i]); //all objects should be opaque
            }

            model.GetComponent<DisplayObjVisibility3D>().ChangedAlpha(allMat); //changing the materials used in DisplayObjVisibility3D
        }
        //if any toggle is on, scroll bar is visible
        else
        {
            scroll.gameObject.SetActive(true);
            for (int i = 0; i < allMat.Length; i++)
            {
                if (i == 0)
                    allMat[i] = MakeTranspart(allMat[i]); //cortex is the most transparent
                else
                    allMat[i] = MakeSemiTransparent(allMat[i]); //internal structures are less transparent so they are still visible
            }
            model.GetComponent<DisplayObjVisibility3D>().ChangedAlpha(allMat);
        }
    }

    Material MakeOpaque(Material mat)
    {
        Shader shade1 = Shader.Find("Standard"); //shader used in material
        Color colour = mat.color;
        colour.a = 1f; //highest alpha
        mat.color = colour;
        mat.shader = shade1;

        return mat;
    }

    Material MakeTranspart(Material mat)
    {
        Shader shade1 = Shader.Find("Legacy Shaders/Transparent/Diffuse"); //transparent shader
        Color colour = mat.color;
        colour.a = 0.12f; //most transparent alpha
        mat.color = colour;
        mat.shader = shade1;

        return mat;
    }

    Material MakeSemiTransparent(Material mat)
    {
        Shader shade1 = Shader.Find("Legacy Shaders/Transparent/Diffuse");
        Color colour = mat.color;
        colour.a = 0.5f; //semi transparent alpha
        mat.color = colour;
        mat.shader = shade1;

        return mat;
    }
}
