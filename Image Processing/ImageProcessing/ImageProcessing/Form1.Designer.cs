
namespace ImageProcessing
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
            this.components = new System.ComponentModel.Container();
            this.display1 = new System.Windows.Forms.PictureBox();
            this.display2 = new System.Windows.Forms.PictureBox();
            this.load = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.copy = new System.Windows.Forms.Button();
            this.grey = new System.Windows.Forms.Button();
            this.Invert = new System.Windows.Forms.Button();
            this.histogram = new System.Windows.Forms.Button();
            this.Sepia = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OnCam = new System.Windows.Forms.Button();
            this.OffCam = new System.Windows.Forms.Button();
            this.OnGreyscale = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OffGreyscale = new System.Windows.Forms.Button();
            this.POffGrey = new System.Windows.Forms.Button();
            this.POnGrey = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.display3 = new System.Windows.Forms.PictureBox();
            this.loadBg = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.subtract = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.display1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display3)).BeginInit();
            this.SuspendLayout();
            // 
            // display1
            // 
            this.display1.Location = new System.Drawing.Point(42, 12);
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(225, 224);
            this.display1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.display1.TabIndex = 1;
            this.display1.TabStop = false;
            // 
            // display2
            // 
            this.display2.Location = new System.Drawing.Point(273, 12);
            this.display2.Name = "display2";
            this.display2.Size = new System.Drawing.Size(225, 224);
            this.display2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.display2.TabIndex = 2;
            this.display2.TabStop = false;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(68, 242);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(172, 42);
            this.load.TabIndex = 3;
            this.load.Text = "LOAD IMAGE";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(735, 159);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(102, 23);
            this.save.TabIndex = 4;
            this.save.Text = "SAVE IMAGE";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // copy
            // 
            this.copy.Location = new System.Drawing.Point(735, 12);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(102, 23);
            this.copy.TabIndex = 5;
            this.copy.Text = "COPY IMAGE";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // grey
            // 
            this.grey.Location = new System.Drawing.Point(735, 70);
            this.grey.Name = "grey";
            this.grey.Size = new System.Drawing.Size(102, 38);
            this.grey.TabIndex = 6;
            this.grey.Text = "GREYSCALE IMAGE";
            this.grey.UseVisualStyleBackColor = true;
            this.grey.Click += new System.EventHandler(this.grey_Click);
            // 
            // Invert
            // 
            this.Invert.Location = new System.Drawing.Point(735, 41);
            this.Invert.Name = "Invert";
            this.Invert.Size = new System.Drawing.Size(102, 23);
            this.Invert.TabIndex = 7;
            this.Invert.Text = "INVERT IMAGE";
            this.Invert.UseVisualStyleBackColor = true;
            this.Invert.Click += new System.EventHandler(this.Invert_Click);
            // 
            // histogram
            // 
            this.histogram.Location = new System.Drawing.Point(735, 114);
            this.histogram.Name = "histogram";
            this.histogram.Size = new System.Drawing.Size(102, 38);
            this.histogram.TabIndex = 8;
            this.histogram.Text = "HISTOGRAM OF IMAGE";
            this.histogram.UseVisualStyleBackColor = true;
            this.histogram.Click += new System.EventHandler(this.histogram_Click);
            // 
            // Sepia
            // 
            this.Sepia.Location = new System.Drawing.Point(735, 188);
            this.Sepia.Name = "Sepia";
            this.Sepia.Size = new System.Drawing.Size(102, 24);
            this.Sepia.TabIndex = 9;
            this.Sepia.Text = "SEPIA IMAGE";
            this.Sepia.UseVisualStyleBackColor = true;
            this.Sepia.Click += new System.EventHandler(this.Sepia_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // OnCam
            // 
            this.OnCam.Location = new System.Drawing.Point(42, 314);
            this.OnCam.Name = "OnCam";
            this.OnCam.Size = new System.Drawing.Size(362, 33);
            this.OnCam.TabIndex = 10;
            this.OnCam.Text = "TURN ON CAMERA";
            this.OnCam.UseVisualStyleBackColor = true;
            this.OnCam.Click += new System.EventHandler(this.OnCam_Click);
            // 
            // OffCam
            // 
            this.OffCam.Location = new System.Drawing.Point(410, 314);
            this.OffCam.Name = "OffCam";
            this.OffCam.Size = new System.Drawing.Size(319, 33);
            this.OffCam.TabIndex = 11;
            this.OffCam.Text = "TURN OFF CAMERA";
            this.OffCam.UseVisualStyleBackColor = true;
            this.OffCam.Click += new System.EventHandler(this.OffCam_Click);
            // 
            // OnGreyscale
            // 
            this.OnGreyscale.Location = new System.Drawing.Point(410, 353);
            this.OnGreyscale.Name = "OnGreyscale";
            this.OnGreyscale.Size = new System.Drawing.Size(152, 35);
            this.OnGreyscale.TabIndex = 12;
            this.OnGreyscale.Text = "GREYSCALE ON";
            this.OnGreyscale.UseVisualStyleBackColor = true;
            this.OnGreyscale.Click += new System.EventHandler(this.greyscale_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OffGreyscale
            // 
            this.OffGreyscale.Location = new System.Drawing.Point(578, 353);
            this.OffGreyscale.Name = "OffGreyscale";
            this.OffGreyscale.Size = new System.Drawing.Size(151, 35);
            this.OffGreyscale.TabIndex = 13;
            this.OffGreyscale.Text = "GREYSCALE OFF";
            this.OffGreyscale.UseVisualStyleBackColor = true;
            this.OffGreyscale.Click += new System.EventHandler(this.OffGreyscale_Click);
            // 
            // POffGrey
            // 
            this.POffGrey.Location = new System.Drawing.Point(228, 353);
            this.POffGrey.Name = "POffGrey";
            this.POffGrey.Size = new System.Drawing.Size(176, 35);
            this.POffGrey.TabIndex = 15;
            this.POffGrey.Text = "POINTER GREYSCALE OFF";
            this.POffGrey.UseVisualStyleBackColor = true;
            this.POffGrey.Click += new System.EventHandler(this.POffGrey_Click);
            // 
            // POnGrey
            // 
            this.POnGrey.Location = new System.Drawing.Point(42, 353);
            this.POnGrey.Name = "POnGrey";
            this.POnGrey.Size = new System.Drawing.Size(170, 35);
            this.POnGrey.TabIndex = 14;
            this.POnGrey.Text = "POINTER GREYSCALE ON";
            this.POnGrey.UseVisualStyleBackColor = true;
            this.POnGrey.Click += new System.EventHandler(this.POnGrey_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // display3
            // 
            this.display3.Location = new System.Drawing.Point(504, 12);
            this.display3.Name = "display3";
            this.display3.Size = new System.Drawing.Size(225, 224);
            this.display3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.display3.TabIndex = 16;
            this.display3.TabStop = false;
            // 
            // loadBg
            // 
            this.loadBg.Location = new System.Drawing.Point(291, 242);
            this.loadBg.Name = "loadBg";
            this.loadBg.Size = new System.Drawing.Size(172, 42);
            this.loadBg.TabIndex = 17;
            this.loadBg.Text = "Load Background";
            this.loadBg.UseVisualStyleBackColor = true;
            this.loadBg.Click += new System.EventHandler(this.loadBg_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(533, 243);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(172, 41);
            this.subtract.TabIndex = 18;
            this.subtract.Text = "Subtract";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 404);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.loadBg);
            this.Controls.Add(this.display3);
            this.Controls.Add(this.POffGrey);
            this.Controls.Add(this.POnGrey);
            this.Controls.Add(this.OffGreyscale);
            this.Controls.Add(this.OnGreyscale);
            this.Controls.Add(this.OffCam);
            this.Controls.Add(this.OnCam);
            this.Controls.Add(this.Sepia);
            this.Controls.Add(this.histogram);
            this.Controls.Add(this.Invert);
            this.Controls.Add(this.grey);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.save);
            this.Controls.Add(this.load);
            this.Controls.Add(this.display2);
            this.Controls.Add(this.display1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.display1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox display1;
        private System.Windows.Forms.PictureBox display2;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button grey;
        private System.Windows.Forms.Button Invert;
        private System.Windows.Forms.Button histogram;
        private System.Windows.Forms.Button Sepia;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button OnCam;
        private System.Windows.Forms.Button OffCam;
        private System.Windows.Forms.Button OnGreyscale;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button OffGreyscale;
        private System.Windows.Forms.Button POffGrey;
        private System.Windows.Forms.Button POnGrey;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox display3;
        private System.Windows.Forms.Button loadBg;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button subtract;
    }
}

