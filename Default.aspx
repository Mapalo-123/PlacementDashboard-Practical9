
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PlacementDashboard._Default" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Placement Dashboard</title>

    <style>
        body {
            font-family: Arial;
            background: #f1f5f9;
            margin: 0;
        }

        .header {
            background: #172554;
            color: white;
            padding: 25px;
            text-align: center;
        }

        .container {
            padding: 25px;
        }

        .cards {
            display: flex;
            gap: 20px;
            margin-bottom: 25px;
        }

        .card {
            background: white;
            flex: 1;
            padding: 22px;
            border-radius: 8px;
            box-shadow: 0 2px 8px #ddd;
        }

        .card h3 {
            color: #64748b;
        }

        .card h2 {
            color: #1d4ed8;
        }

        .table-box {
            background: white;
            padding: 20px;
            border-radius: 8px;
            overflow-x: auto;
        }

        .grid {
            width: 100%;
            border-collapse: collapse;
        }

        .grid th {
            background: #1e40af;
            color: white;
            padding: 12px;
        }

        .grid td {
            padding: 12px;
            border-bottom: 1px solid #ddd;
            text-align: center;
        }

        .grid tr:nth-child(even) {
            background: #eff6ff;
        }

        .footer {
            text-align: center;
            padding: 20px;
        }
    </style>
</head>

<body>
<form id="form1" runat="server">

    <div class="header">
        <h1>College Placement Dashboard</h1>
        <p>Student Placement Management System</p>
    </div>

    <div class="container">

        <div class="cards">

            <div class="card">
                <h3>Total Students</h3>
                <h2>
                    <asp:Label ID="lblTotal" runat="server" Text="0" />
                </h2>
            </div>

            <div class="card">
                <h3>Students Placed</h3>
                <h2>
                    <asp:Label ID="lblPlaced" runat="server" Text="0" />
                </h2>
            </div>

            <div class="card">
                <h3>Not Placed</h3>
                <h2>
                    <asp:Label ID="lblNotPlaced" runat="server" Text="0" />
                </h2>
            </div>

        </div>

        <div class="table-box">

            <h2>Student Placement Records</h2>

            <asp:GridView ID="gvStudents" runat="server"
                AutoGenerateColumns="False"
                AutoGenerateSelectButton="True"
                DataKeyNames="StudentID"
                OnSelectedIndexChanged="gvStudents_SelectedIndexChanged"
                CssClass="grid"
                EmptyDataText="No student records found">

                <Columns>
                    <asp:BoundField DataField="StudentID" HeaderText="ID" />
                    <asp:BoundField DataField="StudentName" HeaderText="Student Name" />
                    <asp:BoundField DataField="Department" HeaderText="Department" />
                    <asp:BoundField DataField="CompanyName" HeaderText="Company" />
                    <asp:BoundField DataField="JobRole" HeaderText="Job Role" />
                    <asp:BoundField DataField="Package" HeaderText="Package (LPA)" />
                    <asp:BoundField DataField="PlacementYear" HeaderText="Year" />
                    <asp:BoundField DataField="Status" HeaderText="Status" />
                </Columns>

            </asp:GridView>
            
<br />

<h2>Selected Student Details</h2>

<asp:DetailsView ID="dvStudent" runat="server"
    AutoGenerateRows="True"
    GridLines="Both"
    CellPadding="10"
    EmptyDataText="Select a student to view details"
    Width="100%">
</asp:DetailsView>


        </div>

    </div>

    <div class="footer">
        College Placement Management System | Practical 9
    </div>

</form>
</body>
</html>
