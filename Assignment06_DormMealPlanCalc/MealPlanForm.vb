Public Class MealPlanForm
    Public intMealSelected As Integer
    Public frmMainForm As New MainForm

    Private Sub btnAddMealPlan_Click(sender As Object, e As EventArgs) Handles btnAddMealPlan.Click

        ' Meal plan selection
        If lstMealPlan.SelectedIndex = -1 Then
            MessageBox.Show("Please select a meal plan!")
        End If

        If lstMealPlan.SelectedIndex = 0 Then
            g_MealSubtotal = g_intMEAL_7
            lblMealStatus.Text = "You have selected the 7 Meals plan"
        ElseIf lstMealPlan.SelectedIndex = 1 Then
            g_MealSubtotal = g_intMEAL_14
            lblMealStatus.Text = "You have selected the 14 Meals plan"
        ElseIf lstMealPlan.SelectedIndex = 2 Then
            g_MealSubtotal = g_intMEAL_UNLIMITED
            lblMealStatus.Text = "You have selected the Unlimited Meals plan"
        End If




    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class