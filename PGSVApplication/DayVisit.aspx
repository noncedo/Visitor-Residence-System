<%@ Page Title="" Language="C#" MasterPageFile="~/SecurityMaster.Master" AutoEventWireup="true" CodeBehind="DayVisit.aspx.cs" Inherits="PGSVApplication.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="js/jquery-1.12.0.min.js"></script>
    <script src="js/Moment.js"></script>
    <script src="js/bootstrap-datetimepicker.min.js"></script>
    <link href="Bootstrap/bootstrap-datetimepicker.min.css" rel="stylesheet" />
    <div style="width: 80%; margin-left: 10%; margin-right: 10%;" class="container">
        <div class="form-group col-sm-12">
            <div style="border-radius: 0px; box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);" class="panel panel-primary">
                <div style="border-radius: 0px;" class="panel-heading">
                    <h3>Visitor</h3>
                </div>

                <div style="width: 80%; margin-left: 10%; margin-right: 10%;" class="row">
                    <br />
                    <div class="form-group col-sm-6">
                        <div style="border-radius: 0px;" class=" panel panel-primary">
                            <div style="border-radius: 0px;" class="thumbnail">
                                <h3>Tenant Details</h3>
                            </div>
                            <div class="panel-body">
                                <div class="input-group col-sm-12">
                                    <asp:TextBox Style="border-radius: 0px;" Width="70%" ID="txtStudentNumber" class="form-control" placeholder="Enter Student Number" runat="server"></asp:TextBox>
                                </div>
                                <asp:Label runat="server" ID="Label1" Font-Bold="true" Text="Name: "></asp:Label>
                                <asp:Label runat="server" ID="lblFirstname"></asp:Label><br />
                                <asp:Label runat="server" ID="Label2" Font-Bold="true" Text="Surname: "></asp:Label>
                                <asp:Label runat="server" ID="lblSurname"></asp:Label><br />
                                <asp:Label runat="server" ID="Label4" Font-Bold="true" Text="Village: "></asp:Label>
                                <asp:Label runat="server" ID="lblVillage"></asp:Label><br />
                                <asp:Label runat="server" ID="Label5" Font-Bold="true" Text="Flat: "></asp:Label>
                                <asp:Label runat="server" ID="lblFlat"></asp:Label>

                                <br />
                                <div class="input-group col-lg-12">
                                    <asp:Button Style="border-radius: 0px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.01);" ID="btnPersonal" runat="server" Text="Search" OnClick="btnPersonal_Click" Width="45%" CssClass=" btn btn-success" />
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
                                <div class="input-group col-lg-12">
                                    <asp:DropDownList Style="border-radius: 0px;" Width="60%" ID="cmbIdentifier" class="form-control" runat="server">
                                    </asp:DropDownList>
                                </div>
                                <br />
                                <div class="input-group col-sm-12">
                                    <asp:TextBox Style="border-radius: 0px;" Width="70%" ID="txtFirstName" class="form-control" placeholder="Enter First Name" runat="server"></asp:TextBox>
                                </div>
                                <br />
                                <div class="input-group col-sm-12">
                                    <asp:TextBox Style="border-radius: 0px;" Width="70%" ID="txtLastName" class="form-control" placeholder="Enter Last Name" runat="server"></asp:TextBox>
                                </div>
                                <br />
                                <div class="input-group date col-sm-12" id="StartDate" style="width: 65%">
                                    <asp:TextBox Style="border-radius: 0px;" ID="txtStartTime" class="form-control" placeholder="Enter Start Time" runat="server"></asp:TextBox>
                                    <span class="input-group-addon">
                                        <span class="glyphicon glyphicon-time"></span>
                                    </span>
                                </div>
                                <br />
                                <div class="input-group col-lg-12">
                                    <asp:Button Style="border-radius: 0px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.01);" ID="btnCreateDayVisit" runat="server" Width="45%" CssClass="btn btn-success" Text="Create Day Visit" OnClick="btnCreateDayVisit_Click" />
                                    <asp:Button Style="border-radius: 0px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.01);" ID="btnCancel" CssClass="btn btn-danger pull-right" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
            </div>
        </div>
    </div>
    <script type="text/javascript">
        var $j = jQuery(function ($) { /*some code that uses $ */
            $("#StartDate").datetimepicker({
                format: "LT"
            });
            //Preventing the clicking of on coming dates
            $("#StartDate").on("dp.change", function (e) {
                $('#StartDate').data("DateTimePicker").minDate(e.Date);
            });

        });
    </script>
</asp:Content>
