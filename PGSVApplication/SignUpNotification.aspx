<%@ Page Title="" Language="C#" MasterPageFile="~/StudentMaster.Master" AutoEventWireup="true" CodeBehind="SignUpNotification.aspx.cs" Inherits="PGSVApplication.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 80%; margin-left: 10%; margin-right: 10%; margin-top: 1%;" class="container">
        <div class="form-group col-sm-11">
            <div style="border-radius: 0px; box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);" class="panel panel-primary">
                <div style="border-radius: 0px;" class="panel-heading">
                    <h3>Registration Successful</h3>
                </div>

                <div style="width: 80%; margin-left: 10%; margin-right: 10%;">
                    <br />
                    <div style="border-radius: 0px;" class="thumbnail">
                        <div class="caption">
                            <div>
                                <br />
                            </div>
                            <div class="input-group col-sm-12">
                                <div style="text-align: center;">
                                    <img alt="SignUpSuccess Logo" src="Images/SuccessfulSignUp.jpg" style="height: 80px; width: 80px;" />
                                </div>
                                <div class="input-group col-sm-12">
                                    <p></p>
                                    <p style="text-align: center;">Congratulations!</p>
                                    <p style="text-align: center;">You have successfully resgistered with PGSV and you are now a member of our community. Now you can start using the system.</p>
                                    <p style="text-align: center;">Thank You</p>
                                </div>
                                <hr />
                            </div>         
                            <br />
                            <div class="input-group col-lg-12" >
                                <asp:Button Style="border-radius: 0px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);" ID="btnGoSignIn" runat="server" OnClick="btnGoSignIn_Click" Text="Continue" Width="45%" CssClass=" btn btn-success center-block"  />
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
