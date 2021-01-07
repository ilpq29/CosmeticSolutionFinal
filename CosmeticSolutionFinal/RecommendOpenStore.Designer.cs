
namespace CosmeticSolutionFinal
{
    partial class RecommendOpenStore
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.dataGridAnalysisResult = new System.Windows.Forms.DataGridView();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FemalePopulation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompetitorStoreNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnalysisResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAnalyze, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(192, 56);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy년";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(3, 31);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(92, 21);
            this.dateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "연령별 매출 분석";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(118, 31);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(71, 22);
            this.btnAnalyze.TabIndex = 2;
            this.btnAnalyze.Text = "입점 분석";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // dataGridAnalysisResult
            // 
            this.dataGridAnalysisResult.AllowUserToResizeColumns = false;
            this.dataGridAnalysisResult.AllowUserToResizeRows = false;
            this.dataGridAnalysisResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAnalysisResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StationName,
            this.FemalePopulation,
            this.CompetitorStoreNumber,
            this.StoreSpace,
            this.BranchNumber,
            this.Score});
            this.dataGridAnalysisResult.Location = new System.Drawing.Point(12, 75);
            this.dataGridAnalysisResult.Name = "dataGridAnalysisResult";
            this.dataGridAnalysisResult.RowHeadersVisible = false;
            this.dataGridAnalysisResult.RowTemplate.Height = 23;
            this.dataGridAnalysisResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAnalysisResult.Size = new System.Drawing.Size(776, 363);
            this.dataGridAnalysisResult.TabIndex = 1;
            // 
            // StationName
            // 
            this.StationName.HeaderText = "역 이름";
            this.StationName.Name = "StationName";
            // 
            // FemalePopulation
            // 
            this.FemalePopulation.HeaderText = "여성 유동 인구";
            this.FemalePopulation.Name = "FemalePopulation";
            this.FemalePopulation.Width = 150;
            // 
            // CompetitorStoreNumber
            // 
            this.CompetitorStoreNumber.HeaderText = "경쟁 업체 수";
            this.CompetitorStoreNumber.Name = "CompetitorStoreNumber";
            // 
            // StoreSpace
            // 
            this.StoreSpace.HeaderText = "매장 평수";
            this.StoreSpace.Name = "StoreSpace";
            // 
            // BranchNumber
            // 
            this.BranchNumber.HeaderText = "입점 매장 수";
            this.BranchNumber.Name = "BranchNumber";
            // 
            // Score
            // 
            this.Score.HeaderText = "총점";
            this.Score.Name = "Score";
            // 
            // RecommendOpenStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridAnalysisResult);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RecommendOpenStore";
            this.Text = "입점 추천 점수";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnalysisResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.DataGridView dataGridAnalysisResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FemalePopulation;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompetitorStoreNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreSpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}