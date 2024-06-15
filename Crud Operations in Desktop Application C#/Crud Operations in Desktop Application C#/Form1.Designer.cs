namespace Crud_Operations_in_Desktop_Application_C_
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
            CRUD = new Label();
            id = new TextBox();
            label1 = new Label();
            name = new TextBox();
            age = new TextBox();
            email = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Submit = new Button();
            SuspendLayout();
            // 
            // CRUD
            // 
            CRUD.AutoSize = true;
            CRUD.BackColor = SystemColors.ActiveCaption;
            CRUD.BorderStyle = BorderStyle.FixedSingle;
            CRUD.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CRUD.Location = new Point(274, 55);
            CRUD.Name = "CRUD";
            CRUD.Size = new Size(252, 39);
            CRUD.TabIndex = 0;
            CRUD.Text = "CRUD OPERATIONS";
            // 
            // id
            // 
            id.Location = new Point(259, 124);
            id.Multiline = true;
            id.Name = "id";
            id.Size = new Size(265, 45);
            id.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 132);
            label1.Name = "label1";
            label1.Size = new Size(138, 37);
            label1.TabIndex = 2;
            label1.Text = "Student Id";
            label1.Click += label1_Click;
            // 
            // name
            // 
            name.Location = new Point(259, 196);
            name.Multiline = true;
            name.Name = "name";
            name.Size = new Size(265, 45);
            name.TabIndex = 3;
            // 
            // age
            // 
            age.Location = new Point(259, 261);
            age.Multiline = true;
            age.Name = "age";
            age.Size = new Size(265, 45);
            age.TabIndex = 4;
            // 
            // email
            // 
            email.Location = new Point(259, 326);
            email.Multiline = true;
            email.Name = "email";
            email.Size = new Size(265, 45);
            email.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 334);
            label2.Name = "label2";
            label2.Size = new Size(180, 37);
            label2.TabIndex = 6;
            label2.Text = "Student Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 269);
            label3.Name = "label3";
            label3.Size = new Size(162, 37);
            label3.TabIndex = 7;
            label3.Text = "Student Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 196);
            label4.Name = "label4";
            label4.Size = new Size(186, 37);
            label4.TabIndex = 8;
            label4.Text = "Student Name";
            // 
            // Submit
            // 
            Submit.BackColor = SystemColors.ActiveCaption;
            Submit.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Submit.Location = new Point(341, 389);
            Submit.Name = "Submit";
            Submit.Size = new Size(115, 49);
            Submit.TabIndex = 9;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Submit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(email);
            Controls.Add(age);
            Controls.Add(name);
            Controls.Add(label1);
            Controls.Add(id);
            Controls.Add(CRUD);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CRUD;
        private TextBox id;
        private Label label1;
        private TextBox name;
        private TextBox age;
        private TextBox email;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Submit;
    }
}
