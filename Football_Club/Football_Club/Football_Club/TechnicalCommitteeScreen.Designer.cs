namespace Football_Club
{
    partial class TechnicalCommitteeScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechnicalCommitteeScreen));
            this.number_of_player = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_reload = new System.Windows.Forms.Button();
            this.text_title = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.contract_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.text_age = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.text_contract = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // number_of_player
            // 
            this.number_of_player.AutoSize = true;
            this.number_of_player.Location = new System.Drawing.Point(65, 266);
            this.number_of_player.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.number_of_player.Name = "number_of_player";
            this.number_of_player.Size = new System.Drawing.Size(118, 17);
            this.number_of_player.TabIndex = 41;
            this.number_of_player.Text = "Number of Player";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Player,
            this.MarketValue,
            this.Age,
            this.ContractYear,
            this.Nationality,
            this.Edit,
            this.Delete});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(69, 326);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 44;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(1500, 394);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_reload
            // 
            this.button_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_reload.Image = ((System.Drawing.Image)(resources.GetObject("button_reload.Image")));
            this.button_reload.Location = new System.Drawing.Point(1564, 247);
            this.button_reload.Margin = new System.Windows.Forms.Padding(4);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(43, 34);
            this.button_reload.TabIndex = 38;
            this.button_reload.UseVisualStyleBackColor = true;
            this.button_reload.Click += new System.EventHandler(this.Button_reload_Click);
            // 
            // text_title
            // 
            this.text_title.Location = new System.Drawing.Point(147, 169);
            this.text_title.Margin = new System.Windows.Forms.Padding(4);
            this.text_title.Name = "text_title";
            this.text_title.Size = new System.Drawing.Size(585, 22);
            this.text_title.TabIndex = 37;
            this.text_title.TextChanged += new System.EventHandler(this.Text_title_TextChanged);
            // 
            // text_name
            // 
            this.text_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_name.Location = new System.Drawing.Point(147, 74);
            this.text_name.Margin = new System.Windows.Forms.Padding(4);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(585, 23);
            this.text_name.TabIndex = 36;
            this.text_name.TextChanged += new System.EventHandler(this.Text_name_TextChanged);
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.SystemColors.Control;
            this.button_register.FlatAppearance.BorderSize = 0;
            this.button_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_register.Image = ((System.Drawing.Image)(resources.GetObject("button_register.Image")));
            this.button_register.Location = new System.Drawing.Point(1439, 247);
            this.button_register.Margin = new System.Windows.Forms.Padding(4);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(117, 34);
            this.button_register.TabIndex = 35;
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.Button_register_Click);
            // 
            // contract_label
            // 
            this.contract_label.AutoSize = true;
            this.contract_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.contract_label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.contract_label.Location = new System.Drawing.Point(775, 172);
            this.contract_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contract_label.Name = "contract_label";
            this.contract_label.Size = new System.Drawing.Size(108, 17);
            this.contract_label.TabIndex = 34;
            this.contract_label.Text = "Contract Year";
            this.contract_label.Click += new System.EventHandler(this.contract_label_Click);
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.age_label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.age_label.Location = new System.Drawing.Point(775, 82);
            this.age_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(36, 17);
            this.age_label.TabIndex = 33;
            this.age_label.Text = "Age";
            this.age_label.Click += new System.EventHandler(this.age_label_Click);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.title_label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.title_label.Location = new System.Drawing.Point(65, 172);
            this.title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(40, 17);
            this.title_label.TabIndex = 32;
            this.title_label.Text = "Title";
            this.title_label.Click += new System.EventHandler(this.position_label_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name_label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.name_label.Location = new System.Drawing.Point(65, 82);
            this.name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(49, 17);
            this.name_label.TabIndex = 31;
            this.name_label.Text = "Name";
            this.name_label.Click += new System.EventHandler(this.name_label_Click);
            // 
            // text_age
            // 
            this.text_age.Location = new System.Drawing.Point(996, 74);
            this.text_age.Margin = new System.Windows.Forms.Padding(4);
            this.text_age.Name = "text_age";
            this.text_age.Size = new System.Drawing.Size(585, 22);
            this.text_age.TabIndex = 30;
            this.text_age.TextChanged += new System.EventHandler(this.Text_age_TextChanged);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.Control;
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Image = ((System.Drawing.Image)(resources.GetObject("button_search.Image")));
            this.button_search.Location = new System.Drawing.Point(1321, 247);
            this.button_search.Margin = new System.Windows.Forms.Padding(4);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(109, 34);
            this.button_search.TabIndex = 39;
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.Button_search_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.SystemColors.Control;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.Location = new System.Drawing.Point(58, 24);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(84, 41);
            this.HomeButton.TabIndex = 42;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // text_contract
            // 
            this.text_contract.Location = new System.Drawing.Point(996, 167);
            this.text_contract.Margin = new System.Windows.Forms.Padding(4);
            this.text_contract.Name = "text_contract";
            this.text_contract.Size = new System.Drawing.Size(585, 22);
            this.text_contract.TabIndex = 43;
            this.text_contract.TextChanged += new System.EventHandler(this.Text_contract_TextChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Player
            // 
            this.Player.HeaderText = "Name";
            this.Player.Name = "Player";
            this.Player.ReadOnly = true;
            // 
            // MarketValue
            // 
            this.MarketValue.HeaderText = "Title";
            this.MarketValue.Name = "MarketValue";
            this.MarketValue.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // ContractYear
            // 
            this.ContractYear.HeaderText = "Contract Year";
            this.ContractYear.Name = "ContractYear";
            this.ContractYear.ReadOnly = true;
            // 
            // Nationality
            // 
            this.Nationality.HeaderText = "Salary";
            this.Nationality.Name = "Nationality";
            this.Nationality.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Width = 26;
            // 
            // Delete
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Width = 26;
            // 
            // TechnicalCommitteeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1673, 793);
            this.Controls.Add(this.text_contract);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.number_of_player);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_reload);
            this.Controls.Add(this.text_title);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.contract_label);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.text_age);
            this.Controls.Add(this.button_search);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TechnicalCommitteeScreen";
            this.Text = "TechnicalCommitteeScreen";
            this.Load += new System.EventHandler(this.TechnicalCommitteeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label number_of_player;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.TextBox text_title;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label contract_label;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox text_age;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.TextBox text_contract;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}