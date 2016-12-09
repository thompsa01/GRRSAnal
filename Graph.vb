Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors

Public Class Graph
    Private cmd As New ADODB.Command
    Private rs As New ADODB.Recordset
    Private dt As New DataTable
    Private qrystr, sumfield, groupfield, seq As String
    Private series1 As New Series
    Private Chart1 As New ChartControl
    Private ct As New ChartTitle()
    Private numrows As Integer = 15

    Private Sub Graph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxEditReports.SelectedIndex = 0
        TextEditNumRows.Text = "15"
        sumfield = "taincome"
        groupfield = "taanl1"
        RadioGroupTopBottom.SelectedIndex = 0
        seq = "DESC"
        Reports()
    End Sub
    Private Sub Reports()
        qrystr = ""
        If Not IsNothing(ComboBoxEditReports.SelectedItem) AndAlso GRRSAnal.ComboBoxWeek.SelectedItem.ToString <> "" _
            AndAlso Not IsNothing(TextEditNumRows.Text) AndAlso TextEditNumRows.Text <> "" _
            AndAlso RadioGroupTopBottom.SelectedIndex <> -1 Then

            LabelControlYWP.Text = GRRSAnal.ComboBoxWeek.SelectedItem.ToString
            numrows = CInt(TextEditNumRows.Text)
            Chart1.Titles.Remove(ct)
            If Chart1.Series.Count > 0 Then
                Chart1.Series.RemoveAt(0)
            End If
            If ComboBoxEditReports.SelectedItem = "Income by Customer Grouping" Then
                qrystr = "select sum(TAINCOME) as TINCOME, TAANL1 as TANL1  from  TRNANL where tarout <> '    '  "
                sumfield = "taincome"
                groupfield = "taanl1"
                series1 = New Series("Cst.Grp.Income", ViewType.Bar)
                Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ElseIf ComboBoxEditReports.SelectedItem = "Profit by Customer Grouping" Then
                qrystr = "select sum(TAPROFIT) as TPROFIT, TAANL1 as TANL1  from  TRNANL where tarout <> '    '  "
                sumfield = "taprofit"
                groupfield = "taanl1"
                series1 = New Series("Cst.Grp.Profit", ViewType.Bar)
                Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ElseIf ComboBoxEditReports.SelectedItem = "Income by Drop Point" Then
                qrystr = "select sum(TAINCOME) as TINCOME, TANAMA as TNAMA  from  TRNANL where tarout <> '    '  "
                sumfield = "taincome"
                groupfield = "tanama"
                series1 = New Series("Drp.Income", ViewType.Bar)
                Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ElseIf ComboBoxEditReports.SelectedItem = "Profit by Drop Point" Then
                qrystr = "select sum(TAPROFIT) as TPROFIT, TANAMA as TNAMA  from  TRNANL where tarout <> '    '  "
                sumfield = "taprofit"
                groupfield = "tanama"
                series1 = New Series("Drp.Profit", ViewType.Bar)
                Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ElseIf ComboBoxEditReports.SelectedItem = "Income by Fleet Type" Then
                qrystr = "select sum(TAINCOME) as TINCOME, TAFLTTYPE as TFLTTYPE  from  TRNANL where tarout <> '    '  "
                sumfield = "taincome"
                groupfield = "taflttype"
                series1 = New Series("Flt.Income", ViewType.Pie)
                Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
            ElseIf ComboBoxEditReports.SelectedItem = "Profit by Fleet Type" Then
                qrystr = "select sum(TAPROFIT) as TPROFIT, TAFLTTYPE as TFLTTYPE  from  TRNANL where tarout <> '    '  "
                sumfield = "taprofit"
                groupfield = "taflttype"
                series1 = New Series("Flt.Profit", ViewType.Bar)
                Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ElseIf ComboBoxEditReports.SelectedItem = "Income by Account" Then
                qrystr = "select sum(TAINCOME) as TINCOME, TANAME as TNAME  from  TRNANL where tarout <> '    '  "
                sumfield = "taincome"
                groupfield = "taname"
                series1 = New Series("Acc.Income", ViewType.Bar)
                Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ElseIf ComboBoxEditReports.SelectedItem = "Profit by Account" Then
                qrystr = "select sum(TAPROFIT) as TPROFIT, TANAME as TNAME  from  TRNANL where tarout <> '    '  "
                sumfield = "taprofit"
                groupfield = "taname"
                series1 = New Series("Acc.Profit", ViewType.Bar)
                Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ElseIf ComboBoxEditReports.SelectedItem = "Income by Home Depot" Then
                qrystr = "select sum(TAINCOME) as TINCOME, TAACCDEPD as TACCDEPD  from  TRNANL where tarout <> '    '  "
                sumfield = "taincome"
                groupfield = "taaccdepd"
                series1 = New Series("HDep.Income", ViewType.Pie)
                Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
            ElseIf ComboBoxEditReports.SelectedItem = "Profit by Home Depot" Then
                qrystr = "select sum(TAPROFIT) as TPROFIT, TAACCDEPD as TACCDEPD  from  TRNANL where tarout <> '    '  "
                sumfield = "taprofit"
                groupfield = "taaccdepd"
                series1 = New Series("HDep.Profit", ViewType.Bar)
                Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ElseIf ComboBoxEditReports.SelectedItem = "Income by Unit" Then
                qrystr = "select sum(TAINCOME) as TINCOME, TAUNIT as TAUNIT  from  TRNANL where tarout <> '    '  "
                sumfield = "taincome"
                groupfield = "taunit"
                series1 = New Series("Unit.Income", ViewType.Pie)
                Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
            ElseIf ComboBoxEditReports.SelectedItem = "Profit by Unit" Then
                qrystr = "select sum(TAPROFIT) as TPROFIT, TAUNIT as TAUNIT  from  TRNANL where tarout <> '    '  "
                sumfield = "taprofit"
                groupfield = "taunit"
                series1 = New Series("Unit.Profit", ViewType.Bar)
                Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ElseIf ComboBoxEditReports.SelectedItem = "Income by Driver" Then
                qrystr = "select sum(TAINCOME) as TINCOME, TADRVR as TDRVR  from  TRNANL where tarout <> '    '  "
                sumfield = "taincome"
                groupfield = "tadrvr"
                series1 = New Series("Drv.Income", ViewType.Pie)
                Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
            ElseIf ComboBoxEditReports.SelectedItem = "Income by Driver" Then
                qrystr = "select sum(TAINCOME) as TINCOME, TADRVR as TDRVR  from  TRNANL where tarout <> '    '  "
                sumfield = "taincome"
                groupfield = "tadrvr"
                series1 = New Series("Drv.Profit", ViewType.Bar)
                Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ElseIf ComboBoxEditReports.SelectedItem = "Income by Zone" Then
                qrystr = "select sum(TAINCOME) as TINCOME, " +
                " (select cddsc2 from CODES where max(TANZONE) = CDCODE and CDKEY = 'ZONE') as TNZONE " +
                " from  TRNANL where tarout <> '    '  "
                sumfield = "taincome"
                groupfield = "tanzone"
                series1 = New Series("Zone.Income", ViewType.Pie)
                Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
            ElseIf ComboBoxEditReports.SelectedItem = "Profit by Zone" Then
                qrystr = "select sum(TAPROFIT) as TPROFIT, " +
                " (select cddsc2 from CODES where max(TANZONE) = CDCODE and CDKEY = 'ZONE') as TNZONE " +
                " from  TRNANL where tarout <> '    '  "
                sumfield = "taprofit"
                groupfield = "tanzone"
                series1 = New Series("Zone.Profit", ViewType.Bar)
                Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ElseIf ComboBoxEditReports.SelectedItem = "Income by Vendor Managed Grouping" Then
                qrystr = "select sum(TAINCOME) as TINCOME, TAANL6 as TAANAL6  from  TRNANL where tarout <> '    '  "
                sumfield = "taincome"
                groupfield = "taanl6"
                series1 = New Series("VM.Grp.Income", ViewType.Pie)
                Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
            ElseIf ComboBoxEditReports.SelectedItem = "Profit by Vendor Managed Grouping" Then
                qrystr = "select sum(TAPROFIT) as TPROFIT, TAANL6 as TAANAL6  from  TRNANL where tarout <> '    '  "
                sumfield = "taprofit"
                groupfield = "taanl6"
                series1 = New Series("VM.Grp.Profit", ViewType.Bar)
                Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
                ''ElseIf ComboBoxEditReports.SelectedItem = "Calc Rate by Account and Drop" Then
                ''    qrystr = "select TAMANA as TNAMA, TRATE  from  TRNANL where tarout <> '    '  "
                ''    sumfield = ""
                ''    groupfield = ""
                ''    series1 = New Series("Rate.Trend", ViewType.Line)
                ''    Chart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            End If

            If GRRSAnal.CheckBoxPeriod.Checked = True Then
                qrystr = qrystr.Trim + " and tayr = " + GRRSAnal.ComboBoxWeek.SelectedItem.ToString.Substring(0, 2) +
                                       " and taper = " + GRRSAnal.ComboBoxWeek.SelectedItem.ToString.Substring(23, 2)
            Else
                qrystr = qrystr.Trim + " and tayr = " + GRRSAnal.ComboBoxWeek.SelectedItem.ToString.Substring(0, 2) +
                                       " and tawk = " + GRRSAnal.ComboBoxWeek.SelectedItem.ToString.Substring(3, 2)
            End If
            qrystr = Trim(qrystr) + " group by " + groupfield.Trim + " order by SUM(" + sumfield.Trim + ") " + seq.Trim + " FETCH FIRST " + numrows.ToString + " ROW ONLY"
            cmd.CommandType = ADODB.CommandTypeEnum.adCmdText
            cmd.ActiveConnection = GRRSAnal.con
            cmd.CommandText = qrystr
            Try
                rs.Open(cmd)
                dt = GRRSAnal.recordSetToDataTable(rs)
            Catch ex As Exception
                Dim debugstring = ex.ToString
            End Try
            Try
                rs.Close()
            Catch ex As Exception
            End Try

            For Each r As DataRow In dt.Rows
                If r.RowState <> DataRowState.Deleted Then
                    Try
                        series1.LegendTextPattern = String.Empty
                        series1.Points.Add(New SeriesPoint(r.Item(1), CInt(r.Item(0))))
                    Catch ex As Exception
                        Dim debugstr As String = ex.ToString
                    End Try
                End If
            Next
            series1.Label.TextPattern = "{A}: {VP:p0}"
            Chart1.Series.Add(series1)

            ct.Text = ComboBoxEditReports.SelectedItem
            Chart1.Titles.Add(ct)
            Chart1.Dock = DockStyle.Fill

            Me.Controls.Add(Chart1)
        End If

    End Sub

    Private Sub ComboBoxEditReports_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEditReports.SelectedIndexChanged
        Reports()
    End Sub
    Private Sub TextEditNumRows_EditValueChanged(sender As Object, e As EventArgs) Handles TextEditNumRows.EditValueChanged
        Reports()
    End Sub

    Private Sub RadioGroupTopBottom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroupTopBottom.SelectedIndexChanged

        Dim Edit As RadioGroup = CType(sender, RadioGroup)
        If (Edit.SelectedIndex = 0) Then
            seq = "DESC"
        Else
            seq = ""
        End If
        Reports()
    End Sub
End Class