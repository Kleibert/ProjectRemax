namespace prjRemax
{
    partial class frmShearchHouse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridHouses = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPrice = new System.Windows.Forms.ComboBox();
            this.cboBathroom = new System.Windows.Forms.ComboBox();
            this.cboRooms = new System.Windows.Forms.ComboBox();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.checkHouse = new System.Windows.Forms.CheckBox();
            this.txtHouseRef = new System.Windows.Forms.TextBox();
            this.txtAgentRef = new System.Windows.Forms.TextBox();
            this.checkAgent = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridHouses)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridHouses
            // 
            this.gridHouses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHouses.Location = new System.Drawing.Point(31, 254);
            this.gridHouses.Name = "gridHouses";
            this.gridHouses.Size = new System.Drawing.Size(785, 208);
            this.gridHouses.TabIndex = 0;
            this.gridHouses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHouses_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.txtAgentRef);
            this.groupBox1.Controls.Add(this.checkAgent);
            this.groupBox1.Controls.Add(this.txtHouseRef);
            this.groupBox1.Controls.Add(this.checkHouse);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboPrice);
            this.groupBox1.Controls.Add(this.cboBathroom);
            this.groupBox1.Controls.Add(this.cboRooms);
            this.groupBox1.Controls.Add(this.cboCity);
            this.groupBox1.Controls.Add(this.cboType);
            this.groupBox1.Location = new System.Drawing.Point(40, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search a House";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Red;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFind.Location = new System.Drawing.Point(650, 91);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(85, 31);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(661, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price <=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bathrooms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rooms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type";
            // 
            // cboPrice
            // 
            this.cboPrice.FormattingEnabled = true;
            this.cboPrice.Location = new System.Drawing.Point(614, 47);
            this.cboPrice.Name = "cboPrice";
            this.cboPrice.Size = new System.Drawing.Size(121, 21);
            this.cboPrice.TabIndex = 4;
            // 
            // cboBathroom
            // 
            this.cboBathroom.FormattingEnabled = true;
            this.cboBathroom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboBathroom.Location = new System.Drawing.Point(468, 47);
            this.cboBathroom.Name = "cboBathroom";
            this.cboBathroom.Size = new System.Drawing.Size(121, 21);
            this.cboBathroom.TabIndex = 3;
            // 
            // cboRooms
            // 
            this.cboRooms.FormattingEnabled = true;
            this.cboRooms.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboRooms.Location = new System.Drawing.Point(326, 47);
            this.cboRooms.Name = "cboRooms";
            this.cboRooms.Size = new System.Drawing.Size(121, 21);
            this.cboRooms.TabIndex = 2;
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(179, 47);
            this.cboCity.MaxDropDownItems = 50;
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(121, 21);
            this.cboCity.TabIndex = 1;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(39, 47);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 21);
            this.cboType.TabIndex = 0;
            // 
            // checkHouse
            // 
            this.checkHouse.AutoSize = true;
            this.checkHouse.Location = new System.Drawing.Point(39, 91);
            this.checkHouse.Name = "checkHouse";
            this.checkHouse.Size = new System.Drawing.Size(105, 17);
            this.checkHouse.TabIndex = 11;
            this.checkHouse.Text = "House reference";
            this.checkHouse.UseVisualStyleBackColor = true;
            this.checkHouse.CheckedChanged += new System.EventHandler(this.checkHouse_CheckedChanged);
            // 
            // txtHouseRef
            // 
            this.txtHouseRef.Location = new System.Drawing.Point(179, 91);
            this.txtHouseRef.Name = "txtHouseRef";
            this.txtHouseRef.Size = new System.Drawing.Size(121, 20);
            this.txtHouseRef.TabIndex = 12;
            // 
            // txtAgentRef
            // 
            this.txtAgentRef.Location = new System.Drawing.Point(468, 91);
            this.txtAgentRef.Name = "txtAgentRef";
            this.txtAgentRef.Size = new System.Drawing.Size(121, 20);
            this.txtAgentRef.TabIndex = 14;
            // 
            // checkAgent
            // 
            this.checkAgent.AutoSize = true;
            this.checkAgent.Location = new System.Drawing.Point(328, 91);
            this.checkAgent.Name = "checkAgent";
            this.checkAgent.Size = new System.Drawing.Size(81, 17);
            this.checkAgent.TabIndex = 13;
            this.checkAgent.Text = "Agent code";
            this.checkAgent.UseVisualStyleBackColor = true;
            this.checkAgent.CheckedChanged += new System.EventHandler(this.checkAgent_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjRemax.Properties.Resources.remax_balloon;
            this.pictureBox1.Location = new System.Drawing.Point(33, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::prjRemax.Properties.Resources.remax_logo;
            this.pictureBox2.Location = new System.Drawing.Point(228, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(538, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // frmShearchHouse
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 489);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridHouses);
            this.Name = "frmShearchHouse";
            this.Text = "frmShearchHouse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmShearchHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHouses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridHouses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboPrice;
        private System.Windows.Forms.ComboBox cboBathroom;
        private System.Windows.Forms.ComboBox cboRooms;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAgentRef;
        private System.Windows.Forms.CheckBox checkAgent;
        private System.Windows.Forms.TextBox txtHouseRef;
        private System.Windows.Forms.CheckBox checkHouse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}