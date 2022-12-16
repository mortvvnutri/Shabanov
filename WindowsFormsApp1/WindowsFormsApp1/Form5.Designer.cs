namespace WindowsFormsApp1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label код_ингридиентаLabel;
            System.Windows.Forms.Label ингридиентLabel;
            System.Windows.Forms.Label единица_измеренияLabel;
            System.Windows.Forms.Label весLabel;
            System.Windows.Forms.Label цена_за_единицуLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.база_данных11DataSet = new WindowsFormsApp1.База_данных11DataSet();
            this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.складTableAdapter = new WindowsFormsApp1.База_данных11DataSetTableAdapters.СкладTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.База_данных11DataSetTableAdapters.TableAdapterManager();
            this.складBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.складBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_ингридиентаTextBox = new System.Windows.Forms.TextBox();
            this.ингридиентTextBox = new System.Windows.Forms.TextBox();
            this.единица_измеренияTextBox = new System.Windows.Forms.TextBox();
            this.весTextBox = new System.Windows.Forms.TextBox();
            this.цена_за_единицуTextBox = new System.Windows.Forms.TextBox();
            код_ингридиентаLabel = new System.Windows.Forms.Label();
            ингридиентLabel = new System.Windows.Forms.Label();
            единица_измеренияLabel = new System.Windows.Forms.Label();
            весLabel = new System.Windows.Forms.Label();
            цена_за_единицуLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingNavigator)).BeginInit();
            this.складBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(173, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Таблица \"Склад\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // база_данных11DataSet
            // 
            this.база_данных11DataSet.DataSetName = "База_данных11DataSet";
            this.база_данных11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // складBindingSource
            // 
            this.складBindingSource.DataMember = "Склад";
            this.складBindingSource.DataSource = this.база_данных11DataSet;
            // 
            // складTableAdapter
            // 
            this.складTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.База_данных11DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Единицы_измеренияTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.МенюTableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = this.складTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // складBindingNavigator
            // 
            this.складBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.складBindingNavigator.BindingSource = this.складBindingSource;
            this.складBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.складBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.складBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.складBindingNavigatorSaveItem});
            this.складBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.складBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.складBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.складBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.складBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.складBindingNavigator.Name = "складBindingNavigator";
            this.складBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.складBindingNavigator.Size = new System.Drawing.Size(565, 25);
            this.складBindingNavigator.TabIndex = 4;
            this.складBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // складBindingNavigatorSaveItem
            // 
            this.складBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.складBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("складBindingNavigatorSaveItem.Image")));
            this.складBindingNavigatorSaveItem.Name = "складBindingNavigatorSaveItem";
            this.складBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.складBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.складBindingNavigatorSaveItem.Click += new System.EventHandler(this.складBindingNavigatorSaveItem_Click);
            // 
            // код_ингридиентаLabel
            // 
            код_ингридиентаLabel.AutoSize = true;
            код_ингридиентаLabel.Location = new System.Drawing.Point(148, 166);
            код_ингридиентаLabel.Name = "код_ингридиентаLabel";
            код_ингридиентаLabel.Size = new System.Drawing.Size(96, 13);
            код_ингридиентаLabel.TabIndex = 4;
            код_ингридиентаLabel.Text = "Код ингридиента:";
            // 
            // код_ингридиентаTextBox
            // 
            this.код_ингридиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.складBindingSource, "Код ингридиента", true));
            this.код_ингридиентаTextBox.Location = new System.Drawing.Point(250, 163);
            this.код_ингридиентаTextBox.Name = "код_ингридиентаTextBox";
            this.код_ингридиентаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_ингридиентаTextBox.TabIndex = 5;
            // 
            // ингридиентLabel
            // 
            ингридиентLabel.AutoSize = true;
            ингридиентLabel.Location = new System.Drawing.Point(174, 207);
            ингридиентLabel.Name = "ингридиентLabel";
            ингридиентLabel.Size = new System.Drawing.Size(70, 13);
            ингридиентLabel.TabIndex = 5;
            ингридиентLabel.Text = "Ингридиент:";
            // 
            // ингридиентTextBox
            // 
            this.ингридиентTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.складBindingSource, "Ингридиент", true));
            this.ингридиентTextBox.Location = new System.Drawing.Point(250, 204);
            this.ингридиентTextBox.Name = "ингридиентTextBox";
            this.ингридиентTextBox.Size = new System.Drawing.Size(100, 20);
            this.ингридиентTextBox.TabIndex = 6;
            // 
            // единица_измеренияLabel
            // 
            единица_измеренияLabel.AutoSize = true;
            единица_измеренияLabel.Location = new System.Drawing.Point(132, 249);
            единица_измеренияLabel.Name = "единица_измеренияLabel";
            единица_измеренияLabel.Size = new System.Drawing.Size(112, 13);
            единица_измеренияLabel.TabIndex = 6;
            единица_измеренияLabel.Text = "Единица измерения:";
            // 
            // единица_измеренияTextBox
            // 
            this.единица_измеренияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.складBindingSource, "Единица измерения", true));
            this.единица_измеренияTextBox.Location = new System.Drawing.Point(250, 246);
            this.единица_измеренияTextBox.Name = "единица_измеренияTextBox";
            this.единица_измеренияTextBox.Size = new System.Drawing.Size(100, 20);
            this.единица_измеренияTextBox.TabIndex = 7;
            // 
            // весLabel
            // 
            весLabel.AutoSize = true;
            весLabel.Location = new System.Drawing.Point(215, 296);
            весLabel.Name = "весLabel";
            весLabel.Size = new System.Drawing.Size(29, 13);
            весLabel.TabIndex = 8;
            весLabel.Text = "Вес:";
            // 
            // весTextBox
            // 
            this.весTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.складBindingSource, "Вес", true));
            this.весTextBox.Location = new System.Drawing.Point(250, 293);
            this.весTextBox.Name = "весTextBox";
            this.весTextBox.Size = new System.Drawing.Size(100, 20);
            this.весTextBox.TabIndex = 9;
            // 
            // цена_за_единицуLabel
            // 
            цена_за_единицуLabel.AutoSize = true;
            цена_за_единицуLabel.Location = new System.Drawing.Point(149, 344);
            цена_за_единицуLabel.Name = "цена_за_единицуLabel";
            цена_за_единицуLabel.Size = new System.Drawing.Size(95, 13);
            цена_за_единицуLabel.TabIndex = 10;
            цена_за_единицуLabel.Text = "Цена за единицу:";
            // 
            // цена_за_единицуTextBox
            // 
            this.цена_за_единицуTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.складBindingSource, "Цена за единицу", true));
            this.цена_за_единицуTextBox.Location = new System.Drawing.Point(250, 341);
            this.цена_за_единицуTextBox.Name = "цена_за_единицуTextBox";
            this.цена_за_единицуTextBox.Size = new System.Drawing.Size(100, 20);
            this.цена_за_единицуTextBox.TabIndex = 11;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 447);
            this.Controls.Add(цена_за_единицуLabel);
            this.Controls.Add(this.цена_за_единицуTextBox);
            this.Controls.Add(весLabel);
            this.Controls.Add(this.весTextBox);
            this.Controls.Add(единица_измеренияLabel);
            this.Controls.Add(this.единица_измеренияTextBox);
            this.Controls.Add(ингридиентLabel);
            this.Controls.Add(this.ингридиентTextBox);
            this.Controls.Add(код_ингридиентаLabel);
            this.Controls.Add(this.код_ингридиентаTextBox);
            this.Controls.Add(this.складBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.база_данных11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingNavigator)).EndInit();
            this.складBindingNavigator.ResumeLayout(false);
            this.складBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private База_данных11DataSet база_данных11DataSet;
        private System.Windows.Forms.BindingSource складBindingSource;
        private База_данных11DataSetTableAdapters.СкладTableAdapter складTableAdapter;
        private База_данных11DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator складBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton складBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_ингридиентаTextBox;
        private System.Windows.Forms.TextBox ингридиентTextBox;
        private System.Windows.Forms.TextBox единица_измеренияTextBox;
        private System.Windows.Forms.TextBox весTextBox;
        private System.Windows.Forms.TextBox цена_за_единицуTextBox;
    }
}