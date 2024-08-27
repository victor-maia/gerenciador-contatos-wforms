using Econtact.DataBaseContext;

namespace Econtact
{
    partial class Econtact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Econtact));
            lblContactId = new Label();
            txtBoxContactId = new TextBox();
            txtBoxContactNumber = new TextBox();
            lblContactNumber = new Label();
            lblFirstName = new Label();
            txtBoxContactName = new TextBox();
            txtBoxContactLastName = new TextBox();
            lblLastName = new Label();
            txtBoxContactAddress = new TextBox();
            lblAddress = new Label();
            lblGender = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            textBoxSearch = new TextBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label1 = new Label();
            cmbGender = new ComboBox();
            lblDbPath = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblContactId
            // 
            lblContactId.AutoSize = true;
            lblContactId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContactId.Location = new Point(57, 106);
            lblContactId.Name = "lblContactId";
            lblContactId.Size = new Size(86, 20);
            lblContactId.TabIndex = 4;
            lblContactId.Text = "Contact ID";
            // 
            // txtBoxContactId
            // 
            txtBoxContactId.Enabled = false;
            txtBoxContactId.Location = new Point(190, 103);
            txtBoxContactId.Name = "txtBoxContactId";
            txtBoxContactId.Size = new Size(192, 23);
            txtBoxContactId.TabIndex = 5;
            // 
            // txtBoxContactNumber
            // 
            txtBoxContactNumber.Location = new Point(190, 218);
            txtBoxContactNumber.Name = "txtBoxContactNumber";
            txtBoxContactNumber.Size = new Size(192, 23);
            txtBoxContactNumber.TabIndex = 3;
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContactNumber.Location = new Point(57, 218);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(65, 20);
            lblContactNumber.TabIndex = 6;
            lblContactNumber.Text = "Número";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(57, 145);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(51, 20);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "Nome";
            // 
            // txtBoxContactName
            // 
            txtBoxContactName.Location = new Point(190, 142);
            txtBoxContactName.Name = "txtBoxContactName";
            txtBoxContactName.Size = new Size(192, 23);
            txtBoxContactName.TabIndex = 1;
            // 
            // txtBoxContactLastName
            // 
            txtBoxContactLastName.Location = new Point(190, 180);
            txtBoxContactLastName.Name = "txtBoxContactLastName";
            txtBoxContactLastName.Size = new Size(192, 23);
            txtBoxContactLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(57, 183);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(92, 20);
            lblLastName.TabIndex = 8;
            lblLastName.Text = "Sobrenome";
            // 
            // txtBoxContactAddress
            // 
            txtBoxContactAddress.Location = new Point(190, 266);
            txtBoxContactAddress.Multiline = true;
            txtBoxContactAddress.Name = "txtBoxContactAddress";
            txtBoxContactAddress.Size = new Size(192, 119);
            txtBoxContactAddress.TabIndex = 4;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(57, 277);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(78, 20);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Endereço";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(57, 404);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(63, 20);
            lblGender.TabIndex = 13;
            lblGender.Text = "Gênero";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12.75F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(335, 462);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 38);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12.75F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(485, 462);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(144, 38);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Atualizar";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12.75F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(635, 462);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 38);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Deletar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(410, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(639, 286);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellClick += CellClick;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(471, 103);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(578, 23);
            textBoxSearch.TabIndex = 9;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Location = new Point(1002, 17);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 44);
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            pictureBox3.Click += btnCloseApp;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F);
            label4.Location = new Point(410, 107);
            label4.Name = "label4";
            label4.Size = new Size(55, 18);
            label4.TabIndex = 26;
            label4.Text = "Buscar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Frutiger 75 Black", 28.7499962F);
            label1.Location = new Point(57, 31);
            label1.Name = "label1";
            label1.Size = new Size(217, 47);
            label1.TabIndex = 27;
            label1.Text = "Econtact+";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cmbGender.Location = new Point(190, 404);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(192, 23);
            cmbGender.TabIndex = 5;
            // 
            // lblDbPath
            // 
            lblDbPath.AutoSize = true;
            lblDbPath.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDbPath.Location = new Point(587, 531);
            lblDbPath.Name = "lblDbPath";
            lblDbPath.Size = new Size(507, 12);
            lblDbPath.TabIndex = 29;
            lblDbPath.Text = "C:\\Users\\maiavict\\AppData\\Local\\Microsoft\\VisualStudio\\17.0_51697d38\\WinFormsDesigner\\vokhkaev.2aw\\contact.db";
            // 
            // Econtact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1083, 564);
            Controls.Add(lblDbPath);
            Controls.Add(cmbGender);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblGender);
            Controls.Add(txtBoxContactAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtBoxContactLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtBoxContactName);
            Controls.Add(txtBoxContactNumber);
            Controls.Add(lblFirstName);
            Controls.Add(lblContactNumber);
            Controls.Add(txtBoxContactId);
            Controls.Add(lblContactId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Econtact";
            Text = "Econtact";
            Load += Econtact_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblContactId;
        private TextBox txtBoxContactId;
        private TextBox txtBoxContactNumber;
        private Label lblContactNumber;
        private Label lblFirstName;
        private TextBox txtBoxContactName;
        private TextBox txtBoxContactLastName;
        private Label lblLastName;
        private TextBox txtBoxContactAddress;
        private Label lblAddress;
        private Label lblGender;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private TextBox textBoxSearch;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label1;
        private ComboBox cmbGender;
        private Label lblDbPath;
    }
}
