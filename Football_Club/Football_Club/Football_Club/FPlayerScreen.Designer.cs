namespace Football_Club
{
    partial class FPlayerScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPlayerScreen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.number_of_player = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_reload = new System.Windows.Forms.Button();
            this.text_position = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.nationality_label = new System.Windows.Forms.Label();
            this.uniform_label = new System.Windows.Forms.Label();
            this.position_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.text_uniform = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.text_nationality = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniformNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // number_of_player
            // 
            this.number_of_player.AutoSize = true;
            this.number_of_player.Location = new System.Drawing.Point(49, 216);
            this.number_of_player.Name = "number_of_player";
            this.number_of_player.Size = new System.Drawing.Size(88, 13);
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
            this.UniformNumber,
            this.Player,
            this.Age,
            this.ContractYear,
            this.MarketValue,
            this.Nationality,
            this.Edit,
            this.Delete});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(52, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 44;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(1125, 320);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // button_reload
            // 
            this.button_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_reload.Image = ((System.Drawing.Image)(resources.GetObject("button_reload.Image")));
            this.button_reload.Location = new System.Drawing.Point(1173, 201);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(32, 28);
            this.button_reload.TabIndex = 38;
            this.button_reload.UseVisualStyleBackColor = true;
            this.button_reload.Click += new System.EventHandler(this.Button_reload_Click);
            // 
            // text_position
            // 
            this.text_position.Location = new System.Drawing.Point(110, 137);
            this.text_position.Name = "text_position";
            this.text_position.Size = new System.Drawing.Size(440, 20);
            this.text_position.TabIndex = 37;
            this.text_position.TextChanged += new System.EventHandler(this.Text_position_TextChanged);
            // 
            // text_name
            // 
            this.text_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_name.Location = new System.Drawing.Point(110, 60);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(440, 20);
            this.text_name.TabIndex = 36;
            this.text_name.TextChanged += new System.EventHandler(this.Text_name_TextChanged);
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.SystemColors.Control;
            this.button_register.FlatAppearance.BorderSize = 0;
            this.button_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_register.Image = ((System.Drawing.Image)(resources.GetObject("button_register.Image")));
            this.button_register.Location = new System.Drawing.Point(1079, 201);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(88, 28);
            this.button_register.TabIndex = 35;
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.Button_register_Click);
            // 
            // nationality_label
            // 
            this.nationality_label.AutoSize = true;
            this.nationality_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nationality_label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.nationality_label.Location = new System.Drawing.Point(581, 140);
            this.nationality_label.Name = "nationality_label";
            this.nationality_label.Size = new System.Drawing.Size(67, 13);
            this.nationality_label.TabIndex = 34;
            this.nationality_label.Text = "Nationality";
            // 
            // uniform_label
            // 
            this.uniform_label.AutoSize = true;
            this.uniform_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uniform_label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.uniform_label.Location = new System.Drawing.Point(581, 67);
            this.uniform_label.Name = "uniform_label";
            this.uniform_label.Size = new System.Drawing.Size(97, 13);
            this.uniform_label.TabIndex = 33;
            this.uniform_label.Text = "Uniform Number";
            // 
            // position_label
            // 
            this.position_label.AutoSize = true;
            this.position_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.position_label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.position_label.Location = new System.Drawing.Point(49, 140);
            this.position_label.Name = "position_label";
            this.position_label.Size = new System.Drawing.Size(52, 13);
            this.position_label.TabIndex = 32;
            this.position_label.Text = "Position";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name_label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.name_label.Location = new System.Drawing.Point(49, 67);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(39, 13);
            this.name_label.TabIndex = 31;
            this.name_label.Text = "Name";
            // 
            // text_uniform
            // 
            this.text_uniform.Location = new System.Drawing.Point(747, 60);
            this.text_uniform.Name = "text_uniform";
            this.text_uniform.Size = new System.Drawing.Size(440, 20);
            this.text_uniform.TabIndex = 30;
            this.text_uniform.TextChanged += new System.EventHandler(this.Text_uniform_TextChanged);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.Control;
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Image = ((System.Drawing.Image)(resources.GetObject("button_search.Image")));
            this.button_search.Location = new System.Drawing.Point(991, 201);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(82, 28);
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
            this.HomeButton.Location = new System.Drawing.Point(35, 10);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(63, 33);
            this.HomeButton.TabIndex = 42;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // text_nationality
            // 
            this.text_nationality.Location = new System.Drawing.Point(747, 138);
            this.text_nationality.Name = "text_nationality";
            this.text_nationality.Size = new System.Drawing.Size(440, 20);
            this.text_nationality.TabIndex = 43;
            this.text_nationality.TextChanged += new System.EventHandler(this.text_nationality_TextChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // UniformNumber
            // 
            this.UniformNumber.HeaderText = "#";
            this.UniformNumber.Name = "UniformNumber";
            // 
            // Player
            // 
            this.Player.HeaderText = "Player";
            this.Player.Name = "Player";
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // ContractYear
            // 
            this.ContractYear.HeaderText = "Contract Year";
            this.ContractYear.Name = "ContractYear";
            // 
            // MarketValue
            // 
            this.MarketValue.HeaderText = "Market Value";
            this.MarketValue.Name = "MarketValue";
            // 
            // Nationality
            // 
            this.Nationality.HeaderText = "Nationality";
            this.Nationality.Name = "Nationality";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
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
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Width = 26;
            // 
            // FPlayerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1255, 644);
            this.Controls.Add(this.text_nationality);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.number_of_player);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_reload);
            this.Controls.Add(this.text_position);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.nationality_label);
            this.Controls.Add(this.uniform_label);
            this.Controls.Add(this.position_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.text_uniform);
            this.Controls.Add(this.button_search);
            this.Name = "FPlayerScreen";
            this.Text = "FPlayerScreen";
            this.Load += new System.EventHandler(this.FPlayerScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label number_of_player;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.TextBox text_position;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label nationality_label;
        private System.Windows.Forms.Label uniform_label;
        private System.Windows.Forms.Label position_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox text_uniform;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.TextBox text_nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniformNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}