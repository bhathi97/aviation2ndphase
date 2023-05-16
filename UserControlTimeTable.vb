
Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Wordprocessing


Public Class UserControlTimeTable

    ' Private dataTable As DataTable ' Declare a private variable to store the data table of the DataGridView

    'Public str As String = "Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True"
    Public str As String = DatabaseConnection.ConnectionString
    Dim connsql As New SqlConnection(str)

    'Dim comboBoxColumnRIC As DataGridViewComboBoxColumn = dgvMain.Columns("Column6")

    Private _comboBoxColumnRIC As DataGridViewComboBoxColumn

    Public Property ComboBoxColumnRIC As DataGridViewComboBoxColumn
        Get
            Return _comboBoxColumnRIC
        End Get
        Set(value As DataGridViewComboBoxColumn)
            _comboBoxColumnRIC = value
        End Set
    End Property

    Private _comboBoxColumnCM As DataGridViewComboBoxColumn

    Public Property ComboBoxColumnCM As DataGridViewComboBoxColumn
        Get
            Return _comboBoxColumnCM
        End Get
        Set(value As DataGridViewComboBoxColumn)
            _comboBoxColumnCM = value
        End Set
    End Property

    Private _comboBoxColumnOP As DataGridViewComboBoxColumn

    Public Property ComboBoxColumnOP As DataGridViewComboBoxColumn
        Get
            Return _comboBoxColumnOP
        End Get
        Set(value As DataGridViewComboBoxColumn)
            _comboBoxColumnOP = value
        End Set
    End Property


    '****************************************
    Private _lbCMItems As New List(Of String)

    Public Property LbcmItems As List(Of String)
        Get
            Return _lbCMItems
        End Get
        Set(value As List(Of String))
            _lbCMItems = value
        End Set
    End Property

    '****************************************


    Private _lbRICItems As New List(Of String)

    Public Property LbRICItems As List(Of String)
        Get
            Return _lbRICItems
        End Get
        Set(value As List(Of String))
            _lbRICItems = value
        End Set
    End Property

    '****************************************


    'Handles MyBase.Load
    Private Sub UserControlTimeTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDate.Value = DateTime.Today 'load today
        CrewmanAddingSelectGroup(cbGroup) 'load group
        TTAddingshift(cbShiftTime) 'load shift Time
        changeDayLbl(dtpDate, lblDay) 'load day

        ' Set the font color of all cells in the DataGridView

        'set columns
        ComboBoxColumnCM = dgvMain.Columns("Column8")
        ComboBoxColumnRIC = dgvMain.Columns("Column6")
        ComboBoxColumnOP = dgvMain.Columns("Column7")


        'set the panel12
        Panel12.Width = 30 ' Set new width 
        btnResizePnl.IconChar = FontAwesome.Sharp.IconChar.AngleLeft

        '
        'Update the label text every second
        Timer1.Interval = 1000 ' 1 second
        Timer1.Start()

        'dgvMain.DataSource = dataTable ' Set the DataSource of the DataGridView to the dataTable variable

        'load update field data

        remarkAdd(cboxremarks)

        'load date
        Dim currentDate As Date = Date.Today
        lbltoday.Text = currentDate.ToString("dd/MM/yyyy") ' Displays the current date in the format "dd/MM/yyyy" on a label control

        '***********************
        LbcmItems.Clear()


    End Sub

    'Handles dtpDate.ValueChanged
    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        changeDayLbl(dtpDate, lblDay) 'load day
    End Sub

    'Handles cbShiftTime.SelectedIndexChanged
    Private Sub cbShiftTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbShiftTime.SelectedIndexChanged
        changeShift(cbShiftTime, lblShift)
    End Sub

    'Handles cbGroup.SelectedIndexChanged
    Private Sub cbGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGroup.SelectedIndexChanged

        Try
            Dim groupName As String
            groupName = cbGroup.Text
            'MsgBox(groupName)
            TTLoadDataToListBoxesModule.LoadDataToListBoxes(cbGroup, lbCM, lbRIC, connsql)

            ' Add each item in the lbCM list box to the list *******************
            For Each item As Object In lbCM.Items
                LbcmItems.Add(item.ToString())

            Next

            ' Add each item in the lbCM list box to the list *******************
            For Each item As Object In lbRIC.Items
                LbRICItems.Add(item.ToString())

            Next

            'add operators to the datagrid view
            ComboBoxColumnOP.Items.Clear()
            loadToDGV(connsql, ComboBoxColumnOP, groupName)


            cbAddMoreCM.Items.Clear()
            'load all CM to the more combo box
            loadMoreCMToComboBox(connsql, cbAddMoreCM, groupName)


            'load all ric to the more RIC combo box
            cbAddMoreRIC.Items.Clear()
            loadMoreRICToComboBox(connsql, cbAddMoreRIC, groupName)


            'load data to datagridview RIC column
            ComboBoxColumnRIC.Items.Clear()
            loadMoreRICToDGV(ComboBoxColumnRIC, lbRIC)

            'load data to datagridview CM column
            ComboBoxColumnCM.Items.Clear()
            loadMoreCMToDGV(ComboBoxColumnCM, lbCM)

            'load operator items
            cbOPerater.Items.Clear()
            addOperators(connsql, cbOPerater)


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try

    End Sub

    'CREWMEN order change ------------------------------
    'Handles lbCM.MouseDown
    Private Sub lbCM_MouseDown(sender As Object, e As MouseEventArgs) Handles lbCM.MouseDown
        Try
            TTOrderChangingModule.dragWantedItem(e, lbCM)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Handles lbCM.DragEnter
    Private Sub lbCM_DragEnter(sender As Object, e As DragEventArgs) Handles lbCM.DragEnter
        Try
            dragOverOtherItems(e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Handles lbCM.DragOver
    Private Sub lbCM_DragOver(sender As Object, e As DragEventArgs) Handles lbCM.DragOver
        Try
            dropWantedItem(e, lbCM)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Handles lbCM.GiveFeedback
    Private Sub lbCM_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles lbCM.GiveFeedback
        e.UseDefaultCursors = False ' Change the cursor to the drag cursor during the drag operation.
        Cursor.Current = Cursors.NoMoveVert ' Change this to the cursor you want to use.
    End Sub

    'RIC order change ------------------------------
    'Handles lbRIC.MouseDown
    Private Sub lbRIC_MouseDown(sender As Object, e As MouseEventArgs) Handles lbRIC.MouseDown
        Try
            dragWantedItem(e, lbRIC)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Handles lbRIC.DragEnter
    Private Sub lbRIC_DragEnter(sender As Object, e As DragEventArgs) Handles lbRIC.DragEnter
        Try
            dragOverOtherItems(e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Handles lbRIC.DragOver
    Private Sub lbRIC_DragOver(sender As Object, e As DragEventArgs) Handles lbRIC.DragOver
        Try
            dropWantedItem(e, lbRIC)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Handles lbRIC.GiveFeedback
    Private Sub lbRIC_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles lbRIC.GiveFeedback
        e.UseDefaultCursors = False ' Change the cursor to the drag cursor during the drag operation.
        Cursor.Current = Cursors.NoMoveVert ' Change this to the cursor you want to use.
    End Sub


    '--------------------------------------------------------


    'Handles btnCMRemove.Click
    Private Sub btnCMRemove_Click(sender As Object, e As EventArgs) Handles btnCMRemove.Click
        Try
            TTAddOrRemoveModule.remove(lbCM, lbRemovedCM)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Handles btnAddAgainCM.Click
    Private Sub btnAddAgainCM_Click(sender As Object, e As EventArgs) Handles btnAddAgainCM.Click
        Try
            TTAddOrRemoveModule.remove(lbRemovedCM, lbCM)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Handles btnRICRemove.Click
    Private Sub btnRICRemove_Click(sender As Object, e As EventArgs) Handles btnRICRemove.Click
        Try
            TTAddOrRemoveModule.remove(lbRIC, lbRemovedRIC)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Handles btnAddAgainRIC.Click
    Private Sub btnAddAgainRIC_Click(sender As Object, e As EventArgs) Handles btnAddAgainRIC.Click
        Try
            TTAddOrRemoveModule.remove(lbRemovedRIC, lbRIC)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Handles btnPlaneAdd.Click
    Private Sub btnPlaneAdd_Click(sender As Object, e As EventArgs) Handles btnPlaneAdd.Click
        Try
            TTAddFlightsModule.addToTable(connsql, lblShift, dtpDate, dgvMain)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
            btnPlaneAdd.Enabled = False
        End Try
    End Sub



    '------------------------------------------------------
    'add crewman
    'Handles btnAddCMToTable.Click
    Private Sub btnAddCMToTable_Click(sender As Object, e As EventArgs) Handles btnAddCMToTable.Click
        Try
            'ComboBoxColumnCM.Items.Clear()
            addCM(LbcmItems, ComboBoxColumnCM)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub

    'Handles btnAddRICToTable.Click
    Private Sub btnAddRICToTable_Click(sender As Object, e As EventArgs) Handles btnAddRICToTable.Click
        Try
            addRIC(_lbRICItems, ComboBoxColumnRIC)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub

    'Handles btnPrint.Click
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            TTDataPassToPrintFModule.loadPrint(dtpDate, cbShiftTime, lblDay, lblShift, dgvMain)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()
        End Try
    End Sub

    ' Handles dgvMain.MouseUp
    Private Sub dgvMain_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvMain.MouseUp
        If e.Button = MouseButtons.Right Then ' Check if the right mouse button was clicked
            Dim hti As DataGridView.HitTestInfo = dgvMain.HitTest(e.X, e.Y)
            If hti.RowIndex >= 0 Then ' Check if the clicked area is in a valid row
                dgvMain.ClearSelection() ' Clear any existing row selection
                dgvMain.Rows(hti.RowIndex).Selected = True ' Select the clicked row

                Dim menu As New ContextMenuStrip() ' Create a new context menu strip
                menu.Items.Add("CHARTER").Name = "AddRow" ' Add an item to add a new row
                'menu.Items.Add("Delete Selected Row").Name = "DeleteRow" ' Add an item to delete the selected row

                AddHandler menu.ItemClicked, AddressOf ContextMenuStrip1_ItemClicked ' Add a handler for the menu item clicked event


                menu.Show(dgvMain, e.Location) ' Show the context menu strip at the clicked location
            End If
        End If
        'dgvMain.Refresh()

    End Sub


    'Handles ContextMenuStrip1.ItemClicked
    Private Sub ContextMenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        Try
            ' Disable the main form
            Me.Enabled = False


            TTGridRowSettingModule.clickEvent(e, dgvMain)

            ' Enable the main form after the new form is closed
            Me.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Handles Timer1.Tick
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update the label text with the current time
        lblTime.Text = DateTime.Now.ToString("HH:mm")
    End Sub

    ' Handles btnResizePnl.Click
    Private Sub btnResizePnl_Click(sender As Object, e As EventArgs) Handles btnResizePnl.Click
        If Panel12.Width = 250 Then
            Panel12.Width = 30 ' Set new width 
            btnResizePnl.IconChar = FontAwesome.Sharp.IconChar.AngleLeft
        Else
            Panel12.Width = 250 ' Set new width
            btnResizePnl.IconChar = FontAwesome.Sharp.IconChar.AngleRight
        End If
    End Sub



    'Handles lblTime.TextChanged
    Private Sub lblTime_TextChanged(sender As Object, e As EventArgs) Handles lblTime.TextChanged
        'get row count
        'Dim rowCount As Integer = dgvMain.RowCount
        checkBoxValueSet(dgvMain, lblTime, lbltoday)

    End Sub

    ' Handles dgvMain.CellClick
    Private Sub dgvMain_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellClick


        'Get the selected row data
        Dim selectedRow As DataGridViewRow = dgvMain.CurrentRow

        ' Get the values of the cells in the selected row
        Dim flightNo As Object = selectedRow.Cells(3).Value 'flight
        Dim eta As Object = selectedRow.Cells(5).Value
        Dim bay As Object = selectedRow.Cells(1).Value
        Dim operater As Object = selectedRow.Cells(8).Value
        Dim remark As Object = selectedRow.Cells(10).Value
        Dim route As Object = selectedRow.Cells(4).Value

        lblSelectedFlight.Text = flightNo
        tbBayNo.Text = bay
        cbOPerater.Text = operater
        cboxremarks.Text = remark
        lblETAShow.Text = eta.ToString()
        tbRoute.Text = route
        'enable the button
        btnUpdateData.Enabled = True

    End Sub


    'Handles btnUpdateData.Click
    Private Sub btnUpdateData_Click(sender As Object, e As EventArgs) Handles btnUpdateData.Click
        Try
            For Each row As DataGridViewRow In dgvMain.Rows
                If Not row.IsNewRow AndAlso row.Cells(3).Value IsNot Nothing AndAlso row.Cells(3).Value.ToString() = lblSelectedFlight.Text AndAlso row.Cells(5).Value IsNot Nothing AndAlso row.Cells(5).Value.ToString() = lblETAShow.Text AndAlso row.Cells(0).Value <> True Then
                    row.Cells(1).Value = tbBayNo.Text
                    row.Cells(8).Value = cbOPerater.Text
                    row.Cells(10).Value = cboxremarks.Text
                    row.Cells(4).Value = tbRoute.Text
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Handles btnRefresh.Click
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            Dim result As DialogResult = MessageBox.Show("Do you want to proceed? All changed data will discard", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                btnPlaneAdd.Enabled = True
            Else
                'no action
            End If
        Catch ex As Exception

        End Try
    End Sub

    ' Handles cbAddMoreCM.MouseDown

    Private Sub cbAddMoreCM_MouseDown(sender As Object, e As MouseEventArgs) Handles cbAddMoreCM.MouseDown
        Try
            If e.Button = MouseButtons.Left Then
                Dim selectedItem As Object = cbAddMoreCM.SelectedItem
                If selectedItem IsNot Nothing Then
                    If Not lbCM.Items.Contains(selectedItem) And Not lbRemovedCM.Items.Contains(selectedItem) Then
                        lbCM.Items.Add(selectedItem)
                        cbAddMoreCM.Items.Remove(selectedItem)


                        ' loadMoreCMToDGV(ComboBoxColumnCM, lbCM)


                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Handles cbAddMoreRIC.MouseDown
    Private Sub cbAddMoreRIC_MouseDown(sender As Object, e As MouseEventArgs) Handles cbAddMoreRIC.MouseDown
        Try
            If e.Button = MouseButtons.Left Then
                Dim selectedItem As Object = cbAddMoreRIC.SelectedItem
                If selectedItem IsNot Nothing Then
                    If Not lbRIC.Items.Contains(selectedItem) And Not lbRemovedRIC.Items.Contains(selectedItem) Then
                        lbRIC.Items.Add(selectedItem)
                        cbAddMoreRIC.Items.Remove(selectedItem)

                        ' loadMoreRICToDGV(ComboBoxColumnRIC, lbRIC)


                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Handles dgvMain.CellContentClick
    Private Sub dgvMain_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMain.CellContentClick

    End Sub
End Class



