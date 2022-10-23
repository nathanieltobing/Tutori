<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="studentviewprofile.aspx.cs" Inherits="Tutori.View.studentviewprofile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
      <div class="row">
         <div class="col-md-8 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                          <asp:Image width="100px" ID="Image1" runat="server" ImageUrl="~/book_inventory/generaluser.png"  />
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Profile</h4>
                 
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                   <div class="row">
                     <div class="col">
                          <label>Profile Picture</label>
                       <asp:FileUpload  class="form-control" ID="FileUpload1" runat="server" />
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>First Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TfirstName" runat="server" placeholder="First Name"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Last Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TlastName" runat="server" placeholder="Last Name"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">                       
                        <label>Date of Birth</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="Tdob" runat="server" placeholder="Password" TextMode="Date"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Email Address</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="Temail" runat="server" placeholder="Email Address" TextMode="Email"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-4">
                        <label>State</label>
                        <div class="form-group">
                           <asp:DropDownList class="form-control" ID="Tstate" runat="server">
                              <asp:ListItem Text="Select" Value="select" />
                              <asp:ListItem Text="Jakarta" Value="Jakarta" />
                              <asp:ListItem Text="Banten" Value="Banten" />
                              <asp:ListItem Text="Sumatera Utara" Value="Sumatera Utara" />
                              <asp:ListItem Text="Sumatera Barat" Value="Sumatera Barat" />
                              <asp:ListItem Text="Sumatera Selatan" Value="Sumatera Selatan" />
                              <asp:ListItem Text="Bengkulu" Value="Bengkulu" />
                              <asp:ListItem Text="Jawa Barat" Value="Jawa Barat" />
                              <asp:ListItem Text="Jawa Tengah" Value="Jawa Tengah" />
                              <asp:ListItem Text="Sulawesi Tengah" Value="Sulawesi Tengah" />
                              <asp:ListItem Text="Sulawesi Barat" Value="Sulawesi Barat" />
                             
                           </asp:DropDownList>
                        </div>
                     </div>
                     <div class="col-md-3">
                        <label>City</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="Tcity" runat="server" placeholder="City"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-5">
                        <label>School/University</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="Tschool" runat="server" placeholder="School" TextMode="SingleLine"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                   <div class="row">
                     <div class="col-md-12">
                        <label>Debit Card</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="Tdebit" runat="server" placeholder="Debit Card"></asp:TextBox>
                        </div>
                     </div>                   
                  </div>
                  <div class="row">
                     <div class="col">
                        <label>Full Address</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="Taddress" runat="server" placeholder="Full Address" TextMode="MultiLine" Rows="2"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <span class="badge badge-pill badge-info">Login Credentials</span>
                                                 
                        </center>
                     </div>
                  </div>
                   <br />
                  <div class="row">
                     <div class="col-md-4">
                        <label>Username</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="Tusername" runat="server" placeholder="Username" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
              
                     <div class="col-md-4">
                        <label>Old Password</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="Topassword" runat="server" placeholder="Password"  ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                       <div class="col-md-4">
                        <label>New Password</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="Tnpassword" runat="server" placeholder="Password" TextMode="Password" ></asp:TextBox>
                        </div>
                     </div>
                   
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <div class="form-group">
                              <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
                           </div>
                        </center>
                     </div>
                  </div>
               </div>
            </div>
            <a href="homepage.aspx"><< Back to Home</a><br><br>
         </div>
      
      </div>
   </div>
</asp:Content>
