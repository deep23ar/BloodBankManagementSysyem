<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pdf.aspx.cs" Inherits="bloodBankManagement.pdf" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Certificate</title>
   <style>
        body {
            font-family: Montserrat;
            margin: 0;
            padding: 0;
            background-color: #f9f9f9;
        }

        .certificate {
                display: flex;
    flex-direction: column;
    width: 1123px;
    /* align-items: center; */
    /* height: 794px; */
    justify-content: center;
    margin: 50px auto;
    padding: 20px;
    border: 5px solid navy;
    border-radius: 10px;
    background-color: #fff;
    position: relative;
        }

        .certificate h1 {
            color: red;
            font-size: 28px;
            text-align: center;
            margin: 0;
        }

        .certificate h2 {
            text-align: center;
            font-size: 24px;
            color: navy;
            margin: 10px 0;
        }

        .certificate .address {
            text-align: center;
            font-size: 14px;
            margin: 5px 0 20px 0;
        }

        .certificate .content {
            font-size: 19px;
            line-height: 1.6;
            text-align: justify;
            margin: 20px 0;
        }

        .certificate .content .name {
            font-weight: bold;
            text-decoration: underline;
        }

        .certificate .footer {
            margin-top: 30px;
            text-align: center;
            font-size: 18px;
            font-style: italic;
        }

        .certificate .signature {
            text-align: right;
            font-size: 18px;
            margin-top: 30px;
        }

        .certificate .red-drop {
            color: red;
            font-size: 32px;
            position: absolute;
        }

        .certificate .red-drop.left {
            top: 50px;
            left: 20px;
        }

        .certificate .red-drop.right {
            top: 50px;
            right: 20px;
        }
        .btn{
            display: flex;
            margin: auto;
        }
        .download-button {
            display: inline-block;
            margin-top: 20px;
            padding: 10px 20px;
            font-size: 16px;
            color: #ffffff;
            background-color: #3498db;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            text-decoration: none;
        }
        .download-button:hover {
            background-color: #2980b9;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="certificate" class="certificate">
        <h1>BLOOD CENTRE</h1>
        <h2>RAMAKRISHNA MISSION SEVA PRATISHTHAN</h2>
        <div class="address">
            99, SARAT BOSE ROAD, KOLKATA - 700 026<br>
            PHONE: +91 33 2475 3636 / 37 / 38 / 39<br>
            FAX: +91 33 2475 4351
        </div>

        <div class="content">
            

            Sri / Smt. <span class="name"><%= Session["donorName"] %></span> is hereby appreciated for his / her voluntary donation of blood at a camp organised by Ramakrishna Mission, Shilpamandira Computer Centre, Belur Math, Howrah in association with Ramakrishna Mission Seva Pratishthan on <b><%= Session["donateDate"] %></b>.
            <br><br>
            May Bhagavan Sri Ramakrishna shower His choicest blessings on him / her for this noble act benefiting the needy in society.
        </div>

        <div class="signature">
            <b>Swami Nityakamalananda</b><br>
            Secretary
        </div>

        <div class="footer">
            "Love concentrates all the power of will without effort" - Swami Vivekananda
        </div>
    </div>
    <div class="btn">
        <button type="button" class="download-button" onclick="downloadPDF()">Download PDF</button>
    </div>
</form>

    <script src="https://cdnjs.cloudflare.com/ajax/libs/jspdf/2.4.0/jspdf.umd.min.js"></script>
<script src="https://html2canvas.hertzen.com/dist/html2canvas.min.js"></script>
<script>
    async function downloadPDF() {
        const { jsPDF } = window.jspdf;

        // Get the certificate element
        const certificateElement = document.getElementById("certificate");

        // Convert the certificate to an image using html2canvas
        const canvas = await html2canvas(certificateElement);
        const imgData = canvas.toDataURL("image/png");

        // Create a new PDF in A4 landscape format
        const pdf = new jsPDF("landscape", "mm", "a4");
        const pdfWidth = pdf.internal.pageSize.getWidth();
        const pdfHeight = pdf.internal.pageSize.getHeight();

        // Adjust the image dimensions to fill the entire PDF page
        pdf.addImage(imgData, "PNG", 0, 0, pdfWidth, pdfHeight);

        // Save the PDF
        pdf.save("Certificate.pdf");
    }
</script>

</body>
</html>
