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
            lblInput = new Label();
            lblOutput = new Label();
            SuspendLayout();
            // 
            // btnCompute
            // 
            btnCompute.Location = new Point(164, 225);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(188, 23);
            btnCompute.TabIndex = 0;
            btnCompute.Text = "Calculer le Header Checksum";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 18F);
            txtInput.Location = new Point(84, 72);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(361, 74);
            txtInput.TabIndex = 1;
            txtInput.Text = "4500 0030 0465 4000 7f06 0000\r\n0a10 062c c239 6d84";
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Segoe UI", 18F);
            txtOutput.Location = new Point(177, 292);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(159, 39);
            txtOutput.TabIndex = 2;
            // 
            // lblNomsParticipants
            // 
            lblNomsParticipants.AutoSize = true;
            lblNomsParticipants.Location = new Point(12, 411);
            lblNomsParticipants.Name = "lblNomsParticipants";
            lblNomsParticipants.Size = new Size(178, 30);
            lblNomsParticipants.TabIndex = 3;
            lblNomsParticipants.Text = "Vermeulen - Vaucher - Levasseur\r\nGianessi - Bruyelles";
            lblNomsParticipants.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMetadata
            // 
            lblMetadata.AutoSize = true;
            lblMetadata.Location = new Point(300, 396);
            lblMetadata.Name = "lblMetadata";
            lblMetadata.Size = new Size(224, 45);
            lblMetadata.TabIndex = 4;
            lblMetadata.Text = "Année Scolaire 2024-2025\r\nIUT d'Amiens, Département Informatique\r\nSAE Réseau Semestre 2";
            lblMetadata.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(84, 183);
            lblError.Name = "lblError";
            lblError.Size = new Size(72, 15);
            lblError.TabIndex = 5;
            lblError.Text = "Error display";
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(84, 54);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(53, 15);
            lblInput.TabIndex = 6;
            lblInput.Text = "Entête IP";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(177, 274);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(104, 15);
            lblOutput.TabIndex = 7;
            lblOutput.Text = "Header Checksum";
            // 
            // FormCalcul
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 450);
            Controls.Add(lblOutput);
            Controls.Add(lblInput);
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
        private Label lblInput;
        private Label lblOutput;
    }
}
