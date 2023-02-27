Console.WriteLine("Unicredit");


string[] qadBankArray = (Methods.Class1.ReadFile()).SkipLast(1).ToArray();


string[] multiOrderArray = new string[qadBankArray.Length];


for (int i = 0; i < qadBankArray.Length; i++)
{

    if (Methods.Class1.ParseString(qadBankArray[i], 110)[82] != "Y")
    {
        string[] singleOrderArray = new string[13];


        ///// Com В этой секции мы соотносим переменные из массива QAD с Unicredit файлом

        singleOrderArray[0] = _ = Methods.Class1.ConvertCurrency(Methods.Class1.ParseString(qadBankArray[i], 110)[7]); //Тип документа	DocType	rubPayment	Да	rubPayment
        singleOrderArray[1] = _ = Methods.Class1.ConvertDate(Methods.Class1.ParseString(qadBankArray[i], 110)[2]);//Дата документа	DocDate	11.01.2021	Да	N!2.N!2.N!4 (DD.MM.YYYY)
        singleOrderArray[2] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[23];//Номер документа	DocNumber	1002	Да	N5
        singleOrderArray[3] = _ = Methods.Class1.ConvertPaymentMethod(Methods.Class1.ParseString(qadBankArray[i], 110)[75]);//Тип передачи документа	SendType	Электронно	Да	=‘ ’|Электронно |Почтой |Телеграфом
        singleOrderArray[4] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[8];//Сумма платежа	Amount	88.23	Да	N11.N2
        singleOrderArray[5] = _ = Methods.Class1.ConvertLearAccount(Methods.Class1.ParseString(qadBankArray[i], 110)[10]);//Счет отправителя	PayerAccount	40702810488881200001	Да	N!20
        singleOrderArray[6] = _ = Methods.Class1.ConvertTaxNum(Methods.Class1.ParseString(qadBankArray[i], 110)[7]);//ИНН отправителя	PayerINN	555555555555	Да	N!10
        singleOrderArray[7] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[42];//Счет получателя	BeneficiaryAccount	40702810538170000001	Да	N!20
        singleOrderArray[8] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[43] + Methods.Class1.ParseString(qadBankArray[i], 110)[44] + Methods.Class1.ParseString(qadBankArray[i], 110)[45] + Methods.Class1.ParseString(qadBankArray[i], 110)[46]; ;//Имя получателя	BeneficiaryName	ЗАО «Получатель»	Да	A160
        singleOrderArray[9] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[51];//ИНН получателя	BeneficiaryINN	7707999999	Да	N12
        singleOrderArray[10] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[49];//БИК банка получателя	BeneficiaryBankBIK	044525225	Да	N!9
        singleOrderArray[11] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[70] + Methods.Class1.ParseString(qadBankArray[i], 110)[71] + Methods.Class1.ParseString(qadBankArray[i], 110)[72]+ Methods.Class1.ParseString(qadBankArray[i], 110)[73];//Назначение платежа	Ground	{VO20050} Оплата по счету 16 от 11.01.2021 г. за консультационные услуги. НДС не облагается	Да	A210
        singleOrderArray[12] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[52];//13	Очередность платежа	PaymentUrgency	4	Да	N2
                                                                                        // singleOrderArray[13] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[83];//Статус (поле 101)	Fiscal101	01	Налоговый	N!2
                                                                                        // singleOrderArray[14] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[81];//КПП плательщика	Fiscal102	773333333	Налоговый	N!9
                                                                                        // singleOrderArray[15] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[84];//КПП получателя	Fiscal103	770000001	Налоговый	N!9
                                                                                        // singleOrderArray[16] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[85];//Код бюджетной классификации (КБК)	Fiscal104	00010102020010000110	Налоговый	N!20
                                                                                        //singleOrderArray[17] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[86];//Код ОКАТО	Fiscal105	22222222	Налоговый	N8
                                                                                        // singleOrderArray[18] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[87];//Основание платежа	Fiscal106	ТП	Налоговый	A!2
                                                                                        // singleOrderArray[19] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[88];//Налоговый период или Код таможенного органа	Fiscal107	КВ.03.2010 10005000	Налоговый Таможенный	A!2.N!2.N!4N!8
                                                                                        // singleOrderArray[20] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[89];//Номер налогового документа (индекс)	Fiscal108	3	Налоговый	N5
                                                                                        // singleOrderArray[21] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[90];//Дата налогового документа	Fiscal109	29.08.2010	Налоговый	N!2.N!2.N!4 (DD.MM.YYYY)|’0’|’00’
                                                                                        // singleOrderArray[22] = _ = "";//Methods.Class1.ParseString(qadBankArray[i], 110)[3];Код выплат	PayoutCode	1	Нет	‘’|‘1’
                                                                                        // singleOrderArray[23] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[19];//Код (УИН)	Fiscal22	12345678901234567890	Налоговый	A25
                                                                                        // singleOrderArray[24] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[19];//Код вида дохода	IncomeType	1	Нет	‘’|‘1’|‘2’|‘3’
                                                                                        // singleOrderArray[25] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[42];//Счет банка получателя	BeneficiaryBankAccount	40102810845370000052	Нет	N!20



        ///// Com В этой секции мы соотносим переменные из массива QAD с Unicredit файлом


        multiOrderArray[i] = string.Join("~", singleOrderArray);

    }


    else
    {
        string[] singleOrderArray = new string[26];
        ///// Tax В этой секции мы соотносим переменные из массива QAD с Unicredit файлом


        singleOrderArray[0] = _ = Methods.Class1.ConvertCurrency(Methods.Class1.ParseString(qadBankArray[i], 110)[7]); //Тип документа	DocType	rubPayment	Да	rubPayment
        singleOrderArray[1] = _ = Methods.Class1.ConvertDate(Methods.Class1.ParseString(qadBankArray[i], 110)[2]);//Дата документа	DocDate	11.01.2021	Да	N!2.N!2.N!4 (DD.MM.YYYY)
        singleOrderArray[2] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[23];//Номер документа	DocNumber	1002	Да	N5
        singleOrderArray[3] = _ = Methods.Class1.ConvertPaymentMethod(Methods.Class1.ParseString(qadBankArray[i], 110)[75]);//Тип передачи документа	SendType	Электронно	Да	=‘ ’|Электронно |Почтой |Телеграфом
        singleOrderArray[4] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[8];//Сумма платежа	Amount	88.23	Да	N11.N2
        singleOrderArray[5] = _ = Methods.Class1.ConvertLearAccount(Methods.Class1.ParseString(qadBankArray[i], 110)[10]);//Счет отправителя	PayerAccount	40702810488881200001	Да	N!20
        singleOrderArray[6] = _ = Methods.Class1.ConvertTaxNum(Methods.Class1.ParseString(qadBankArray[i], 110)[7]);//ИНН отправителя	PayerINN	555555555555	Да	N!10
        singleOrderArray[7] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[42];//Счет получателя	BeneficiaryAccount	40702810538170000001	Да	N!20
        singleOrderArray[8] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[43] + Methods.Class1.ParseString(qadBankArray[i], 110)[44] + Methods.Class1.ParseString(qadBankArray[i], 110)[45] + Methods.Class1.ParseString(qadBankArray[i], 110)[46]; ;//Имя получателя	BeneficiaryName	ЗАО «Получатель»	Да	A160
        singleOrderArray[9] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[51];//ИНН получателя	BeneficiaryINN	7707999999	Да	N12
        singleOrderArray[10] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[49];//БИК банка получателя	BeneficiaryBankBIK	044525225	Да	N!9
        singleOrderArray[11] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[70] + Methods.Class1.ParseString(qadBankArray[i], 110)[71] + Methods.Class1.ParseString(qadBankArray[i], 110)[72];//Назначение платежа	Ground	{VO20050} Оплата по счету 16 от 11.01.2021 г. за консультационные услуги. НДС не облагается	Да	A210
        singleOrderArray[12] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[52];//13	Очередность платежа	PaymentUrgency	4	Да	N2
        singleOrderArray[13] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[83];//Статус (поле 101)	Fiscal101	01	Налоговый	N!2
        singleOrderArray[14] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[81];//КПП плательщика	Fiscal102	773333333	Налоговый	N!9
        singleOrderArray[15] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[84];//КПП получателя	Fiscal103	770000001	Налоговый	N!9
        singleOrderArray[16] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[85];//Код бюджетной классификации (КБК)	Fiscal104	00010102020010000110	Налоговый	N!20
        singleOrderArray[17] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[86];//Код ОКАТО	Fiscal105	22222222	Налоговый	N8
        singleOrderArray[18] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[87];//Основание платежа	Fiscal106	ТП	Налоговый	A!2
        singleOrderArray[19] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[88];//Налоговый период или Код таможенного органа	Fiscal107	КВ.03.2010 10005000	Налоговый Таможенный	A!2.N!2.N!4N!8
        singleOrderArray[20] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[89];//Номер налогового документа (индекс)	Fiscal108	3	Налоговый	N5
        singleOrderArray[21] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[90];//Дата налогового документа	Fiscal109	29.08.2010	Налоговый	N!2.N!2.N!4 (DD.MM.YYYY)|’0’|’00’
        singleOrderArray[22] = _ = "";//Methods.Class1.ParseString(qadBankArray[i], 110)[3];Код выплат	PayoutCode	1	Нет	‘’|‘1’
        singleOrderArray[23] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[19];//Код (УИН)	Fiscal22	12345678901234567890	Налоговый	A25
        singleOrderArray[24] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[93];//Код вида дохода	IncomeType	1	Нет	‘’|‘1’|‘2’|‘3’
        singleOrderArray[25] = _ = "";//Methods.Class1.ParseString(qadBankArray[i], 110)[42];//Счет банка получателя	BeneficiaryBankAccount	40102810845370000052	Нет	N!20



        ///// Tax В этой секции мы соотносим переменные из массива QAD с Unicredit файлом


        multiOrderArray[i] = string.Join("~", singleOrderArray);
    }

    

}

await Methods.Class1.WriteAsync(multiOrderArray);
Console.WriteLine("Готово. Нажмите Ввод");
Console.ReadLine();
