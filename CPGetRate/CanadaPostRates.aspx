<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CanadaPostRates.aspx.cs" Inherits="CPGetRate._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Assignment 2: Get Rates from Canada post</h2>    
    </div>

    <div class="row">
        <div class="col-md-12">
            <h5>Enter the required fields and click on "Get Rates" to view the service rates</h5>   
        </div>

        <div class="col-md-4">
            
            <br />
            <asp:Label id="lblUserName" Text="Enter the User Name" runat="server" />
            <br />
            <asp:TextBox id="txtUserName" runat="server" />
            <br /><br/>
            <asp:Label id="lblPassword" Text="Enter the Password" runat="server" />
            <br />
            <asp:TextBox id="txtPassword" TextMode="password" runat="server" />
            <br /><br/>
            <asp:Label id="lblCustomerNo" Text="Enter the Customer Number" runat="server" />
            <br />
            <asp:TextBox id="txtCustomerNumber" runat="server" />
            <br /><br/>
            <p>
                <asp:Button id="BtnGetRate" OnClick="submit" Text="GetRate" runat="server" />
            </p>
        </div>


        <div  class="row" >
            <br /> <br /> <br />

            <asp:repeater id="rptRatesTable"    runat="server">
        
            <headertemplate>
              <table >
                <tr>
                  <td style="width :150px"><b> Service Type   </b></td>
                  <td style="width :100px "><b> Transit Day    </b></td>
                  <td style="width :100px "><b> Regular Price  </b></td>
                </tr>
            </headertemplate>
          
            <itemtemplate>
              <tr>
                <td Style="text-align:left"> <%# Eval("ServiceType1") %> </td>
                <td Style="text-align:center"> <%# Eval("TransitDay1") %> </td>
                <td Style="text-align:center"> <%# Eval("RegularPrice1") %> </td>
              </tr>
            </itemtemplate>
          
            <footertemplate>
              </table>
            </footertemplate>
          </asp:repeater>
            </div>

    </div>

</asp:Content>
