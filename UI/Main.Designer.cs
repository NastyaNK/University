namespace University
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
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
            this.группыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.university_ds = new University.Data.university_ds();
            this.информация_о_преподеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.информация_о_студентеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ведомостьСтудентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.факультетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ведомостьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ta_ведомость = new University.Data.university_dsTableAdapters.ВедомостьTableAdapter();
            this.ta_manager = new University.Data.university_dsTableAdapters.TableAdapterManager();
            this.ta_группы = new University.Data.university_dsTableAdapters.ГруппыTableAdapter();
            this.ta_дисциплины = new University.Data.university_dsTableAdapters.ДисциплиныTableAdapter();
            this.ta_кафедры = new University.Data.university_dsTableAdapters.КафедрыTableAdapter();
            this.ta_пользователи = new University.Data.university_dsTableAdapters.ПользователиTableAdapter();
            this.ta_преподаватели = new University.Data.university_dsTableAdapters.ПреподавателиTableAdapter();
            this.ta_специальности = new University.Data.university_dsTableAdapters.СпециальностиTableAdapter();
            this.ta_студенты = new University.Data.university_dsTableAdapters.СтудентыTableAdapter();
            this.ta_учебплан = new University.Data.university_dsTableAdapters.Учебный_планTableAdapter();
            this.ta_факультеты = new University.Data.university_dsTableAdapters.ФакультетыTableAdapter();
            this.ведомостьСтудентаTableAdapter = new University.Data.university_dsTableAdapters.ВедомостьСтудентаTableAdapter();
            this.дисциплиныBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кафедрыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.преподавателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.специальностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учебный_планBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ta_студент_ПИ = new University.Data.university_dsTableAdapters.Информация_о_студентеTableAdapter();
            this.ta_преподаватель_ПИ = new University.Data.university_dsTableAdapters.Информация_о_преподеTableAdapter();
            this.ведомость_ПреподаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ведомость_ПреподаTableAdapter = new University.Data.university_dsTableAdapters.Ведомость_ПреподаTableAdapter();
            this.преподыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.преподыTableAdapter = new University.Data.university_dsTableAdapters.ПреподыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sc_main)).BeginInit();
            this.sc_main.Panel1.SuspendLayout();
            this.sc_main.Panel2.SuspendLayout();
            this.sc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информация_о_преподеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информация_о_студентеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ведомостьСтудентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ведомостьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дисциплиныBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кафедрыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учебный_планBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ведомость_ПреподаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподыBindingSource)).BeginInit();
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
            this.sc_main.Size = new System.Drawing.Size(884, 570);
            this.sc_main.SplitterDistance = 633;
            this.sc_main.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(545, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Отчёты";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(545, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Справка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l_warn
            // 
            this.l_warn.BackColor = System.Drawing.SystemColors.Control;
            this.l_warn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_warn.Location = new System.Drawing.Point(27, 46);
            this.l_warn.Name = "l_warn";
            this.l_warn.Size = new System.Drawing.Size(483, 19);
            this.l_warn.TabIndex = 12;
            this.l_warn.Text = "Сообщение";
            this.l_warn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_load
            // 
            this.btn_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_load.Location = new System.Drawing.Point(84, 541);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 5;
            this.btn_load.Text = "Обновить";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_save.Location = new System.Drawing.Point(3, 541);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Location = new System.Drawing.Point(555, 540);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Поиск";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search.Location = new System.Drawing.Point(165, 543);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(387, 20);
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
            this.data_title.Size = new System.Drawing.Size(507, 51);
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
            this.dataGridView1.Size = new System.Drawing.Size(627, 455);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Location = new System.Drawing.Point(3, 536);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(241, 31);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
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
            this.l_info.Size = new System.Drawing.Size(241, 176);
            this.l_info.TabIndex = 8;
            this.l_info.Text = "Информация";
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
            this.panel1.Location = new System.Drawing.Point(3, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 416);
            this.panel1.TabIndex = 11;
            // 
            // l_class
            // 
            this.l_class.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_class.BackColor = System.Drawing.SystemColors.Control;
            this.l_class.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_class.Location = new System.Drawing.Point(112, 9);
            this.l_class.Name = "l_class";
            this.l_class.Size = new System.Drawing.Size(132, 19);
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
            this.l_id.Size = new System.Drawing.Size(129, 19);
            this.l_id.TabIndex = 10;
            this.l_id.Text = "Идентификатор";
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
            // группыBindingSource
            // 
            this.группыBindingSource.DataMember = "Группы";
            this.группыBindingSource.DataSource = this.university_ds;
            // 
            // university_ds
            // 
            this.university_ds.DataSetName = "university_ds";
            this.university_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // информация_о_преподеBindingSource
            // 
            this.информация_о_преподеBindingSource.DataMember = "Информация о преподе";
            this.информация_о_преподеBindingSource.DataSource = this.university_ds;
            // 
            // информация_о_студентеBindingSource
            // 
            this.информация_о_студентеBindingSource.DataMember = "Информация о студенте";
            this.информация_о_студентеBindingSource.DataSource = this.university_ds;
            // 
            // ведомостьСтудентаBindingSource
            // 
            this.ведомостьСтудентаBindingSource.DataMember = "ВедомостьСтудента";
            this.ведомостьСтудентаBindingSource.DataSource = this.university_ds;
            // 
            // факультетыBindingSource
            // 
            this.факультетыBindingSource.DataMember = "Факультеты";
            this.факультетыBindingSource.DataSource = this.university_ds;
            // 
            // ведомостьBindingSource
            // 
            this.ведомостьBindingSource.DataMember = "Ведомость";
            this.ведомостьBindingSource.DataSource = this.university_ds;
            // 
            // ta_ведомость
            // 
            this.ta_ведомость.ClearBeforeFill = true;
            // 
            // ta_manager
            // 
            this.ta_manager.BackupDataSetBeforeUpdate = false;
            this.ta_manager.UpdateOrder = University.Data.university_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.ta_manager.Ведомость_ПреподаTableAdapter = null;
            this.ta_manager.ВедомостьTableAdapter = this.ta_ведомость;
            this.ta_manager.ГруппыTableAdapter = this.ta_группы;
            this.ta_manager.ДисциплиныTableAdapter = this.ta_дисциплины;
            this.ta_manager.КафедрыTableAdapter = this.ta_кафедры;
            this.ta_manager.ПользователиTableAdapter = this.ta_пользователи;
            this.ta_manager.ПреподавателиTableAdapter = this.ta_преподаватели;
            this.ta_manager.СпециальностиTableAdapter = this.ta_специальности;
            this.ta_manager.СтудентыTableAdapter = this.ta_студенты;
            this.ta_manager.Учебный_планTableAdapter = this.ta_учебплан;
            this.ta_manager.ФакультетыTableAdapter = this.ta_факультеты;
            // 
            // ta_группы
            // 
            this.ta_группы.ClearBeforeFill = true;
            // 
            // ta_дисциплины
            // 
            this.ta_дисциплины.ClearBeforeFill = true;
            // 
            // ta_кафедры
            // 
            this.ta_кафедры.ClearBeforeFill = true;
            // 
            // ta_пользователи
            // 
            this.ta_пользователи.ClearBeforeFill = true;
            // 
            // ta_преподаватели
            // 
            this.ta_преподаватели.ClearBeforeFill = true;
            // 
            // ta_специальности
            // 
            this.ta_специальности.ClearBeforeFill = true;
            // 
            // ta_студенты
            // 
            this.ta_студенты.ClearBeforeFill = true;
            // 
            // ta_учебплан
            // 
            this.ta_учебплан.ClearBeforeFill = true;
            // 
            // ta_факультеты
            // 
            this.ta_факультеты.ClearBeforeFill = true;
            // 
            // ведомостьСтудентаTableAdapter
            // 
            this.ведомостьСтудентаTableAdapter.ClearBeforeFill = true;
            // 
            // дисциплиныBindingSource
            // 
            this.дисциплиныBindingSource.DataMember = "Дисциплины";
            this.дисциплиныBindingSource.DataSource = this.university_ds;
            // 
            // кафедрыBindingSource
            // 
            this.кафедрыBindingSource.DataMember = "Кафедры";
            this.кафедрыBindingSource.DataSource = this.university_ds;
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataMember = "Пользователи";
            this.пользователиBindingSource.DataSource = this.university_ds;
            // 
            // преподавателиBindingSource
            // 
            this.преподавателиBindingSource.DataMember = "Преподаватели";
            this.преподавателиBindingSource.DataSource = this.university_ds;
            // 
            // специальностиBindingSource
            // 
            this.специальностиBindingSource.DataMember = "Специальности";
            this.специальностиBindingSource.DataSource = this.university_ds;
            // 
            // студентыBindingSource
            // 
            this.студентыBindingSource.DataMember = "Студенты";
            this.студентыBindingSource.DataSource = this.university_ds;
            // 
            // учебный_планBindingSource
            // 
            this.учебный_планBindingSource.DataMember = "Учебный план";
            this.учебный_планBindingSource.DataSource = this.university_ds;
            // 
            // ta_студент_ПИ
            // 
            this.ta_студент_ПИ.ClearBeforeFill = true;
            // 
            // ta_преподаватель_ПИ
            // 
            this.ta_преподаватель_ПИ.ClearBeforeFill = true;
            // 
            // ведомость_ПреподаBindingSource
            // 
            this.ведомость_ПреподаBindingSource.DataMember = "Ведомость Препода";
            this.ведомость_ПреподаBindingSource.DataSource = this.university_ds;
            // 
            // ведомость_ПреподаTableAdapter
            // 
            this.ведомость_ПреподаTableAdapter.ClearBeforeFill = true;
            // 
            // преподыBindingSource
            // 
            this.преподыBindingSource.DataMember = "Преподы";
            this.преподыBindingSource.DataSource = this.university_ds;
            // 
            // преподыTableAdapter
            // 
            this.преподыTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 570);
            this.Controls.Add(this.sc_main);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisibleChanged += new System.EventHandler(this.Main_VisibleChanged);
            this.sc_main.Panel1.ResumeLayout(false);
            this.sc_main.Panel1.PerformLayout();
            this.sc_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_main)).EndInit();
            this.sc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информация_о_преподеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информация_о_студентеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ведомостьСтудентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ведомостьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дисциплиныBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кафедрыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учебный_планBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ведомость_ПреподаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc_main;
        private System.Windows.Forms.Label l_class;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label data_title;
        private Data.university_ds university_ds;
        private System.Windows.Forms.BindingSource ведомостьBindingSource;
        private Data.university_dsTableAdapters.ВедомостьTableAdapter ta_ведомость;
        private System.Windows.Forms.BindingSource ведомостьСтудентаBindingSource;
        private Data.university_dsTableAdapters.ВедомостьСтудентаTableAdapter ведомостьСтудентаTableAdapter;
        private Data.university_dsTableAdapters.ГруппыTableAdapter ta_группы;
        private System.Windows.Forms.BindingSource группыBindingSource;
        private Data.university_dsTableAdapters.ДисциплиныTableAdapter ta_дисциплины;
        private System.Windows.Forms.BindingSource дисциплиныBindingSource;
        private Data.university_dsTableAdapters.КафедрыTableAdapter ta_кафедры;
        private System.Windows.Forms.BindingSource кафедрыBindingSource;
        private Data.university_dsTableAdapters.ПользователиTableAdapter ta_пользователи;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private Data.university_dsTableAdapters.ПреподавателиTableAdapter ta_преподаватели;
        private System.Windows.Forms.BindingSource преподавателиBindingSource;
        private Data.university_dsTableAdapters.СпециальностиTableAdapter ta_специальности;
        private System.Windows.Forms.BindingSource специальностиBindingSource;
        private Data.university_dsTableAdapters.СтудентыTableAdapter ta_студенты;
        private System.Windows.Forms.BindingSource студентыBindingSource;
        private Data.university_dsTableAdapters.Учебный_планTableAdapter ta_учебплан;
        private System.Windows.Forms.BindingSource учебный_планBindingSource;
        private Data.university_dsTableAdapters.ФакультетыTableAdapter ta_факультеты;
        private System.Windows.Forms.BindingSource факультетыBindingSource;
        public Data.university_dsTableAdapters.TableAdapterManager ta_manager;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.Label l_info;
        private System.Windows.Forms.BindingSource информация_о_студентеBindingSource;
        public Data.university_dsTableAdapters.Информация_о_студентеTableAdapter ta_студент_ПИ;
        private System.Windows.Forms.BindingSource информация_о_преподеBindingSource;
        public Data.university_dsTableAdapters.Информация_о_преподеTableAdapter ta_преподаватель_ПИ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label l_warn;
        private System.Windows.Forms.BindingSource ведомость_ПреподаBindingSource;
        private Data.university_dsTableAdapters.Ведомость_ПреподаTableAdapter ведомость_ПреподаTableAdapter;
        private System.Windows.Forms.BindingSource преподыBindingSource;
        private Data.university_dsTableAdapters.ПреподыTableAdapter преподыTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

