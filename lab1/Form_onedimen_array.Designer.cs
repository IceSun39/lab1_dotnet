namespace lab1
{
    partial class Form_onedimen_array
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
            button_close = new Button();
            SuspendLayout();
            // 
            // button_close
            // 
            button_close.Location = new Point(341, 387);
            button_close.Name = "button_close";
            button_close.Size = new Size(75, 23);
            button_close.TabIndex = 0;
            button_close.Text = "Закрити";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // Form_onedimen_array
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_close);
            Name = "Form_onedimen_array";
            Text = "Form_onedimen_array";
            ResumeLayout(false);
        }

        #endregion

        private Button button_close;
    }
}