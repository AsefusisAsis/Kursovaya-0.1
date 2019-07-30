namespace Kursovaya_0._1
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иконкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.силаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ловкостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.интелектDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.атакаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скоростьАтакиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скоростьПередвиженияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.восстановлениеМаныDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.восстановлениеЗдоровьяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сопротивлениеМагииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяПерезарядкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.манакостDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.spellDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.commonitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dota2DataSet = new Kursovaya_0._1.Dota2DataSet();
            this.common_itemsTableAdapter = new Kursovaya_0._1.Dota2DataSetTableAdapters.common_itemsTableAdapter();
            this.info = new System.Windows.Forms.Panel();
            this.Activelab = new System.Windows.Forms.Label();
            this.Passivelab = new System.Windows.Forms.Label();
            this.property = new System.Windows.Forms.Label();
            this.Uselab = new System.Windows.Forms.Label();
            this.Infolab = new System.Windows.Forms.Label();
            this.ItemName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.infoPic = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Basic = new System.Windows.Forms.Panel();
            this.Basiclab = new System.Windows.Forms.Label();
            this.Upgrade = new System.Windows.Forms.Panel();
            this.Upgradelab = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dota2DataSet)).BeginInit();
            this.info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPic)).BeginInit();
            this.Basic.SuspendLayout();
            this.Upgrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.иконкаDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.силаDataGridViewTextBoxColumn,
            this.ловкостьDataGridViewTextBoxColumn,
            this.интелектDataGridViewTextBoxColumn,
            this.атакаDataGridViewTextBoxColumn,
            this.скоростьАтакиDataGridViewTextBoxColumn,
            this.скоростьПередвиженияDataGridViewTextBoxColumn,
            this.восстановлениеМаныDataGridViewTextBoxColumn,
            this.восстановлениеЗдоровьяDataGridViewTextBoxColumn,
            this.сопротивлениеМагииDataGridViewTextBoxColumn,
            this.времяПерезарядкиDataGridViewTextBoxColumn,
            this.манакостDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.usableDataGridViewCheckBoxColumn,
            this.spellDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.commonitemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-132, 449);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(512, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // иконкаDataGridViewTextBoxColumn
            // 
            this.иконкаDataGridViewTextBoxColumn.DataPropertyName = "Иконка";
            this.иконкаDataGridViewTextBoxColumn.HeaderText = "Иконка";
            this.иконкаDataGridViewTextBoxColumn.Name = "иконкаDataGridViewTextBoxColumn";
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // силаDataGridViewTextBoxColumn
            // 
            this.силаDataGridViewTextBoxColumn.DataPropertyName = "Сила";
            this.силаDataGridViewTextBoxColumn.HeaderText = "Сила";
            this.силаDataGridViewTextBoxColumn.Name = "силаDataGridViewTextBoxColumn";
            // 
            // ловкостьDataGridViewTextBoxColumn
            // 
            this.ловкостьDataGridViewTextBoxColumn.DataPropertyName = "Ловкость";
            this.ловкостьDataGridViewTextBoxColumn.HeaderText = "Ловкость";
            this.ловкостьDataGridViewTextBoxColumn.Name = "ловкостьDataGridViewTextBoxColumn";
            // 
            // интелектDataGridViewTextBoxColumn
            // 
            this.интелектDataGridViewTextBoxColumn.DataPropertyName = "Интелект";
            this.интелектDataGridViewTextBoxColumn.HeaderText = "Интелект";
            this.интелектDataGridViewTextBoxColumn.Name = "интелектDataGridViewTextBoxColumn";
            // 
            // атакаDataGridViewTextBoxColumn
            // 
            this.атакаDataGridViewTextBoxColumn.DataPropertyName = "Атака";
            this.атакаDataGridViewTextBoxColumn.HeaderText = "Атака";
            this.атакаDataGridViewTextBoxColumn.Name = "атакаDataGridViewTextBoxColumn";
            // 
            // скоростьАтакиDataGridViewTextBoxColumn
            // 
            this.скоростьАтакиDataGridViewTextBoxColumn.DataPropertyName = "Скорость атаки";
            this.скоростьАтакиDataGridViewTextBoxColumn.HeaderText = "Скорость атаки";
            this.скоростьАтакиDataGridViewTextBoxColumn.Name = "скоростьАтакиDataGridViewTextBoxColumn";
            // 
            // скоростьПередвиженияDataGridViewTextBoxColumn
            // 
            this.скоростьПередвиженияDataGridViewTextBoxColumn.DataPropertyName = "Скорость передвижения";
            this.скоростьПередвиженияDataGridViewTextBoxColumn.HeaderText = "Скорость передвижения";
            this.скоростьПередвиженияDataGridViewTextBoxColumn.Name = "скоростьПередвиженияDataGridViewTextBoxColumn";
            // 
            // восстановлениеМаныDataGridViewTextBoxColumn
            // 
            this.восстановлениеМаныDataGridViewTextBoxColumn.DataPropertyName = "Восстановление маны";
            this.восстановлениеМаныDataGridViewTextBoxColumn.HeaderText = "Восстановление маны";
            this.восстановлениеМаныDataGridViewTextBoxColumn.Name = "восстановлениеМаныDataGridViewTextBoxColumn";
            // 
            // восстановлениеЗдоровьяDataGridViewTextBoxColumn
            // 
            this.восстановлениеЗдоровьяDataGridViewTextBoxColumn.DataPropertyName = "Восстановление здоровья";
            this.восстановлениеЗдоровьяDataGridViewTextBoxColumn.HeaderText = "Восстановление здоровья";
            this.восстановлениеЗдоровьяDataGridViewTextBoxColumn.Name = "восстановлениеЗдоровьяDataGridViewTextBoxColumn";
            // 
            // сопротивлениеМагииDataGridViewTextBoxColumn
            // 
            this.сопротивлениеМагииDataGridViewTextBoxColumn.DataPropertyName = "Сопротивление магии";
            this.сопротивлениеМагииDataGridViewTextBoxColumn.HeaderText = "Сопротивление магии";
            this.сопротивлениеМагииDataGridViewTextBoxColumn.Name = "сопротивлениеМагииDataGridViewTextBoxColumn";
            // 
            // времяПерезарядкиDataGridViewTextBoxColumn
            // 
            this.времяПерезарядкиDataGridViewTextBoxColumn.DataPropertyName = "Время перезарядки";
            this.времяПерезарядкиDataGridViewTextBoxColumn.HeaderText = "Время перезарядки";
            this.времяПерезарядкиDataGridViewTextBoxColumn.Name = "времяПерезарядкиDataGridViewTextBoxColumn";
            // 
            // манакостDataGridViewTextBoxColumn
            // 
            this.манакостDataGridViewTextBoxColumn.DataPropertyName = "Манакост";
            this.манакостDataGridViewTextBoxColumn.HeaderText = "Манакост";
            this.манакостDataGridViewTextBoxColumn.Name = "манакостDataGridViewTextBoxColumn";
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            // 
            // usableDataGridViewCheckBoxColumn
            // 
            this.usableDataGridViewCheckBoxColumn.DataPropertyName = "usable";
            this.usableDataGridViewCheckBoxColumn.HeaderText = "usable";
            this.usableDataGridViewCheckBoxColumn.Name = "usableDataGridViewCheckBoxColumn";
            // 
            // spellDataGridViewCheckBoxColumn
            // 
            this.spellDataGridViewCheckBoxColumn.DataPropertyName = "spell";
            this.spellDataGridViewCheckBoxColumn.HeaderText = "spell";
            this.spellDataGridViewCheckBoxColumn.Name = "spellDataGridViewCheckBoxColumn";
            // 
            // commonitemsBindingSource
            // 
            this.commonitemsBindingSource.DataMember = "common_items";
            this.commonitemsBindingSource.DataSource = this.dota2DataSet;
            // 
            // dota2DataSet
            // 
            this.dota2DataSet.DataSetName = "Dota2DataSet";
            this.dota2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // common_itemsTableAdapter
            // 
            this.common_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // info
            // 
            this.info.AutoScroll = true;
            this.info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(34)))));
            this.info.Controls.Add(this.Activelab);
            this.info.Controls.Add(this.Passivelab);
            this.info.Controls.Add(this.property);
            this.info.Controls.Add(this.Uselab);
            this.info.Controls.Add(this.Infolab);
            this.info.Controls.Add(this.ItemName);
            this.info.Controls.Add(this.label2);
            this.info.Controls.Add(this.label1);
            this.info.Controls.Add(this.infoPic);
            this.info.Location = new System.Drawing.Point(570, 34);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(421, 346);
            this.info.TabIndex = 1;
            this.info.Visible = false;
            // 
            // Activelab
            // 
            this.Activelab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.Activelab.Font = new System.Drawing.Font("asinastra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Activelab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(78)))), ((int)(((byte)(156)))));
            this.Activelab.Location = new System.Drawing.Point(78, 133);
            this.Activelab.Name = "Activelab";
            this.Activelab.Size = new System.Drawing.Size(264, 213);
            this.Activelab.TabIndex = 9;
            this.Activelab.Text = "label3";
            this.Activelab.Visible = false;
            // 
            // Passivelab
            // 
            this.Passivelab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Passivelab.Font = new System.Drawing.Font("asinastra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passivelab.ForeColor = System.Drawing.Color.Silver;
            this.Passivelab.Location = new System.Drawing.Point(78, 97);
            this.Passivelab.Name = "Passivelab";
            this.Passivelab.Size = new System.Drawing.Size(264, 152);
            this.Passivelab.TabIndex = 8;
            this.Passivelab.Text = "label3";
            this.Passivelab.Visible = false;
            // 
            // property
            // 
            this.property.AutoSize = true;
            this.property.Font = new System.Drawing.Font("asinastra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.property.ForeColor = System.Drawing.Color.White;
            this.property.Location = new System.Drawing.Point(166, 202);
            this.property.Name = "property";
            this.property.Size = new System.Drawing.Size(56, 16);
            this.property.TabIndex = 7;
            this.property.Text = "label3";
            // 
            // Uselab
            // 
            this.Uselab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(62)))), ((int)(((byte)(39)))));
            this.Uselab.Font = new System.Drawing.Font("asinastra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Uselab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(192)))), ((int)(((byte)(122)))));
            this.Uselab.Location = new System.Drawing.Point(12, 173);
            this.Uselab.Name = "Uselab";
            this.Uselab.Size = new System.Drawing.Size(264, 152);
            this.Uselab.TabIndex = 6;
            this.Uselab.Text = "label3";
            this.Uselab.Visible = false;
            // 
            // Infolab
            // 
            this.Infolab.AutoSize = true;
            this.Infolab.Font = new System.Drawing.Font("asinastra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Infolab.ForeColor = System.Drawing.Color.White;
            this.Infolab.Location = new System.Drawing.Point(193, 52);
            this.Infolab.Name = "Infolab";
            this.Infolab.Size = new System.Drawing.Size(104, 16);
            this.Infolab.TabIndex = 4;
            this.Infolab.Text = "Информация";
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemName.ForeColor = System.Drawing.Color.White;
            this.ItemName.Location = new System.Drawing.Point(122, 13);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(100, 20);
            this.ItemName.TabIndex = 3;
            this.ItemName.Text = "Название:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("asinastra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 111);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("asinastra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Цена:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoPic
            // 
            this.infoPic.Location = new System.Drawing.Point(15, 3);
            this.infoPic.Name = "infoPic";
            this.infoPic.Size = new System.Drawing.Size(100, 50);
            this.infoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.infoPic.TabIndex = 0;
            this.infoPic.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Basic
            // 
            this.Basic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(34)))));
            this.Basic.Controls.Add(this.Basiclab);
            this.Basic.Location = new System.Drawing.Point(40, 34);
            this.Basic.Name = "Basic";
            this.Basic.Size = new System.Drawing.Size(266, 100);
            this.Basic.TabIndex = 3;
            // 
            // Basiclab
            // 
            this.Basiclab.AutoSize = true;
            this.Basiclab.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Basiclab.ForeColor = System.Drawing.Color.Transparent;
            this.Basiclab.Location = new System.Drawing.Point(100, 4);
            this.Basiclab.Name = "Basiclab";
            this.Basiclab.Size = new System.Drawing.Size(99, 20);
            this.Basiclab.TabIndex = 0;
            this.Basiclab.Text = "Основные";
            // 
            // Upgrade
            // 
            this.Upgrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(34)))));
            this.Upgrade.Controls.Add(this.Upgradelab);
            this.Upgrade.Location = new System.Drawing.Point(308, 184);
            this.Upgrade.Name = "Upgrade";
            this.Upgrade.Size = new System.Drawing.Size(266, 100);
            this.Upgrade.TabIndex = 4;
            // 
            // Upgradelab
            // 
            this.Upgradelab.AutoSize = true;
            this.Upgradelab.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Upgradelab.ForeColor = System.Drawing.Color.Transparent;
            this.Upgradelab.Location = new System.Drawing.Point(100, 4);
            this.Upgradelab.Name = "Upgradelab";
            this.Upgradelab.Size = new System.Drawing.Size(106, 20);
            this.Upgradelab.TabIndex = 0;
            this.Upgradelab.Text = "Улучшения";
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(950, 659);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(66, 20);
            this.back.TabIndex = 5;
            this.back.Text = "Назад";
            this.back.Click += new System.EventHandler(this.Back_Click);
            this.back.MouseLeave += new System.EventHandler(this.Back_MouseLeave);
            this.back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Back_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("asinastra", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(435, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Error:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1024, 686);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Upgrade);
            this.Controls.Add(this.Basic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dota2DataSet)).EndInit();
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPic)).EndInit();
            this.Basic.ResumeLayout(false);
            this.Basic.PerformLayout();
            this.Upgrade.ResumeLayout(false);
            this.Upgrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Dota2DataSet dota2DataSet;
        private System.Windows.Forms.BindingSource commonitemsBindingSource;
        private Dota2DataSetTableAdapters.common_itemsTableAdapter common_itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иконкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn силаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ловкостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn интелектDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn атакаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скоростьАтакиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скоростьПередвиженияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn восстановлениеМаныDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn восстановлениеЗдоровьяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сопротивлениеМагииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяПерезарядкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn манакостDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn usableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn spellDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Panel info;
        private System.Windows.Forms.PictureBox infoPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Basic;
        private System.Windows.Forms.Label Basiclab;
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.Panel Upgrade;
        private System.Windows.Forms.Label Upgradelab;
        private System.Windows.Forms.Label Infolab;
        private System.Windows.Forms.Label Uselab;
        private System.Windows.Forms.Label property;
        private System.Windows.Forms.Label Passivelab;
        private System.Windows.Forms.Label Activelab;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label label3;
    }
}

