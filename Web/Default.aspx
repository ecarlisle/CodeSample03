<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="number_matrix_exercise._Default" %>

<asp:Content runat="server" ContentPlaceHolderID="HeadContent" ID="HeadData">

<link href='http://fonts.googleapis.com/css?family=Ubuntu:400,700' rel='stylesheet' type='text/css'>
<style type="text/css">
	body, table {
		font: 14px Ubuntu, Arial, sans-serif;
	}
	
	table {
		border-collapse: collapse;
	}

	table td {
		border: solid 1px #333;
		background-color: #EEE;
		text-align: center;
		padding: 6px;
	}

	h2 {
		margin: 20px 0 3px 0;
	}

	.highlighted {
		background-color: #FF0;
		color: #CD0000;
	}
</style>


</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

<h2>Matrix:</h2>
<asp:DataList id="dl" runat="server" RepeatColumns="20">
	<ItemTemplate>
		<%# Container.DataItem %>
	</ItemTemplate>
</asp:DataList>
<br />

<h2>Largest Product:</h2>
<asp:Label runat="server" ID="lblProduct" />
<br />

<h2>Number Indices:</h2>
<asp:Label runat="server" ID="lblIndices" />
<br />

<h2>Number Values:</h2>
<asp:Label runat="server" ID="lblValues" />


</asp:Content>
