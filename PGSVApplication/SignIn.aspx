<%@ Page Title="PGSV - Sign In" Language="C#" MasterPageFile="~/GeneralMaster.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="PGSVApplication.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- Modal -->
    <div  class="modal fade" id="smyModal" role="dialog">
    <div class="modal-dialog">
    
      <!-- Modal content-->
      <div class="modal-content" style="border-radius: 0px;">
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal">&times;</button>
          <h4 class="modal-title" style="color:darkred;">Yenza Kanje </h4>
        </div>
        <div class="modal-body  text-left">
            1. Faka i-username kwindawo ye-username. <br />
            2. Faka i-password kwindawo ye-password.  <br />
            3. Cofa iqhosha elibhalwe "Sign In". <br />
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-danger" style="border-radius: 0px;" data-dismiss="modal">Vala</button>
        </div>
      </div>
      
    </div>
  </div>
    <div style="width: 80%; margin-left: 10%; margin-right: 10%; margin-top: 1%;" class="container">
        <div style="border-radius: 0px;" class="thumbnail">
                            <div class="caption"> 
                                <button type="button" style="border-radius: 0px;" class="btn btn-info btn-danger" data-toggle="modal" data-target="#smyModal">Uncedo (Security)</button>  
</div>
            </div>
        </div> 
    <div style="width: 80%; margin-left: 10%; margin-right: 10%;" class="container">
        <div class="form-group col-sm-11">
            <div style="border-radius: 0px; box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);" class="panel panel-primary">
                <div  class="panel-heading">
                    <h3>Sign In</h3>
                </div>
                <div style="width: 80%; margin-left: 10%; margin-right: 10%;">
                    <br />
                    <div>
                        <div class="panel-body">
                            <div>
                            </div>
                            <div class="form-group">
                                <asp:TextBox Style="border-radius: 0px;" required="" Width="100%" ID="txtUsername" class="form-control" placeholder="Enter Username" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:TextBox Style="border-radius: 0px;" required="" Width="100%" ID="txtPassword" TextMode="Password" class="form-control" placeholder="Enter Password" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <h3><asp:Label ID="lblNo" Visible="false" runat="server" class="label label-danger" Text="Label"></asp:Label></h3>
                            </div>
                            <div class="form-group">
                                <asp:Button Style="border-radius: 0px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);" ID="btnSignUp" OnClick="btnSignUp_Click" runat="server" Text="Sign In" Width="45%" CssClass=" btn btn-success" />
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
