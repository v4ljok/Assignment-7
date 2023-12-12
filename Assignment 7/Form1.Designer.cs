namespace Assignment_7
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            openFileDialog1 = new OpenFileDialog();
            btnLoadStudentAnswers = new Button();
            btnCheckAnswers = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLoadStudentAnswers
            // 
            btnLoadStudentAnswers.Font = new Font("Segoe Print", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoadStudentAnswers.Location = new Point(1, 20);
            btnLoadStudentAnswers.Margin = new Padding(3, 2, 3, 2);
            btnLoadStudentAnswers.Name = "btnLoadStudentAnswers";
            btnLoadStudentAnswers.Size = new Size(176, 55);
            btnLoadStudentAnswers.TabIndex = 0;
            btnLoadStudentAnswers.Text = "Choose File";
            btnLoadStudentAnswers.UseVisualStyleBackColor = true;
            btnLoadStudentAnswers.Click += btnLoadStudentAnswers_Click;
            // 
            // btnCheckAnswers
            // 
            btnCheckAnswers.Font = new Font("Segoe Print", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCheckAnswers.Location = new Point(128, 270);
            btnCheckAnswers.Name = "btnCheckAnswers";
            btnCheckAnswers.Size = new Size(119, 56);
            btnCheckAnswers.TabIndex = 1;
            btnCheckAnswers.Text = "check";
            btnCheckAnswers.UseVisualStyleBackColor = true;
            btnCheckAnswers.Click += btnCheckAnswers_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(183, 24);
            label1.Name = "label1";
            label1.Size = new Size(208, 47);
            label1.TabIndex = 2;
            label1.Text = "No file chosen";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(384, 338);
            Controls.Add(label1);
            Controls.Add(btnCheckAnswers);
            Controls.Add(btnLoadStudentAnswers);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Driver’s License Exam";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button btnLoadStudentAnswers;
        private Button btnCheckAnswers;
        private Label label1;
    }
}