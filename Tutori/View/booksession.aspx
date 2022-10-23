<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="booksession.aspx.cs" Inherits="Tutori.View.booksession" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script type="text/javascript">

         $(document).ready(function () {
             $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
         });

     </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="container-fluid">
      <div class="row">
         <div class="col-md-5">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Book Session</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <img id="imgview" height="100px" width="100px" src="../imgs/generaluser.png" />
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  
                  <div class="row">
                     <div class="col-md-6">
                        <label>Tutor Username</label>
                        <div class="form-group">
                           <div class="form-group">
                              <asp:TextBox CssClass="form-control" ID="Tusername" runat="server" placeholder="Tutor Username"></asp:TextBox>
                            
                           </div>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Subject</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="Tsubject" runat="server" placeholder="ex: Fisika, Matematika"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                   
                  <div class="row">
                     <div class="col-md-5">
                        <label>Media</label>
                        <div class="form-group">
                           <asp:DropDownList class="form-control" ID="Tmedia" runat="server">
                              <asp:ListItem Text="Online" Value="Online" />
                              <asp:ListItem Text="Offline" Value="Offline" />
                              
                           </asp:DropDownList>
                        </div>                      
                     </div>
                     <div class="col-md-7">
                        <label>Place/Application</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="Tplaceapplication" runat="server" placeholder="ex : Zoom Meetings, Supermall Karawaci"></asp:TextBox>
                        </div>                        
                     </div>
                    
                  </div>
                <div class="row">
                     <div class="col-md-4">
                       
                        <label>Total Hours</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="Ttotalhours" runat="server" placeholder="Total Hours" TextMode="Number"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">                        
                        <label>Date</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="Tdate" runat="server" placeholder="Date" TextMode="Date"></asp:TextBox>
                        </div>
                     </div>
                    <div class="col-md-4">                        
                        <label>Time</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="Ttime" runat="server" placeholder="ex : 09:00-11:00" TextMode="SingleLine"></asp:TextBox>
                        </div>
                     </div>
                    
                  </div>
                  <div class="row">
                     <div class="col-md">
                        <label>Debit Card</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="Tdebit" runat="server" placeholder="Debit Card"></asp:TextBox>
                        </div>
                     </div>
                     
                  </div>
                  
                  
                  <div class="row ">
                     <div class="col">
                        <asp:Button ID="Button1" class="btn btn-lg btn-block btn-success" runat="server" Text="Book" OnClick="Button1_Click" />
                     </div>
                  </div>
               </div>
            </div>
            <a href="homepage.aspx"><< Back to Home</a><br>
            <br>
         </div>
         <div class="col-md-7">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Tutors List</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TutoriConnectionString %>" SelectCommand="SELECT * FROM [tutor_master_tbl]"></asp:SqlDataSource>
                     <div class="col">
                        <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="username" DataSourceID="SqlDataSource1">
                            <Columns>
                                <asp:BoundField DataField="username" HeaderText="Username" ReadOnly="True" SortExpression="username" >
                                 <ControlStyle Font-Bold="True" />
                                 <ItemStyle Font-Bold="True" />
                              </asp:BoundField>
                              <asp:TemplateField>
                                 <ItemTemplate>
                                    <div class="container-fluid">
                                       <div class="row">
                                          <div class="col-lg-10">                                        
                                             <div class="row">
                                                <div class="col-12">
                                                   <span>Name : </span>
                                                   <asp:Label ID="Label2" runat="server" Font-Bold="True" Text='<%# Eval("fullname") %>'></asp:Label>
                                                    
                                                   
                                                </div>
                                             </div>
                                              <div class="row">
                                                <div class="col-12">
                                                   </span>School : </span>
                                                   <asp:Label ID="Label4" runat="server" Font-Bold="True" Text='<%# Eval("school") %>'></asp:Label>
                                                   
                                                   
                                                </div>
                                             </div>
                                             <div class="row">
                                                <div class="col-12">
                                                   Email :
                                                   <asp:Label ID="Label5" runat="server" Font-Bold="True" Text='<%# Eval("email") %>'></asp:Label>
                                                   &nbsp;
                                                </div>
                                             </div>
                                              <div class="row">
                                                <div class="col-12">
                                                   State :
                                                   <asp:Label ID="Label6" runat="server" Font-Bold="True" Text='<%# Eval("state") %>'></asp:Label>
                                                  
                                                   
                                                   
                                                </div>
                                             </div>
                                              <div class="row">
                                                <div class="col-12">
                                                   City :
                                                   <asp:Label ID="Label8" runat="server" Font-Bold="True" Text='<%# Eval("city") %>'></asp:Label>
                                                   
                                                   
                                                </div>
                                             </div>
                                             <div class="row">
                                                <div class="col-12">
                                                   Subjects :
                                                   <asp:Label ID="Label10" runat="server" Font-Bold="True" Text='<%# Eval("subjects") %>'></asp:Label>
                                                   
                                                </div>
                                             </div>
                                              <div class="row">
                                                <div class="col-12">
                                                    Tutoring Fee : <b>Rp </b>
                                                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Text= '<%# Eval("tutoring_fee") %>'></asp:Label>
                                                                                                                                                                                                        
                                                </div>
                                             </div>
                                                   
                                             <div class="row">
                                                <div class="col-12">  
                                                   
                                                   Biodata :
                                                   <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="Smaller" Text='<%# Eval("biodata") %>'></asp:Label>
                                                </div>
                                             </div>
                                          </div>
                                          <div class="col-lg-2">
                                              <div class="row">
                                                  <asp:Image class="img-fluid" ID="Image1" runat="server" ImageUrl='<%# Eval("profile_img_link") %>' />
                                              </div>
                                              
                                          </div>
                                       </div>
                                    </div>
                                 </ItemTemplate>
                              </asp:TemplateField>
                                
                            </Columns>
                         </asp:GridView>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>
</asp:Content>
