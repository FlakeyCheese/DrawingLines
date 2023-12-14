namespace DrawingLines
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
            this.txt_angle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_length = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_draw = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_colour = new System.Windows.Forms.Button();
            this.txt_newX = new System.Windows.Forms.TextBox();
            this.txt_newY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_changeXY = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_circle_radius = new System.Windows.Forms.TextBox();
            this.btn_circle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_X = new System.Windows.Forms.Label();
            this.lbl_Y = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_angle
            // 
            this.txt_angle.Location = new System.Drawing.Point(223, 489);
            this.txt_angle.Name = "txt_angle";
            this.txt_angle.Size = new System.Drawing.Size(100, 20);
            this.txt_angle.TabIndex = 0;
            this.txt_angle.Text = "90";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "angle";
            // 
            // txt_length
            // 
            this.txt_length.Location = new System.Drawing.Point(223, 533);
            this.txt_length.Name = "txt_length";
            this.txt_length.Size = new System.Drawing.Size(100, 20);
            this.txt_length.TabIndex = 0;
            this.txt_length.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "length";
            // 
            // btn_draw
            // 
            this.btn_draw.Location = new System.Drawing.Point(223, 575);
            this.btn_draw.Name = "btn_draw";
            this.btn_draw.Size = new System.Drawing.Size(75, 23);
            this.btn_draw.TabIndex = 2;
            this.btn_draw.Text = "Draw Line";
            this.btn_draw.UseVisualStyleBackColor = true;
            this.btn_draw.Click += new System.EventHandler(this.btn_draw_Click);
            // 
            // btn_colour
            // 
            this.btn_colour.Location = new System.Drawing.Point(334, 575);
            this.btn_colour.Name = "btn_colour";
            this.btn_colour.Size = new System.Drawing.Size(86, 23);
            this.btn_colour.TabIndex = 3;
            this.btn_colour.Text = "Change Colour";
            this.btn_colour.UseVisualStyleBackColor = true;
            this.btn_colour.Click += new System.EventHandler(this.btn_colour_Click);
            // 
            // txt_newX
            // 
            this.txt_newX.Location = new System.Drawing.Point(932, 489);
            this.txt_newX.Name = "txt_newX";
            this.txt_newX.Size = new System.Drawing.Size(100, 20);
            this.txt_newX.TabIndex = 0;
            this.txt_newX.Text = "0";
            // 
            // txt_newY
            // 
            this.txt_newY.Location = new System.Drawing.Point(932, 533);
            this.txt_newY.Name = "txt_newY";
            this.txt_newY.Size = new System.Drawing.Size(100, 20);
            this.txt_newY.TabIndex = 0;
            this.txt_newY.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(887, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "New X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(887, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "New Y";
            // 
            // btn_changeXY
            // 
            this.btn_changeXY.Location = new System.Drawing.Point(932, 575);
            this.btn_changeXY.Name = "btn_changeXY";
            this.btn_changeXY.Size = new System.Drawing.Size(75, 23);
            this.btn_changeXY.TabIndex = 2;
            this.btn_changeXY.Text = "Move Point";
            this.btn_changeXY.UseVisualStyleBackColor = true;
            this.btn_changeXY.Click += new System.EventHandler(this.btn_changeXY_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Circle Radius";
            // 
            // txt_circle_radius
            // 
            this.txt_circle_radius.Location = new System.Drawing.Point(657, 526);
            this.txt_circle_radius.Name = "txt_circle_radius";
            this.txt_circle_radius.Size = new System.Drawing.Size(100, 20);
            this.txt_circle_radius.TabIndex = 5;
            this.txt_circle_radius.Text = "100";
            // 
            // btn_circle
            // 
            this.btn_circle.Location = new System.Drawing.Point(669, 575);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(75, 23);
            this.btn_circle.TabIndex = 6;
            this.btn_circle.Text = "Draw Circle";
            this.btn_circle.UseVisualStyleBackColor = true;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(932, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Current X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(932, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Current Y";
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Location = new System.Drawing.Point(997, 13);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(25, 13);
            this.lbl_X.TabIndex = 7;
            this.lbl_X.Text = "300";
            // 
            // lbl_Y
            // 
            this.lbl_Y.AutoSize = true;
            this.lbl_Y.Location = new System.Drawing.Point(997, 42);
            this.lbl_Y.Name = "lbl_Y";
            this.lbl_Y.Size = new System.Drawing.Size(25, 13);
            this.lbl_Y.TabIndex = 7;
            this.lbl_Y.Text = "300";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 636);
            this.Controls.Add(this.lbl_Y);
            this.Controls.Add(this.lbl_X);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_circle);
            this.Controls.Add(this.txt_circle_radius);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_colour);
            this.Controls.Add(this.btn_changeXY);
            this.Controls.Add(this.btn_draw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_newY);
            this.Controls.Add(this.txt_newX);
            this.Controls.Add(this.txt_length);
            this.Controls.Add(this.txt_angle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_angle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_length;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_draw;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_colour;
        private System.Windows.Forms.TextBox txt_newX;
        private System.Windows.Forms.TextBox txt_newY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_changeXY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_circle_radius;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Label lbl_Y;
    }
}

