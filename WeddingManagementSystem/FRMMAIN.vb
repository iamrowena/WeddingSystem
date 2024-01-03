Public Class FRMMAIN
    Private Sub BTNDASHBOARD_Click(sender As Object, e As EventArgs) Handles BTNDASHBOARD.Click
        With FRMDASHBOARD
            PANELMAIN.Controls.Clear()
            FRMDASHBOARD.TopLevel = False
            PANELMAIN.Controls.Add(FRMDASHBOARD)
            FRMDASHBOARD.BringToFront()
            FRMDASHBOARD.Show()
            .LoadName()

            BTNDASHBOARD.FillColor = Color.FromArgb(145, 127, 179)
            BTNAPPOINTMENTS.FillColor = Color.FromArgb(229, 190, 236)
            BTNBOOKINGS.FillColor = Color.FromArgb(229, 190, 236)
            BTNMESSAGES.FillColor = Color.FromArgb(229, 190, 236)
            BTNPAYMENT.FillColor = Color.FromArgb(229, 190, 236)
            BTNSERVICES.FillColor = Color.FromArgb(229, 190, 236)
            BTNVENDOR.FillColor = Color.FromArgb(229, 190, 236)
            BTNPAYMENT.FillColor = Color.FromArgb(229, 190, 236)
            BTNTASK.FillColor = Color.FromArgb(229, 190, 236)

        End With
    End Sub

    Private Sub BTNAPPOINTMENTS_Click(sender As Object, e As EventArgs) Handles BTNAPPOINTMENTS.Click
        With FRMAPPOINTMENT
            PANELMAIN.Controls.Clear()
            FRMAPPOINTMENT.TopLevel = False
            PANELMAIN.Controls.Add(FRMAPPOINTMENT)
            FRMAPPOINTMENT.BringToFront()
            .LOADAPPOINTMENT()
            FRMAPPOINTMENT.Show()

            BTNDASHBOARD.FillColor = Color.FromArgb(229, 190, 236)
            BTNAPPOINTMENTS.FillColor = Color.FromArgb(145, 127, 179)
            BTNBOOKINGS.FillColor = Color.FromArgb(229, 190, 236)
            BTNMESSAGES.FillColor = Color.FromArgb(229, 190, 236)
            BTNPAYMENT.FillColor = Color.FromArgb(229, 190, 236)
            BTNSERVICES.FillColor = Color.FromArgb(229, 190, 236)
            BTNVENDOR.FillColor = Color.FromArgb(229, 190, 236)
            BTNPAYMENT.FillColor = Color.FromArgb(229, 190, 236)
            BTNTASK.FillColor = Color.FromArgb(229, 190, 236)

        End With
    End Sub

    Private Sub BTNMESSAGES_Click(sender As Object, e As EventArgs) Handles BTNMESSAGES.Click
        With FRMMESSAGES
            PANELMAIN.Controls.Clear()
            FRMMESSAGES.TopLevel = False
            PANELMAIN.Controls.Add(FRMMESSAGES)
            FRMMESSAGES.BringToFront()
            FRMMESSAGES.Show()
            .LOADMESSAGES()

            BTNDASHBOARD.FillColor = Color.FromArgb(229, 190, 236)
            BTNAPPOINTMENTS.FillColor = Color.FromArgb(229, 190, 236)
            BTNBOOKINGS.FillColor = Color.FromArgb(229, 190, 236)
            BTNMESSAGES.FillColor = Color.FromArgb(145, 127, 179)
            BTNPAYMENT.FillColor = Color.FromArgb(229, 190, 236)
            BTNSERVICES.FillColor = Color.FromArgb(229, 190, 236)
            BTNVENDOR.FillColor = Color.FromArgb(229, 190, 236)
            BTNPAYMENT.FillColor = Color.FromArgb(229, 190, 236)
            BTNTASK.FillColor = Color.FromArgb(229, 190, 236)

        End With
    End Sub

    Private Sub BTNSERVICES_Click(sender As Object, e As EventArgs) Handles BTNSERVICES.Click
        With FRMSERVICES
            PANELMAIN.Controls.Clear()
            FRMSERVICES.TopLevel = False
            PANELMAIN.Controls.Add(FRMSERVICES)
            FRMSERVICES.BringToFront()
            FRMSERVICES.Show()
            .LOADPACKAGES()


            BTNDASHBOARD.FillColor = Color.FromArgb(229, 190, 236)
            BTNAPPOINTMENTS.FillColor = Color.FromArgb(229, 190, 236)
            BTNBOOKINGS.FillColor = Color.FromArgb(229, 190, 236)
            BTNMESSAGES.FillColor = Color.FromArgb(229, 190, 236)
            BTNPAYMENT.FillColor = Color.FromArgb(229, 190, 236)
            BTNSERVICES.FillColor = Color.FromArgb(145, 127, 179)
            BTNVENDOR.FillColor = Color.FromArgb(229, 190, 236)
            BTNPAYMENT.FillColor = Color.FromArgb(229, 190, 236)
            BTNTASK.FillColor = Color.FromArgb(229, 190, 236)
        End With
    End Sub

    Private Sub BTNPAYMENT_Click(sender As Object, e As EventArgs) Handles BTNPAYMENT.Click
        With FRMPAYMENT
            PANELMAIN.Controls.Clear()
            FRMPAYMENT.TopLevel = False
            PANELMAIN.Controls.Add(FRMPAYMENT)
            FRMPAYMENT.BringToFront()
            FRMPAYMENT.Show()
            .LOADPAYMENT()

            BTNDASHBOARD.FillColor = Color.FromArgb(229, 190, 236)
            BTNAPPOINTMENTS.FillColor = Color.FromArgb(229, 190, 236)
            BTNBOOKINGS.FillColor = Color.FromArgb(229, 190, 236)
            BTNMESSAGES.FillColor = Color.FromArgb(229, 190, 236)
            BTNPAYMENT.FillColor = Color.FromArgb(145, 127, 179)
            BTNSERVICES.FillColor = Color.FromArgb(229, 190, 236)
            BTNVENDOR.FillColor = Color.FromArgb(229, 190, 236)
            BTNPAYMENT.FillColor = Color.FromArgb(145, 127, 179)
            BTNTASK.FillColor = Color.FromArgb(229, 190, 236)
        End With
    End Sub

    Private Sub BTNVENDOR_Click(sender As Object, e As EventArgs) Handles BTNVENDOR.Click
        With FRMSTAFF
            PANELMAIN.Controls.Clear()
            FRMSTAFF.TopLevel = False
            PANELMAIN.Controls.Add(FRMSTAFF)
            FRMSTAFF.BringToFront()
            FRMSTAFF.Show()
            .LOADplanner()
            .LOADvendor()

            BTNDASHBOARD.FillColor = Color.FromArgb(229, 190, 236)
            BTNAPPOINTMENTS.FillColor = Color.FromArgb(229, 190, 236)
            BTNBOOKINGS.FillColor = Color.FromArgb(229, 190, 236)
            BTNMESSAGES.FillColor = Color.FromArgb(229, 190, 236)
            BTNPAYMENT.FillColor = Color.FromArgb(229, 190, 236)
            BTNSERVICES.FillColor = Color.FromArgb(229, 190, 236)
            BTNVENDOR.FillColor = Color.FromArgb(145, 127, 179)
            BTNPAYMENT.FillColor = Color.FromArgb(229, 190, 236)
            BTNTASK.FillColor = Color.FromArgb(229, 190, 236)

        End With
    End Sub

    Private Sub BTNBOOKINGS_Click(sender As Object, e As EventArgs) Handles BTNBOOKINGS.Click
        With FRMBOOKINGS
            PANELMAIN.Controls.Clear()
            FRMBOOKINGS.TopLevel = False
            PANELMAIN.Controls.Add(FRMBOOKINGS)
            FRMBOOKINGS.BringToFront()
            .LOADbookings()
            .LOADclient()
            
            FRMBOOKINGS.Show()


            BTNDASHBOARD.FillColor = Color.FromArgb(229, 190, 236)
            BTNAPPOINTMENTS.FillColor = Color.FromArgb(229, 190, 236)
            BTNBOOKINGS.FillColor = Color.FromArgb(145, 127, 179)
            BTNPAYMENT.FillColor = Color.FromArgb(229, 190, 236)
            BTNSERVICES.FillColor = Color.FromArgb(229, 190, 236)
            BTNVENDOR.FillColor = Color.FromArgb(229, 190, 236)
            BTNPAYMENT.FillColor = Color.FromArgb(229, 190, 236)
            BTNTASK.FillColor = Color.FromArgb(229, 190, 236)

        End With
    End Sub

    Private Sub FRMMAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With FRMDASHBOARD
            PANELMAIN.Controls.Clear()
            FRMDASHBOARD.TopLevel = False
            PANELMAIN.Controls.Add(FRMDASHBOARD)
            FRMDASHBOARD.BringToFront()
            FRMDASHBOARD.Show()

            BTNDASHBOARD.FillColor = Color.FromArgb(145, 127, 179)
            BTNAPPOINTMENTS.FillColor = Color.FromArgb(229, 190, 236)
            BTNBOOKINGS.FillColor = Color.FromArgb(229, 190, 236)
            BTNMESSAGES.FillColor = Color.FromArgb(229, 190, 236)
            BTNPAYMENT.FillColor = Color.FromArgb(229, 190, 236)
            BTNSERVICES.FillColor = Color.FromArgb(229, 190, 236)
            BTNVENDOR.FillColor = Color.FromArgb(229, 190, 236)
            BTNPAYMENT.FillColor = Color.FromArgb(229, 190, 236)
            BTNTASK.FillColor = Color.FromArgb(229, 190, 236)
        End With
    End Sub

    Private Sub BTNTASK_Click(sender As Object, e As EventArgs) Handles BTNTASK.Click
        With FRMTASK
            PANELMAIN.Controls.Clear()
            FRMTASK.TopLevel = False
            PANELMAIN.Controls.Add(FRMTASK)
            FRMTASK.BringToFront()
            FRMTASK.Show()
            .LOADTASK()

            BTNTASK.FillColor = Color.FromArgb(145, 127, 179)
            BTNDASHBOARD.FillColor = Color.FromArgb(229, 190, 236)
            BTNAPPOINTMENTS.FillColor = Color.FromArgb(229, 190, 236)
            BTNBOOKINGS.FillColor = Color.FromArgb(229, 190, 236)
            BTNMESSAGES.FillColor = Color.FromArgb(229, 190, 236)
            BTNPAYMENT.FillColor = Color.FromArgb(229, 190, 236)
            BTNSERVICES.FillColor = Color.FromArgb(229, 190, 236)
            BTNVENDOR.FillColor = Color.FromArgb(229, 190, 236)
            BTNPAYMENT.FillColor = Color.FromArgb(229, 190, 236)
        End With
    End Sub
End Class