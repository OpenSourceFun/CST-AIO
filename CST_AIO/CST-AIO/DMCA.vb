Imports Microsoft.Office.Interop
Imports System.Xml




Public Class DMCA
    Dim Execute As Integer = 0
    Dim Form As Integer = 0

    Private Sub cmbSelectForm_Leave(sender As Object, e As EventArgs) Handles cmbSelectForm.Leave
        'Selects the document used throught he rest of the form.
        Form = 0
        Select Case cmbSelectForm.Text
            Case "DMCA (able to contact customer)"
                Form = 1
            Case "DMCA (No contact with customer)"
                Form = 2
            Case "2nd Offense (able to contact customer)"
                Form = 3
            Case "2nd Offense (No contact with customer)"
                Form = 4
            Case "3rd Offense (able to contact customer)"
                Form = 5
            Case "3rd Offense (No contact with customer)"
                Form = 6
            Case "CEGTEK"
                Form = 7
        End Select
    End Sub

    Private Sub btnDMCADocs_Click(sender As Object, e As EventArgs) Handles btnDMCADocs.Click
        'launch explorer to the S drive
        Process.Start("S:\CST_IR\Call_Center\DMCA_Docs")
    End Sub

    Private Sub btnDMCAsFolder_Click(sender As Object, e As EventArgs) Handles btnDMCAsFolder.Click
        'launch explorer to the S drive
        Process.Start("S:\CST_IR\Call_Center\DMCAs")
    End Sub

    Private Sub btnSavePrint_Click(sender As Object, e As EventArgs) Handles btnSavePrint.Click
        'Perform actions based on form selection
        Execute = 1
        Select Case Form

            Case Form = 1
                'DMCA (able to contact customer)
                FirstWithContact()


            Case Form = 2
                'DMCA (No contact with customer)

            Case Form = 3
                '2nd Offense (able to contact customer)

            Case Form = 4
                '2nd Offense (No contact with customer)

            Case Form = 5
                '3rd Offense (able to contact customer)

            Case Form = 6
                '3rd Offense (No contact with customer)

            Case Form = 7
                'CEGTEK

        End Select
    End Sub

    Private Sub FirstWithContact(execute As Integer)
        Throw New NotImplementedException()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'close form
        Me.Close()
    End Sub

    Function FirstWithContact()
        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Dim oTable As Word.Table
        Dim oPara1 As Word.Paragraph, oPara2 As Word.Paragraph
        Dim oPara3 As Word.Paragraph, oPara4 As Word.Paragraph
        Dim oRng As Word.Range
        Dim oShape As Word.InlineShape
        Dim oChart As Object
        Dim Pos As Double

        'Start Word and open the document template.
        oWord = CreateObject("Word.Application")
        oWord.Visible = True
        oDoc = oWord.Documents.Add

        'Insert a paragraph at the beginning of the document.
        oPara1 = oDoc.Content.Paragraphs.Add
        oPara1.Range.Text = "Heading 1"
        oPara1.Range.Font.Bold = True
        oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
        oPara1.Range.InsertParagraphAfter()

        'Insert a paragraph at the end of the document.
        '** \endofdoc is a predefined bookmark.
        oPara2 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara2.Range.Text = "Heading 2"
        oPara2.Format.SpaceAfter = 6
        oPara2.Range.InsertParagraphAfter()

        'Insert another paragraph.
        oPara3 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara3.Range.Text = "This is a sentence of normal text. Now here is a table:"
        oPara3.Range.Font.Bold = False
        oPara3.Format.SpaceAfter = 24
        oPara3.Range.InsertParagraphAfter()

        'Insert a 3 x 5 table, fill it with data, and make the first row
        'bold and italic.
        Dim r As Integer, c As Integer
        oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 3, 5)
        oTable.Range.ParagraphFormat.SpaceAfter = 6
        For r = 1 To 3
            For c = 1 To 5
                oTable.Cell(r, c).Range.Text = "r" & r & "c" & c
            Next
        Next
        oTable.Rows.Item(1).Range.Font.Bold = True
        oTable.Rows.Item(1).Range.Font.Italic = True

        'Add some text after the table.
        'oTable.Range.InsertParagraphAfter()
        oPara4 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara4.Range.InsertParagraphBefore()
        oPara4.Range.Text = "And here's another table:"
        oPara4.Format.SpaceAfter = 24
        oPara4.Range.InsertParagraphAfter()

        'Insert a 5 x 2 table, fill it with data, and change the column widths.
        oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 5, 2)
        oTable.Range.ParagraphFormat.SpaceAfter = 6
        For r = 1 To 5
            For c = 1 To 2
                oTable.Cell(r, c).Range.Text = "r" & r & "c" & c
            Next
        Next
        oTable.Columns.Item(1).Width = oWord.InchesToPoints(2)   'Change width of columns 1 & 2
        oTable.Columns.Item(2).Width = oWord.InchesToPoints(3)

        'Keep inserting text. When you get to 7 inches from top of the
        'document, insert a hard page break.
        Pos = oWord.InchesToPoints(7)
        oDoc.Bookmarks.Item("\endofdoc").Range.InsertParagraphAfter()
        Do
            oRng = oDoc.Bookmarks.Item("\endofdoc").Range
            oRng.ParagraphFormat.SpaceAfter = 6
            oRng.InsertAfter("A line of text")
            oRng.InsertParagraphAfter()
        Loop While Pos >= oRng.Information(Word.WdInformation.wdVerticalPositionRelativeToPage)
        oRng.Collapse(Word.WdCollapseDirection.wdCollapseEnd)
        oRng.InsertBreak(Word.WdBreakType.wdPageBreak)
        oRng.Collapse(Word.WdCollapseDirection.wdCollapseEnd)
        oRng.InsertAfter("We're now on page 2. Here's my chart:")
        oRng.InsertParagraphAfter()

        'Insert a chart and change the chart.
        oShape = oDoc.Bookmarks.Item("\endofdoc").Range.InlineShapes.AddOLEObject(
            ClassType:="MSGraph.Chart.8", FileName _
            :="", LinkToFile:=False, DisplayAsIcon:=False)
        oChart = oShape.OLEFormat.Object
        oChart.charttype = 4 'xlLine = 4
        oChart.Application.Update()
        oChart.Application.Quit()
        'If desired, you can proceed from here using the Microsoft Graph 
        'Object model on the oChart object to make additional changes to the
        'chart.
        oShape.Width = oWord.InchesToPoints(6.25)
        oShape.Height = oWord.InchesToPoints(3.57)

        'Add text after the chart.
        oRng = oDoc.Bookmarks.Item("\endofdoc").Range
        oRng.InsertParagraphAfter()
        oRng.InsertAfter("THE END.")

        Execute = 0
    End Function

End Class


