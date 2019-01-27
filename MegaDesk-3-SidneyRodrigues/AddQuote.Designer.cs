namespace MegaDesk_3_SidneyRodrigues
{
    partial class AddQuote
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
            this.btnSave = new System.Windows.Forms.Button();
            this.custumerName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.Label();
            this.textDepth = new System.Windows.Forms.TextBox();
            this.depth = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.Label();
            this.drawers = new System.Windows.Forms.Label();
            this.comboDrawers = new System.Windows.Forms.ComboBox();
            this.comboMaterial = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.Label();
            this.rushBox = new System.Windows.Forms.CheckBox();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio5 = new System.Windows.Forms.RadioButton();
            this.radio7 = new System.Windows.Forms.RadioButton();
            this.finalPrice = new System.Windows.Forms.TextBox();
            this.labelFinal = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(411, 352);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 50);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // custumerName
            // 
            this.custumerName.AutoSize = true;
            this.custumerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custumerName.Location = new System.Drawing.Point(41, 73);
            this.custumerName.Name = "custumerName";
            this.custumerName.Size = new System.Drawing.Size(144, 22);
            this.custumerName.TabIndex = 2;
            this.custumerName.Text = "Customer Name:";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(191, 70);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(325, 27);
            this.textName.TabIndex = 3;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // textWidth
            // 
            this.textWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textWidth.Location = new System.Drawing.Point(191, 112);
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(110, 27);
            this.textWidth.TabIndex = 5;
            this.textWidth.TextChanged += new System.EventHandler(this.textWidth_TextChanged);
            this.textWidth.Validating += new System.ComponentModel.CancelEventHandler(this.textWidth_Validating);
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width.Location = new System.Drawing.Point(78, 115);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(107, 22);
            this.width.TabIndex = 4;
            this.width.Text = "Desk Width:";
            // 
            // textDepth
            // 
            this.textDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDepth.Location = new System.Drawing.Point(406, 112);
            this.textDepth.Name = "textDepth";
            this.textDepth.Size = new System.Drawing.Size(110, 27);
            this.textDepth.TabIndex = 7;
            this.textDepth.TextChanged += new System.EventHandler(this.textDepth_TextChanged);
            this.textDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDepth_KeyPress);
            this.textDepth.Validating += new System.ComponentModel.CancelEventHandler(this.textDepth_Validating);
            this.textDepth.Validated += new System.EventHandler(this.textDepth_Validated);
            // 
            // depth
            // 
            this.depth.AutoSize = true;
            this.depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depth.Location = new System.Drawing.Point(341, 115);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(63, 22);
            this.depth.TabIndex = 6;
            this.depth.Text = "Depth:";
            this.depth.Click += new System.EventHandler(this.label1_Click);
            // 
            // material
            // 
            this.material.AutoSize = true;
            this.material.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.material.Location = new System.Drawing.Point(327, 158);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(78, 22);
            this.material.TabIndex = 10;
            this.material.Text = "Material:";
            // 
            // drawers
            // 
            this.drawers.AutoSize = true;
            this.drawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawers.Location = new System.Drawing.Point(99, 157);
            this.drawers.Name = "drawers";
            this.drawers.Size = new System.Drawing.Size(82, 22);
            this.drawers.TabIndex = 8;
            this.drawers.Text = "Drawers:";
            this.drawers.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboDrawers
            // 
            this.comboDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDrawers.FormattingEnabled = true;
            this.comboDrawers.Location = new System.Drawing.Point(191, 154);
            this.comboDrawers.Name = "comboDrawers";
            this.comboDrawers.Size = new System.Drawing.Size(110, 28);
            this.comboDrawers.TabIndex = 13;
            // 
            // comboMaterial
            // 
            this.comboMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMaterial.FormattingEnabled = true;
            this.comboMaterial.Location = new System.Drawing.Point(406, 155);
            this.comboMaterial.Name = "comboMaterial";
            this.comboMaterial.Size = new System.Drawing.Size(110, 28);
            this.comboMaterial.TabIndex = 14;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(128, 37);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(53, 22);
            this.date.TabIndex = 15;
            this.date.Text = "Date:";
            this.date.Click += new System.EventHandler(this.label4_Click);
            // 
            // rushBox
            // 
            this.rushBox.AutoSize = true;
            this.rushBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushBox.Location = new System.Drawing.Point(191, 204);
            this.rushBox.Name = "rushBox";
            this.rushBox.Size = new System.Drawing.Size(119, 24);
            this.rushBox.TabIndex = 16;
            this.rushBox.Text = "Rush Order?";
            this.rushBox.UseVisualStyleBackColor = true;
            this.rushBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio3.Location = new System.Drawing.Point(191, 234);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(76, 24);
            this.radio3.TabIndex = 18;
            this.radio3.TabStop = true;
            this.radio3.Text = "3 Days";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // radio5
            // 
            this.radio5.AutoSize = true;
            this.radio5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio5.Location = new System.Drawing.Point(191, 264);
            this.radio5.Name = "radio5";
            this.radio5.Size = new System.Drawing.Size(76, 24);
            this.radio5.TabIndex = 19;
            this.radio5.TabStop = true;
            this.radio5.Text = "5 Days";
            this.radio5.UseVisualStyleBackColor = true;
            // 
            // radio7
            // 
            this.radio7.AutoSize = true;
            this.radio7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio7.Location = new System.Drawing.Point(191, 294);
            this.radio7.Name = "radio7";
            this.radio7.Size = new System.Drawing.Size(76, 24);
            this.radio7.TabIndex = 20;
            this.radio7.TabStop = true;
            this.radio7.Text = "7 Days";
            this.radio7.UseVisualStyleBackColor = true;
            // 
            // finalPrice
            // 
            this.finalPrice.Enabled = false;
            this.finalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalPrice.Location = new System.Drawing.Point(411, 292);
            this.finalPrice.Name = "finalPrice";
            this.finalPrice.Size = new System.Drawing.Size(110, 27);
            this.finalPrice.TabIndex = 22;
            // 
            // labelFinal
            // 
            this.labelFinal.AutoSize = true;
            this.labelFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinal.Location = new System.Drawing.Point(305, 294);
            this.labelFinal.Name = "labelFinal";
            this.labelFinal.Size = new System.Drawing.Size(100, 22);
            this.labelFinal.TabIndex = 21;
            this.labelFinal.Text = "FInal Price:";
            this.labelFinal.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Location = new System.Drawing.Point(278, 352);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(110, 50);
            this.btnGoBack.TabIndex = 23;
            this.btnGoBack.Text = "Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 439);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.finalPrice);
            this.Controls.Add(this.labelFinal);
            this.Controls.Add(this.radio7);
            this.Controls.Add(this.radio5);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.rushBox);
            this.Controls.Add(this.date);
            this.Controls.Add(this.comboMaterial);
            this.Controls.Add(this.comboDrawers);
            this.Controls.Add(this.material);
            this.Controls.Add(this.drawers);
            this.Controls.Add(this.textDepth);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.textWidth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.custumerName);
            this.Controls.Add(this.btnSave);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label custumerName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.TextBox textDepth;
        private System.Windows.Forms.Label depth;
        private System.Windows.Forms.Label material;
        private System.Windows.Forms.Label drawers;
        private System.Windows.Forms.ComboBox comboDrawers;
        private System.Windows.Forms.ComboBox comboMaterial;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.CheckBox rushBox;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio5;
        private System.Windows.Forms.RadioButton radio7;
        private System.Windows.Forms.TextBox finalPrice;
        private System.Windows.Forms.Label labelFinal;
        private System.Windows.Forms.Button btnGoBack;
    }
}