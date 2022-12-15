
namespace University.UI
{
    partial class Help
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
            this.sc_main = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.l_warn = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.data_title = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_exit = new System.Windows.Forms.Button();
            this.l_info = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_class = new System.Windows.Forms.Label();
            this.l_id = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sc_main)).BeginInit();
            this.sc_main.Panel1.SuspendLayout();
            this.sc_main.Panel2.SuspendLayout();
            this.sc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sc_main
            // 
            this.sc_main.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_main.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.sc_main.Location = new System.Drawing.Point(0, 0);
            this.sc_main.Name = "sc_main";
            // 
            // sc_main.Panel1
            // 
            this.sc_main.Panel1.AutoScroll = true;
            this.sc_main.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.sc_main.Panel1.Controls.Add(this.label3);
            this.sc_main.Panel1.Controls.Add(this.label2);
            this.sc_main.Panel1.Controls.Add(this.label1);
            this.sc_main.Panel1.Controls.Add(this.button2);
            this.sc_main.Panel1.Controls.Add(this.button1);
            this.sc_main.Panel1.Controls.Add(this.l_warn);
            this.sc_main.Panel1.Controls.Add(this.btn_load);
            this.sc_main.Panel1.Controls.Add(this.btn_save);
            this.sc_main.Panel1.Controls.Add(this.btn_search);
            this.sc_main.Panel1.Controls.Add(this.tb_search);
            this.sc_main.Panel1.Controls.Add(this.data_title);
            this.sc_main.Panel1.Controls.Add(this.dataGridView1);
            this.sc_main.Panel1MinSize = 500;
            // 
            // sc_main.Panel2
            // 
            this.sc_main.Panel2.AutoScroll = true;
            this.sc_main.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.sc_main.Panel2.Controls.Add(this.btn_exit);
            this.sc_main.Panel2.Controls.Add(this.l_info);
            this.sc_main.Panel2.Controls.Add(this.panel1);
            this.sc_main.Panel2.Controls.Add(this.l_class);
            this.sc_main.Panel2.Controls.Add(this.l_id);
            this.sc_main.Panel2.Controls.Add(this.l_name);
            this.sc_main.Panel2MinSize = 200;
            this.sc_main.Size = new System.Drawing.Size(800, 450);
            this.sc_main.SplitterDistance = 549;
            this.sc_main.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(461, -105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Отчёты";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(461, -78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Справка";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // l_warn
            // 
            this.l_warn.BackColor = System.Drawing.SystemColors.Control;
            this.l_warn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_warn.Location = new System.Drawing.Point(27, 46);
            this.l_warn.Name = "l_warn";
            this.l_warn.Size = new System.Drawing.Size(483, 19);
            this.l_warn.TabIndex = 12;
            this.l_warn.Text = "Информационное сообщение";
            this.l_warn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_load
            // 
            this.btn_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_load.Location = new System.Drawing.Point(84, 421);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 5;
            this.btn_load.Text = "Обновить";
            this.btn_load.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_save.Location = new System.Drawing.Point(3, 421);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Location = new System.Drawing.Point(471, 420);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Поиск";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // tb_search
            // 
            this.tb_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search.Location = new System.Drawing.Point(165, 423);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(303, 20);
            this.tb_search.TabIndex = 2;
            // 
            // data_title
            // 
            this.data_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_title.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_title.Location = new System.Drawing.Point(3, 9);
            this.data_title.Name = "data_title";
            this.data_title.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.data_title.Size = new System.Drawing.Size(423, 51);
            this.data_title.TabIndex = 1;
            this.data_title.Text = "Заголовок";
            this.data_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Location = new System.Drawing.Point(3, 416);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(241, 31);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // l_info
            // 
            this.l_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_info.BackColor = System.Drawing.Color.Transparent;
            this.l_info.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_info.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_info.Location = new System.Drawing.Point(3, 82);
            this.l_info.Name = "l_info";
            this.l_info.Size = new System.Drawing.Size(241, 136);
            this.l_info.TabIndex = 8;
            this.l_info.Text = "Дополнительная информация о пользователе";
            this.l_info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 296);
            this.panel1.TabIndex = 11;
            // 
            // l_class
            // 
            this.l_class.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_class.BackColor = System.Drawing.SystemColors.Control;
            this.l_class.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_class.Location = new System.Drawing.Point(123, 9);
            this.l_class.Name = "l_class";
            this.l_class.Size = new System.Drawing.Size(121, 32);
            this.l_class.TabIndex = 2;
            this.l_class.Text = "Тип аккаунта";
            this.l_class.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_id
            // 
            this.l_id.BackColor = System.Drawing.SystemColors.Control;
            this.l_id.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_id.Location = new System.Drawing.Point(0, 9);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(129, 32);
            this.l_id.TabIndex = 10;
            this.l_id.Text = "Идентификатор или номер зачётной книжки";
            this.l_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // l_name
            // 
            this.l_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_name.Location = new System.Drawing.Point(3, 28);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(241, 51);
            this.l_name.TabIndex = 0;
            this.l_name.Text = "Фамилия Имя Отчество";
            this.l_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Управление выгрузкой и загрузкой данных";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(165, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Поисковая система";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(97, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 168);
            this.label3.TabIndex = 17;
            this.label3.Text = "Таблица данных\r\n\r\nНекоторые поля поддерживают переход по двойному клику.\r\nНаприме" +
    "р, при двойном клике на название факультета будет открыта таблица с кафедрами то" +
    "лько из этого факультета";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 192);
            this.label4.TabIndex = 18;
            this.label4.Text = "Кнопки для перехода к различным вкладкам";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sc_main);
            this.Name = "Help";
            this.Text = "Help";
            this.sc_main.Panel1.ResumeLayout(false);
            this.sc_main.Panel1.PerformLayout();
            this.sc_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_main)).EndInit();
            this.sc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc_main;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label l_warn;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label data_title;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label l_info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_class;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}