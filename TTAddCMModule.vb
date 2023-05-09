

Module TTAddCMModule
    Public Sub addCM(lb As List(Of String), dgv As DataGridViewComboBoxColumn)

        Try
            dgv.Items.Clear()
            Dim rowCount As Integer = dgv.DataGridView.Rows.Count
            Dim colCount As Integer = dgv.DataGridView.Columns.Count

            For i As Integer = 0 To colCount - 1 Step lb.Count
                Dim rangeEnd As Integer = Math.Min(i + lb.Count - 1, colCount - 1)

                For j As Integer = i To rangeEnd
                    Dim col As DataGridViewColumn = dgv.DataGridView.Columns(j)

                    If TypeOf col Is DataGridViewComboBoxColumn AndAlso CType(col, DataGridViewComboBoxColumn).Items.Contains(lb(j - i)) Then
                        Continue For ' item already exists in column, move on to next
                    End If

                    dgv.Items.Add(lb(j - i))
                    Dim itemIndex As Integer = dgv.Items.Count - 1

                    For k As Integer = 0 To rowCount - 1
                        Dim cell As DataGridViewComboBoxCell = CType(dgv.DataGridView.Rows(k).Cells(j), DataGridViewComboBoxCell)
                        cell.Items.Add(lb(j - i))
                        cell.Value = dgv.Items(itemIndex)
                    Next
                Next
            Next
        Catch ex As Exception
            ' handle exception
        End Try


    End Sub






End Module
