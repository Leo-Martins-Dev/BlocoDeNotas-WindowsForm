namespace BlocoDeNotas
{
    partial class blocoNotas
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
            titleBox = new TextBox();
            noteBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            previousNote = new DataGridView();
            loadButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            newNoteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)previousNote).BeginInit();
            SuspendLayout();
            // 
            // titleBox
            // 
            titleBox.BackColor = Color.Snow;
            titleBox.Location = new Point(388, 27);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(412, 23);
            titleBox.TabIndex = 0;
            titleBox.TextChanged += TextBox1_TextChanged;
            // 
            // noteBox
            // 
            noteBox.BackColor = Color.Snow;
            noteBox.Location = new Point(388, 71);
            noteBox.Multiline = true;
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(412, 389);
            noteBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(388, 3);
            label1.Name = "label1";
            label1.Size = new Size(412, 15);
            label1.TabIndex = 2;
            label1.Text = "Titulo:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(388, 53);
            label2.Name = "label2";
            label2.Size = new Size(412, 15);
            label2.TabIndex = 3;
            label2.Text = "Nota:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // previousNote
            // 
            previousNote.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            previousNote.BackgroundColor = Color.Snow;
            previousNote.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousNote.Location = new Point(3, 3);
            previousNote.Name = "previousNote";
            previousNote.RowTemplate.Height = 25;
            previousNote.Size = new Size(379, 359);
            previousNote.TabIndex = 4;
            previousNote.CellContentDoubleClick += PreviousNote_CellContentDoubleClick;
            // 
            // loadButton
            // 
            loadButton.BackColor = Color.Snow;
            loadButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loadButton.Location = new Point(3, 368);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(182, 43);
            loadButton.TabIndex = 5;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += LoadButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Snow;
            deleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.Location = new Point(200, 368);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(182, 43);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += DeleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Snow;
            saveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.Location = new Point(200, 417);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(182, 43);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += SaveButton_Click;
            // 
            // newNoteButton
            // 
            newNoteButton.BackColor = Color.Snow;
            newNoteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            newNoteButton.Location = new Point(3, 417);
            newNoteButton.Name = "newNoteButton";
            newNoteButton.Size = new Size(182, 43);
            newNoteButton.TabIndex = 8;
            newNoteButton.Text = "Nova Nota";
            newNoteButton.UseVisualStyleBackColor = false;
            newNoteButton.Click += NewNoteButton_Click;
            // 
            // blocoNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 472);
            Controls.Add(newNoteButton);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(loadButton);
            Controls.Add(previousNote);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(noteBox);
            Controls.Add(titleBox);
            Name = "blocoNotas";
            Text = "Bloco de notas";
            Load += BlocoNotas;
            ((System.ComponentModel.ISupportInitialize)previousNote).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleBox;
        private TextBox noteBox;
        private Label label1;
        private Label label2;
        private DataGridView previousNote;
        private Button loadButton;
        private Button deleteButton;
        private Button saveButton;
        private Button newNoteButton;
    }
}