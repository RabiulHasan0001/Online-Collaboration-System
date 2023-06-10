<%@ Page language="c#" Codebehind="Wizard.aspx.cs" AutoEventWireup="false" Inherits="WizardDemo.WizardPage" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Demo application for article titled "Panels can do Wonders" - By Rajiv. R, 
			Rajspace.Org. Published at ASPAlliance.Com</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<P>
				<asp:Panel id="pnlStep1" runat="server" Height="189px" Width="925px">Step 1</asp:Panel>
				<asp:Panel id="pnlStep2" runat="server" Height="173px" Width="925px" Visible="False">Step 2</asp:Panel>
				<asp:Panel id="pnlStep3" runat="server" Height="187px" Width="924px" Visible="False">Step 3</asp:Panel>
				<asp:Panel id="pnlStep4" runat="server" Height="140px" Width="922px" Visible="False">Done</asp:Panel></P>
			<P>
				<TABLE id="TableButtons" style="HEIGHT: 29px" width="100%" border="0">
					<TR>
						<TD style="WIDTH: 124px"></TD>
						<TD style="WIDTH: 89px">
							<asp:button id="btnCancel" runat="server" Height="24px" Width="65px" BorderColor="#C3C3C3" BorderStyle="None" Text="Cancel" Font-Size="8pt" Font-Bold="True" BackColor="#C3C3C3"></asp:button></TD>
						<TD style="WIDTH: 87px">
							<asp:button id="btnBack" runat="server" Height="24px" Width="65px" BorderColor="#C3C3C3" BorderStyle="None" Text=" Back" Font-Size="8pt" Font-Bold="True" BackColor="#C3C3C3" Enabled="False"></asp:button></TD>
						<TD style="WIDTH: 78px">
							<asp:button id="btnNext" runat="server" Height="24px" Width="65px" BorderColor="#C3C3C3" BorderStyle="None" Text="Next " Font-Size="8pt" Font-Bold="True" BackColor="#C3C3C3" Font-Names="Arial"></asp:button></TD>
						<TD></TD>
						<TD></TD>
					</TR>
				</TABLE>
			</P>
			<hr>
			<asp:Literal id="ltAuthor" runat="server" Text='Demo application for article titled "Panels can do Wonders" - By Rajiv. R, Rajspace.Org. Published at ASPAlliance.Com. Feel Free to remove this line! :)'></asp:Literal>
		</form>
	</body>
</HTML>
