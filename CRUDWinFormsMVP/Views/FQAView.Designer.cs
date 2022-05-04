
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
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearchFQA = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabPageFQADetail = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtquestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cboxquestiontype1 = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textquestion = new System.Windows.Forms.TextBox();
            this.cboxquestiontype = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncancel1 = new System.Windows.Forms.Button();
            this.dgvans = new System.Windows.Forms.DataGridView();
            this.listviewans = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageFQAList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPageFQADetail.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvans)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(892, 411);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageFQAList
            // 
            this.tabPageFQAList.Controls.Add(this.btnAddQuestion);
            this.tabPageFQAList.Controls.Add(this.dataGridView);
            this.tabPageFQAList.Controls.Add(this.label2);
            this.tabPageFQAList.Controls.Add(this.btnDelete);
            this.tabPageFQAList.Controls.Add(this.btnEdit);
            this.tabPageFQAList.Controls.Add(this.btnSearchFQA);
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
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(668, 335);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(198, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
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
            // btnSearchFQA
            // 
            this.btnSearchFQA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchFQA.Location = new System.Drawing.Point(668, 62);
            this.btnSearchFQA.Name = "btnSearchFQA";
            this.btnSearchFQA.Size = new System.Drawing.Size(198, 30);
            this.btnSearchFQA.TabIndex = 2;
            this.btnSearchFQA.Text = "Search FQA";
            this.btnSearchFQA.UseVisualStyleBackColor = true;
            this.btnSearchFQA.Click += new System.EventHandler(this.btnAddNew_Click);
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
            this.tabPageFQADetail.Controls.Add(this.label10);
            this.tabPageFQADetail.Controls.Add(this.listView2);
            this.tabPageFQADetail.Controls.Add(this.cboxquestiontype1);
            this.tabPageFQADetail.Controls.Add(this.btnCancel);
            this.tabPageFQADetail.Controls.Add(this.btnSearch1);
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
            this.tabPageFQADetail.Text = "Search FQA";
            this.tabPageFQADetail.UseVisualStyleBackColor = true;
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
            // btnSearch1
            // 
            this.btnSearch1.Location = new System.Drawing.Point(64, 298);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(154, 44);
            this.btnSearch1.TabIndex = 14;
            this.btnSearch1.Text = "Search";
            this.btnSearch1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Question type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Question:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtquestion
            // 
            this.txtquestion.Location = new System.Drawing.Point(63, 184);
            this.txtquestion.Name = "txtquestion";
            this.txtquestion.Size = new System.Drawing.Size(154, 34);
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
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // cboxquestiontype1
            // 
            this.cboxquestiontype1.FormattingEnabled = true;
            this.cboxquestiontype1.Items.AddRange(new object[] {
            "Equals",
            "Startwith",
            "Contains"});
            this.cboxquestiontype1.Location = new System.Drawing.Point(260, 181);
            this.cboxquestiontype1.Name = "cboxquestiontype1";
            this.cboxquestiontype1.Size = new System.Drawing.Size(153, 37);
            this.cboxquestiontype1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.listviewans);
            this.tabPage1.Controls.Add(this.dgvans);
            this.tabPage1.Controls.Add(this.btncancel1);
            this.tabPage1.Controls.Add(this.btnadd);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cboxquestiontype);
            this.tabPage1.Controls.Add(this.textquestion);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textId);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(884, 373);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Add Question";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(81, 63);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(154, 30);
            this.textId.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Question:";
            // 
            // textquestion
            // 
            this.textquestion.Location = new System.Drawing.Point(81, 172);
            this.textquestion.Name = "textquestion";
            this.textquestion.Size = new System.Drawing.Size(154, 30);
            this.textquestion.TabIndex = 11;
            // 
            // cboxquestiontype
            // 
            this.cboxquestiontype.FormattingEnabled = true;
            this.cboxquestiontype.Items.AddRange(new object[] {
            "Equals",
            "Startwith",
            "Contains"});
            this.cboxquestiontype.Location = new System.Drawing.Point(267, 169);
            this.cboxquestiontype.Name = "cboxquestiontype";
            this.cboxquestiontype.Size = new System.Drawing.Size(153, 33);
            this.cboxquestiontype.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(262, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Question type:";
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(83, 293);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(152, 44);
            this.btnadd.TabIndex = 19;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
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
            this.btncancel1.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvans
            // 
            this.dgvans.AllowUserToAddRows = false;
            this.dgvans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvans.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvans.Location = new System.Drawing.Point(436, 202);
            this.dgvans.Name = "dgvans";
            this.dgvans.RowHeadersWidth = 51;
            this.dgvans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvans.Size = new System.Drawing.Size(426, 135);
            this.dgvans.TabIndex = 21;
            // 
            // listviewans
            // 
            this.listviewans.HideSelection = false;
            this.listviewans.Location = new System.Drawing.Point(436, 63);
            this.listviewans.Name = "listviewans";
            this.listviewans.Size = new System.Drawing.Size(426, 133);
            this.listviewans.TabIndex = 22;
            this.listviewans.UseCompatibleStateImageBehavior = false;
            this.listviewans.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(435, 54);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(425, 288);
            this.listView2.TabIndex = 23;
            this.listView2.UseCompatibleStateImageBehavior = false;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFQAList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearchFQA;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tabPageFQADetail;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtquestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.ComboBox cboxquestiontype1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btncancel1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxquestiontype;
        private System.Windows.Forms.TextBox textquestion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvans;
        private System.Windows.Forms.ListView listviewans;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label9;
    }
}