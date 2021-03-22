
namespace lab_1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbThickness = new System.Windows.Forms.ComboBox();
            this.btnDemo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEllips = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnTriandle = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.pbDrawingBoard = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbThickness);
            this.panel1.Controls.Add(this.btnDemo);
            this.panel1.Controls.Add(this.pbColor);
            this.panel1.Controls.Add(this.btnRedo);
            this.panel1.Controls.Add(this.btnUndo);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnEllips);
            this.panel1.Controls.Add(this.btnSquare);
            this.panel1.Controls.Add(this.btnCircle);
            this.panel1.Controls.Add(this.btnTriandle);
            this.panel1.Controls.Add(this.btnLink);
            this.panel1.Controls.Add(this.btnRectangle);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 90);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbThickness
            // 
            this.cbThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbThickness.FormattingEnabled = true;
            this.cbThickness.Location = new System.Drawing.Point(626, 24);
            this.cbThickness.Name = "cbThickness";
            this.cbThickness.Size = new System.Drawing.Size(69, 33);
            this.cbThickness.TabIndex = 7;
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(530, 17);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(75, 50);
            this.btnDemo.TabIndex = 10;
            this.btnDemo.Text = "Lab-1";
            this.btnDemo.UseVisualStyleBackColor = true;
            // 
            // btnRedo
            // 
            this.btnRedo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRedo.Location = new System.Drawing.Point(960, 8);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(75, 45);
            this.btnRedo.TabIndex = 8;
            this.btnRedo.Text = "Next";
            this.btnRedo.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUndo.Location = new System.Drawing.Point(879, 8);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 45);
            this.btnUndo.TabIndex = 7;
            this.btnUndo.Text = "Prev";
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // pbColor
            // 
            this.pbColor.BackColor = System.Drawing.Color.Black;
            this.pbColor.Location = new System.Drawing.Point(699, 8);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(80, 75);
            this.pbColor.TabIndex = 9;
            this.pbColor.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Image = global::lab_1.Properties.Resources.clean;
            this.btnClear.Location = new System.Drawing.Point(785, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 75);
            this.btnClear.TabIndex = 6;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEllips
            // 
            this.btnEllips.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEllips.Image = global::lab_1.Properties.Resources.ellipse;
            this.btnEllips.Location = new System.Drawing.Point(433, 8);
            this.btnEllips.Name = "btnEllips";
            this.btnEllips.Size = new System.Drawing.Size(80, 75);
            this.btnEllips.TabIndex = 5;
            this.btnEllips.UseVisualStyleBackColor = true;
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSquare.Image = global::lab_1.Properties.Resources.square;
            this.btnSquare.Location = new System.Drawing.Point(347, 8);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(80, 75);
            this.btnSquare.TabIndex = 4;
            this.btnSquare.UseVisualStyleBackColor = true;
            // 
            // btnCircle
            // 
            this.btnCircle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCircle.Image = global::lab_1.Properties.Resources.circumference;
            this.btnCircle.Location = new System.Drawing.Point(261, 8);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(80, 75);
            this.btnCircle.TabIndex = 3;
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTriandle
            // 
            this.btnTriandle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTriandle.Image = global::lab_1.Properties.Resources.triangle;
            this.btnTriandle.Location = new System.Drawing.Point(175, 8);
            this.btnTriandle.Name = "btnTriandle";
            this.btnTriandle.Size = new System.Drawing.Size(80, 75);
            this.btnTriandle.TabIndex = 2;
            this.btnTriandle.UseVisualStyleBackColor = true;
            // 
            // btnLink
            // 
            this.btnLink.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLink.Image = global::lab_1.Properties.Resources.diagonal_line;
            this.btnLink.Location = new System.Drawing.Point(89, 8);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(80, 75);
            this.btnLink.TabIndex = 1;
            this.btnLink.UseVisualStyleBackColor = true;
            // 
            // btnRectangle
            // 
            this.btnRectangle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRectangle.Image = global::lab_1.Properties.Resources.ratio;
            this.btnRectangle.Location = new System.Drawing.Point(3, 8);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(80, 75);
            this.btnRectangle.TabIndex = 0;
            this.btnRectangle.UseVisualStyleBackColor = true;
            // 
            // pbDrawingBoard
            // 
            this.pbDrawingBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDrawingBoard.Location = new System.Drawing.Point(3, 122);
            this.pbDrawingBoard.Name = "pbDrawingBoard";
            this.pbDrawingBoard.Size = new System.Drawing.Size(1044, 446);
            this.pbDrawingBoard.TabIndex = 0;
            this.pbDrawingBoard.TabStop = false;
            this.pbDrawingBoard.Click += new System.EventHandler(this.pbDrawingBoard_Click);
            this.pbDrawingBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pbDrawingBoard_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbDrawingBoard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDrawingBoard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEllips;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnTriandle;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.ComboBox cbThickness;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnUndo;
    }
}

