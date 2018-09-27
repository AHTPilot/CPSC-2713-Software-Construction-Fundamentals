namespace DormAndMealSelector
{
     partial class TotalCharges
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
               this.labelTotal = new System.Windows.Forms.Label();
               this.btnClose = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // labelTotal
               // 
               this.labelTotal.AutoSize = true;
               this.labelTotal.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelTotal.Location = new System.Drawing.Point(183, 80);
               this.labelTotal.Name = "labelTotal";
               this.labelTotal.Size = new System.Drawing.Size(275, 23);
               this.labelTotal.TabIndex = 0;
               this.labelTotal.Text = "Total Charges Per Semester";
               // 
               // btnClose
               // 
               this.btnClose.Location = new System.Drawing.Point(237, 178);
               this.btnClose.Name = "btnClose";
               this.btnClose.Size = new System.Drawing.Size(165, 23);
               this.btnClose.TabIndex = 2;
               this.btnClose.Text = "Close";
               this.btnClose.UseVisualStyleBackColor = true;
               this.btnClose.Click += new System.EventHandler(this.btnCalc_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(237, 134);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(37, 13);
               this.label1.TabIndex = 3;
               this.label1.Text = "Total: ";
               // 
               // TotalCharges
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(660, 397);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.btnClose);
               this.Controls.Add(this.labelTotal);
               this.Name = "TotalCharges";
               this.Text = "TotalCharges";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label labelTotal;
          public System.Windows.Forms.Button btnClose;
          public System.Windows.Forms.Label label1;
     }
}