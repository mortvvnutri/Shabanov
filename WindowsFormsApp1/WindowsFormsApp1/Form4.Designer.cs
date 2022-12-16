namespace WindowsFormsApp1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label код_блюдаLabel;
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label единица_измеренияLabel;
            System.Windows.Forms.Label весLabel;
            System.Windows.Forms.Label ингридиент1Label;
            this.label1 = new System.Windows.Forms.Label();
            this.база_данных11DataSet = new WindowsFormsApp1.База_данных11DataSet();
            this.менюBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.менюTableAdapter = new WindowsFormsApp1.База_данных11DataSetTableAdapters.МенюTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.База_данных11DataSetTableAdapters.TableAdapterManager();
            this.менюBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.менюBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_блюдаTextBox = new System.Windows.Forms.TextBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.единица_измеренияTextBox = new System.Windows.Forms.TextBox();
            this.весTextBox = new System.Windows.Forms.TextBox();
            this.ингридиент1TextBox = new System.Windows.Forms.TextBox();
            код_блюдаLabel = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            единица_измеренияLabel = new System.Windows.Forms.Label();
            весLabel = new System.Windows.Forms.Label();
            ингридиент1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.менюBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.менюBindingNavigator)).BeginInit();
            this.менюBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(166, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Таблица \"Меню\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // база_данных11DataSet
            // 
            this.база_данных11DataSet.DataSetName = "База_данных11DataSet";
            this.база_данных11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // менюBindingSource
            // 
            this.менюBindingSource.DataMember = "Меню";
            this.менюBindingSource.DataSource = this.база_данных11DataSet;
            // 
            // менюTableAdapter
            // 
            this.менюTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.База_данных11DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Единицы_измеренияTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.МенюTableAdapter = this.менюTableAdapter;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // менюBindingNavigator
            // 
            this.менюBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.менюBindingNavigator.BindingSource = this.менюBindingSource;
            this.менюBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.менюBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.менюBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.менюBindingNavigatorSaveItem});
            this.менюBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.менюBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.менюBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.менюBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.менюBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.менюBindingNavigator.Name = "менюBindingNavigator";
            this.менюBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.менюBindingNavigator.Size = new System.Drawing.Size(534, 25);
            this.менюBindingNavigator.TabIndex = 3;
            this.менюBindingNavigator.Text = "bindingNavigator1";
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
            // менюBindingNavigatorSaveItem
            // 
            this.менюBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.менюBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("менюBindingNavigatorSaveItem.Image")));
            this.менюBindingNavigatorSaveItem.Name = "менюBindingNavigatorSaveItem";
            this.менюBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.менюBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.менюBindingNavigatorSaveItem.Click += new System.EventHandler(this.менюBindingNavigatorSaveItem_Click);
            // 
            // код_блюдаLabel
            // 
            код_блюдаLabel.AutoSize = true;
            код_блюдаLabel.Location = new System.Drawing.Point(152, 130);
            код_блюдаLabel.Name = "код_блюдаLabel";
            код_блюдаLabel.Size = new System.Drawing.Size(64, 13);
            код_блюдаLabel.TabIndex = 3;
            код_блюдаLabel.Text = "Код блюда:";
            // 
            // код_блюдаTextBox
            // 
            this.код_блюдаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.менюBindingSource, "Код блюда", true));
            this.код_блюдаTextBox.Location = new System.Drawing.Point(222, 127);
            this.код_блюдаTextBox.Name = "код_блюдаTextBox";
            this.код_блюдаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_блюдаTextBox.TabIndex = 4;
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(156, 156);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(60, 13);
            названиеLabel.TabIndex = 4;
            названиеLabel.Text = "Название:";
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.менюBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(222, 153);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(100, 20);
            this.названиеTextBox.TabIndex = 5;
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(180, 182);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(36, 13);
            ценаLabel.TabIndex = 6;
            ценаLabel.Text = "Цена:";
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.менюBindingSource, "Цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(222, 179);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(100, 20);
            this.ценаTextBox.TabIndex = 7;
            this.ценаTextBox.TextChanged += new System.EventHandler(this.ценаTextBox_TextChanged);
            // 
            // единица_измеренияLabel
            // 
            единица_измеренияLabel.AutoSize = true;
            единица_измеренияLabel.Location = new System.Drawing.Point(104, 208);
            единица_измеренияLabel.Name = "единица_измеренияLabel";
            единица_измеренияLabel.Size = new System.Drawing.Size(112, 13);
            единица_измеренияLabel.TabIndex = 8;
            единица_измеренияLabel.Text = "Единица измерения:";
            единица_измеренияLabel.Click += new System.EventHandler(this.единица_измеренияLabel_Click);
            // 
            // единица_измеренияTextBox
            // 
            this.единица_измеренияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.менюBindingSource, "Единица измерения", true));
            this.единица_измеренияTextBox.Location = new System.Drawing.Point(222, 205);
            this.единица_измеренияTextBox.Name = "единица_измеренияTextBox";
            this.единица_измеренияTextBox.Size = new System.Drawing.Size(100, 20);
            this.единица_измеренияTextBox.TabIndex = 9;
            this.единица_измеренияTextBox.TextChanged += new System.EventHandler(this.единица_измеренияTextBox_TextChanged);
            // 
            // весLabel
            // 
            весLabel.AutoSize = true;
            весLabel.Location = new System.Drawing.Point(187, 234);
            весLabel.Name = "весLabel";
            весLabel.Size = new System.Drawing.Size(29, 13);
            весLabel.TabIndex = 10;
            весLabel.Text = "Вес:";
            // 
            // весTextBox
            // 
            this.весTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.менюBindingSource, "Вес", true));
            this.весTextBox.Location = new System.Drawing.Point(222, 231);
            this.весTextBox.Name = "весTextBox";
            this.весTextBox.Size = new System.Drawing.Size(100, 20);
            this.весTextBox.TabIndex = 11;
            // 
            // ингридиент1Label
            // 
            ингридиент1Label.AutoSize = true;
            ингридиент1Label.Location = new System.Drawing.Point(140, 260);
            ингридиент1Label.Name = "ингридиент1Label";
            ингридиент1Label.Size = new System.Drawing.Size(79, 13);
            ингридиент1Label.TabIndex = 12;
            ингридиент1Label.Text = "Ингридиент 1:";
            // 
            // ингридиент1TextBox
            // 
            this.ингридиент1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.менюBindingSource, "Ингридиент1", true));
            this.ингридиент1TextBox.Location = new System.Drawing.Point(222, 257);
            this.ингридиент1TextBox.Name = "ингридиент1TextBox";
            this.ингридиент1TextBox.Size = new System.Drawing.Size(100, 20);
            this.ингридиент1TextBox.TabIndex = 13;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(ингридиент1Label);
            this.Controls.Add(this.ингридиент1TextBox);
            this.Controls.Add(весLabel);
            this.Controls.Add(this.весTextBox);
            this.Controls.Add(единица_измеренияLabel);
            this.Controls.Add(this.единица_измеренияTextBox);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(код_блюдаLabel);
            this.Controls.Add(this.код_блюдаTextBox);
            this.Controls.Add(this.менюBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.база_данных11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.менюBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.менюBindingNavigator)).EndInit();
            this.менюBindingNavigator.ResumeLayout(false);
            this.менюBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private База_данных11DataSet база_данных11DataSet;
        private System.Windows.Forms.BindingSource менюBindingSource;
        private База_данных11DataSetTableAdapters.МенюTableAdapter менюTableAdapter;
        private База_данных11DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator менюBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton менюBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_блюдаTextBox;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.TextBox единица_измеренияTextBox;
        private System.Windows.Forms.TextBox весTextBox;
        private System.Windows.Forms.TextBox ингридиент1TextBox;
    }
}