Public Class MainForm
    ' Variables
    Public intDormCost As Integer

    ' Display Total Cost
    Sub OutputCost()
        ' Display Dorm Cost
        lblDormCost.Text = intDormCost.ToString("c")
        ' Display Meal Cost
        lblMealPlanCost.Text = g_MealSubtotal.ToString("c")
        ' Calc subtotal
        g_total = g_MealSubtotal + intDormCost
        ' Display subtotal
        lblTotal.Text = g_total.ToString("c")
    End Sub

    Private Sub btnAddDorm_Click(sender As Object, e As EventArgs) Handles btnAddDorm.Click
        ' Dorm Selection
        ' If user did not select a dormitory
        If lstDormitory.SelectedIndex = -1 Then
            lblStatus.Text = "Please Select a Dormitory"
        End If

        ' Determine the dormitory the user selected
        If lstDormitory.SelectedIndex = 0 Then
            intDormCost = g_intDORM__ALLEN_HALL
            lblStatus.Text = "You have selected Allen Hall. Congratulation!"
        ElseIf lstDormitory.SelectedIndex = 1 Then
            intDormCost = g_intDORM__PIKE_HALL
            lblStatus.Text = "You have selected Pike Hall. Congratulation!"
        ElseIf lstDormitory.SelectedIndex = 2 Then
            intDormCost = g_intDORM__FARTHING_HALL
            lblStatus.Text = "You have selected Farthing Hall. Congratulation!"
        ElseIf lstDormitory.SelectedIndex = 3 Then
            intDormCost = g_intDORM__UNI_SUITES
            lblStatus.Text = "You have selected University Suits. Congratulation!"
        End If

        ' Display Cost of Dormitory
        OutputCost()



    End Sub

    Private Sub btnViewMealPlan_Click(sender As Object, e As EventArgs) Handles btnViewMealPlan.Click
        ' Create an instance of the Meal Plan Form
        Dim frmMealPlan As New MealPlanForm

        ' Display the form in modal style
        frmMealPlan.ShowDialog()

        ' display output cost of meals and dorms with total cost
        OutputCost()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblDormCost.Text = String.Empty
        lblMealPlanCost.Text = String.Empty
        lblTotal.Text = String.Empty
        lblStatus.Text = String.Empty
    End Sub
End Class
