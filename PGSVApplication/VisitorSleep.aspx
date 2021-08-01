<%@ Page Title="" Language="C#" MasterPageFile="~/StudentMaster.Master" AutoEventWireup="true" CodeBehind="VisitorSleep.aspx.cs" Inherits="PGSVApplication.VisitorSleep" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script src="js/jquery-1.12.0.min.js"></script>
    <script src="js/Moment.js"></script>
    <script src="js/bootstrap-datetimepicker.min.js"></script>
    <link href="Bootstrap/bootstrap-datetimepicker.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <%--<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>--%>
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
            2. Enter your visitor details and then click "Create Sleep Permit" button.  <br />
            3. Remember that this is only for weekends<br />
            4. If you want a permit for weekdays, create a spcial permit.
            5. This permit will automatically go to the securities by the gate. <br>
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
    <!--Carousel-->
    <div style="width: 80%; margin-left: 10%; margin-right: 10%;" class="container">
        <div class="form-group col-sm-12">
            <div style="border-radius: 0px; box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);" class="panel panel-primary">
                <div style="border-radius: 0px;" class="panel-heading">
                    <h3>Weekend Sleep Over</h3>
                </div>

                <div style="width: 80%; margin-left: 10%; margin-right: 10%;" class="row">
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
                                    <asp:TextBox Style="border-radius: 0px;" Width="70%" ID="txtStudentNumber" required="" class="form-control" placeholder="Enter Student Number" runat="server"></asp:TextBox>
                                </div>
                                <asp:Label runat="server" ID="lblName" Font-Bold="true" Text="Name: "></asp:Label><br />
                                <asp:Label runat="server" ID="lblVillage" Font-Bold="true" Text="Village : "></asp:Label><br />
                                <asp:Label runat="server" ID="lblFlat" Font-Bold="true" Text="Flat: "></asp:Label><br />
                                <asp:Label runat="server" ID="lblRoom" Font-Bold="true" Text="Room: "></asp:Label><br />
                                <div class="input-group col-lg-12">
                                    <asp:Button Style="border-radius: 0px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.01);" ID="btnPersonal" runat="server" Text="Search" Width="45%" CssClass=" btn btn-success" OnClick="btnPersonal_Click" />
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
                                    <asp:TextBox Style="border-radius: 0px;" Width="70%" ID="txtStuVis" class="form-control" required=""  placeholder="Enter Student/ID Number" runat="server"></asp:TextBox>
                                </div>
                                <br />
                                <div class="input-group col-sm-12">
                                    <asp:TextBox Style="border-radius: 0px;" Width="70%" ID="txtFirstName" class="form-control" required=""  placeholder="First Names..." runat="server"></asp:TextBox>
                                </div>
                                <br />
                                <div class="input-group col-sm-12">
                                    <asp:TextBox Style="border-radius: 0px;" Width="70%" ID="txtLastName" class="form-control" required=""  placeholder="Last Name..." runat="server"></asp:TextBox>
                                </div>
                                <br />
                                <div class="input-group col-sm-12">
                                    <asp:TextBox Style="border-radius: 0px;" Width="70%" TextMode="MultiLine" ID="txtAddress" required=""  class="form-control" placeholder="Address..." runat="server"></asp:TextBox>
                                </div>
                                <br />
                                <asp:Label ID="lblStart" Font-Bold="true" runat="server" Text="Start Date:"></asp:Label>
                                <div class="input-group date col-sm-12" id="StartDate" style="width: 65%">
                                    <asp:TextBox Style="border-radius: 0px;" ID="txtStartDate" class="form-control" required=""  placeholder="Enter Start Time" runat="server"></asp:TextBox>
                                    <span class="input-group-addon">
                                        <span class="glyphicon glyphicon-calendar"></span>
                                    </span>
                                </div>
                                <br />
                                <asp:Label ID="lblEnd" Font-Bold="true" runat="server" Text="End Date: "></asp:Label>
                                <div class="input-group date col-sm-12" id="EndDate" style="width: 65%">
                                    <asp:TextBox Style="border-radius: 0px;" ID="txtEndDate" class="form-control" required=""  placeholder="Enter Start Time" runat="server"></asp:TextBox>
                                    <span class="input-group-addon">
                                        <span class="glyphicon glyphicon-calendar"></span>
                                    </span>
                                </div>
                                <br />

                                <div class="input-group col-lg-12">
                                    <asp:Button Style="border-radius: 0px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.17);" Enabled="false" OnClick="btnFinish_Click" ID="btnFinish" runat="server" CssClass=" btn btn-success" Text="Create Sleep Permit" />
                                    <asp:Button Style="border-radius: 0px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.17);" CausesValidation="false" Visible="false" OnClick="btnCancel_Click" ID="btnCancel" runat="server" CssClass=" btn btn-danger pull-right" Text="Cancel" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <br />
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        var $j = jQuery(function ($) { /*some code that uses $ */
            $("#StartDate").datetimepicker({
                format: "DD-MM-YYYY",
                daysOfWeekDisabled: [1, 2, 3, 4],
                useCurrent: false
            });
            //Preventing the clicking of on coming dates
            $("#StartDate").on("dp.change", function (e) {
                $('#StartDate').data("DateTimePicker").minDate(e.Date);
            });
            $("#EndDate").datetimepicker({
                format: "DD-MM-YYYY",
                daysOfWeekDisabled: [2, 3, 4, 5, 6, 7],
                useCurrent: false
            });
            
            //Preventing the clicking of on coming dates
            $("#StartDate").on("dp.change", function (e) {
                $('#EndDate').data("DateTimePicker").minDate(e.Date);
            });
            $("#EndDate").on("dp.change", function (e) {
                $('#StartDate').data("DateTimePicker").maxDate(e.Date);
            });

        });
    </script>
</asp:Content>
