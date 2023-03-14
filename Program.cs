Console.WriteLine("Unicredit");


string[] qadBankArray = (Methods.Class1.ReadFile()).SkipLast(1).ToArray();


string[] multiOrderArray = new string[qadBankArray.Length];


for (int i = 0; i < qadBankArray.Length; i++)
{
    switch (Methods.Class1.ParseString(qadBankArray[i], 110)[1])
    {
        case "DFT":



    if (Methods.Class1.ParseString(qadBankArray[i], 110)[82] != "Y")
    {
        string[] singleOrderArrayDFT = new string[13];


        ///// Com В этой секции мы соотносим переменные из массива QAD с Unicredit файлом

                singleOrderArrayDFT[0] = _ = Methods.Class1.ConvertCurrency(Methods.Class1.ParseString(qadBankArray[i], 110)[7]); //Тип документа	DocType	rubPayment	Да	rubPayment
                singleOrderArrayDFT[1] = _ = Methods.Class1.ConvertDate(Methods.Class1.ParseString(qadBankArray[i], 110)[2]);//Дата документа	DocDate	11.01.2021	Да	N!2.N!2.N!4 (DD.MM.YYYY)
                singleOrderArrayDFT[2] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[23];//Номер документа	DocNumber	1002	Да	N5
                singleOrderArrayDFT[3] = _ = Methods.Class1.ConvertPaymentMethod(Methods.Class1.ParseString(qadBankArray[i], 110)[75]);//Тип передачи документа	SendType	Электронно	Да	=‘ ’|Электронно |Почтой |Телеграфом
                singleOrderArrayDFT[4] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[8];//Сумма платежа	Amount	88.23	Да	N11.N2
                singleOrderArrayDFT[5] = _ = Methods.Class1.ConvertLearAccount(Methods.Class1.ParseString(qadBankArray[i], 110)[10]);//Счет отправителя	PayerAccount	40702810488881200001	Да	N!20
                singleOrderArrayDFT[6] = _ = Methods.Class1.ConvertTaxNum(Methods.Class1.ParseString(qadBankArray[i], 110)[7]);//ИНН отправителя	PayerINN	555555555555	Да	N!10
                singleOrderArrayDFT[7] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[42];//Счет получателя	BeneficiaryAccount	40702810538170000001	Да	N!20
                singleOrderArrayDFT[8] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[43] + Methods.Class1.ParseString(qadBankArray[i], 110)[44] + Methods.Class1.ParseString(qadBankArray[i], 110)[45] + Methods.Class1.ParseString(qadBankArray[i], 110)[46]; ;//Имя получателя	BeneficiaryName	ЗАО «Получатель»	Да	A160
                singleOrderArrayDFT[9] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[51];//ИНН получателя	BeneficiaryINN	7707999999	Да	N12
                singleOrderArrayDFT[10] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[49];//БИК банка получателя	BeneficiaryBankBIK	044525225	Да	N!9
                singleOrderArrayDFT[11] = _ = Methods.Class1.ClearNonUTF8(Methods.Class1.ParseString(qadBankArray[i], 110)[70] + Methods.Class1.ParseString(qadBankArray[i], 110)[71] + Methods.Class1.ParseString(qadBankArray[i], 110)[72] + Methods.Class1.ParseString(qadBankArray[i], 110)[73]);//Назначение платежа	Ground	{VO20050} Оплата по счету 16 от 11.01.2021 г. за консультационные услуги. НДС не облагается	Да	A210
                singleOrderArrayDFT[12] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[52];//13	Очередность платежа	PaymentUrgency	4	Да	N2



        ///// Com В этой секции мы соотносим переменные из массива QAD с Unicredit файлом


        multiOrderArray[i] = string.Join("~",singleOrderArrayDFT);

    }


    else
    {
        string[]  singleOrderArrayDFT = new string[26];
        ///// Tax В этой секции мы соотносим переменные из массива QAD с Unicredit файлом


                singleOrderArrayDFT[0] = _ = Methods.Class1.ConvertCurrency(Methods.Class1.ParseString(qadBankArray[i], 110)[7]); //Тип документа	DocType	rubPayment	Да	rubPayment
                singleOrderArrayDFT[1] = _ = Methods.Class1.ConvertDate(Methods.Class1.ParseString(qadBankArray[i], 110)[2]);//Дата документа	DocDate	11.01.2021	Да	N!2.N!2.N!4 (DD.MM.YYYY)
                singleOrderArrayDFT[2] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[23];//Номер документа	DocNumber	1002	Да	N5
                singleOrderArrayDFT[3] = _ = Methods.Class1.ConvertPaymentMethod(Methods.Class1.ParseString(qadBankArray[i], 110)[75]);//Тип передачи документа	SendType	Электронно	Да	=‘ ’|Электронно |Почтой |Телеграфом
                singleOrderArrayDFT[4] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[8];//Сумма платежа	Amount	88.23	Да	N11.N2
                singleOrderArrayDFT[5] = _ = Methods.Class1.ConvertLearAccount(Methods.Class1.ParseString(qadBankArray[i], 110)[10]);//Счет отправителя	PayerAccount	40702810488881200001	Да	N!20
                singleOrderArrayDFT[6] = _ = Methods.Class1.ConvertTaxNum(Methods.Class1.ParseString(qadBankArray[i], 110)[7]);//ИНН отправителя	PayerINN	555555555555	Да	N!10
                singleOrderArrayDFT[7] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[42];//Счет получателя	BeneficiaryAccount	40702810538170000001	Да	N!20
                singleOrderArrayDFT[8] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[43] + Methods.Class1.ParseString(qadBankArray[i], 110)[44] + Methods.Class1.ParseString(qadBankArray[i], 110)[45] + Methods.Class1.ParseString(qadBankArray[i], 110)[46]; ;//Имя получателя	BeneficiaryName	ЗАО «Получатель»	Да	A160
                singleOrderArrayDFT[9] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[51];//ИНН получателя	BeneficiaryINN	7707999999	Да	N12
                singleOrderArrayDFT[10] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[49];//БИК банка получателя	BeneficiaryBankBIK	044525225	Да	N!9
                singleOrderArrayDFT[11] = _ = Methods.Class1.ClearNonUTF8(Methods.Class1.ParseString(qadBankArray[i], 110)[70] + Methods.Class1.ParseString(qadBankArray[i], 110)[71] + Methods.Class1.ParseString(qadBankArray[i], 110)[72] + Methods.Class1.ParseString(qadBankArray[i], 110)[73]);//Назначение платежа	Ground	{VO20050} Оплата по счету 16 от 11.01.2021 г. за консультационные услуги. НДС не облагается	Да	A210
                singleOrderArrayDFT[12] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[52];//13	Очередность платежа	PaymentUrgency	4	Да	N2
                singleOrderArrayDFT[13] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[83];//Статус (поле 101)	Fiscal101	01	Налоговый	N!2
                singleOrderArrayDFT[14] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[81];//КПП плательщика	Fiscal102	773333333	Налоговый	N!9
                singleOrderArrayDFT[15] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[84];//КПП получателя	Fiscal103	770000001	Налоговый	N!9
                singleOrderArrayDFT[16] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[85];//Код бюджетной классификации (КБК)	Fiscal104	00010102020010000110	Налоговый	N!20
                singleOrderArrayDFT[17] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[86];//Код ОКАТО	Fiscal105	22222222	Налоговый	N8
                singleOrderArrayDFT[18] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[87];//Основание платежа	Fiscal106	ТП	Налоговый	A!2
                singleOrderArrayDFT[19] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[88];//Налоговый период или Код таможенного органа	Fiscal107	КВ.03.2010 10005000	Налоговый Таможенный	A!2.N!2.N!4N!8
                singleOrderArrayDFT[20] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[89];//Номер налогового документа (индекс)	Fiscal108	3	Налоговый	N5
                singleOrderArrayDFT[21] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[90];//Дата налогового документа	Fiscal109	29.08.2010	Налоговый	N!2.N!2.N!4 (DD.MM.YYYY)|’0’|’00’
                singleOrderArrayDFT[22] = _ = "";//Methods.Class1.ParseString(qadBankArray[i], 110)[3];Код выплат	PayoutCode	1	Нет	‘’|‘1’
                singleOrderArrayDFT[23] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[19];//Код (УИН)	Fiscal22	12345678901234567890	Налоговый	A25
                singleOrderArrayDFT[24] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[93];//Код вида дохода	IncomeType	1	Нет	‘’|‘1’|‘2’|‘3’
                singleOrderArrayDFT[25] = _ = "";//Methods.Class1.ParseString(qadBankArray[i], 110)[42];//Счет банка получателя	BeneficiaryBankAccount	40102810845370000052	Нет	N!20



        ///// Tax В этой секции мы соотносим переменные из массива QAD с Unicredit файлом


        multiOrderArray[i] = string.Join("~",singleOrderArrayDFT);
    }
            break;
        case "EFT":
            string[] singleOrderArrayEFT = new string[23];

            ///// Currency В этой секции мы соотносим переменные из массива QAD с Unicredit файлом

            singleOrderArrayEFT[0] = _ = Methods.Class1.ConvertCurrency(Methods.Class1.ParseString(qadBankArray[i], 110)[7]); //Тип документа	DocType	rubPayment	Да	rubPayment
            singleOrderArrayEFT[1] = _ = Methods.Class1.ConvertDate(Methods.Class1.ParseString(qadBankArray[i], 110)[2]);//Дата документа	DocDate	11.01.2021	Да	N!2.N!2.N!4 (DD.MM.YYYY)
            singleOrderArrayEFT[2] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[23];//Номер документа	DocNumber	1002	Да	N5
            singleOrderArrayEFT[3] = _ = ""; //Срочность платежа 
            singleOrderArrayEFT[4] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[8];//Сумма платежа
            singleOrderArrayEFT[5] = _ =  Methods.Class1.ParseString(qadBankArray[i], 110)[7];//Код валюты платежа
            singleOrderArrayEFT[6] = _ = Methods.Currency.ConvertLearAccount(Methods.Class1.ParseString(qadBankArray[i], 110)[10]);//Счёт Плательщика 010004882
            singleOrderArrayEFT[7] = _ =  Methods.Class1.ParseString(qadBankArray[i], 110)[42];//Счёт бенефициара
            singleOrderArrayEFT[8] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[43];//Наименование Бенефициара
            singleOrderArrayEFT[9] = _ = "";//Код страны Бенефициара не заполняем
            singleOrderArrayEFT[10] = _ = "";//Адрес (улица, дом) Бенефициара не заполняем
            singleOrderArrayEFT[11] = _ = "";//Город Бенефициара не заполняем
            singleOrderArrayEFT[12] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[49]; //SWIFT-код Банка Бенефициара AGRIFRPP847
            singleOrderArrayEFT[13] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[53];//Наименование Банка Бенефициара CREDIT AGRICOLE
            singleOrderArrayEFT[14] = _ = "";//Счёт Банка Бенефициара в Банке-посреднике не заполняем
            singleOrderArrayEFT[15] = _ = "";//Код страны Банка Бенефициара подтягивается автоматически
            singleOrderArrayEFT[16] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[54]+ Methods.Class1.ParseString(qadBankArray[i], 110)[55]+ Methods.Class1.ParseString(qadBankArray[i], 110)[56];//Адрес Банка Бенефициара La Garde-Route de Paris, Nantes
            singleOrderArrayEFT[17] = _ = "";//SWIFT-код Банка-посредника не указываем
            singleOrderArrayEFT[18] = _ =  Methods.Class1.ClearNonUTF8(Methods.Class1.ParseString(qadBankArray[i], 110)[70] + Methods.Class1.ParseString(qadBankArray[i], 110)[71] + Methods.Class1.ParseString(qadBankArray[i], 110)[72] + Methods.Class1.ParseString(qadBankArray[i], 110)[73]);//Назначение платежа
            singleOrderArrayEFT[19] = _ = Methods.Class1.ParseString(qadBankArray[i], 110)[20];//Тип списания комиссии OUR
            singleOrderArrayEFT[20] = _ = Methods.Currency.ConvertChargeLearAccount();//Счёт списания комиссии 40702810800014609662
            singleOrderArrayEFT[21] = _ = "";//Дополнительные инструкции
            singleOrderArrayEFT[22] = _ = ""; //Референс из сторонней системы (Строка для совместимости с предыдущей версией формата)

            ///// Currency В этой секции мы соотносим переменные из массива QAD с Unicredit файлом

            multiOrderArray[i] = string.Join("~", singleOrderArrayEFT);

            break;
}

}

await Methods.Class1.WriteAsync(multiOrderArray);
Console.WriteLine("Готово. Нажмите Ввод");
Console.ReadLine();
