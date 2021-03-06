﻿using System.ComponentModel;
using System.Windows.Forms;

namespace SuperEdit
{
    partial class SuperEdit
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
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.dgvJobSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvJobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxMove = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxTop = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxBottom = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxRegex = new System.Windows.Forms.ToolStripMenuItem();
            this.comboVal = new System.Windows.Forms.ComboBox();
            this.btnReview = new System.Windows.Forms.Button();
            this.comboTemp = new System.Windows.Forms.ComboBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.btnDirectExec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.ctxMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvJobs
            // 
            this.dgvJobs.AllowUserToAddRows = false;
            this.dgvJobs.AllowUserToDeleteRows = false;
            this.dgvJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJobs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvJobSelect,
            this.dgvJobName});
            this.dgvJobs.ContextMenuStrip = this.ctxMove;
            this.dgvJobs.EnableHeadersVisualStyles = false;
            this.dgvJobs.Location = new System.Drawing.Point(12, 46);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobs.ShowEditingIcon = false;
            this.dgvJobs.Size = new System.Drawing.Size(820, 389);
            this.dgvJobs.TabIndex = 0;
            this.dgvJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobs_CellContentClick);
            this.dgvJobs.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvJobs_ColumnHeaderMouseClick);
            // 
            // dgvJobSelect
            // 
            this.dgvJobSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvJobSelect.HeaderText = "Select";
            this.dgvJobSelect.Name = "dgvJobSelect";
            this.dgvJobSelect.Width = 50;
            // 
            // dgvJobName
            // 
            this.dgvJobName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvJobName.HeaderText = "Name";
            this.dgvJobName.Name = "dgvJobName";
            this.dgvJobName.ReadOnly = true;
            // 
            // ctxMove
            // 
            this.ctxMove.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxTop,
            this.ctxBottom,
            this.ctxRegex});
            this.ctxMove.Name = "ctxMove";
            this.ctxMove.Size = new System.Drawing.Size(242, 70);
            // 
            // ctxTop
            // 
            this.ctxTop.Name = "ctxTop";
            this.ctxTop.Size = new System.Drawing.Size(241, 22);
            this.ctxTop.Text = "Move Selected Rows To Top";
            this.ctxTop.Click += new System.EventHandler(this.ctxTop_Click);
            // 
            // ctxBottom
            // 
            this.ctxBottom.Name = "ctxBottom";
            this.ctxBottom.Size = new System.Drawing.Size(241, 22);
            this.ctxBottom.Text = "Move Selected Rows To Bottom";
            this.ctxBottom.Click += new System.EventHandler(this.ctxBottom_Click);
            // 
            // ctxRegex
            // 
            this.ctxRegex.Name = "ctxRegex";
            this.ctxRegex.Size = new System.Drawing.Size(241, 22);
            this.ctxRegex.Text = "Regex Filter";
            this.ctxRegex.Click += new System.EventHandler(this.ctxRegex_Click);
            // 
            // comboVal
            // 
            this.comboVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboVal.FormattingEnabled = true;
            this.comboVal.Location = new System.Drawing.Point(225, 451);
            this.comboVal.Name = "comboVal";
            this.comboVal.Size = new System.Drawing.Size(200, 21);
            this.comboVal.TabIndex = 1;
            // 
            // btnReview
            // 
            this.btnReview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReview.Location = new System.Drawing.Point(440, 451);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(93, 23);
            this.btnReview.TabIndex = 2;
            this.btnReview.Text = "Review";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // comboTemp
            // 
            this.comboTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTemp.FormattingEnabled = true;
            this.comboTemp.Location = new System.Drawing.Point(12, 451);
            this.comboTemp.Name = "comboTemp";
            this.comboTemp.Size = new System.Drawing.Size(200, 21);
            this.comboTemp.TabIndex = 3;
            this.comboTemp.SelectedIndexChanged += new System.EventHandler(this.comboTemp_SelectedIndexChanged);
            // 
            // comboType
            // 
            this.comboType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(575, 12);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(257, 21);
            this.comboType.TabIndex = 4;
            this.comboType.SelectedIndexChanged += new System.EventHandler(this.comboType_SelectedIndexChanged);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(12, 12);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(70, 17);
            this.chkAll.TabIndex = 5;
            this.chkAll.Text = "Select All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // btnDirectExec
            // 
            this.btnDirectExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDirectExec.Location = new System.Drawing.Point(539, 451);
            this.btnDirectExec.Name = "btnDirectExec";
            this.btnDirectExec.Size = new System.Drawing.Size(93, 23);
            this.btnDirectExec.TabIndex = 6;
            this.btnDirectExec.Text = "Execute";
            this.btnDirectExec.UseVisualStyleBackColor = true;
            this.btnDirectExec.Click += new System.EventHandler(this.btnDirectExec_Click);
            // 
            // SuperEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 486);
            this.Controls.Add(this.btnDirectExec);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.comboTemp);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.comboVal);
            this.Controls.Add(this.dgvJobs);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "SuperEdit";
            this.Text = "SuperEdit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SuperEdit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.ctxMove.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJobs;
        private ComboBox comboVal;
        private Button btnReview;
        private ComboBox comboTemp;
        private ComboBox comboType;
        private CheckBox chkAll;
        private Button btnDirectExec;
        private DataGridViewCheckBoxColumn dgvJobSelect;
        private DataGridViewTextBoxColumn dgvJobName;
        private ContextMenuStrip ctxMove;
        private ToolStripMenuItem ctxTop;
        private ToolStripMenuItem ctxBottom;
        private ToolStripMenuItem ctxRegex;
    }
}

