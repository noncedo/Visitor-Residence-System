<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ProcessRequest.aspx.cs" Inherits="PGSVApplication.ProcessRequest" %>
<%@ Register Assembly="AjaxControlToolKit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="Bootstrap/bootstrap.min.css" rel="stylesheet" />
    <title>PGSV - Process Request</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="container">
        <asp:ListView ID="lstRequest" runat="server"
            DataKeyNames="SleepOverId"
            OnItemUpdating="lstRequest_ItemUpdating"
            OnItemDeleting="lstRequest_ItemDeleting"
            OnPagePropertiesChanging="lstRequest_PagePropertiesChanging">
            <LayoutTemplate>
                <div class="row">
                    <div class="">
                        <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
                    </div>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <div class="col-md-4">
                    <div class="panel panel-success">
                        <div class="panel-heading">
                            <h4 class="panel-title">
                                <asp:Label ID="lblRequest" runat="server" CssClass="" Font-Italic="true" ForeColor="Black" Font-Bold="true" Text="Request" />
                                <a href="#" style="color: black;">#
                                    <asp:Label ID="lblRequestNo" runat="server" Font-Italic="true">
                                        <%# DataBinder.Eval(Container.DataItem, "SleepOverId")%>
                                    </asp:Label>
                                </a>
                            </h4>
                        </div>
                        <div class="panel-body">
                            <asp:Label ID="TenantName" runat="server" Font-Bold="true" Text="Tenant Name: " />
                            <a href="#">
                                <asp:Label ID="lblTenant" runat="server">
                                 <%# DataBinder.Eval(Container.DataItem, "Tenant")%>
                                </asp:Label>
                            </a>
                            <br />
                            <asp:Label ID="VisitorName" runat="server" Font-Bold="true" Text="Visitor Name: " />
                            <a href="#">
                                <asp:Label ID="lblVisitor" runat="server">
                                 <%# DataBinder.Eval(Container.DataItem, "Visitor")%>
                                </asp:Label>
                            </a>
                            <br />
                            <asp:Label ID="Room" runat="server" Font-Bold="true" Text="Room: " />
                            <a href="#">
                                <asp:Label ID="lblRoomNo" runat="server">
                                 <%# DataBinder.Eval(Container.DataItem, "Room")%>
                                </asp:Label>
                            </a>
                            <br />
                            <br />
                            <p>
                                <a class="btn btn-primary" role="button" href="#Description" data-toggle="collapse"
                                    aria-expanded="false"
                                    aria-controls="Description">Reasons For Request

                                </a>
                            </p>
                            <div class="collapse" id="Description">
                                <div class="panel panel-default">
                                    <div class="panel-body">
                                        <%# DataBinder.Eval(Container.DataItem, "Description")%>
                                    </div>
                                </div>
                            </div>
                            <hr />
                            <span class="glyphicon glyphicon-calendar"></span>
                            <asp:Label ID="StartDate" runat="server" Font-Italic="true" Text="Start Date: " />
                            <a href="#">
                                <asp:Label ID="lblStartDate" runat="server">
                                 <%# DataBinder.Eval(Container.DataItem, "StartDate")%>
                                </asp:Label>
                            </a>
                            <span>&nbsp; </span>
                            <span class="glyphicon glyphicon-calendar"></span>
                            <asp:Label ID="EndDate" runat="server" Font-Italic="true" Text="End Date: " />
                            <a href="#">
                                <asp:Label ID="lblEndDate" runat="server">
                                 <%# DataBinder.Eval(Container.DataItem, "EndDate")%>
                                </asp:Label>
                            </a>
                            <hr />
                            <asp:Button ID="btnAccept" runat="server" CommandName="Update" CssClass="btn btn-success pull-left" Text="Accept" />
                            <asp:Button ID="btnReject" runat="server" CommandName="Delete" CssClass="btn btn-danger pull-right" Text="Reject" />
                        </div>
                    </div>
                </div>
            </ItemTemplate>
            <EmptyDataTemplate>
                <div class="text-info">
                    Sorry, there is no new special request
                </div>
            </EmptyDataTemplate>
        </asp:ListView>
        <div class="text-center">
            <asp:DataPager ID="DataPager1" runat="server" PagedControlID="lstRequest" PageSize="9">
                <Fields>
                    <asp:NextPreviousPagerField ButtonType="Link" ShowFirstPageButton="false" ShowPreviousPageButton="true" ShowNextPageButton="false" />
                    <asp:NumericPagerField ButtonType="Link" />
                    <asp:NextPreviousPagerField ButtonType="Link" ShowNextPageButton="true" ShowLastPageButton="false" ShowPreviousPageButton="false" />
                </Fields>
            </asp:DataPager>
        </div>
    </div>
    <script src="js/jquery-1.12.0.min.js"></script>
    <script src="Bootstrap/bootstrap.min.js"></script>
</asp:Content>
