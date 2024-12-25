namespace Tyuiu.AkhmedullovRR.Sprint6.Task0.V18
{
    partial class FormMain
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
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBoxVariable = new TextBox();
            labelVariable = new Label();
            groupBox3 = new GroupBox();
            textBoxResult = new TextBox();
            label4 = new Label();
            button_Done = new Button();
            buttonQuestion = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(594, 253);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(449, 29);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 84);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 29);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(435, 199);
            textBox1.TabIndex = 0;
            textBox1.Text = "Вычислить выражение по формуле";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxVariable);
            groupBox2.Controls.Add(labelVariable);
            groupBox2.Location = new Point(21, 277);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(354, 133);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // textBoxVariable
            // 
            textBoxVariable.Location = new Point(113, 71);
            textBoxVariable.Margin = new Padding(3, 4, 3, 4);
            textBoxVariable.Name = "textBoxVariable";
            textBoxVariable.Size = new Size(109, 27);
            textBoxVariable.TabIndex = 1;
            textBoxVariable.TextChanged += textBoxVariable_TextChanged;
            textBoxVariable.KeyPress += textBoxVariable_KeyPress;
            // 
            // labelVariable
            // 
            labelVariable.AutoSize = true;
            labelVariable.Location = new Point(113, 44);
            labelVariable.Name = "labelVariable";
            labelVariable.Size = new Size(114, 20);
            labelVariable.TabIndex = 0;
            labelVariable.Text = "Переменная X:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxResult);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(382, 277);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(216, 133);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(14, 71);
            textBoxResult.Margin = new Padding(3, 4, 3, 4);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(195, 27);
            textBoxResult.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 44);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 0;
            label4.Text = "Результат:";
            // 
            // button_Done
            // 
            button_Done.FlatStyle = FlatStyle.Popup;
            button_Done.Location = new Point(447, 419);
            button_Done.Margin = new Padding(3, 4, 3, 4);
            button_Done.Name = "button_Done";
            button_Done.Size = new Size(151, 55);
            button_Done.TabIndex = 3;
            button_Done.Text = "Выполнить";
            button_Done.UseVisualStyleBackColor = true;
            button_Done.Click += buttonDone_Click;
            // 
            // buttonQuestion
            // 
            buttonQuestion.FlatStyle = FlatStyle.Flat;
            buttonQuestion.Location = new Point(382, 419);
            buttonQuestion.Margin = new Padding(3, 4, 3, 4);
            buttonQuestion.Name = "buttonQuestion";
            buttonQuestion.Size = new Size(58, 55);
            buttonQuestion.TabIndex = 4;
            buttonQuestion.Text = "?";
            buttonQuestion.UseVisualStyleBackColor = true;
            buttonQuestion.Click += buttonQuestion_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 489);
            Controls.Add(buttonQuestion);
            Controls.Add(button_Done);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 18 | Ахмедуллов Р. Р.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox textBoxVariable;
        private Label labelVariable;
        private GroupBox groupBox3;
        private Button button_Done;
        private Button buttonQuestion;
        private TextBox textBoxResult;
        private Label label4;
    }
}