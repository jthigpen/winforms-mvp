namespace ToDo.Ui
{
    partial class ToDoListView
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
            this.tasksListView = new BrightIdeasSoftware.ObjectListView();
            this.actionColumn = new BrightIdeasSoftware.OLVColumn();
            this.newTaskTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tasksListView)).BeginInit();
            this.SuspendLayout();
            // 
            // tasksListView
            // 
            this.tasksListView.AllColumns.Add(this.actionColumn);
            this.tasksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.actionColumn});
            this.tasksListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.tasksListView.FullRowSelect = true;
            this.tasksListView.HasCollapsibleGroups = false;
            this.tasksListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.tasksListView.Location = new System.Drawing.Point(12, 41);
            this.tasksListView.MultiSelect = false;
            this.tasksListView.Name = "tasksListView";
            this.tasksListView.ShowGroups = false;
            this.tasksListView.ShowHeaderInAllViews = false;
            this.tasksListView.Size = new System.Drawing.Size(461, 464);
            this.tasksListView.TabIndex = 0;
            this.tasksListView.UseCompatibleStateImageBehavior = false;
            this.tasksListView.View = System.Windows.Forms.View.Details;
            this.tasksListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tasksListView_MouseDoubleClick);
            // 
            // actionColumn
            // 
            this.actionColumn.AspectName = "Action";
            this.actionColumn.FillsFreeSpace = true;
            this.actionColumn.HeaderFont = null;
            this.actionColumn.Text = "Action";
            this.actionColumn.Width = 200;
            // 
            // newTaskTextBox
            // 
            this.newTaskTextBox.Location = new System.Drawing.Point(12, 12);
            this.newTaskTextBox.Name = "newTaskTextBox";
            this.newTaskTextBox.Size = new System.Drawing.Size(461, 20);
            this.newTaskTextBox.TabIndex = 2;
            this.newTaskTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newTaskTextBox_KeyPress);
            // 
            // ToDoListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 517);
            this.Controls.Add(this.newTaskTextBox);
            this.Controls.Add(this.tasksListView);
            this.Name = "ToDoListView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tasksListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView tasksListView;
        private System.Windows.Forms.TextBox newTaskTextBox;
        private BrightIdeasSoftware.OLVColumn actionColumn;
    }
}

