
namespace PratikumWeek14
{
    partial class Team
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
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_topScore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_teamName = new System.Windows.Forms.Label();
            this.lbl_manager = new System.Windows.Forms.Label();
            this.lbl_stadium = new System.Windows.Forms.Label();
            this.lbl_top = new System.Windows.Forms.Label();
            this.lbl_worst = new System.Windows.Forms.Label();
            this.dgv_match = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_match)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(22, 24);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(50, 48);
            this.btn_first.TabIndex = 0;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(103, 24);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(50, 48);
            this.btn_prev.TabIndex = 1;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(190, 24);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(50, 48);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(269, 24);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(50, 48);
            this.btn_last.TabIndex = 3;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Manager :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stadium :";
            // 
            // lbl_topScore
            // 
            this.lbl_topScore.AutoSize = true;
            this.lbl_topScore.Location = new System.Drawing.Point(29, 244);
            this.lbl_topScore.Name = "lbl_topScore";
            this.lbl_topScore.Size = new System.Drawing.Size(87, 17);
            this.lbl_topScore.TabIndex = 7;
            this.lbl_topScore.Text = "Top Scorer :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Worst Discipline :";
            // 
            // lbl_teamName
            // 
            this.lbl_teamName.AutoSize = true;
            this.lbl_teamName.Location = new System.Drawing.Point(169, 96);
            this.lbl_teamName.Name = "lbl_teamName";
            this.lbl_teamName.Size = new System.Drawing.Size(46, 17);
            this.lbl_teamName.TabIndex = 9;
            this.lbl_teamName.Text = "label6";
            // 
            // lbl_manager
            // 
            this.lbl_manager.AutoSize = true;
            this.lbl_manager.Location = new System.Drawing.Point(169, 143);
            this.lbl_manager.Name = "lbl_manager";
            this.lbl_manager.Size = new System.Drawing.Size(46, 17);
            this.lbl_manager.TabIndex = 10;
            this.lbl_manager.Text = "label7";
            // 
            // lbl_stadium
            // 
            this.lbl_stadium.AutoSize = true;
            this.lbl_stadium.Location = new System.Drawing.Point(169, 195);
            this.lbl_stadium.Name = "lbl_stadium";
            this.lbl_stadium.Size = new System.Drawing.Size(46, 17);
            this.lbl_stadium.TabIndex = 11;
            this.lbl_stadium.Text = "label8";
            // 
            // lbl_top
            // 
            this.lbl_top.AutoSize = true;
            this.lbl_top.Location = new System.Drawing.Point(169, 244);
            this.lbl_top.Name = "lbl_top";
            this.lbl_top.Size = new System.Drawing.Size(46, 17);
            this.lbl_top.TabIndex = 12;
            this.lbl_top.Text = "label9";
            // 
            // lbl_worst
            // 
            this.lbl_worst.AutoSize = true;
            this.lbl_worst.Location = new System.Drawing.Point(169, 295);
            this.lbl_worst.Name = "lbl_worst";
            this.lbl_worst.Size = new System.Drawing.Size(54, 17);
            this.lbl_worst.TabIndex = 13;
            this.lbl_worst.Text = "label10";
            // 
            // dgv_match
            // 
            this.dgv_match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_match.Location = new System.Drawing.Point(12, 331);
            this.dgv_match.Name = "dgv_match";
            this.dgv_match.RowHeadersWidth = 51;
            this.dgv_match.RowTemplate.Height = 24;
            this.dgv_match.Size = new System.Drawing.Size(638, 250);
            this.dgv_match.TabIndex = 19;
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 627);
            this.Controls.Add(this.dgv_match);
            this.Controls.Add(this.lbl_worst);
            this.Controls.Add(this.lbl_top);
            this.Controls.Add(this.lbl_stadium);
            this.Controls.Add(this.lbl_manager);
            this.Controls.Add(this.lbl_teamName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_topScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_first);
            this.Name = "Team";
            this.Text = "Team";
            this.Load += new System.EventHandler(this.Team_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_match)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_topScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_teamName;
        private System.Windows.Forms.Label lbl_manager;
        private System.Windows.Forms.Label lbl_stadium;
        private System.Windows.Forms.Label lbl_top;
        private System.Windows.Forms.Label lbl_worst;
        private System.Windows.Forms.DataGridView dgv_match;
    }
}

