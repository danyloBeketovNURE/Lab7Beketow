namespace Lb6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AuthorsGridView = new System.Windows.Forms.DataGridView();
            this.AddAuthorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DelleteChousedAuthor = new System.Windows.Forms.Button();
            this.BooksGridView = new System.Windows.Forms.DataGridView();
            this.AddBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DelleteChousedBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthorsGridView
            // 
            this.AuthorsGridView.AllowUserToResizeColumns = false;
            this.AuthorsGridView.AllowUserToResizeRows = false;
            this.AuthorsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AuthorsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AuthorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorsGridView.Location = new System.Drawing.Point(78, 34);
            this.AuthorsGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AuthorsGridView.Name = "AuthorsGridView";
            this.AuthorsGridView.RowHeadersWidth = 62;
            this.AuthorsGridView.RowTemplate.Height = 28;
            this.AuthorsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AuthorsGridView.Size = new System.Drawing.Size(482, 615);
            this.AuthorsGridView.TabIndex = 0;
            this.AuthorsGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.AuthorGridView_CellValueChanged);
            this.AuthorsGridView.SelectionChanged += new System.EventHandler(this.AuthorGridView_SelectionChanged);
            // 
            // AddAuthorButton
            // 
            this.AddAuthorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAuthorButton.Location = new System.Drawing.Point(9, 34);
            this.AddAuthorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddAuthorButton.Name = "AddAuthorButton";
            this.AddAuthorButton.Size = new System.Drawing.Size(58, 299);
            this.AddAuthorButton.TabIndex = 2;
            this.AddAuthorButton.Text = "Add";
            this.AddAuthorButton.UseVisualStyleBackColor = true;
            this.AddAuthorButton.Click += new System.EventHandler(this.AddAuthorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "authors";
            // 
            // DelleteChousedAuthor
            // 
            this.DelleteChousedAuthor.Location = new System.Drawing.Point(9, 350);
            this.DelleteChousedAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelleteChousedAuthor.Name = "DelleteChousedAuthor";
            this.DelleteChousedAuthor.Size = new System.Drawing.Size(55, 299);
            this.DelleteChousedAuthor.TabIndex = 4;
            this.DelleteChousedAuthor.Text = "Dell";
            this.DelleteChousedAuthor.UseVisualStyleBackColor = true;
            this.DelleteChousedAuthor.Click += new System.EventHandler(this.RemoveAuthor_Click);
            // 
            // BooksGridView
            // 
            this.BooksGridView.AllowUserToResizeColumns = false;
            this.BooksGridView.AllowUserToResizeRows = false;
            this.BooksGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BooksGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksGridView.Location = new System.Drawing.Point(641, 34);
            this.BooksGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BooksGridView.Name = "BooksGridView";
            this.BooksGridView.RowHeadersWidth = 62;
            this.BooksGridView.RowTemplate.Height = 28;
            this.BooksGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BooksGridView.Size = new System.Drawing.Size(482, 615);
            this.BooksGridView.TabIndex = 0;
            this.BooksGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksGridView_CellValueChanged);
            this.BooksGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.BooksGridView_DataError);
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(572, 34);
            this.AddBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(55, 299);
            this.AddBook.TabIndex = 5;
            this.AddBook.Text = "Add";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(874, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "books";
            // 
            // DelleteChousedBook
            // 
            this.DelleteChousedBook.Location = new System.Drawing.Point(572, 350);
            this.DelleteChousedBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelleteChousedBook.Name = "DelleteChousedBook";
            this.DelleteChousedBook.Size = new System.Drawing.Size(52, 299);
            this.DelleteChousedBook.TabIndex = 7;
            this.DelleteChousedBook.Text = "Dell";
            this.DelleteChousedBook.UseVisualStyleBackColor = true;
            this.DelleteChousedBook.Click += new System.EventHandler(this.RemoveWorker_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 668);
            this.Controls.Add(this.DelleteChousedBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.DelleteChousedAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddAuthorButton);
            this.Controls.Add(this.BooksGridView);
            this.Controls.Add(this.AuthorsGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(928, 498);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authors&Books";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AuthorsGridView;
        private System.Windows.Forms.Button AddAuthorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DelleteChousedAuthor;
        private System.Windows.Forms.DataGridView BooksGridView;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DelleteChousedBook;
    }
}

