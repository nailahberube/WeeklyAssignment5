Public Class frmComic
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intGroup As Integer = 0
        Dim decRegistration As Decimal
        Dim decTotalCost As Decimal
        Dim decSuperHero As Decimal = 380D
        Dim decAutographs As Decimal = 275D
        Dim decConvection As Decimal = 209D

        'Did user enter numeric value
        If IsNumeric(txtGroupSize.Text) Then
            intGroup = Convert.ToInt32(txtGroupSize.Text)
            'Is number of group greater than zero 
            If intGroup > 0 And intGroup < 20 Then
                If radSuperheroExperience.Checked Then
                    decRegistration = decSuperHero
                ElseIf radAutographs.Checked Then
                    decRegistration = decAutographs
                ElseIf radConvention.Checked Then
                    decRegistration = decConvection
                End If
                decTotalCost = (intGroup * decRegistration)
                lblLabelCostEstimate.Text = decTotalCost.ToString("C")
            Else
                'Display error message if user entered a negative number 
                MsgBox("Enter a positive number between 1 and 20",, "Invalid Number Error")
            End If
        Else
            'Display error message if user entered a negative number 
            MsgBox("Enter a reasonable number between 1 and 20",, "Invalid Entry Error")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGroupSize.Clear()
        lblLabelCostEstimate.Text = ""
        radSuperheroExperience.Checked = True
        radAutographs.Checked = False
        radConvention.Checked = False
        txtGroupSize.Focus()

    End Sub

    Private Sub frmComic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear out the cost estimate and set focus 
        txtGroupSize.Focus()
        lblLabelCostEstimate.Text = ""

    End Sub
End Class
