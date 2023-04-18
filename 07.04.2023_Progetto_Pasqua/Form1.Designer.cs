
namespace _07._04._2023_Progetto_Pasqua
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
            this.components = new System.ComponentModel.Container();
            this.btn_start = new System.Windows.Forms.Button();
            this.dgv_board = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chk_log = new System.Windows.Forms.CheckBox();
            this.lst_result = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_board)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.btn_start.Location = new System.Drawing.Point(475, 654);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(135, 67);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // dgv_board
            // 
            this.dgv_board.AllowUserToAddRows = false;
            this.dgv_board.AllowUserToDeleteRows = false;
            this.dgv_board.AllowUserToResizeColumns = false;
            this.dgv_board.AllowUserToResizeRows = false;
            this.dgv_board.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_board.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_board.ColumnHeadersHeight = 12;
            this.dgv_board.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_board.ColumnHeadersVisible = false;
            this.dgv_board.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgv_board.EnableHeadersVisualStyles = false;
            this.dgv_board.Location = new System.Drawing.Point(329, 94);
            this.dgv_board.Name = "dgv_board";
            this.dgv_board.ReadOnly = true;
            this.dgv_board.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_board.RowHeadersVisible = false;
            this.dgv_board.RowHeadersWidth = 300;
            this.dgv_board.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_board.RowTemplate.Height = 33;
            this.dgv_board.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_board.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_board.Size = new System.Drawing.Size(473, 473);
            this.dgv_board.TabIndex = 2;
            // 
            // chk_log
            // 
            this.chk_log.AutoSize = true;
            this.chk_log.Location = new System.Drawing.Point(1002, 59);
            this.chk_log.Name = "chk_log";
            this.chk_log.Size = new System.Drawing.Size(80, 29);
            this.chk_log.TabIndex = 4;
            this.chk_log.Text = "Log";
            this.chk_log.UseVisualStyleBackColor = true;
            this.chk_log.CheckedChanged += new System.EventHandler(this.chk_log_CheckedChanged);
            // 
            // lst_result
            // 
            this.lst_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.lst_result.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lst_result.HideSelection = false;
            this.lst_result.Location = new System.Drawing.Point(867, 142);
            this.lst_result.MultiSelect = false;
            this.lst_result.Name = "lst_result";
            this.lst_result.Size = new System.Drawing.Size(382, 442);
            this.lst_result.TabIndex = 6;
            this.lst_result.UseCompatibleStateImageBehavior = false;
            this.lst_result.View = System.Windows.Forms.View.Tile;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1412, 806);
            this.Controls.Add(this.lst_result);
            this.Controls.Add(this.chk_log);
            this.Controls.Add(this.dgv_board);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "Lost in the fronds";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_board)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.DataGridView dgv_board;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.CheckBox chk_log;
        private System.Windows.Forms.ListView lst_result;
    }
}

