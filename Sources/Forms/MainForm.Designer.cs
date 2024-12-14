namespace FurnitureCalc
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.input = new System.Windows.Forms.TabPage();
            this.thicknessInput = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputFasteners = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dropdownTypes = new System.Windows.Forms.ComboBox();
            this.lengthInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.heightInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.TabPage();
            this.paintFurnuteLabel = new System.Windows.Forms.Label();
            this.woodCountFurnuteLabel = new System.Windows.Forms.Label();
            this.thicknessFurnuteLabel = new System.Windows.Forms.Label();
            this.typeFurnuteLabel = new System.Windows.Forms.Label();
            this.fastenersFurnuteLabel = new System.Windows.Forms.Label();
            this.lengthFurnuteLabel = new System.Windows.Forms.Label();
            this.heightFurnuteLabel = new System.Windows.Forms.Label();
            this.widthFurnuteLabel = new System.Windows.Forms.Label();
            this.nameFurnuteLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.TabPage();
            this.historyGrid = new System.Windows.Forms.DataGridView();
            this.NameFurniture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaintCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WoodCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загруззкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wardrobeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputFasteners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            this.calc.SuspendLayout();
            this.history.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyGrid)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wardrobeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.input);
            this.tabControl.Controls.Add(this.calc);
            this.tabControl.Controls.Add(this.history);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 425);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 1;
            // 
            // input
            // 
            this.input.Controls.Add(this.thicknessInput);
            this.input.Controls.Add(this.label6);
            this.input.Controls.Add(this.label5);
            this.input.Controls.Add(this.inputFasteners);
            this.input.Controls.Add(this.label4);
            this.input.Controls.Add(this.dropdownTypes);
            this.input.Controls.Add(this.lengthInput);
            this.input.Controls.Add(this.label3);
            this.input.Controls.Add(this.heightInput);
            this.input.Controls.Add(this.label2);
            this.input.Controls.Add(this.widthInput);
            this.input.Controls.Add(this.label1);
            this.input.Controls.Add(this.nameInput);
            this.input.Controls.Add(this.labelName);
            this.input.Location = new System.Drawing.Point(4, 22);
            this.input.Name = "input";
            this.input.Padding = new System.Windows.Forms.Padding(3);
            this.input.Size = new System.Drawing.Size(792, 399);
            this.input.TabIndex = 0;
            this.input.Text = "Ввод данных";
            this.input.UseVisualStyleBackColor = true;
            // 
            // thicknessInput
            // 
            this.thicknessInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thicknessInput.Location = new System.Drawing.Point(93, 197);
            this.thicknessInput.Name = "thicknessInput";
            this.thicknessInput.Size = new System.Drawing.Size(691, 20);
            this.thicknessInput.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Толщина (см)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Тип мебели";
            // 
            // inputFasteners
            // 
            this.inputFasteners.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFasteners.Location = new System.Drawing.Point(93, 161);
            this.inputFasteners.Name = "inputFasteners";
            this.inputFasteners.Size = new System.Drawing.Size(691, 20);
            this.inputFasteners.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Шурупы";
            // 
            // dropdownTypes
            // 
            this.dropdownTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dropdownTypes.FormattingEnabled = true;
            this.dropdownTypes.Items.AddRange(new object[] {
            "Стол",
            "Кровать",
            "Шкаф"});
            this.dropdownTypes.Location = new System.Drawing.Point(95, 231);
            this.dropdownTypes.Name = "dropdownTypes";
            this.dropdownTypes.Size = new System.Drawing.Size(691, 21);
            this.dropdownTypes.TabIndex = 8;
            // 
            // lengthInput
            // 
            this.lengthInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lengthInput.Location = new System.Drawing.Point(93, 128);
            this.lengthInput.Name = "lengthInput";
            this.lengthInput.Size = new System.Drawing.Size(691, 20);
            this.lengthInput.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Длина (см)";
            // 
            // heightInput
            // 
            this.heightInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heightInput.Location = new System.Drawing.Point(93, 92);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(691, 20);
            this.heightInput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Высота (см)";
            // 
            // widthInput
            // 
            this.widthInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.widthInput.Location = new System.Drawing.Point(93, 56);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(691, 20);
            this.widthInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ширина (см)";
            // 
            // nameInput
            // 
            this.nameInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameInput.Location = new System.Drawing.Point(93, 18);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(691, 20);
            this.nameInput.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(8, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название";
            // 
            // calc
            // 
            this.calc.Controls.Add(this.paintFurnuteLabel);
            this.calc.Controls.Add(this.woodCountFurnuteLabel);
            this.calc.Controls.Add(this.thicknessFurnuteLabel);
            this.calc.Controls.Add(this.typeFurnuteLabel);
            this.calc.Controls.Add(this.fastenersFurnuteLabel);
            this.calc.Controls.Add(this.lengthFurnuteLabel);
            this.calc.Controls.Add(this.heightFurnuteLabel);
            this.calc.Controls.Add(this.widthFurnuteLabel);
            this.calc.Controls.Add(this.nameFurnuteLabel);
            this.calc.Controls.Add(this.calcButton);
            this.calc.Location = new System.Drawing.Point(4, 22);
            this.calc.Name = "calc";
            this.calc.Padding = new System.Windows.Forms.Padding(3);
            this.calc.Size = new System.Drawing.Size(792, 399);
            this.calc.TabIndex = 1;
            this.calc.Text = "Расчет";
            this.calc.UseVisualStyleBackColor = true;
            // 
            // paintFurnuteLabel
            // 
            this.paintFurnuteLabel.AutoSize = true;
            this.paintFurnuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paintFurnuteLabel.Location = new System.Drawing.Point(8, 295);
            this.paintFurnuteLabel.Name = "paintFurnuteLabel";
            this.paintFurnuteLabel.Size = new System.Drawing.Size(187, 24);
            this.paintFurnuteLabel.TabIndex = 20;
            this.paintFurnuteLabel.Text = "Количество краски:";
            // 
            // woodCountFurnuteLabel
            // 
            this.woodCountFurnuteLabel.AutoSize = true;
            this.woodCountFurnuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.woodCountFurnuteLabel.Location = new System.Drawing.Point(8, 261);
            this.woodCountFurnuteLabel.Name = "woodCountFurnuteLabel";
            this.woodCountFurnuteLabel.Size = new System.Drawing.Size(182, 24);
            this.woodCountFurnuteLabel.TabIndex = 19;
            this.woodCountFurnuteLabel.Text = "Объем древесины:";
            // 
            // thicknessFurnuteLabel
            // 
            this.thicknessFurnuteLabel.AutoSize = true;
            this.thicknessFurnuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thicknessFurnuteLabel.Location = new System.Drawing.Point(6, 228);
            this.thicknessFurnuteLabel.Name = "thicknessFurnuteLabel";
            this.thicknessFurnuteLabel.Size = new System.Drawing.Size(128, 24);
            this.thicknessFurnuteLabel.TabIndex = 18;
            this.thicknessFurnuteLabel.Text = "Толщина (см)";
            // 
            // typeFurnuteLabel
            // 
            this.typeFurnuteLabel.AutoSize = true;
            this.typeFurnuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeFurnuteLabel.Location = new System.Drawing.Point(6, 194);
            this.typeFurnuteLabel.Name = "typeFurnuteLabel";
            this.typeFurnuteLabel.Size = new System.Drawing.Size(116, 24);
            this.typeFurnuteLabel.TabIndex = 17;
            this.typeFurnuteLabel.Text = "Тип мебели";
            // 
            // fastenersFurnuteLabel
            // 
            this.fastenersFurnuteLabel.AutoSize = true;
            this.fastenersFurnuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fastenersFurnuteLabel.Location = new System.Drawing.Point(8, 158);
            this.fastenersFurnuteLabel.Name = "fastenersFurnuteLabel";
            this.fastenersFurnuteLabel.Size = new System.Drawing.Size(197, 24);
            this.fastenersFurnuteLabel.TabIndex = 16;
            this.fastenersFurnuteLabel.Text = "Шурупы (в единицах)";
            // 
            // lengthFurnuteLabel
            // 
            this.lengthFurnuteLabel.AutoSize = true;
            this.lengthFurnuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengthFurnuteLabel.Location = new System.Drawing.Point(8, 121);
            this.lengthFurnuteLabel.Name = "lengthFurnuteLabel";
            this.lengthFurnuteLabel.Size = new System.Drawing.Size(106, 24);
            this.lengthFurnuteLabel.TabIndex = 15;
            this.lengthFurnuteLabel.Text = "Длина (см)";
            // 
            // heightFurnuteLabel
            // 
            this.heightFurnuteLabel.AutoSize = true;
            this.heightFurnuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightFurnuteLabel.Location = new System.Drawing.Point(8, 85);
            this.heightFurnuteLabel.Name = "heightFurnuteLabel";
            this.heightFurnuteLabel.Size = new System.Drawing.Size(116, 24);
            this.heightFurnuteLabel.TabIndex = 14;
            this.heightFurnuteLabel.Text = "Высота (см)";
            // 
            // widthFurnuteLabel
            // 
            this.widthFurnuteLabel.AutoSize = true;
            this.widthFurnuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthFurnuteLabel.Location = new System.Drawing.Point(8, 49);
            this.widthFurnuteLabel.Name = "widthFurnuteLabel";
            this.widthFurnuteLabel.Size = new System.Drawing.Size(118, 24);
            this.widthFurnuteLabel.TabIndex = 13;
            this.widthFurnuteLabel.Text = "Ширина (см)";
            // 
            // nameFurnuteLabel
            // 
            this.nameFurnuteLabel.AutoSize = true;
            this.nameFurnuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameFurnuteLabel.Location = new System.Drawing.Point(8, 12);
            this.nameFurnuteLabel.Name = "nameFurnuteLabel";
            this.nameFurnuteLabel.Size = new System.Drawing.Size(97, 24);
            this.nameFurnuteLabel.TabIndex = 12;
            this.nameFurnuteLabel.Text = "Название";
            // 
            // calcButton
            // 
            this.calcButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcButton.Location = new System.Drawing.Point(-4, 336);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(800, 67);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "Расчитать";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // history
            // 
            this.history.Controls.Add(this.historyGrid);
            this.history.Location = new System.Drawing.Point(4, 22);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(792, 399);
            this.history.TabIndex = 2;
            this.history.Text = "Просмотр истории";
            this.history.UseVisualStyleBackColor = true;
            // 
            // historyGrid
            // 
            this.historyGrid.AllowUserToAddRows = false;
            this.historyGrid.AllowUserToDeleteRows = false;
            this.historyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameFurniture,
            this.Width,
            this.Height,
            this.Length,
            this.PaintCount,
            this.WoodCount});
            this.historyGrid.Location = new System.Drawing.Point(0, 0);
            this.historyGrid.Name = "historyGrid";
            this.historyGrid.ReadOnly = true;
            this.historyGrid.Size = new System.Drawing.Size(789, 403);
            this.historyGrid.TabIndex = 0;
            // 
            // NameFurniture
            // 
            this.NameFurniture.HeaderText = "Название";
            this.NameFurniture.Name = "NameFurniture";
            this.NameFurniture.ReadOnly = true;
            // 
            // Width
            // 
            this.Width.HeaderText = "Ширина";
            this.Width.Name = "Width";
            this.Width.ReadOnly = true;
            // 
            // Height
            // 
            this.Height.HeaderText = "Высота";
            this.Height.Name = "Height";
            this.Height.ReadOnly = true;
            // 
            // Length
            // 
            this.Length.HeaderText = "Длина";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            // 
            // PaintCount
            // 
            this.PaintCount.HeaderText = "Количество краски";
            this.PaintCount.Name = "PaintCount";
            this.PaintCount.ReadOnly = true;
            // 
            // WoodCount
            // 
            this.WoodCount.HeaderText = "Объем древесины";
            this.WoodCount.Name = "WoodCount";
            this.WoodCount.ReadOnly = true;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сохранениеToolStripMenuItem,
            this.загруззкаToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // сохранениеToolStripMenuItem
            // 
            this.сохранениеToolStripMenuItem.Name = "сохранениеToolStripMenuItem";
            this.сохранениеToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сохранениеToolStripMenuItem.Text = "Сохранение";
            this.сохранениеToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // загруззкаToolStripMenuItem
            // 
            this.загруззкаToolStripMenuItem.Name = "загруззкаToolStripMenuItem";
            this.загруззкаToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.загруззкаToolStripMenuItem.Text = "Загрузка";
            this.загруззкаToolStripMenuItem.Click += new System.EventHandler(this.LoadFileToolStripMenuItem_Click);
            // 
            // wardrobeBindingSource
            // 
            this.wardrobeBindingSource.DataSource = typeof(FurnitureCalc.Sources.Models.Wardrobe);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.input.ResumeLayout(false);
            this.input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputFasteners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            this.calc.ResumeLayout(false);
            this.calc.PerformLayout();
            this.history.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyGrid)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wardrobeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage input;
        private System.Windows.Forms.TabPage calc;
        private System.Windows.Forms.TabPage history;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загруззкаToolStripMenuItem;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.BindingSource wardrobeBindingSource;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.NumericUpDown heightInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown widthInput;
        private System.Windows.Forms.NumericUpDown lengthInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dropdownTypes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown inputFasteners;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label typeFurnuteLabel;
        private System.Windows.Forms.Label fastenersFurnuteLabel;
        private System.Windows.Forms.Label lengthFurnuteLabel;
        private System.Windows.Forms.Label heightFurnuteLabel;
        private System.Windows.Forms.Label widthFurnuteLabel;
        private System.Windows.Forms.Label nameFurnuteLabel;
        private System.Windows.Forms.NumericUpDown thicknessInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label thicknessFurnuteLabel;
        private System.Windows.Forms.Label paintFurnuteLabel;
        private System.Windows.Forms.Label woodCountFurnuteLabel;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView historyGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFurniture;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaintCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn WoodCount;
    }
}

