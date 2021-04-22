Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MealCost As New cMeal
        MealCost.Coke = MealCost.pCoke * Double.Parse(TextBox13.Text)
        MealCost.Origin = MealCost.pOrigin * Double.Parse(TextBox12.Text)
        MealCost.Fanta = MealCost.pFanta * Double.Parse(TextBox11.Text)
        MealCost.Alvaro = MealCost.pAlvaro * Double.Parse(TextBox10.Text)
        MealCost.BottleWater = MealCost.pBottleWater * Double.Parse(TextBox14.Text)
        MealCost.Malt = MealCost.pMalt * Double.Parse(TextBox15.Text)
        MealCost.Sprite = MealCost.pSprite * Double.Parse(TextBox16.Text)
        MealCost.Welch = MealCost.pWelch * Double.Parse(TextBox17.Text)

        MealCost.Rice = MealCost.pRice * Double.Parse(TextBox1.Text)
        MealCost.Fufu = MealCost.pFufu * Double.Parse(TextBox2.Text)
        MealCost.Kokonte = MealCost.pKokonte * Double.Parse(TextBox3.Text)
        MealCost.Beans = MealCost.pBeans * Double.Parse(TextBox4.Text)
        MealCost.FriedRice = MealCost.pFriedRice * Double.Parse(TextBox5.Text)
        MealCost.OilRice = MealCost.pOilRice * Double.Parse(TextBox6.Text)
        MealCost.Waakye = MealCost.pWaakye * Double.Parse(TextBox7.Text)
        MealCost.Jolof = MealCost.pJolof * Double.Parse(TextBox8.Text)
        MealCost.Banku = MealCost.pBanku * Double.Parse(TextBox9.Text)


        Dim iSubTotal As Double = MealCost.GetAmount
        Dim iTax As Double = MealCost.GetTax
        Dim iTotal As Double = iSubTotal + iTax

        Label5.Text = FormatCurrency(iSubTotal)
        Label4.Text = FormatCurrency(iTax)
        Label6.Text = FormatCurrency(iTotal)
        '============================================rReceipt===========================================
        rtReceipt.AppendText(vbTab + vbTab + "Bushke Online" + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Accra" + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Abeka" + vbNewLine)
        rtReceipt.AppendText("======================================================================" + vbNewLine)
        rtReceipt.AppendText("Coke" + vbTab + vbTab + vbTab + vbTab + TextBox13.Text + vbNewLine)
        rtReceipt.AppendText("Origin" + vbTab + vbTab + vbTab + vbTab + TextBox12.Text + vbNewLine)
        rtReceipt.AppendText("Fanta" + vbTab + vbTab + vbTab + vbTab + TextBox11.Text + vbNewLine)
        rtReceipt.AppendText("Alvaro" + vbTab + vbTab + vbTab + vbTab + TextBox10.Text + vbNewLine)
        rtReceipt.AppendText("BottleWater" + vbTab + vbTab + vbTab + vbTab + TextBox14.Text + vbNewLine)
        rtReceipt.AppendText("Malt" + vbTab + vbTab + vbTab + vbTab + TextBox15.Text + vbNewLine)
        rtReceipt.AppendText("Sprite" + vbTab + vbTab + vbTab + vbTab + TextBox16.Text + vbNewLine)
        rtReceipt.AppendText("Welch" + vbTab + vbTab + vbTab + vbTab + TextBox17.Text + vbNewLine)
        rtReceipt.AppendText("Rice" + vbTab + vbTab + vbTab + vbTab + TextBox1.Text + vbNewLine)
        rtReceipt.AppendText("Fufu" + vbTab + vbTab + vbTab + vbTab + TextBox2.Text + vbNewLine)
        rtReceipt.AppendText("Kokonte" + vbTab + vbTab + vbTab + vbTab + TextBox3.Text + vbNewLine)
        rtReceipt.AppendText("Beans" + vbTab + vbTab + vbTab + vbTab + TextBox4.Text + vbNewLine)
        rtReceipt.AppendText("FriedRice" + vbTab + vbTab + vbTab + vbTab + TextBox5.Text + vbNewLine)
        rtReceipt.AppendText("OilRice" + vbTab + vbTab + vbTab + vbTab + TextBox6.Text + vbNewLine)
        rtReceipt.AppendText("Waakye" + vbTab + vbTab + vbTab + vbTab + TextBox7.Text + vbNewLine)
        rtReceipt.AppendText("Jolof" + vbTab + vbTab + vbTab + vbTab + TextBox8.Text + vbNewLine)
        rtReceipt.AppendText("Banku" + vbTab + vbTab + vbTab + vbTab + TextBox9.Text + vbNewLine)
        rtReceipt.AppendText("Tax" + vbTab + vbTab + vbTab + vbTab + Label4.Text + vbNewLine)
        rtReceipt.AppendText("SubTotal" + vbTab + vbTab + vbTab + vbTab + Label5.Text + vbNewLine)
        rtReceipt.AppendText("Total" + vbTab + vbTab + vbTab + vbTab + Label6.Text + vbNewLine)
        rtReceipt.AppendText("============================================================" + vbNewLine)
        rtReceipt.AppendText(vbTab + vbTab + "Thank you" + vbNewLine)



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cMeal.ExitSystem()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each txt In {TextBox13, TextBox12, TextBox11, TextBox10, TextBox14, TextBox15, TextBox16, TextBox17, TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9}
            txt.Enabled = False
            txt.Text = "0"

        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each txt In {TextBox13, TextBox12, TextBox11, TextBox10, TextBox14, TextBox15, TextBox16, TextBox17, TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9}
            txt.Text = "0"

        Next

        Label5.Text = ""
        Label4.Text = ""
        Label6.Text = ""
        rtReceipt.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            TextBox13.Text = ""
            TextBox13.Enabled = True
            TextBox13.Focus()
        Else
            TextBox13.Text = "0"
            TextBox13.Enabled = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked = True) Then
            TextBox12.Text = ""
            TextBox12.Enabled = True
            TextBox12.Focus()
        Else
            TextBox12.Text = "0"
            TextBox12.Enabled = False
        End If
    End Sub


    Private Sub CheckBox3_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If (CheckBox3.Checked) = True Then
            TextBox11.Text = ""
            TextBox11.Enabled = True
            TextBox11.Focus()
        Else
            TextBox11.Text = "0"
            TextBox11.Enabled = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If (CheckBox4.Checked = True) Then
            TextBox10.Text = ""
            TextBox10.Enabled = True
            TextBox10.Focus()
        Else
            TextBox10.Text = "0"
            TextBox10.Enabled = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If (CheckBox5.Checked = True) Then
            TextBox14.Text = ""
            TextBox14.Enabled = True
            TextBox14.Focus()
        Else
            TextBox14.Text = "0"
            TextBox14.Enabled = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If (CheckBox6.Checked = True) Then
            TextBox15.Text = ""
            TextBox15.Enabled = True
            TextBox15.Focus()
        Else
            TextBox15.Text = "0"
            TextBox15.Enabled = False
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If (CheckBox7.Checked = True) Then
            TextBox16.Text = ""
            TextBox16.Enabled = True
            TextBox16.Focus()
        Else
            TextBox16.Text = "0"
            TextBox16.Enabled = False
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If (CheckBox8.Checked = True) Then
            TextBox17.Text = ""
            TextBox17.Enabled = True
            TextBox17.Focus()
        Else
            TextBox17.Text = "0"
            TextBox17.Enabled = False
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If (CheckBox9.Checked = True) Then
            TextBox1.Text = ""
            TextBox1.Enabled = True
            TextBox1.Focus()
        Else
            TextBox1.Text = "0"
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If (CheckBox10.Checked = True) Then
            TextBox2.Text = ""
            TextBox2.Enabled = True
            TextBox2.Focus()
        Else
            TextBox2.Text = "0"
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If (CheckBox11.Checked = True) Then
            TextBox3.Text = ""
            TextBox3.Enabled = True
            TextBox3.Focus()
        Else
            TextBox3.Text = "0"
            TextBox3.Enabled = False
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If (CheckBox12.Checked = True) Then
            TextBox4.Text = ""
            TextBox4.Enabled = True
            TextBox4.Focus()
        Else
            TextBox4.Text = "0"
            TextBox4.Enabled = False
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If (CheckBox13.Checked = True) Then
            TextBox5.Text = ""
            TextBox5.Enabled = True
            TextBox5.Focus()
        Else
            TextBox5.Text = "0"
            TextBox5.Enabled = False
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If (CheckBox14.Checked = True) Then
            TextBox6.Text = ""
            TextBox6.Enabled = True
            TextBox6.Focus()
        Else
            TextBox6.Text = "0"
            TextBox6.Enabled = False
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        If (CheckBox15.Checked = True) Then
            TextBox7.Text = ""
            TextBox7.Enabled = True
            TextBox7.Focus()
        Else
            TextBox7.Text = "0"
            TextBox7.Enabled = False
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        If (CheckBox16.Checked = True) Then
            TextBox8.Text = ""
            TextBox8.Enabled = True
            TextBox8.Focus()
        Else
            TextBox8.Text = "0"
            TextBox8.Enabled = False
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        If (CheckBox17.Checked = True) Then
            TextBox9.Text = ""
            TextBox9.Enabled = True
            TextBox9.Focus()
        Else
            TextBox9.Text = "0"
            TextBox9.Enabled = False
        End If
    End Sub




    Private Sub NUMBER_ONLY(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress, TextBox8.KeyPress, TextBox7.KeyPress, TextBox6.KeyPress, TextBox5.KeyPress, TextBox4.KeyPress, TextBox3.KeyPress, TextBox2.KeyPress, TextBox17.KeyPress, TextBox16.KeyPress, TextBox15.KeyPress, TextBox14.KeyPress, TextBox13.KeyPress, TextBox12.KeyPress, TextBox11.KeyPress, TextBox10.KeyPress, TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            MessageBox.Show("Please enter valid number ")
        End If
    End Sub

    Private Sub Enter_TEXT(sender As Object, e As EventArgs) Handles TextBox9.Validated, TextBox8.Validated, TextBox7.Validated, TextBox6.Validated, TextBox5.Validated, TextBox4.Validated, TextBox3.Validated, TextBox2.Validated, TextBox17.Validated, TextBox16.Validated, TextBox15.Validated, TextBox14.Validated, TextBox13.Validated, TextBox12.Validated, TextBox11.Validated, TextBox10.Validated, TextBox1.Validated
        Dim txt As TextBox = sender

        If (txt.Text = "") Then
            txt.Text = "0"
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class
