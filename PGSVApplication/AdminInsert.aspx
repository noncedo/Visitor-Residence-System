<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminInsert.aspx.cs" Inherits="PGSVApplication.AdminInsert" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="SearchUserPanel" runat="server">
        <div style="width: 80%; margin-left: 10%; margin-right: 10%; margin-top: 1%;" class="container">
            <div class="form-group col-sm-11">
                <div style="border-radius: 0px; box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);" class="panel panel-primary">
                    <div style="border-radius: 0px;" class="panel-heading">
                        <h3>Add Admin</h3>
                    </div>

                    <div style="width: 80%; margin-left: 10%; margin-right: 10%;">
                        <br />
                        <div >
                            <div class="panel-body">
                                <div>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox Style="border-radius: 0px;" Width="100%" ID="txtSearchUsername" class="form-control" placeholder="Enter Username" runat="server"></asp:TextBox>
                                </div>
                                <br />
                                <div class="form-group">
                                    <asp:Button Style="border-radius: 0px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);" OnClick="btnSearchUsername_Click" ID="btnSearchUsername" runat="server" Text="Search" Width="45%" CssClass=" btn btn-success" />
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="SignUpUserPanel" runat="server">
        <div style="width: 80%; margin-left: 10%; margin-right: 10%; margin-top: 1%;" class="container">
            <div class="form-group col-sm-11">
                <div style="border-radius: 0px; box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);" class="panel panel-primary">
                    <div style="border-radius: 0px;" class="panel-heading">
                        <h3>Add Admin</h3>
                    </div>

                    <div style="width: 80%; margin-left: 10%; margin-right: 10%;">
                        <br />
                        <div>
                            <div class="panel-body">
                                <div>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox Style="border-radius: 0px;" Width="100%" ID="txtUsername" ReadOnly="true" class="form-control" placeholder="Enter Username" runat="server"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox Style="border-radius: 0px;" Width="100%" ID="txtFirstName" ReadOnly="true" class="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox Style="border-radius: 0px;" Width="100%" ID="txtSurname" ReadOnly="true" class="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox Style="border-radius: 0px;" Width="100%" ID="txtPassword" Placeholder="Enter Password" TextMode="Password" class="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox Style="border-radius: 0px;" Width="100%" ID="txtConfirmPassword" Placeholder="Confirm Password" TextMode="Password" class="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Button Style="border-radius: 0px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);" ID="btnSignUp" OnClick="btnSignUp_Click" runat="server" Text="Add Admin" Width="45%" CssClass=" btn btn-success" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>
</asp:Content>
