
namespace Union_s_Wealth_re
{
	partial class UbooAlarmForm
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UbooAlarmForm));
			this.mesoStatusLabel = new System.Windows.Forms.Label();
			this.timeLabel = new System.Windows.Forms.Label();
			this.timeTextBox = new System.Windows.Forms.TextBox();
			this.stopUnionButton = new System.Windows.Forms.Button();
			this.executeUnionButton = new System.Windows.Forms.Button();
			this.unionProgressBar = new System.Windows.Forms.ProgressBar();
			this.stopMesoButton = new System.Windows.Forms.Button();
			this.executeMesoButton = new System.Windows.Forms.Button();
			this.mesoProgressBar = new System.Windows.Forms.ProgressBar();
			this.set100secButton = new System.Windows.Forms.Button();
			this.set80secButton = new System.Windows.Forms.Button();
			this.unionStatusLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// mesoStatusLabel
			// 
			this.mesoStatusLabel.Location = new System.Drawing.Point(98, 330);
			this.mesoStatusLabel.Name = "mesoStatusLabel";
			this.mesoStatusLabel.Size = new System.Drawing.Size(160, 23);
			this.mesoStatusLabel.TabIndex = 0;
			this.mesoStatusLabel.Text = "mesoStatus";
			this.mesoStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timeLabel
			// 
			this.timeLabel.Location = new System.Drawing.Point(85, 9);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(188, 23);
			this.timeLabel.TabIndex = 1;
			this.timeLabel.Text = "시간을 입력하세요 (숫자만)";
			this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timeTextBox
			// 
			this.timeTextBox.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.timeTextBox.Location = new System.Drawing.Point(130, 35);
			this.timeTextBox.Name = "timeTextBox";
			this.timeTextBox.Size = new System.Drawing.Size(100, 35);
			this.timeTextBox.TabIndex = 2;
			this.timeTextBox.Text = "30";
			this.timeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.timeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.timeTextBox_KeyDown);
			// 
			// stopUnionButton
			// 
			this.stopUnionButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.stopUnionButton.Location = new System.Drawing.Point(87, 76);
			this.stopUnionButton.Name = "stopUnionButton";
			this.stopUnionButton.Size = new System.Drawing.Size(90, 70);
			this.stopUnionButton.TabIndex = 3;
			this.stopUnionButton.Text = "중지";
			this.stopUnionButton.UseVisualStyleBackColor = true;
			this.stopUnionButton.Click += new System.EventHandler(this.stopUnionButton_Click);
			// 
			// executeUnionButton
			// 
			this.executeUnionButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.executeUnionButton.Location = new System.Drawing.Point(183, 76);
			this.executeUnionButton.Name = "executeUnionButton";
			this.executeUnionButton.Size = new System.Drawing.Size(90, 70);
			this.executeUnionButton.TabIndex = 3;
			this.executeUnionButton.Text = "실행";
			this.executeUnionButton.UseVisualStyleBackColor = true;
			this.executeUnionButton.Click += new System.EventHandler(this.executeUnionButton_Click);
			// 
			// unionProgressBar
			// 
			this.unionProgressBar.Location = new System.Drawing.Point(42, 150);
			this.unionProgressBar.Name = "unionProgressBar";
			this.unionProgressBar.Size = new System.Drawing.Size(280, 26);
			this.unionProgressBar.TabIndex = 4;
			this.unionProgressBar.Value = 100;
			// 
			// stopMesoButton
			// 
			this.stopMesoButton.Location = new System.Drawing.Point(102, 239);
			this.stopMesoButton.Name = "stopMesoButton";
			this.stopMesoButton.Size = new System.Drawing.Size(75, 58);
			this.stopMesoButton.TabIndex = 5;
			this.stopMesoButton.Text = "메소 중지";
			this.stopMesoButton.UseVisualStyleBackColor = true;
			this.stopMesoButton.Click += new System.EventHandler(this.stopMesoButton_Click);
			// 
			// executeMesoButton
			// 
			this.executeMesoButton.Location = new System.Drawing.Point(183, 239);
			this.executeMesoButton.Name = "executeMesoButton";
			this.executeMesoButton.Size = new System.Drawing.Size(75, 58);
			this.executeMesoButton.TabIndex = 5;
			this.executeMesoButton.Text = "메소 실행";
			this.executeMesoButton.UseVisualStyleBackColor = true;
			this.executeMesoButton.Click += new System.EventHandler(this.executeMesoButton_Click);
			// 
			// mesoProgressBar
			// 
			this.mesoProgressBar.Location = new System.Drawing.Point(87, 316);
			this.mesoProgressBar.Name = "mesoProgressBar";
			this.mesoProgressBar.Size = new System.Drawing.Size(186, 11);
			this.mesoProgressBar.TabIndex = 4;
			this.mesoProgressBar.Value = 100;
			// 
			// set100secButton
			// 
			this.set100secButton.Location = new System.Drawing.Point(277, 239);
			this.set100secButton.Name = "set100secButton";
			this.set100secButton.Size = new System.Drawing.Size(75, 23);
			this.set100secButton.TabIndex = 6;
			this.set100secButton.Text = "1m 40s";
			this.set100secButton.UseVisualStyleBackColor = true;
			this.set100secButton.Click += new System.EventHandler(this.set100secButton_Click);
			// 
			// set80secButton
			// 
			this.set80secButton.Location = new System.Drawing.Point(277, 274);
			this.set80secButton.Name = "set80secButton";
			this.set80secButton.Size = new System.Drawing.Size(75, 23);
			this.set80secButton.TabIndex = 6;
			this.set80secButton.Text = "1m 20s";
			this.set80secButton.UseVisualStyleBackColor = true;
			this.set80secButton.Click += new System.EventHandler(this.set80secButton_Click);
			// 
			// unionStatusLabel
			// 
			this.unionStatusLabel.Location = new System.Drawing.Point(98, 179);
			this.unionStatusLabel.Name = "unionStatusLabel";
			this.unionStatusLabel.Size = new System.Drawing.Size(160, 23);
			this.unionStatusLabel.TabIndex = 7;
			this.unionStatusLabel.Text = "unionStatus";
			this.unionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// UbooAlarmForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 361);
			this.Controls.Add(this.unionStatusLabel);
			this.Controls.Add(this.set80secButton);
			this.Controls.Add(this.set100secButton);
			this.Controls.Add(this.executeMesoButton);
			this.Controls.Add(this.stopMesoButton);
			this.Controls.Add(this.mesoProgressBar);
			this.Controls.Add(this.unionProgressBar);
			this.Controls.Add(this.executeUnionButton);
			this.Controls.Add(this.stopUnionButton);
			this.Controls.Add(this.timeTextBox);
			this.Controls.Add(this.timeLabel);
			this.Controls.Add(this.mesoStatusLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "UbooAlarmForm";
			this.Text = "유부 알리미";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label mesoStatusLabel;
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.TextBox timeTextBox;
		private System.Windows.Forms.Button stopUnionButton;
		private System.Windows.Forms.Button executeUnionButton;
		private System.Windows.Forms.ProgressBar unionProgressBar;
		private System.Windows.Forms.Button stopMesoButton;
		private System.Windows.Forms.Button executeMesoButton;
		private System.Windows.Forms.ProgressBar mesoProgressBar;
		private System.Windows.Forms.Button set100secButton;
		private System.Windows.Forms.Button set80secButton;
		private System.Windows.Forms.Label unionStatusLabel;
	}
}