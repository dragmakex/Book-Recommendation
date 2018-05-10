Public Class frmBookRec

    Private Sub frmBookRec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim PO As Integer
        Dim StrLine As String

        RL.Fill()
        BL.Fill()

        For PO = 0 To 85    'Filling all readers and ratings list and arrays
            StrLine = ""
            For J = 0 To 55
                StrLine = StrLine + Trim((RL.Readers(PO).Ratings(J))) + " "
            Next J
            lstReaders.Items.Add(RL.Readers(PO).Name)
            lstReaders.Items.Add(StrLine)
        Next PO

        For J = 0 To 54 'Filling all books and authors list and arrays
            StrLine = BL.Books(J).Name + " - " + BL.Books(J).Author
            lstBooks.Items.Add(StrLine)
        Next J

        'method c is creating an array of similar values for ?
        'do what you did in method A and multiply it by similar ratings
    End Sub

    Private Sub cmdMethA_Click(sender As Object, e As EventArgs) Handles cmdMethA.Click
        Method.A()
        '7
    End Sub

    Private Sub cmdMethB_Click(sender As Object, e As EventArgs) Handles cmdMethB.Click
        Method.B()
    End Sub

    Private Sub cmdMethC_Click(sender As Object, e As EventArgs) Handles cmdMethC.Click
        Method.C()
    End Sub
End Class
