namespace MariaDbTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenConnect = new System.Windows.Forms.Button();
            this.dataGridViewMariaDB = new System.Windows.Forms.DataGridView();
            this.textBoxNO = new System.Windows.Forms.TextBox();
            this.textBoxNO2 = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.rdbItem1 = new System.Windows.Forms.RadioButton();
            this.rdbItem2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMariaDB)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenConnect
            // 
            this.buttonOpenConnect.Location = new System.Drawing.Point(178, 48);
            this.buttonOpenConnect.Name = "buttonOpenConnect";
            this.buttonOpenConnect.Size = new System.Drawing.Size(75, 25);
            this.buttonOpenConnect.TabIndex = 0;
            this.buttonOpenConnect.Text = "打开连接";
            this.buttonOpenConnect.UseVisualStyleBackColor = true;
            this.buttonOpenConnect.Click += new System.EventHandler(this.buttonOpenConnect_Click);
            // 
            // dataGridViewMariaDB
            // 
            this.dataGridViewMariaDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMariaDB.Location = new System.Drawing.Point(12, 206);
            this.dataGridViewMariaDB.Name = "dataGridViewMariaDB";
            this.dataGridViewMariaDB.RowTemplate.Height = 25;
            this.dataGridViewMariaDB.Size = new System.Drawing.Size(475, 150);
            this.dataGridViewMariaDB.TabIndex = 1;
            // 
            // textBoxNO
            // 
            this.textBoxNO.Location = new System.Drawing.Point(178, 128);
            this.textBoxNO.Name = "textBoxNO";
            this.textBoxNO.Size = new System.Drawing.Size(100, 21);
            this.textBoxNO.TabIndex = 2;
            // 
            // textBoxNO2
            // 
            this.textBoxNO2.Location = new System.Drawing.Point(178, 170);
            this.textBoxNO2.Name = "textBoxNO2";
            this.textBoxNO2.Size = new System.Drawing.Size(100, 21);
            this.textBoxNO2.TabIndex = 2;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(382, 125);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 25);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "删除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(382, 85);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 25);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "查询数据";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(382, 167);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 25);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "插入数据";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(425, 375);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 25);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "关闭连接";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonCloseConnect_Click);
            // 
            // rdbItem1
            // 
            this.rdbItem1.AutoSize = true;
            this.rdbItem1.Location = new System.Drawing.Point(178, 89);
            this.rdbItem1.Name = "rdbItem1";
            this.rdbItem1.Size = new System.Drawing.Size(71, 16);
            this.rdbItem1.TabIndex = 0;
            this.rdbItem1.TabStop = true;
            this.rdbItem1.Text = "chatdata";
            this.rdbItem1.UseVisualStyleBackColor = true;
            this.rdbItem1.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // rdbItem2
            // 
            this.rdbItem2.AutoSize = true;
            this.rdbItem2.Location = new System.Drawing.Point(266, 89);
            this.rdbItem2.Name = "rdbItem2";
            this.rdbItem2.Size = new System.Drawing.Size(77, 16);
            this.rdbItem2.TabIndex = 0;
            this.rdbItem2.TabStop = true;
            this.rdbItem2.Text = "fobiddata";
            this.rdbItem2.UseVisualStyleBackColor = true;
            this.rdbItem2.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("华文新魏", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(162, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "聊天数据管理";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(12, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 15);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "请单击按钮以连接数据库：";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(12, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 15);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "请选择表名称：";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(12, 130);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 15);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "请输入id以删除记录：";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5.Location = new System.Drawing.Point(12, 170);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(143, 15);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "请输入待插入的数据：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 405);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxNO);
            this.Controls.Add(this.textBoxNO2);
            this.Controls.Add(this.dataGridViewMariaDB);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOpenConnect);
            this.Controls.Add(this.rdbItem2);
            this.Controls.Add(this.rdbItem1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMariaDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenConnect;
        private System.Windows.Forms.DataGridView dataGridViewMariaDB;
        private System.Windows.Forms.TextBox textBoxNO;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonClose;
//        private System.Windows.Forms.TextBox textBoxNO1;
        private System.Windows.Forms.TextBox textBoxNO2;
        private System.Windows.Forms.RadioButton rdbItem1;
        private System.Windows.Forms.RadioButton rdbItem2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

