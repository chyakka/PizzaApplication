﻿namespace PizzaApplication
{
    partial class PizzaBaseForm
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
            this.thinBox = new System.Windows.Forms.GroupBox();
            this.thickBox = new System.Windows.Forms.GroupBox();
            this.deepBase = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThin = new System.Windows.Forms.Button();
            this.btnThick = new System.Windows.Forms.Button();
            this.btnDeep = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.thinBox.SuspendLayout();
            this.thickBox.SuspendLayout();
            this.deepBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // thinBox
            // 
            this.thinBox.Controls.Add(this.pictureBox1);
            this.thinBox.Controls.Add(this.btnThin);
            this.thinBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thinBox.Location = new System.Drawing.Point(12, 132);
            this.thinBox.Name = "thinBox";
            this.thinBox.Size = new System.Drawing.Size(357, 223);
            this.thinBox.TabIndex = 0;
            this.thinBox.TabStop = false;
            this.thinBox.Text = "Thin Base";
            // 
            // thickBox
            // 
            this.thickBox.Controls.Add(this.pictureBox2);
            this.thickBox.Controls.Add(this.btnThick);
            this.thickBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thickBox.Location = new System.Drawing.Point(389, 132);
            this.thickBox.Name = "thickBox";
            this.thickBox.Size = new System.Drawing.Size(357, 223);
            this.thickBox.TabIndex = 1;
            this.thickBox.TabStop = false;
            this.thickBox.Text = "Thick Base";
            // 
            // deepBase
            // 
            this.deepBase.Controls.Add(this.pictureBox3);
            this.deepBase.Controls.Add(this.btnDeep);
            this.deepBase.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deepBase.Location = new System.Drawing.Point(762, 132);
            this.deepBase.Name = "deepBase";
            this.deepBase.Size = new System.Drawing.Size(357, 223);
            this.deepBase.TabIndex = 2;
            this.deepBase.TabStop = false;
            this.deepBase.Text = "Deep Dish Base";
            this.deepBase.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rage Italic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(769, 80);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Your Desired Pizza Base";
            // 
            // btnThin
            // 
            this.btnThin.Location = new System.Drawing.Point(276, 194);
            this.btnThin.Name = "btnThin";
            this.btnThin.Size = new System.Drawing.Size(75, 23);
            this.btnThin.TabIndex = 0;
            this.btnThin.Text = "Select";
            this.btnThin.UseVisualStyleBackColor = true;
            // 
            // btnThick
            // 
            this.btnThick.Location = new System.Drawing.Point(276, 194);
            this.btnThick.Name = "btnThick";
            this.btnThick.Size = new System.Drawing.Size(75, 23);
            this.btnThick.TabIndex = 0;
            this.btnThick.Text = "Select";
            this.btnThick.UseVisualStyleBackColor = true;
            // 
            // btnDeep
            // 
            this.btnDeep.Location = new System.Drawing.Point(276, 194);
            this.btnDeep.Name = "btnDeep";
            this.btnDeep.Size = new System.Drawing.Size(75, 23);
            this.btnDeep.TabIndex = 0;
            this.btnDeep.Text = "Select";
            this.btnDeep.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::PizzaApplication.Properties.Resources.chicago1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(7, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(344, 144);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PizzaApplication.Properties.Resources.thick;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(7, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(344, 144);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PizzaApplication.Properties.Resources.thin;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(7, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 144);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(936, 524);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(182, 52);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "CONTINUE >";
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // PizzaBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 588);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deepBase);
            this.Controls.Add(this.thickBox);
            this.Controls.Add(this.thinBox);
            this.Name = "PizzaBaseForm";
            this.Text = "Select Pizza Base";
            this.thinBox.ResumeLayout(false);
            this.thickBox.ResumeLayout(false);
            this.deepBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox thinBox;
        private System.Windows.Forms.GroupBox thickBox;
        private System.Windows.Forms.GroupBox deepBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThin;
        private System.Windows.Forms.Button btnThick;
        private System.Windows.Forms.Button btnDeep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnContinue;
    }
}