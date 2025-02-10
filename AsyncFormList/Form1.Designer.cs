namespace AsyncFormList
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
            label1 = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            label2 = new Label();
            textBoxAge = new TextBox();
            label3 = new Label();
            textBoxGroup = new TextBox();
            label4 = new Label();
            listView1 = new ListView();
            button1 = new Button();
            label5 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 17);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(54, 35);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(203, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(54, 101);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(203, 23);
            textBoxSurname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 83);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Фамилия";
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(54, 164);
            textBoxAge.MaxLength = 3;
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(203, 23);
            textBoxAge.TabIndex = 5;
            textBoxAge.KeyPress += textBoxAge_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 146);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Возраст";
            // 
            // textBoxGroup
            // 
            textBoxGroup.Location = new Point(54, 229);
            textBoxGroup.Name = "textBoxGroup";
            textBoxGroup.Size = new Size(203, 23);
            textBoxGroup.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 211);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 6;
            label4.Text = "Группа";
            // 
            // listView1
            // 
            listView1.Location = new Point(334, 35);
            listView1.Name = "listView1";
            listView1.Size = new Size(263, 246);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(182, 273);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(402, 17);
            label5.Name = "label5";
            label5.Size = new Size(133, 15);
            label5.TabIndex = 10;
            label5.Text = "Список пользователей";
            // 
            // button2
            // 
            button2.Location = new Point(438, 287);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Очистить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 319);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(textBoxGroup);
            Controls.Add(label4);
            Controls.Add(textBoxAge);
            Controls.Add(label3);
            Controls.Add(textBoxSurname);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private Label label2;
        private TextBox textBoxAge;
        private Label label3;
        private TextBox textBoxGroup;
        private Label label4;
        private ListView listView1;
        private Button button1;
        private Label label5;
        private Button button2;
    }
}
