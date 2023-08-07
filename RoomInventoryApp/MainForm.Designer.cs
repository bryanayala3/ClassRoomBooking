namespace RoomInventoryApp
{
    partial class MainForm
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
            listBoxRooms = new ListBox();
            btnUpdateRoom = new Button();
            btnExit = new Button();
            btnResetForNext = new Button();
            btnSaveRoom = new Button();
            btnShowRooms = new Button();
            lblMessages = new Label();
            txtProjectors = new TextBox();
            lblNumProjectors = new Label();
            txtCapacity = new TextBox();
            lblCapacity = new Label();
            txtRoomNumber = new TextBox();
            lblRoomNumber = new Label();
            txtRoomId = new TextBox();
            lblRoomId = new Label();
            hasSmartBoardCheckBox = new CheckBox();
            isAccessibleCheckBox = new CheckBox();
            groupBoxCampuses = new GroupBox();
            radioBtnY = new RadioButton();
            radioBtnM = new RadioButton();
            radioBtnN = new RadioButton();
            groupBoxCapacity = new GroupBox();
            txtMinCapacity = new TextBox();
            lblMin = new Label();
            groupBoxCampuses.SuspendLayout();
            groupBoxCapacity.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxRooms
            // 
            listBoxRooms.FormattingEnabled = true;
            listBoxRooms.ItemHeight = 25;
            listBoxRooms.Location = new Point(17, 535);
            listBoxRooms.Margin = new Padding(5);
            listBoxRooms.Name = "listBoxRooms";
            listBoxRooms.Size = new Size(832, 354);
            listBoxRooms.TabIndex = 0;
            listBoxRooms.SelectedIndexChanged += listBoxRooms_SelectedIndexChanged;
            // 
            // btnUpdateRoom
            // 
            btnUpdateRoom.Location = new Point(645, 91);
            btnUpdateRoom.Margin = new Padding(5);
            btnUpdateRoom.Name = "btnUpdateRoom";
            btnUpdateRoom.Size = new Size(192, 38);
            btnUpdateRoom.TabIndex = 34;
            btnUpdateRoom.Text = "Update room";
            btnUpdateRoom.UseVisualStyleBackColor = true;
            btnUpdateRoom.Click += btnUpdateRoom_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(645, 220);
            btnExit.Margin = new Padding(5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(192, 38);
            btnExit.TabIndex = 33;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnResetForNext
            // 
            btnResetForNext.Location = new Point(645, 153);
            btnResetForNext.Margin = new Padding(5);
            btnResetForNext.Name = "btnResetForNext";
            btnResetForNext.Size = new Size(192, 37);
            btnResetForNext.TabIndex = 32;
            btnResetForNext.Text = "Reset for next";
            btnResetForNext.UseVisualStyleBackColor = true;
            btnResetForNext.Click += btnResetForNext_Click;
            // 
            // btnSaveRoom
            // 
            btnSaveRoom.Location = new Point(645, 35);
            btnSaveRoom.Margin = new Padding(5);
            btnSaveRoom.Name = "btnSaveRoom";
            btnSaveRoom.Size = new Size(192, 38);
            btnSaveRoom.TabIndex = 31;
            btnSaveRoom.Text = "Add new room";
            btnSaveRoom.UseVisualStyleBackColor = true;
            btnSaveRoom.Click += btnSaveRoom_Click;
            // 
            // btnShowRooms
            // 
            btnShowRooms.Location = new Point(18, 453);
            btnShowRooms.Margin = new Padding(5);
            btnShowRooms.Name = "btnShowRooms";
            btnShowRooms.Size = new Size(137, 63);
            btnShowRooms.TabIndex = 29;
            btnShowRooms.Text = "Show rooms";
            btnShowRooms.UseVisualStyleBackColor = true;
            btnShowRooms.Click += btnShowRooms_Click;
            // 
            // lblMessages
            // 
            lblMessages.AutoSize = true;
            lblMessages.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessages.Location = new Point(35, 360);
            lblMessages.Margin = new Padding(5, 0, 5, 0);
            lblMessages.Name = "lblMessages";
            lblMessages.Size = new Size(244, 21);
            lblMessages.TabIndex = 28;
            lblMessages.Text = "Placeholder for info/err messages";
            // 
            // txtProjectors
            // 
            txtProjectors.Location = new Point(188, 228);
            txtProjectors.Margin = new Padding(5);
            txtProjectors.Name = "txtProjectors";
            txtProjectors.Size = new Size(284, 31);
            txtProjectors.TabIndex = 25;
            // 
            // lblNumProjectors
            // 
            lblNumProjectors.AutoSize = true;
            lblNumProjectors.Location = new Point(35, 241);
            lblNumProjectors.Margin = new Padding(5, 0, 5, 0);
            lblNumProjectors.Name = "lblNumProjectors";
            lblNumProjectors.Size = new Size(111, 25);
            lblNumProjectors.TabIndex = 24;
            lblNumProjectors.Text = "# Projectors:";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(188, 159);
            txtCapacity.Margin = new Padding(5);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(284, 31);
            txtCapacity.TabIndex = 23;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Location = new Point(35, 172);
            lblCapacity.Margin = new Padding(5, 0, 5, 0);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(83, 25);
            lblCapacity.TabIndex = 22;
            lblCapacity.Text = "Capacity:";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(188, 100);
            txtRoomNumber.Margin = new Padding(5);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(284, 31);
            txtRoomNumber.TabIndex = 21;
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new Point(35, 105);
            lblRoomNumber.Margin = new Padding(5, 0, 5, 0);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(131, 25);
            lblRoomNumber.TabIndex = 20;
            lblRoomNumber.Text = "Room number:";
            // 
            // txtRoomId
            // 
            txtRoomId.Enabled = false;
            txtRoomId.Location = new Point(188, 35);
            txtRoomId.Margin = new Padding(5);
            txtRoomId.Name = "txtRoomId";
            txtRoomId.Size = new Size(284, 31);
            txtRoomId.TabIndex = 19;
            // 
            // lblRoomId
            // 
            lblRoomId.AutoSize = true;
            lblRoomId.Location = new Point(35, 40);
            lblRoomId.Margin = new Padding(5, 0, 5, 0);
            lblRoomId.Name = "lblRoomId";
            lblRoomId.Size = new Size(87, 25);
            lblRoomId.TabIndex = 18;
            lblRoomId.Text = "Room ID:";
            // 
            // hasSmartBoardCheckBox
            // 
            hasSmartBoardCheckBox.AutoSize = true;
            hasSmartBoardCheckBox.Location = new Point(35, 303);
            hasSmartBoardCheckBox.Margin = new Padding(5);
            hasSmartBoardCheckBox.Name = "hasSmartBoardCheckBox";
            hasSmartBoardCheckBox.Size = new Size(180, 29);
            hasSmartBoardCheckBox.TabIndex = 35;
            hasSmartBoardCheckBox.Text = "Has Smart Board?";
            hasSmartBoardCheckBox.UseVisualStyleBackColor = true;
            // 
            // isAccessibleCheckBox
            // 
            isAccessibleCheckBox.AutoSize = true;
            isAccessibleCheckBox.Location = new Point(338, 303);
            isAccessibleCheckBox.Margin = new Padding(5);
            isAccessibleCheckBox.Name = "isAccessibleCheckBox";
            isAccessibleCheckBox.Size = new Size(142, 29);
            isAccessibleCheckBox.TabIndex = 36;
            isAccessibleCheckBox.Text = "Is accessible?";
            isAccessibleCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBoxCampuses
            // 
            groupBoxCampuses.Controls.Add(radioBtnY);
            groupBoxCampuses.Controls.Add(radioBtnM);
            groupBoxCampuses.Controls.Add(radioBtnN);
            groupBoxCampuses.Location = new Point(195, 453);
            groupBoxCampuses.Margin = new Padding(5);
            groupBoxCampuses.Name = "groupBoxCampuses";
            groupBoxCampuses.Padding = new Padding(5);
            groupBoxCampuses.Size = new Size(348, 72);
            groupBoxCampuses.TabIndex = 37;
            groupBoxCampuses.TabStop = false;
            groupBoxCampuses.Text = "By campus?";
            // 
            // radioBtnY
            // 
            radioBtnY.AutoSize = true;
            radioBtnY.Location = new Point(210, 28);
            radioBtnY.Margin = new Padding(5);
            radioBtnY.Name = "radioBtnY";
            radioBtnY.Size = new Size(71, 29);
            radioBtnY.TabIndex = 2;
            radioBtnY.TabStop = true;
            radioBtnY.Text = "York";
            radioBtnY.UseVisualStyleBackColor = true;
            // 
            // radioBtnM
            // 
            radioBtnM.AutoSize = true;
            radioBtnM.Location = new Point(125, 28);
            radioBtnM.Margin = new Padding(5);
            radioBtnM.Name = "radioBtnM";
            radioBtnM.Size = new Size(112, 29);
            radioBtnM.TabIndex = 1;
            radioBtnM.TabStop = true;
            radioBtnM.Text = "Markham";
            radioBtnM.UseVisualStyleBackColor = true;
            // 
            // radioBtnN
            // 
            radioBtnN.AutoSize = true;
            radioBtnN.Location = new Point(12, 28);
            radioBtnN.Margin = new Padding(5);
            radioBtnN.Name = "radioBtnN";
            radioBtnN.Size = new Size(117, 29);
            radioBtnN.TabIndex = 0;
            radioBtnN.TabStop = true;
            radioBtnN.Text = "Newnham";
            radioBtnN.UseVisualStyleBackColor = true;
            // 
            // groupBoxCapacity
            // 
            groupBoxCapacity.Controls.Add(txtMinCapacity);
            groupBoxCapacity.Controls.Add(lblMin);
            groupBoxCapacity.Location = new Point(595, 453);
            groupBoxCapacity.Margin = new Padding(5);
            groupBoxCapacity.Name = "groupBoxCapacity";
            groupBoxCapacity.Padding = new Padding(5);
            groupBoxCapacity.Size = new Size(248, 72);
            groupBoxCapacity.TabIndex = 38;
            groupBoxCapacity.TabStop = false;
            groupBoxCapacity.Text = "By capacity?";
            // 
            // txtMinCapacity
            // 
            txtMinCapacity.Location = new Point(133, 23);
            txtMinCapacity.Margin = new Padding(5);
            txtMinCapacity.Name = "txtMinCapacity";
            txtMinCapacity.Size = new Size(96, 31);
            txtMinCapacity.TabIndex = 1;
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(15, 32);
            lblMin.Margin = new Padding(5, 0, 5, 0);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(92, 25);
            lblMin.TabIndex = 0;
            lblMin.Text = "Minimum:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 820);
            Controls.Add(groupBoxCapacity);
            Controls.Add(groupBoxCampuses);
            Controls.Add(isAccessibleCheckBox);
            Controls.Add(hasSmartBoardCheckBox);
            Controls.Add(btnUpdateRoom);
            Controls.Add(btnExit);
            Controls.Add(btnResetForNext);
            Controls.Add(btnSaveRoom);
            Controls.Add(btnShowRooms);
            Controls.Add(lblMessages);
            Controls.Add(txtProjectors);
            Controls.Add(lblNumProjectors);
            Controls.Add(txtCapacity);
            Controls.Add(lblCapacity);
            Controls.Add(txtRoomNumber);
            Controls.Add(lblRoomNumber);
            Controls.Add(txtRoomId);
            Controls.Add(lblRoomId);
            Controls.Add(listBoxRooms);
            Margin = new Padding(5);
            Name = "MainForm";
            Text = "College Class Room Inventory - Bart Simpson (123456)";
            Load += MainForm_Load;
            groupBoxCampuses.ResumeLayout(false);
            groupBoxCampuses.PerformLayout();
            groupBoxCapacity.ResumeLayout(false);
            groupBoxCapacity.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxRooms;
        private Button btnUpdateRoom;
        private Button btnExit;
        private Button btnResetForNext;
        private Button btnSaveRoom;
        private Button btnShowRooms;
        private Label lblMessages;
        private TextBox txtProjectors;
        private Label lblNumProjectors;
        private TextBox txtCapacity;
        private Label lblCapacity;
        private TextBox txtRoomNumber;
        private Label lblRoomNumber;
        private TextBox txtRoomId;
        private Label lblRoomId;
        private CheckBox hasSmartBoardCheckBox;
        private CheckBox isAccessibleCheckBox;
        private GroupBox groupBoxCampuses;
        private RadioButton radioBtnM;
        private RadioButton radioBtnN;
        private RadioButton radioBtnY;
        private GroupBox groupBoxCapacity;
        private TextBox txtMinCapacity;
        private Label lblMin;
    }
}