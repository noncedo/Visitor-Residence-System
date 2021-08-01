<%@ Page Title="" Language="C#" MasterPageFile="~/StudentMaster.Master" AutoEventWireup="true" CodeBehind="StudentSpecialPermit.aspx.cs" Inherits="PGSVApplication.StudentSpecialPermit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Modal -->
    <div  class="modal fade" id="myModal" role="dialog">
    <div class="modal-dialog">
    
      <!-- Modal content-->
      <div class="modal-content" style="border-radius: 0px;">
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal">&times;</button>
          <h4 class="modal-title" style="color:darkred;">Way Forward: </h4>
        </div>
        <div class="modal-body  text-left">
            1. Enter your student number first and then click the "Search" button. <br />
            2. Enter your visitor details and then click "Create Special Request" button.  <br />
            3. This will have to be approved by the Admin before it can reflect to the securities. 
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-danger" style="border-radius: 0px;" data-dismiss="modal">Close</button>
        </div>
      </div>
      
    </div>
  </div>
    <div class="container" style="width: 80%; margin-left: 10%; margin-right: 10%; margin-top: 1%;">
        <div style="border-radius: 0px;" class="thumbnail">
                            <div class="caption">
                    <button type="button" style="border-radius: 0px;" class="btn btn-info btn-danger" data-toggle="modal" data-target="#myModal">Help</button>            
</div>
            </div>
        </div>
    <div style="width:80%; margin-left:10%; margin-right:10%; " class="container">
        <div class="form-group col-sm-12">
            <div style="border-radius: 0px; box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);" class="panel panel-primary">
                <div style="border-radius: 0px;" class="panel-heading"><h3>Special Permit</h3></div>

                    <div style="width:80%; margin-left:10%; margin-right:10%;" class="row">
                        <br />
                        <div class="form-group col-sm-6">
                            <div style="border-radius: 0px;" class=" panel panel-default">
                                <div style="border-radius: 0px;" class="thumbnail">
                                    <h3>Tenant Details</h3>
                                </div>
                                <div class="panel-body">
                                    <div class="input-group col-sm-12">
                                        <h4><asp:Label ID="lblVis" Visible="false" runat="server"  Width="70%" Style="border-radius: 0px; text-size-adjust:auto; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.01);" class="label label-success" Text="Label"></asp:Label></h4>
                                    <br />
                                        <asp:TextBox style="border-radius: 0px;" Width="70%" ID="txtStudentNumber"  class="form-control"  placeholder="Enter Student Number" runat="server"></asp:TextBox>
                                    </div>
                                    <asp:Label runat="server" ID="lblName" Font-Bold="true" Text="Name: "></asp:Label><br />
                                    <asp:Label runat="server" ID="lblVillage" Font-Bold="true" Text="Village : "></asp:Label><br />
                                    <asp:Label runat="server" ID="lblFlat" Font-Bold="true" Text="Flat: "></asp:Label><br />
                                    <asp:Label runat="server" ID="lblRoom" Font-Bold="true" Text="Room: "></asp:Label><br />
                                    <div class="input-group col-lg-12">
                                        <asp:Button style="border-radius: 0px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.01);" ID="btnSearch" OnClick="btnSearch_Click" runat="server" Text="Search" Width="45%" CssClass=" btn btn-success" />
                                    </div>
                                </div>
                             </div>
                       </div>
                        <div class="form-group col-sm-6">
                            <div style="border-radius: 0px;" class=" panel panel-primary">
                                <div style="border-radius: 0px;" class="thumbnail">
                                    <h3>Visitor Details</h3>
                                </div>
                                <div class="panel-body">
                                    <div class="input-group col-sm-12">
                                        <asp:TextBox style="border-radius: 0px;" Width="70%" ID="txtStuVis" class="form-control" required=""  placeholder="Enter Student/ID Number" runat="server"></asp:TextBox>
                                    </div><br />
                                    <div class="input-group col-sm-12">
                                        <asp:TextBox style="border-radius: 0px;" Width="70%" ID="txtFirstName" class="form-control" required=""   placeholder="First Names..." runat="server"></asp:TextBox>
                                    </div><br />
                                    <div class="input-group col-sm-12">
                                        <asp:TextBox style="border-radius: 0px;" Width="70%" ID="txtLastName" class="form-control" required=""   placeholder="Last Name..." runat="server"></asp:TextBox>
                                    </div><br />
                                    <div class="input-group col-sm-12">
                                        <asp:TextBox style="border-radius: 0px;" Width="70%" TextMode="MultiLine" ID="txtAddress" required=""  class="form-control"  placeholder="Address..." runat="server"></asp:TextBox>
                                    </div><br />
                                    <div class="input-group col-sm-12">
                                        <asp:TextBox style="border-radius: 0px;" Width="70%" TextMode="MultiLine" ID="txtRequest" required=""  class="form-control"  placeholder="Special Request..." runat="server"></asp:TextBox>
                                    </div><br />
                                    <asp:Label ID="lblStart" Font-Bold="true" runat="server" Text="Start Date:"></asp:Label>
                                    <div class="input-group col-sm-12">
                                        <asp:TextBox ID="txtStartDate" runat="server" Width="70%" class="form-control" required=""  TextMode="Date"></asp:TextBox>
                                    </div><br />
                                    <asp:Label ID="lblEnd" Font-Bold="true" runat="server" Text="End Date: "></asp:Label>
                                    <div class="input-group col-sm-12">
                                        <asp:TextBox ID="txtEndDate" runat="server" Width="70%" class="form-control" required=""  TextMode="Date"></asp:TextBox>
                                    </div><br />
                                    
                                    <div class="input-group col-lg-12">
                                        <asp:Button style="border-radius: 0px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.17);" Enabled="false" OnClick="btnCreateRequest_Click" ID="btnCreateRequest" runat="server" CssClass=" btn btn-success" Text="Create Special Request" />
                                        <asp:Button style="border-radius: 0px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.17);" CausesValidation="false" Enabled="false" OnClick="Button1_Click" ID="btnCancel" runat="server" CssClass=" btn btn-danger pull-right" Text="Cancel" />
                                     </div>
                                 </div>
                             </div>
                       </div> <br />
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
