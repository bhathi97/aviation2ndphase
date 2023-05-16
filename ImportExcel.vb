Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Excel
Imports OleDbConnection = System.Data.OleDb.OleDbConnection


Public Class ImportExcel



    Private Sub btnpath_Click(sender As Object, e As EventArgs) Handles btnpath.Click
        Try
            ' Create a new instance of the OpenFileDialog control.
            Dim openFileDialog1 As New OpenFileDialog()

            ' Set the default file extension filter and title.
            openFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*"
            openFileDialog1.Title = "Select an Excel File"

            ' Display the OpenFileDialog control and get the selected file's full path.
            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                ' Get the selected file path.
                Dim filePath As String = openFileDialog1.FileName

                ' Set the file path to the tbpath textbox.
                tbpath.Text = filePath
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub btnExcell_Click(sender As Object, e As EventArgs) Handles btnExcell.Click
        Try
            ' Check if a file has been selected
            If String.IsNullOrEmpty(tbpath.Text) Then
                MessageBox.Show("Please select an Excel file first.")
                Return
            End If

            ' Create the connection string and open the connection
            Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & tbpath.Text & ";Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1;'"
            Using conn As New OLEDBConnection(connString)
                Try
                    conn.Open()

                    ' Retrieve the data from the sheet into a DataTable
                    Dim sheetName As String = "Sheet1$" ' Change this to your sheet name
                    Dim cmd As New OleDbCommand("SELECT * FROM [" & sheetName & "]", conn)
                    Dim da As New OleDbDataAdapter(cmd)
                    Dim dt As New System.Data.DataTable()
                    da.Fill(dt)

                    ' Bind the DataTable to the DataGridView
                    dgvExcell.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while inserting data: " & ex.Message)
        End Try
    End Sub

    Private Sub ImportExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each frm As Form In System.Windows.Forms.Application.OpenForms
            If frm IsNot Me Then
                frm.Enabled = False
            End If
        Next
    End Sub

    Private Sub ImportExcel_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Loop through all the open forms in the application
        For Each form As Form In System.Windows.Forms.Application.OpenForms
            If form IsNot Me AndAlso Not form.Enabled Then
                form.Enabled = True
            End If
        Next
    End Sub
End Class