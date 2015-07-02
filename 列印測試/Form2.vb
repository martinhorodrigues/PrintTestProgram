Imports System
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class Form2

    Private WithEvents printPreviewButton As Button

    Private printPreviewDialog1 As New PrintPreviewDialog()
    Private printDialog1 As New PrintDialog()
    Private WithEvents printDocument1 As New PrintDocument()

    ' Declare a string to hold the entire document contents.
    Private documentContents As String

    ' Declare a variable to hold the portion of the document that
    ' is not printed.
    Private stringToPrint As String

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New()
        Me.printPreviewButton = New System.Windows.Forms.Button()
        Me.printPreviewButton.Location = New System.Drawing.Point(12, 12)
        Me.printPreviewButton.Size = New System.Drawing.Size(125, 23)
        Me.printPreviewButton.Text = "Print Preview"
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.printPreviewButton)

    End Sub

    Private Sub ReadDocument()
        Dim docName As String = "map-桃園監理站MAP.txt"
        Dim docPath As String = "d:\"
        printDocument1.DocumentName = docName
        Dim stream As New FileStream(docPath + docName, FileMode.Open)
        Try
            Dim reader As New StreamReader(stream)
            Try
                documentContents = reader.ReadToEnd()
            Finally
                reader.Dispose()
            End Try
        Finally
            stream.Dispose()
        End Try
        stringToPrint = documentContents

    End Sub

    Sub printDocument1_PrintPage(ByVal sender As Object, _
        ByVal e As PrintPageEventArgs) Handles printDocument1.PrintPage

        Dim charactersOnPage As Integer = 0
        Dim linesPerPage As Integer = 0

        ' Sets the value of charactersOnPage to the number of characters 
        ' of stringToPrint that will fit within the bounds of the page.
        e.Graphics.MeasureString(stringToPrint, Me.Font, e.MarginBounds.Size, _
            StringFormat.GenericTypographic, charactersOnPage, linesPerPage)

        ' Draws the string within the bounds of the page.
        e.Graphics.DrawString(stringToPrint, Me.Font, Brushes.Black, _
            e.MarginBounds, StringFormat.GenericTypographic)

        ' Remove the portion of the string that has been printed.
        stringToPrint = stringToPrint.Substring(charactersOnPage)

        ' Check to see if more pages are to be printed.
        e.HasMorePages = stringToPrint.Length > 0

        ' If there are no more pages, reset the string to be printed.
        If Not e.HasMorePages Then
            stringToPrint = documentContents
        End If

    End Sub

    Private Sub printPreviewButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles printPreviewButton.Click

        ReadDocument()
        'printPreviewDialog1.Document = printDocument1
        'printPreviewDialog1.ShowDialog()

        printDialog1.Document = printDocument1
        printDialog1.ShowDialog()
    End Sub

    <STAThread()> _
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form1())

    End Sub

End Class