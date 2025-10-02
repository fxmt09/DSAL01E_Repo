namespace LESSON5ACTIVITY
{
    partial class Lesson2_Example3_PrintFrm
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
            this.printDispLbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printDispLbox
            // 
            this.printDispLbox.BackColor = System.Drawing.Color.LimeGreen;
            this.printDispLbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printDispLbox.FormattingEnabled = true;
            this.printDispLbox.Location = new System.Drawing.Point(123, 50);
            this.printDispLbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.printDispLbox.Name = "printDispLbox";
            this.printDispLbox.Size = new System.Drawing.Size(381, 249);
            this.printDispLbox.TabIndex = 0;
            this.printDispLbox.SelectedIndexChanged += new System.EventHandler(this.printDispLbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "GREEN\'S FOOD ORDERING APPLICATION";
            // 
            // Lesson2_Example3_PrintFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImage = global::LESSON5ACTIVITY.Properties.Resources.park_cute_kawaii_lo_fi_background_summer_green_grass_and_trees_good_weather_2d_cartoon_landscape_illustration_lofi_aesthetic_wallpaper_desktop_japanese_anime_scenery_dreamy_vibes_vector;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printDispLbox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Lesson2_Example3_PrintFrm";
            this.Text = "Lesson2_Example3_PrintFrm";
            this.Load += new System.EventHandler(this.Lesson2_Example3_PrintFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox printDispLbox;
        private System.Windows.Forms.Label label1;
    }
}