namespace Symulator_Latarki
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.buttonON = new System.Windows.Forms.Button();
            this.buttonOFF = new System.Windows.Forms.Button();
            this.buttonRemoveTheBattery = new System.Windows.Forms.Button();
            this.buttonInsertTheBatteries = new System.Windows.Forms.Button();
            this.buttonInsertLightBulb = new System.Windows.Forms.Button();
            this.buttonReplaceTheBulb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBattery1 = new System.Windows.Forms.TextBox();
            this.textBoxBattery2 = new System.Windows.Forms.TextBox();
            this.textBoxBattery3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSelectBulbPower = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(443, 115);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.ReadOnly = true;
            this.textBoxState.Size = new System.Drawing.Size(174, 22);
            this.textBoxState.TabIndex = 0;
            // 
            // buttonON
            // 
            this.buttonON.Location = new System.Drawing.Point(175, 49);
            this.buttonON.Name = "buttonON";
            this.buttonON.Size = new System.Drawing.Size(124, 63);
            this.buttonON.TabIndex = 1;
            this.buttonON.Text = "ON";
            this.buttonON.UseVisualStyleBackColor = true;
            this.buttonON.Click += new System.EventHandler(this.buttonON_Click);
            // 
            // buttonOFF
            // 
            this.buttonOFF.Location = new System.Drawing.Point(32, 49);
            this.buttonOFF.Name = "buttonOFF";
            this.buttonOFF.Size = new System.Drawing.Size(124, 63);
            this.buttonOFF.TabIndex = 2;
            this.buttonOFF.Text = "OFF";
            this.buttonOFF.UseVisualStyleBackColor = true;
            this.buttonOFF.Click += new System.EventHandler(this.buttonOFF_Click);
            // 
            // buttonRemoveTheBattery
            // 
            this.buttonRemoveTheBattery.Location = new System.Drawing.Point(916, 306);
            this.buttonRemoveTheBattery.Name = "buttonRemoveTheBattery";
            this.buttonRemoveTheBattery.Size = new System.Drawing.Size(124, 63);
            this.buttonRemoveTheBattery.TabIndex = 3;
            this.buttonRemoveTheBattery.Text = "Remove The Battery";
            this.buttonRemoveTheBattery.UseVisualStyleBackColor = true;
            this.buttonRemoveTheBattery.Click += new System.EventHandler(this.buttonRemoveTheBattery_Click);
            // 
            // buttonInsertTheBatteries
            // 
            this.buttonInsertTheBatteries.Location = new System.Drawing.Point(779, 306);
            this.buttonInsertTheBatteries.Name = "buttonInsertTheBatteries";
            this.buttonInsertTheBatteries.Size = new System.Drawing.Size(124, 63);
            this.buttonInsertTheBatteries.TabIndex = 4;
            this.buttonInsertTheBatteries.Text = "Insert the Battery";
            this.buttonInsertTheBatteries.UseVisualStyleBackColor = true;
            this.buttonInsertTheBatteries.Click += new System.EventHandler(this.buttonInsertTheBatteries_Click);
            // 
            // buttonInsertLightBulb
            // 
            this.buttonInsertLightBulb.Location = new System.Drawing.Point(32, 134);
            this.buttonInsertLightBulb.Name = "buttonInsertLightBulb";
            this.buttonInsertLightBulb.Size = new System.Drawing.Size(124, 63);
            this.buttonInsertLightBulb.TabIndex = 5;
            this.buttonInsertLightBulb.Text = "Insert a light bulb";
            this.buttonInsertLightBulb.UseVisualStyleBackColor = true;
            this.buttonInsertLightBulb.Click += new System.EventHandler(this.buttonInsertLightBulb_Click);
            // 
            // buttonReplaceTheBulb
            // 
            this.buttonReplaceTheBulb.Location = new System.Drawing.Point(32, 400);
            this.buttonReplaceTheBulb.Name = "buttonReplaceTheBulb";
            this.buttonReplaceTheBulb.Size = new System.Drawing.Size(124, 63);
            this.buttonReplaceTheBulb.TabIndex = 6;
            this.buttonReplaceTheBulb.Text = "Replace the bulb";
            this.buttonReplaceTheBulb.UseVisualStyleBackColor = true;
            this.buttonReplaceTheBulb.Click += new System.EventHandler(this.buttonReplaceTheBulb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Flashlight State";
            // 
            // textBoxBattery1
            // 
            this.textBoxBattery1.Location = new System.Drawing.Point(913, 115);
            this.textBoxBattery1.Name = "textBoxBattery1";
            this.textBoxBattery1.ReadOnly = true;
            this.textBoxBattery1.Size = new System.Drawing.Size(100, 22);
            this.textBoxBattery1.TabIndex = 8;
            // 
            // textBoxBattery2
            // 
            this.textBoxBattery2.Location = new System.Drawing.Point(913, 175);
            this.textBoxBattery2.Name = "textBoxBattery2";
            this.textBoxBattery2.ReadOnly = true;
            this.textBoxBattery2.Size = new System.Drawing.Size(100, 22);
            this.textBoxBattery2.TabIndex = 9;
            // 
            // textBoxBattery3
            // 
            this.textBoxBattery3.Location = new System.Drawing.Point(913, 229);
            this.textBoxBattery3.Name = "textBoxBattery3";
            this.textBoxBattery3.ReadOnly = true;
            this.textBoxBattery3.Size = new System.Drawing.Size(100, 22);
            this.textBoxBattery3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(913, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Baterry1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(913, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Baterry2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(913, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Baterry3";
            // 
            // textBoxSelectBulbPower
            // 
            this.textBoxSelectBulbPower.Location = new System.Drawing.Point(32, 359);
            this.textBoxSelectBulbPower.Name = "textBoxSelectBulbPower";
            this.textBoxSelectBulbPower.Size = new System.Drawing.Size(100, 22);
            this.textBoxSelectBulbPower.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Select Bulb Power (1-10)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 579);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSelectBulbPower);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBattery3);
            this.Controls.Add(this.textBoxBattery2);
            this.Controls.Add(this.textBoxBattery1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReplaceTheBulb);
            this.Controls.Add(this.buttonInsertLightBulb);
            this.Controls.Add(this.buttonInsertTheBatteries);
            this.Controls.Add(this.buttonRemoveTheBattery);
            this.Controls.Add(this.buttonOFF);
            this.Controls.Add(this.buttonON);
            this.Controls.Add(this.textBoxState);
            this.Name = "Form1";
            this.Text = "Symulator Latarki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Button buttonON;
        private System.Windows.Forms.Button buttonOFF;
        private System.Windows.Forms.Button buttonRemoveTheBattery;
        private System.Windows.Forms.Button buttonInsertTheBatteries;
        private System.Windows.Forms.Button buttonInsertLightBulb;
        private System.Windows.Forms.Button buttonReplaceTheBulb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBattery1;
        private System.Windows.Forms.TextBox textBoxBattery2;
        private System.Windows.Forms.TextBox textBoxBattery3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSelectBulbPower;
        private System.Windows.Forms.Label label5;
    }
}

