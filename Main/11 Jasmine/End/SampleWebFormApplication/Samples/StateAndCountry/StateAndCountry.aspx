<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StateAndCountry.aspx.cs" Inherits="SampleWebFormApplication.Samples.StateAndCountry.StateAndCountry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../../Scripts/jquery-1.8.2.intellisense.js"></script>
    <script src="../../Scripts/jquery-1.8.2.js"></script>
    <script src="../../Scripts/jquery-1.8.2.min.js"></script>
    <script src="../../Scripts/jquery-ui-1.8.24.js"></script>
    <script src="../../Scripts/jquery-ui-1.8.24.min.js"></script>
    <script src="../../Scripts/modernizr-2.6.2.js"></script>
    <script src="StateDropDown.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <select id="countrySelect" name="country" onchange="initCounty_OnChange(this);" style="width: 200px;">
        <option value=""></option>
        <option value="US">USA</option>
    </select>
        <br /><br />
    <select id="stateSelect" name="state" style="width: 200px;"></select>
    </div>
    </form>
</body>
</html>
