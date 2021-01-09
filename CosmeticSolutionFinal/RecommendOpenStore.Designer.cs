
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.dataGridAnalysisResult = new System.Windows.Forms.DataGridView();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FemalePopulation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompetitorStoreNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelProgress = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnalysisResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.Controls.Add(this.dateTimePicker, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.btnAnalyze, 1, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(202, 31);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy년";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(92, 21);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker_KeyDown);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(121, 3);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAnalysisResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridAnalysisResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAnalysisResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StationName,
            this.FemalePopulation,
            this.CompetitorStoreNumber,
            this.StoreSpace,
            this.BranchNumber,
            this.Score});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAnalysisResult.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridAnalysisResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridAnalysisResult.Location = new System.Drawing.Point(0, 87);
            this.dataGridAnalysisResult.Name = "dataGridAnalysisResult";
            this.dataGridAnalysisResult.RowHeadersVisible = false;
            this.dataGridAnalysisResult.RowTemplate.Height = 23;
            this.dataGridAnalysisResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAnalysisResult.Size = new System.Drawing.Size(800, 363);
            this.dataGridAnalysisResult.TabIndex = 1;
            // 
            // StationName
            // 
            this.StationName.HeaderText = "역 이름";
            this.StationName.Name = "StationName";
            this.StationName.Width = 200;
            // 
            // FemalePopulation
            // 
            this.FemalePopulation.HeaderText = "여성 유동 인구";
            this.FemalePopulation.Name = "FemalePopulation";
            this.FemalePopulation.Width = 180;
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
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(221, 22);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(41, 12);
            this.labelProgress.TabIndex = 3;
            this.labelProgress.Text = "분석중";
            // 
            // RecommendOpenStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridAnalysisResult);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.labelProgress);
            this.Name = "RecommendOpenStore";
            this.Text = "입점 추천 점수";
            this.Load += new System.EventHandler(this.RecommendOpenStore_Load);
            this.SizeChanged += new System.EventHandler(this.RecommendOpenStore_SizeChanged);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnalysisResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.DataGridView dataGridAnalysisResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FemalePopulation;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompetitorStoreNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreSpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.Label labelProgress;
    }
}