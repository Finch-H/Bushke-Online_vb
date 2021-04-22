Public Class cMeal

    Public Coke As Double
    Public Origin As Double
    Public Fanta As Double
    Public Alvaro As Double
    Public BottleWater As Double
    Public Malt As Double
    Public Sprite As Double
    Public Welch As Double
    Public Rice As Double
    Public Fufu As Double
    Public Kokonte As Double
    Public Beans As Double
    Public FriedRice As Double
    Public OilRice As Double
    Public Waakye As Double
    Public Jolof As Double
    Public Banku As Double

    Public Tax_Rate As Double = 0.17

    Public pCoke As Double = 1.55
    Public pOrigin As Double = 3.0
    Public pFanta As Double = 1.55
    Public pAlvaro As Double = 1.55
    Public pBottleWater As Double = 1.0
    Public pMalt As Double = 3.0
    Public pSprite As Double = 1.55
    Public pWelch As Double = 12.0
    Public pRice As Double = 4.0
    Public pFufu As Double = 4.0
    Public pKokonte As Double = 4.0
    Public pBeans As Double = 2.55
    Public pFriedRice As Double = 5.0
    Public pOilRice As Double = 7.0
    Public pWaakye As Double = 7.0
    Public pJolof As Double = 7.0
    Public pBanku As Double = 4.0



    Public itemscost1 As Double
    Public itemscost2 As Double
    Public itemscost3 As Double
    Public itemscost4 As Double
    Public itemscost As Double
    Public Taxcost As Double

    Public Function GetAmount()
        itemscost1 = Coke + Origin + Fanta + Alvaro
        itemscost2 = BottleWater + Malt + Sprite + Welch
        itemscost3 = Rice + Fufu + Kokonte + Beans + FriedRice
        itemscost4 = OilRice + Waakye + Jolof + Banku
        itemscost = itemscost1 + itemscost2 + itemscost3 + itemscost4
        Return itemscost
    End Function

    Public Function cFindTax(ByVal cAmount As Double) As Double
        cFindTax = (cAmount * Tax_Rate)
    End Function

    Public Function GetTax() As Double
        Taxcost = cFindTax(itemscost)
        Return Taxcost
    End Function

    Public Shared Function ExitSystem()
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to exit", "Bushke Online", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If

    End Function
End Class
