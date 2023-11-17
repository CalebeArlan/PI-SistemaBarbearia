namespace SistemaBarbearia_PI
{
    partial class CadastroHorario
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
            button1 = new Button();
            label4 = new Label();
            BtnCadastrar = new Button();
            LblData = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(19, 296);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 19);
            label4.Name = "label4";
            label4.Size = new Size(287, 32);
            label4.TabIndex = 17;
            label4.Text = "Cadastrar Novo Horário";
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Image = Properties.Resources.icons8_ok_48;
            BtnCadastrar.Location = new Point(234, 287);
            BtnCadastrar.Margin = new Padding(3, 2, 3, 2);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(56, 41);
            BtnCadastrar.TabIndex = 10;
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // LblData
            // 
            LblData.AutoSize = true;
            LblData.Location = new Point(25, 72);
            LblData.Name = "LblData";
            LblData.Size = new Size(34, 15);
            LblData.TabIndex = 11;
            LblData.Text = "Data:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(236, 72);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 31;
            label5.Text = "Horário:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(81, 68);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(133, 23);
            dateTimePicker1.TabIndex = 32;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "hh:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(291, 68);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(103, 23);
            dateTimePicker2.TabIndex = 33;
            // 
            // CadastroHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(BtnCadastrar);
            Controls.Add(LblData);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastroHorario";
            Text = "CadastroHoráriocs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label4;
        private Button BtnCadastrar;
        private Label LblData;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}