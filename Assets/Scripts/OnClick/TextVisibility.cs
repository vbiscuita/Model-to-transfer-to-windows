using UnityEngine;
using System.Collections.Generic;
using System;

public class TextVisibility : MonoBehaviour {

    public GameObject frontalLobe_Text;
    public GameObject parietalLobe_Text;
    public GameObject temporalLobe_Text;
    public GameObject occipitalLobe_Text;

    public GameObject brocas_Text;
    public GameObject frontalEyeField_Text;
    public GameObject preMotorCortex_Text;
    public GameObject SMA_Text;

    public GameObject wernickes_Text;

    public GameObject preCentGyrus_Text;
    public GameObject postCentGyrus_Text;
    public GameObject cingulateGyrus_Text;

    public GameObject centSulcus_Text;
    public GameObject latSulcus_Text;
    public GameObject periSulcus_Text;

    public GameObject latVent_Text;
    public GameObject cerebralAque_Text;
    public GameObject thirdVent_Text;
    public GameObject fourthVent_Text;

    public GameObject cereCortex_Text;
    public GameObject peduncles_Text;
    public GameObject vermis_Text;
    public GameObject cereWhiteMatter_Text;

    public GameObject brainstem_Text;
    public GameObject spinalCord_Text;

    public GameObject ASArt_Text;
    public GameObject VertArt_Text;
    public GameObject PostInfCereArt_Text;
    public GameObject BasilarArt_Text;
    public GameObject AntInfCereArt_Text;
    public GameObject PontineArt_Text;
    public GameObject SupCereArt_Text;
    public GameObject FacialArt_Text;
    public GameObject IntCarotidArt_Text;
    public GameObject LabArt_Text;
    public GameObject MaxArt_Text;
    public GameObject MidCerebralArt_Text;
    public GameObject OccipitalArt_Text;
    public GameObject OpthalmicArt_Text;
    public GameObject PostCerebralArt_Text;
    public GameObject AntCerebralArt_Text;
    public GameObject AscPharArt_Text;
    public GameObject PostAuricularArt_Text;
    public GameObject PostCommArt_Text;
    public GameObject MidMeningealArt_Text;
    public GameObject SupTempArt_Text;
    public GameObject ExtCarotidArt_Text;
    public GameObject SupThyroidArt_Text;
    public GameObject LingualArt_Text;
    public GameObject IntJugular_Text;
    public GameObject AntCommArt_Text;

    public GameObject SupSagSin_Text;
    public GameObject InfSagSin_Text;
    public GameObject CavernousSin_Text;
    public GameObject SupPetrosalSin_Text;
    public GameObject SphernoperietalSin_Text;
    public GameObject InfPetrosalSin_Text;
    public GameObject OccipitalSin_Text;
    public GameObject TransSin_Text;
    public GameObject SigmoidSin_Text;
    public GameObject StraightSin_Text;

    public GameObject CNI_Text;
    public GameObject CNII_Text;
    public GameObject CNIII_Text;
    public GameObject CNIV_Text;
    public GameObject CNV_Text;
    public GameObject CNVI_Text;
    public GameObject CNVII_Text;
    public GameObject CNVIII_Text;
    public GameObject CNIX_Text;
    public GameObject CNX_Text;
    public GameObject CNXI_Text;
    public GameObject CNXII_Text;

    public GameObject whiteMatter_Text;
    public GameObject corpCall_Text;
    public GameObject intCap_Text;
    public GameObject fornix_Text;
    public GameObject caudateNuc_Text;
    public GameObject gloPall_Text;
    public GameObject putamen_Text;
    public GameObject thalamus_Text;
    public GameObject hypothalamus_Text;
    public GameObject hippocampus_Text;

    public GameObject titlebkgd;
    public GameObject addBkgd;

    IList<GameObject>[] allButtons = new IList<GameObject>[15];

    enum buttonToggle { ventSys, cere, brainStem, spinalCord, vas, sinuses, nerves, subCortSturct, cortLobe,
        frontalLobe, parietalLobe, temporalLobe, cortGyri, cortSulci, bkgd };

    void Start()
    {
        allButtons[(int)buttonToggle.ventSys] = new List<GameObject>(new GameObject[] { latVent_Text, cerebralAque_Text,
            thirdVent_Text, fourthVent_Text });
        allButtons[(int)buttonToggle.cere] = new List<GameObject>(new GameObject[] { cereCortex_Text, peduncles_Text,
            vermis_Text, cereWhiteMatter_Text });
        allButtons[(int)buttonToggle.brainStem] = new List<GameObject>(new GameObject[] { brainstem_Text });
        allButtons[(int)buttonToggle.spinalCord] = new List<GameObject>(new GameObject[] { spinalCord_Text });
        allButtons[(int)buttonToggle.vas] = new List<GameObject>(new GameObject[]{ ASArt_Text, VertArt_Text,
            PostInfCereArt_Text, BasilarArt_Text, AntInfCereArt_Text, PontineArt_Text, SupCereArt_Text, FacialArt_Text,
            IntCarotidArt_Text, LabArt_Text, MaxArt_Text, MidCerebralArt_Text, OccipitalArt_Text, OpthalmicArt_Text,
            PostCerebralArt_Text, AntCerebralArt_Text, AscPharArt_Text, PostAuricularArt_Text, PostCommArt_Text,
            MidMeningealArt_Text, SupTempArt_Text, ExtCarotidArt_Text, SupThyroidArt_Text, LingualArt_Text, IntJugular_Text, AntCommArt_Text });
        allButtons[(int)buttonToggle.sinuses] = new List<GameObject>(new GameObject[]{SupSagSin_Text, InfSagSin_Text,
            CavernousSin_Text, SupPetrosalSin_Text, SphernoperietalSin_Text, InfPetrosalSin_Text,
            OccipitalSin_Text, TransSin_Text, SigmoidSin_Text, StraightSin_Text});
        allButtons[(int)buttonToggle.nerves] = new List<GameObject>(new GameObject[] { CNI_Text, CNII_Text, CNIII_Text,
            CNIV_Text, CNV_Text, CNVI_Text, CNVII_Text, CNVIII_Text, CNIX_Text, CNX_Text, CNXI_Text, CNXII_Text});
        allButtons[(int)buttonToggle.subCortSturct] = new List<GameObject>(new GameObject[] {whiteMatter_Text, corpCall_Text,
            intCap_Text, fornix_Text, caudateNuc_Text, gloPall_Text, putamen_Text, thalamus_Text, hypothalamus_Text,
            hippocampus_Text });
        allButtons[(int)buttonToggle.cortLobe] = new List<GameObject>(new GameObject[] { frontalLobe_Text,
            parietalLobe_Text, temporalLobe_Text, occipitalLobe_Text });
        allButtons[(int)buttonToggle.frontalLobe] = new List<GameObject>(new GameObject[] { brocas_Text,
            frontalEyeField_Text, preMotorCortex_Text, SMA_Text });
        allButtons[(int)buttonToggle.parietalLobe] = new List<GameObject>(new GameObject[] { postCentGyrus_Text });
        allButtons[(int)buttonToggle.temporalLobe] = new List<GameObject>(new GameObject[] { wernickes_Text });
        allButtons[(int)buttonToggle.cortGyri] = new List<GameObject>(new GameObject[] { preCentGyrus_Text,
            postCentGyrus_Text, cingulateGyrus_Text });
        allButtons[(int)buttonToggle.cortSulci] = new List<GameObject>(new GameObject[] { centSulcus_Text, latSulcus_Text,
            periSulcus_Text });
        allButtons[(int)buttonToggle.bkgd] = new List<GameObject>(new GameObject[] { titlebkgd, addBkgd });
    }

    public void frontalLobeShowText()
    {
        buttTogg();
        frontalLobe_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void brocasShowText()
    {
        buttTogg();
        brocas_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void frontalEyeFieldShowText()
    {
        buttTogg();
        frontalEyeField_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void preMotorCortexShowText()
    {
        buttTogg();
        preMotorCortex_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void SMAShowText()
    {
        buttTogg();
        SMA_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void parietalLobeShowText()
    {
        buttTogg();
        parietalLobe_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void temporalLobeShowText()
    {
        buttTogg();
        temporalLobe_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void wernickesShowText()
    {
        buttTogg();
        wernickes_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void occipitalLobeShowText()
    {
        buttTogg();
        occipitalLobe_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void preCentGyrusShowText()
    {
        buttTogg();
        preCentGyrus_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void postCentGyrusShowText()
    {
        buttTogg();
        postCentGyrus_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void cingulateGyrusShowText()
    {
        buttTogg();
        cingulateGyrus_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void centSulcusShowText()
    {
        buttTogg();
        centSulcus_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void latSulcusShowText()
    {
        buttTogg();
        latSulcus_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void periSulcusShowText()
    {
        buttTogg();
        periSulcus_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void latVentShowText()
    {
        buttTogg();
        latVent_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void cerebralAqueShowText()
    {
        buttTogg();
        cerebralAque_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void thirdVentShowText()
    {
        buttTogg();
        thirdVent_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void fourthVentShowText()
    {
        buttTogg();
        fourthVent_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void cereCortexShowText()
    {
        buttTogg();
        cereCortex_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void pedunclesShowText()
    {
        buttTogg();
        peduncles_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void vermisShowText()
    {
        buttTogg();
        vermis_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void cereWhiteMatterShowText()
    {
        buttTogg();
        cereWhiteMatter_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void brainstemShowText()
    {
        buttTogg();
        brainstem_Text.SetActive(true);
        addBkgd.SetActive(true);
    }

    public void spinalCordShowText()
    {
        buttTogg();
        spinalCord_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void ASArtShowText()
    {
        buttTogg();
        ASArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void VertArtShowText()
    {
        buttTogg();
        VertArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void PostInfCereArtShowText()
    {
        buttTogg();
        PostInfCereArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void BasilarArtShowText()
    {
        buttTogg();
        BasilarArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void AntInfCereArtShowText()
    {
        buttTogg();
        AntInfCereArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void PontineArtShowText()
    {
        buttTogg();
        PontineArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void SupCereArtShowText()
    {
        buttTogg();
        SupCereArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void FacialArtShowText()
    {
        buttTogg();
        FacialArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void IntCarotidArtShowText()
    {
        buttTogg();
        IntCarotidArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void LabArtShowText()
    {
        buttTogg();
        LabArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void MaxArtShowText()
    {
        buttTogg();
        MaxArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void MidCerebralArtShowText()
    {
        buttTogg();
        MidCerebralArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void OccipitalArtShowText()
    {
        buttTogg();
        OccipitalArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void OpthalmicArtShowText()
    {
        buttTogg();
        OpthalmicArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void PostCerebralArtShowText()
    {
        buttTogg();
        PostCerebralArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void AntCerebralArtShowText()
    {
        buttTogg();
        AntCerebralArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void AscPharArtShowText()
    {
        buttTogg();
        AscPharArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void PostAuricularArtShowText()
    {
        buttTogg();
        PostAuricularArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void PostCommArtArtShowText()
    {
        buttTogg();
        PostCommArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void MidMeningealArtShowText()
    {
        buttTogg();
        MidMeningealArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void SupTempArtShowText()
    {
        buttTogg();
        SupTempArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void AntCommArtShowText()
    {
        buttTogg();
        AntCommArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void ExtCarotidArtShowText()
    {
        buttTogg();
        ExtCarotidArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void SupThyroidArtShowText()
    {
        buttTogg();
        SupThyroidArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void LingualArtShowText()
    {
        buttTogg();
        LingualArt_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void IntJugularShowText()
    {
        buttTogg();
        IntJugular_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void SupSagSinShowText()
    {
        buttTogg();
        SupSagSin_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void InfSagSinShowText()
    {
        buttTogg();
        InfSagSin_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void CavernousSinShowText()
    {
        buttTogg();
        CavernousSin_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void SupPetrosalSinShowText()
    {
        buttTogg();
        SupPetrosalSin_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void SphernoperietalSinShowText()
    {
        buttTogg();
        SphernoperietalSin_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void InfPetrosalSinShowText()
    {
        buttTogg();
        InfPetrosalSin_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }   

    public void OccipitalSinShowText()
    {
        buttTogg();
        OccipitalSin_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void TransSinShowText()
    {
        buttTogg();
        TransSin_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void SigmoidSinShowText()
    {
        buttTogg();
        SigmoidSin_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }   

    public void StraightSinShowText()
    {
        buttTogg();
        StraightSin_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void CNIShowText()
    {
        buttTogg();
        CNI_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void CNIIShowText()
    {
        buttTogg();
        CNII_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void CNIIIShowText()
    {
        buttTogg();
        CNIII_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void CNIVShowText()
    {
        buttTogg();
        CNIV_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void CNVShowText()
    {
        buttTogg();
        CNV_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void CNVIShowText()
    {
        buttTogg();
        CNVI_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void CNVIIShowText()
    {
        buttTogg();
        CNVII_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void CNVIIIShowText()
    {
        buttTogg();
        CNVIII_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void CNIXShowText()
    {
        buttTogg();
        CNIX_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void CNXShowText()
    {
        buttTogg();
        CNX_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void CNXIShowText()
    {
        buttTogg();
        CNXI_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void CNXIIShowText()
    {
        buttTogg();
        CNXII_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void whiteMatterShowText()
    {
        buttTogg();
        whiteMatter_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void corpCallShowText()
    {
        buttTogg();
        corpCall_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void intCapShowText()
    {
        buttTogg();
        intCap_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void fornixShowText()
    {
        buttTogg();
        fornix_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void caudateNucShowText()
    {
        buttTogg();
        caudateNuc_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void gloPallShowText()
    {
        buttTogg();
        gloPall_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void putamenShowText()
    {
        buttTogg();
        putamen_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void thalamusShowText()
    {
        buttTogg();
        thalamus_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void hypothalamusShowText()
    {
        buttTogg();
        hypothalamus_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    public void hippocampusShowText()
    {
        buttTogg();
        hippocampus_Text.SetActive(true);
        titlebkgd.SetActive(true);
    }

    void buttTogg()
    {
        for (int i = 0; i < allButtons.Length; i++)
        {
            foreach (GameObject x in allButtons[i])
            {
                x.SetActive(false);
            }
        }
    }

}
