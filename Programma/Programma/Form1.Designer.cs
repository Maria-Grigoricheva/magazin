namespace Programma
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbLists = new System.Windows.Forms.GroupBox();
            this.btnBranch = new System.Windows.Forms.Button();
            this.gbImage = new System.Windows.Forms.GroupBox();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChooseBranch = new System.Windows.Forms.ComboBox();
            this.dgvStorage = new System.Windows.Forms.DataGridView();
            this.btnPereraspMerch = new System.Windows.Forms.Button();
            this.btnZakMerch = new System.Windows.Forms.Button();
            this.gbLists.SuspendLayout();
            this.gbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.gbReport.SuspendLayout();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLists
            // 
            this.gbLists.Controls.Add(this.button5);
            this.gbLists.Controls.Add(this.button4);
            this.gbLists.Controls.Add(this.button3);
            this.gbLists.Controls.Add(this.button2);
            this.gbLists.Controls.Add(this.button1);
            this.gbLists.Controls.Add(this.btnBranch);
            this.gbLists.Location = new System.Drawing.Point(12, 264);
            this.gbLists.Name = "gbLists";
            this.gbLists.Size = new System.Drawing.Size(251, 254);
            this.gbLists.TabIndex = 0;
            this.gbLists.TabStop = false;
            // 
            // btnBranch
            // 
            this.btnBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBranch.Location = new System.Drawing.Point(7, 18);
            this.btnBranch.Name = "btnBranch";
            this.btnBranch.Size = new System.Drawing.Size(235, 30);
            this.btnBranch.TabIndex = 0;
            this.btnBranch.Text = "Просмотр филиалов";
            this.btnBranch.UseVisualStyleBackColor = true;
            this.btnBranch.Click += new System.EventHandler(this.btnBranch_Click);
            // 
            // gbImage
            // 
            this.gbImage.Controls.Add(this.label1);
            this.gbImage.Controls.Add(this.Avatar);
            this.gbImage.Location = new System.Drawing.Point(12, 12);
            this.gbImage.Name = "gbImage";
            this.gbImage.Size = new System.Drawing.Size(251, 246);
            this.gbImage.TabIndex = 1;
            this.gbImage.TabStop = false;
            // 
            // Avatar
            // 
            this.Avatar.Location = new System.Drawing.Point(6, 10);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(236, 199);
            this.Avatar.TabIndex = 0;
            this.Avatar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сеть торговых точек \"Магазин\"";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(7, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Просмотр менеджеров";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(8, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Просмотр поставщиков";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(8, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Просмотр категорий";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(8, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "Список товара";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(8, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(235, 30);
            this.button5.TabIndex = 5;
            this.button5.Text = "Список продаж";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // gbReport
            // 
            this.gbReport.Controls.Add(this.button9);
            this.gbReport.Controls.Add(this.button8);
            this.gbReport.Controls.Add(this.button7);
            this.gbReport.Controls.Add(this.button6);
            this.gbReport.Location = new System.Drawing.Point(12, 524);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(251, 180);
            this.gbReport.TabIndex = 2;
            this.gbReport.TabStop = false;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(7, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(235, 30);
            this.button6.TabIndex = 0;
            this.button6.Text = "Продаваемость товара ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(7, 55);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(235, 30);
            this.button7.TabIndex = 1;
            this.button7.Text = "Популярность постащиков";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(8, 93);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(235, 30);
            this.button8.TabIndex = 2;
            this.button8.Text = "Продаваемость по филиалам";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(8, 131);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(235, 30);
            this.button9.TabIndex = 3;
            this.button9.Text = "Результативность менеджеров";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.btnZakMerch);
            this.gbMain.Controls.Add(this.btnPereraspMerch);
            this.gbMain.Controls.Add(this.dgvStorage);
            this.gbMain.Controls.Add(this.cbChooseBranch);
            this.gbMain.Controls.Add(this.label2);
            this.gbMain.Location = new System.Drawing.Point(269, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(703, 692);
            this.gbMain.TabIndex = 3;
            this.gbMain.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Наличие товара на складе";
            // 
            // cbChooseBranch
            // 
            this.cbChooseBranch.FormattingEnabled = true;
            this.cbChooseBranch.Location = new System.Drawing.Point(227, 18);
            this.cbChooseBranch.Name = "cbChooseBranch";
            this.cbChooseBranch.Size = new System.Drawing.Size(470, 21);
            this.cbChooseBranch.TabIndex = 1;
            this.cbChooseBranch.Text = "Выберите филиал";
            // 
            // dgvStorage
            // 
            this.dgvStorage.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorage.Location = new System.Drawing.Point(10, 51);
            this.dgvStorage.Name = "dgvStorage";
            this.dgvStorage.Size = new System.Drawing.Size(687, 593);
            this.dgvStorage.TabIndex = 2;
            // 
            // btnPereraspMerch
            // 
            this.btnPereraspMerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPereraspMerch.Location = new System.Drawing.Point(221, 656);
            this.btnPereraspMerch.Name = "btnPereraspMerch";
            this.btnPereraspMerch.Size = new System.Drawing.Size(235, 30);
            this.btnPereraspMerch.TabIndex = 3;
            this.btnPereraspMerch.Text = "Перераспределить товар";
            this.btnPereraspMerch.UseVisualStyleBackColor = true;
            // 
            // btnZakMerch
            // 
            this.btnZakMerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZakMerch.Location = new System.Drawing.Point(462, 656);
            this.btnZakMerch.Name = "btnZakMerch";
            this.btnZakMerch.Size = new System.Drawing.Size(235, 30);
            this.btnZakMerch.TabIndex = 4;
            this.btnZakMerch.Text = "Заказать товар";
            this.btnZakMerch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 717);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.gbReport);
            this.Controls.Add(this.gbImage);
            this.Controls.Add(this.gbLists);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сеть торговых точек \"Магазин\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbLists.ResumeLayout(false);
            this.gbImage.ResumeLayout(false);
            this.gbImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.gbReport.ResumeLayout(false);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLists;
        private System.Windows.Forms.Button btnBranch;
        private System.Windows.Forms.GroupBox gbImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbReport;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Button btnZakMerch;
        private System.Windows.Forms.Button btnPereraspMerch;
        private System.Windows.Forms.DataGridView dgvStorage;
        private System.Windows.Forms.ComboBox cbChooseBranch;
        private System.Windows.Forms.Label label2;
    }
}

