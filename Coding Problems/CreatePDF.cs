using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//NOTE the imports
using System.Diagnostics;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
//Install-Package PdfSharp -Version 1.50.5147
namespace Coding_Problems
{
    class CreatePDF
    {
        public static void PDF()
        {
            //dont forget the imports
            // change to var name = SaveEmployee.name 
            string empID = "testID";
            string empName = "testName";
            string empSurname = "testsurname";
            string bankName = "testBankName";
            string bankBranch = "testBranch";
            string accountNumber = "testAccNo";
            string accountType = "testAccType";
            string branchCode = "testBranchCode";
            //below are var that I created
            string basicSalary = "testBasicSalary";
            string empAddress = "testAddress";
            string payPeriod = "testPayPeriod";
            string taxNumber = "testTaxNumber";
            string comCompletedJobs = "testCom";
            string bonus = "testBonus";
            string totalRemuneration = "testTotalRem";
            string comWeek1 = "testWeek1";
            string comWeek2 = "testWeek2";
            string comWeek3 = "testWeek3";
            string comWeek4 = "testWeek4";
            string comWeek5 = "testWeek5";
            string comTotal = "testComTotal";
            string totalEarnings = "TestTotalEarnings";
            string travWeek1 = "testWeek1";
            string travWeek2 = "testWeek2";
            string travWeek3 = "testWeek3";
            string travWeek4 = "testWeek4";
            string travWeek5 = "testWeek5";
            string travTotal = "testTravTotal";
            string unpaidLeaveDays = "testDays";
            string unpaidLeave = "testUnpaidLeave";
            string payeTax = "testPayeTax";
            string UIF = "testUIF";
            string otherDeduct = "testOtherDeducts";
            string totalDeducts = "testTotalDeducts";
            string nettPay = "TestNettPay";

            string leaveDaysDate = "testDate";
            string leaveDaysAva = "testLeaveDays";


            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "" + empSurname + " " + DateTime.Now.Date;
            PdfPage pdfPage = pdf.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Verdana", 6, XFontStyle.Regular);
            XFont fontTitles = new XFont("Verdana", 8, XFontStyle.Bold);
            XFont fontDetails = new XFont("Verdana", 6, XFontStyle.Bold);
            //colour boxes
            XRect empDetsBox = new XRect(98, 106, 400, 75);
            gfx.DrawRectangle(XBrushes.DarkBlue, empDetsBox);
            XRect empDetsBoxVars1 = new XRect(200, 120, 295, 8);
            gfx.DrawRectangle(XBrushes.White, empDetsBoxVars1);
            XRect empDetsBoxVars2 = new XRect(200, 130, 295, 8);
            gfx.DrawRectangle(XBrushes.White, empDetsBoxVars2);
            XRect empDetsBoxVars3 = new XRect(200, 140, 295, 8);
            gfx.DrawRectangle(XBrushes.White, empDetsBoxVars3);
            XRect empDetsBoxVars4 = new XRect(200, 150, 295, 8);
            gfx.DrawRectangle(XBrushes.White, empDetsBoxVars4);
            XRect empDetsBoxVars5 = new XRect(200, 160, 295, 8);
            gfx.DrawRectangle(XBrushes.White, empDetsBoxVars5);
            XRect empDetsBoxVars6 = new XRect(200, 170, 295, 8);
            gfx.DrawRectangle(XBrushes.White, empDetsBoxVars6);

            XRect RemDetsBox = new XRect(98, 185, 400, 10);
            gfx.DrawRectangle(XBrushes.DarkBlue, RemDetsBox);
            XRect RemDetsBoxVar = new XRect(98, 195, 400, 40);
            gfx.DrawRectangle(XBrushes.LightBlue, RemDetsBoxVar);
            XRect RemDetsBoxTot = new XRect(98, 229, 400, 12);
            gfx.DrawRectangle(XBrushes.BlueViolet, RemDetsBoxTot);

            XRect QuoteBox = new XRect(98, 245, 400, 10);
            gfx.DrawRectangle(XBrushes.DarkBlue, QuoteBox);
            XRect QuoteBoxVar = new XRect(98, 255, 400, 60);
            gfx.DrawRectangle(XBrushes.LightBlue, QuoteBoxVar);
            XRect QuoteBoxTot = new XRect(98, 309, 400, 12);
            gfx.DrawRectangle(XBrushes.BlueViolet, QuoteBoxTot);

            XRect EarnBox = new XRect(98, 324, 400, 12);
            gfx.DrawRectangle(XBrushes.BlueViolet, EarnBox);

            XRect TravelBox = new XRect(98, 340, 400, 10);
            gfx.DrawRectangle(XBrushes.DarkBlue, TravelBox);
            XRect TravelBoxVar = new XRect(98, 350, 400, 53);
            gfx.DrawRectangle(XBrushes.LightBlue, TravelBoxVar);
            XRect TravelBoxTot = new XRect(98, 399, 400, 12);
            gfx.DrawRectangle(XBrushes.BlueViolet, TravelBoxTot);

            XRect DeductsBox = new XRect(98, 415, 400, 10);
            gfx.DrawRectangle(XBrushes.DarkBlue, DeductsBox);
            XRect DeductsBoxVar = new XRect(98, 425, 400, 43);
            gfx.DrawRectangle(XBrushes.LightBlue, DeductsBoxVar);
            XRect DeductsBoxTot = new XRect(98, 464, 400, 12);
            gfx.DrawRectangle(XBrushes.BlueViolet, DeductsBoxTot);

            XRect NetBox = new XRect(98, 479, 400, 12);
            gfx.DrawRectangle(XBrushes.DarkBlue, NetBox);

            XRect LeaveBox = new XRect(98, 494, 400, 12);
            gfx.DrawRectangle(XBrushes.LightBlue, LeaveBox);

            //add logo . Note file path and to change
            gfx.DrawImage(XImage.FromFile(@"C:\Users\grant\Downloads\IMG-20190629-WA0009.jpg"), 120, 0);//! note jpg!

            //add text
            gfx.DrawString("TEL: 0861 2468 73 | FAX: 086 508 0770 | info@househoppers ", font, XBrushes.Blue, new XRect(0, 90, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
            gfx.DrawString("746 Ribbon Ave, Little Falls | PO Box 1334, Subensvalley 1375", font, XBrushes.Blue, new XRect(0, 96, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);

            gfx.DrawString("EMPLOYEE DETAILS", fontTitles, XBrushes.White, new XRect(0, 107, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
            gfx.DrawString("NAME", fontTitles, XBrushes.White, new XRect(100, 120, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("" + empName + " " + empSurname, fontDetails, XBrushes.Blue, new XRect(70, 120, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
            gfx.DrawString("ID", fontTitles, XBrushes.White, new XRect(100, 130, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("" + empID, fontDetails, XBrushes.Blue, new XRect(70, 130, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
            gfx.DrawString("ADDRESS", fontTitles, XBrushes.White, new XRect(100, 140, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("" + empAddress, fontDetails, XBrushes.Blue, new XRect(70, 140, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
            gfx.DrawString("PAY PERIOD", fontTitles, XBrushes.White, new XRect(100, 150, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("" + payPeriod, fontDetails, XBrushes.Blue, new XRect(70, 150, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
            gfx.DrawString("BANKING DETAILS", fontTitles, XBrushes.White, new XRect(100, 160, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("" + bankName + ", " + bankBranch + ", " + accountNumber + ", " + accountType + ", " + branchCode, fontDetails, XBrushes.Blue, new XRect(70, 160, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
            gfx.DrawString("TAX NUMBER", fontTitles, XBrushes.White, new XRect(100, 170, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("" + taxNumber, fontDetails, XBrushes.Blue, new XRect(70, 170, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);


            gfx.DrawString("BASIC SALARY", fontTitles, XBrushes.DarkBlue, new XRect(100, 200, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + basicSalary, fontDetails, XBrushes.Blue, new XRect(-100, 200, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
            gfx.DrawString("COMMISION ON JOBS COMPLETED", fontTitles, XBrushes.DarkBlue, new XRect(100, 210, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + comCompletedJobs, fontDetails, XBrushes.Blue, new XRect(-100, 210, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
            gfx.DrawString("BONUS", fontTitles, XBrushes.DarkBlue, new XRect(100, 220, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + bonus, fontDetails, XBrushes.Blue, new XRect(-100, 220, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
            gfx.DrawString("TOTAL REMUNERATION", fontTitles, XBrushes.DarkBlue, new XRect(100, 230, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + totalRemuneration, fontDetails, XBrushes.Blue, new XRect(-100, 230, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);

            gfx.DrawString("COMMISSION EARNED ON QUOTES ACCEPTED", fontTitles, XBrushes.White, new XRect(0, 245, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
            gfx.DrawString("WEEK 1", fontTitles, XBrushes.DarkBlue, new XRect(100, 260, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + comWeek1, fontDetails, XBrushes.Blue, new XRect(-100, 260, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
            gfx.DrawString("WEEK 2", fontTitles, XBrushes.DarkBlue, new XRect(100, 270, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + comWeek2, fontDetails, XBrushes.Blue, new XRect(-100, 270, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
            gfx.DrawString("WEEK 3", fontTitles, XBrushes.DarkBlue, new XRect(100, 280, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + comWeek3, fontDetails, XBrushes.Blue, new XRect(-100, 280, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
            gfx.DrawString("WEEK 4", fontTitles, XBrushes.DarkBlue, new XRect(100, 290, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + comWeek4, fontDetails, XBrushes.Blue, new XRect(-100, 290, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
            gfx.DrawString("WEEK 5", fontTitles, XBrushes.DarkBlue, new XRect(100, 300, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + comWeek5, fontDetails, XBrushes.Blue, new XRect(-100, 300, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
            gfx.DrawString("TOTAL COMMISION", fontTitles, XBrushes.DarkBlue, new XRect(100, 310, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + comTotal, fontDetails, XBrushes.Blue, new XRect(-100, 310, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);

            gfx.DrawString("TOTAL EARNINGS", fontTitles, XBrushes.DarkBlue, new XRect(100, 325, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + totalEarnings, fontDetails, XBrushes.Blue, new XRect(-100, 325, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);

            gfx.DrawString("TRAVEL REIMBURSMENT", fontTitles, XBrushes.White, new XRect(0, 340, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
            gfx.DrawString("WEEK 1", fontTitles, XBrushes.DarkBlue, new XRect(100, 350, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + travWeek1, fontDetails, XBrushes.Blue, new XRect(-100, 350, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
            gfx.DrawString("WEEK 2", fontTitles, XBrushes.DarkBlue, new XRect(100, 360, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + travWeek2, fontDetails, XBrushes.Blue, new XRect(-100, 360, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
            gfx.DrawString("WEEK 3", fontTitles, XBrushes.DarkBlue, new XRect(100, 370, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + travWeek3, fontDetails, XBrushes.Blue, new XRect(-100, 370, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
            gfx.DrawString("WEEK 4", fontTitles, XBrushes.DarkBlue, new XRect(100, 380, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + travWeek4, fontDetails, XBrushes.Blue, new XRect(-100, 380, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
            gfx.DrawString("WEEK 5", fontTitles, XBrushes.DarkBlue, new XRect(100, 390, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + travWeek5, fontDetails, XBrushes.Blue, new XRect(-100, 390, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
            gfx.DrawString("TOTAL COMMISION", fontTitles, XBrushes.DarkBlue, new XRect(100, 400, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + travTotal, fontDetails, XBrushes.Blue, new XRect(-100, 400, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);

            gfx.DrawString("DEDUCTIONS", fontTitles, XBrushes.White, new XRect(0, 415, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
            gfx.DrawString("UNPAID LEAVE", fontTitles, XBrushes.DarkBlue, new XRect(100, 425, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("DAYS    " + unpaidLeaveDays, fontDetails, XBrushes.DarkBlue, new XRect(0, 425, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
            gfx.DrawString("R " + unpaidLeave, fontDetails, XBrushes.Blue, new XRect(-100, 425, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
            gfx.DrawString("PAYE TAX", fontTitles, XBrushes.DarkBlue, new XRect(100, 435, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + payeTax, fontDetails, XBrushes.Blue, new XRect(-100, 435, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
            gfx.DrawString("UIF CONTRIBUTION", fontTitles, XBrushes.DarkBlue, new XRect(100, 445, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + UIF, fontDetails, XBrushes.Blue, new XRect(-100, 445, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
            gfx.DrawString("OTHER DEDUCTIONS", fontTitles, XBrushes.DarkBlue, new XRect(100, 455, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + otherDeduct, fontDetails, XBrushes.Blue, new XRect(-100, 455, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);
            gfx.DrawString("TOTAL DEDUCTIONS", fontTitles, XBrushes.DarkBlue, new XRect(100, 465, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + totalDeducts, fontDetails, XBrushes.Blue, new XRect(-100, 465, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);

            gfx.DrawString("NETT PAY", fontTitles, XBrushes.White, new XRect(100, 480, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString("R " + nettPay, fontDetails, XBrushes.White, new XRect(-100, 480, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);

            gfx.DrawString("LEAVE DAYS AVAILABLE", fontTitles, XBrushes.DarkBlue, new XRect(100, 495, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString(leaveDaysDate + "              " + leaveDaysAva, fontDetails, XBrushes.DarkBlue, new XRect(-100, 495, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopRight);

            //saving pdf . NOTE surname being the save name & check default save location
            string pdfFilename = empSurname + "-" + payPeriod + ".pdf";
            pdf.Save(pdfFilename);

            //optional. displays pdf
            Process.Start(pdfFilename);

            //needed to close pdfSharp gtx to create another pdf
            gfx.Dispose();
        }

    }
}

