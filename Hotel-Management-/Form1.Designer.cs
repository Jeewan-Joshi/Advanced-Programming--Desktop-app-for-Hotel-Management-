namespace Hotel_Management_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RoomNumber = new Label();
            RoomType = new Label();
            NightlyRate = new Label();
            txtRN = new TextBox();
            txtNR = new TextBox();
            txtRT = new TextBox();
            label4 = new Label();
            btnAddRoom = new Button();
            btnModifyRoom = new Button();
            btnDeleteRoom = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            printDialog1 = new PrintDialog();
            dgvRooms = new DataGridView();
            Number = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            NiglthyRate = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();
            // 
            // RoomNumber
            // 
            RoomNumber.AutoSize = true;
            RoomNumber.Location = new Point(72, 122);
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Size = new Size(89, 15);
            RoomNumber.TabIndex = 0;
            RoomNumber.Text = "Room Number ";
            // 
            // RoomType
            // 
            RoomType.AutoSize = true;
            RoomType.Location = new Point(72, 183);
            RoomType.Name = "RoomType";
            RoomType.Size = new Size(66, 15);
            RoomType.TabIndex = 1;
            RoomType.Text = "Room Type";
            // 
            // NightlyRate
            // 
            NightlyRate.AutoSize = true;
            NightlyRate.Location = new Point(72, 243);
            NightlyRate.Name = "NightlyRate";
            NightlyRate.Size = new Size(89, 15);
            NightlyRate.TabIndex = 2;
            NightlyRate.Text = "Nightly Rate ($)";
            // 
            // txtRN
            // 
            txtRN.Location = new Point(72, 140);
            txtRN.Name = "txtRN";
            txtRN.Size = new Size(241, 23);
            txtRN.TabIndex = 3;
            // 
            // txtNR
            // 
            txtNR.Location = new Point(72, 275);
            txtNR.Name = "txtNR";
            txtNR.Size = new Size(241, 23);
            txtNR.TabIndex = 4;
            // 
            // txtRT
            // 
            txtRT.Location = new Point(72, 201);
            txtRT.Name = "txtRT";
            txtRT.Size = new Size(241, 23);
            txtRT.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 76);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 6;
            label4.Text = "Enter room  Details";
       
            // btnAddRoom
            // 
            btnAddRoom.Location = new Point(72, 319);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(75, 23);
            btnAddRoom.TabIndex = 7;
            btnAddRoom.Text = "Add";
            btnAddRoom.UseVisualStyleBackColor = true;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // btnModifyRoom
            // 
            btnModifyRoom.Location = new Point(153, 319);
            btnModifyRoom.Name = "btnModifyRoom";
            btnModifyRoom.Size = new Size(75, 23);
            btnModifyRoom.TabIndex = 8;
            btnModifyRoom.Text = "Modify";
            btnModifyRoom.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRoom
            // 
            btnDeleteRoom.Location = new Point(233, 319);
            btnDeleteRoom.Name = "btnDeleteRoom";
            btnDeleteRoom.Size = new Size(79, 23);
            btnDeleteRoom.TabIndex = 9;
            btnDeleteRoom.Text = "Delete";
            btnDeleteRoom.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 76);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 11;
            label5.Text = "Room inventory";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(391, 109);
            label6.Name = "label6";
            label6.Size = new Size(184, 15);
            label6.TabIndex = 12;
            label6.Text = "Select a row to modify or delete it";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(354, 218);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 13;
          
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // dgvRooms
            // 
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Columns.AddRange(new DataGridViewColumn[] { Number, Type, NiglthyRate, Status });
            dgvRooms.Location = new Point(375, 140);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.Size = new Size(403, 215);
            dgvRooms.TabIndex = 14;
            // 
            // Number
            // 
            Number.HeaderText = "Number";
            Number.Name = "Number";
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.Name = "Type";
            // 
            // NiglthyRate
            // 
            NiglthyRate.HeaderText = "Nightly Rate";
            NiglthyRate.Name = "NiglthyRate";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvRooms);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnDeleteRoom);
            Controls.Add(btnModifyRoom);
            Controls.Add(btnAddRoom);
            Controls.Add(label4);
            Controls.Add(txtRT);
            Controls.Add(txtNR);
            Controls.Add(txtRN);
            Controls.Add(NightlyRate);
            Controls.Add(RoomType);
            Controls.Add(RoomNumber);
            Name = "Form1";
            Text = "RoomManagement";
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RoomNumber;
        private Label RoomType;
        private Label NightlyRate;
        private TextBox txtRN;
        private TextBox txtNR;
        private TextBox txtRT;
        private Label label4;
        private Button btnAddRoom;
        private Button btnModifyRoom;
        private Button btnDeleteRoom;
        private Label label5;
        private Label label6;
        private Label label7;
        private PrintDialog printDialog1;
        private DataGridView dgvRooms;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn NiglthyRate;
        private DataGridViewTextBoxColumn Status;
    }
}
