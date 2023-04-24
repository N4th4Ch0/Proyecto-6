<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class evaluacion
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
        GroupCali = New GroupBox()
        cbbCali = New ComboBox()
        lblMensaje = New Label()
        cmdResultado = New Button()
        lblResultado = New Label()
        GroupCali.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupCali
        ' 
        GroupCali.Controls.Add(cbbCali)
        GroupCali.Controls.Add(lblMensaje)
        GroupCali.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GroupCali.Location = New Point(244, 103)
        GroupCali.Name = "GroupCali"
        GroupCali.Size = New Size(273, 110)
        GroupCali.TabIndex = 0
        GroupCali.TabStop = False
        GroupCali.Text = "Calificacion"
        ' 
        ' cbbCali
        ' 
        cbbCali.FormattingEnabled = True
        cbbCali.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        cbbCali.Location = New Point(112, 38)
        cbbCali.Name = "cbbCali"
        cbbCali.Size = New Size(121, 29)
        cbbCali.TabIndex = 2
        cbbCali.Text = "0"
        ' 
        ' lblMensaje
        ' 
        lblMensaje.AutoSize = True
        lblMensaje.Font = New Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblMensaje.Location = New Point(6, 38)
        lblMensaje.Name = "lblMensaje"
        lblMensaje.Size = New Size(100, 25)
        lblMensaje.TabIndex = 1
        lblMensaje.Text = "Calificaciones"
        ' 
        ' cmdResultado
        ' 
        cmdResultado.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cmdResultado.Location = New Point(356, 257)
        cmdResultado.Name = "cmdResultado"
        cmdResultado.Size = New Size(112, 39)
        cmdResultado.TabIndex = 1
        cmdResultado.Text = "Resultado"
        cmdResultado.UseVisualStyleBackColor = True
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblResultado.Location = New Point(356, 318)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(0, 21)
        lblResultado.TabIndex = 2
        lblResultado.TextAlign = ContentAlignment.TopCenter
        ' 
        ' evaluacion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResultado)
        Controls.Add(cmdResultado)
        Controls.Add(GroupCali)
        Name = "evaluacion"
        Text = "Form1"
        GroupCali.ResumeLayout(False)
        GroupCali.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupCali As GroupBox
    Friend WithEvents lblMensaje As Label
    Friend WithEvents cbbCali As ComboBox
    Friend WithEvents cmdResultado As Button
    Friend WithEvents lblResultado As Label
End Class
