<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="studentbooklist.aspx.cs" Inherits="Tutori.View.studentbooklist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
      $(document).ready(function () {
          $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).DataTable();
         
      });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="container-fluid">
      <div class="row">
         <div class="col-md-6">
            <div class="card">
               <div class="card-body">
                  
                  <div class="row">
                     <div class="col">
                        <center>
                           <img width="100px" src="../imgs/generaluser.png" />
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-12">
                        <label>Booking ID</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="TbookingID" runat="server" placeholder="Booking ID"></asp:TextBox>
                              
                           </div>
                        </div>
                     </div>                    
                  </div>
              
                  <div class="row">
                     <div class="col-4">
                        <asp:Button ID="Button1" class="btn btn-lg btn-block btn-danger" runat="server" Text="Cancel Booking" OnClick="Button1_Click" />
                     </div>
                     <div class="col-4">
                        <asp:Button ID="Button3" class="btn btn-lg btn-block btn-primary" runat="server" Text="Confirm Denial" OnClick="Button3_Click" />
                     </div>
                     <div class="col-4">
                        <asp:Button ID="Button2" class="btn btn-lg btn-block btn-success" runat="server" Text="Confirm Cancellation" OnClick="Button2_Click" />
                     </div>
                      
                  </div>
               </div>
            </div>
            <a href="homepage.aspx"><< Back to Home</a><br>
            <br>
         </div>
         <div class="col-md-6">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Booking List</h4>
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
                        <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" >
                                  <Columns>
                                <asp:BoundField DataField="bookingID" HeaderText="Booking ID" ReadOnly="True" SortExpression="bookingID" >
                                 <ControlStyle Font-Bold="True" />
                                 <ItemStyle Font-Bold="True" />
                              </asp:BoundField>
                              <asp:TemplateField>
                                 <ItemTemplate>
                                    <div class="container-fluid">
                                       <div class="row">
                                          <div class="col-lg-9">                                        
                                             <div class="row">
                                                <div class="col-12">
                                                   <span>Media : </span>
                                                   <asp:Label ID="Label2" runat="server" Font-Bold="True" Text='<%# Eval("media") %>'></asp:Label>
                                                    
                                                   
                                                </div>
                                             </div>
                                              <div class="row">
                                                <div class="col-12">
                                                   </span>Place/Application : </span>
                                                   <asp:Label ID="Label4" runat="server" Font-Bold="True" Text='<%# Eval("place_application") %>'></asp:Label>
                                                   
                                                   
                                                </div>
                                             </div>
                                             <div class="row">
                                                <div class="col-12">
                                                   Date :
                                                   <asp:Label ID="Label5" runat="server" Font-Bold="True" Text='<%# Eval("date") %>'></asp:Label>
                                                   &nbsp;
                                                </div>
                                             </div>
                                              <div class="row">
                                                <div class="col-12">
                                                   Total Hours :
                                                   <asp:Label ID="Label6" runat="server" Font-Bold="True" Text='<%# Eval("total_hours") %>'></asp:Label>
                                                  
                                                   
                                                   
                                                </div>
                                             </div>
                                              <div class="row">
                                                <div class="col-12">
                                                    Time :
                                                   <asp:Label ID="Label8" runat="server" Font-Bold="True" Text='<%# Eval("time") %>'></asp:Label>
                                                   
                                                   
                                                </div>
                                             </div>
                                             <div class="row">
                                                <div class="col-12">
                                                   Tutor Name :
                                                   <asp:Label ID="Label10" runat="server" Font-Bold="True" Text='<%# Eval("tutor_name") %>'></asp:Label>
                                                   
                                                </div>
                                             </div>
                                              <div class="row">
                                                <div class="col-12">
                                                    Student Name : 
                                                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Text= '<%# Eval("student_name") %>'></asp:Label>
                                                                                                                                                                                                        
                                                </div>
                                             </div>
                                             <div class="row">
                                                <div class="col-12">  
                                                   
                                                   Subject :
                                                   <asp:Label ID="Label3" runat="server" Font-Bold="True"  Text='<%# Eval("subject") %>'></asp:Label>
                                                </div>
                                             </div>
                                              <div class="row">
                                                <div class="col-12">  
                                                   
                                                   Tutoring Fee : <b>Rp </b>
                                                   <asp:Label ID="Label7" runat="server" Font-Bold="True"  Text='<%# Eval("tutoring_fee") %>'></asp:Label>
                                                </div>
                                             </div>
                                             
                                          </div>
                                          <div class="col-lg-3">
                                              <div class="row h-100  align-items-center">
                                                <div class="col-12 mx-auto">  
                                                   <div><h5>Status :</h5> </div>
                                                   <div> <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="Large" Text='<%# Eval("status") %>'></asp:Label></div>
                                                  
                                                </div>
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
