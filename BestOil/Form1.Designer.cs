
namespace BestOil
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.MaskedTextBox();
            this.AddGas = new System.Windows.Forms.Button();
            this.hSum = new System.Windows.Forms.MaskedTextBox();
            this.hGasCount = new System.Windows.Forms.MaskedTextBox();
            this.hGasoline = new System.Windows.Forms.ComboBox();
            this.group = new System.Windows.Forms.GroupBox();
            this.hGasPay = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCount = new System.Windows.Forms.RadioButton();
            this.cbSum = new System.Windows.Forms.RadioButton();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.hPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Цена = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.hPayCafe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hTotalPay = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LoadData = new System.Windows.Forms.ToolStripMenuItem();
            this.AZS = new System.Windows.Forms.ToolStripMenuItem();
            this.CAFE = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.group.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.AddGas);
            this.groupBox1.Controls.Add(this.hSum);
            this.groupBox1.Controls.Add(this.hGasCount);
            this.groupBox1.Controls.Add(this.hGasoline);
            this.groupBox1.Controls.Add(this.group);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.hPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Цена);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автозаправка";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(151, 122);
            this.textBox9.Mask = "0000.00";
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 7;
            // 
            // AddGas
            // 
            this.AddGas.Location = new System.Drawing.Point(6, 145);
            this.AddGas.Name = "AddGas";
            this.AddGas.Size = new System.Drawing.Size(217, 23);
            this.AddGas.TabIndex = 6;
            this.AddGas.Text = "Добавить бензин";
            this.AddGas.UseVisualStyleBackColor = true;
            this.AddGas.Click += new System.EventHandler(this.AddGas_Click);
            // 
            // hSum
            // 
            this.hSum.Location = new System.Drawing.Point(112, 90);
            this.hSum.Mask = "0000.00";
            this.hSum.Name = "hSum";
            this.hSum.Size = new System.Drawing.Size(72, 20);
            this.hSum.TabIndex = 5;
            // 
            // hGasCount
            // 
            this.hGasCount.Location = new System.Drawing.Point(112, 67);
            this.hGasCount.Mask = "00.00";
            this.hGasCount.Name = "hGasCount";
            this.hGasCount.Size = new System.Drawing.Size(72, 20);
            this.hGasCount.TabIndex = 5;
            // 
            // hGasoline
            // 
            this.hGasoline.FormattingEnabled = true;
            this.hGasoline.Location = new System.Drawing.Point(48, 19);
            this.hGasoline.Name = "hGasoline";
            this.hGasoline.Size = new System.Drawing.Size(94, 21);
            this.hGasoline.TabIndex = 2;
            this.hGasoline.SelectedIndexChanged += new System.EventHandler(this.hGasoline_SelectedIndexChanged);
            // 
            // group
            // 
            this.group.Controls.Add(this.hGasPay);
            this.group.Location = new System.Drawing.Point(6, 170);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(253, 52);
            this.group.TabIndex = 4;
            this.group.TabStop = false;
            this.group.Text = "К оплате";
            // 
            // hGasPay
            // 
            this.hGasPay.AutoSize = true;
            this.hGasPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hGasPay.Location = new System.Drawing.Point(0, 16);
            this.hGasPay.Name = "hGasPay";
            this.hGasPay.Size = new System.Drawing.Size(87, 37);
            this.hGasPay.TabIndex = 1;
            this.hGasPay.Text = "SUM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCount);
            this.groupBox2.Controls.Add(this.cbSum);
            this.groupBox2.Location = new System.Drawing.Point(6, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 57);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // cbCount
            // 
            this.cbCount.AutoSize = true;
            this.cbCount.Checked = true;
            this.cbCount.Location = new System.Drawing.Point(6, 11);
            this.cbCount.Name = "cbCount";
            this.cbCount.Size = new System.Drawing.Size(84, 17);
            this.cbCount.TabIndex = 1;
            this.cbCount.TabStop = true;
            this.cbCount.Text = "Количество";
            this.cbCount.UseVisualStyleBackColor = true;
            this.cbCount.CheckedChanged += new System.EventHandler(this.cbCount_CheckedChanged);
            // 
            // cbSum
            // 
            this.cbSum.AutoSize = true;
            this.cbSum.Location = new System.Drawing.Point(6, 34);
            this.cbSum.Name = "cbSum";
            this.cbSum.Size = new System.Drawing.Size(59, 17);
            this.cbSum.TabIndex = 2;
            this.cbSum.TabStop = true;
            this.cbSum.Text = "Сумма";
            this.cbSum.UseVisualStyleBackColor = true;
            this.cbSum.CheckedChanged += new System.EventHandler(this.cbCount_CheckedChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(48, 122);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(72, 20);
            this.textBox10.TabIndex = 1;
            // 
            // hPrice
            // 
            this.hPrice.Location = new System.Drawing.Point(187, 20);
            this.hPrice.Name = "hPrice";
            this.hPrice.Size = new System.Drawing.Size(72, 20);
            this.hPrice.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "грн.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "литров";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Бензин";
            // 
            // Цена
            // 
            this.Цена.AutoSize = true;
            this.Цена.Location = new System.Drawing.Point(148, 27);
            this.Цена.Name = "Цена";
            this.Цена.Size = new System.Drawing.Size(33, 13);
            this.Цена.TabIndex = 2;
            this.Цена.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Бензин";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(322, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 229);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "АвтоКафе";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox4.Location = new System.Drawing.Point(14, 101);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(79, 17);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Кока Кола";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.cbCount_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.Location = new System.Drawing.Point(14, 80);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(88, 16);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Картошка Фри";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.cbCount_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(14, 59);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Гамбургер";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.cbCount_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Хот-Дог";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.cbCount_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.hPayCafe);
            this.groupBox4.Location = new System.Drawing.Point(6, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 68);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "К оплате";
            // 
            // hPayCafe
            // 
            this.hPayCafe.AutoSize = true;
            this.hPayCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hPayCafe.Location = new System.Drawing.Point(6, 16);
            this.hPayCafe.Name = "hPayCafe";
            this.hPayCafe.Size = new System.Drawing.Size(87, 37);
            this.hPayCafe.TabIndex = 1;
            this.hPayCafe.Text = "SUM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Количество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Цена";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(166, 99);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(55, 20);
            this.textBox8.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(166, 77);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(55, 20);
            this.textBox6.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(166, 56);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(55, 20);
            this.textBox4.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(166, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(105, 99);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(55, 20);
            this.textBox7.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(105, 77);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(55, 20);
            this.textBox5.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(55, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 20);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.hTotalPay);
            this.groupBox5.Location = new System.Drawing.Point(12, 277);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(580, 68);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "К оплате";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Расчёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hTotalPay
            // 
            this.hTotalPay.AutoSize = true;
            this.hTotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hTotalPay.Location = new System.Drawing.Point(276, 16);
            this.hTotalPay.Name = "hTotalPay";
            this.hTotalPay.Size = new System.Drawing.Size(87, 37);
            this.hTotalPay.TabIndex = 1;
            this.hTotalPay.Text = "SUM";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadData});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LoadData
            // 
            this.LoadData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AZS,
            this.CAFE});
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(111, 20);
            this.LoadData.Text = "Загрузка данных";
            // 
            // AZS
            // 
            this.AZS.Name = "AZS";
            this.AZS.Size = new System.Drawing.Size(180, 22);
            this.AZS.Text = "Автозаправка";
            this.AZS.Click += new System.EventHandler(this.AZS_Click);
            // 
            // CAFE
            // 
            this.CAFE.Name = "CAFE";
            this.CAFE.Size = new System.Drawing.Size(180, 22);
            this.CAFE.Text = "Кафе";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(601, 372);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton cbSum;
        private System.Windows.Forms.TextBox hPrice;
        private System.Windows.Forms.Label Цена;
        private System.Windows.Forms.RadioButton cbCount;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Label hGasPay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label hPayCafe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label hTotalPay;
        private System.Windows.Forms.ComboBox hGasoline;
        private System.Windows.Forms.MaskedTextBox hSum;
        private System.Windows.Forms.MaskedTextBox hGasCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem LoadData;
        private System.Windows.Forms.ToolStripMenuItem AZS;
        private System.Windows.Forms.ToolStripMenuItem CAFE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button AddGas;
        private System.Windows.Forms.MaskedTextBox textBox9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

