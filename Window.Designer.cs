
namespace DataBaseMySQL
{
	partial class Window
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
			this._dataGridView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this._txtDate = new System.Windows.Forms.TextBox();
			this._txtTask = new System.Windows.Forms.TextBox();
			this._btnAdd = new System.Windows.Forms.Button();
			this._btnDelete = new System.Windows.Forms.Button();
			this._cmbDone = new System.Windows.Forms.ComboBox();
			this._btnUpdate = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this._txtId = new System.Windows.Forms.TextBox();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// _dataGridView
			// 
			this._dataGridView.AllowUserToAddRows = false;
			this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
			this._dataGridView.Location = new System.Drawing.Point(12, 12);
			this._dataGridView.Name = "_dataGridView";
			this._dataGridView.ReadOnly = true;
			this._dataGridView.RowHeadersWidth = 51;
			this._dataGridView.RowTemplate.Height = 24;
			this._dataGridView.Size = new System.Drawing.Size(762, 247);
			this._dataGridView.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 289);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Дата:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 331);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Выполнение:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 374);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Задача:";
			// 
			// _txtDate
			// 
			this._txtDate.Location = new System.Drawing.Point(121, 289);
			this._txtDate.Name = "_txtDate";
			this._txtDate.Size = new System.Drawing.Size(188, 22);
			this._txtDate.TabIndex = 4;
			this._txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// _txtTask
			// 
			this._txtTask.Location = new System.Drawing.Point(121, 374);
			this._txtTask.Name = "_txtTask";
			this._txtTask.Size = new System.Drawing.Size(188, 22);
			this._txtTask.TabIndex = 6;
			this._txtTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// _btnAdd
			// 
			this._btnAdd.Location = new System.Drawing.Point(332, 287);
			this._btnAdd.Name = "_btnAdd";
			this._btnAdd.Size = new System.Drawing.Size(114, 24);
			this._btnAdd.TabIndex = 7;
			this._btnAdd.Text = "Добавить";
			this._btnAdd.UseVisualStyleBackColor = true;
			this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
			// 
			// _btnDelete
			// 
			this._btnDelete.Location = new System.Drawing.Point(332, 372);
			this._btnDelete.Name = "_btnDelete";
			this._btnDelete.Size = new System.Drawing.Size(114, 24);
			this._btnDelete.TabIndex = 9;
			this._btnDelete.Text = "Удалить";
			this._btnDelete.UseVisualStyleBackColor = true;
			// 
			// _cmbDone
			// 
			this._cmbDone.FormattingEnabled = true;
			this._cmbDone.Items.AddRange(new object[] {
            "Выполнено",
            "Не выполнено"});
			this._cmbDone.Location = new System.Drawing.Point(121, 328);
			this._cmbDone.Name = "_cmbDone";
			this._cmbDone.Size = new System.Drawing.Size(188, 24);
			this._cmbDone.TabIndex = 10;
			// 
			// _btnUpdate
			// 
			this._btnUpdate.Location = new System.Drawing.Point(332, 330);
			this._btnUpdate.Name = "_btnUpdate";
			this._btnUpdate.Size = new System.Drawing.Size(114, 24);
			this._btnUpdate.TabIndex = 8;
			this._btnUpdate.Text = "Обновить";
			this._btnUpdate.UseVisualStyleBackColor = true;
			this._btnUpdate.Click += new System.EventHandler(this.button2_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 425);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(25, 17);
			this.label4.TabIndex = 11;
			this.label4.Text = "ID:";
			// 
			// _txtId
			// 
			this._txtId.Location = new System.Drawing.Point(39, 423);
			this._txtId.Name = "_txtId";
			this._txtId.Size = new System.Drawing.Size(30, 22);
			this._txtId.TabIndex = 12;
			this._txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "ID";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 125;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Дата";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Выполнение";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Задача";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 125;
			// 
			// Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(817, 491);
			this.Controls.Add(this._txtId);
			this.Controls.Add(this.label4);
			this.Controls.Add(this._cmbDone);
			this.Controls.Add(this._btnDelete);
			this.Controls.Add(this._btnUpdate);
			this.Controls.Add(this._btnAdd);
			this.Controls.Add(this._txtTask);
			this.Controls.Add(this._txtDate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._dataGridView);
			this.Name = "Window";
			this.Text = "Window";
			((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView _dataGridView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox _txtDate;
		private System.Windows.Forms.TextBox _txtTask;
		private System.Windows.Forms.Button _btnAdd;
		private System.Windows.Forms.Button _btnDelete;
		private System.Windows.Forms.ComboBox _cmbDone;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.Button _btnUpdate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox _txtId;
	}
}

