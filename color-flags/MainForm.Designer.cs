namespace color_flags
{
    partial class MainForm
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
            tableLayoutPanel = new TableLayoutPanel();
            lblV10 = new Label();
            lblV50 = new Label();
            lblV90 = new Label();
            lblVbak = new Label();
            lblWbak = new Label();
            lblW90 = new Label();
            lblW50 = new Label();
            lblW10 = new Label();
            buttonReadExisting = new Button();
            labelByte = new Label();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.Controls.Add(lblV10, 0, 0);
            tableLayoutPanel.Controls.Add(lblV50, 1, 0);
            tableLayoutPanel.Controls.Add(lblV90, 2, 0);
            tableLayoutPanel.Controls.Add(lblVbak, 3, 0);
            tableLayoutPanel.Controls.Add(lblWbak, 3, 1);
            tableLayoutPanel.Controls.Add(lblW90, 2, 1);
            tableLayoutPanel.Controls.Add(lblW50, 1, 1);
            tableLayoutPanel.Controls.Add(lblW10, 0, 1);
            tableLayoutPanel.Location = new Point(30, 28);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel.Size = new Size(391, 101);
            tableLayoutPanel.TabIndex = 0;
            // 
            // lblV10
            // 
            lblV10.Anchor = AnchorStyles.None;
            lblV10.BackColor = Color.Black;
            lblV10.ForeColor = Color.White;
            lblV10.Location = new Point(4, 6);
            lblV10.Name = "lblV10";
            lblV10.Size = new Size(88, 38);
            lblV10.TabIndex = 0;
            lblV10.Text = "lblV10";
            lblV10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblV50
            // 
            lblV50.Anchor = AnchorStyles.None;
            lblV50.BackColor = Color.Black;
            lblV50.ForeColor = Color.White;
            lblV50.Location = new Point(101, 6);
            lblV50.Name = "lblV50";
            lblV50.Size = new Size(88, 38);
            lblV50.TabIndex = 0;
            lblV50.Text = "lblV50";
            lblV50.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblV90
            // 
            lblV90.Anchor = AnchorStyles.None;
            lblV90.BackColor = Color.Black;
            lblV90.ForeColor = Color.White;
            lblV90.Location = new Point(198, 6);
            lblV90.Name = "lblV90";
            lblV90.Size = new Size(88, 38);
            lblV90.TabIndex = 0;
            lblV90.Text = "lblV90";
            lblV90.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVbak
            // 
            lblVbak.Anchor = AnchorStyles.None;
            lblVbak.BackColor = Color.Black;
            lblVbak.ForeColor = Color.White;
            lblVbak.Location = new Point(297, 6);
            lblVbak.Name = "lblVbak";
            lblVbak.Size = new Size(88, 38);
            lblVbak.TabIndex = 0;
            lblVbak.Text = "lblVbak";
            lblVbak.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWbak
            // 
            lblWbak.Anchor = AnchorStyles.None;
            lblWbak.BackColor = Color.Black;
            lblWbak.ForeColor = Color.White;
            lblWbak.Location = new Point(297, 56);
            lblWbak.Name = "lblWbak";
            lblWbak.Size = new Size(88, 38);
            lblWbak.TabIndex = 0;
            lblWbak.Text = "lblWbak";
            lblWbak.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblW90
            // 
            lblW90.Anchor = AnchorStyles.None;
            lblW90.BackColor = Color.Black;
            lblW90.ForeColor = Color.White;
            lblW90.Location = new Point(198, 56);
            lblW90.Name = "lblW90";
            lblW90.Size = new Size(88, 38);
            lblW90.TabIndex = 0;
            lblW90.Text = "lblW90";
            lblW90.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblW50
            // 
            lblW50.Anchor = AnchorStyles.None;
            lblW50.BackColor = Color.Black;
            lblW50.ForeColor = Color.White;
            lblW50.Location = new Point(101, 56);
            lblW50.Name = "lblW50";
            lblW50.Size = new Size(88, 38);
            lblW50.TabIndex = 0;
            lblW50.Text = "lblW50";
            lblW50.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblW10
            // 
            lblW10.Anchor = AnchorStyles.None;
            lblW10.BackColor = Color.Black;
            lblW10.ForeColor = Color.White;
            lblW10.Location = new Point(4, 56);
            lblW10.Name = "lblW10";
            lblW10.Size = new Size(88, 38);
            lblW10.TabIndex = 0;
            lblW10.Text = "lblW10";
            lblW10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonReadExisting
            // 
            buttonReadExisting.Location = new Point(34, 178);
            buttonReadExisting.Name = "buttonReadExisting";
            buttonReadExisting.Size = new Size(185, 34);
            buttonReadExisting.TabIndex = 1;
            buttonReadExisting.Text = "Read Existing";
            buttonReadExisting.UseVisualStyleBackColor = true;
            // 
            // labelByte
            // 
            labelByte.Anchor = AnchorStyles.None;
            labelByte.BackColor = Color.Black;
            labelByte.ForeColor = Color.White;
            labelByte.Location = new Point(260, 178);
            labelByte.Name = "labelByte";
            labelByte.Size = new Size(88, 38);
            labelByte.TabIndex = 0;
            labelByte.Text = "0x00";
            labelByte.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 244);
            Controls.Add(buttonReadExisting);
            Controls.Add(tableLayoutPanel);
            Controls.Add(labelByte);
            Name = "MainForm";
            Text = "Main Form";
            tableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Label lblV10;
        private Label lblV50;
        private Label lblV90;
        private Label lblVbak;
        private Label lblWbak;
        private Label lblW90;
        private Label lblW50;
        private Label lblW10;
        private Button buttonReadExisting;
        private Label labelByte;
    }
}
