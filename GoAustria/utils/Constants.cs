using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoAustria.utils
{
	public class Constants
	{

		public static String CASH_ON_DELIVERY_MAIL = @"
<table class=MsoNormalTable border=0 cellpadding=0 width=""100%""
 style='width:100.0%;mso-cellspacing:1.5pt;mso-yfti-tbllook:1184;mso-padding-alt:
 0cm 5.4pt 0cm 5.4pt'>
 <tr style = 'mso-yfti-irow:0;mso-yfti-firstrow:yes' >
 <td colspan=2 style='padding:.75pt .75pt .75pt .75pt'>
  <p class=MsoNormal><b><span style = 'font-size:14.0pt;line-height:115%;
  font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
  mso-bidi-theme-font:minor-bidi'>Kedves $NAME$!</span></b><span
  style='font-size:14.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'><o:p></o:p></span></p>
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'><o:p>&nbsp;</o:p></span></p>
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>A mai napon ($DATE$) a következő rendelést adtad le internetes
  áruházunkban:<o:p></o:p></span></p>
  <p class=MsoNormal><span style = 'font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'><o:p>&nbsp;</o:p></span></p>
  <table class=MsoNormalTable border = 0 cellpadding=0 width=""100%""
   style='width:100.0%;mso-cellspacing:1.5pt;mso-yfti-tbllook:1184;mso-padding-alt:
   0cm 5.4pt 0cm 5.4pt'>
   <tr style = 'mso-yfti-irow:0;mso-yfti-firstrow:yes' >

	<td colspan=2 style='padding:.75pt .75pt .75pt .75pt'>
    <h4><span style = 'font-size:14.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;

	mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:major-bidi'>Rendelési
    adatok<o:p></o:p></span></h4>
    </td>
   </tr>
   <tr style = 'mso-yfti-irow:1' >

	<td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt' >
 
	<p class=MsoNormal><strong><span style = 'font-size:12.0pt;line-height:115%;

	font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
    mso-bidi-theme-font:minor-bidi'>Rendelésszám:</span></strong><span
    style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
    mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'><o:p></o:p></span></p>
    </td>
    <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
    <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;

	font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
    mso-bidi-theme-font:minor-bidi'>$ORDER_NUMBER$<o:p></o:p></span></p>
    </td>
   </tr>
   <tr style = 'mso-yfti-irow:2;mso-yfti-lastrow:yes' >

	<td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt' >
 
	<p class=MsoNormal><strong><span style = 'font-size:12.0pt;line-height:115%;

	font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
    mso-bidi-theme-font:minor-bidi'>Rendelés dátuma:</span></strong><span
    style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
    mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'><o:p></o:p></span></p>
    </td>
    <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
    <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;

	font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
    mso-bidi-theme-font:minor-bidi'>$ORDER_DATE$<o:p></o:p></span></p>
    </td>
   </tr>
  </table>
  <p class=MsoNormal><span style = 'font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'><o:p>&nbsp;</o:p></span></p>
  <table class=MsoNormalTable border = 0 cellpadding=0 width=""105%""
   style='width:105.56%;mso-cellspacing:1.5pt;mso-yfti-tbllook:1184;mso-padding-alt:
   0cm 5.4pt 0cm 5.4pt'>
   <thead>
    <tr style = 'mso-yfti-irow:0;mso-yfti-firstrow:yes' >

	<td style='padding:.75pt .75pt .75pt .75pt'>
     <p class=MsoNormal><b style = 'mso-bidi-font-weight:normal' ><span

	 style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
     mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>Termék
     neve<o:p></o:p></span></b></p>
     </td>
     <td width = ""13%"" style='width:13.3%;padding:.75pt .75pt .75pt .75pt'>
     <p class=MsoNormal><b style = 'mso-bidi-font-weight:normal' ><span

	 style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
     mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>Mennyiség</span></b><span
     style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
     mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'><o:p></o:p></span></p>
     </td>
     <td width = ""18%"" style='width:18.92%;padding:.75pt .75pt .75pt .75pt'>
     <p class=MsoNormal style = 'margin-left:8.25pt' ><b style='mso-bidi-font-weight:
     normal'><span style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
     mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>Fogyasztói
     ár<o:p></o:p></span></b></p>
     </td>
     <td style = 'padding:.75pt .75pt .75pt .75pt' >

	<p class=MsoNormal><b style = 'mso-bidi-font-weight:normal' ><span

	 style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
     mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>Összesen</span></b><span
     style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
     mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'><o:p></o:p></span></p>
     </td>
    </tr>
    <tr style = 'mso-yfti-irow:1' >

	<td style='padding:.75pt .75pt .75pt .75pt'>
     <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;

	 font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
     mso-bidi-theme-font:minor-bidi'>Munkavállalás Ausztriában Lépésről Lépésre
     Könyv<o:p></o:p></span></p>
     </td>
     <td width = ""13%"" style='width:13.3%;padding:.75pt .75pt .75pt .75pt'>
     <p class=MsoNormal align = center style='text-align:center'><span
	   style = 'font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;

	 mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>$QTY$
     db<o:p></o:p></span></p>
     </td>
     <td width = ""18%"" style='width:18.92%;padding:.75pt .75pt .75pt .75pt'>
     <p class=MsoNormal align = center style='text-align:center'><span
	   style = 'font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;

	 mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>$PRICE$
     Ft<o:p></o:p></span></p>
     </td>
     <td style = 'padding:.75pt .75pt .75pt .75pt' >

	<p class=MsoNormal align = center style='text-align:center'><span
		style = 'font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;

	 mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>$PRICE$
     Ft<o:p></o:p></span></p>
     </td>
    </tr>
   </thead>
   <tr style = 'mso-yfti-irow:2' >

	<td width=""85%"" colspan=3 style='width:85.02%;padding:.75pt .75pt .75pt .75pt'>
    <p class=MsoNormal align = right style='text-align:right'><span
	  style = 'font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;

	mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>Szállítási
    költség:<o:p></o:p></span></p>
    </td>
    <td style = 'padding:.75pt .75pt .75pt .75pt' >

	<p class=MsoNormal align = center style='text-align:center'><span
	   style = 'font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;

	mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>$TRANS_PRICE$
    Ft<o:p></o:p></span></p>
    </td>
   </tr>
   <tr style = 'mso-yfti-irow:3;mso-yfti-lastrow:yes' >

	<td width=""85%"" nowrap colspan = 3 style='width:85.02%;padding:.75pt .75pt .75pt .75pt'>
    <p class=MsoNormal align = right style='text-align:right'><span
	  style = 'font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;

	mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>Összesen:<o:p></o:p></span></p>
    </td>
    <td nowrap style='padding:.75pt .75pt .75pt .75pt'>
    <p class=MsoNormal align = center style='text-align:center'><span
	  style = 'font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;

	mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>$SUM_PRICE$
    Ft<o:p></o:p></span></p>
    </td>
   </tr>
  </table>
  <p class=MsoNormal><span style = 'font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'><o:p>&nbsp;</o:p></span></p>
  <table class=MsoNormalTable border = 0 cellpadding=0 width=""100%""
   style='width:100.0%;mso-cellspacing:1.5pt;mso-yfti-tbllook:1184;mso-padding-alt:
   0cm 5.4pt 0cm 5.4pt'>
   <tr style = 'mso-yfti-irow:0;mso-yfti-firstrow:yes' >

	<td colspan=2 style='padding:.75pt .75pt .75pt .75pt'>
    <h4><span style = 'font-size:14.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;

	mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:major-bidi'>Megrendelő
    adatai<o:p></o:p></span></h4>
    </td>
   </tr>
   <tr style = 'mso-yfti-irow:1' >

	<td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt' >
 
	<p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;

	font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
    mso-bidi-theme-font:minor-bidi'>E-mail:<o:p></o:p></span></p>
    </td>
    <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
    <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;

	font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
    mso-bidi-theme-font:minor-bidi'>$EMAIL$<o:p></o:p></span></p>
    </td>
   </tr>
   <tr style = 'mso-yfti-irow:2' >

	<td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt' >
 
	<p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;

	font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
    mso-bidi-theme-font:minor-bidi'>Telefonszám:<o:p></o:p></span></p>
    </td>
    <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
    <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;

	font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
    mso-bidi-theme-font:minor-bidi'>$PHONE$<o:p></o:p></span></p>
    </td>
   </tr>
   <tr style = 'mso-yfti-irow:3' >

	<td colspan=2 style='padding:.75pt .75pt .75pt .75pt'></td>
   </tr>
   <tr style = 'mso-yfti-irow:4' >

	<td colspan=2 style='padding:.75pt .75pt .75pt .75pt'>
    <h4><span style = 'font-size:14.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;

	mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:major-bidi'>Szállítási
    adatok<o:p></o:p></span></h4>
    </td>
   </tr>
   <tr style = 'mso-yfti-irow:5' >

	<td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt' >
 
	<p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;

	font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
    mso-bidi-theme-font:minor-bidi'>Házhoz szállítás<o:p></o:p></span></p>
    </td>
    <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
    <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;

	font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
    mso-bidi-theme-font:minor-bidi'>$TRANS_ADDRESS$<o:p></o:p></span></p>
    </td>
   </tr>
   <tr style = 'mso-yfti-irow:6' >

	<td colspan=2 style='padding:.75pt .75pt .75pt .75pt'></td>
   </tr>
   <tr style = 'mso-yfti-irow:7' >

	<td colspan=2 style='padding:.75pt .75pt .75pt .75pt'>
    <h4><span style = 'font-size:14.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;

	mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:major-bidi'>Számlázási
    adatok<o:p></o:p></span></h4>
    </td>
   </tr>
   <tr style = 'mso-yfti-irow:8' >

	<td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt' >
 
	<p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;

	font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
    mso-bidi-theme-font:minor-bidi'>Név:<o:p></o:p></span></p>
    </td>
    <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
    <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;

	font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
    mso-bidi-theme-font:minor-bidi'>$INV_NAME$<o:p></o:p></span></p>
    </td>
   </tr>
   <tr style = 'mso-yfti-irow:9' >

	<td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt' >
 
	<p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;

	font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
    mso-bidi-theme-font:minor-bidi'>Ország:<o:p></o:p></span></p>
    </td>
    <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
    <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;

	font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
    mso-bidi-theme-font:minor-bidi'>$INV_COUNTRY$<o:p></o:p></span></p>
    </td>
   </tr>
   <tr style = 'mso-yfti-irow:10' >

	<td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt' >
 
	<p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;

	font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
    mso-bidi-theme-font:minor-bidi'>Irányítószám:<o:p></o:p></span></p>
    </td>
    <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
    <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;

	font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
    mso-bidi-theme-font:minor-bidi'>$INV_POSTAL_CODE$<o:p></o:p></span></p>
    </td>
   </tr>
   <tr style = 'mso-yfti-irow:11' >

	<td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt' >
 
	<p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;

	font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
    mso-bidi-theme-font:minor-bidi'>Település:<o:p></o:p></span></p>
    </td>
    <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
    <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;

	font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
    mso-bidi-theme-font:minor-bidi'>$INV_CITY$<o:p></o:p></span></p>
    </td>
   </tr>
   <tr style = 'mso-yfti-irow:12;mso-yfti-lastrow:yes' >

	<td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt' >
 
	<p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;

	font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
    mso-bidi-theme-font:minor-bidi'>Utca, házszám:<o:p></o:p></span></p>
    </td>
    <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
    <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;

	font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
    mso-bidi-theme-font:minor-bidi'>$INV_ADDRESS$<o:p></o:p></span></p>
    </td>
   </tr>
  </table>
  <h4><span style = 'font-size:14.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:major-bidi'>Szállítási
  mód<o:p></o:p></span></h4>
  </td>
 </tr>
 <tr style = 'mso-yfti-irow:1' >
 <td width=""24%"" nowrap style = 'width:24.92%;padding:.75pt .75pt .75pt .75pt' >
 
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>&nbsp;<o:p></o:p></span></p>
  </td>
  <td width = ""74%"" style='width:74.76%;padding:.75pt .75pt .75pt .75pt'>
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>Házhoz szállítás DPD futárszolgálattal<o:p></o:p></span></p>
  </td>
 </tr>
 <tr style = 'mso-yfti-irow:2' >
 <td colspan=2 style='padding:.75pt .75pt .75pt .75pt'></td>
 </tr>
 <tr style = 'mso-yfti-irow:3;height:36.25pt' >
 <td colspan=2 style='padding:.75pt .75pt .75pt .75pt;height:36.25pt'>
  <h4><span style = 'font-size:14.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:major-bidi'>Fizetési
  mód<o:p></o:p></span></h4>
  </td>
 </tr>
 <tr style = 'mso-yfti-irow:4;mso-yfti-lastrow:yes' >
 <td width=""24%"" nowrap style = 'width:24.92%;padding:.75pt .75pt .75pt .75pt' ></ td >
 
  <td width=""74%"" style='width:74.76%;padding:.75pt .75pt .75pt .75pt'>
  <p class=MsoNormal><b style = 'mso-bidi-font-weight:normal' ><span
  style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>Utánvét</span></b><span
  style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>: A
  megrendelt terméket kiszállításkor fizetheti készpénzben vagy bankkártyával.
  Kérem a bankkártyás fizetéssel kapcsolatban érdeklődjön a futárszolgálatnál. <o:p></o:p></span></p>
  </td>
 </tr>
</table>

<p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
minor-bidi'><br>
<b>Köszönjük megrendelésedet! <o:p></o:p></b></span></p>

<p class=MsoNormal><b><span style = 'font-size:12.0pt;line-height:115%;
font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
mso-bidi-theme-font:minor-bidi'>Kérdés esetén keress minket bizalommal az </span></b><a
href=""mailto:info@ausztriamunka.hu""><b><span style = 'font-size:12.0pt;
line-height:115%;font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
mso-bidi-theme-font:minor-bidi'>info@ausztriamunka.hu</span></b></a><b><span
style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'> email
címen.</span></b><span style = 'font-size:12.0pt;line-height:115%;font-family:
""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
minor-bidi'><br>
<br>
</span><span style = 'font-family:""Helvetica"",sans-serif;mso-bidi-font-family:
""Times New Roman""; mso-bidi-theme-font:minor-bidi'><br>
</span><span style = 'font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>Legyen
ma is szép napod! <br style = 'mso-special-character:line-break' >
<![if !supportLineBreakNewLine] ><br style='mso-special-character:line-break'>
<![endif]><o:p></o:p></span></p>

<p class=MsoNormal style = 'margin-bottom:0cm;margin-bottom:.0001pt' ><span
style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'><br>
</span><span style = 'font-size:14.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>Kóbor
Alexandra E.V.</span><span style = 'font-size:12.0pt;line-height:115%;font-family:
""Helvetica"", sans-serif; mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
minor-bidi'><o:p></o:p></span></p>

<p class=MsoNormal style = 'margin-bottom:0cm;margin-bottom:.0001pt' ><a
href=""http://www.ausztriamunka.hu""><span style = 'font-size:12.0pt;line-height:
115%; font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
mso-bidi-theme-font:minor-bidi'>www.ausztriamunka.hu</span></a><span
style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'><o:p></o:p></span></p>

<p class=MsoNormal><span style = 'font-family:""Helvetica"",sans-serif;mso-bidi-font-family:
""Times New Roman""; mso-bidi-theme-font:minor-bidi'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal><span style = 'font-family:""Helvetica"",sans-serif;mso-bidi-font-family:
""Times New Roman""; mso-bidi-theme-font:minor-bidi'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal><span style = 'font-family:""Helvetica"",sans-serif;mso-bidi-font-family:
""Times New Roman""; mso-bidi-theme-font:minor-bidi'><o:p>&nbsp;</o:p></span></p>

";



		public static String TRANSFER_MAIL = @"
<p class=MsoNormal><b><span style='font-size:14.0pt;line-height:115%;
font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
mso-bidi-theme-font:minor-bidi'>Kedves $NAME$!</span></b><span
style='font-size:14.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'><o:p></o:p></span></p>

<p class=MsoNormal><span style = 'font-family:""Helvetica"",sans-serif;mso-bidi-font-family:
""Times New Roman""; mso-bidi-theme-font:minor-bidi'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
minor-bidi'>A mai napon ($DATE$) a következő rendelést adtad le internetes
áruházunkban:<o:p></o:p></span></p>

<p class=MsoNormal><span style = 'font-family:""Helvetica"",sans-serif;mso-bidi-font-family:
""Times New Roman""; mso-bidi-theme-font:minor-bidi'><o:p>&nbsp;</o:p></span></p>

<table class=MsoNormalTable border = 0 cellpadding=0 width=""100%""
 style='width:100.0%;mso-cellspacing:1.5pt;mso-yfti-tbllook:1184;mso-padding-alt:
 0cm 5.4pt 0cm 5.4pt'>
 <tr style = 'mso-yfti-irow:0;mso-yfti-firstrow:yes'>
  <td colspan=2 style='padding:.75pt .75pt .75pt .75pt'>
  <h4><span style = 'font-size:14.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:major-bidi'>Rendelési
  adatok<o:p></o:p></span></h4>
  </td>
 </tr>
 <tr style = 'mso-yfti-irow:1'>
  <td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt'>
 
   <p class=MsoNormal><strong><span style = 'font-size:12.0pt;line-height:115%;
  font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
  mso-bidi-theme-font:minor-bidi'>Rendelésszám:</span></strong><span
  style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'><o:p></o:p></span></p>
  </td>
  <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>$ORDER_NUMBER$<o:p></o:p></span></p>
  </td>
 </tr>
 <tr style = 'mso-yfti-irow:2;mso-yfti-lastrow:yes' >
  <td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt'>
 
  <p class=MsoNormal><strong><span style = 'font-size:12.0pt;line-height:115%;
  font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
  mso-bidi-theme-font:minor-bidi'>Rendelés dátuma:</span></strong><span
  style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'><o:p></o:p></span></p>
  </td>
  <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>$ORDER_DATE$<o:p></o:p></span></p>
  </td>
 </tr>
</table>

<p class=MsoNormal><span style = 'font-family:""Helvetica"",sans-serif;mso-bidi-font-family:
""Times New Roman""; mso-bidi-theme-font:minor-bidi'><o:p>&nbsp;</o:p></span></p>

<table class=MsoNormalTable border = 0 cellpadding=0 width=""105%""
 style='width:105.56%;mso-cellspacing:1.5pt;mso-yfti-tbllook:1184;mso-padding-alt:
 0cm 5.4pt 0cm 5.4pt'>
 <thead>
  <tr style = 'mso-yfti-irow:0;mso-yfti-firstrow:yes' >
  <td style='padding:.75pt .75pt .75pt .75pt'>
   <p class=MsoNormal><b style = 'mso-bidi-font-weight:normal' ><span
   style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
   mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>Termék
   neve<o:p></o:p></span></b></p>
   </td>
   <td width = ""13%"" style='width:13.3%;padding:.75pt .75pt .75pt .75pt'>
   <p class=MsoNormal><b style = 'mso-bidi-font-weight:normal' ><span
   style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
   mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>Mennyiség</span></b><span
   style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
   mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'><o:p></o:p></span></p>
   </td>
   <td width = ""18%"" style='width:18.92%;padding:.75pt .75pt .75pt .75pt'>
   <p class=MsoNormal style = 'margin-left:8.25pt' ><b style='mso-bidi-font-weight:
   normal'><span style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
   mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>Fogyasztói
   ár<o:p></o:p></span></b></p>
   </td>
   <td style = 'padding:.75pt .75pt .75pt .75pt' >
  <p class=MsoNormal><b style = 'mso-bidi-font-weight:normal' ><span
   style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
   mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>Összesen</span></b><span
   style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
   mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'><o:p></o:p></span></p>
   </td>
  </tr>
  <tr style = 'mso-yfti-irow:1' >
  <td style='padding:.75pt .75pt .75pt .75pt'>
   <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;
   font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
   mso-bidi-theme-font:minor-bidi'>Munkavállalás Ausztriában Lépésről Lépésre
   Könyv<o:p></o:p></span></p>
   </td>
   <td width = ""13%"" style='width:13.3%;padding:.75pt .75pt .75pt .75pt'>
   <p class=MsoNormal align = center style='text-align:center'><span
	 style = 'font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
   mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>$QTY$
   db<o:p></o:p></span></p>
   </td>
   <td width = ""18%"" style='width:18.92%;padding:.75pt .75pt .75pt .75pt'>
   <p class=MsoNormal align = center style='text-align:center'><span
	 style = 'font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
   mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>$PRICE$
   Ft<o:p></o:p></span></p>
   </td>
   <td style = 'padding:.75pt .75pt .75pt .75pt' >
  <p class=MsoNormal align = center style='text-align:center'><span
	  style = 'font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
   mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>$PRICE$
   Ft<o:p></o:p></span></p>
   </td>
  </tr>
 </thead>
 <tr style = 'mso-yfti-irow:2' >
 <td width=""85%"" colspan=3 style='width:85.02%;padding:.75pt .75pt .75pt .75pt'>
  <p class=MsoNormal align = right style='text-align:right'><span
	style = 'font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>Szállítási
  költség:<o:p></o:p></span></p>
  </td>
  <td style = 'padding:.75pt .75pt .75pt .75pt' >
 <p class=MsoNormal align = center style='text-align:center'><span
	 style = 'font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>$TRANS_PRICE$
  Ft<o:p></o:p></span></p>
  </td>
 </tr>
 <tr style = 'mso-yfti-irow:3;mso-yfti-lastrow:yes' >
 <td width=""85%"" nowrap colspan = 3 style='width:85.02%;padding:.75pt .75pt .75pt .75pt'>
  <p class=MsoNormal align = right style='text-align:right'><span
	style = 'font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>Összesen:<o:p></o:p></span></p>
  </td>
  <td nowrap style='padding:.75pt .75pt .75pt .75pt'>
  <p class=MsoNormal align = center style='text-align:center'><span
	style = 'font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>$SUM_PRICE$
  Ft<o:p></o:p></span></p>
  </td>
 </tr>
</table>

<p class=MsoNormal><span style = 'font-family:""Helvetica"",sans-serif;mso-bidi-font-family:
""Times New Roman""; mso-bidi-theme-font:minor-bidi'><o:p>&nbsp;</o:p></span></p>

<table class=MsoNormalTable border = 0 cellpadding=0 width=""100%""
 style='width:100.0%;mso-cellspacing:1.5pt;mso-yfti-tbllook:1184;mso-padding-alt:
 0cm 5.4pt 0cm 5.4pt'>
 <tr style = 'mso-yfti-irow:0;mso-yfti-firstrow:yes' >
 <td colspan=2 style='padding:.75pt .75pt .75pt .75pt'>
  <h4><span style = 'font-size:14.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:major-bidi'>Megrendelő
  adatai<o:p></o:p></span></h4>
  </td>
 </tr>
 <tr style = 'mso-yfti-irow:1' >
 <td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt' >
 
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>E-mail:<o:p></o:p></span></p>
  </td>
  <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>$EMAIL$<o:p></o:p></span></p>
  </td>
 </tr>
 <tr style = 'mso-yfti-irow:2' >
 <td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt' >
 
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>Telefonszám:<o:p></o:p></span></p>
  </td>
  <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>$PHONE$<o:p></o:p></span></p>
  </td>
 </tr>
 <tr style = 'mso-yfti-irow:3' >
 <td colspan=2 style='padding:.75pt .75pt .75pt .75pt'></td>
 </tr>
 <tr style = 'mso-yfti-irow:4' >
 <td colspan=2 style='padding:.75pt .75pt .75pt .75pt'>
  <h4><span style = 'font-size:14.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:major-bidi'>Szállítási
  adatok<o:p></o:p></span></h4>
  </td>
 </tr>
 <tr style = 'mso-yfti-irow:5' >
 <td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt' >
 
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>Házhoz szállítás<o:p></o:p></span></p>
  </td>
  <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>$TRANS_ADDRESS$<o:p></o:p></span></p>
  </td>
 </tr>
 <tr style = 'mso-yfti-irow:6' >
 <td colspan=2 style='padding:.75pt .75pt .75pt .75pt'></td>
 </tr>
 <tr style = 'mso-yfti-irow:7' >
 <td colspan=2 style='padding:.75pt .75pt .75pt .75pt'>
  <h4><span style = 'font-size:14.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:major-bidi'>Számlázási
  adatok<o:p></o:p></span></h4>
  </td>
 </tr>
 <tr style = 'mso-yfti-irow:8' >
 <td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt' >
 
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>Név:<o:p></o:p></span></p>
  </td>
  <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>$INV_NAME$<o:p></o:p></span></p>
  </td>
 </tr>
 <tr style = 'mso-yfti-irow:9' >
 <td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt' >
 
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>Ország:<o:p></o:p></span></p>
  </td>
  <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>$INV_COUNTRY$<o:p></o:p></span></p>
  </td>
 </tr>
 <tr style = 'mso-yfti-irow:10' >
 <td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt' >
 
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>Irányítószám:<o:p></o:p></span></p>
  </td>
  <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>$INV_POSTAL_CODE$<o:p></o:p></span></p>
  </td>
 </tr>
 <tr style = 'mso-yfti-irow:11' >
 <td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt' >
 
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>Település:<o:p></o:p></span></p>
  </td>
  <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>$INV_CITY$<o:p></o:p></span></p>
  </td>
 </tr>
 <tr style = 'mso-yfti-irow:12' >
 <td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt' >
 
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>Utca, házszám:<o:p></o:p></span></p>
  </td>
  <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'>$INV_ADDRESS$<o:p></o:p></span></p>
  </td>
 </tr>
 <tr style = 'mso-yfti-irow:13' >
 <td colspan=2 style='padding:.75pt .75pt .75pt .75pt'></td>
 </tr>
 <tr style = 'mso-yfti-irow:14' >
 <td colspan=2 style='padding:.75pt .75pt .75pt .75pt'>
  <h4><span style = 'font-size:14.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:major-bidi'>Szállítási
  mód<o:p></o:p></span></h4>
  </td>
 </tr>
 <tr style = 'mso-yfti-irow:15' >
 <td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt' >
 
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi;color:red'>&nbsp;<o:p></o:p></span></p>
  </td>
  <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi;color:red'>Postai ajánlott levél<o:p></o:p></span></p>
  </td>
 </tr>
 <tr style = 'mso-yfti-irow:16' >
 <td colspan=2 style='padding:.75pt .75pt .75pt .75pt'></td>
 </tr>
 <tr style = 'mso-yfti-irow:17;height:36.25pt' >
 <td colspan=2 style='padding:.75pt .75pt .75pt .75pt;height:36.25pt'>
  <h4><span style = 'font-size:14.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:major-bidi'>Fizetési
  mód<o:p></o:p></span></h4>
  </td>
 </tr>
 <tr style = 'mso-yfti-irow:18;mso-yfti-lastrow:yes' >
 <td width=""25%"" nowrap style = 'width:25.0%;padding:.75pt .75pt .75pt .75pt' >
 
  <p class=MsoNormal><span style = 'font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>&nbsp;</span><span
  style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'><o:p></o:p></span></p>
  </td>
  <td width = ""75%"" style='width:75.0%;padding:.75pt .75pt .75pt .75pt'>
  <p class=MsoNormal><b style = 'mso-bidi-font-weight:normal' ><span
  style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>Átutalás:</span></b><span
  style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'> <span
  style='color:red'>Kérlek, az alábbi bankszámlaszámra utald el a feltűntetett
  végösszeget.A csomagot az összeg beérkezése után tudjuk postázni.</span> <o:p></o:p></span></p>
  <p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
  ""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
  minor-bidi'><br>
  <b>Számlatulajdonos neve:</b> Kóbor Alexandra E.V.<br>
  <b>Az átutalást a következő bankszámlaszámra kérjük:</b>
  11600006-00000000-83591781 <o:p></o:p></span></p>
  <p class=MsoNormal><b><span style = 'font-size:12.0pt;line-height:115%;
  font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
  mso-bidi-theme-font:minor-bidi'>Ezt írd a közleménybe: Szent Péter,
  2019021635404 (ez a rendelés száma legyen, ha lehet, írja ide automatikusan a
  névvel együtt)</span></b><b><span style = 'font-family:""Helvetica"",sans-serif;
  mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'><o:p></o:p></span></b></p>
  </td>
 </tr>
</table>

<p class=MsoNormal><span style = 'font-size:12.0pt;line-height:115%;font-family:
""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
minor-bidi'><br>
<b>Köszönjük megrendelésedet! <o:p></o:p></b></span></p>

<p class=MsoNormal><b><span style = 'font-size:12.0pt;line-height:115%;
font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
mso-bidi-theme-font:minor-bidi'>Kérdés esetén keress minket bizalommal az </span></b><a
href=""mailto:info@ausztriamunka.hu""><b><span style = 'font-size:12.0pt;
line-height:115%;font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
mso-bidi-theme-font:minor-bidi'>info@ausztriamunka.hu</span></b></a><b><span
style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'> email
címen.</span></b><span style = 'font-size:12.0pt;line-height:115%;font-family:
""Helvetica"", sans-serif;mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
minor-bidi'><br>
<br>
</span><span style = 'font-family:""Helvetica"",sans-serif;mso-bidi-font-family:
""Times New Roman""; mso-bidi-theme-font:minor-bidi'><br>
</span><span style = 'font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>Legyen
ma is szép napod! <br style = 'mso-special-character:line-break' >
<![if !supportLineBreakNewLine] ><br style='mso-special-character:line-break'>
<![endif]><o:p></o:p></span></p>

<p class=MsoNormal style = 'margin-bottom:0cm;margin-bottom:.0001pt' ><span
style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'><br>
</span><span style = 'font-size:14.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'>Kóbor
Alexandra E.V.</span><span style = 'font-size:12.0pt;line-height:115%;font-family:
""Helvetica"", sans-serif; mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:
minor-bidi'><o:p></o:p></span></p>

<p class=MsoNormal style = 'margin-bottom:0cm;margin-bottom:.0001pt' ><a
href=""http://www.ausztriamunka.hu""><span style = 'font-size:12.0pt;line-height:
115%; font-family:""Helvetica"",sans-serif;mso-bidi-font-family:""Times New Roman"";
mso-bidi-theme-font:minor-bidi'>www.ausztriamunka.hu</span></a><span
style='font-size:12.0pt;line-height:115%;font-family:""Helvetica"",sans-serif;
mso-bidi-font-family:""Times New Roman"";mso-bidi-theme-font:minor-bidi'><o:p></o:p></span></p>

<p class=MsoNormal><span style = 'font-family:""Helvetica"",sans-serif;mso-bidi-font-family:
""Times New Roman""; mso-bidi-theme-font:minor-bidi'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal><span style = 'font-family:""Helvetica"",sans-serif;mso-bidi-font-family:
""Times New Roman""; mso-bidi-theme-font:minor-bidi'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal><span style = 'font-family:""Helvetica"",sans-serif;mso-bidi-font-family:
""Times New Roman""; mso-bidi-theme-font:minor-bidi'><o:p>&nbsp;</o:p></span></p>

<p class=MsoNormal><span style = 'font-family:""Helvetica"",sans-serif;mso-bidi-font-family:
""Times New Roman""; mso-bidi-theme-font:minor-bidi'><o:p>&nbsp;</o:p></span></p>

";

	}
}