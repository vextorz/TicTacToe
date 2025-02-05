namespace TicTacToe
{
    partial class Form1
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
            this.a1Btn = new System.Windows.Forms.Button();
            this.a2Btn = new System.Windows.Forms.Button();
            this.a3Btn = new System.Windows.Forms.Button();
            this.b1Btn = new System.Windows.Forms.Button();
            this.b2Btn = new System.Windows.Forms.Button();
            this.b3Btn = new System.Windows.Forms.Button();
            this.c1Btn = new System.Windows.Forms.Button();
            this.c2Btn = new System.Windows.Forms.Button();
            this.c3Btn = new System.Windows.Forms.Button();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.a1Btn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.a2Btn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.a3Btn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.b1Btn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.b2Btn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.b3Btn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.c1Btn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.c2Btn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.c3Btn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.newGameBtn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.stopBtn, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.display, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 509);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // a1Btn
            // 
            this.a1Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.a1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1Btn.Location = new System.Drawing.Point(3, 75);
            this.a1Btn.Name = "a1Btn";
            this.a1Btn.Size = new System.Drawing.Size(145, 115);
            this.a1Btn.TabIndex = 0;
            this.a1Btn.UseVisualStyleBackColor = true;
            this.a1Btn.Click += new System.EventHandler(this.boardBtn_Click);
            // 
            // a2Btn
            // 
            this.a2Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.a2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2Btn.Location = new System.Drawing.Point(154, 75);
            this.a2Btn.Name = "a2Btn";
            this.a2Btn.Size = new System.Drawing.Size(145, 115);
            this.a2Btn.TabIndex = 1;
            this.a2Btn.UseVisualStyleBackColor = true;
            this.a2Btn.Click += new System.EventHandler(this.boardBtn_Click);
            // 
            // a3Btn
            // 
            this.a3Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.a3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3Btn.Location = new System.Drawing.Point(305, 75);
            this.a3Btn.Name = "a3Btn";
            this.a3Btn.Size = new System.Drawing.Size(146, 115);
            this.a3Btn.TabIndex = 2;
            this.a3Btn.UseVisualStyleBackColor = true;
            this.a3Btn.Click += new System.EventHandler(this.boardBtn_Click);
            // 
            // b1Btn
            // 
            this.b1Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1Btn.Location = new System.Drawing.Point(3, 196);
            this.b1Btn.Name = "b1Btn";
            this.b1Btn.Size = new System.Drawing.Size(145, 115);
            this.b1Btn.TabIndex = 3;
            this.b1Btn.UseVisualStyleBackColor = true;
            this.b1Btn.Click += new System.EventHandler(this.boardBtn_Click);
            // 
            // b2Btn
            // 
            this.b2Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2Btn.Location = new System.Drawing.Point(154, 196);
            this.b2Btn.Name = "b2Btn";
            this.b2Btn.Size = new System.Drawing.Size(145, 115);
            this.b2Btn.TabIndex = 4;
            this.b2Btn.UseVisualStyleBackColor = true;
            this.b2Btn.Click += new System.EventHandler(this.boardBtn_Click);
            // 
            // b3Btn
            // 
            this.b3Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3Btn.Location = new System.Drawing.Point(305, 196);
            this.b3Btn.Name = "b3Btn";
            this.b3Btn.Size = new System.Drawing.Size(146, 115);
            this.b3Btn.TabIndex = 5;
            this.b3Btn.UseVisualStyleBackColor = true;
            this.b3Btn.Click += new System.EventHandler(this.boardBtn_Click);
            // 
            // c1Btn
            // 
            this.c1Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Btn.Location = new System.Drawing.Point(3, 317);
            this.c1Btn.Name = "c1Btn";
            this.c1Btn.Size = new System.Drawing.Size(145, 115);
            this.c1Btn.TabIndex = 6;
            this.c1Btn.UseVisualStyleBackColor = true;
            this.c1Btn.Click += new System.EventHandler(this.boardBtn_Click);
            // 
            // c2Btn
            // 
            this.c2Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2Btn.Location = new System.Drawing.Point(154, 317);
            this.c2Btn.Name = "c2Btn";
            this.c2Btn.Size = new System.Drawing.Size(145, 115);
            this.c2Btn.TabIndex = 7;
            this.c2Btn.UseVisualStyleBackColor = true;
            this.c2Btn.Click += new System.EventHandler(this.boardBtn_Click);
            // 
            // c3Btn
            // 
            this.c3Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3Btn.Location = new System.Drawing.Point(305, 317);
            this.c3Btn.Name = "c3Btn";
            this.c3Btn.Size = new System.Drawing.Size(146, 115);
            this.c3Btn.TabIndex = 8;
            this.c3Btn.UseVisualStyleBackColor = true;
            this.c3Btn.Click += new System.EventHandler(this.boardBtn_Click);
            // 
            // newGameBtn
            // 
            this.newGameBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameBtn.Location = new System.Drawing.Point(3, 460);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(145, 46);
            this.newGameBtn.TabIndex = 9;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(305, 460);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(146, 46);
            this.stopBtn.TabIndex = 10;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // display
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.display, 3);
            this.display.Dock = System.Windows.Forms.DockStyle.Top;
            this.display.Enabled = false;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(3, 3);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(448, 45);
            this.display.TabIndex = 1;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 509);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(972, 1056);
            this.MinimumSize = new System.Drawing.Size(472, 556);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button b1Btn;
        private System.Windows.Forms.Button a1Btn;
        private System.Windows.Forms.Button a2Btn;
        private System.Windows.Forms.Button a3Btn;
        private System.Windows.Forms.Button b2Btn;
        private System.Windows.Forms.Button b3Btn;
        private System.Windows.Forms.Button c1Btn;
        private System.Windows.Forms.Button c2Btn;
        private System.Windows.Forms.Button c3Btn;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.TextBox display;
    }
}

