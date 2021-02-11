
namespace TriggerTestAssieme
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDriver = new System.Windows.Forms.DataGridView();
            this.dgvStoricoCancellazioni = new System.Windows.Forms.DataGridView();
            this.dgvStoricoAggiornamenti = new System.Windows.Forms.DataGridView();
            this.btnAggDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazione = new System.Windows.Forms.TextBox();
            this.btnRicercaCazione = new System.Windows.Forms.Button();
            this.btnEseguiNumero = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoCancellazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoAggiornamenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDriver
            // 
            this.dgvDriver.AllowUserToAddRows = false;
            this.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriver.Location = new System.Drawing.Point(13, 13);
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.Size = new System.Drawing.Size(323, 196);
            this.dgvDriver.TabIndex = 0;
            this.dgvDriver.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDblClickDriver);
            this.dgvDriver.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.OnRowsDeletedDriver);
            // 
            // dgvStoricoCancellazioni
            // 
            this.dgvStoricoCancellazioni.AllowUserToAddRows = false;
            this.dgvStoricoCancellazioni.AllowUserToDeleteRows = false;
            this.dgvStoricoCancellazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoricoCancellazioni.Location = new System.Drawing.Point(352, 13);
            this.dgvStoricoCancellazioni.Name = "dgvStoricoCancellazioni";
            this.dgvStoricoCancellazioni.RowHeadersVisible = false;
            this.dgvStoricoCancellazioni.Size = new System.Drawing.Size(323, 196);
            this.dgvStoricoCancellazioni.TabIndex = 1;
            // 
            // dgvStoricoAggiornamenti
            // 
            this.dgvStoricoAggiornamenti.AllowUserToAddRows = false;
            this.dgvStoricoAggiornamenti.AllowUserToDeleteRows = false;
            this.dgvStoricoAggiornamenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoricoAggiornamenti.Location = new System.Drawing.Point(13, 242);
            this.dgvStoricoAggiornamenti.Name = "dgvStoricoAggiornamenti";
            this.dgvStoricoAggiornamenti.RowHeadersVisible = false;
            this.dgvStoricoAggiornamenti.Size = new System.Drawing.Size(662, 196);
            this.dgvStoricoAggiornamenti.TabIndex = 2;
            // 
            // btnAggDB
            // 
            this.btnAggDB.Location = new System.Drawing.Point(13, 216);
            this.btnAggDB.Name = "btnAggDB";
            this.btnAggDB.Size = new System.Drawing.Size(159, 23);
            this.btnAggDB.TabIndex = 3;
            this.btnAggDB.Text = "Aggiorna Data Base";
            this.btnAggDB.UseVisualStyleBackColor = true;
            this.btnAggDB.Click += new System.EventHandler(this.btnAggDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inserisci la nazione";
            // 
            // txtNazione
            // 
            this.txtNazione.Location = new System.Drawing.Point(128, 470);
            this.txtNazione.Name = "txtNazione";
            this.txtNazione.Size = new System.Drawing.Size(100, 20);
            this.txtNazione.TabIndex = 5;
            // 
            // btnRicercaCazione
            // 
            this.btnRicercaCazione.Location = new System.Drawing.Point(261, 468);
            this.btnRicercaCazione.Name = "btnRicercaCazione";
            this.btnRicercaCazione.Size = new System.Drawing.Size(75, 23);
            this.btnRicercaCazione.TabIndex = 6;
            this.btnRicercaCazione.Text = "Esegui ricerca";
            this.btnRicercaCazione.UseVisualStyleBackColor = true;
            this.btnRicercaCazione.Click += new System.EventHandler(this.btnRicercaCazione_Click);
            // 
            // btnEseguiNumero
            // 
            this.btnEseguiNumero.Location = new System.Drawing.Point(261, 497);
            this.btnEseguiNumero.Name = "btnEseguiNumero";
            this.btnEseguiNumero.Size = new System.Drawing.Size(75, 23);
            this.btnEseguiNumero.TabIndex = 9;
            this.btnEseguiNumero.Text = "Esegui ricerca";
            this.btnEseguiNumero.UseVisualStyleBackColor = true;
            this.btnEseguiNumero.Click += new System.EventHandler(this.btnEseguiNumero_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(128, 499);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Inserisci il numero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 529);
            this.Controls.Add(this.btnEseguiNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRicercaCazione);
            this.Controls.Add(this.txtNazione);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAggDB);
            this.Controls.Add(this.dgvStoricoAggiornamenti);
            this.Controls.Add(this.dgvStoricoCancellazioni);
            this.Controls.Add(this.dgvDriver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoCancellazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoAggiornamenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDriver;
        private System.Windows.Forms.DataGridView dgvStoricoCancellazioni;
        private System.Windows.Forms.DataGridView dgvStoricoAggiornamenti;
        private System.Windows.Forms.Button btnAggDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazione;
        private System.Windows.Forms.Button btnRicercaCazione;
        private System.Windows.Forms.Button btnEseguiNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
    }
}

