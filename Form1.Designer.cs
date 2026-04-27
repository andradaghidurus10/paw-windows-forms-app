namespace paw_ex_Verificare_produs_parte_2
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNume = new TextBox();
            txtCalificative = new TextBox();
            txtScor = new TextBox();
            txtPret = new TextBox();
            btnPlus = new Button();
            btnMinus = new Button();
            btnVerif = new Button();
            btnSalvare = new Button();
            btnErrOn = new Button();
            btnErrOf = new Button();
            errorProvider1 = new ErrorProvider(components);
            menuStrip1 = new MenuStrip();
            optiuniToolStripMenuItem = new ToolStripMenuItem();
            completareAutomataToolStripMenuItem = new ToolStripMenuItem();
            stergereDateToolStripMenuItem = new ToolStripMenuItem();
            listBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 61);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Denumire Produs:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 117);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Pret:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 166);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Scor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 266);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 3;
            label4.Text = "Calificative:";
            // 
            // txtNume
            // 
            txtNume.Location = new Point(249, 62);
            txtNume.Name = "txtNume";
            txtNume.Size = new Size(125, 27);
            txtNume.TabIndex = 4;
            // 
            // txtCalificative
            // 
            txtCalificative.Location = new Point(249, 259);
            txtCalificative.Name = "txtCalificative";
            txtCalificative.Size = new Size(125, 27);
            txtCalificative.TabIndex = 5;
            txtCalificative.TextChanged += txtCalificative_TextChanged;
            // 
            // txtScor
            // 
            txtScor.Location = new Point(249, 166);
            txtScor.Name = "txtScor";
            txtScor.Size = new Size(125, 27);
            txtScor.TabIndex = 6;
            txtScor.KeyPress += txtScor_KeyPress;
            txtScor.Validating += txtScor_Validating;
            // 
            // txtPret
            // 
            txtPret.Location = new Point(249, 117);
            txtPret.Name = "txtPret";
            txtPret.Size = new Size(125, 27);
            txtPret.TabIndex = 7;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(404, 257);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(52, 29);
            btnPlus.TabIndex = 8;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(481, 257);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(52, 29);
            btnMinus.TabIndex = 10;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnVerif
            // 
            btnVerif.Location = new Point(118, 213);
            btnVerif.Name = "btnVerif";
            btnVerif.Size = new Size(129, 29);
            btnVerif.TabIndex = 11;
            btnVerif.Text = "Verifica";
            btnVerif.UseVisualStyleBackColor = true;
            btnVerif.Click += btnVerif_Click;
            // 
            // btnSalvare
            // 
            btnSalvare.Location = new Point(404, 292);
            btnSalvare.Name = "btnSalvare";
            btnSalvare.Size = new Size(129, 29);
            btnSalvare.TabIndex = 12;
            btnSalvare.Text = "Salvare";
            btnSalvare.UseVisualStyleBackColor = true;
            btnSalvare.Click += btnSalvare_Click;
            // 
            // btnErrOn
            // 
            btnErrOn.Location = new Point(14, 417);
            btnErrOn.Name = "btnErrOn";
            btnErrOn.Size = new Size(94, 29);
            btnErrOn.TabIndex = 13;
            btnErrOn.Text = "err on";
            btnErrOn.UseVisualStyleBackColor = true;
            btnErrOn.Click += btnErrOn_Click;
            // 
            // btnErrOf
            // 
            btnErrOf.Location = new Point(131, 417);
            btnErrOf.Name = "btnErrOf";
            btnErrOf.Size = new Size(94, 29);
            btnErrOf.TabIndex = 14;
            btnErrOf.Text = "err of";
            btnErrOf.UseVisualStyleBackColor = true;
            btnErrOf.Click += btnErrOf_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { optiuniToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1254, 28);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // optiuniToolStripMenuItem
            // 
            optiuniToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { completareAutomataToolStripMenuItem, stergereDateToolStripMenuItem });
            optiuniToolStripMenuItem.Name = "optiuniToolStripMenuItem";
            optiuniToolStripMenuItem.Size = new Size(72, 24);
            optiuniToolStripMenuItem.Text = "Optiuni";
            // 
            // completareAutomataToolStripMenuItem
            // 
            completareAutomataToolStripMenuItem.Name = "completareAutomataToolStripMenuItem";
            completareAutomataToolStripMenuItem.Size = new Size(240, 26);
            completareAutomataToolStripMenuItem.Text = "Completare Automata";
            completareAutomataToolStripMenuItem.Click += completareAutomataToolStripMenuItem_Click;
            // 
            // stergereDateToolStripMenuItem
            // 
            stergereDateToolStripMenuItem.Name = "stergereDateToolStripMenuItem";
            stergereDateToolStripMenuItem.Size = new Size(240, 26);
            stergereDateToolStripMenuItem.Text = "Stergere Date";
            stergereDateToolStripMenuItem.Click += stergereDateToolStripMenuItem_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(658, 48);
            listBox.Name = "listBox";
            listBox.Size = new Size(444, 324);
            listBox.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 450);
            Controls.Add(listBox);
            Controls.Add(btnErrOf);
            Controls.Add(btnErrOn);
            Controls.Add(btnSalvare);
            Controls.Add(btnVerif);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(txtPret);
            Controls.Add(txtScor);
            Controls.Add(txtCalificative);
            Controls.Add(txtNume);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNume;
        private TextBox txtCalificative;
        private TextBox txtScor;
        private TextBox txtPret;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnVerif;
        private Button btnSalvare;
        private Button btnErrOn;
        private Button btnErrOf;
        private ErrorProvider errorProvider1;
        private ListBox listBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optiuniToolStripMenuItem;
        private ToolStripMenuItem completareAutomataToolStripMenuItem;
        private ToolStripMenuItem stergereDateToolStripMenuItem;
    }
}
