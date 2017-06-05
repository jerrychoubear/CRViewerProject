﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRViewer.aspx.cs" Inherits="CRViewerProject.CRViewer" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <CR:CrystalReportViewer ID="MyViewer" runat="server" AutoDataBind="true" EnableDatabaseLogonPrompt="False" EnableParameterPrompt="False" ReuseParameterValuesOnRefresh="True" ToolPanelView="None" />
    
    </div>
    </form>
</body>
</html>
