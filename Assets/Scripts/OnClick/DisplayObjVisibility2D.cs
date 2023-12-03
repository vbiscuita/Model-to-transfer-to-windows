using UnityEngine;
using System.Collections.Generic;
using System;

public class DisplayObjVisibility2D : MonoBehaviour
{

    public GameObject frontalLobe_Obj;
    public GameObject parietalLobe_Obj;
    public GameObject temporalLobe_Obj;
    public GameObject occipitalLobe_Obj;

    public GameObject brocas_Obj;
    public GameObject frontalEyeField_Obj;
    public GameObject preMotor_Obj;
    public GameObject SMA_Obj;

    public GameObject wernickes_Obj;

    public GameObject preCentGyrus_Obj;
    public GameObject postCentGyrus_Obj;
    public GameObject cingulateGyrus_Obj;

    public GameObject centSulcus_Obj;
    public GameObject latSulcus_Obj;
    public GameObject pariSulcus_Obj;

    public GameObject latVent_Obj;
    public GameObject latVentAx_Obj;
    public GameObject cerebralAque_Obj;
    public GameObject thirdVent_Obj;
    public GameObject fourthVent_Obj;

    public GameObject cerebellum_Obj;
    public GameObject cereCortex_Obj;
    public GameObject peduncles_Obj;
    public GameObject vermis_Obj;
    public GameObject cereWhiteMatter_Obj;

    public GameObject brainstem_Obj;
    public GameObject spinalCord_Obj;

    public GameObject ASArt_Obj;
    public GameObject VertArt_Obj;
    public GameObject PostInfCereArt_Obj;
    public GameObject BasilarArt_Obj;
    public GameObject AntInfCereArt_Obj;
    public GameObject PontineArt_Obj;
    public GameObject SupCereArt_Obj;
    public GameObject FacialArt_Obj;
    public GameObject IntCarotidArt_Obj;
    public GameObject LabArt_Obj;
    public GameObject MaxArt_Obj;
    public GameObject MidCerebralArt_Obj;
    public GameObject OccipitalArt_Obj;
    public GameObject OpthalmicArt_Obj;
    public GameObject PostCerebralArt_Obj;
    public GameObject AntCerebralArt_Obj;
    public GameObject AscPharArt_Obj;
    public GameObject PostAuricularArt_Obj;
    public GameObject PostCommArt_Obj;
    public GameObject SupTempArt_Obj;
    public GameObject ExtCarotidArt_Obj;
    public GameObject CommCarotidArt_Obj;
    public GameObject SupThyroidArt_Obj;
    public GameObject LingualArt_Obj;
    public GameObject antCommArt_Obj;
    public GameObject IntJugular_Obj;

    public GameObject SupSagSin_Obj;
    public GameObject InfSagSin_Obj;
    public GameObject CavernousSin_Obj;
    public GameObject SupPetrosalSin_Obj;
    public GameObject SphernoperietalSin_Obj;
    public GameObject InfPetrosalSin_Obj;
    public GameObject OccipitalSin_Obj;
    public GameObject TransSin_Obj;
    public GameObject SigmoidSin_Obj;
    public GameObject StraightSin_Obj;

    public GameObject CNI_Obj;
    public GameObject CNII_Obj;
    public GameObject CNIII_Obj;
    public GameObject CNIV_Obj;
    public GameObject CNV_Obj;
    public GameObject CNVI_Obj;
    public GameObject CNVII_Obj;
    public GameObject CNVIII_Obj;
    public GameObject CNIX_Obj;
    public GameObject CNX_Obj;
    public GameObject CNXI_Obj;
    public GameObject CNXII_Obj;

    public GameObject whiteMatter_Obj;
    public GameObject corpCall_Obj;
    public GameObject corpCallAx_Obj;
    public GameObject intCap_Obj;
    public GameObject intCapAx_Obj;
    public GameObject fornix_Obj;
    public GameObject caudateNuc_Obj;
    public GameObject caudateNucCor_Obj;
    public GameObject gloPall_Obj;
    public GameObject gloPallAx_Obj;
    public GameObject putamen_Obj;
    public GameObject putamenAx_Obj;
    public GameObject thalamus_Obj;
    public GameObject thalamusAx_Obj;
    public GameObject hypothalamus_Obj;
    public GameObject hypothalamusCor_Obj;
    public GameObject hippocampus_Obj;
    public GameObject hippocampusCor_Obj;

    IList<GameObject>[] allButtons = new IList<GameObject>[14];

    enum buttonToggle
    {
        ventSys, cere, brainStem, spinalCord, vas, sinuses, nerves, subCortSturct, cortLobe,
        frontalLobe, parietalLobe, temporalLobe, cortGyri, cortSulci
    };

    void Start()
    {
        allButtons[(int)buttonToggle.ventSys] = new List<GameObject>(new GameObject[] { latVent_Obj, cerebralAque_Obj,
            thirdVent_Obj, fourthVent_Obj, latVentAx_Obj });
        allButtons[(int)buttonToggle.cere] = new List<GameObject>(new GameObject[] { cereCortex_Obj, peduncles_Obj,
            vermis_Obj, cereWhiteMatter_Obj, cerebellum_Obj });
        allButtons[(int)buttonToggle.brainStem] = new List<GameObject>(new GameObject[] { brainstem_Obj });
        allButtons[(int)buttonToggle.spinalCord] = new List<GameObject>(new GameObject[] { spinalCord_Obj });
        allButtons[(int)buttonToggle.vas] = new List<GameObject>(new GameObject[] { ASArt_Obj, VertArt_Obj,
            PostInfCereArt_Obj, BasilarArt_Obj, AntInfCereArt_Obj, PontineArt_Obj, SupCereArt_Obj, FacialArt_Obj,
            IntCarotidArt_Obj, LabArt_Obj, MidCerebralArt_Obj, OpthalmicArt_Obj, MaxArt_Obj,OccipitalArt_Obj,
            PostCerebralArt_Obj, AntCerebralArt_Obj, PostCommArt_Obj, ExtCarotidArt_Obj, CommCarotidArt_Obj, AscPharArt_Obj, PostAuricularArt_Obj,
            ExtCarotidArt_Obj, SupThyroidArt_Obj, LingualArt_Obj, IntJugular_Obj, SupTempArt_Obj, antCommArt_Obj});
        allButtons[(int)buttonToggle.sinuses] = new List<GameObject>(new GameObject[] { SupSagSin_Obj, InfSagSin_Obj,
            CavernousSin_Obj, SupPetrosalSin_Obj, SphernoperietalSin_Obj, InfPetrosalSin_Obj, OccipitalSin_Obj,
            TransSin_Obj, SigmoidSin_Obj, StraightSin_Obj});
        allButtons[(int)buttonToggle.nerves] = new List<GameObject>(new GameObject[] {  CNI_Obj, CNII_Obj, CNIII_Obj,
              CNIV_Obj, CNV_Obj, CNVI_Obj, CNVII_Obj, CNVIII_Obj, CNIX_Obj, CNX_Obj, CNXI_Obj, CNXII_Obj });
        allButtons[(int)buttonToggle.subCortSturct] = new List<GameObject>(new GameObject[] {whiteMatter_Obj, corpCall_Obj,
            intCap_Obj, fornix_Obj, caudateNuc_Obj, gloPall_Obj, putamen_Obj, thalamus_Obj, thalamusAx_Obj,
            hypothalamus_Obj, hippocampus_Obj, corpCallAx_Obj, intCapAx_Obj, caudateNucCor_Obj, gloPallAx_Obj, putamenAx_Obj,
            hippocampusCor_Obj, hypothalamusCor_Obj});
        allButtons[(int)buttonToggle.cortLobe] = new List<GameObject>(new GameObject[] { frontalLobe_Obj,
            parietalLobe_Obj, temporalLobe_Obj, occipitalLobe_Obj });
        allButtons[(int)buttonToggle.frontalLobe] = new List<GameObject>(new GameObject[] { brocas_Obj,
            frontalEyeField_Obj, SMA_Obj, preMotor_Obj });
        allButtons[(int)buttonToggle.parietalLobe] = new List<GameObject>(new GameObject[] { postCentGyrus_Obj });
        allButtons[(int)buttonToggle.temporalLobe] = new List<GameObject>(new GameObject[] { wernickes_Obj });
        allButtons[(int)buttonToggle.cortGyri] = new List<GameObject>(new GameObject[] { preCentGyrus_Obj,
            postCentGyrus_Obj, cingulateGyrus_Obj });
        allButtons[(int)buttonToggle.cortSulci] = new List<GameObject>(new GameObject[] { centSulcus_Obj, latSulcus_Obj,
            pariSulcus_Obj });
    }

    public void frontalLobeShowObj()
    {
        ImageTogg();
        frontalLobe_Obj.SetActive(true);
    }

    public void parietalLobeShowObj()
    {
        ImageTogg();
        parietalLobe_Obj.SetActive(true);
    }

    public void temporalLobeShowObj()
    {
        ImageTogg();
        temporalLobe_Obj.SetActive(true);
    }

    public void brocasShowObj()
    {
        ImageTogg();
        brocas_Obj.SetActive(true);
    }

    public void frontalEyeFieldShowObj()
    {
        ImageTogg();
        frontalEyeField_Obj.SetActive(true);
    }

    public void preMotorShowObj()
    {
        ImageTogg();
        preMotor_Obj.SetActive(true);
    }

    public void SMAShowObj()
    {
        ImageTogg();
        SMA_Obj.SetActive(true);
    }

    public void wernickesShowObj()
    {
        ImageTogg();
        wernickes_Obj.SetActive(true);
    }

    public void occipitalLobeShowObj()
    {
        ImageTogg();
        occipitalLobe_Obj.SetActive(true);
    }

    public void preCentGyrusShowObj()
    {
        ImageTogg();
        preCentGyrus_Obj.SetActive(true);
    }

    public void postCentGyrusShowObj()
    {
        ImageTogg();
        postCentGyrus_Obj.SetActive(true);
    }

    public void cingulateGyrusShowObj()
    {
        ImageTogg();
        cingulateGyrus_Obj.SetActive(true);
    }

    public void centSulcusShowObj()
    {
        ImageTogg();
        centSulcus_Obj.SetActive(true);
    }

    public void latSulcusShowObj()
    {
        ImageTogg();
        latSulcus_Obj.SetActive(true);
    }

    public void periSulcusShowObj()
    {
        ImageTogg();
        pariSulcus_Obj.SetActive(true);
    }

    public void latVentShowObj()
    {
        ImageTogg();
        latVent_Obj.SetActive(true);
    }

    public void cerebralAqueShowObj()
    {
        ImageTogg();
        cerebralAque_Obj.SetActive(true);
    }

    public void thirdVentShowObj()
    {
        ImageTogg();
        thirdVent_Obj.SetActive(true);
    }

    public void fourthVentShowObj()
    {
        ImageTogg();
        fourthVent_Obj.SetActive(true);
    }

    public void cereCortexShowObj()
    {
        ImageTogg();
        cereCortex_Obj.SetActive(true);
        cerebellum_Obj.SetActive(true);
    }

    public void pedunclesShowObj()
    {
        ImageTogg();
        peduncles_Obj.SetActive(true);
        cerebellum_Obj.SetActive(true);
    }

    public void vermisShowObj()
    {
        ImageTogg();
        vermis_Obj.SetActive(true);
        cerebellum_Obj.SetActive(true);
    }

    public void cereWhiteMatterShowObj()
    {
        ImageTogg();
        cereWhiteMatter_Obj.SetActive(true);
        cerebellum_Obj.SetActive(true);
    }

    public void brainstemShowObj()
    {
        ImageTogg();
        brainstem_Obj.SetActive(true);
    }

    public void spinalCordShowObj()
    {
        ImageTogg();
        spinalCord_Obj.SetActive(true);
    }

    public void ASArtShowObj()
    {
        ImageTogg();
        ASArt_Obj.SetActive(true);
    }

    public void VertArtShowObj()
    {
        ImageTogg();
        VertArt_Obj.SetActive(true);
    }

    public void PostInfCereArtShowObj()
    {
        ImageTogg();
        PostInfCereArt_Obj.SetActive(true);
    }

    public void BasilarArtShowObj()
    {
        ImageTogg();
        BasilarArt_Obj.SetActive(true);
    }

    public void AntInfCereArtShowObj()
    {
        ImageTogg();
        AntInfCereArt_Obj.SetActive(true);
    }

    public void PontineArtShowObj()
    {
        ImageTogg();
        PontineArt_Obj.SetActive(true);
    }

    public void SupCereArtShowObj()
    {
        ImageTogg();
        SupCereArt_Obj.SetActive(true);
    }

    public void FacialArtShowObj()
    {
        ImageTogg();
        FacialArt_Obj.SetActive(true);
    }

    public void IntCarotidArtShowObj()
    {
        ImageTogg();
        IntCarotidArt_Obj.SetActive(true);
    }

    public void LabArtShowObj()
    {
        ImageTogg();
        LabArt_Obj.SetActive(true);
    }

    public void MaxArtShowObj()
    {
        ImageTogg();
        MaxArt_Obj.SetActive(true);
    }

    public void MidCerebralArtShowObj()
    {
        ImageTogg();
        MidCerebralArt_Obj.SetActive(true);
    }

    public void OccipitalArtShowObj()
    {
        ImageTogg();
        OccipitalArt_Obj.SetActive(true);
    }

    public void OpthalmicArtShowObj()
    {
        ImageTogg();
        OpthalmicArt_Obj.SetActive(true);
    }

    public void PostCerebralArtShowObj()
    {
        ImageTogg();
        PostCerebralArt_Obj.SetActive(true);
    }

    public void AntCerebralArtShowObj()
    {
        ImageTogg();
        AntCerebralArt_Obj.SetActive(true);
    }

    public void AscPharArtShowObj()
    {
        ImageTogg();
        AscPharArt_Obj.SetActive(true);
    }

    public void PostAuricularArtShowObj()
    {
        ImageTogg();
        PostAuricularArt_Obj.SetActive(true);
    }

    public void PostCommArtArtShowObj()
    {
        ImageTogg();
        PostCommArt_Obj.SetActive(true);
    }

    public void SupTempArtShowObj()
    {
        ImageTogg();
        SupTempArt_Obj.SetActive(true);
    }

    public void AntCommArtShowObj()
    {
        ImageTogg();
        antCommArt_Obj.SetActive(true);
    }

    public void ExtCarotidArtShowObj()
    {
        ImageTogg();
        ExtCarotidArt_Obj.SetActive(true);
    }

    public void CommCarotidArtShowObj()
    {
        ImageTogg();
        CommCarotidArt_Obj.SetActive(true);
    }

    public void SupThyroidArtShowObj()
    {
        ImageTogg();
        SupThyroidArt_Obj.SetActive(true);
    }

    public void LingualArtShowObj()
    {
        ImageTogg();
        LingualArt_Obj.SetActive(true);
    }

    public void IntJugularShowObj()
    {
        ImageTogg();
        IntJugular_Obj.SetActive(true);
    }

    public void SupSagSinShowObj()
    {
        ImageTogg();
        SupSagSin_Obj.SetActive(true);
    }

    public void InfSagSinShowObj()
    {
        ImageTogg();
        InfSagSin_Obj.SetActive(true);
    }

    public void CavernousSinShowObj()
    {
        ImageTogg();
        CavernousSin_Obj.SetActive(true);
    }

    public void SupPetrosalSinShowObj()
    {
        ImageTogg();
        SupPetrosalSin_Obj.SetActive(true);
    }

    public void SphernoperietalSinShowObj()
    {
        ImageTogg();
        SphernoperietalSin_Obj.SetActive(true);
    }

    public void InfPetrosalSinShowObj()
    {
        ImageTogg();
        InfPetrosalSin_Obj.SetActive(true);
    }

    public void OccipitalSinShowObj()
    {
        ImageTogg();
        OccipitalSin_Obj.SetActive(true);
    }

    public void TransSinShowObj()
    {
        ImageTogg();
        TransSin_Obj.SetActive(true);
    }

    public void SigmoidSinShowObj()
    {
        ImageTogg();
        SigmoidSin_Obj.SetActive(true);
    }

    public void StraightSinShowObj()
    {
        ImageTogg();
        StraightSin_Obj.SetActive(true);
    }

    public void CNIShowObj()
    {
        ImageTogg();
        CNI_Obj.SetActive(true);
    }

    public void CNIIShowObj()
    {
        ImageTogg();
        CNII_Obj.SetActive(true);
    }

    public void CNIIIShowObj()
    {
        ImageTogg();
        CNIII_Obj.SetActive(true);
    }

    public void CNIVShowObj()
    {
        ImageTogg();
        CNIV_Obj.SetActive(true);
    }

    public void CNVShowObj()
    {
        ImageTogg();
        CNV_Obj.SetActive(true);
    }

    public void CNVIShowObj()
    {
        ImageTogg();
        CNVI_Obj.SetActive(true);
    }

    public void CNVIIShowObj()
    {
        ImageTogg();
        CNVII_Obj.SetActive(true);
    }

    public void CNVIIIShowObj()
    {
        ImageTogg();
        CNVIII_Obj.SetActive(true);
    }

    public void CNIXShowObj()
    {
        ImageTogg();
        CNIX_Obj.SetActive(true);
    }

    public void CNXShowObj()
    {
        ImageTogg();
        CNX_Obj.SetActive(true);
    }

    public void CNXIShowObj()
    {
        ImageTogg();
        CNXI_Obj.SetActive(true);
    }

    public void CNXIIShowObj()
    {
        ImageTogg();
        CNXII_Obj.SetActive(true);
    }

    public void whiteMatterShowObj()
    {
        ImageTogg();
        whiteMatter_Obj.SetActive(true);
    }

    public void corpCallShowObj()
    {
        ImageTogg();
        corpCall_Obj.SetActive(true);
    }

    public void intCapShowObj()
    {
        ImageTogg();
        intCap_Obj.SetActive(true);
    }

    public void fornixShowObj()
    {
        ImageTogg();
        fornix_Obj.SetActive(true);
    }

    public void caudateNucShowObj()
    {
        ImageTogg();
        caudateNuc_Obj.SetActive(true);
    }

    public void gloPallShowObj()
    {
        ImageTogg();
        gloPall_Obj.SetActive(true);
    }

    public void putamenShowObj()
    {
        ImageTogg();
        putamen_Obj.SetActive(true);
    }

    public void thalamusShowObj()
    {
        ImageTogg();
        thalamus_Obj.SetActive(true);
    }

    public void hypothalamusShowObj()
    {
        ImageTogg();
        hypothalamus_Obj.SetActive(true);
    }

    public void hippocampusShowObj()
    {
        ImageTogg();
        hippocampus_Obj.SetActive(true);
    }

    void ImageTogg()
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
