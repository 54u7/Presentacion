namespace Tarea_app
{
    partial class formPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPaint));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.btnFull = new System.Windows.Forms.Button();
            this.btnPaint = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pic = new System.Windows.Forms.PictureBox();
            this.nuevo = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.guardar);
            this.panel1.Controls.Add(this.nuevo);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Controls.Add(this.btnRectangle);
            this.panel1.Controls.Add(this.btnCircle);
            this.panel1.Controls.Add(this.btnEraser);
            this.panel1.Controls.Add(this.btnPencil);
            this.panel1.Controls.Add(this.btnFull);
            this.panel1.Controls.Add(this.btnPaint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1883, 99);
            this.panel1.TabIndex = 0;
            // 
            // btnLine
            // 
            this.btnLine.Image = global::Tarea_app.Properties.Resources.line;
            this.btnLine.Location = new System.Drawing.Point(756, 12);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(118, 84);
            this.btnLine.TabIndex = 6;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Image = global::Tarea_app.Properties.Resources.rectangle;
            this.btnRectangle.Location = new System.Drawing.Point(632, 12);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(118, 84);
            this.btnRectangle.TabIndex = 5;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Image = global::Tarea_app.Properties.Resources.circle;
            this.btnCircle.Location = new System.Drawing.Point(508, 12);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(118, 84);
            this.btnCircle.TabIndex = 4;
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.Image = global::Tarea_app.Properties.Resources.eraser;
            this.btnEraser.Location = new System.Drawing.Point(384, 12);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(118, 84);
            this.btnEraser.TabIndex = 3;
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.Image = global::Tarea_app.Properties.Resources.pencil;
            this.btnPencil.Location = new System.Drawing.Point(260, 12);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(118, 84);
            this.btnPencil.TabIndex = 2;
            this.btnPencil.UseVisualStyleBackColor = true;
            this.btnPencil.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFull
            // 
            this.btnFull.Image = global::Tarea_app.Properties.Resources.relleno1;
            this.btnFull.Location = new System.Drawing.Point(136, 12);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(118, 84);
            this.btnFull.TabIndex = 1;
            this.btnFull.UseVisualStyleBackColor = true;
            this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPaint.Image = global::Tarea_app.Properties.Resources.paleta_de_colores1;
            this.btnPaint.Location = new System.Drawing.Point(12, 12);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(118, 84);
            this.btnPaint.TabIndex = 0;
            this.btnPaint.UseVisualStyleBackColor = false;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1883, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pic
            // 
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 123);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1883, 717);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // nuevo
            // 
            this.nuevo.Location = new System.Drawing.Point(880, 57);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(108, 36);
            this.nuevo.TabIndex = 7;
            this.nuevo.Text = "Nuevo";
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(880, 12);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(108, 36);
            this.guardar.TabIndex = 8;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // formPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1883, 840);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formPaint";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btnFull;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Button guardar;
    }
}