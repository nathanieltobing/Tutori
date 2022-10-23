<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="tutorsignup.aspx.cs" Inherits="Tutori.View.tutorsignup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">

         function readURL(input) {
             if (input.files && input.files[0]) {
                 var reader = new FileReader();

                 reader.onload = function (e) {
                     $('#imgview').attr('src', e.target.result);
                 };

                 reader.readAsDataURL(input.files[0]);
             }
         }
    </script>
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
                           <img width="100px"  id="imgview" src ="../imgs/generaluser.png"/>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Tutor Signup</h4>
                 
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
                       <asp:FileUpload onchange="readURL(this);" class="form-control" ID="FileUpload1" runat="server" />
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
                        <label>Subjects to Teach</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="Tsubject" runat="server" placeholder="Fisika, Matematika" TextMode="MultiLine" Rows="1"></asp:TextBox>
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
                        <label>Biodata</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="Tbiodata" runat="server" placeholder="Biodata" TextMode="MultiLine" Rows="2"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                    <div class="row">
                     <div class="col">
                        <label>Tutoring Fee (/hour)</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TtutoringFee" runat="server" placeholder="Rp/hour"></asp:TextBox>
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
                     <div class="col-md-6">
                        <label>Username</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="Tusername" runat="server" placeholder="Username" ></asp:TextBox>
                        </div>
                     </div>
              
                     <div class="col-md-6">
                        <label>Password</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="Tpassword" runat="server" placeholder="Password" TextMode="Password" ></asp:TextBox>
                        </div>
                     </div>
                   
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <div class="form-group">
                              <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Sign Up" OnClick="Button1_Click" />
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
