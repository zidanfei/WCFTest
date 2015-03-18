<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/jquery-1.10.2.js"></script>
    <script>
        $(function () {
            $.get("/GetAllCustomerList", function (data) {
                $("#rundow").html(data);

            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="rundow">
    
    </div>
    </form>
</body>
</html>
