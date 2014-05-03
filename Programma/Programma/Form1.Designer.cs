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
            this.btnSale = new System.Windows.Forms.Button();
            this.btnMerch = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnProv = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnBranch = new System.Windows.Forms.Button();
            this.gbImage = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.btnReportManager = new System.Windows.Forms.Button();
            this.btnReportBranch = new System.Windows.Forms.Button();
            this.btnReportProv = new System.Windows.Forms.Button();
            this.btnReportMerch = new System.Windows.Forms.Button();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.btnZakMerch = new System.Windows.Forms.Button();
            this.btnPereraspMerch = new System.Windows.Forms.Button();
            this.dgvStorage = new System.Windows.Forms.DataGridView();
            this.cbChooseBranch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.gbLists.Controls.Add(this.btnSale);
            this.gbLists.Controls.Add(this.btnMerch);
            this.gbLists.Controls.Add(this.btnCategory);
            this.gbLists.Controls.Add(this.btnProv);
            this.gbLists.Controls.Add(this.btnManager);
            this.gbLists.Controls.Add(this.btnBranch);
            this.gbLists.Location = new System.Drawing.Point(12, 264);
            this.gbLists.Name = "gbLists";
            this.gbLists.Size = new System.Drawing.Size(251, 254);
            this.gbLists.TabIndex = 0;
            this.gbLists.TabStop = false;
            // 
            // btnSale
            // 
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSale.Location = new System.Drawing.Point(8, 206);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(235, 30);
            this.btnSale.TabIndex = 5;
            this.btnSale.Text = "Список продаж";
            this.btnSale.UseVisualStyleBackColor = true;
            // 
            // btnMerch
            // 
            this.btnMerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMerch.Location = new System.Drawing.Point(8, 168);
            this.btnMerch.Name = "btnMerch";
            this.btnMerch.Size = new System.Drawing.Size(235, 30);
            this.btnMerch.TabIndex = 4;
            this.btnMerch.Text = "Список товара";
            this.btnMerch.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCategory.Location = new System.Drawing.Point(8, 131);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(235, 30);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Просмотр категорий";
            this.btnCategory.UseVisualStyleBackColor = true;
            // 
            // btnProv
            // 
            this.btnProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProv.Location = new System.Drawing.Point(8, 93);
            this.btnProv.Name = "btnProv";
            this.btnProv.Size = new System.Drawing.Size(235, 30);
            this.btnProv.TabIndex = 2;
            this.btnProv.Text = "Просмотр поставщиков";
            this.btnProv.UseVisualStyleBackColor = true;
            this.btnProv.Click += new System.EventHandler(this.btnProv_Click);
            // 
            // btnManager
            // 
            this.btnManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnManager.Location = new System.Drawing.Point(7, 55);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(235, 30);
            this.btnManager.TabIndex = 1;
            this.btnManager.Text = "Просмотр менеджеров";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
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
            // Avatar
            // 
            this.Avatar.Location = new System.Drawing.Point(6, 10);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(236, 199);
            this.Avatar.TabIndex = 0;
            this.Avatar.TabStop = false;
            // 
            // gbReport
            // 
            this.gbReport.Controls.Add(this.btnReportManager);
            this.gbReport.Controls.Add(this.btnReportBranch);
            this.gbReport.Controls.Add(this.btnReportProv);
            this.gbReport.Controls.Add(this.btnReportMerch);
            this.gbReport.Location = new System.Drawing.Point(12, 524);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(251, 180);
            this.gbReport.TabIndex = 2;
            this.gbReport.TabStop = false;
            // 
            // btnReportManager
            // 
            this.btnReportManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReportManager.Location = new System.Drawing.Point(8, 131);
            this.btnReportManager.Name = "btnReportManager";
            this.btnReportManager.Size = new System.Drawing.Size(235, 30);
            this.btnReportManager.TabIndex = 3;
            this.btnReportManager.Text = "Результативность менеджеров";
            this.btnReportManager.UseVisualStyleBackColor = true;
            // 
            // btnReportBranch
            // 
            this.btnReportBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReportBranch.Location = new System.Drawing.Point(8, 93);
            this.btnReportBranch.Name = "btnReportBranch";
            this.btnReportBranch.Size = new System.Drawing.Size(235, 30);
            this.btnReportBranch.TabIndex = 2;
            this.btnReportBranch.Text = "Продаваемость по филиалам";
            this.btnReportBranch.UseVisualStyleBackColor = true;
            // 
            // btnReportProv
            // 
            this.btnReportProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReportProv.Location = new System.Drawing.Point(7, 55);
            this.btnReportProv.Name = "btnReportProv";
            this.btnReportProv.Size = new System.Drawing.Size(235, 30);
            this.btnReportProv.TabIndex = 1;
            this.btnReportProv.Text = "Популярность постащиков";
            this.btnReportProv.UseVisualStyleBackColor = true;
            // 
            // btnReportMerch
            // 
            this.btnReportMerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReportMerch.Location = new System.Drawing.Point(7, 19);
            this.btnReportMerch.Name = "btnReportMerch";
            this.btnReportMerch.Size = new System.Drawing.Size(235, 30);
            this.btnReportMerch.TabIndex = 0;
            this.btnReportMerch.Text = "Продаваемость товара ";
            this.btnReportMerch.UseVisualStyleBackColor = true;
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
            // dgvStorage
            // 
            this.dgvStorage.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorage.Location = new System.Drawing.Point(10, 51);
            this.dgvStorage.Name = "dgvStorage";
            this.dgvStorage.Size = new System.Drawing.Size(687, 593);
            this.dgvStorage.TabIndex = 2;
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
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnMerch;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnProv;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.GroupBox gbReport;
        private System.Windows.Forms.Button btnReportManager;
        private System.Windows.Forms.Button btnReportBranch;
        private System.Windows.Forms.Button btnReportProv;
        private System.Windows.Forms.Button btnReportMerch;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Button btnZakMerch;
        private System.Windows.Forms.Button btnPereraspMerch;
        private System.Windows.Forms.DataGridView dgvStorage;
        private System.Windows.Forms.ComboBox cbChooseBranch;
        private System.Windows.Forms.Label label2;
    }
}

