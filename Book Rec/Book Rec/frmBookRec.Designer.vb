<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookRec
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
        Me.lstReaders = New System.Windows.Forms.ListBox()
        Me.lstBooks = New System.Windows.Forms.ListBox()
        Me.cmdMethA = New System.Windows.Forms.Button()
        Me.lstRecPerson = New System.Windows.Forms.ListBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.cmdMethB = New System.Windows.Forms.Button()
        Me.Book1 = New System.Windows.Forms.PictureBox()
        Me.Book2 = New System.Windows.Forms.PictureBox()
        Me.lblSimilar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Book3 = New System.Windows.Forms.PictureBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.cmdMethC = New System.Windows.Forms.Button()
        CType(Me.Book1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Book2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Book3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstReaders
        '
        Me.lstReaders.FormattingEnabled = True
        Me.lstReaders.ItemHeight = 18
        Me.lstReaders.Location = New System.Drawing.Point(16, 43)
        Me.lstReaders.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstReaders.Name = "lstReaders"
        Me.lstReaders.Size = New System.Drawing.Size(1095, 130)
        Me.lstReaders.TabIndex = 0
        '
        'lstBooks
        '
        Me.lstBooks.FormattingEnabled = True
        Me.lstBooks.ItemHeight = 18
        Me.lstBooks.Location = New System.Drawing.Point(16, 194)
        Me.lstBooks.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstBooks.Name = "lstBooks"
        Me.lstBooks.Size = New System.Drawing.Size(504, 130)
        Me.lstBooks.TabIndex = 2
        '
        'cmdMethA
        '
        Me.cmdMethA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdMethA.Location = New System.Drawing.Point(16, 430)
        Me.cmdMethA.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdMethA.Name = "cmdMethA"
        Me.cmdMethA.Size = New System.Drawing.Size(201, 77)
        Me.cmdMethA.TabIndex = 4
        Me.cmdMethA.Text = "Method A"
        Me.cmdMethA.UseVisualStyleBackColor = False
        '
        'lstRecPerson
        '
        Me.lstRecPerson.FormattingEnabled = True
        Me.lstRecPerson.ItemHeight = 18
        Me.lstRecPerson.Location = New System.Drawing.Point(317, 421)
        Me.lstRecPerson.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstRecPerson.Name = "lstRecPerson"
        Me.lstRecPerson.Size = New System.Drawing.Size(178, 274)
        Me.lstRecPerson.TabIndex = 5
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(199, 351)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(33, 20)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "    "
        '
        'cmdMethB
        '
        Me.cmdMethB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdMethB.Location = New System.Drawing.Point(16, 523)
        Me.cmdMethB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdMethB.Name = "cmdMethB"
        Me.cmdMethB.Size = New System.Drawing.Size(201, 83)
        Me.cmdMethB.TabIndex = 7
        Me.cmdMethB.Text = "Method B"
        Me.cmdMethB.UseVisualStyleBackColor = False
        '
        'Book1
        '
        Me.Book1.Location = New System.Drawing.Point(503, 390)
        Me.Book1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Book1.Name = "Book1"
        Me.Book1.Size = New System.Drawing.Size(225, 305)
        Me.Book1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Book1.TabIndex = 8
        Me.Book1.TabStop = False
        '
        'Book2
        '
        Me.Book2.Location = New System.Drawing.Point(736, 390)
        Me.Book2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Book2.Name = "Book2"
        Me.Book2.Size = New System.Drawing.Size(242, 305)
        Me.Book2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Book2.TabIndex = 9
        Me.Book2.TabStop = False
        '
        'lblSimilar
        '
        Me.lblSimilar.AutoSize = True
        Me.lblSimilar.Location = New System.Drawing.Point(199, 392)
        Me.lblSimilar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSimilar.Name = "lblSimilar"
        Me.lblSimilar.Size = New System.Drawing.Size(33, 20)
        Me.lblSimilar.TabIndex = 10
        Me.lblSimilar.Text = "    "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 351)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Recommending For:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 392)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Most Similar Person:"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Readers and Ratings"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 171)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Books"
        '
        'Book3
        '
        Me.Book3.Location = New System.Drawing.Point(986, 390)
        Me.Book3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Book3.Name = "Book3"
        Me.Book3.Size = New System.Drawing.Size(231, 305)
        Me.Book3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Book3.TabIndex = 15
        Me.Book3.TabStop = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(33, 648)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 20)
        Me.lblScore.TabIndex = 16
        '
        'cmdMethC
        '
        Me.cmdMethC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdMethC.ForeColor = System.Drawing.Color.OrangeRed
        Me.cmdMethC.Location = New System.Drawing.Point(16, 619)
        Me.cmdMethC.Name = "cmdMethC"
        Me.cmdMethC.Size = New System.Drawing.Size(201, 76)
        Me.cmdMethC.TabIndex = 17
        Me.cmdMethC.Text = "Method C"
        Me.cmdMethC.UseVisualStyleBackColor = False
        '
        'frmBookRec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1256, 722)
        Me.Controls.Add(Me.cmdMethC)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Book3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSimilar)
        Me.Controls.Add(Me.Book2)
        Me.Controls.Add(Me.Book1)
        Me.Controls.Add(Me.cmdMethB)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lstRecPerson)
        Me.Controls.Add(Me.cmdMethA)
        Me.Controls.Add(Me.lstBooks)
        Me.Controls.Add(Me.lstReaders)
        Me.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.OrangeRed
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmBookRec"
        Me.Text = " "
        CType(Me.Book1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Book2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Book3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstReaders As ListBox
    Friend WithEvents lstBooks As ListBox
    Friend WithEvents cmdMethA As Button
    Friend WithEvents lstRecPerson As ListBox
    Friend WithEvents lblName As Label
    Friend WithEvents cmdMethB As Button
    Friend WithEvents Book1 As PictureBox
    Friend WithEvents Book2 As PictureBox
    Friend WithEvents lblSimilar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Book3 As PictureBox
    Friend WithEvents lblScore As Label
    Friend WithEvents cmdMethC As Button
End Class
