
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
            this.groupBox1.Controls.Add(this.btunGraphics);
            this.groupBox1.Controls.Add(this.btnVehUpdate);
            this.groupBox1.Controls.Add(this.btnVehDelete);
            this.groupBox1.Controls.Add(this.btnVehAdd);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(693, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1012, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btunGraphics
            // 
            this.btunGraphics.Location = new System.Drawing.Point(21, 123);
            this.btunGraphics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btunGraphics.Name = "btunGraphics";
            this.btunGraphics.Size = new System.Drawing.Size(195, 52);
            this.btunGraphics.TabIndex = 5;
            this.btunGraphics.Text = "Graphics";
            this.btunGraphics.UseVisualStyleBackColor = true;
            this.btunGraphics.Click += new System.EventHandler(this.btunGraphics_Click);
            // 
            // btnVehUpdate
            // 
            this.btnVehUpdate.Location = new System.Drawing.Point(453, 41);
            this.btnVehUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVehUpdate.Name = "btnVehUpdate";
            this.btnVehUpdate.Size = new System.Drawing.Size(195, 52);
            this.btnVehUpdate.TabIndex = 3;
            this.btnVehUpdate.Text = "Vehicle Update";
            this.btnVehUpdate.UseVisualStyleBackColor = true;
            this.btnVehUpdate.Click += new System.EventHandler(this.btnVehUpdate_Click);
            // 
            // btnVehDelete
            // 
            this.btnVehDelete.Location = new System.Drawing.Point(21, 41);
            this.btnVehDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVehDelete.Name = "btnVehDelete";
            this.btnVehDelete.Size = new System.Drawing.Size(195, 52);
            this.btnVehDelete.TabIndex = 2;
            this.btnVehDelete.Text = "Vehicle Delete";
            this.btnVehDelete.UseVisualStyleBackColor = true;
            this.btnVehDelete.Click += new System.EventHandler(this.btnVehDelete_Click);
            // 
            // btnVehAdd
            // 
            this.btnVehAdd.Location = new System.Drawing.Point(236, 41);
            this.btnVehAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVehAdd.Name = "btnVehAdd";
            this.btnVehAdd.Size = new System.Drawing.Size(195, 49);
            this.btnVehAdd.TabIndex = 1;
            this.btnVehAdd.Text = "Vehicle Add";
            this.btnVehAdd.UseVisualStyleBackColor = true;
            this.btnVehAdd.Click += new System.EventHandler(this.btnVehAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vehicle_Service.Properties.Resources.icons8_mechanic_96px;
            this.pictureBox1.Location = new System.Drawing.Point(851, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 122);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtOwner
            // 
            this.txtOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOwner.Location = new System.Drawing.Point(221, 78);
            this.txtOwner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(172, 29);
            this.txtOwner.TabIndex = 5;
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBrand.Location = new System.Drawing.Point(221, 116);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(172, 29);
            this.txtBrand.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModel.Location = new System.Drawing.Point(221, 160);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(172, 29);
            this.txtModel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vehicle Owners :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(57, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vehicle Brand :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(59, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vehicle Model :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(57, 432);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Vehicle Status :";
            // 
            // rbPreparing
            // 
            this.rbPreparing.AutoSize = true;
            this.rbPreparing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPreparing.Location = new System.Drawing.Point(221, 432);
            this.rbPreparing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPreparing.Name = "rbPreparing";
            this.rbPreparing.Size = new System.Drawing.Size(113, 28);
            this.rbPreparing.TabIndex = 13;
            this.rbPreparing.TabStop = true;
            this.rbPreparing.Text = "Preparing";
            this.rbPreparing.UseVisualStyleBackColor = true;
            // 
            // rbReady
            // 
            this.rbReady.AutoSize = true;
            this.rbReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbReady.Location = new System.Drawing.Point(348, 432);
            this.rbReady.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbReady.Name = "rbReady";
            this.rbReady.Size = new System.Drawing.Size(85, 28);
            this.rbReady.TabIndex = 14;
            this.rbReady.TabStop = true;
            this.rbReady.Text = "Ready";
            this.rbReady.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(57, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Vehicle Plate  :";
            // 
            // txtPlate
            // 
            this.txtPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlate.Location = new System.Drawing.Point(221, 204);
            this.txtPlate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(172, 29);
            this.txtPlate.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(87, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Vehicle ID :";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Location = new System.Drawing.Point(221, 39);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(172, 29);
            this.txtID.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 518);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1689, 308);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(32, 274);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Veihicle Problem :";
            // 
            // txtProblem
            // 
            this.txtProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProblem.Location = new System.Drawing.Point(221, 256);
            this.txtProblem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProblem.Multiline = true;
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.Size = new System.Drawing.Size(581, 155);
            this.txtProblem.TabIndex = 20;
            // 
            // FrmVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1721, 841);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}