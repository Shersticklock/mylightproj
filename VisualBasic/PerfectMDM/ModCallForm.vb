Module ModCallForm
    Sub CallForm(ByVal HeadNameServices As String, ByVal formNumber As Integer, ByVal selectFormType As Integer)
        Dim frmSelect As New Form

        Select Case selectFormType
            Case Is = 1
                Select Case formNumber
                    Case Is = 1 : frmSelect = New c_UCWOCmdm : frmSelect.Text = HeadNameServices

                    Case Is = 16 : frmSelect = New c_SaleMatAll : frmSelect.Text = HeadNameServices
                    Case Is = 31 : frmSelect = New c_OtherServices : frmSelect.Text = HeadNameServices
                    Case Is = 33 : frmSelect = New c_OtherServicesWOM 'услуги без материала
                    Case Is = 30 : frmSelect = New c_PlotCut : frmSelect.Text = HeadNameServices
                    Case Is = 39 : frmSelect = New c_UniCost : frmSelect.Text = HeadNameServices  'универсальный 
                        '   Case Is = 50 : frmSelect = New c_ServiceIntOther : frmSelect.Text = HeadNameServices 'калькулятор на отд таб услуг иерарх
                    Case Is = 52 : frmSelect = New c_UniCostWOColor : frmSelect.Text = HeadNameServices
                    Case Is = 53 : frmSelect = New c_UniCostGM : frmSelect.Text = HeadNameServices
                    Case Is = 58 : frmSelect = New c_WFormat : frmSelect.Text = HeadNameServices    'калькулятор для чертежей
                    Case Is = 59 : frmSelect = New c_UVprint : frmSelect.Text = HeadNameServices
                    Case Is = 61 : frmSelect = New c_LargeFomat ': frmSelect.Text = HeadNameServices 'калькулятор ШФ
                    Case Is = 63 : frmSelect = New c_GM : frmSelect.Text = HeadNameServices  'калькулятор 
                    Case Is = 77 : frmSelect = New c_FastOrder : frmSelect.Text = HeadNameServices  'быстрых заказов
                    Case Is = 178 : frmSelect = New c_FastOrderNew : frmSelect.Text = HeadNameServices  'быстрых заказов
                    Case Is = 777 : frmSelect = New c_PolygraphBind : frmSelect.Text = HeadNameServices   'многостраничка
                End Select

            Case Is = 2
                Select Case formNumber 'вызов форм прайсов
                    Case Is = 0 : Exit Sub
                    Case Is = 1
                        Exit Sub
                    Case Is = 2 : frmSelect = New cu_UniPrice : frmSelect.Text = "Цены по направлению " & HeadNameServices : frmSelect.Show() : Exit Sub
                    Case Is = 3 : frmSelect = New tech_Equipment

                End Select

            Case Is = 3
                Select Case formNumber 'вызов форм обеспечения
                    Case Is = 1 : frmSelect = New spr_Common : frmSelect.Text = HeadNameServices : sprCaption = HeadNameServices
                    Case Is = 2 : frmSelect = New frmReports : frmSelect.Show() : Exit Sub
                    Case Is = 3 : frmSelect = New fin_Kassa
                    Case Is = 4 : frmSelect = New frmTableDB : frmSelect.Show() : Exit Sub
                    Case Is = 5 : frmSelect = New frmEmployees
                        'Case Is = 6 : frmSelect = New frmExpens
                    Case Is = 7 : frmSelect = New frmMaterials
                    Case Is = 8 : frmSelect = New webMaper : frmSelect.Show() : Exit Sub
                    Case Is = 9 : frmSelect = New frmKAgents
                    Case Is = 10 : frmSelect = New frmMarketing
                    Case Is = 11 : frmSelect = New frmOrder
                    Case Is = 12 : frmSelect = New frmSklad : frmSelect.Show() : Exit Sub
                    Case Is = 13 : frmSelect = New frmEmplRole
                    Case Is = 14 : frmSelect = New frmDocFile
                    Case Is = 15 : frmSelect = New frmOrderTask
                    Case Is = 16 : frmSelect = New frmConfigCalcMat : frmSelect.Show() : Exit Sub
                    Case Is = 17 : frmSelect = New frmLogOrderCard
                    Case Is = 18 : frmSelect = New frmLogOrders
                    Case Is = 19 : frmSelect = New frmServices
                    Case Is = 20 : frmSelect = New fin_MassPay
                    Case Is = 21 : frmSelect = New frmOrderClosing : frmSelect.Show() : Exit Sub
                    Case Is = 23 : frmSelect = New fin_ArtExpens
                    Case Is = 24 : frmSelect = New fin_EmplPaym
                    Case Is = 25 : frmSelect = New fzpEmplPenalty
                        'Case Is = 26 : frmSelect = New frmStandartAccUnits
                    Case Is = 27 : frmSelect = New fin_Invoices : frmSelect.Show() : Exit Sub
                    Case Is = 28 : frmSelect = New fin_InvoiceCard
                    Case Is = 29 : frmSelect = New frmOrderPayment
                    Case Is = 30 : frmSelect = New tech_TasksInWork
                    Case Is = 31 : frmSelect = New fzp_EmplPlan : frmSelect.Show() : Exit Sub
                    Case Is = 33 : frmSelect = New frmSkladInventar
                    Case Is = 34 : frmSelect = New frmSkladArrival
                    Case Is = 35 : frmSelect = New fin_SalaryEmpl
                    Case Is = 36 : frmSelect = New fin_Exp_on_period
                    Case Is = 37 : frmSelect = New frmTransData
                    Case Is = 38 : frmSelect = New webGanter : frmSelect.Show() : Exit Sub
                    Case Is = 39 : frmSelect = New frmWeb : frmSelect.Text = HeadNameServices : frmSelect.Show() : Exit Sub
                    Case Is = 40 : frmSelect = New frmMatCostCorr : frmSelect.Show() : Exit Sub
                    Case Is = 41 : frmSelect = New frmMatForOper : frmSelect.Show() : Exit Sub
                    Case Is = 42 : frmSelect = New frmProduktNew
                End Select
        End Select

        frmSelect.Text = HeadNameServices
        frmSelect.ShowDialog()
    End Sub

    Sub CallConfigParam() ' с определением когда будет видна опция восстановления БД из бэкапа
        Dim frmSelect As New frmConfigParam
        frmSelect.ShowDialog()
    End Sub
End Module
