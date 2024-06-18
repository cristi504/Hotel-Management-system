<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        ContextMenuStrip2 = New ContextMenuStrip(components)
        IonToolStripMenuItem1 = New ToolStripMenuItem()
        EnigmaOtilieiToolStripMenuItem1 = New ToolStripMenuItem()
        Button4 = New Button()
        ContextMenuStrip2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(457, 670)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 46)
        Button1.TabIndex = 0
        Button1.Text = "Sign up"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(249, 670)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 46)
        Button2.TabIndex = 1
        Button2.Text = "Sign in"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(678, 670)
        Button3.Name = "Button3"
        Button3.Size = New Size(150, 55)
        Button3.TabIndex = 2
        Button3.Text = "Sterge cont"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Monotype Corsiva", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(238))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(38, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(417, 39)
        Label1.TabIndex = 3
        Label1.Text = "Bine ati venit la Hotelul nostru!"
        ' 
        ' ContextMenuStrip2
        ' 
        ContextMenuStrip2.ImageScalingSize = New Size(32, 32)
        ContextMenuStrip2.Items.AddRange(New ToolStripItem() {IonToolStripMenuItem1, EnigmaOtilieiToolStripMenuItem1})
        ContextMenuStrip2.Name = "ContextMenuStrip2"
        ContextMenuStrip2.Size = New Size(233, 80)
        ' 
        ' IonToolStripMenuItem1
        ' 
        IonToolStripMenuItem1.Name = "IonToolStripMenuItem1"
        IonToolStripMenuItem1.Size = New Size(232, 38)
        IonToolStripMenuItem1.Text = "camera dubla"
        ' 
        ' EnigmaOtilieiToolStripMenuItem1
        ' 
        EnigmaOtilieiToolStripMenuItem1.Name = "EnigmaOtilieiToolStripMenuItem1"
        EnigmaOtilieiToolStripMenuItem1.Size = New Size(232, 38)
        EnigmaOtilieiToolStripMenuItem1.Text = "camera tripla"
        ' 
        ' Button4
        ' 
        Button4.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button4.Font = New Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(408, 347)
        Button4.Name = "Button4"
        Button4.Size = New Size(275, 46)
        Button4.TabIndex = 4
        Button4.Text = "Rezerva o camera"
        Button4.UseVisualStyleBackColor = True
        Button4.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1115, 728)
        Controls.Add(Button4)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ContextMenuStrip2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents IonToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EnigmaOtilieiToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Button4 As Button

End Class
