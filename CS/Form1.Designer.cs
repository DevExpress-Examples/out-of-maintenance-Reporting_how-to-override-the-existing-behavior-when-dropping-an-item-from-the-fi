namespace WindowsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            ((System.ComponentModel.ISupportInitialize)(this.xrDesignPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // xrDesignPanel
            // 
            this.xrDesignPanel.Location = new System.Drawing.Point(92, 76);
            this.xrDesignPanel.Size = new System.Drawing.Size(434, 445);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 544);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.xrDesignPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.xrDesignPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

