using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnButtonClick : MonoBehaviour {
    public GameObject menu;
    public GameObject text;
    public GameObject displayObj;
	
	public bool is3D;

    public Button cort;
    public Button lobe;
    public Button lobe1;
    public Button lobe2;
    public Button lobe3;
    public Button gyri;
    public Button sulci;
    public Button frontal;
    public Button parietal;
    public Button temporal;
    public Button occipital;
    public Button brocas;
    public Button frontalEyeField;
    public Button preMotorCortex;
    public Button sma;
    public Button parietalPostCentGryus;
    public Button wernickes;
    public Button preCentGyrus;
    public Button postCentGyrus;
    public Button cingulateGyrus;
    public Button centSulcus;
    public Button latSulcus;
    public Button periSuclus;

    public Button vent;
    public Button latVent;
    public Button cerebralAque;
    public Button thirdVent;
    public Button fourthVent;

    public Button cere;
    public Button cereCortex;
    public Button peduncles;
    public Button vermis;
    public Button cereWhiteMatter;

    public Button vas;
    public Button commCar;
    public Button commCar1;
    public Button commCar2;
    public Button commCar3;
    public Button intCar;
    public Button intCar1;
    public Button extCar;
    public Button vert;
    public Button basilarArt;
    public Button basilarArt1;
    public Button antCereArt;
    public Button maxArt;
    public Button antInfCereArt;
    public Button intJugular;
    public Button postCommArt;
    public Button opthalmicArt;
    public Button midCereArt;
    public Button antCommArt;
    public Button supThyroidArt;
    public Button ascPharArt;
    public Button lingualArt;
    public Button facialArt;
    public Button occipitalArt;
    public Button postAricularArt;
    public Button supTempArt;
    public Button PostInfCereArt;
    public Button ASArt;
    public Button labArt;
    public Button pontineArt;
    public Button supCereArt;
    public Button postCerebralArt;

    public Button sin;
    public Button supSagSin;
    public Button infSagSin;
    public Button cavernousSin;
    public Button supPetrosalSin;
    public Button sphernoperitalSin;
    public Button infPetrosalSin;
    public Button occipitalSin;
    public Button transSin;
    public Button sigmoidSin;
    public Button straightSin;

    public Button nerve;
    public Button cnI;
    public Button cnII;
    public Button cnIII;
    public Button cnIV;
    public Button cnV;
    public Button cnVI;
    public Button cnVII;
    public Button cnVIII;
    public Button cnIX;
    public Button cnX;
    public Button cnXI;
    public Button cnXII;

    public Button subCort;
    public Button whiteMatter;
    public Button corpCall;
    public Button intCap;
    public Button fornix;
    public Button caudateNuc;
    public Button gloPall;
    public Button putamen;
    public Button thalamus;
    public Button hippo;
    public Button hypo;

    public Button spinal;
    public Button brainStem;

    Color highlight = new Color32(71, 230, 184, 255);
    Color reset;

    Button[] allbuttons;

    void Start()
    {
        allbuttons = new Button[] {cort, lobe, gyri, sulci, frontal, parietal, temporal, occipital, brocas, frontalEyeField,
                                    preMotorCortex, sma, parietalPostCentGryus, wernickes, preCentGyrus, postCentGyrus,
                                    cingulateGyrus, centSulcus, latSulcus, periSuclus, vent, latVent, cerebralAque, thirdVent,
                                    fourthVent, cere, cereCortex, peduncles, vermis, cereWhiteMatter, vas, commCar, intCar,
                                    extCar, vert, basilarArt, antCereArt, maxArt, antInfCereArt, intJugular, postCommArt,
                                    opthalmicArt, midCereArt, antCommArt, supThyroidArt, ascPharArt, lingualArt, facialArt,
                                    occipitalArt, postAricularArt, supTempArt, PostInfCereArt, ASArt,
                                    labArt, pontineArt, supCereArt, postCerebralArt, sin, supSagSin, infSagSin, cavernousSin,
                                    supPetrosalSin, sphernoperitalSin, infPetrosalSin, occipitalSin, transSin,
                                    sigmoidSin, straightSin, nerve, cnI, cnII, cnIII, cnIV, cnV, cnVI, cnVII, cnVIII, cnIX,
                                    cnX, cnXI, cnXII, subCort, whiteMatter, corpCall, intCap, fornix, caudateNuc,
                                    gloPall, putamen, thalamus, hippo, hypo, spinal, brainStem};
        reset = cort.image.color;
    }

    public void cortStructOnClick()
    {
        menu.GetComponent<ButtonVisibility>().cortStructDropDown();
        colorReset();
        cort.image.color = highlight;
    }

    public void ventSysOnClick()
    {
        menu.GetComponent<ButtonVisibility>().ventSysDropDown();
        colorReset();
        vent.image.color = highlight;
    }

    public void latVentOnClick()
    {
        colorReset();
        vent.image.color = highlight;
        latVent.image.color = highlight;
    }

    public void cerebralAqueOnClick()
    {
        colorReset();
        vent.image.color = highlight;
        cerebralAque.image.color = highlight;
    }

    public void thirdVentOnClick()
    {
        colorReset();
        vent.image.color = highlight;
        thirdVent.image.color = highlight;
    }

    public void fourthVentOnClick()
    {
        colorReset();
        vent.image.color = highlight;
        fourthVent.image.color = highlight;
    }

    public void cereOnClick()
    {
        menu.GetComponent<ButtonVisibility>().cereDropDown();
        colorReset();
        cere.image.color = highlight;
    }

    public void cereCortexOnClick()
    {
        colorReset();
        cere.image.color = highlight;
        cereCortex.image.color = highlight;
    }

    public void pedunclesOnClick()
    {
        colorReset();
        cere.image.color = highlight;
        peduncles.image.color = highlight;
    }

    public void vermisOnClick()
    {
        colorReset();
        cere.image.color = highlight;
        vermis.image.color = highlight;
    }

    public void cereWhiteMatterOnClick()
    {
        colorReset();
        cere.image.color = highlight;
        cereWhiteMatter.image.color = highlight;
    }

    public void brainStemOnClick()
    {
        menu.GetComponent<ButtonVisibility>().brainDropDown();
        text.GetComponent<TextVisibility>().brainstemShowText();
		if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().brainstemShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().brainstemShowObj();
        colorReset();
        brainStem.image.color = highlight;
    }

    public void spinalCordOnClick()
    {
        menu.GetComponent<ButtonVisibility>().spinalDropDown();
        text.GetComponent<TextVisibility>().spinalCordShowText();
		if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().spinalCordShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().spinalCordShowObj();
        colorReset();
        spinal.image.color = highlight;
    }

    public void vasOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasDropDown();
        colorReset();
        vas.image.color = highlight;
    }

    public void intJugOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasJugular();
        colorReset();
        vas.image.color = highlight;
        intJugular.image.color = highlight;
    }

    public void vasCommCarOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasCommCarotidDropDown();
        colorReset();
        commCar.image.color = highlight;
        vas.image.color = highlight;
    }

    public void vasIntCarOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasIntCarotidDropDown();
        colorReset();
        commCar1.image.color = highlight;
        vas.image.color = highlight;
        intCar.image.color = highlight;
    }

    public void PostCommArtOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasIntCarotidDropDown();
        colorReset();
        commCar1.image.color = highlight;
        vas.image.color = highlight;
        intCar.image.color = highlight;
        postCommArt.image.color = highlight;
    }

    public void OpthalmicArtOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasIntCarotidDropDown();
        colorReset();
        commCar1.image.color = highlight;
        vas.image.color = highlight;
        intCar.image.color = highlight;
        opthalmicArt.image.color = highlight;
    }

    public void MidCerebralArtOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasIntCarotidDropDown();
        colorReset();
        commCar1.image.color = highlight;
        vas.image.color = highlight;
        intCar.image.color = highlight;
        midCereArt.image.color = highlight;
    }

    public void vasIntCarAntCerebralOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasIntCarotidAntCerebralDropDown();
        colorReset();
        commCar1.image.color = highlight;
        vas.image.color = highlight;
        intCar1.image.color = highlight;
        antCereArt.image.color = highlight;
    }

    public void AntCommArtOnClick()
    {
        colorReset();
        commCar2.image.color = highlight;
        vas.image.color = highlight;
        intCar1.image.color = highlight;
        antCereArt.image.color = highlight;
        antCommArt.image.color = highlight;
    }

    public void vasExtCarOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasExtCarotidDropDown();
        colorReset();
        commCar3.image.color = highlight;
        vas.image.color = highlight;
        extCar.image.color = highlight;
    }

    public void SupThyroidArtOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasExtCarotidDropDown();
        colorReset();
        commCar3.image.color = highlight;
        vas.image.color = highlight;
        extCar.image.color = highlight;
        supThyroidArt.image.color = highlight;
    }

    public void AscPharArtOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasExtCarotidDropDown();
        colorReset();
        commCar3.image.color = highlight;
        vas.image.color = highlight;
        extCar.image.color = highlight;
        ascPharArt.image.color = highlight;
    }

    public void LingualArtOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasExtCarotidDropDown();
        colorReset();
        commCar3.image.color = highlight;
        vas.image.color = highlight;
        extCar.image.color = highlight;
        lingualArt.image.color = highlight;
    }

    public void FacialArtOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasExtCarotidDropDown();
        colorReset();
        commCar3.image.color = highlight;
        vas.image.color = highlight;
        extCar.image.color = highlight;
        facialArt.image.color = highlight;
    }

    public void OccipitalArtOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasExtCarotidDropDown();
        colorReset();
        commCar3.image.color = highlight;
        vas.image.color = highlight;
        extCar.image.color = highlight;
        occipitalArt.image.color = highlight;
    }

    public void PostAuricularArtOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasExtCarotidDropDown();
        colorReset();
        commCar3.image.color = highlight;
        vas.image.color = highlight;
        extCar.image.color = highlight;
        postAricularArt.image.color = highlight;
    }

    public void SupTempArtOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasExtCarotidDropDown();
        colorReset();
        commCar3.image.color = highlight;
        vas.image.color = highlight;
        extCar.image.color = highlight;
        supTempArt.image.color = highlight;
    }

    public void vasExtCarMaxArtOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasExtCarotidDropDown();
        colorReset();
        commCar3.image.color = highlight;
        vas.image.color = highlight;
        extCar.image.color = highlight;
        maxArt.image.color = highlight;
    }

    public void vasVertOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasVertDropDown();
        colorReset();
        vas.image.color = highlight;
        vert.image.color = highlight;
    }

    public void PostInfCereArtOnClick()
    {
        colorReset();
        vas.image.color = highlight;
        vert.image.color = highlight;
        PostInfCereArt.image.color = highlight;
    }

    public void ASAOnClick()
    {
        colorReset();
        vas.image.color = highlight;
        vert.image.color = highlight;
        ASArt.image.color = highlight;
    }

    public void vasBasilarOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasBasilarDropDown();
        colorReset();
        vas.image.color = highlight;
        basilarArt.image.color = highlight;
    }

    public void PontineOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasBasilarDropDown();
        colorReset();
        vas.image.color = highlight;
        basilarArt.image.color = highlight;
        pontineArt.image.color = highlight;
    }

    public void SupCereArtOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasBasilarDropDown();
        colorReset();
        vas.image.color = highlight;
        basilarArt.image.color = highlight;
        supCereArt.image.color = highlight;
    }

    public void PostCerebralOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasBasilarDropDown();
        colorReset();
        vas.image.color = highlight;
        basilarArt.image.color = highlight;
        postCerebralArt.image.color = highlight;
    }

    public void vasBasilarAntInfCereOnClick()
    {
        menu.GetComponent<ButtonVisibility>().vasBasilarAntInfCereDropDown();
        colorReset();
        vas.image.color = highlight;
        basilarArt1.image.color = highlight;
        antInfCereArt.image.color = highlight;
    }

    public void LabArtOnClick()
    {
        colorReset();
        vas.image.color = highlight;
        basilarArt1.image.color = highlight;
        antInfCereArt.image.color = highlight;
        labArt.image.color = highlight;
    }

    public void nervesOnClick()
    {
        menu.GetComponent<ButtonVisibility>().nervesDropDown();
        colorReset();
        nerve.image.color = highlight;
    }

    public void cnIOnClick()
    {
        colorReset();
        nerve.image.color = highlight;
        cnI.image.color = highlight;
    }

    public void cnIIOnClick()
    {
        colorReset();
        nerve.image.color = highlight;
        cnII.image.color = highlight;
    }

    public void cnIIIOnClick()
    {
        colorReset();
        nerve.image.color = highlight;
        cnIII.image.color = highlight;
    }

    public void cnIVOnClick()
    {
        colorReset();
        nerve.image.color = highlight;
        cnIV.image.color = highlight;
    }

    public void cnVOnClick()
    {
        colorReset();
        nerve.image.color = highlight;
        cnV.image.color = highlight;
    }

    public void cnVIOnClick()
    {
        colorReset();
        nerve.image.color = highlight;
        cnVI.image.color = highlight;
    }

    public void cnVIIOnClick()
    {
        colorReset();
        nerve.image.color = highlight;
        cnVII.image.color = highlight;
    }

    public void cnVIIIOnClick()
    {
        colorReset();
        nerve.image.color = highlight;
        cnVIII.image.color = highlight;
    }

    public void cnIXOnClick()
    {
        colorReset();
        nerve.image.color = highlight;
        cnIX.image.color = highlight;
    }

    public void cnXOnClick()
    {
        colorReset();
        nerve.image.color = highlight;
        cnX.image.color = highlight;
    }

    public void cnXIOnClick()
    {
        colorReset();
        nerve.image.color = highlight;
        cnXI.image.color = highlight;
    }

    public void cnXIIOnClick()
    {
        colorReset();
        nerve.image.color = highlight;
        cnXII.image.color = highlight;
    }

    public void sinusesOnClick()
    {
        menu.GetComponent<ButtonVisibility>().sinusesDropDown();
        colorReset();
        sin.image.color = highlight;
    }

    public void supSagSinOnClick()
    {
        colorReset();
        sin.image.color = highlight;
        supSagSin.image.color = highlight;
    }

    public void infSagSinOnClick()
    {
        colorReset();
        sin.image.color = highlight;
        infSagSin.image.color = highlight;
    }

    public void cavernousSinOnClick()
    {
        colorReset();
        sin.image.color = highlight;
        cavernousSin.image.color = highlight;
    }

    public void supPetSinOnClick()
    {
        colorReset();
        sin.image.color = highlight;
        supPetrosalSin.image.color = highlight;
    }

    public void SphernoOnClick()
    {
        colorReset();
        sin.image.color = highlight;
        sphernoperitalSin.image.color = highlight;
    }

    public void infPetSinOnClick()
    {
        colorReset();
        sin.image.color = highlight;
        infPetrosalSin.image.color = highlight;
    }

    public void occipitalSinOnClick()
    {
        colorReset();
        sin.image.color = highlight;
        occipitalSin.image.color = highlight;
    }

    public void transSinOnClick()
    {
        colorReset();
        sin.image.color = highlight;
        transSin.image.color = highlight;
    }

    public void sigmoidSinOnClick()
    {
        colorReset();
        sin.image.color = highlight;
        sigmoidSin.image.color = highlight;
    }

    public void straightSinOnClick()
    {
        colorReset();
        sin.image.color = highlight;
        straightSin.image.color = highlight;
    }

    public void subCortOnClick()
    {
        menu.GetComponent<ButtonVisibility>().subCortDropDown();
        colorReset();
        subCort.image.color = highlight;
    }

    public void whiteMatterOnClick()
    {
        colorReset();
        subCort.image.color = highlight;
        whiteMatter.image.color = highlight;
    }

    public void corpCallOnClick()
    {
        colorReset();
        subCort.image.color = highlight;
        corpCall.image.color = highlight;
    }

    public void intCapOnClick()
    {
        colorReset();
        subCort.image.color = highlight;
        intCap.image.color = highlight;
    }

    public void fornixOnClick()
    {
        colorReset();
        subCort.image.color = highlight;
        fornix.image.color = highlight;
    }

    public void caudateNucOnClick()
    {
        colorReset();
        subCort.image.color = highlight;
        caudateNuc.image.color = highlight;
    }

    public void gloPallOnClick()
    {
        colorReset();
        subCort.image.color = highlight;
        gloPall.image.color = highlight;
    }

    public void putamenOnClick()
    {
        colorReset();
        subCort.image.color = highlight;
        putamen.image.color = highlight;
    }

    public void thalamusOnClick()
    {
        colorReset();
        subCort.image.color = highlight;
        thalamus.image.color = highlight;
    }

    public void hippoOnClick()
    {
        colorReset();
        subCort.image.color = highlight;
        hippo.image.color = highlight;
    }

    public void hypoOnClick()
    {
        colorReset();
        subCort.image.color = highlight;
        hypo.image.color = highlight;
    }

    public void cortLobeOnClick()
    {
        menu.GetComponent<ButtonVisibility>().cortLobeDropDown();
        colorReset();
        cort.image.color = highlight;
        lobe.image.color = highlight;
    }

    public void OccipitalOnClick()
    {
        menu.GetComponent<ButtonVisibility>().occipitalLobeDropDown();
        colorReset();
        cort.image.color = highlight;
        lobe.image.color = highlight;
        occipital.image.color = highlight;
    }

    public void frontalLobeOnClick()
    {
        menu.GetComponent<ButtonVisibility>().frontalLobeDropDown();
        colorReset();
        cort.image.color = highlight;
        lobe1.image.color = highlight;
        frontal.image.color = highlight;
    }

    public void BrocasOnClick()
    {
        colorReset();
        cort.image.color = highlight;
        lobe1.image.color = highlight;
        frontal.image.color = highlight;
        brocas.image.color = highlight;
    }

    public void FrontalEyeFieldOnClick()
    {
        colorReset();
        cort.image.color = highlight;
        lobe1.image.color = highlight;
        frontal.image.color = highlight;
        frontalEyeField.image.color = highlight;
    }

    public void PreMotorCortexOnClick()
    {
        colorReset();
        cort.image.color = highlight;
        lobe1.image.color = highlight;
        frontal.image.color = highlight;
        preMotorCortex.image.color = highlight;
    }

    public void SMAOnClick()
    {
        colorReset();
        cort.image.color = highlight;
        lobe1.image.color = highlight;
        frontal.image.color = highlight;
        sma.image.color = highlight;
    }

    public void parietalLobeOnClick()
    {
        menu.GetComponent<ButtonVisibility>().parietalLobeDropDown();
        colorReset();
        cort.image.color = highlight;
        lobe2.image.color = highlight;
        parietal.image.color = highlight;
    }
    public void ParietalPostCentGyrusOnClick()
    {
        menu.GetComponent<ButtonVisibility>().parietalLobeDropDown();
        colorReset();
        cort.image.color = highlight;
        lobe2.image.color = highlight;
        parietal.image.color = highlight;
        parietalPostCentGryus.image.color = highlight;
    }

    public void temporalLobeOnClick()
    {
        menu.GetComponent<ButtonVisibility>().temporalLobeDropDown();
        colorReset();
        cort.image.color = highlight;
        lobe3.image.color = highlight;
        temporal.image.color = highlight;
    }

    public void WernickesOnClick()
    {
        colorReset();
        cort.image.color = highlight;
        lobe3.image.color = highlight;
        temporal.image.color = highlight;
        wernickes.image.color = highlight;
    }

    public void cortGyriOnClick()
    {
        menu.GetComponent<ButtonVisibility>().cortGyriDropDown();
        colorReset();
        cort.image.color = highlight;
        gyri.image.color = highlight;
    }

    public void PreCentGyrusOnClick()
    {
        colorReset();
        cort.image.color = highlight;
        gyri.image.color = highlight;
        preCentGyrus.image.color = highlight;
    }

    public void PostCentGyrusOnClick()
    {
        colorReset();
        cort.image.color = highlight;
        gyri.image.color = highlight;
        postCentGyrus.image.color = highlight;
    }

    public void CingulateOnClick()
    {
        colorReset();
        cort.image.color = highlight;
        gyri.image.color = highlight;
        cingulateGyrus.image.color = highlight;
    }

    public void cortSulcusOnClick()
    {
        menu.GetComponent<ButtonVisibility>().cortSulciDropDown();
        colorReset();
        cort.image.color = highlight;
        sulci.image.color = highlight;
    }

    public void CentSulcusOnClick()
    {
        colorReset();
        cort.image.color = highlight;
        sulci.image.color = highlight;
        centSulcus.image.color = highlight;
    }

    public void LatSulcusOnClick()
    {
        colorReset();
        cort.image.color = highlight;
        sulci.image.color = highlight;
        latSulcus.image.color = highlight;
    }

    public void PeriSulcusOnClick()
    {
        colorReset();
        cort.image.color = highlight;
        sulci.image.color = highlight;
        periSuclus.image.color = highlight;
    }

    public void resetOnClick()
    {
        menu.GetComponent<ButtonVisibility>().resetDropDown();
        colorReset();
    }

    public void colorReset()
    {
        for (int i = 0; i < allbuttons.Length; i++)
        {
            allbuttons[i].image.color = reset;
        }
    }
}
