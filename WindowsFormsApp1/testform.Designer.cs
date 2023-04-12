
namespace CrimeaCloud
{
    partial class testform
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
            this.flowLayCust1 = new CrimeaCloud.FlowLayCust();
            this.SuspendLayout();
            // 
            // flowLayCust1
            // 
            this.flowLayCust1.Location = new System.Drawing.Point(232, 12);
            this.flowLayCust1.Name = "flowLayCust1";
            this.flowLayCust1.Size = new System.Drawing.Size(562, 487);
            this.flowLayCust1.TabIndex = 8;
            // 
            // testform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 647);
            this.Controls.Add(this.flowLayCust1);
            this.Name = "testform";
            this.Text = "testform";
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayCust flowLayCust1;
    }
}