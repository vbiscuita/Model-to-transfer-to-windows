using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class DisplayObjVisibility3D : MonoBehaviour
{
    public Material highLightColor;
    public Material highLightColor2;

    public Toggle skullToggButt;
    public Toggle cortexLToggButt;
    public Toggle cortexRToggButt;
    public Toggle whiteMatterToggButt;
    public Toggle cereToggButt;
    public Toggle basalGangToggButt;
    public Toggle vasToggButt;
    public Toggle sinusToggButt;
    public Toggle nerveToggButt;

    public GameObject skull;

    public GameObject frontalLobe_L;
    public GameObject frontalLobe_R;
    public GameObject parietalLobe_L;
    public GameObject parietalLobe_R;
    public GameObject temporalLobe_L;
    public GameObject temporalLobe_R;
    public GameObject occipitalLobe_L;
    public GameObject occipitalLobe_R;

    public GameObject brocas;
    public GameObject frontalEyeField_L;
    public GameObject frontalEyeField_R;
    public GameObject premoterCortex_L;
    public GameObject premoterCortex_R;
    public GameObject SMA_L;
    public GameObject SMA_R;

    public GameObject wernickes;

    public GameObject preCentGyrus_L;
    public GameObject preCentGyrus_R;
    public GameObject postCentGyrus_L;
    public GameObject postCentGyrus_R;
    public GameObject cingulateGyrus_L;
    public GameObject cingulateGyrus_R;

    public GameObject centSulcus_L;
    public GameObject centSulcus_R;
    public GameObject latSulcus_L;
    public GameObject latSulcus_R;
    public GameObject pariSulcus_L;
    public GameObject pariSulcus_R;

    public GameObject latVent;
    public GameObject cerebralAque;
    public GameObject thirdVent_Part1;
    public GameObject thirdVent_Part2;
    public GameObject fourthVent;
    public GameObject centCanal;

    public GameObject cereCortex_L;
    public GameObject cereCortex_R;
    public GameObject peduncles;
    public GameObject vermis;
    public GameObject cereWhiteMatterPart1;
    public GameObject cereWhiteMatterPart2;

    public GameObject brainstem;
    public GameObject spinalCord;

    public GameObject ASArt;
    public GameObject PSArt_L;
    public GameObject PSArt_R;
    public GameObject VertArt_L;
    public GameObject VertArt_R;
    public GameObject PostInfCereArt_L;
    public GameObject PostInfCereArt_R;
    public GameObject BasilarArt;
    public GameObject AntInfCereArt_L;
    public GameObject AntInfCereArt_R;
    public GameObject PontineArt_L;
    public GameObject PontineArt_R;
    public GameObject SupCereArt_L;
    public GameObject SupCereArt_R;
    public GameObject FacialArt_L;
    public GameObject FacialArt_R;
    public GameObject IntCarotidArt_L;
    public GameObject IntCarotidArt_R;
    public GameObject LabArt_L;
    public GameObject LabArt_R;
    public GameObject MaxArt_L_Part1;
    public GameObject MaxArt_L_Part2;
    public GameObject MaxArt_R_Part1;
    public GameObject MaxArt_R_Part2;
    public GameObject MidCerebralArt_L;
    public GameObject MidCerebralArt_R;
    public GameObject OccipitalArt_L;
    public GameObject OccipitalArt_R;
    public GameObject OpthalmicArt_L;
    public GameObject OpthalmicArt_R;
    public GameObject PostCerebralArt_L;
    public GameObject PostCerebralArt_R;
    public GameObject AntCerebralArt_L;
    public GameObject AntCerebralArt_R;
    public GameObject AscPharArt_L;
    public GameObject AscPharArt_R;
    public GameObject PostAuricularArt_L;
    public GameObject PostAuricularArt_R;
    public GameObject PostCommArt_L;
    public GameObject PostCommArt_R;
    public GameObject MidMeningealArt_L;
    public GameObject MidMeningealArt_R;
    public GameObject PostMeningealBranch;
    public GameObject SupTempArt_L;
    public GameObject SupTempArt_R;
    public GameObject ExtCarotidArt_L;
    public GameObject ExtCarotidArt_R;
    public GameObject SupThyroidArt_L;
    public GameObject SupThyroidArt_R;
    public GameObject LingualArt_R;
    public GameObject LingualArt_L;
    public GameObject IntJugular_L;
    public GameObject IntJugular_R;
    public GameObject supOphthalmic_L;
    public GameObject supOphthalmic_R;
    public GameObject antCommArt;

    public GameObject SupSagSin;
    public GameObject InfSagSin;
    public GameObject CavernousSin_L;
    public GameObject CavernousSin_R;
    public GameObject SupPetrosalSin_L;
    public GameObject SupPetrosalSin_R;
    public GameObject SphenoparietalSin_L;
    public GameObject SphenoparietalSin_R;
    public GameObject InfPetrosalSin_L;
    public GameObject InfPetrosalSin_R;
    public GameObject OccipitalSin_L;
    public GameObject OccipitalSin_R;
    public GameObject TransSin_L;
    public GameObject TransSin_R;
    public GameObject SigmoidSin_L;
    public GameObject SigmoidSin_R;
    public GameObject StraightSin;
    public GameObject BasilarSin;

    public GameObject CNI;
    public GameObject CNII;
    public GameObject CNIII_L;
    public GameObject CNIII_R;
    public GameObject CNIV_L;
    public GameObject CNIV_R;
    public GameObject CNV_L;
    public GameObject CNV_R;
    public GameObject CNVI_L;
    public GameObject CNVI_R;
    public GameObject CNVII_L;
    public GameObject CNVII_R;
    public GameObject CNVIII_L;
    public GameObject CNVIII_R;
    public GameObject CNIX_L;
    public GameObject CNIX_R;
    public GameObject CNX_L;
    public GameObject CNX_R;
    public GameObject CNXI_L;
    public GameObject CNXI_R;
    public GameObject CNXII_L;
    public GameObject CNXII_R;

    public GameObject whiteMatter;
    public GameObject corpCall;
    public GameObject intCap;
    public GameObject fornix;
    public GameObject caudateNuc1;
    public GameObject caudateNuc2;
    public GameObject gloPall;
    public GameObject putamen;
    public GameObject thalamus;
    public GameObject hypothalamus;
    public GameObject hippocampus;

    IList<GameObject>[] objectVisibility = new IList<GameObject>[12]; //list of arrays containing objects
    Toggle[] ToggCheckBox = new Toggle[9]; //for al check boxes, see togglebuttons for order and names. The first 9 are the toggles in the 
                                            //scene, the other 3 are objects that need to be turned on or off with other structures to show
                                            //structural information correctly
    bool[] toggles = new bool[] { true, true, true, true, true, true, true, true, true, true, true, true };
    enum toggleButtons { skullTogg, cortexLTogg, cortexRTogg, whiteMatterTogg, cereTogg, basalGangTogg, vasTogg,
        sinusTogg, nerveTogg, jugTogg, thalamusTogg, cereCortex };

    //All materials that are used in this model by name
    enum structMenuByMat { whiteMatter, whiteMatter2, thirdVent, corpCall, thalamus, intcap, hypothalamus, hippocampus, glopall,
        fornix, caudate, latvent, mat030, mat054, mat055, mat056, mat057, mat060, mat061, mat062, mat063, mat064,
        mat065, mat066, mat067, mat068, mat069, mat070, mat072, mat073, mat074, mat075, mat076, mat078, mat079, mat080, mat081,
        mat083, mat084, mat086, mat087, mat088, mat089, mat090, mat091, mat092, mat093, mat094, mat095, mat097 };
    Material[] allMat = new Material[50];
    IList<GameObject>[] allObjects = new IList<GameObject>[50];

    void Start()
    {
        //all objects are sorted into list. This is used when toggles are turned on and off
        objectVisibility[(int)toggleButtons.skullTogg] = new List<GameObject>(new GameObject[] { skull });
        objectVisibility[(int)toggleButtons.cortexLTogg] = new List<GameObject>(new GameObject[] { frontalLobe_L, brocas,
            wernickes, frontalEyeField_L, premoterCortex_L, preCentGyrus_L, postCentGyrus_L, centSulcus_L, latSulcus_L,
            pariSulcus_L, parietalLobe_L, temporalLobe_L, occipitalLobe_L, SMA_L, cingulateGyrus_L});
        objectVisibility[(int)toggleButtons.cortexRTogg] = new List<GameObject>(new GameObject[] { frontalLobe_R,
            frontalEyeField_R, premoterCortex_R, preCentGyrus_R, postCentGyrus_R, centSulcus_R, latSulcus_R, pariSulcus_R,
            parietalLobe_R, temporalLobe_R, occipitalLobe_R, SMA_R, cingulateGyrus_R});
        objectVisibility[(int)toggleButtons.whiteMatterTogg] = new List<GameObject>(new GameObject[] { whiteMatter });
        objectVisibility[(int)toggleButtons.cereTogg] = new List<GameObject>(new GameObject[] { cereCortex_L, cereCortex_R,
            peduncles, vermis, cereWhiteMatterPart1, cereWhiteMatterPart2 });
        objectVisibility[(int)toggleButtons.basalGangTogg] = new List<GameObject>(new GameObject[] { caudateNuc1, caudateNuc2,
            putamen, gloPall, intCap});
        objectVisibility[(int)toggleButtons.vasTogg] = new List<GameObject>(new GameObject[] { ASArt, BasilarArt, LingualArt_R, LingualArt_L,
            PostMeningealBranch, AntCerebralArt_L, AntCerebralArt_R, AntInfCereArt_L, AntInfCereArt_R, AscPharArt_L, AscPharArt_R,
            ExtCarotidArt_L, ExtCarotidArt_R, FacialArt_L, FacialArt_R, IntCarotidArt_L, IntCarotidArt_R, LabArt_L, LabArt_R,
            MaxArt_L_Part1, MaxArt_L_Part2, MaxArt_R_Part1, MaxArt_R_Part2, MidCerebralArt_L, MidCerebralArt_R, OccipitalArt_L,
            OccipitalArt_R, OpthalmicArt_L, OpthalmicArt_R, PostCerebralArt_L, PostCerebralArt_R, PostInfCereArt_L, PostInfCereArt_R,
            PontineArt_L, PontineArt_R, PostAuricularArt_L, PostAuricularArt_R, PostCommArt_L, PostCommArt_R, 
            SupTempArt_L, SupTempArt_R, SupCereArt_L, SupCereArt_R, SupThyroidArt_L, SupThyroidArt_R, VertArt_L, VertArt_R,
            IntJugular_L, IntJugular_R, MidMeningealArt_L, MidMeningealArt_R, supOphthalmic_L, supOphthalmic_R, antCommArt,
            PSArt_L, PSArt_R});
        objectVisibility[(int)toggleButtons.sinusTogg] = new List<GameObject>(new GameObject[] { InfSagSin, CavernousSin_L,
            CavernousSin_R, InfPetrosalSin_L, InfPetrosalSin_R, OccipitalSin_L, OccipitalSin_R, SphenoparietalSin_L, SphenoparietalSin_R,
            SupPetrosalSin_L, SupPetrosalSin_R, TransSin_L, TransSin_R, SigmoidSin_L, SigmoidSin_R, SupSagSin, StraightSin, BasilarSin});
        objectVisibility[(int)toggleButtons.nerveTogg] = new List<GameObject>(new GameObject[] { CNI, CNII, CNIII_L, CNIII_R, CNIV_L,
            CNIV_R, CNV_L, CNV_R, CNVI_L, CNVI_R, CNVII_L, CNVII_R, CNVIII_L, CNVIII_R, CNIX_L, CNIX_R, CNX_L, CNX_R, CNXI_L, CNXI_R,
            CNXII_L, CNXII_R});
        objectVisibility[(int)toggleButtons.jugTogg] = new List<GameObject>(new GameObject[] { IntJugular_L, IntJugular_R });
        objectVisibility[(int)toggleButtons.thalamusTogg] = new List<GameObject>(new GameObject[] { thalamus });
        objectVisibility[(int)toggleButtons.cereCortex] = new List<GameObject>(new GameObject[] { cereCortex_L });

        //object visibility in above list is done using this toggles and bools
        ToggCheckBox[(int)toggleButtons.skullTogg] = skullToggButt;
        ToggCheckBox[(int)toggleButtons.cortexLTogg] = cortexLToggButt;
        ToggCheckBox[(int)toggleButtons.cortexRTogg] = cortexRToggButt;
        ToggCheckBox[(int)toggleButtons.whiteMatterTogg] = whiteMatterToggButt;
        ToggCheckBox[(int)toggleButtons.cereTogg] = cereToggButt;
        ToggCheckBox[(int)toggleButtons.basalGangTogg] = basalGangToggButt;
        ToggCheckBox[(int)toggleButtons.vasTogg] = vasToggButt;
        ToggCheckBox[(int)toggleButtons.sinusTogg] = sinusToggButt;
        ToggCheckBox[(int)toggleButtons.nerveTogg] = nerveToggButt;

        //each material is added to list from one structure so that materials do not need to be added to scene
        //like the GameObjects
        allMat[(int)structMenuByMat.whiteMatter] = frontalLobe_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.whiteMatter2] = brainstem.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.thirdVent] = whiteMatter.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.corpCall] = corpCall.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.thalamus] = thalamus.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.intcap] = intCap.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.hypothalamus] = hypothalamus.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.hippocampus] = hippocampus.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.glopall] = gloPall.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.fornix] = fornix.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.caudate] = caudateNuc1.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.latvent] = latVent.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat030] = putamen.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat054] = CNIII_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat055] = CNIX_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat056] = CNXI_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat057] = BasilarArt.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat060] = PostInfCereArt_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat061] = OpthalmicArt_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat062] = PostCommArt_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat063] = AntInfCereArt_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat064] = PSArt_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat065] = CNX_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat066] = CNVII_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat067] = CNII.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat068] = AscPharArt_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat069] = OccipitalSin_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat070] = InfSagSin.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat072] = CNVI_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat073] = VertArt_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat074] = LabArt_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat075] = CNI.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat076] = MidMeningealArt_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat078] = PontineArt_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat079] = CNIV_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat080] = antCommArt.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat081] = supOphthalmic_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat083] = InfPetrosalSin_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat084] = CavernousSin_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat086] = CNXII_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat087] = SupCereArt_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat088] = SupSagSin.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat089] = PostCerebralArt_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat090] = BasilarSin.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat091] = CNVIII_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat092] = CNV_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat093] = IntCarotidArt_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat094] = SphenoparietalSin_L.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat095] = ASArt.GetComponent<Renderer>().material;
        allMat[(int)structMenuByMat.mat097] = SigmoidSin_L.GetComponent<Renderer>().material;

        //All objects are sorted by the material used 
        allObjects[(int)structMenuByMat.whiteMatter] = new List<GameObject>(new GameObject[] { brocas, cingulateGyrus_L,
            cingulateGyrus_R, frontalEyeField_L, frontalEyeField_R, frontalLobe_L, frontalLobe_R,
            occipitalLobe_L, occipitalLobe_R, parietalLobe_L, parietalLobe_R, postCentGyrus_L, postCentGyrus_R, preCentGyrus_L,
            preCentGyrus_R, premoterCortex_L, premoterCortex_R, SMA_L, SMA_R, temporalLobe_L, temporalLobe_R, wernickes,
            centSulcus_L, centSulcus_R, latSulcus_L, latSulcus_R, pariSulcus_L, pariSulcus_R, cereCortex_L, cereCortex_R,
            peduncles, vermis, cereWhiteMatterPart1, cereWhiteMatterPart2, whiteMatter});
        allObjects[(int)structMenuByMat.whiteMatter2] = new List<GameObject>(new GameObject[] { brainstem, spinalCord });
        allObjects[(int)structMenuByMat.thirdVent] = new List<GameObject>(new GameObject[] { fourthVent, centCanal, cerebralAque,
            thirdVent_Part1, thirdVent_Part2});
        allObjects[(int)structMenuByMat.corpCall] = new List<GameObject>(new GameObject[] { corpCall });
        allObjects[(int)structMenuByMat.thalamus] = new List<GameObject>(new GameObject[] { thalamus });
        allObjects[(int)structMenuByMat.intcap] = new List<GameObject>(new GameObject[] { intCap });
        allObjects[(int)structMenuByMat.hypothalamus] = new List<GameObject>(new GameObject[] { hypothalamus });
        allObjects[(int)structMenuByMat.hippocampus] = new List<GameObject>(new GameObject[] { hippocampus });
        allObjects[(int)structMenuByMat.glopall] = new List<GameObject>(new GameObject[] { gloPall });
        allObjects[(int)structMenuByMat.fornix] = new List<GameObject>(new GameObject[] { fornix });
        allObjects[(int)structMenuByMat.caudate] = new List<GameObject>(new GameObject[] { caudateNuc1, caudateNuc2 });
        allObjects[(int)structMenuByMat.latvent] = new List<GameObject>(new GameObject[] { latVent });
        allObjects[(int)structMenuByMat.mat030] = new List<GameObject>(new GameObject[] { putamen });
        allObjects[(int)structMenuByMat.mat054] = new List<GameObject>(new GameObject[] { CNIII_L, CNIII_R });
        allObjects[(int)structMenuByMat.mat055] = new List<GameObject>(new GameObject[] { CNIX_L, CNIX_R });
        allObjects[(int)structMenuByMat.mat056] = new List<GameObject>(new GameObject[] { CNXI_L, CNXI_R });
        allObjects[(int)structMenuByMat.mat057] = new List<GameObject>(new GameObject[] { BasilarArt });
        allObjects[(int)structMenuByMat.mat060] = new List<GameObject>(new GameObject[] { PostInfCereArt_L, PostInfCereArt_R });
        allObjects[(int)structMenuByMat.mat061] = new List<GameObject>(new GameObject[] { OpthalmicArt_L, OpthalmicArt_R });
        allObjects[(int)structMenuByMat.mat062] = new List<GameObject>(new GameObject[] { PostCommArt_L, PostCommArt_R });
        allObjects[(int)structMenuByMat.mat063] = new List<GameObject>(new GameObject[] { AntInfCereArt_L, AntInfCereArt_R });
        allObjects[(int)structMenuByMat.mat064] = new List<GameObject>(new GameObject[] { PSArt_L, PSArt_R});
        allObjects[(int)structMenuByMat.mat065] = new List<GameObject>(new GameObject[] { CNX_L, CNX_R});
        allObjects[(int)structMenuByMat.mat066] = new List<GameObject>(new GameObject[] { CNVII_L, CNVII_R });
        allObjects[(int)structMenuByMat.mat067] = new List<GameObject>(new GameObject[] { CNII });
        allObjects[(int)structMenuByMat.mat068] = new List<GameObject>(new GameObject[] { AscPharArt_L, AscPharArt_R, ExtCarotidArt_L,
            ExtCarotidArt_R, FacialArt_L, FacialArt_R, MaxArt_L_Part1, MaxArt_L_Part2, MaxArt_R_Part1, MaxArt_R_Part2,
            OccipitalArt_L, OccipitalArt_R, PostAuricularArt_L, PostAuricularArt_R, SupTempArt_L, SupTempArt_R, SupThyroidArt_L,
            SupThyroidArt_R, LingualArt_R, LingualArt_L});
        allObjects[(int)structMenuByMat.mat069] = new List<GameObject>(new GameObject[] { OccipitalSin_L, OccipitalSin_R });
        allObjects[(int)structMenuByMat.mat070] = new List<GameObject>(new GameObject[] { InfSagSin, StraightSin });
        allObjects[(int)structMenuByMat.mat072] = new List<GameObject>(new GameObject[] { CNVI_L, CNVI_R});
        allObjects[(int)structMenuByMat.mat073] = new List<GameObject>(new GameObject[] { VertArt_L, VertArt_R });
        allObjects[(int)structMenuByMat.mat074] = new List<GameObject>(new GameObject[] { LabArt_L, LabArt_R });
        allObjects[(int)structMenuByMat.mat075] = new List<GameObject>(new GameObject[] { CNI });
        allObjects[(int)structMenuByMat.mat076] = new List<GameObject>(new GameObject[] { MidMeningealArt_L, MidMeningealArt_R });
        allObjects[(int)structMenuByMat.mat078] = new List<GameObject>(new GameObject[] { PontineArt_L, PontineArt_R });
        allObjects[(int)structMenuByMat.mat079] = new List<GameObject>(new GameObject[] { CNIV_L, CNIV_R });
        allObjects[(int)structMenuByMat.mat080] = new List<GameObject>(new GameObject[] { antCommArt, AntCerebralArt_L,
            AntCerebralArt_R });
        allObjects[(int)structMenuByMat.mat081] = new List<GameObject>(new GameObject[] { supOphthalmic_L, supOphthalmic_R });
        allObjects[(int)structMenuByMat.mat083] = new List<GameObject>(new GameObject[] { InfPetrosalSin_L, InfPetrosalSin_R });
        allObjects[(int)structMenuByMat.mat084] = new List<GameObject>(new GameObject[] { CavernousSin_L, CavernousSin_R, SupPetrosalSin_L, SupPetrosalSin_R });
        allObjects[(int)structMenuByMat.mat086] = new List<GameObject>(new GameObject[] { CNXII_L, CNXII_R });
        allObjects[(int)structMenuByMat.mat087] = new List<GameObject>(new GameObject[] { SupCereArt_L, SupCereArt_R });
        allObjects[(int)structMenuByMat.mat088] = new List<GameObject>(new GameObject[] { SupSagSin });
        allObjects[(int)structMenuByMat.mat089] = new List<GameObject>(new GameObject[] { PostCerebralArt_L, PostCerebralArt_R });
        allObjects[(int)structMenuByMat.mat090] = new List<GameObject>(new GameObject[] { BasilarSin });
        allObjects[(int)structMenuByMat.mat091] = new List<GameObject>(new GameObject[] { CNVIII_L, CNVIII_R});
        allObjects[(int)structMenuByMat.mat092] = new List<GameObject>(new GameObject[] { CNV_L, CNV_R });
        allObjects[(int)structMenuByMat.mat093] = new List<GameObject>(new GameObject[] { IntCarotidArt_L, IntCarotidArt_R,
            MidCerebralArt_L, MidCerebralArt_R});
        allObjects[(int)structMenuByMat.mat094] = new List<GameObject>(new GameObject[] { SphenoparietalSin_L, SphenoparietalSin_R });
        allObjects[(int)structMenuByMat.mat095] = new List<GameObject>(new GameObject[] { ASArt });
        allObjects[(int)structMenuByMat.mat097] = new List<GameObject>(new GameObject[] { SigmoidSin_L, SigmoidSin_R, TransSin_L, TransSin_R,
            IntJugular_L, IntJugular_R});
    }

    //When an object button is clicked, the associated object is highlighted in a green colour. All Functions with ShowObj in name
    //use this method. All the MattTogg function (see below for description) and then the appropriate objects are highlighted in
    //green. Then the appropriate toggles are called. Some functions with turn off whole sections that the user can then turn on,
    //others will call the toggles, like the jugular toggle, that the user cannot turn on/off. This is down to make it easier to 
    //see particular sturctures or to better see structural/functional relationships.

    public void frontalLobeShowObj()
    {
        MattTogg();
        frontalLobe_L.GetComponent<Renderer>().material = highLightColor2; 
        frontalLobe_R.GetComponent<Renderer>().material = highLightColor2;
        brocas.GetComponent<Renderer>().material = highLightColor2;
        frontalEyeField_L.GetComponent<Renderer>().material = highLightColor2;
        frontalEyeField_R.GetComponent<Renderer>().material = highLightColor2;
        premoterCortex_L.GetComponent<Renderer>().material = highLightColor2;
        premoterCortex_R.GetComponent<Renderer>().material = highLightColor2;
        SMA_L.GetComponent<Renderer>().material = highLightColor2;
        SMA_R.GetComponent<Renderer>().material = highLightColor2;
        preCentGyrus_L.GetComponent<Renderer>().material = highLightColor2;
        preCentGyrus_R.GetComponent<Renderer>().material = highLightColor2;
        everythingButSkull();
    }

    public void parietalLobeShowObj()
    {
        MattTogg();
        parietalLobe_L.GetComponent<Renderer>().material = highLightColor2;
        parietalLobe_R.GetComponent<Renderer>().material = highLightColor2;
        postCentGyrus_L.GetComponent<Renderer>().material = highLightColor2;
        postCentGyrus_R.GetComponent<Renderer>().material = highLightColor2;
        everythingButSkull();
    }

    public void temporalLobeShowObj()
    {
        MattTogg();
        temporalLobe_L.GetComponent<Renderer>().material = highLightColor2;
        temporalLobe_R.GetComponent<Renderer>().material = highLightColor2;
        wernickes.GetComponent<Renderer>().material = highLightColor2;
        everythingButSkull();
    }

    public void brocasShowObj()
    {
        MattTogg();
        brocas.GetComponent<Renderer>().material = highLightColor2;
        everythingButSkull();
    }

    public void frontalEyeFieldShowObj()
    {
        MattTogg();
        frontalEyeField_L.GetComponent<Renderer>().material = highLightColor2;
        frontalEyeField_R.GetComponent<Renderer>().material = highLightColor2;
        everythingButSkull();
    }

    public void preMotorCortexShowObj()
    {
        MattTogg();
        premoterCortex_L.GetComponent<Renderer>().material = highLightColor2;
        premoterCortex_R.GetComponent<Renderer>().material = highLightColor2;
        everythingButSkull();
    }

    public void SMAShowObj()
    {
        MattTogg();
        SMA_L.GetComponent<Renderer>().material = highLightColor2;
        SMA_R.GetComponent<Renderer>().material = highLightColor2;
        everythingButSkull();
    }

    public void wernickesShowObj()
    {
        MattTogg();
        wernickes.GetComponent<Renderer>().material = highLightColor2;
        everythingButSkull();
    }

    public void occipitalLobeShowObj()
    {
        MattTogg();
        occipitalLobe_L.GetComponent<Renderer>().material = highLightColor2;
        occipitalLobe_R.GetComponent<Renderer>().material = highLightColor2;
        everythingButSkull();
    }

    public void preCentGyrusShowObj()
    {
        MattTogg();
        preCentGyrus_L.GetComponent<Renderer>().material = highLightColor2;
        preCentGyrus_R.GetComponent<Renderer>().material = highLightColor2;
        everythingButSkull();
    }

    public void postCentGyrusShowObj()
    {
        MattTogg();
        postCentGyrus_L.GetComponent<Renderer>().material = highLightColor2;
        postCentGyrus_R.GetComponent<Renderer>().material = highLightColor2;
        everythingButSkull();
    }

    public void cingulateGyrusShowObj()
    {
        MattTogg();
        cingulateGyrus_L.GetComponent<Renderer>().material = highLightColor2;
        cingulateGyrus_R.GetComponent<Renderer>().material = highLightColor2;
        //This structure required turning off toggles that are not similar to any other function; therefore did not require a separate function
        bool[] newtoggle = new bool[] { false, false, true, false, true, false, false, true, false, false, true, true };
        updateToggles(newtoggle);
        toggles = newtoggle;
        nonCheckBoxTogg(); //Function used to reset object visibility based on toggles the user cannot turn on/off
    }

    public void centSulcusShowObj()
    {
        MattTogg();
        centSulcus_L.GetComponent<Renderer>().material = highLightColor2;
        centSulcus_R.GetComponent<Renderer>().material = highLightColor2;
        everythingButSkull();
    }

    public void latSulcusShowObj()
    {
        MattTogg();
        latSulcus_L.GetComponent<Renderer>().material = highLightColor2;
        latSulcus_R.GetComponent<Renderer>().material = highLightColor2;
        everythingButSkull();
    }

    public void periSulcusShowObj()
    {
        MattTogg();
        pariSulcus_L.GetComponent<Renderer>().material = highLightColor2;
        pariSulcus_R.GetComponent<Renderer>().material = highLightColor2;
        everythingButSkull();
    }

    public void latVentShowObj()
    {
        MattTogg();
        latVent.GetComponent<Renderer>().material = highLightColor2;
        //This structure required turning off toggles that are not similar to any other function; therefore did not require a separate function
        bool[] newtoggle = new bool[] { false, false, true, false, true, false, false, true, false, false, true, true };
        updateToggles(newtoggle);
        toggles = newtoggle;
        nonCheckBoxTogg(); //Function used to reset object visibility based on toggles the user cannot turn on/off
    }

    public void cerebralAqueShowObj()
    {
        MattTogg();
        cerebralAque.GetComponent<Renderer>().material = highLightColor2;
        bool[] newtoggle = new bool[] { false, false, true, false, false, false, false, true, false, false, false, false };
        updateToggles(newtoggle);
        toggles = newtoggle;
        nonCheckBoxTogg();
    }

    public void thirdVentShowObj()
    {
        MattTogg();
        thirdVent_Part1.GetComponent<Renderer>().material = highLightColor2;
        thirdVent_Part2.GetComponent<Renderer>().material = highLightColor2;
        bool[] newtoggle = new bool[] { false, false, true, false, false, false, false, true, false, false, false, false };
        updateToggles(newtoggle);
        toggles = newtoggle;
        nonCheckBoxTogg();
        thirdVent_Part1.SetActive(true);
        thirdVent_Part2.SetActive(true);
    }

    public void fourthVentShowObj()
    {
        MattTogg();
        fourthVent.GetComponent<Renderer>().material = highLightColor2;
        bool[] newtoggle = new bool[] { false, false, true, false, false, false, false, true, false, false, true, false };
        updateToggles(newtoggle);
        toggles = newtoggle;
        nonCheckBoxTogg();
    }

    public void cereCortexShowObj()
    {
        MattTogg();
        cereCortex_L.GetComponent<Renderer>().material = highLightColor2;
        cereCortex_R.GetComponent<Renderer>().material = highLightColor2;
        everythingButSkull();
    }

    public void pedunclesShowObj()
    {
        MattTogg();
        peduncles.GetComponent<Renderer>().material = highLightColor2;
        everythingButSkull();
    }

    public void vermisShowObj()
    {
        MattTogg();
        vermis.GetComponent<Renderer>().material = highLightColor2;
        everythingButSkull();
    }

    public void cereWhiteMatterShowObj()
    {
        MattTogg();
        cereWhiteMatterPart1.GetComponent<Renderer>().material = highLightColor2;
        cereWhiteMatterPart2.GetComponent<Renderer>().material = highLightColor2;
        bool[] newtoggle = new bool[] { false, true, true, true, true, true, true, true, true, true, true, false };
        updateToggles(newtoggle);
        toggles = newtoggle;
        nonCheckBoxTogg();
    }

    public void brainstemShowObj()
    {
        MattTogg();
        brainstem.GetComponent<Renderer>().material = highLightColor;
        everythingButSkull();
    }

    public void spinalCordShowObj()
    {
        MattTogg();
        spinalCord.GetComponent<Renderer>().material = highLightColor;
        everythingButSkull();
    }

    public void ASArtShowObj()
    {
        MattTogg();
        ASArt.GetComponent<Renderer>().material = highLightColor;
        skullNervesSinusOff();
    }

    public void VertArtShowObj()
    {
        MattTogg();
        VertArt_L.GetComponent<Renderer>().material = highLightColor;
        VertArt_R.GetComponent<Renderer>().material = highLightColor;
        skullNervesSinusOff();
    }

    public void PostInfCereArtShowObj()
    {
        MattTogg();
        PostInfCereArt_L.GetComponent<Renderer>().material = highLightColor;
        PostInfCereArt_R.GetComponent<Renderer>().material = highLightColor;
        skullNervesSinusOff();
    }

    public void BasilarArtShowObj()
    {
        MattTogg();
        BasilarArt.GetComponent<Renderer>().material = highLightColor;
        skullNervesSinusOff();
    }

    public void AntInfCereArtShowObj()
    {
        MattTogg();
        AntInfCereArt_L.GetComponent<Renderer>().material = highLightColor;
        AntInfCereArt_R.GetComponent<Renderer>().material = highLightColor;
        skullCortexWhiteNervesSinusOff();
    }

    public void PontineArtShowObj()
    {
        MattTogg();
        PontineArt_L.GetComponent<Renderer>().material = highLightColor;
        PontineArt_R.GetComponent<Renderer>().material = highLightColor;
        skullCortexWhiteNervesSinusOff();
    }

    public void SupCereArtShowObj()
    {
        MattTogg();
        SupCereArt_L.GetComponent<Renderer>().material = highLightColor;
        SupCereArt_R.GetComponent<Renderer>().material = highLightColor;
        skullCortexWhiteNervesSinusOff();
    }

    public void FacialArtShowObj()
    {
        MattTogg();
        FacialArt_L.GetComponent<Renderer>().material = highLightColor;
        FacialArt_R.GetComponent<Renderer>().material = highLightColor;
        skullNervesSinusOff();
    }

    public void IntCarotidArtShowObj()
    {
        MattTogg();
        IntCarotidArt_L.GetComponent<Renderer>().material = highLightColor;
        IntCarotidArt_R.GetComponent<Renderer>().material = highLightColor;
        skullNervesSinusOff();
    }

    public void LabArtShowObj()
    {
        MattTogg();
        LabArt_L.GetComponent<Renderer>().material = highLightColor;
        LabArt_R.GetComponent<Renderer>().material = highLightColor;
        skullCortexWhiteNervesSinusOff();
    }

    public void MaxArtShowObj()
    {
        MattTogg();
        MaxArt_L_Part1.GetComponent<Renderer>().material = highLightColor;
        MaxArt_L_Part2.GetComponent<Renderer>().material = highLightColor;
        MaxArt_R_Part1.GetComponent<Renderer>().material = highLightColor;
        MaxArt_R_Part2.GetComponent<Renderer>().material = highLightColor;
        skullNervesSinusOff();
    }

    public void MidCerebralArtShowObj()
    {
        MattTogg();
        MidCerebralArt_L.GetComponent<Renderer>().material = highLightColor;
        MidCerebralArt_R.GetComponent<Renderer>().material = highLightColor;
        skullCortexWhiteNervesSinusOff();
    }

    public void OccipitalArtShowObj()
    {
        MattTogg();
        OccipitalArt_L.GetComponent<Renderer>().material = highLightColor;
        OccipitalArt_R.GetComponent<Renderer>().material = highLightColor;
        skullNervesSinusOff();
    }

    public void OpthalmicArtShowObj()
    {
        MattTogg();
        OpthalmicArt_L.GetComponent<Renderer>().material = highLightColor;
        OpthalmicArt_R.GetComponent<Renderer>().material = highLightColor;
        skullCortexWhiteNervesSinusOff();
    }

    public void PostCerebralArtShowObj()
    {
        MattTogg();
        PostCerebralArt_L.GetComponent<Renderer>().material = highLightColor;
        PostCerebralArt_R.GetComponent<Renderer>().material = highLightColor;
        skullCortexWhiteNervesSinusOff();
    }

    public void AntCerebralArtShowObj()
    {
        MattTogg();
        AntCerebralArt_L.GetComponent<Renderer>().material = highLightColor;
        AntCerebralArt_R.GetComponent<Renderer>().material = highLightColor;
        skullCortexWhiteNervesSinusOff();
    }

    public void AscPharArtShowObj()
    {
        MattTogg();
        AscPharArt_L.GetComponent<Renderer>().material = highLightColor;
        AscPharArt_R.GetComponent<Renderer>().material = highLightColor;
        skullNervesSinusOff();
    }

    public void PostAuricularArtShowObj()
    {
        MattTogg();
        PostAuricularArt_L.GetComponent<Renderer>().material = highLightColor;
        PostAuricularArt_R.GetComponent<Renderer>().material = highLightColor;
        skullNervesSinusOff();
    }

    public void PostCommArtArtShowObj()
    {
        MattTogg();
        PostCommArt_L.GetComponent<Renderer>().material = highLightColor;
        PostCommArt_R.GetComponent<Renderer>().material = highLightColor;
        skullCortexWhiteNervesSinusOff();
    }

    public void MidMeningealArtShowObj()
    {
        MattTogg();
        MidMeningealArt_L.GetComponent<Renderer>().material = highLightColor;
        MidMeningealArt_R.GetComponent<Renderer>().material = highLightColor;
        skullNervesSinusOff();
    }

    public void SupTempArtShowObj()
    {
        MattTogg();
        SupTempArt_L.GetComponent<Renderer>().material = highLightColor;
        SupTempArt_R.GetComponent<Renderer>().material = highLightColor;
        skullNervesSinusOff();
    }

    public void ExtCarotidArtShowObj()
    {
        MattTogg();
        ExtCarotidArt_L.GetComponent<Renderer>().material = highLightColor;
        ExtCarotidArt_R.GetComponent<Renderer>().material = highLightColor;
        skullNervesSinusOff();
    }

    public void SupThyroidArtShowObj()
    {
        MattTogg();
        SupThyroidArt_L.GetComponent<Renderer>().material = highLightColor;
        SupThyroidArt_R.GetComponent<Renderer>().material = highLightColor;
        skullNervesSinusOff();
    }

    public void LingualArtShowObj()
    {
        MattTogg();
        LingualArt_L.GetComponent<Renderer>().material = highLightColor;
        LingualArt_R.GetComponent<Renderer>().material = highLightColor;
        skullNervesSinusOff();
    }

    public void AntCommArtShowObj()
    {
        MattTogg();
        antCommArt.GetComponent<Renderer>().material = highLightColor;
        bool[] newtoggle = new bool[] { false, false, false, false, true, true, true, false, false, true, true, true };
        updateToggles(newtoggle);
        toggles = newtoggle;
        nonCheckBoxTogg();
    }

    public void IntJugularShowObj()
    {
        MattTogg();
        IntJugular_L.GetComponent<Renderer>().material = highLightColor;
        IntJugular_R.GetComponent<Renderer>().material = highLightColor;
        bool[] newtoggle = new bool[] { false, true, true, true, true, true, true, true, false, true, true, true };
        updateToggles(newtoggle);
        toggles = newtoggle;
        nonCheckBoxTogg();
    }

    public void SupSagSinShowObj()
    {
        MattTogg();
        SupSagSin.GetComponent<Renderer>().material = highLightColor;
        bool[] newtoggle = new bool[] { false, true, true, true, true, true, false, true, false, true, true, true };
        updateToggles(newtoggle);
        toggles = newtoggle;
        nonCheckBoxTogg();
    }

    public void InfSagSinShowObj()
    {
        MattTogg();
        InfSagSin.GetComponent<Renderer>().material = highLightColor;
        bool[] newtoggle = new bool[] { false, false, false, false, false, true, false, true, false, true, true, false };
        updateToggles(newtoggle);
        toggles = newtoggle;
        nonCheckBoxTogg();
    }

    public void CavernousSinShowObj()
    {
        MattTogg();
        CavernousSin_L.GetComponent<Renderer>().material = highLightColor;
        CavernousSin_R.GetComponent<Renderer>().material = highLightColor;
        skullAndVasOff();
    }

    public void SupPetrosalSinShowObj()
    {
        MattTogg();
        SupPetrosalSin_L.GetComponent<Renderer>().material = highLightColor;
        SupPetrosalSin_R.GetComponent<Renderer>().material = highLightColor;
        skullAndVasOff();
    }

    public void SphernoperietalSinShowObj()
    {
        MattTogg();
        SphenoparietalSin_L.GetComponent<Renderer>().material = highLightColor;
        SphenoparietalSin_R.GetComponent<Renderer>().material = highLightColor;
        skullAndVasOff();
    }

    public void InfPetrosalSinShowObj()
    {
        MattTogg();
        InfPetrosalSin_L.GetComponent<Renderer>().material = highLightColor;
        InfPetrosalSin_R.GetComponent<Renderer>().material = highLightColor;
        skullAndVasOff();
    }

    public void OccipitalSinShowObj()
    {
        MattTogg();
        OccipitalSin_L.GetComponent<Renderer>().material = highLightColor;
        OccipitalSin_R.GetComponent<Renderer>().material = highLightColor;
        skullAndVasOff();
    }

    public void TransSinShowObj()
    {
        MattTogg();
        TransSin_L.GetComponent<Renderer>().material = highLightColor;
        TransSin_R.GetComponent<Renderer>().material = highLightColor;
        skullAndVasOff();
    }

    public void SigmoidSinShowObj()
    {
        MattTogg();
        SigmoidSin_L.GetComponent<Renderer>().material = highLightColor;
        SigmoidSin_R.GetComponent<Renderer>().material = highLightColor;
        skullAndVasOff();
    }

    public void StraightSinShowObj()
    {
        MattTogg();
        StraightSin.GetComponent<Renderer>().material = highLightColor;
        skullAndVasOff();
    }

    public void CNIShowObj()
    {
        MattTogg();
        CNI.GetComponent<Renderer>().material = highLightColor;
        skullWhiteMatterVasSinusJugOff();
    }

    public void CNIIShowObj()
    {
        MattTogg();
        CNII.GetComponent<Renderer>().material = highLightColor;
        skullWhiteMatterVasSinusJugOff();
    }

    public void CNIIIShowObj()
    {
        MattTogg();
        CNIII_L.GetComponent<Renderer>().material = highLightColor;
        CNIII_R.GetComponent<Renderer>().material = highLightColor;
        skullWhiteMatterVasSinusJugOff();
    }

    public void CNIVShowObj()
    {
        MattTogg();
        CNIV_L.GetComponent<Renderer>().material = highLightColor;
        CNIV_R.GetComponent<Renderer>().material = highLightColor;
        skullWhiteMatterVasSinusJugOff();
    }

    public void CNVShowObj()
    {
        MattTogg();
        CNV_L.GetComponent<Renderer>().material = highLightColor;
        CNV_R.GetComponent<Renderer>().material = highLightColor;
        skullWhiteMatterVasSinusJugOff();
    }

    public void CNVIShowObj()
    {
        MattTogg();
        CNVI_L.GetComponent<Renderer>().material = highLightColor;
        CNVI_R.GetComponent<Renderer>().material = highLightColor;
        skullWhiteMatterVasSinusJugOff();
    }

    public void CNVIIShowObj()
    {
        MattTogg();
        CNVII_L.GetComponent<Renderer>().material = highLightColor;
        CNVII_R.GetComponent<Renderer>().material = highLightColor;
        skullWhiteMatterVasSinusJugOff();
    }

    public void CNVIIIShowObj()
    {
        MattTogg();
        CNVIII_L.GetComponent<Renderer>().material = highLightColor;
        CNVIII_R.GetComponent<Renderer>().material = highLightColor;
        skullWhiteMatterVasSinusJugOff();
    }

    public void CNIXShowObj()
    {
        MattTogg();
        CNIX_L.GetComponent<Renderer>().material = highLightColor;
        CNIX_R.GetComponent<Renderer>().material = highLightColor;
        skullWhiteMatterVasSinusJugOff();
    }

    public void CNXShowObj()
    {
        MattTogg();
        CNX_L.GetComponent<Renderer>().material = highLightColor;
        CNX_R.GetComponent<Renderer>().material = highLightColor;
        skullWhiteMatterVasSinusJugOff();
    }

    public void CNXIShowObj()
    {
        MattTogg();
        CNXI_L.GetComponent<Renderer>().material = highLightColor;
        CNXI_R.GetComponent<Renderer>().material = highLightColor;
        skullWhiteMatterVasSinusJugOff();
    }

    public void CNXIIShowObj()
    {
        MattTogg();
        CNXII_L.GetComponent<Renderer>().material = highLightColor;
        CNXII_R.GetComponent<Renderer>().material = highLightColor;
        skullWhiteMatterVasSinusJugOff();
    }

    public void whiteMatterShowObj()
    {
        MattTogg();
        whiteMatter.GetComponent<Renderer>().material = highLightColor2;
        skullCortexVasSinusNerveJugOff();
    }

    public void corpCallShowObj()
    {
        MattTogg();
        corpCall.GetComponent<Renderer>().material = highLightColor2;
        skullCortexWhiteVasSinusNerveJugOff();
    }

    public void intCapShowObj()
    {
        MattTogg();
        intCap.GetComponent<Renderer>().material = highLightColor2;
        skullCortexWhiteVasSinusNerveJugOff();
    }

    public void fornixShowObj()
    {
        MattTogg();
        fornix.GetComponent<Renderer>().material = highLightColor2;
        bool[] newtoggle = new bool[] { false, false, false, false, true, false, false, false, false, false, false, true };
        updateToggles(newtoggle);
        toggles = newtoggle;
        nonCheckBoxTogg();
    }

    public void caudateNucShowObj()
    {
        MattTogg();
        caudateNuc1.GetComponent<Renderer>().material = highLightColor2;
        caudateNuc2.GetComponent<Renderer>().material = highLightColor2;
        skullCortexWhiteVasSinusNerveJugOff();
    }

    public void gloPallShowObj()
    {
        MattTogg();
        gloPall.GetComponent<Renderer>().material = highLightColor2;
        skullCortexWhiteVasSinusNerveJugOff();
    }

    public void putamenShowObj()
    {
        MattTogg();
        putamen.GetComponent<Renderer>().material = highLightColor2;
        skullCortexWhiteVasSinusNerveJugOff();
    }

    public void thalamusShowObj()
    {
        MattTogg();
        thalamus.GetComponent<Renderer>().material = highLightColor2;
        skullCortexWhiteBGVasSinusNerveJugOff();
    }

    public void hypothalamusShowObj()
    {
        MattTogg();
        hypothalamus.GetComponent<Renderer>().material = highLightColor2;
        skullCortexWhiteVasSinusNerveJugOff();
    }

    public void hippocampusShowObj()
    {
        MattTogg();
        hippocampus.GetComponent<Renderer>().material = highLightColor2;
        skullCortexWhiteVasSinusNerveJugOff();
    }

    //goes through the object array where they are sorted by material. This resets all objects to their original state.
    void MattTogg()
    {
        for (int i = 0; i < allObjects.Length; i++)
        {
            foreach (GameObject x in allObjects[i])
            {
                x.GetComponent<Renderer>().material = allMat[i];
            }
        }
    }

    //Turns the skull visibility on/off. 
    public void toggleSkull()
    {
        GameObject MRI = GameObject.Find("MRIToggles");

        //If the MRI toggles are turned on, then the skull is always off
        if (MRI.GetComponent<MRIToggle>().axial.isOn == true || MRI.GetComponent<MRIToggle>().coronal.isOn == true ||
            MRI.GetComponent<MRIToggle>().sagittal.isOn == true)
        {
            toggles[(int)toggleButtons.skullTogg] = false;
        }
        else
        {
            toggles[(int)toggleButtons.skullTogg] = !toggles[(int)toggleButtons.skullTogg];
        }
        
        visTogg(); //Function used to reset object visibility based on toggles
    }

    //Turns on/off left cortex objects. User can press this toggle
    public void toggleLCortex()
    {
        toggles[(int)toggleButtons.cortexLTogg] = !toggles[(int)toggleButtons.cortexLTogg];
        visTogg();
    }

    //Turns on/off right cortex objects. User can press this toggle
    public void toggleRCortex()
    {
        toggles[(int)toggleButtons.cortexRTogg] = !toggles[(int)toggleButtons.cortexRTogg];
        visTogg();
    }

    //Turns on/off white matter objects. User can press this toggle
    public void toggleWhiteMatter()
    {
        toggles[(int)toggleButtons.whiteMatterTogg] = !toggles[(int)toggleButtons.whiteMatterTogg];
        visTogg();
        cereWhiteMatterPart1.SetActive(toggles[(int)toggleButtons.whiteMatterTogg]);
        cereWhiteMatterPart2.SetActive(toggles[(int)toggleButtons.whiteMatterTogg]);
    }

    //Turns on/off cerebellum objects. User can press this toggle
    public void toggleCere()
    {
        toggles[(int)toggleButtons.cereTogg] = !toggles[(int)toggleButtons.cereTogg];
        toggles[(int)toggleButtons.cereCortex] = toggles[(int)toggleButtons.cereTogg];
        visTogg();
    }

    //Turns on/off basal ganglia objects. User can press this toggle
    public void toggleBasalGang()
    {
        toggles[(int)toggleButtons.basalGangTogg] = !toggles[(int)toggleButtons.basalGangTogg];
        visTogg();
    }

    //Turns on/off vasculature objects. User can press this toggle
    public void toggleVas()
    {
        toggles[(int)toggleButtons.vasTogg] = !toggles[(int)toggleButtons.vasTogg];
        visTogg();
    }

    //Turns on/off sinus objects. User can press this toggle
    public void toggleSinus()
    {
        toggles[(int)toggleButtons.sinusTogg] = !toggles[(int)toggleButtons.sinusTogg];
        visTogg();
    }

    //Turns on/off nerve objects. User can press this toggle
    public void toggleNerve()
    {
        toggles[(int)toggleButtons.nerveTogg] = !toggles[(int)toggleButtons.nerveTogg];
        visTogg();
    }

    //All user pressable toggles call this funtion. Goes through the list where objects are sorted by toggle visibility.
    //sets object visibility based on the toggles bool values.
    void visTogg()
    {
        //both sinues and vasulature share the jugular objects. Jugular is only turned off when both are off. 
        if (toggles[(int)toggleButtons.vasTogg] == false && toggles[(int)toggleButtons.sinusTogg] == false)
            toggles[(int)toggleButtons.jugTogg] = false;
        else
            toggles[(int)toggleButtons.jugTogg] = true;
        for (int i = 0; i < objectVisibility.Length; i++)
        {
            foreach (GameObject x in objectVisibility[i])
            {
                x.SetActive(toggles[i]);                
            }
        }
    }

    //Goes through the list of objects that are not toggled by user pressable toggles. Last three in list. Sets object visibility
    //based on the toggles bool values
    void nonCheckBoxTogg()
    {
        if (toggles[(int)toggleButtons.vasTogg] == false && toggles[(int)toggleButtons.sinusTogg] == false)
            toggles[(int)toggleButtons.jugTogg] = false;
        else
            toggles[(int)toggleButtons.jugTogg] = true;
        for (int i = objectVisibility.Length - 2; i < objectVisibility.Length; i++)
        {
            foreach (GameObject x in objectVisibility[i])
            {
                x.SetActive(toggles[i]);
            }
        }
    }

    //turns on everything but skull
    void everythingButSkull()
    {
        bool[] newtoggle = new bool[] { false, true, true, true, true, true, true, true, true, true, true, true };
        updateToggles(newtoggle);
        toggles = newtoggle;
        nonCheckBoxTogg();
    }

    //turns off skull and vasculature
    void skullAndVasOff()
    {
        bool[] newtoggle = new bool[] { false, false, true, false, true, true, false, true, false, true, true, false };
        updateToggles(newtoggle);
        toggles = newtoggle;
        nonCheckBoxTogg();
    }

    //turns off skull, nerves, sinuses
    void skullNervesSinusOff()
    {
        bool[] newtoggle = new bool[] { false, true, true, true, true, true, true, false, false, true, true, true };
        updateToggles(newtoggle);
        toggles = newtoggle;
        nonCheckBoxTogg();
    }

    //turns of skull, full cortex, nerves, sinuses
    void skullCortexWhiteNervesSinusOff()
    {
        bool[] newtoggle = new bool[] { false, false, true, false, true, true, true, false, false, true, true, true };
        updateToggles(newtoggle);
        toggles = newtoggle;
        nonCheckBoxTogg();
    }

    //turns off skull, white matter, vasculature, sinuses, jugular
    void skullWhiteMatterVasSinusJugOff()
    {
        bool[] newtoggle = new bool[] { false, true, true, false, true, true, false, false, true, false, true, true };
        updateToggles(newtoggle);
        toggles = newtoggle;
        nonCheckBoxTogg();
    }

    //turns off skull, full cortex, vasculature, sinuses, nerves, jugular
    void skullCortexVasSinusNerveJugOff()
    {
        bool[] newtoggle = new bool[] { false, false, false, true, true, true, false, false, false, false, true, true };
        updateToggles(newtoggle);
        toggles = newtoggle;
        nonCheckBoxTogg();
    }

    //turns off skull, full cortex, white matter, vasculature, sinuses, nerves, jugular
    void skullCortexWhiteVasSinusNerveJugOff()
    {
        bool[] newtoggle = new bool[] { false, false, false, false, true, true, false, false, false, false, true, true };
        updateToggles(newtoggle);
        toggles = newtoggle;
        nonCheckBoxTogg();
    }

    //turns off skull, full cortex, white matter, basal ganglia, vasuclature, sinuses, nerves, jugular
    void skullCortexWhiteBGVasSinusNerveJugOff()
    {
        bool[] newtoggle = new bool[] { false, false, false, false, true, false, false, false, false, false, true, true };
        updateToggles(newtoggle);
        toggles = newtoggle;
        nonCheckBoxTogg();
    }

    //updates the ToggCheckBox list with the new visibility values based on the function calling it
    void updateToggles(bool[] newVal)
    {
        ToggCheckBox[(int)toggleButtons.skullTogg].isOn = newVal[(int)toggleButtons.skullTogg];
        ToggCheckBox[(int)toggleButtons.cortexLTogg].isOn = newVal[(int)toggleButtons.cortexLTogg];
        ToggCheckBox[(int)toggleButtons.cortexRTogg].isOn = newVal[(int)toggleButtons.cortexRTogg];
        ToggCheckBox[(int)toggleButtons.whiteMatterTogg].isOn = newVal[(int)toggleButtons.whiteMatterTogg];
        ToggCheckBox[(int)toggleButtons.cereTogg].isOn = newVal[(int)toggleButtons.cereTogg];
        ToggCheckBox[(int)toggleButtons.basalGangTogg].isOn = newVal[(int)toggleButtons.basalGangTogg];
        ToggCheckBox[(int)toggleButtons.vasTogg].isOn = newVal[(int)toggleButtons.vasTogg];
        ToggCheckBox[(int)toggleButtons.sinusTogg].isOn = newVal[(int)toggleButtons.sinusTogg];
        ToggCheckBox[(int)toggleButtons.nerveTogg].isOn = newVal[(int)toggleButtons.nerveTogg];
    }

    //When the MRI slices are turned on, the materials in some areas needs to have a different alpha value so the slice can be seen
    //behind it. Alpha values are changed in MRIToggle
    public void ChangedAlpha(Material[] newMat)
    {
        allMat[(int)structMenuByMat.whiteMatter] = newMat[0];
        allMat[(int)structMenuByMat.thirdVent] = newMat[1];
        allMat[(int)structMenuByMat.corpCall] = newMat[2];
        allMat[(int)structMenuByMat.thalamus] = newMat[3];
        allMat[(int)structMenuByMat.intcap] = newMat[4];
        allMat[(int)structMenuByMat.hypothalamus] = newMat[5];
        allMat[(int)structMenuByMat.hippocampus] = newMat[6];
        allMat[(int)structMenuByMat.glopall] = newMat[7];
        allMat[(int)structMenuByMat.fornix] = newMat[8];
        allMat[(int)structMenuByMat.caudate] = newMat[9];
        allMat[(int)structMenuByMat.latvent] = newMat[10];
        allMat[(int)structMenuByMat.mat030] = newMat[11];
        highLightColor2 = newMat[12];

        for (int i = 0; i < 13; i++)
        {
            if (i !=1)
            {
                foreach (GameObject x in allObjects[i])
                {
                    if (x.GetComponent<Renderer>().material.name == "Highlight2 (Instance)")
                        x.GetComponent<Renderer>().material = highLightColor2;
                    else
                        x.GetComponent<Renderer>().material = allMat[i];
                }
            }
        }
    }
}
