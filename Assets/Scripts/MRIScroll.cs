using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

public class MRIScroll : MonoBehaviour {
    //all MRI images
    public List<RawImage> axialImages = new List<RawImage>(27);
    public List<RawImage> coronalImages = new List<RawImage>(20);
    public List<RawImage> sagittalImages = new List<RawImage>(21);

    //all MRI slices
    public List<GameObject> axialSlice = new List<GameObject>(27);
    public List<GameObject> coronalSlice = new List<GameObject>(20);
    public List<GameObject> sagittalSlice = new List<GameObject>(21);

    public bool selectAxial;
    public bool selectCoronal;
    public bool selectSag;

    //bool list is used for both images and slices lists so that the same image/slice is turn on/off
    public List<bool> axialBool = new List<bool>(27);
    public List<bool> coronalBool = new List<bool>(27);
    public List<bool> sagBool = new List<bool>(21);

    public Slider scroll;

    public GameObject networking;

    // Use this for initialization
    void Start () {
        //all images and slices are not visible
        axialBool = IsOff(axialBool);
        coronalBool = IsOff(coronalBool);
        sagBool = IsOff(sagBool);
        axialImages = ChangeImage(axialBool, axialImages);
        axialSlice = ChangeSlice(axialBool, axialSlice);
        coronalImages = ChangeImage(coronalBool, coronalImages);
        coronalSlice = ChangeSlice(coronalBool, coronalSlice);
        sagittalImages = ChangeImage(sagBool, sagittalImages);
        sagittalSlice = ChangeSlice(sagBool, sagittalSlice);
    }

    public void ChangeValue()
    {
        //turn off all bools
        axialBool = IsOff(axialBool);
        coronalBool = IsOff(coronalBool);
        sagBool = IsOff(sagBool);

        if (selectAxial)
        {
            //take the value of the scroll bar and turn on that slice
            int x = Convert.ToInt32(scroll.value);
            axialBool[x] = true;
            networking.GetComponent<NetworkService>().RecordMouse("AxialSlice", x); //record slice value being viewed
        }
        else if (selectCoronal)
        {
            int x = Convert.ToInt32(scroll.value);
            coronalBool[x] = true;
            networking.GetComponent<NetworkService>().RecordMouse("CoronalSlice", x);
        }
        else
        {
            int x = Convert.ToInt32(scroll.value);
            sagBool[x] = true;
            networking.GetComponent<NetworkService>().RecordMouse("SagSlice", x);
        }

        //set which images/slices are visible
        axialImages = ChangeImage(axialBool, axialImages);
        axialSlice = ChangeSlice(axialBool, axialSlice);
        coronalImages = ChangeImage(coronalBool, coronalImages);
        coronalSlice = ChangeSlice(coronalBool, coronalSlice);
        sagittalImages = ChangeImage(sagBool, sagittalImages);
        sagittalSlice = ChangeSlice(sagBool, sagittalSlice);
    }

    //axial toggle on
    public void SwitchAxial()
    {
        selectAxial = true;
        selectCoronal = false;
        selectSag = false;
        ChangeValue();
    }

    //coronal toggle on 
    public void SwitchCoronal()
    {
        selectAxial = false;
        selectCoronal = true;
        selectSag = false;
        ChangeValue();
    }

    //sagitall toggle on
    public void SwitchSag()
    {
        selectAxial = false;
        selectCoronal = false;
        selectSag = true;
        ChangeValue();
    }

    //turns off all images and slice for axial
    public void AxialOff()
    {
        selectAxial = false;
        axialBool = IsOff(axialBool);
        axialImages = ChangeImage(axialBool, axialImages);
        axialSlice = ChangeSlice(axialBool, axialSlice);
    }

    //turns off all images and slice for coronal
    public void CoronalOff()
    {
        selectCoronal = false;
        coronalBool = IsOff(coronalBool);
        coronalImages = ChangeImage(coronalBool, coronalImages);
        coronalSlice = ChangeSlice(coronalBool, coronalSlice);
    }

    //turns off all images and slice for sagittal
    public void SagOff()
    {
        selectSag = false;
        sagBool = IsOff(sagBool);
        sagittalImages = ChangeImage(sagBool, sagittalImages);
        sagittalSlice = ChangeSlice(sagBool, sagittalSlice);
    }

    //function used to turn visibility off for image/slice lists
    public List<bool> IsOff(List<bool> offList)
    {
        for (int i = 0; i < offList.Count; i++)
        {
            offList[i] = false;
        }

        return (offList);
    }

    //turns correct image on 
    public List<RawImage> ChangeImage(List<bool> boolList, List<RawImage> imageList)
    {
        for (int i = 0; i < imageList.Count; i++)
        {
            imageList[i].gameObject.SetActive(boolList[i]);
        }

        return (imageList);
    }

    //turns on correct slice
    public List<GameObject> ChangeSlice(List<bool> boolList, List<GameObject> sliceList)
    {
        for (int i = 0; i < sliceList.Count; i++)
        {
            sliceList[i].gameObject.SetActive(boolList[i]);
        }

        return (sliceList);
    }
}
