<%@ Page Title="" Language="C#" MasterPageFile="~/SecurityMaster.Master" AutoEventWireup="true" CodeBehind="SecurityAddDayVisit.aspx.cs" Inherits="PGSVApplication.WebForm7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="EmptyPanelSearchUserForDayVisit" runat="server">
    <div style="width: 80%; margin-left: 10%; margin-right: 10%;" class="container">
            <div class="form-group col-sm-11">
                <div style="border-radius: 0px; box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);" class="panel panel-primary">
                    <div style="border-radius: 0px;" class="panel-heading">
                        <h3>Visitor</h3>
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
                                        <asp:TextBox Style="border-radius: 0px;" Width="70%" ID="txtStudentNumber" class="form-control" placeholder="Enter Student Number" runat="server"></asp:TextBox>
                                    </div>
                                    <br />
                                    <div class="input-group col-lg-12">
                                        <asp:Button Style="border-radius: 0px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.01);" ID="btnPersonal" OnClick="btnPersonal_Click" runat="server" Text="Search" Width="45%" CssClass=" btn btn-success" />
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
                                        <asp:TextBox Style="border-radius: 0px;" Width="70%" ID="txtStuVis" class="form-control" placeholder="Enter Student/ID Number" runat="server"></asp:TextBox>
                                    </div>
                                    <br />
                                    <div class="input-group col-sm-12">
                                        <asp:TextBox Style="border-radius: 0px;" Width="70%" ID="txtFirstName" class="form-control" placeholder="First Names..." runat="server"></asp:TextBox>
                                    </div>
                                    <br />
                                    <div class="input-group col-sm-12">
                                        <asp:TextBox Style="border-radius: 0px;" Width="70%" ID="txtLastName" class="form-control" placeholder="Last Name..." runat="server"></asp:TextBox>
                                    </div>
                                    <br />
                                    <div class="input-group col-sm-12">
                                        <asp:TextBox Style="border-radius: 0px;" Width="70%" TextMode="MultiLine" ID="txtAddress" class="form-control" placeholder="Address..." runat="server"></asp:TextBox>
                                    </div>
                                    <br />
                                    <asp:Label ID="lblStart" Font-Bold="true" runat="server" Text="Start Date:"></asp:Label>
                                    <div class="input-group col-sm-12">
                                        <asp:TextBox ID="txtStartDate" runat="server" Width="70%" class="form-control" TextMode="Date"></asp:TextBox>
                                    </div>
                                    <br />
                                    <asp:Label ID="lblEnd" Font-Bold="true" runat="server" Text="End Date: "></asp:Label>
                                    <div class="input-group col-sm-12">
                                        <asp:TextBox ID="txtEndDate" runat="server" Width="70%" class="form-control" TextMode="Date"></asp:TextBox>
                                    </div>
                                    <br />

                                    <div class="input-group col-lg-12">
                                        <asp:Button Style="border-radius: 0px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.17);" ID="btnEmptyPanelSearchUserForDayVisit" OnClick="btnEmptyPanelSearchUserForDayVisit_Click" runat="server" CssClass=" btn btn-success" Text="Finish" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                    </div>
                </div>
            </div>
        </div>
        </asp:Panel>
    <asp:Panel ID="PopulatedSearchUserForDayVisit" runat="server">
        <div style="width: 80%; margin-left: 10%; margin-right: 10%; margin-top: 1%;" class="container">
            <div class="form-group col-sm-11">
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
                                        <asp:TextBox Style="border-radius: 0px;" Width="70%" ID="txtSearchField" class="form-control" placeholder="Enter Student Number" runat="server"></asp:TextBox>
                                    </div>
                                    <asp:Label runat="server" ID="Label1" Text="Name: "></asp:Label>
                                    <asp:Label runat="server" ID="txtSearchedName" Text=""></asp:Label><br />
                                    <asp:Label runat="server" ID="Label4" Text="Surname: "></asp:Label>
                                    <asp:Label runat="server" ID="txtSearchedSurname" Text=""></asp:Label><br />
                                    <asp:Label runat="server" ID="Label2" Text="Village: "></asp:Label>
                                    <asp:Label runat="server" ID="txtSearchedVillage" Text=""></asp:Label><br />
                                    <asp:Label runat="server" ID="Label6" Text="Room: "></asp:Label>
                                    <asp:Label runat="server" ID="txtSearchedRoom" Text=""></asp:Label><br />
                                    <asp:Label runat="server" ID="Label8" Text=""></asp:Label><br />
                                    <div class="input-group col-lg-12">
                                        <asp:Button Style="border-radius: 0px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.01);" ID="btnSearchRegTenant" OnClick="btnSearchRegTenant_Click" runat="server" Text="Search" Width="45%" CssClass=" btn btn-success" />
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
                                        <asp:DropDownList style="border-radius: 0px;" Width="60%" ID="cmbIdentifier" class="form-control" runat="server" >
                                            <asp:ListItem Text="--ID/SC/Passport--" Value="0"></asp:ListItem>
                                            <asp:ListItem Text="Identity Document" Value="1"></asp:ListItem>
                                            <asp:ListItem Text="Student Card" Value="2"></asp:ListItem>
                                            <asp:ListItem Text="Passport" Value="3"></asp:ListItem>
                                            <asp:ListItem Text="Driver's License" Value="4"></asp:ListItem>
                                            <asp:ListItem Text="Staff Card" Value="5"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <br />
                                    <div class="input-group col-sm-12">
                                        <asp:TextBox Style="border-radius: 0px;" Width="70%" ID="txtUsernameVisitor" class="form-control" placeholder="Enter Student/ID Number" runat="server"></asp:TextBox>
                                    </div>
                                    <br />
                                    <div class="input-group col-sm-12">
                                        <asp:TextBox Style="border-radius: 0px;" Width="70%" ID="txtFirstnameVisitor" class="form-control" placeholder="First Names..." runat="server"></asp:TextBox>
                                    </div>
                                    <br />
                                    <div class="input-group col-sm-12">
                                        <asp:TextBox Style="border-radius: 0px;" Width="70%" ID="txtLastnameVisitor" class="form-control" placeholder="Last Name..." runat="server"></asp:TextBox>
                                    </div>
                                    <br />
                                    <div class="input-group col-sm-12">
                                        <asp:TextBox Style="border-radius: 0px;" Width="70%" TextMode="MultiLine" ID="txtAddressVisitor" class="form-control" placeholder="Address..." runat="server"></asp:TextBox>
                                    </div>
                                    <br />
                                    <asp:Label ID="Label9" Font-Bold="true" runat="server" Text="Start Date:"></asp:Label>
                                    <div class="input-group col-sm-12">
                                        <asp:TextBox ID="txtDateVisitor" runat="server" Width="70%" class="form-control" TextMode="Date"></asp:TextBox>
                                    </div>
                                    <br />
                                    <asp:Label ID="Label10" Font-Bold="true" runat="server" Text="End Date: "></asp:Label>
                                    <div class="input-group col-sm-12">
                                        <asp:TextBox ID="TextBox7" runat="server" Width="70%" class="form-control" TextMode="Date"></asp:TextBox>
                                    </div>
                                    <br />

                                    <div class="input-group col-lg-12">
                                        <asp:Button Style="border-radius: 0px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.17);" ID="Button2" runat="server" CssClass=" btn btn-success" Text="Finish" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>
        <hr /> 
</asp:Content>
