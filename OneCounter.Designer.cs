
namespace OneCounter
{
    partial class OneCounter
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterButton = new System.Windows.Forms.Button();
            this.tittleLabel = new System.Windows.Forms.Label();
            this.inputToTextBox = new System.Windows.Forms.TextBox();
            this.inputFromTextBox = new System.Windows.Forms.TextBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(104, 188);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(125, 39);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "Calculate";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.OnEnterButtonClicked);
            // 
            // tittleLabel
            // 
            this.tittleLabel.AutoSize = true;
            this.tittleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittleLabel.Location = new System.Drawing.Point(76, 45);
            this.tittleLabel.Name = "tittleLabel";
            this.tittleLabel.Size = new System.Drawing.Size(196, 31);
            this.tittleLabel.TabIndex = 1;
            this.tittleLabel.Text = "Enter Numbers";
            // 
            // inputToTextBox
            // 
            this.inputToTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputToTextBox.Location = new System.Drawing.Point(186, 107);
            this.inputToTextBox.Name = "inputToTextBox";
            this.inputToTextBox.Size = new System.Drawing.Size(95, 30);
            this.inputToTextBox.TabIndex = 2;
            this.inputToTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputFromTextBox
            // 
            this.inputFromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFromTextBox.Location = new System.Drawing.Point(63, 107);
            this.inputFromTextBox.Name = "inputFromTextBox";
            this.inputFromTextBox.Size = new System.Drawing.Size(86, 30);
            this.inputFromTextBox.TabIndex = 3;
            this.inputFromTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(91, 140);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(36, 17);
            this.fromLabel.TabIndex = 4;
            this.fromLabel.Text = "from";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(218, 140);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(20, 17);
            this.toLabel.TabIndex = 5;
            this.toLabel.Text = "to";
            // 
            // OneCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 281);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.inputFromTextBox);
            this.Controls.Add(this.inputToTextBox);
            this.Controls.Add(this.tittleLabel);
            this.Controls.Add(this.enterButton);
            this.Name = "OneCounter";
            this.Text = "One Counter";
            this.Load += new System.EventHandler(this.OneCounter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label tittleLabel;
        private System.Windows.Forms.TextBox inputToTextBox;
        private System.Windows.Forms.TextBox inputFromTextBox;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
    }
}

