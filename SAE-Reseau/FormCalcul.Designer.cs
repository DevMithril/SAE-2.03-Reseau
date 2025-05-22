namespace SAE_Reseau
{
    partial class FormCalcul
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCompute = new Button();
            txtInput = new TextBox();
            txtOutput = new TextBox();
            lblNomsParticipants = new Label();
            lblMetadata = new Label();
            lblError = new Label();
            SuspendLayout();
            // 
            // btnCompute
            // 
            btnCompute.Location = new Point(428, 278);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(188, 23);
            btnCompute.TabIndex = 0;
            btnCompute.Text = "Calculer le Header Checksum";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(298, 26);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(469, 218);
            txtInput.TabIndex = 1;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(440, 354);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(159, 23);
            txtOutput.TabIndex = 2;
            // 
            // lblNomsParticipants
            // 
            lblNomsParticipants.AutoSize = true;
            lblNomsParticipants.Location = new Point(45, 52);
            lblNomsParticipants.Name = "lblNomsParticipants";
            lblNomsParticipants.Size = new Size(178, 30);
            lblNomsParticipants.TabIndex = 3;
            lblNomsParticipants.Text = "Vermeulen - Vaucher - Levasseur\r\nGianessi - Bruyelles";
            lblNomsParticipants.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMetadata
            // 
            lblMetadata.AutoSize = true;
            lblMetadata.Location = new Point(27, 123);
            lblMetadata.Name = "lblMetadata";
            lblMetadata.Size = new Size(224, 45);
            lblMetadata.TabIndex = 4;
            lblMetadata.Text = "Année Scolaire 2024-2025\r\nIUT d'Amiens, Département Informatique\r\nSAE Réseau Semestre 2";
            lblMetadata.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(86, 354);
            lblError.Name = "lblError";
            lblError.Size = new Size(48, 15);
            lblError.TabIndex = 5;
            lblError.Text = "Error lol";
            // 
            // FormCalcul
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblError);
            Controls.Add(lblMetadata);
            Controls.Add(lblNomsParticipants);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(btnCompute);
            Name = "FormCalcul";
            Text = "Calculateur de Header Checksum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCompute;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Label lblNomsParticipants;
        private Label lblMetadata;
        private Label lblError;
    }
}
