namespace Sistema_erp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Usuariotxt = new TextBox();
            Senhatxt = new TextBox();
            button1 = new Button();
            label1 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // Usuariotxt
            // 
            Usuariotxt.BackColor = Color.FromArgb(255, 252, 237);
            Usuariotxt.BorderStyle = BorderStyle.None;
            Usuariotxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usuariotxt.ImeMode = ImeMode.NoControl;
            Usuariotxt.Location = new Point(421, 281);
            Usuariotxt.Multiline = true;
            Usuariotxt.Name = "Usuariotxt";
            Usuariotxt.PlaceholderText = "Usuário";
            Usuariotxt.Size = new Size(236, 28);
            Usuariotxt.TabIndex = 0;
            Usuariotxt.TabStop = false;
            // 
            // Senhatxt
            // 
            Senhatxt.BackColor = Color.FromArgb(255, 252, 237);
            Senhatxt.BorderStyle = BorderStyle.None;
            Senhatxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Senhatxt.ImeMode = ImeMode.NoControl;
            Senhatxt.Location = new Point(421, 346);
            Senhatxt.Multiline = true;
            Senhatxt.Name = "Senhatxt";
            Senhatxt.PlaceholderText = "Senha";
            Senhatxt.Size = new Size(236, 28);
            Senhatxt.TabIndex = 1;
            Senhatxt.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(533, 465);
            button1.Name = "button1";
            button1.Size = new Size(66, 23);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(396, 405);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 4;
            label1.Text = "Manter Conectado";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(375, 406);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 5;
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1008, 740);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(Senhatxt);
            Controls.Add(Usuariotxt);
            Name = "Login";
            Text = "Erp Sistem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Usuariotxt;
        private TextBox Senhatxt;
        private Button button1;
        private Label label1;
        private CheckBox checkBox1;
    }
}
