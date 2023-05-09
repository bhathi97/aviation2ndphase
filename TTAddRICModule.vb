
Module TTAddRICModule

    Public Sub addRIC(lb As ListBox, dgv As DataGridViewComboBoxColumn)
        Dim itemCount As Integer = lb.Items.Count 'listview column count
        Dim flag As Integer = 0

        'loop thruogh the table rows
        If itemCount <> 1 Then

            For i As Integer = 0 To dgv.DataGridView.Rows.Count - 1
                Dim cell As DataGridViewComboBoxCell = dgv.DataGridView.Rows(i).Cells(dgv.Name)

                If dgv.DataGridView.Rows(i).Cells("Column3").Value IsNot Nothing AndAlso dgv.DataGridView.Rows(i).Cells("Column3").Value <> "YES" AndAlso dgv.DataGridView.Rows(i).Cells("Column2").Value <> True Then
                    If flag < itemCount Then
                        cell.Value = lb.Items(flag).ToString()
                        flag += 1
                        If flag = itemCount Then flag = 0 ' reset flag if it reaches the end of the ListView
                    End If
                ElseIf dgv.DataGridView.Rows(i).Cells("Column2").Value = True Then
                    ' Do nothing
                Else
                    cell.Value = ""
                End If
            Next

            'if there is only one item 
        ElseIf itemCount = 1 Then

            For i As Integer = 0 To dgv.DataGridView.Rows.Count - 1
                Dim cell As DataGridViewComboBoxCell = dgv.DataGridView.Rows(i).Cells(dgv.Name)

                If dgv.DataGridView.Rows(i).Cells("Column3").Value IsNot Nothing AndAlso dgv.DataGridView.Rows(i).Cells("Column3").Value <> "YES" Then
                    cell.Value = lb.Items(0).ToString()
                Else
                    cell.Value = ""
                End If
            Next

        End If

    End Sub


End Module
