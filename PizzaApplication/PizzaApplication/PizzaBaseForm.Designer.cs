namespace PizzaApplication
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
            this.lblThin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThin = new System.Windows.Forms.Button();
            this.thickBox = new System.Windows.Forms.GroupBox();
            this.lblThick = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnThick = new System.Windows.Forms.Button();
            this.deepBase = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnDeep = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblOrder = new System.Windows.Forms.Label();
            this.orderList = new System.Windows.Forms.ListBox();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.pizzabaseTab = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pizzaBaseLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.thinBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.thickBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.deepBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.pizzabaseTab.SuspendLayout();
            this.pizzaBaseLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // thinBox
            // 
            this.thinBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.thinBox.Controls.Add(this.lblThin);
            this.thinBox.Controls.Add(this.pictureBox1);
            this.thinBox.Controls.Add(this.btnThin);
            this.thinBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thinBox.Location = new System.Drawing.Point(3, 3);
            this.thinBox.Name = "thinBox";
            this.thinBox.Size = new System.Drawing.Size(357, 223);
            this.thinBox.TabIndex = 0;
            this.thinBox.TabStop = false;
            this.thinBox.Text = "Thin Base";
            // 
            // lblThin
            // 
            this.lblThin.AutoSize = true;
            this.lblThin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThin.Location = new System.Drawing.Point(7, 172);
            this.lblThin.Name = "lblThin";
            this.lblThin.Size = new System.Drawing.Size(155, 32);
            this.lblThin.TabIndex = 2;
            this.lblThin.Text = "Light, yet delicious pizza!\r\n£3.99";
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
            // btnThin
            // 
            this.btnThin.Location = new System.Drawing.Point(276, 194);
            this.btnThin.Name = "btnThin";
            this.btnThin.Size = new System.Drawing.Size(75, 23);
            this.btnThin.TabIndex = 0;
            this.btnThin.Text = "Select";
            this.btnThin.UseVisualStyleBackColor = true;
            this.btnThin.Click += new System.EventHandler(this.BtnThin_Click);
            // 
            // thickBox
            // 
            this.thickBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.thickBox.Controls.Add(this.lblThick);
            this.thickBox.Controls.Add(this.pictureBox2);
            this.thickBox.Controls.Add(this.btnThick);
            this.thickBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thickBox.Location = new System.Drawing.Point(3, 232);
            this.thickBox.Name = "thickBox";
            this.thickBox.Size = new System.Drawing.Size(357, 223);
            this.thickBox.TabIndex = 1;
            this.thickBox.TabStop = false;
            this.thickBox.Text = "Thick Base";
            // 
            // lblThick
            // 
            this.lblThick.AutoSize = true;
            this.lblThick.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThick.Location = new System.Drawing.Point(7, 172);
            this.lblThick.Name = "lblThick";
            this.lblThick.Size = new System.Drawing.Size(142, 32);
            this.lblThick.TabIndex = 2;
            this.lblThick.Text = "Thick and hearty pizza!\r\n£5.99";
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
            // btnThick
            // 
            this.btnThick.Location = new System.Drawing.Point(276, 194);
            this.btnThick.Name = "btnThick";
            this.btnThick.Size = new System.Drawing.Size(75, 23);
            this.btnThick.TabIndex = 0;
            this.btnThick.Text = "Select";
            this.btnThick.UseVisualStyleBackColor = true;
            this.btnThick.Click += new System.EventHandler(this.BtnThick_Click);
            // 
            // deepBase
            // 
            this.deepBase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deepBase.Controls.Add(this.label2);
            this.deepBase.Controls.Add(this.pictureBox3);
            this.deepBase.Controls.Add(this.btnDeep);
            this.deepBase.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deepBase.Location = new System.Drawing.Point(366, 3);
            this.deepBase.Name = "deepBase";
            this.deepBase.Size = new System.Drawing.Size(357, 223);
            this.deepBase.TabIndex = 2;
            this.deepBase.TabStop = false;
            this.deepBase.Text = "Deep Dish Base";
            this.deepBase.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chicago pizza, baked for maximum taste!\r\n£6.99";
            this.label2.UseWaitCursor = true;
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
            this.pictureBox3.UseWaitCursor = true;
            // 
            // btnDeep
            // 
            this.btnDeep.Location = new System.Drawing.Point(276, 194);
            this.btnDeep.Name = "btnDeep";
            this.btnDeep.Size = new System.Drawing.Size(75, 23);
            this.btnDeep.TabIndex = 0;
            this.btnDeep.Text = "Select";
            this.btnDeep.UseVisualStyleBackColor = true;
            this.btnDeep.UseWaitCursor = true;
            this.btnDeep.Click += new System.EventHandler(this.BtnDeep_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinue.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(936, 524);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(182, 52);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "CONTINUE >";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrder.AutoSize = true;
            this.lblOrder.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblOrder.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(1013, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(118, 29);
            this.lblOrder.TabIndex = 5;
            this.lblOrder.Text = "My Order";
            this.lblOrder.MouseEnter += new System.EventHandler(this.LblOrder_MouseEnter);
            this.lblOrder.MouseLeave += new System.EventHandler(this.LblOrder_MouseLeave);
            // 
            // orderList
            // 
            this.orderList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orderList.FormattingEnabled = true;
            this.orderList.Location = new System.Drawing.Point(956, 29);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(175, 160);
            this.orderList.TabIndex = 6;
            this.orderList.Visible = false;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.pizzabaseTab);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Controls.Add(this.tabPage3);
            this.mainTabControl.Controls.Add(this.tabPage4);
            this.mainTabControl.Location = new System.Drawing.Point(1, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1130, 588);
            this.mainTabControl.TabIndex = 0;
            // 
            // pizzabaseTab
            // 
            this.pizzabaseTab.Controls.Add(this.pizzaBaseLayoutPanel);
            this.pizzabaseTab.Location = new System.Drawing.Point(4, 22);
            this.pizzabaseTab.Name = "pizzabaseTab";
            this.pizzabaseTab.Padding = new System.Windows.Forms.Padding(3);
            this.pizzabaseTab.Size = new System.Drawing.Size(1122, 562);
            this.pizzabaseTab.TabIndex = 0;
            this.pizzabaseTab.Text = "Pizza Base";
            this.pizzabaseTab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1122, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1122, 562);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1122, 562);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pizzaBaseLayoutPanel
            // 
            this.pizzaBaseLayoutPanel.Controls.Add(this.thinBox);
            this.pizzaBaseLayoutPanel.Controls.Add(this.deepBase);
            this.pizzaBaseLayoutPanel.Controls.Add(this.thickBox);
            this.pizzaBaseLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.pizzaBaseLayoutPanel.Name = "pizzaBaseLayoutPanel";
            this.pizzaBaseLayoutPanel.Size = new System.Drawing.Size(928, 489);
            this.pizzaBaseLayoutPanel.TabIndex = 3;
            // 
            // PizzaBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 588);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.orderList);
            this.Controls.Add(this.mainTabControl);
            this.Name = "PizzaBaseForm";
            this.Text = "Select Your Order";
            this.Load += new System.EventHandler(this.PizzaBaseForm_Load);
            this.thinBox.ResumeLayout(false);
            this.thinBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.thickBox.ResumeLayout(false);
            this.thickBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.deepBase.ResumeLayout(false);
            this.deepBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.pizzabaseTab.ResumeLayout(false);
            this.pizzaBaseLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox thinBox;
        private System.Windows.Forms.GroupBox thickBox;
        private System.Windows.Forms.GroupBox deepBase;
        private System.Windows.Forms.Button btnThin;
        private System.Windows.Forms.Button btnThick;
        private System.Windows.Forms.Button btnDeep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblThin;
        private System.Windows.Forms.Label lblThick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.ListBox orderList;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage pizzabaseTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.FlowLayoutPanel pizzaBaseLayoutPanel;
    }
}