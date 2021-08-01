<%@ Page Title="Security Home" Language="C#" MasterPageFile="~/SecurityMaster.Master" AutoEventWireup="true" CodeBehind="SecurityHome.aspx.cs" Inherits="PGSVApplication.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Bootstrap/dataTables.bootstrap.min.css" rel="stylesheet" />
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="width: 80%; margin-left: 10%; margin-right: 10%;" class="container">
        <div class="form-group col-sm-11">
            <div style="border-radius: 0px; box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);" class="panel panel-primary">
                <div style="border-radius: 0px;" class="panel-heading">
                    <h3>All Day Visits</h3>
                </div>

                <div style="width: 80%; margin-left: 10%; margin-right: 10%;" class="row">
                    <br />
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="table-responsive">
                                <asp:GridView ID="DayVisit" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false" 
                                    OnRowEditing="DayVisit_RowEditing" OnPreRender="DayVisit_PreRender">
                                    <Columns>
                                        <asp:BoundField DataField="DayVisitId" HeaderText="Key" ShowHeader="true" Visible="false" />
                                        <asp:BoundField DataField="Tenant" HeaderText="Tenant Name" ShowHeader="true" />
                                        <asp:BoundField DataField="Visitor" HeaderText="Visitor Name" ShowHeader="true" />
                                        <asp:BoundField DataField="Room" HeaderText="Student Room" ShowHeader="true" />
                                        <asp:BoundField DataField="StartTime" HeaderText="Time In" ShowHeader="true" />
                                        <asp:BoundField DataField="EndTime" HeaderText="Time Out" ShowHeader="true" />
                                        <asp:TemplateField ShowHeader="false">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="imgSignOut" runat="server" CausesValidation="False" CommandName="Edit" ImageUrl="Images/checkout.png" ToolTip="Sign Out" />
                                            </ItemTemplate>
                                            <ControlStyle Height="22px" Width="25px" />
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src="js/jquery-1.12.0.min.js"></script>
    <script src="js/jquery.dataTables.min.js"></script>
    <script src="js/dataTables.bootstrap.min.js"></script>
    <script type="text/javascript">
        var $j = jQuery(function ($) { /*some code that uses $ */
            $('table').DataTable();
        });
    </script>
</asp:Content>
