﻿Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentRecord1DataSet.member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me.StudentRecord1DataSet.member)

    End Sub


End Class
