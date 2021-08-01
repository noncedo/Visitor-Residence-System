<%@ Page Title="" Language="C#" MasterPageFile="~/StudentMaster.Master" AutoEventWireup="true" CodeBehind="UserAccount.aspx.cs" Inherits="PGSVApplication.UserAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
$(document).ready(function(){
    $('[data-toggle="tooltip"]').tooltip(); 
});
</script>
    
    <div style="width:80%; margin-left:10%; margin-right:10%; margin-top:1%;" class="container">
        <div style="border-radius: 0px;" class=" panel panel-primary">
            <div style="border-radius: 0px;" class="panel-heading">
                <h3>User Account management</h3>                          
            </div>
            
            <div style="border-radius: 0px;" class="panel-body">
                <ul style="border-radius: 0px;" class="nav nav-tabs">
                  <li class="active" style="border-radius: 0px;" runat="server" id="liInfo"><asp:LinkButton style="border-radius: 0px;" ID="lnkUserInfo" runat="server" OnClick="lnkUserInfo_Click" Text="Profile"></asp:LinkButton></li>
                  <li runat="server" id="liManage"><asp:LinkButton style="border-radius: 0px;" Visible="false" ID="lnkManage" runat="server" OnClick="lnkManage_Click" Text="Password Management"></asp:LinkButton></li>
                  <li runat="server" id="liView"><asp:LinkButton style="border-radius: 0px;" Visible="false"  ID="lnkViewUser" OnClick="lnkViewUser_Click" runat="server" Text="View Your Slot"></asp:LinkButton></li>
                    <li runat="server" id="liHours"><asp:LinkButton style="border-radius: 0px;" Visible="false"  ID="lnkAddHours" OnClick="lnkAddHours_Click" runat="server" Text="Add More hours"></asp:LinkButton></li>
                </ul>
                <br />
                <asp:Panel ID="pnlPersonal" runat="server">
                <div class="col-sm-12 col-md-12">
                            <div style="border-radius: 0px;" class="thumbnail">
                                <div class="caption">
                                    <h3 style="color:blue;">Your Personal Details</h3>
                                    <table style="width:100%;" class="table table-hover">
                                        <tr>
                                            <td style="width:40%;"><p style="font-size:large">First Name:  </p></td>
                                            <td style="width:60%;"><asp:Label Font-Size="Large" ID="lblFirstName" CssClass="text-right" runat="server" Text="Name"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td><p style="font-size:large">Last Name: </p></td>
                                            <td><asp:Label ID="lblLastName" Font-Size="Large" CssClass="text-right" runat="server" Text="Surname"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td><p style="font-size:large">Room : </p></td>
                                            <td><asp:Label ID="lblRoom" Font-Size="Large" CssClass="text-right" runat="server" Text="Village|Flat"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td><p style="font-size:large">Email Address: </p></td>
                                            <td><asp:Label ID="lblEmail" Font-Size="Large" CssClass="text-right" runat="server" Text="s000000000@mandela.ac.za"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td><p style="font-size:large">Active Permit: </p></td>
                                            <td><asp:Label ID="lblPerm" Font-Size="Large" CssClass="text-right" runat="server" Text="Special Permit Result (Under Construction)"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td></td>
                                            <td><asp:Label ID="lblSleep2" Font-Size="Large" CssClass="text-right" runat="server" Text="Weekend Sleep Over Result (Under Construction)"></asp:Label></td>
                                        </tr>
                                    </table>
                                </div>
                    </div>
                </div>
                </asp:Panel>
                <asp:Panel ID="pnlPassword" runat="server" Visible="false">
                    <div class="col-sm-12 col-md-12">
                            <div style="border-radius: 0px;" class="thumbnail">
                                <div class="caption">
                                    <h3 style="color:blue;">Change Password Here</h3>
                                    <div class="form-group">
                                    <asp:TextBox Style="border-radius: 0px;" Width="60%" ID="txtUsername" class="form-control" placeholder="Enter Old Password" runat="server"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox Style="border-radius: 0px;" Width="60%" ID="txtFirstName" class="form-control" placeholder="Enter New Password" runat="server"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox Style="border-radius: 0px;" Width="60%" ID="txtSurname" class="form-control" placeholder="Re-Enter New Password" runat="server"></asp:TextBox>
                                </div>

                                </div>
                    </div>
                </div>
                    <div class="col-sm-12 col-md-12">
                        <div style="border-radius: 0px;" class="thumbnail">
                            <div class="caption">
                                <asp:Button ID="btnPrevLesson" Text="Change Password" style="border-radius: 0px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);" runat="server" CssClass="btn btn-success" Width="250px" />
                                </div>
                            </div>
                        </div>   
                </asp:Panel>
            </div>
        </div>
        </div>
    </div>
</asp:Content>
