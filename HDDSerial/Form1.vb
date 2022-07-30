Imports System.Management
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim searcher As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk")
        ListBox1.Items.Clear()
        For Each wmi_HD As ManagementObject In searcher.Get

            ListBox1.Items.Add("Name: " & wmi_HD("Name"))
            ListBox1.Items.Add("Description: " & wmi_HD("Description"))
            ListBox1.Items.Add("DeviceID: " & wmi_HD("DeviceID"))
            ListBox1.Items.Add("VolumeName: " & wmi_HD("VolumeName"))
            ListBox1.Items.Add("VolumeSerialNumber: " & wmi_HD("VolumeSerialNumber"))
            ListBox1.Items.Add("---")

        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub
End Class
