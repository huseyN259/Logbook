﻿namespace WinFormsApp7;

partial class FormMain
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.rbCheckTeacher1 = new System.Windows.Forms.RadioButton();
			this.rbCheckTeacher2 = new System.Windows.Forms.RadioButton();
			this.panel10 = new System.Windows.Forms.Panel();
			this.lblLessonName = new System.Windows.Forms.Label();
			this.txtMaterial = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblLesson = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblFullName = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblLastIn = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.rbtnAllTrue = new System.Windows.Forms.RadioButton();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.pnlStdentContent = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel10.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.tableLayoutPanel2);
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(8, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1714, 234);
			this.panel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.panel9, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel10, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1714, 139);
			this.tableLayoutPanel2.TabIndex = 8;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel9.Controls.Add(this.label1);
			this.panel9.Controls.Add(this.rbCheckTeacher1);
			this.panel9.Controls.Add(this.rbCheckTeacher2);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel9.Location = new System.Drawing.Point(3, 3);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(851, 133);
			this.panel9.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(17, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "FBAS_4214 (WinForms)";
			// 
			// rbCheckTeacher1
			// 
			this.rbCheckTeacher1.AutoSize = true;
			this.rbCheckTeacher1.Location = new System.Drawing.Point(17, 72);
			this.rbCheckTeacher1.Name = "rbCheckTeacher1";
			this.rbCheckTeacher1.Size = new System.Drawing.Size(118, 24);
			this.rbCheckTeacher1.TabIndex = 1;
			this.rbCheckTeacher1.Text = "Main Teacher";
			this.rbCheckTeacher1.UseVisualStyleBackColor = true;
			this.rbCheckTeacher1.CheckedChanged += new System.EventHandler(this.rbCheckTeacher1_CheckedChanged);
			// 
			// rbCheckTeacher2
			// 
			this.rbCheckTeacher2.AutoSize = true;
			this.rbCheckTeacher2.Location = new System.Drawing.Point(17, 102);
			this.rbCheckTeacher2.Name = "rbCheckTeacher2";
			this.rbCheckTeacher2.Size = new System.Drawing.Size(134, 24);
			this.rbCheckTeacher2.TabIndex = 3;
			this.rbCheckTeacher2.Text = "Second Teacher";
			this.rbCheckTeacher2.UseVisualStyleBackColor = false;
			this.rbCheckTeacher2.CheckedChanged += new System.EventHandler(this.rbCheckTeacher2_CheckedChanged);
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel10.Controls.Add(this.lblLessonName);
			this.panel10.Controls.Add(this.txtMaterial);
			this.panel10.Controls.Add(this.btnSave);
			this.panel10.Controls.Add(this.lblLesson);
			this.panel10.Controls.Add(this.btnCancel);
			this.panel10.Controls.Add(this.btnEdit);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel10.Location = new System.Drawing.Point(860, 3);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(851, 133);
			this.panel10.TabIndex = 1;
			// 
			// lblLessonName
			// 
			this.lblLessonName.AutoSize = true;
			this.lblLessonName.Location = new System.Drawing.Point(280, 109);
			this.lblLessonName.Name = "lblLessonName";
			this.lblLessonName.Size = new System.Drawing.Size(0, 20);
			this.lblLessonName.TabIndex = 9;
			// 
			// txtMaterial
			// 
			this.txtMaterial.Location = new System.Drawing.Point(398, 15);
			this.txtMaterial.Name = "txtMaterial";
			this.txtMaterial.Size = new System.Drawing.Size(125, 27);
			this.txtMaterial.TabIndex = 4;
			this.txtMaterial.Visible = false;
			// 
			// btnSave
			// 
			this.btnSave.BackgroundImage = global::WinFormsApp7.Properties.Resources.icons8_save_16;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Location = new System.Drawing.Point(534, 13);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(33, 29);
			this.btnSave.TabIndex = 5;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Visible = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblLesson
			// 
			this.lblLesson.AutoSize = true;
			this.lblLesson.Location = new System.Drawing.Point(180, 109);
			this.lblLesson.Name = "lblLesson";
			this.lblLesson.Size = new System.Drawing.Size(92, 20);
			this.lblLesson.TabIndex = 8;
			this.lblLesson.Text = "Topic Name:";
			this.lblLesson.Click += new System.EventHandler(this.lblLesson_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackgroundImage = global::WinFormsApp7.Properties.Resources.icons8_cross_mark_button_48;
			this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Location = new System.Drawing.Point(573, 14);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(33, 29);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Visible = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnEdit.Enabled = false;
			this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEdit.Location = new System.Drawing.Point(209, 15);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(183, 29);
			this.btnEdit.TabIndex = 2;
			this.btnEdit.Text = "Note The Lesson Name";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 7;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.82772F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.9588F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.0387F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.86891F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.86891F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.86891F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.56804F));
			this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel5, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel6, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel7, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel8, 6, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 142);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1714, 92);
			this.tableLayoutPanel1.TabIndex = 7;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel2.Controls.Add(this.lblFullName);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(385, 86);
			this.panel2.TabIndex = 0;
			// 
			// lblFullName
			// 
			this.lblFullName.Location = new System.Drawing.Point(93, 33);
			this.lblFullName.Name = "lblFullName";
			this.lblFullName.Size = new System.Drawing.Size(248, 20);
			this.lblFullName.TabIndex = 0;
			this.lblFullName.Text = "Name|Surname|Fathername";
			this.lblFullName.Click += new System.EventHandler(this.lblFullName_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel3.Controls.Add(this.lblLastIn);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(394, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(198, 86);
			this.panel3.TabIndex = 1;
			// 
			// lblLastIn
			// 
			this.lblLastIn.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.lblLastIn.Location = new System.Drawing.Point(3, 33);
			this.lblLastIn.Name = "lblLastIn";
			this.lblLastIn.Size = new System.Drawing.Size(192, 20);
			this.lblLastIn.TabIndex = 0;
			this.lblLastIn.Text = "Last In To MyStat";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel4.Controls.Add(this.rbtnAllTrue);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(598, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(217, 86);
			this.panel4.TabIndex = 2;
			// 
			// rbtnAllTrue
			// 
			this.rbtnAllTrue.AutoSize = true;
			this.rbtnAllTrue.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.rbtnAllTrue.Enabled = false;
			this.rbtnAllTrue.Location = new System.Drawing.Point(77, 29);
			this.rbtnAllTrue.Name = "rbtnAllTrue";
			this.rbtnAllTrue.Size = new System.Drawing.Size(85, 24);
			this.rbtnAllTrue.TabIndex = 1;
			this.rbtnAllTrue.TabStop = true;
			this.rbtnAllTrue.Text = "Note All";
			this.rbtnAllTrue.UseVisualStyleBackColor = false;
			this.rbtnAllTrue.CheckedChanged += new System.EventHandler(this.rbtnAllTrue_CheckedChanged);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel5.Controls.Add(this.label7);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(821, 3);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(180, 86);
			this.panel5.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(58, 33);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(79, 20);
			this.label7.TabIndex = 0;
			this.label7.Text = "Class Mark";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel6.Controls.Add(this.label4);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(1007, 3);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(180, 86);
			this.panel6.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(33, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "Laboratory Mark";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel7.Controls.Add(this.label5);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(1193, 3);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(180, 86);
			this.panel7.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(57, 33);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "Crsytals";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel8.Controls.Add(this.label6);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(1379, 3);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(332, 86);
			this.panel8.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 33);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 20);
			this.label6.TabIndex = 0;
			this.label6.Text = "Comments";
			// 
			// pnlStdentContent
			// 
			this.pnlStdentContent.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pnlStdentContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlStdentContent.Location = new System.Drawing.Point(8, 234);
			this.pnlStdentContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pnlStdentContent.Name = "pnlStdentContent";
			this.pnlStdentContent.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.pnlStdentContent.Size = new System.Drawing.Size(1714, 535);
			this.pnlStdentContent.TabIndex = 1;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoScrollMinSize = new System.Drawing.Size(1080, 0);
			this.ClientSize = new System.Drawing.Size(1730, 769);
			this.Controls.Add(this.pnlStdentContent);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormMain";
			this.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.Text = "MYSTAT";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.panel10.ResumeLayout(false);
			this.panel10.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.ResumeLayout(false);

    }

    #endregion

    private Panel panel1;
    private RadioButton rbCheckTeacher1;
    private Button btnEdit;
    private RadioButton rbCheckTeacher2;
    private TextBox txtMaterial;
    private Button btnCancel;
    private Button btnSave;
    private Panel panel2;
    private Label lblFullName;
    private Panel panel3;
    private Label lblLastIn;
    private Panel panel4;
    private Panel panel5;
    private Label label7;
    private Panel panel6;
    private Label label4;
    private Panel panel7;
    private Label label5;
    private Panel panel8;
    private Label label6;
    public TableLayoutPanel tableLayoutPanel1;
    private RadioButton rbtnAllTrue;
    private Label lblLessonName;
    private Label lblLesson;
    private Panel pnlStdentContent;
    private TableLayoutPanel tableLayoutPanel2;
    private Panel panel9;
    private Panel panel10;
	private Label label1;
}