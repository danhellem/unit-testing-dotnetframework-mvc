<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShirtsAndPants.aspx.cs" Inherits="SampleWebFormApplication.ShirtsAndPants" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="../../Scripts/modernizr-2.6.2.js"></script>
    <script src="../../Scripts/jquery-1.8.2.intellisense.js"></script>
    <script src="../../Scripts/jquery-1.8.2.js"></script>
    <script src="../../Scripts/jquery-1.8.2.min.js"></script>
    <script src="../../Scripts/jquery-ui-1.8.24.js"></script>
    <script src="../../Scripts/jquery-ui-1.8.24.min.js"></script>
    <script src="ShirtsAndPants.js"></script>

    <title></title>
  
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="text" id="txtPantsColor" name="txtPantsColor" />
        <input type="button" id="btnSubmit" name="btnSubmit" value="Get Shirt Color" />
        <br /><br />
        <div id="divShirtColor">Suggested Shirt Color: </div>
    </div>
    </form>
    </body>
</html>

<script>

    $(document).ready(function () {
        $("#btnSubmit").click(function () {
            var pantsColor = $("#txtPantsColor").val();
            var objColorCordinator = new ColorCordinator();
                        
            objColorCordinator.RunColorCordinatorForPants(pantsColor);
            var result = objColorCordinator.shirtcolor;

            $("#divShirtColor").html('Suggested Shirt Color: ' + result);

            objColorCordinator = null;            
        });
    });

</script>
