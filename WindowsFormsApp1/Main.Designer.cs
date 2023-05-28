namespace WindowsFormsApp1
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label6 = new System.Windows.Forms.Label();
            this.DepartmentChief = new System.Windows.Forms.TextBox();
            this.QuestionsCount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StudyYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Discipline = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Faculty = new System.Windows.Forms.TextBox();
            this.Header = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TicketsCount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Export = new System.Windows.Forms.Button();
            this.listQuestions = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(811, 338);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Заведующий кафедрой";
            // 
            // DepartmentChief
            // 
            this.DepartmentChief.Location = new System.Drawing.Point(814, 358);
            this.DepartmentChief.Margin = new System.Windows.Forms.Padding(4);
            this.DepartmentChief.Name = "DepartmentChief";
            this.DepartmentChief.Size = new System.Drawing.Size(160, 22);
            this.DepartmentChief.TabIndex = 37;
            this.DepartmentChief.Text = "Долгов В. В.";
            // 
            // QuestionsCount
            // 
            this.QuestionsCount.Location = new System.Drawing.Point(694, 424);
            this.QuestionsCount.Margin = new System.Windows.Forms.Padding(4);
            this.QuestionsCount.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.QuestionsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuestionsCount.Name = "QuestionsCount";
            this.QuestionsCount.Size = new System.Drawing.Size(65, 22);
            this.QuestionsCount.TabIndex = 36;
            this.QuestionsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuestionsCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(691, 404);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Количество вопросов:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(692, 338);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Учебный год";
            // 
            // StudyYear
            // 
            this.StudyYear.Location = new System.Drawing.Point(695, 358);
            this.StudyYear.Margin = new System.Windows.Forms.Padding(4);
            this.StudyYear.Name = "StudyYear";
            this.StudyYear.Size = new System.Drawing.Size(87, 22);
            this.StudyYear.TabIndex = 33;
            this.StudyYear.Text = "2021-2022";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(691, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Предмет";
            // 
            // Discipline
            // 
            this.Discipline.Location = new System.Drawing.Point(695, 294);
            this.Discipline.Margin = new System.Windows.Forms.Padding(4);
            this.Discipline.Name = "Discipline";
            this.Discipline.Size = new System.Drawing.Size(582, 22);
            this.Discipline.TabIndex = 31;
            this.Discipline.Text = "Программирование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(691, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Кафедра";
            // 
            // Department
            // 
            this.Department.Location = new System.Drawing.Point(695, 229);
            this.Department.Margin = new System.Windows.Forms.Padding(4);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(582, 22);
            this.Department.TabIndex = 29;
            this.Department.Text = "Программное обеспечение вычислительной техники и автоматизированных систем";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(691, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Факультет";
            // 
            // Faculty
            // 
            this.Faculty.Location = new System.Drawing.Point(695, 166);
            this.Faculty.Margin = new System.Windows.Forms.Padding(4);
            this.Faculty.Name = "Faculty";
            this.Faculty.Size = new System.Drawing.Size(582, 22);
            this.Faculty.TabIndex = 27;
            this.Faculty.Text = "Информатика и вычислительная техника";
            // 
            // Header
            // 
            this.Header.Location = new System.Drawing.Point(695, 29);
            this.Header.Margin = new System.Windows.Forms.Padding(4);
            this.Header.Multiline = true;
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(582, 96);
            this.Header.TabIndex = 26;
            this.Header.Text = resources.GetString("Header.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Шапка";
            // 
            // TicketsCount
            // 
            this.TicketsCount.Location = new System.Drawing.Point(694, 484);
            this.TicketsCount.Margin = new System.Windows.Forms.Padding(4);
            this.TicketsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TicketsCount.Name = "TicketsCount";
            this.TicketsCount.Size = new System.Drawing.Size(93, 22);
            this.TicketsCount.TabIndex = 41;
            this.TicketsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TicketsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(691, 464);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Количество билетов:";
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(1134, 478);
            this.Export.Margin = new System.Windows.Forms.Padding(4);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(143, 28);
            this.Export.TabIndex = 39;
            this.Export.Text = "Сформировать";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // listQuestions
            // 
            this.listQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.listQuestions.Location = new System.Drawing.Point(12, 29);
            this.listQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.listQuestions.Multiline = true;
            this.listQuestions.Name = "listQuestions";
            this.listQuestions.Size = new System.Drawing.Size(671, 477);
            this.listQuestions.TabIndex = 43;
            this.listQuestions.Text = resources.GetString("listQuestions.Text");
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(672, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "Введите список вопросов без использования дополнительных символов";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 519);
            this.Controls.Add(this.listQuestions);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TicketsCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DepartmentChief);
            this.Controls.Add(this.QuestionsCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StudyYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Discipline);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Faculty);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Генератор экземенационных билетов";
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DepartmentChief;
        private System.Windows.Forms.NumericUpDown QuestionsCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StudyYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Discipline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Department;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Faculty;
        private System.Windows.Forms.TextBox Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TicketsCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.TextBox listQuestions;
        private System.Windows.Forms.Label label9;
    }
}