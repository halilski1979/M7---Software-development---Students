namespace CarSystem.FormApp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtCountry = new TextBox();
            txtModelName = new TextBox();
            txtYear = new TextBox();
            btnAddManufacturer = new Button();
            btnDeleteManufacturer = new Button();
            button3 = new Button();
            btnAddModel = new Button();
            btnDeleteModel = new Button();
            button6 = new Button();
            dgvManufacturers = new DataGridView();
            dgvModels = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvManufacturers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvModels).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 57);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "txtName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 94);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "txtCountry";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 241);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 3;
            label3.Text = "txtModelName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 292);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "txtYear";
            // 
            // txtName
            // 
            txtName.Location = new Point(91, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(146, 23);
            txtName.TabIndex = 5;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(91, 91);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(146, 23);
            txtCountry.TabIndex = 6;
            // 
            // txtModelName
            // 
            txtModelName.Location = new Point(91, 238);
            txtModelName.Name = "txtModelName";
            txtModelName.Size = new Size(146, 23);
            txtModelName.TabIndex = 7;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(91, 289);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(146, 23);
            txtYear.TabIndex = 8;
            // 
            // btnAddManufacturer
            // 
            btnAddManufacturer.Location = new Point(262, 11);
            btnAddManufacturer.Name = "btnAddManufacturer";
            btnAddManufacturer.Size = new Size(150, 46);
            btnAddManufacturer.TabIndex = 9;
            btnAddManufacturer.Text = "btnAddManufacturer";
            btnAddManufacturer.UseVisualStyleBackColor = true;
            btnAddManufacturer.Click += btnAddManufacturer_Click;
            // 
            // btnDeleteManufacturer
            // 
            btnDeleteManufacturer.Location = new Point(262, 63);
            btnDeleteManufacturer.Name = "btnDeleteManufacturer";
            btnDeleteManufacturer.Size = new Size(150, 46);
            btnDeleteManufacturer.TabIndex = 10;
            btnDeleteManufacturer.Text = "btnDeleteManufacturer";
            btnDeleteManufacturer.UseVisualStyleBackColor = true;
            btnDeleteManufacturer.Click += btnDeleteManufacturer_Click;
            // 
            // button3
            // 
            button3.Location = new Point(262, 115);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 11;
            button3.Text = "btnUpdateManufacturer";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnUpdateManufacturer_Click;
            // 
            // btnAddModel
            // 
            btnAddModel.Location = new Point(276, 210);
            btnAddModel.Name = "btnAddModel";
            btnAddModel.Size = new Size(136, 46);
            btnAddModel.TabIndex = 12;
            btnAddModel.Text = "AddModel";
            btnAddModel.UseVisualStyleBackColor = true;
            btnAddModel.Click += btnAddModel_Click;
            // 
            // btnDeleteModel
            // 
            btnDeleteModel.Location = new Point(276, 276);
            btnDeleteModel.Name = "btnDeleteModel";
            btnDeleteModel.Size = new Size(136, 46);
            btnDeleteModel.TabIndex = 13;
            btnDeleteModel.Text = "DeleteModel";
            btnDeleteModel.UseVisualStyleBackColor = true;
            btnDeleteModel.Click += btnDeleteModel_Click;
            // 
            // button6
            // 
            button6.Location = new Point(276, 328);
            button6.Name = "button6";
            button6.Size = new Size(136, 46);
            button6.TabIndex = 14;
            button6.Text = "btnUpdateModel";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnUpdateModel_Click;
            // 
            // dgvManufacturers
            // 
            dgvManufacturers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManufacturers.Location = new Point(439, 12);
            dgvManufacturers.Name = "dgvManufacturers";
            dgvManufacturers.Size = new Size(333, 184);
            dgvManufacturers.TabIndex = 15;
            // 
            // dgvModels
            // 
            dgvModels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvModels.Location = new Point(439, 211);
            dgvModels.Name = "dgvModels";
            dgvModels.Size = new Size(336, 184);
            dgvModels.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvModels);
            Controls.Add(dgvManufacturers);
            Controls.Add(button6);
            Controls.Add(btnDeleteModel);
            Controls.Add(btnAddModel);
            Controls.Add(button3);
            Controls.Add(btnDeleteManufacturer);
            Controls.Add(btnAddManufacturer);
            Controls.Add(txtYear);
            Controls.Add(txtModelName);
            Controls.Add(txtCountry);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvManufacturers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvModels).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtCountry;
        private TextBox txtModelName;
        private TextBox txtYear;
        private Button btnAddManufacturer;
        private Button btnDeleteManufacturer;
        private Button button3;
        private Button btnAddModel;
        private Button btnDeleteModel;
        private Button button6;
        private DataGridView dgvManufacturers;
        private DataGridView dgvModels;
    }
}
