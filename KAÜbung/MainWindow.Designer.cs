
namespace KAÜbung
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.mainView = new System.Windows.Forms.DataGridView();
            this.txt_Titel = new System.Windows.Forms.TextBox();
            this.txt_Autor = new System.Windows.Forms.TextBox();
            this.lbl_Text_ISBN = new System.Windows.Forms.Label();
            this.lbl_Text_Titel = new System.Windows.Forms.Label();
            this.lbl_Text_Autor = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_Text_Erscheinungsjahr = new System.Windows.Forms.Label();
            this.dtp_YOR = new System.Windows.Forms.DateTimePicker();
            this.btn_SaveAndExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Location = new System.Drawing.Point(120, 222);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(341, 20);
            this.txt_ISBN.TabIndex = 1;
            // 
            // mainView
            // 
            this.mainView.AllowUserToAddRows = false;
            this.mainView.AllowUserToDeleteRows = false;
            this.mainView.AllowUserToResizeRows = false;
            this.mainView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mainView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainView.Location = new System.Drawing.Point(9, 12);
            this.mainView.Name = "mainView";
            this.mainView.Size = new System.Drawing.Size(563, 204);
            this.mainView.TabIndex = 3;
            // 
            // txt_Titel
            // 
            this.txt_Titel.Location = new System.Drawing.Point(120, 248);
            this.txt_Titel.Name = "txt_Titel";
            this.txt_Titel.Size = new System.Drawing.Size(341, 20);
            this.txt_Titel.TabIndex = 2;
            // 
            // txt_Autor
            // 
            this.txt_Autor.Location = new System.Drawing.Point(120, 274);
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.Size = new System.Drawing.Size(341, 20);
            this.txt_Autor.TabIndex = 3;
            // 
            // lbl_Text_ISBN
            // 
            this.lbl_Text_ISBN.AutoSize = true;
            this.lbl_Text_ISBN.Location = new System.Drawing.Point(82, 225);
            this.lbl_Text_ISBN.Name = "lbl_Text_ISBN";
            this.lbl_Text_ISBN.Size = new System.Drawing.Size(32, 13);
            this.lbl_Text_ISBN.TabIndex = 7;
            this.lbl_Text_ISBN.Text = "ISBN";
            // 
            // lbl_Text_Titel
            // 
            this.lbl_Text_Titel.AutoSize = true;
            this.lbl_Text_Titel.Location = new System.Drawing.Point(82, 251);
            this.lbl_Text_Titel.Name = "lbl_Text_Titel";
            this.lbl_Text_Titel.Size = new System.Drawing.Size(27, 13);
            this.lbl_Text_Titel.TabIndex = 8;
            this.lbl_Text_Titel.Text = "Titel";
            // 
            // lbl_Text_Autor
            // 
            this.lbl_Text_Autor.AutoSize = true;
            this.lbl_Text_Autor.Location = new System.Drawing.Point(82, 277);
            this.lbl_Text_Autor.Name = "lbl_Text_Autor";
            this.lbl_Text_Autor.Size = new System.Drawing.Size(32, 13);
            this.lbl_Text_Autor.TabIndex = 9;
            this.lbl_Text_Autor.Text = "Autor";
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Insert.FlatAppearance.BorderSize = 0;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insert.Location = new System.Drawing.Point(198, 329);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(263, 23);
            this.btn_Insert.TabIndex = 10;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(120, 329);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(72, 23);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_Text_Erscheinungsjahr
            // 
            this.lbl_Text_Erscheinungsjahr.AutoSize = true;
            this.lbl_Text_Erscheinungsjahr.Location = new System.Drawing.Point(82, 303);
            this.lbl_Text_Erscheinungsjahr.Name = "lbl_Text_Erscheinungsjahr";
            this.lbl_Text_Erscheinungsjahr.Size = new System.Drawing.Size(36, 13);
            this.lbl_Text_Erscheinungsjahr.TabIndex = 13;
            this.lbl_Text_Erscheinungsjahr.Text = "Y.O.R";
            // 
            // dtp_YOR
            // 
            this.dtp_YOR.Location = new System.Drawing.Point(120, 303);
            this.dtp_YOR.Name = "dtp_YOR";
            this.dtp_YOR.Size = new System.Drawing.Size(341, 20);
            this.dtp_YOR.TabIndex = 4;
            // 
            // btn_SaveAndExit
            // 
            this.btn_SaveAndExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_SaveAndExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveAndExit.Location = new System.Drawing.Point(467, 303);
            this.btn_SaveAndExit.Name = "btn_SaveAndExit";
            this.btn_SaveAndExit.Size = new System.Drawing.Size(105, 49);
            this.btn_SaveAndExit.TabIndex = 14;
            this.btn_SaveAndExit.Text = "Speichern und Beenden";
            this.btn_SaveAndExit.UseVisualStyleBackColor = true;
            this.btn_SaveAndExit.Click += new System.EventHandler(this.btn_SaveAndExit_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btn_SaveAndExit);
            this.Controls.Add(this.dtp_YOR);
            this.Controls.Add(this.lbl_Text_Erscheinungsjahr);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.lbl_Text_Autor);
            this.Controls.Add(this.lbl_Text_Titel);
            this.Controls.Add(this.lbl_Text_ISBN);
            this.Controls.Add(this.txt_Autor);
            this.Controls.Add(this.txt_Titel);
            this.Controls.Add(this.mainView);
            this.Controls.Add(this.txt_ISBN);
            this.Name = "MainWindow";
            this.Text = "emp";
            ((System.ComponentModel.ISupportInitialize)(this.mainView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.DataGridView mainView;
        private System.Windows.Forms.TextBox txt_Titel;
        private System.Windows.Forms.TextBox txt_Autor;
        private System.Windows.Forms.Label lbl_Text_ISBN;
        private System.Windows.Forms.Label lbl_Text_Titel;
        private System.Windows.Forms.Label lbl_Text_Autor;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lbl_Text_Erscheinungsjahr;
        private System.Windows.Forms.DateTimePicker dtp_YOR;
        private System.Windows.Forms.Button btn_SaveAndExit;
    }
}

