using UnityEngine;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class ButtonVisibility : MonoBehaviour {
    public GameObject cortStruct;

    public GameObject cortMainMenu;
    public GameObject lobeMenu;
    public GameObject frontalMenu;
    public GameObject parietalMenu;
    public GameObject temporalMenu;
    public GameObject gyriMenu;
    public GameObject sulciMenu;

    public GameObject latVent;
    public GameObject cerebralAque;
    public GameObject thirdVent;
    public GameObject fourthVent;

    public GameObject Cere;

    public GameObject cereCortex;
    public GameObject peduncles;
    public GameObject vermis;
    public GameObject cereWhiteMatter;

    public GameObject vasMainMenu;
    public GameObject commCarotidMenu;
    public GameObject intCarotidMenu1;
    public GameObject intCarotidMenu2;
    public GameObject extCarotidMenu1;
    public GameObject vertMenu;
    public GameObject basilarMenu1;
    public GameObject basilarMenu2;

    public GameObject SupSagSin;
    public GameObject InfSagSin;
    public GameObject CavernousSin;
    public GameObject SupPetrosalSin;
    public GameObject SphernoperietalSin;
    public GameObject InfPetrosalSin;
    public GameObject OccipitalSin;
    public GameObject TransSin;
    public GameObject SigmoidSin;
    public GameObject StraightSin;

    public GameObject CNI;
    public GameObject CNII;
    public GameObject CNIII;
    public GameObject CNIV;
    public GameObject CNV;
    public GameObject CNVI;
    public GameObject CNVII;
    public GameObject CNVIII;
    public GameObject CNIX;
    public GameObject CNX;
    public GameObject CNXI;
    public GameObject CNXII;

    public GameObject whiteMatter;
    public GameObject corpCall;
    public GameObject intCap;
    public GameObject fornix;
    public GameObject caudateNuc;
    public GameObject gloPall;
    public GameObject putamen;
    public GameObject thalamus;
    public GameObject hypothalamus;
    public GameObject hippocampus;

    public bool is3D;

    Vector3 drop1;
    Vector3 drop1Start;
    Vector3 drop2;
    Vector3 drop2Start;

    Color reset;
    Color highlight = Color.cyan;

    IList<GameObject>[] allButtons = new IList<GameObject>[22];

    bool[] buttonVal = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false,
        false, false, false, false, false, false, false, false, false, false, false };
    enum buttonToggle {cortStruct, ventSys, cere, brainStem, spinalCord, vas, vasCommCar, vasIntCar, vasIntCarAntCerebral,
        vasExtCar, vasVert, vasBasilar, vasBasilarAntInfCere, sinuses, nerves, subCortSturct, cortLobe,
        frontalLobe, parietalLobe, temporalLobe, cortGyri, cortSulci};

    void Start()
    {
        reset = cortStruct.GetComponent<Image>().color;
        allButtons[(int)buttonToggle.cortStruct] = new List<GameObject>(new GameObject[] { cortMainMenu });
        allButtons[(int)buttonToggle.ventSys] = new List<GameObject>(new GameObject[] { latVent, cerebralAque, thirdVent, fourthVent });
        allButtons[(int)buttonToggle.cere] = new List<GameObject>(new GameObject[] { cereCortex, peduncles, vermis, cereWhiteMatter });
        allButtons[(int)buttonToggle.brainStem] = new List<GameObject>(new GameObject[] { null });
        allButtons[(int)buttonToggle.spinalCord] = new List<GameObject>(new GameObject[] { null });
        allButtons[(int)buttonToggle.vas] = new List<GameObject>(new GameObject[] { vasMainMenu });
        allButtons[(int)buttonToggle.vasCommCar] = new List<GameObject>(new GameObject[] { commCarotidMenu });
        allButtons[(int)buttonToggle.vasIntCar] = new List<GameObject>(new GameObject[] { intCarotidMenu1 });
        allButtons[(int)buttonToggle.vasIntCarAntCerebral] = new List<GameObject>(new GameObject[] { intCarotidMenu2 });
        allButtons[(int)buttonToggle.vasExtCar] = new List<GameObject>(new GameObject[] { extCarotidMenu1 });
        allButtons[(int)buttonToggle.vasVert] = new List<GameObject>(new GameObject[] { vertMenu });
        allButtons[(int)buttonToggle.vasBasilar] = new List<GameObject>(new GameObject[] { basilarMenu1 });
        allButtons[(int)buttonToggle.vasBasilarAntInfCere] = new List<GameObject>(new GameObject[] { basilarMenu2 });
        allButtons[(int)buttonToggle.sinuses] = new List<GameObject>(new GameObject[]{SupSagSin, InfSagSin, CavernousSin, SupPetrosalSin,
            SphernoperietalSin, InfPetrosalSin, OccipitalSin, TransSin, SigmoidSin, StraightSin});
        allButtons[(int)buttonToggle.nerves] = new List<GameObject>(new GameObject[] { CNI, CNII, CNIII, CNIV, CNV, CNVI, CNVII, CNVIII, CNIX,
            CNX, CNXI, CNXII });
        allButtons[(int)buttonToggle.subCortSturct] = new List<GameObject>(new GameObject[] {whiteMatter, corpCall, intCap, fornix, caudateNuc, gloPall,
            putamen, thalamus, hypothalamus, hippocampus });
        allButtons[(int)buttonToggle.cortLobe] = new List<GameObject>(new GameObject[] { lobeMenu });
        allButtons[(int)buttonToggle.frontalLobe] = new List<GameObject>(new GameObject[] { frontalMenu });
        allButtons[(int)buttonToggle.parietalLobe] = new List<GameObject>(new GameObject[] { parietalMenu });
        allButtons[(int)buttonToggle.temporalLobe] = new List<GameObject>(new GameObject[] { temporalMenu });
        allButtons[(int)buttonToggle.cortGyri] = new List<GameObject>(new GameObject[] { gyriMenu });
        allButtons[(int)buttonToggle.cortSulci] = new List<GameObject>(new GameObject[] { sulciMenu });
    }

    public void cortStructDropDown()
    {
        resetStatus((int)buttonToggle.cortStruct);
        buttTogg();
    }

    public void ventSysDropDown()
    {
        resetStatus((int)buttonToggle.ventSys);
        buttTogg();
    }

    public void cereDropDown()
    {
        resetStatus((int)buttonToggle.cere);
        buttTogg();
    }

    public void brainDropDown()
    {
        resetStatus((int)buttonToggle.brainStem);
        buttTogg();
    }

    public void spinalDropDown()
    {
        resetStatus((int)buttonToggle.spinalCord);
        buttTogg();
    }

    public void vasDropDown()
    {
        resetStatus((int)buttonToggle.vas);
        buttTogg();
    }

    public void vasCommCarotidDropDown()
    {
        resetStatus((int)buttonToggle.vasCommCar);
        buttTogg();
    }

    public void vasIntCarotidDropDown()
    {
        resetStatus((int)buttonToggle.vasIntCar);
        buttTogg();
    }

    public void vasIntCarotidAntCerebralDropDown()
    {
        resetStatus((int)buttonToggle.vasIntCarAntCerebral);
        buttTogg();
    }

    public void vasExtCarotidDropDown()
    {
        resetStatus((int)buttonToggle.vasExtCar);
        buttTogg();
    }

    public void vasVertDropDown()
    {
        resetStatus((int)buttonToggle.vasVert);
        buttTogg();
    }

    public void vasBasilarDropDown()
    {
        resetStatus((int)buttonToggle.vasBasilar);
        buttTogg();
    }

    public void vasBasilarAntInfCereDropDown()
    {
        resetStatus((int)buttonToggle.vasBasilarAntInfCere);
        buttTogg();
    }

    public void vasJugular()
    {
        resetStatus((int)buttonToggle.vas);
        buttTogg();
    }

    public void sinusesDropDown()
    {
        resetStatus((int)buttonToggle.sinuses);
        buttTogg();
    }

    public void nervesDropDown()
    {
        resetStatus((int)buttonToggle.nerves);
        buttTogg();
    }

    public void subCortDropDown()
    {
        resetStatus((int)buttonToggle.subCortSturct);
        buttTogg();
    }

    public void cortLobeDropDown()
    {
        resetStatus((int)buttonToggle.cortLobe);
        buttTogg();
    }

    public void frontalLobeDropDown()
    {
        resetStatus((int)buttonToggle.frontalLobe);
        buttTogg();
    }

    public void parietalLobeDropDown()
    {
        resetStatus((int)buttonToggle.parietalLobe);
        buttTogg();
    }

    public void temporalLobeDropDown()
    {
        resetStatus((int)buttonToggle.temporalLobe);
        buttTogg();
    }

    public void occipitalLobeDropDown()
    {
        resetStatus((int)buttonToggle.cortLobe);
        buttTogg();
    }

    public void cortGyriDropDown()
    {
        resetStatus((int)buttonToggle.cortGyri);
        buttTogg();
    }

    public void cortSulciDropDown()
    {
        resetStatus((int)buttonToggle.cortSulci);
        buttTogg();
    }

    public void resetDropDown()
    {
        resetStatus(-1);
        buttTogg();
    }

    void buttTogg()
    {
        for (int i = 0; i < allButtons.Length; i++)
        {
            if (!(i == 3 || i == 4))
            {
                foreach (GameObject x in allButtons[i])
                {
                    x.SetActive(buttonVal[i]);
                }
            }
        }
    }

    void resetStatus(int input)
    {
        for (int i = 0; i < buttonVal.Length; i++)
        {
            if (i == input)
                buttonVal[i] = true;
            else
                buttonVal[i] = false;
        }
    }
}
