<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MealPlanForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstMealPlan = New System.Windows.Forms.ListBox()
        Me.btnAddMealPlan = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblMealStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstMealPlan)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 160)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Weekly Meal Plan"
        '
        'lstMealPlan
        '
        Me.lstMealPlan.FormattingEnabled = True
        Me.lstMealPlan.Items.AddRange(New Object() {"7 Meals - $1,560.00", "14 Meals - $2,095.00", "Unlimited Meals - $2,500.00"})
        Me.lstMealPlan.Location = New System.Drawing.Point(11, 30)
        Me.lstMealPlan.Name = "lstMealPlan"
        Me.lstMealPlan.Size = New System.Drawing.Size(321, 95)
        Me.lstMealPlan.TabIndex = 0
        '
        'btnAddMealPlan
        '
        Me.btnAddMealPlan.Location = New System.Drawing.Point(375, 24)
        Me.btnAddMealPlan.Name = "btnAddMealPlan"
        Me.btnAddMealPlan.Size = New System.Drawing.Size(141, 55)
        Me.btnAddMealPlan.TabIndex = 1
        Me.btnAddMealPlan.Text = "Add Meal Plan"
        Me.btnAddMealPlan.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(375, 117)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(141, 55)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus, Me.lblMealStatus})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 188)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(528, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'lblMealStatus
        '
        Me.lblMealStatus.Name = "lblMealStatus"
        Me.lblMealStatus.Size = New System.Drawing.Size(0, 17)
        '
        'MealPlanForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 210)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddMealPlan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MealPlanForm"
        Me.Text = "MealPlanForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstMealPlan As ListBox
    Friend WithEvents btnAddMealPlan As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents lblMealStatus As ToolStripStatusLabel
End Class
