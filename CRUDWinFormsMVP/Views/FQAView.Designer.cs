﻿
namespace CRUDWinFormsMVP.Views
{
    partial class FQAView
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFQAList = new System.Windows.Forms.TabPage();
            this.btnDeleteFQA = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddFQA = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabPageFQADetail = new System.Windows.Forms.TabPage();
            this.lbquestionId = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboxquestiontype1 = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtquestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.tabPageAddQuestion = new System.Windows.Forms.TabPage();
            this.txtviewans = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.btncancel1 = new System.Windows.Forms.Button();
            this.btnAddFQADetails = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxquestiontype = new System.Windows.Forms.ComboBox();
            this.textquestion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageFQAList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPageFQADetail.SuspendLayout();
            this.tabPageAddQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "FQA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 56);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(851, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFQAList);
            this.tabControl1.Controls.Add(this.tabPageFQADetail);
            this.tabControl1.Controls.Add(this.tabPageAddQuestion);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(892, 411);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageFQAList
            // 
            this.tabPageFQAList.Controls.Add(this.btnDeleteFQA);
            this.tabPageFQAList.Controls.Add(this.btnAddQuestion);
            this.tabPageFQAList.Controls.Add(this.dataGridView);
            this.tabPageFQAList.Controls.Add(this.label2);
            this.tabPageFQAList.Controls.Add(this.btnEdit);
            this.tabPageFQAList.Controls.Add(this.btnAddFQA);
            this.tabPageFQAList.Controls.Add(this.btnSearch);
            this.tabPageFQAList.Controls.Add(this.txtSearch);
            this.tabPageFQAList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageFQAList.Location = new System.Drawing.Point(4, 34);
            this.tabPageFQAList.Name = "tabPageFQAList";
            this.tabPageFQAList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFQAList.Size = new System.Drawing.Size(884, 373);
            this.tabPageFQAList.TabIndex = 0;
            this.tabPageFQAList.Text = "FQA list";
            this.tabPageFQAList.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFQA
            // 
            this.btnDeleteFQA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFQA.Location = new System.Drawing.Point(668, 170);
            this.btnDeleteFQA.Name = "btnDeleteFQA";
            this.btnDeleteFQA.Size = new System.Drawing.Size(198, 30);
            this.btnDeleteFQA.TabIndex = 9;
            this.btnDeleteFQA.Text = "Delete";
            this.btnDeleteFQA.UseVisualStyleBackColor = true;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddQuestion.Location = new System.Drawing.Point(668, 98);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(198, 30);
            this.btnAddQuestion.TabIndex = 8;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(24, 63);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(638, 302);
            this.dataGridView.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search FQA:";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(668, 134);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(198, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddFQA
            // 
            this.btnAddFQA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFQA.Location = new System.Drawing.Point(668, 62);
            this.btnAddFQA.Name = "btnAddFQA";
            this.btnAddFQA.Size = new System.Drawing.Size(198, 30);
            this.btnAddFQA.TabIndex = 2;
            this.btnAddFQA.Text = "Add FQA";
            this.btnAddFQA.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(668, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(198, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(24, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(638, 30);
            this.txtSearch.TabIndex = 0;
            // 
            // tabPageFQADetail
            // 
            this.tabPageFQADetail.Controls.Add(this.lbquestionId);
            this.tabPageFQADetail.Controls.Add(this.tbAnswer);
            this.tabPageFQADetail.Controls.Add(this.label10);
            this.tabPageFQADetail.Controls.Add(this.cboxquestiontype1);
            this.tabPageFQADetail.Controls.Add(this.btnCancel);
            this.tabPageFQADetail.Controls.Add(this.btnSave);
            this.tabPageFQADetail.Controls.Add(this.label5);
            this.tabPageFQADetail.Controls.Add(this.label4);
            this.tabPageFQADetail.Controls.Add(this.txtquestion);
            this.tabPageFQADetail.Controls.Add(this.label3);
            this.tabPageFQADetail.Controls.Add(this.txtId);
            this.tabPageFQADetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageFQADetail.Location = new System.Drawing.Point(4, 34);
            this.tabPageFQADetail.Name = "tabPageFQADetail";
            this.tabPageFQADetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFQADetail.Size = new System.Drawing.Size(884, 373);
            this.tabPageFQADetail.TabIndex = 1;
            this.tabPageFQADetail.Text = "Add FQA";
            this.tabPageFQADetail.UseVisualStyleBackColor = true;
            // 
            // lbquestionId
            // 
            this.lbquestionId.AutoSize = true;
            this.lbquestionId.Location = new System.Drawing.Point(635, 3);
            this.lbquestionId.Name = "lbquestionId";
            this.lbquestionId.Size = new System.Drawing.Size(26, 29);
            this.lbquestionId.TabIndex = 26;
            this.lbquestionId.Text = "0";
            this.lbquestionId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbquestionId.Visible = false;
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(435, 54);
            this.tbAnswer.Multiline = true;
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(446, 288);
            this.tbAnswer.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(430, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Answer:";
            // 
            // cboxquestiontype1
            // 
            this.cboxquestiontype1.FormattingEnabled = true;
            this.cboxquestiontype1.Items.AddRange(new object[] {
            "Equals",
            "Startwith",
            "Contains"});
            this.cboxquestiontype1.Location = new System.Drawing.Point(241, 54);
            this.cboxquestiontype1.Name = "cboxquestiontype1";
            this.cboxquestiontype1.Size = new System.Drawing.Size(153, 37);
            this.cboxquestiontype1.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(260, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 44);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(64, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 44);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Question type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Question:";
            // 
            // txtquestion
            // 
            this.txtquestion.Location = new System.Drawing.Point(64, 119);
            this.txtquestion.Multiline = true;
            this.txtquestion.Name = "txtquestion";
            this.txtquestion.Size = new System.Drawing.Size(349, 160);
            this.txtquestion.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(64, 54);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(154, 34);
            this.txtId.TabIndex = 6;
            this.txtId.Text = "0";
            // 
            // tabPageAddQuestion
            // 
            this.tabPageAddQuestion.Controls.Add(this.txtviewans);
            this.tabPageAddQuestion.Controls.Add(this.label9);
            this.tabPageAddQuestion.Controls.Add(this.dgvQuestions);
            this.tabPageAddQuestion.Controls.Add(this.btncancel1);
            this.tabPageAddQuestion.Controls.Add(this.btnAddFQADetails);
            this.tabPageAddQuestion.Controls.Add(this.label8);
            this.tabPageAddQuestion.Controls.Add(this.cboxquestiontype);
            this.tabPageAddQuestion.Controls.Add(this.textquestion);
            this.tabPageAddQuestion.Controls.Add(this.label7);
            this.tabPageAddQuestion.Controls.Add(this.textId);
            this.tabPageAddQuestion.Controls.Add(this.label6);
            this.tabPageAddQuestion.Location = new System.Drawing.Point(4, 34);
            this.tabPageAddQuestion.Name = "tabPageAddQuestion";
            this.tabPageAddQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddQuestion.Size = new System.Drawing.Size(884, 373);
            this.tabPageAddQuestion.TabIndex = 2;
            this.tabPageAddQuestion.Text = "Add Question";
            this.tabPageAddQuestion.UseVisualStyleBackColor = true;
            // 
            // txtviewans
            // 
            this.txtviewans.Location = new System.Drawing.Point(436, 63);
            this.txtviewans.Multiline = true;
            this.txtviewans.Name = "txtviewans";
            this.txtviewans.Size = new System.Drawing.Size(426, 133);
            this.txtviewans.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(431, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 29);
            this.label9.TabIndex = 23;
            this.label9.Text = "Answer:";
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestions.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Location = new System.Drawing.Point(436, 202);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.RowHeadersWidth = 51;
            this.dgvQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestions.Size = new System.Drawing.Size(426, 135);
            this.dgvQuestions.TabIndex = 21;
            // 
            // btncancel1
            // 
            this.btncancel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel1.Location = new System.Drawing.Point(267, 293);
            this.btncancel1.Name = "btncancel1";
            this.btncancel1.Size = new System.Drawing.Size(152, 44);
            this.btncancel1.TabIndex = 20;
            this.btncancel1.Text = "Cancel";
            this.btncancel1.UseVisualStyleBackColor = true;
            // 
            // btnAddFQADetails
            // 
            this.btnAddFQADetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFQADetails.Location = new System.Drawing.Point(83, 293);
            this.btnAddFQADetails.Name = "btnAddFQADetails";
            this.btnAddFQADetails.Size = new System.Drawing.Size(152, 44);
            this.btnAddFQADetails.TabIndex = 19;
            this.btnAddFQADetails.Text = "Add";
            this.btnAddFQADetails.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(250, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Question type:";
            // 
            // cboxquestiontype
            // 
            this.cboxquestiontype.FormattingEnabled = true;
            this.cboxquestiontype.Items.AddRange(new object[] {
            "Equals",
            "Startwith",
            "Contains"});
            this.cboxquestiontype.Location = new System.Drawing.Point(255, 60);
            this.cboxquestiontype.Name = "cboxquestiontype";
            this.cboxquestiontype.Size = new System.Drawing.Size(153, 33);
            this.cboxquestiontype.TabIndex = 17;
            // 
            // textquestion
            // 
            this.textquestion.Location = new System.Drawing.Point(83, 135);
            this.textquestion.Multiline = true;
            this.textquestion.Name = "textquestion";
            this.textquestion.Size = new System.Drawing.Size(336, 138);
            this.textquestion.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Question:";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(81, 63);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(154, 30);
            this.textId.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "ID:";
            // 
            // FQAView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 467);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FQAView";
            this.Text = "FQAView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageFQAList.ResumeLayout(false);
            this.tabPageFQAList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPageFQADetail.ResumeLayout(false);
            this.tabPageFQADetail.PerformLayout();
            this.tabPageAddQuestion.ResumeLayout(false);
            this.tabPageAddQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFQAList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddFQA;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tabPageFQADetail;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtquestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.ComboBox cboxquestiontype1;
        private System.Windows.Forms.TabPage tabPageAddQuestion;
        private System.Windows.Forms.Button btncancel1;
        private System.Windows.Forms.Button btnAddFQADetails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxquestiontype;
        private System.Windows.Forms.TextBox textquestion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.TextBox txtviewans;
        private System.Windows.Forms.Label lbquestionId;
        private System.Windows.Forms.Button btnDeleteFQA;
    }
}