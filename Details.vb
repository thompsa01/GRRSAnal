Public Class Details 
    Private obj As GRRSAnal
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelTYR.Text = obj.GridView1.GetFocusedRow().row.item("TYR")
        LabelTWK.Text = obj.GridView1.GetFocusedRow().row.item("TWK")
        LabelTPER.Text = obj.GridView1.GetFocusedRow().row.item("TPER")
        LabelTTINCOME.Text = obj.GridView1.GetFocusedRow().row.item("TTINCOME")
        LabelTTEXPENSE.Text = obj.GridView1.GetFocusedRow().row.item("TTOTEXP")
        LabelTPROFIT.Text = obj.GridView1.GetFocusedRow().row.item("TPROFIT")
        LabelTACCDEPD.Text = obj.GridView1.GetFocusedRow().row.item("TACCDEPD")
        LabelTACON.Text = obj.GridView1.GetFocusedRow().row.item("TACON")
        LabelTNAME.Text = obj.GridView1.GetFocusedRow().row.item("TNAME")
        LabelTINCOME.Text = obj.GridView1.GetFocusedRow().row.item("TINCOME")
        LabelTEXPENSE.Text = obj.GridView1.GetFocusedRow().row.item("TEXPENSE")
        LabelTUNIT.Text = obj.GridView1.GetFocusedRow().row.item("TUNIT")
        LabelTUNITH.Text = obj.GridView1.GetFocusedRow().row.item("TUNITH")
        LabelTDRVR.Text = obj.GridView1.GetFocusedRow().row.item("TDRVR")
        LabelTTRLR.Text = obj.GridView1.GetFocusedRow().row.item("TTRLR")

        LabelTDRP.Text = obj.GridView1.GetFocusedRow().row.item("TDRP")
        LabelTNAMA.Text = obj.GridView1.GetFocusedRow().row.item("TNAMA")
        LabelTNADR1.Text = obj.GridView1.GetFocusedRow().row.item("TNADR1")
        LabelTNADR2.Text = obj.GridView1.GetFocusedRow().row.item("TNADR2")
        LabelTNADR3.Text = obj.GridView1.GetFocusedRow().row.item("TNADR3")
        LabelTNADR4.Text = obj.GridView1.GetFocusedRow().row.item("TNADR4")
        LabelTNPC.Text = obj.GridView1.GetFocusedRow().row.item("TNPC")
        LabelTNZONE.Text = obj.GridView1.GetFocusedRow().row.item("TNZONE")

        LabelTANL1.Text = obj.GridView1.GetFocusedRow().row.item("TANL1")
        LabelTANL2.Text = obj.GridView1.GetFocusedRow().row.item("TANL2")
        LabelTANL3.Text = obj.GridView1.GetFocusedRow().row.item("TANL3")
        LabelTANL4.Text = obj.GridView1.GetFocusedRow().row.item("TANL4")
        LabelTANL5.Text = obj.GridView1.GetFocusedRow().row.item("TANL5")
        LabelTANL6.Text = obj.GridView1.GetFocusedRow().row.item("TANL6")

        LabelTFLTTYPE.Text = obj.GridView1.GetFocusedRow().row.item("TFLTTYPE")
        If obj.GridView1.Columns("TTMILES").VisibleIndex <> -1 Then
            LabelTTMILES.Text = obj.GridView1.GetFocusedRow().row.item("TTMILES")
        Else
            LabelTTMILES.Text = ""
        End If
        If obj.GridView1.Columns("THBMILES").VisibleIndex <> -1 Then
            LabelTHBMILES.Text = obj.GridView1.GetFocusedRow().row.item("THBMILES")
        Else
            LabelTHBMILES.Text = ""
        End If
        If obj.GridView1.Columns("TPLTMILES").VisibleIndex <> -1 Then
            LabelTPLTMILES.Text = obj.GridView1.GetFocusedRow().row.item("TPLTMILES")
        Else
            LabelTPLTMILES.Text = ""
        End If
        If obj.GridView1.Columns("THOURS").VisibleIndex <> -1 Then
            LabelTHOURS.Text = obj.GridView1.GetFocusedRow().row.item("THOURS")
        Else
            LabelTHOURS.Text = ""
        End If
        If obj.GridView1.Columns("TADHRS").VisibleIndex <> -1 Then
            LabelTADHRS.Text = obj.GridView1.GetFocusedRow().row.item("TADHRS")
        Else
            LabelTADHRS.Text = ""
        End If
        If obj.GridView1.Columns("TAMILE").VisibleIndex <> -1 Then
            LabelTAMILES.Text = obj.GridView1.GetFocusedRow().row.item("TAMILE")
        Else
            LabelTAMILES.Text = ""
        End If
        LabelTROUT.Text = obj.GridView1.GetFocusedRow().row.item("TROUT")
        LabelTORDNO.Text = obj.GridView1.GetFocusedRow().row.item("TORDNO")
        LabelTJOBN.Text = obj.GridView1.GetFocusedRow().row.item("TJOBN")
        LabelTDATE.Text = obj.GridView1.GetFocusedRow().row.item("TDATE")

        LabelTDRIVER.Text = obj.GridView1.GetFocusedRow().row.item("TDRIVER")
        LabelTFUEL.Text = obj.GridView1.GetFocusedRow().row.item("TFUEL")
        LabelTFIXED.Text = obj.GridView1.GetFocusedRow().row.item("TFIXED")
        LabelTSHUNT.Text = obj.GridView1.GetFocusedRow().row.item("TSHUNT")
        LabelTTPCST.Text = obj.GridView1.GetFocusedRow().row.item("TTPCST")

        LabelTS1.Text = obj.GridView1.GetFocusedRow().row.item("TS1")
        LabelTS2.Text = obj.GridView1.GetFocusedRow().row.item("TS2")
        LabelTS3.Text = obj.GridView1.GetFocusedRow().row.item("TS3")
        LabelTS4.Text = obj.GridView1.GetFocusedRow().row.item("TS4")
        LabelTS5.Text = obj.GridView1.GetFocusedRow().row.item("TS5")
        LabelTSCST1.Text = obj.GridView1.GetFocusedRow().row.item("TSCST1")
        LabelTSCST2.Text = obj.GridView1.GetFocusedRow().row.item("TSCST2")
        LabelTSCST3.Text = obj.GridView1.GetFocusedRow().row.item("TSCST3")
        LabelTSCST4.Text = obj.GridView1.GetFocusedRow().row.item("TSCST4")
        LabelTSCST5.Text = obj.GridView1.GetFocusedRow().row.item("TSCST5")
        ''LabelTSL.Text = obj.GridView1.GetFocusedRow().row.item("TSL")
        ''LabelTTD.Text = obj.GridView1.GetFocusedRow().row.item("TTD")
        ''LabelTCS.Text = obj.GridView1.GetFocusedRow().row.item("TCS")
        If obj.GridView1.GetFocusedRow().row.item("TSLCST").Equals(0) Then
            LabelTSL.Text = ""
        Else
            LabelTSL.Text = "Stay Loaded"
        End If
        If obj.GridView1.GetFocusedRow().row.item("TTDCST").Equals(0) Then
            LabelTTD.Text = ""
        Else
            LabelTTD.Text = "Cross Dock"
        End If
        If obj.GridView1.GetFocusedRow().row.item("TCSCST").Equals(0) Then
            LabelTCS.Text = ""
        Else
            LabelTCS.Text = "Storage"
        End If
        LabelTSLCST.Text = obj.GridView1.GetFocusedRow().row.item("TSLCST")
        LabelTTDCST.Text = obj.GridView1.GetFocusedRow().row.item("TTDCST")
        LabelTCSCST.Text = obj.GridView1.GetFocusedRow().row.item("TCSCST")

        LabelTDEL.Text = obj.GridView1.GetFocusedRow().row.item("TDEL")
        LabelTCOL.Text = obj.GridView1.GetFocusedRow().row.item("TCOL")
        If obj.GridView1.Columns("TSURC").VisibleIndex <> -1 Then
            LabelTSURP.Text = obj.GridView1.GetFocusedRow().row.item("TSURP")
            LabelTSURC.Text = obj.GridView1.GetFocusedRow().row.item("TSURC")
        Else
            LabelTSURP.Text = ""
            LabelTSURC.Text = ""
        End If

        LabelTTYPE.Text = obj.GridView1.GetFocusedRow().row.item("TTYPE")
    End Sub





    Sub New(taobj As GRRSAnal)
        obj = taobj
        InitializeComponent()
    End Sub

    
End Class