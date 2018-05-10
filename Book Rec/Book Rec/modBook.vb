Module modBook
    Public RL As ReaderList
    Public BL As BookList
    Public Method As Meth
    Public I As Integer
    Public J As Integer
    Public Path As String

    Structure Reader
        Dim Name As String
        Dim Ratings() As Integer
    End Structure

    Structure ReaderList
        Dim Readers() As Reader

        Sub Fill()
            ReDim Readers(85)
            Dim StrLine As String
            Dim StrLine2 As String
            Dim TC As Integer
            Dim K As Integer
            Dim U As Integer

            Path = "F:\Locker\Files\Projects\CP II\VB.NET\Library\Book Rec\Resources\readerratings.txt"
            TC = 0
            K = 1

            For I = 0 To 85
                ReDim Readers(I).Ratings(55)
            Next I

            FileOpen(1, Path, OpenMode.Input, OpenAccess.Read)
            Do While Not EOF(1)
                StrLine = LineInput(1)
                Readers(TC).Name = StrLine
                StrLine2 = LineInput(1)   'Filling multiple lines at once

                For U = 0 To 55
                    If Trim(Mid(StrLine2, K, 2)) = "-" Then
                        K = K + 1
                    End If
                    If U = 55 Then
                        Exit For
                    End If
                    Readers(TC).Ratings(U) = Trim(Mid(StrLine2, K, 2))
                    K = K + 2
                Next U
                K = 1
                TC = TC + 1
            Loop
            FileClose(1)
        End Sub
    End Structure

    Structure Book
        Dim Name As String
        Dim Author As String
    End Structure

    Structure BookList
        Dim Books() As Book

        Sub Fill()
            ReDim Books(55)
            Dim TC As Integer
            Dim StrLine As String
            Dim K As Integer

            Path = "F:\Locker\Files\Projects\CP II\VB.NET\Library\Book Rec\Resources\books.txt"
            TC = 0

            FileOpen(1, Path, OpenMode.Input, OpenAccess.Read)
            Do While Not EOF(1)
                StrLine = LineInput(1)

                For I = 1 To Len(StrLine)
                    If Mid(StrLine, I, 1) = "," Then
                        K = I + 1
                        Exit For
                    End If
                Next I
                Books(TC).Author = Mid(StrLine, 1, (K - 2))
                Books(TC).Name = Mid(StrLine, K, Len(StrLine))
                K = 0
                TC = TC + 1
            Loop
            FileClose(1)
        End Sub
    End Structure

    Structure Total
        Dim Name As String
        Dim Score As Single
        Dim Index As Integer
    End Structure

    Structure Meth
        Sub A()
            frmBookRec.lblScore.Text = ""
            Dim Index As Integer
            Dim U As Integer
            Dim H As Integer
            Dim Total(55) As Total
            Dim S As Integer
            Dim Count As Integer
            Dim Temp As Total

            Index = frmBookRec.lstReaders.SelectedIndex - (frmBookRec.lstReaders.SelectedIndex / 2)
            frmBookRec.lblName.Text = RL.Readers(Index).Name
            frmBookRec.lstRecPerson.Items.Clear()
            frmBookRec.Label2.Visible = False
            frmBookRec.lblSimilar.Text = "    "
            frmBookRec.Book2.Image = Nothing
            frmBookRec.Book3.Image = Nothing

            For J = 0 To 54
                For I = 0 To 85
                    S = S + RL.Readers(I).Ratings(J)
                    If RL.Readers(I).Ratings(J) <> 0 Then
                        Count = Count + 1
                    End If
                Next I
                Total(J).Score = S / Count
                'frmBookRec.lblScore.Text = Total(J).Score
                Total(J).Name = BL.Books(J).Name
                Total(J).Index = J
                S = 0
                Count = 0
            Next J

            For U = 0 To 53
                For H = U + 1 To 54
                    If Total(U).Score > Total(H).Score Then
                        Temp.Score = Total(U).Score
                        Temp.Name = Total(U).Name
                        Temp.Index = Total(U).Index
                        Total(U).Score = Total(H).Score
                        Total(U).Name = Total(H).Name
                        Total(U).Index = Total(H).Index
                        Total(H).Score = Temp.Score
                        Total(H).Name = Temp.Name
                        Total(H).Index = Temp.Index
                    End If
                Next H
            Next U

            For J = 54 To 0 Step -1
                If RL.Readers(Index).Ratings(Total(J).Index) = 0 Then
                    frmBookRec.lstRecPerson.Items.Add(Total(J).Name)
                    frmBookRec.Book1.Image = Image.FromFile("F:\Locker\Files\Projects\CP II\VB.NET\Library\Book Rec\Resources\Book Titles\" + Total(J).Name + ".jpg")
                    Exit For
                End If
            Next J
        End Sub

        Sub B()
            Dim Index As Integer
            Dim SV As Integer
            Dim arrSV(86) As Integer
            Dim High As Integer
            Dim Pos As Integer
            Dim NumPic As Integer
            Dim BookPic(3) As String

            frmBookRec.Label2.Visible = True
            frmBookRec.lstRecPerson.Items.Clear()
            NumPic = 0

            Index = (frmBookRec.lstReaders.SelectedIndex) - (frmBookRec.lstReaders.SelectedIndex / 2)
            frmBookRec.lblName.Text = RL.Readers(Index).Name

            For J = 0 To 85
                For I = 0 To 54
                    If J <> Index Then
                        SV = SV + RL.Readers(Index).Ratings(I) * RL.Readers(J).Ratings(I)
                    Else
                        SV = 0
                    End If
                    arrSV(J) = SV
                Next I
                SV = 0
            Next J

            High = 0

            For J = 0 To 85
                If arrSV(J) > High Then
                    High = arrSV(J)
                    Pos = J
                End If
            Next J

            frmBookRec.lblSimilar.Text = RL.Readers(Pos).Name + " " + Str(High)

            For J = 0 To 54
                If RL.Readers(Pos).Ratings(J) = 5 Then
                    If RL.Readers(Index).Ratings(J) = 0 Then
                        frmBookRec.lstRecPerson.Items.Add(BL.Books(J).Name)
                        NumPic = NumPic + 1
                        If NumPic <= 3 And NumPic > 0 Then
                            BookPic(NumPic) = BL.Books(J).Name
                        End If
                        'frmBookRec.lstRecPerson.Items.Add("Hatchet")
                        'frmBookRec.lstRecPerson.Items.Add("Maus: A Survivor's Tale")
                    End If
                End If
            Next J

            If BookPic(1) <> "" Then
                frmBookRec.Book1.Image = Image.FromFile("F:\Locker\Files\Projects\CP II\VB.NET\Library\Book Rec\Resources\Book Titles\" + BookPic(1) + ".jpg")
            ElseIf BookPic(1) = "" Then
                frmBookRec.Book1.Image = Nothing
            End If

            If BookPic(2) <> "" Then
                frmBookRec.Book2.Image = Image.FromFile("F:\Locker\Files\Projects\CP II\VB.NET\Library\Book Rec\Resources\Book Titles\" + BookPic(2) + ".jpg")
            ElseIf BookPic(2) = "" Then
                frmBookRec.Book2.Image = Nothing
            End If

            If BookPic(3) <> "" Then
                frmBookRec.Book3.Image = Image.FromFile("F:\Locker\Files\Projects\CP II\VB.NET\Library\Book Rec\Resources\Book Titles\" + BookPic(3) + ".jpg")
            ElseIf BookPic(3) = "" Then
                frmBookRec.Book3.Image = Nothing
            End If
        End Sub

        Sub C()
            Dim Index As Integer
            Dim SV As Integer
            Dim arrSV(85) As Integer
            Dim High As Integer
            Dim Pos As Integer
            Dim Numpic As Integer
            Dim BookPic(3) As String
            Dim arrPop(85) As Integer

            For J = 0 To 85
                For I = 0 To 54
                    If J <> Index Then
                        SV = SV + RL.Readers(Index).Ratings(I) * RL.Readers(J).Ratings(I)
                    Else
                        SV = 0
                    End If
                Next I
                SV = 0
            Next J


            frmBookRec.lstRecPerson.Items.Clear()

            For I = 0 To 54
                arrPop(I) = 0
                For J = 0 To 85
                    arrPop(I) += modBook.RL.Readers(J).Ratings(I) * arrSV(J)

                Next
            Next

            For I = 0 To 54
                If modBook.RL.Readers(frmBookRec.lstReaders.SelectedIndex).Ratings(I) = 0 And arrPop(I) > 2000 Then
                    frmBookRec.lstRecPerson.Items.Add(modBook.BL.Books(I).Name & " " & modBook.BL.Books(I).Author)
                End If
            Next

        End Sub
    End Structure
End Module
