
namespace Vehicle_Service
{
    partial class FrmVehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVehicles));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btunGraphics = new System.Windows.Forms.Button();
            this.btnVehUpdate = new System.Windows.Forms.Button();
            this.btnVehDelete = new System.Windows.Forms.Button();
            this.btnVehAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbPreparing = new System.Windows.Forms.RadioButton();
            this.rbReady = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProblem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskDate = new System.Windows.Forms.MaskedTextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btunGraphics);
            this.groupBox1.Controls.Add(this.btnVehUpdate);
            this.groupBox1.Controls.Add(this.btnVehDelete);
            this.groupBox1.Controls.Add(this.btnVehAdd);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(520, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btunGraphics
            // 
            this.btunGraphics.Location = new System.Drawing.Point(16, 100);
            this.btunGraphics.Name = "btunGraphics";
            this.btunGraphics.Size = new System.Drawing.Size(146, 42);
            this.btunGraphics.TabIndex = 5;
            this.btunGraphics.Text = "Graphics";
            this.btunGraphics.UseVisualStyleBackColor = true;
            this.btunGraphics.Click += new System.EventHandler(this.btunGraphics_Click);
            // 
            // btnVehUpdate
            // 
            this.btnVehUpdate.Location = new System.Drawing.Point(340, 33);
            this.btnVehUpdate.Name = "btnVehUpdate";
            this.btnVehUpdate.Size = new System.Drawing.Size(146, 42);
            this.btnVehUpdate.TabIndex = 3;
            this.btnVehUpdate.Text = "Vehicle Update";
            this.btnVehUpdate.UseVisualStyleBackColor = true;
            this.btnVehUpdate.Click += new System.EventHandler(this.btnVehUpdate_Click);
            // 
            // btnVehDelete
            // 
            this.btnVehDelete.Location = new System.Drawing.Point(16, 33);
            this.btnVehDelete.Name = "btnVehDelete";
            this.btnVehDelete.Size = new System.Drawing.Size(146, 42);
            this.btnVehDelete.TabIndex = 2;
            this.btnVehDelete.Text = "Vehicle Delete";
            this.btnVehDelete.UseVisualStyleBackColor = true;
            this.btnVehDelete.Click += new System.EventHandler(this.btnVehDelete_Click);
            // 
            // btnVehAdd
            // 
            this.btnVehAdd.Location = new System.Drawing.Point(177, 33);
            this.btnVehAdd.Name = "btnVehAdd";
            this.btnVehAdd.Size = new System.Drawing.Size(146, 40);
            this.btnVehAdd.TabIndex = 1;
            this.btnVehAdd.Text = "Vehicle Add";
            this.btnVehAdd.UseVisualStyleBackColor = true;
            this.btnVehAdd.Click += new System.EventHandler(this.btnVehAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vehicle_Service.Properties.Resources.icons8_mechanic_96px;
            this.pictureBox1.Location = new System.Drawing.Point(638, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 99);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtOwner
            // 
            this.txtOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOwner.Location = new System.Drawing.Point(166, 63);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(130, 24);
            this.txtOwner.TabIndex = 5;
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBrand.Location = new System.Drawing.Point(166, 94);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(130, 24);
            this.txtBrand.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModel.Location = new System.Drawing.Point(166, 130);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(130, 24);
            this.txtModel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vehicle Owners :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(43, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vehicle Brand :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(44, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vehicle Model :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Vehicle Status :";
            // 
            // rbPreparing
            // 
            this.rbPreparing.AutoSize = true;
            this.rbPreparing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPreparing.Location = new System.Drawing.Point(161, 414);
            this.rbPreparing.Name = "rbPreparing";
            this.rbPreparing.Size = new System.Drawing.Size(89, 22);
            this.rbPreparing.TabIndex = 13;
            this.rbPreparing.TabStop = true;
            this.rbPreparing.Text = "Preparing";
            this.rbPreparing.UseVisualStyleBackColor = true;
            // 
            // rbReady
            // 
            this.rbReady.AutoSize = true;
            this.rbReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbReady.Location = new System.Drawing.Point(256, 414);
            this.rbReady.Name = "rbReady";
            this.rbReady.Size = new System.Drawing.Size(68, 22);
            this.rbReady.TabIndex = 14;
            this.rbReady.TabStop = true;
            this.rbReady.Text = "Ready";
            this.rbReady.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(43, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Vehicle Plate  :";
            // 
            // txtPlate
            // 
            this.txtPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlate.Location = new System.Drawing.Point(166, 166);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(130, 24);
            this.txtPlate.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(65, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Vehicle ID :";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Location = new System.Drawing.Point(166, 32);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(130, 24);
            this.txtID.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 481);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1267, 250);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(19, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Veihicle Problem :";
            // 
            // txtProblem
            // 
            this.txtProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProblem.Location = new System.Drawing.Point(161, 258);
            this.txtProblem.Multiline = true;
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.Size = new System.Drawing.Size(437, 127);
            this.txtProblem.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(105, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Date :";
            // 
            // mskDate
            // 
            this.mskDate.Location = new System.Drawing.Point(166, 212);
            this.mskDate.Mask = "00/00/0000 90:00";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(130, 20);
            this.mskDate.TabIndex = 23;
            this.mskDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(177, 100);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(146, 42);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // FrmVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1291, 743);
            this.Controls.Add(this.mskDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProblem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.rbReady);
            this.Controls.Add(this.rbPreparing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVehicles";
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.FrmVehicles_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVehUpdate;
        private System.Windows.Forms.Button btnVehDelete;
        private System.Windows.Forms.Button btnVehAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbPreparing;
        private System.Windows.Forms.RadioButton rbReady;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProblem;
        private System.Windows.Forms.Button btunGraphics;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskDate;
        private System.Windows.Forms.Button btnRefresh;
    }
}