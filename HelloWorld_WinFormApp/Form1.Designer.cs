namespace HelloWorld_WinFormApp
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
            btnClickMe = new Button();
            lblHelloWorld = new Label();
            SuspendLayout();
            // 
            // btnClickMe
            // 
            btnClickMe.Location = new Point(305, 158);
            btnClickMe.Name = "btnClickMe";
            btnClickMe.Size = new Size(184, 76);
            btnClickMe.TabIndex = 0;
            btnClickMe.Text = "Click me!";
            btnClickMe.UseVisualStyleBackColor = true;
            btnClickMe.Click += button1_Click;
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.AutoSize = true;
            lblHelloWorld.Location = new Point(370, 237);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(50, 20);
            lblHelloWorld.TabIndex = 1;
            lblHelloWorld.Text = "label1";
            lblHelloWorld.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHelloWorld);
            Controls.Add(btnClickMe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClickMe;
        private Label lblHelloWorld;
    }
}
