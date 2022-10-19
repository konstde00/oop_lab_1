using System.Windows.Forms;
using System.Drawing;

namespace Excel
{
    partial class MyExcel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new Panel();
            this.dataGridView = new DataGridView();
            this.splitContainer = new SplitContainer();
            this.calculateButton = new Button();
            this.textBox = new TextBox();
            this.delRowButton = new Button();
            this.addRowButton = new Button();
            this.delColButton = new Button();
            this.rowLabel = new Label();
            this.addColButton = new Button();
            this.label1 = new Label();
            this.saveButton = new Button();
            this.openButton = new Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.panel.Controls.Add(this.dataGridView);
            this.panel.Location = new Point(1, 47);
            this.panel.Name = "panel";
            this.panel.Size = new Size(1136, 595);
            this.panel.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = DockStyle.Fill;
            this.dataGridView.Location = new Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new Size(1136, 595);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // splitContainer
            // 
            this.splitContainer.Cursor = Cursors.VSplit;
            this.splitContainer.FixedPanel = FixedPanel.Panel1;
            this.splitContainer.Location = new Point(1, 2);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.calculateButton);
            this.splitContainer.Panel1.Controls.Add(this.textBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.delRowButton);
            this.splitContainer.Panel2.Controls.Add(this.addRowButton);
            this.splitContainer.Panel2.Controls.Add(this.delColButton);
            this.splitContainer.Panel2.Controls.Add(this.rowLabel);
            this.splitContainer.Panel2.Controls.Add(this.addColButton);
            this.splitContainer.Panel2.Controls.Add(this.label1);
            this.splitContainer.Panel2.Controls.Add(this.saveButton);
            this.splitContainer.Panel2.Controls.Add(this.openButton);
            this.splitContainer.Size = new Size(1136, 39);
            this.splitContainer.SplitterDistance = 488;
            this.splitContainer.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new Point(359, 4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new Size(126, 34);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new Point(3, 5);
            this.textBox.Name = "textBox";
            this.textBox.Size = new Size(350, 31);
            this.textBox.TabIndex = 0;
            // 
            // delRowButton
            // 
            this.delRowButton.Location = new Point(309, 5);
            this.delRowButton.Name = "delRowButton";
            this.delRowButton.Size = new Size(30, 32);
            this.delRowButton.TabIndex = 7;
            this.delRowButton.Text = "-";
            this.delRowButton.TextAlign = ContentAlignment.TopCenter;
            this.delRowButton.UseVisualStyleBackColor = true;
            this.delRowButton.Click += new System.EventHandler(this.delRowButton_Click);
            // 
            // addRowButton
            // 
            this.addRowButton.Location = new Point(273, 5);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new Size(30, 32);
            this.addRowButton.TabIndex = 6;
            this.addRowButton.Text = "+";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // delColButton
            // 
            this.delColButton.Location = new Point(140, 4);
            this.delColButton.Name = "delColButton";
            this.delColButton.Size = new Size(30, 32);
            this.delColButton.TabIndex = 5;
            this.delColButton.Text = "-";
            this.delColButton.TextAlign = ContentAlignment.TopCenter;
            this.delColButton.UseVisualStyleBackColor = true;
            this.delColButton.Click += new System.EventHandler(this.delColButton_Click);
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Location = new Point(213, 9);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new Size(54, 25);
            this.rowLabel.TabIndex = 4;
            this.rowLabel.Text = "Rows";
            // 
            // addColButton
            // 
            this.addColButton.Location = new Point(104, 4);
            this.addColButton.Name = "addColButton";
            this.addColButton.Size = new Size(30, 32);
            this.addColButton.TabIndex = 3;
            this.addColButton.Text = "+";
            this.addColButton.UseVisualStyleBackColor = true;
            this.addColButton.Click += new System.EventHandler(this.addColButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new Size(82, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Columns";
            // 
            // saveButton
            // 
            this.saveButton.Location = new Point(545, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new Size(96, 34);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new Point(431, 3);
            this.openButton.Name = "openButton";
            this.openButton.Size = new Size(97, 34);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // MyExcel
            // 
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1136, 642);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.splitContainer);
            this.Name = "MyExcel";
            this.Text = "MyExcel";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel;
        private DataGridView dataGridView;
        private SplitContainer splitContainer;
        private Button calculateButton;
        private TextBox textBox;
        private Label label1;
        private Button saveButton;
        private Button openButton;
        private Button addColButton;
        private Button delRowButton;
        private Button addRowButton;
        private Button delColButton;
        private Label rowLabel;
    }
}

