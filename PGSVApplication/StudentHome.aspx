<%@ Page Title="" Language="C#" MasterPageFile="~/StudentMaster.Master" AutoEventWireup="true" CodeBehind="StudentHome.aspx.cs" Inherits="PGSVApplication.WebForm10" %>

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
            1. Click on "Weekend Sleep Over" to create a sleep over for the weekend.<br />
            2. This is only for weekends. <br />
            3. Click "Special Permit" for any other permit. <br />
            4. This will be check by the RSA and can be accepted or rejected depending on the reason. <br />
            5. Your response can be viewed on your Profile page, the one written "Welcome, (Your Name)".<br />
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-danger" style="border-radius: 0px;" data-dismiss="modal">Close</button>
        </div>
      </div>
      
    </div>
  </div>
    <div class="container">
        <div style="border-radius: 0px;" class="thumbnail">
                            <div class="caption">
                    <button type="button" style="border-radius: 0px;" class="btn btn-info btn-danger" data-toggle="modal" data-target="#myModal">Help</button>
                                </div>
            </div>
        </div>
                                                
    <!--Carousel-->
    <div class="container">
        <div id="carousel-example-generic" class="carousel slide" style="width:100%;height:450px"margin:0 auto; data-ride="carousel">
            <!-- Indicators -->
            <ol class="carousel-indicators">
                <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                <li data-target="#carousel-example-generic" data-slide-to="2"></li>
                <li data-target="#carousel-example-generic" data-slide-to="3"></li>
                <li data-target="#carousel-example-generic" data-slide-to="4"></li>
            </ol>
            <!-- Wrapper for slides -->
            <div class="carousel-inner" role="listbox">
                <div class="item active">
                    <img src="Images/1.jpeg"  alt="..." style=" width:100%;height:360px"/>
                    <div class="carousel-caption">
                        <h3>PGSV</h3>
                        <p>Block A</p>
                    </div>
                </div>
                <div class="item">
                    <img src="Images/1.jpeg" alt="..." style="width:100%;height:360px" />
                    <div class="carousel-caption">
                        <h3>PGSV</h3>
                        <p>Block B</p>
                    </div>
                </div>
                <div class="item">
                    <img src="Images/a31933a930124eb19351e7134f4108fb.jpg" alt="..." style="width:100%;height:360px" />
                    <div class="carousel-caption">
                        <h3>PGSV</h3>
                        <p>Block C</p>
                    </div>
                </div>
                <div class="item">
                    <img src="Images/Logo-blue-on-white.png" alt="..." style="width:100%;height:360px" />
                    <div class="carousel-caption">
                        <h3>PGSV</h3>
                        <p>Block D</p>
                    </div>
                </div>
                <div class="item">
                    <img src="Images/11.jpg" alt="..." style="width:100%;height:360px" />
                    <div class="carousel-caption">
                        <h3>PGSV</h3>
                        <p>Block E</p>
                    </div>
                </div>
            </div>
            <!-- Controls -->
            <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
    </div>
    <!--Carousel-->
    <!--Middle Content-->
    <div class="container MasterContent">
        <div class="container" style="text-align: center">
            <p>
                The PGSV Web Application is an online platform for managing the Post Graduate Student Village. It is geared at improving the process of gaining access to the Post Graduate Student Village premises, which involves signing in and signing out of visitors before and after visits.
            </p>
        </div>      
    </div>
    <!--Middle Content--> 
</asp:Content>
