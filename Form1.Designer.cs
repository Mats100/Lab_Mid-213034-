namespace SalaryCalulator
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

 
        private void InitializeComponent()
        {
            NameLabel = new Label();
            NameTextBox = new TextBox();
            GradeLabel = new Label();
            GradeComboBox = new ComboBox();
            SalaryGroupBox = new GroupBox();
            ProgrammerRadioButton = new RadioButton();
            ProjectManagerRadioButton = new RadioButton();
            ManagerRadioButton = new RadioButton();
            DirectorRadioButton = new RadioButton();
            BenefitsGroupBox = new GroupBox();
            OtherBenefit2CheckBox = new CheckBox();
            OtherBenefit1CheckBox = new CheckBox();
            ConvenceCheckBox = new CheckBox();
            HousingCheckBox = new CheckBox();
            BonusesCheckedListBox = new CheckedListBox();
            BonusesLabel = new Label();
            DeductionsGroupBox = new GroupBox();
            MedicalDeductionTextBox = new TextBox();
            ProvidentFundTextBox = new TextBox();
            CalculateSalaryButton = new Button();
            ExitButton = new Button();
            SalaryGroupBox.SuspendLayout();
            BenefitsGroupBox.SuspendLayout();
            DeductionsGroupBox.SuspendLayout();
            SuspendLayout();
         
            // NameLabel
         
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(15, 15);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(45, 15);
            NameLabel.TabIndex = 0;
            NameLabel.Text = " Name:";
         
            // NameTextBox
           
            NameTextBox.Location = new Point(175, 15);
            NameTextBox.Margin = new Padding(4, 3, 4, 3);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(233, 23);
            NameTextBox.TabIndex = 1;
         
            // GradeLabel
        
            GradeLabel.AutoSize = true;
            GradeLabel.Location = new Point(15, 57);
            GradeLabel.Margin = new Padding(4, 0, 4, 0);
            GradeLabel.Name = "GradeLabel";
            GradeLabel.Size = new Size(74, 15);
            GradeLabel.TabIndex = 2;
            GradeLabel.Text = " Grade Level:";
        
            // GradeComboBox
          
            GradeComboBox.FormattingEnabled = true;
            GradeComboBox.Items.AddRange(new object[] { "Director", "Manager", "Project Manager", "Programmer" });
            GradeComboBox.Location = new Point(175, 53);
            GradeComboBox.Margin = new Padding(4, 3, 4, 3);
            GradeComboBox.Name = "GradeComboBox";
            GradeComboBox.Size = new Size(140, 23);
            GradeComboBox.TabIndex = 3;
         
            // SalaryGroupBox
        
            SalaryGroupBox.Controls.Add(ProgrammerRadioButton);
            SalaryGroupBox.Controls.Add(ProjectManagerRadioButton);
            SalaryGroupBox.Controls.Add(ManagerRadioButton);
            SalaryGroupBox.Controls.Add(DirectorRadioButton);
            SalaryGroupBox.Location = new Point(19, 100);
            SalaryGroupBox.Margin = new Padding(4, 3, 4, 3);
            SalaryGroupBox.Name = "SalaryGroupBox";
            SalaryGroupBox.Padding = new Padding(4, 3, 4, 3);
            SalaryGroupBox.Size = new Size(233, 150);
            SalaryGroupBox.TabIndex = 4;
            SalaryGroupBox.TabStop = false;
            SalaryGroupBox.Text = "Basic Salary";
      
            // ProgrammerRadioButton
         
            ProgrammerRadioButton.AutoSize = true;
            ProgrammerRadioButton.Location = new Point(8, 120);
            ProgrammerRadioButton.Margin = new Padding(4, 3, 4, 3);
            ProgrammerRadioButton.Name = "ProgrammerRadioButton";
            ProgrammerRadioButton.Size = new Size(92, 19);
            ProgrammerRadioButton.TabIndex = 3;
            ProgrammerRadioButton.TabStop = true;
            ProgrammerRadioButton.Text = "30,000";
            ProgrammerRadioButton.UseVisualStyleBackColor = true;
        
            // ProjectManagerRadioButton
       
            ProjectManagerRadioButton.AutoSize = true;
            ProjectManagerRadioButton.Location = new Point(8, 90);
            ProjectManagerRadioButton.Margin = new Padding(4, 3, 4, 3);
            ProjectManagerRadioButton.Name = "ProjectManagerRadioButton";
            ProjectManagerRadioButton.Size = new Size(112, 19);
            ProjectManagerRadioButton.TabIndex = 2;
            ProjectManagerRadioButton.TabStop = true;
            ProjectManagerRadioButton.Text = "40,000";
            ProjectManagerRadioButton.UseVisualStyleBackColor = true;
       
            // ManagerRadioButton
         
            ManagerRadioButton.AutoSize = true;
            ManagerRadioButton.Location = new Point(8, 60);
            ManagerRadioButton.Margin = new Padding(4, 3, 4, 3);
            ManagerRadioButton.Name = "ManagerRadioButton";
            ManagerRadioButton.Size = new Size(72, 19);
            ManagerRadioButton.TabIndex = 1;
            ManagerRadioButton.TabStop = true;
            ManagerRadioButton.Text = "50,000";
            ManagerRadioButton.UseVisualStyleBackColor = true;
            // 
            // DirectorRadioButton
            // 
            DirectorRadioButton.AutoSize = true;
            DirectorRadioButton.Location = new Point(8, 30);
            DirectorRadioButton.Margin = new Padding(4, 3, 4, 3);
            DirectorRadioButton.Name = "DirectorRadioButton";
            DirectorRadioButton.Size = new Size(67, 19);
            DirectorRadioButton.TabIndex = 0;
            DirectorRadioButton.TabStop = true;
            DirectorRadioButton.Text = "100,000";
            DirectorRadioButton.UseVisualStyleBackColor = true;
         
            // BenefitsGroupBox
        
            BenefitsGroupBox.Controls.Add(OtherBenefit2CheckBox);
            BenefitsGroupBox.Controls.Add(OtherBenefit1CheckBox);
            BenefitsGroupBox.Controls.Add(ConvenceCheckBox);
            BenefitsGroupBox.Controls.Add(HousingCheckBox);
            BenefitsGroupBox.Location = new Point(284, 100);
            BenefitsGroupBox.Margin = new Padding(4, 3, 4, 3);
            BenefitsGroupBox.Name = "BenefitsGroupBox";
            BenefitsGroupBox.Padding = new Padding(4, 3, 4, 3);
            BenefitsGroupBox.Size = new Size(233, 150);
            BenefitsGroupBox.TabIndex = 5;
            BenefitsGroupBox.TabStop = false;
            BenefitsGroupBox.Text = "Benefits";
         
            // OtherBenefit2CheckBox
        
            OtherBenefit2CheckBox.AutoSize = true;
            OtherBenefit2CheckBox.Location = new Point(7, 120);
            OtherBenefit2CheckBox.Margin = new Padding(4, 3, 4, 3);
            OtherBenefit2CheckBox.Name = "OtherBenefit2CheckBox";
            OtherBenefit2CheckBox.Size = new Size(105, 19);
            OtherBenefit2CheckBox.TabIndex = 3;
            OtherBenefit2CheckBox.Text = "Other Benefit 2";
            OtherBenefit2CheckBox.UseVisualStyleBackColor = true;
        
            // OtherBenefit1CheckBox
         
            OtherBenefit1CheckBox.AutoSize = true;
            OtherBenefit1CheckBox.Location = new Point(7, 90);
            OtherBenefit1CheckBox.Margin = new Padding(4, 3, 4, 3);
            OtherBenefit1CheckBox.Name = "OtherBenefit1CheckBox";
            OtherBenefit1CheckBox.Size = new Size(105, 19);
            OtherBenefit1CheckBox.TabIndex = 2;
            OtherBenefit1CheckBox.Text = "Other Benefit 1";
            OtherBenefit1CheckBox.UseVisualStyleBackColor = true;
           
            // ConvenceCheckBox
           
            ConvenceCheckBox.AutoSize = true;
            ConvenceCheckBox.Location = new Point(7, 60);
            ConvenceCheckBox.Margin = new Padding(4, 3, 4, 3);
            ConvenceCheckBox.Name = "ConvenceCheckBox";
            ConvenceCheckBox.Size = new Size(91, 19);
            ConvenceCheckBox.TabIndex = 1;
            ConvenceCheckBox.Text = "Convence";
            ConvenceCheckBox.UseVisualStyleBackColor = true;
          
            // HousingCheckBox
         
            HousingCheckBox.AutoSize = true;
            HousingCheckBox.Location = new Point(7, 30);
            HousingCheckBox.Margin = new Padding(4, 3, 4, 3);
            HousingCheckBox.Name = "HousingCheckBox";
            HousingCheckBox.Size = new Size(71, 19);
            HousingCheckBox.TabIndex = 0;
            HousingCheckBox.Text = "Housing";
            HousingCheckBox.UseVisualStyleBackColor = true;
       
            // BonusesCheckedListBox
         
            BonusesCheckedListBox.FormattingEnabled = true;
            BonusesCheckedListBox.Items.AddRange(new object[] { "Project Completion Bonus", "Year End Bonus", "Performance Bonus", "Customer appreciation Bonus" });
            BonusesCheckedListBox.Location = new Point(19, 278);
            BonusesCheckedListBox.Margin = new Padding(4, 3, 4, 3);
            BonusesCheckedListBox.Name = "BonusesCheckedListBox";
            BonusesCheckedListBox.Size = new Size(233, 76);
            BonusesCheckedListBox.TabIndex = 6;
          
            // BonusesLabel
      
            BonusesLabel.AutoSize = true;
            BonusesLabel.Location = new Point(15, 255);
            BonusesLabel.Margin = new Padding(4, 0, 4, 0);
            BonusesLabel.Name = "BonusesLabel";
            BonusesLabel.Size = new Size(54, 15);
            BonusesLabel.TabIndex = 7;
            BonusesLabel.Text = "Bonuses:";
        
            // DeductionsGroupBox
         
            DeductionsGroupBox.Controls.Add(MedicalDeductionTextBox);
            DeductionsGroupBox.Controls.Add(ProvidentFundTextBox);
            DeductionsGroupBox.Location = new Point(284, 264);
            DeductionsGroupBox.Margin = new Padding(4, 3, 4, 3);
            DeductionsGroupBox.Name = "DeductionsGroupBox";
            DeductionsGroupBox.Padding = new Padding(4, 3, 4, 3);
            DeductionsGroupBox.Size = new Size(233, 90);
            DeductionsGroupBox.TabIndex = 12;
            DeductionsGroupBox.TabStop = false;
            DeductionsGroupBox.Text = "Deductions";
        
            // MedicalDeductionTextBox
         
            MedicalDeductionTextBox.Location = new Point(7, 52);
            MedicalDeductionTextBox.Margin = new Padding(4, 3, 4, 3);
            MedicalDeductionTextBox.Name = "MedicalDeductionTextBox";
            MedicalDeductionTextBox.Size = new Size(116, 23);
            MedicalDeductionTextBox.TabIndex = 1;
            MedicalDeductionTextBox.Text = "0";
      
            // ProvidentFundTextBox
     
            ProvidentFundTextBox.Location = new Point(7, 22);
            ProvidentFundTextBox.Margin = new Padding(4, 3, 4, 3);
            ProvidentFundTextBox.Name = "ProvidentFundTextBox";
            ProvidentFundTextBox.Size = new Size(116, 23);
            ProvidentFundTextBox.TabIndex = 0;
            ProvidentFundTextBox.Text = "0";
         
            // CalculateSalaryButton
      
            CalculateSalaryButton.Location = new Point(19, 373);
            CalculateSalaryButton.Margin = new Padding(4, 3, 4, 3);
            CalculateSalaryButton.Name = "CalculateSalaryButton";
            CalculateSalaryButton.Size = new Size(120, 27);
            CalculateSalaryButton.TabIndex = 10;
            CalculateSalaryButton.Text = "Calculate";
            CalculateSalaryButton.UseVisualStyleBackColor = true;
            CalculateSalaryButton.Click += CalculateSalaryButton_Click;
    
            // ExitButton
       
            ExitButton.Location = new Point(429, 373);
            ExitButton.Margin = new Padding(4, 3, 4, 3);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(88, 27);
            ExitButton.TabIndex = 11;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
         
            // Form1
         
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 423);
            Controls.Add(ExitButton);
            Controls.Add(CalculateSalaryButton);
            Controls.Add(DeductionsGroupBox);
            Controls.Add(BonusesLabel);
            Controls.Add(BonusesCheckedListBox);
            Controls.Add(BenefitsGroupBox);
            Controls.Add(SalaryGroupBox);
            Controls.Add(GradeComboBox);
            Controls.Add(GradeLabel);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = " Salary Calculator";
            SalaryGroupBox.ResumeLayout(false);
            SalaryGroupBox.PerformLayout();
            BenefitsGroupBox.ResumeLayout(false);
            BenefitsGroupBox.PerformLayout();
            DeductionsGroupBox.ResumeLayout(false);
            DeductionsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private TextBox NameTextBox;
        private Label GradeLabel;
        private ComboBox GradeComboBox;
        private GroupBox SalaryGroupBox;
        private RadioButton ProgrammerRadioButton;
        private RadioButton ProjectManagerRadioButton;
        private RadioButton ManagerRadioButton;
        private RadioButton DirectorRadioButton;
        private GroupBox BenefitsGroupBox;
        private CheckBox OtherBenefit2CheckBox;
        private CheckBox OtherBenefit1CheckBox;
        private CheckBox ConvenceCheckBox;
        private CheckBox HousingCheckBox;
        private CheckedListBox BonusesCheckedListBox;
        private Label BonusesLabel;
        private GroupBox DeductionsGroupBox;
        private TextBox ProvidentFundTextBox;
        private TextBox MedicalDeductionTextBox;
        private Button CalculateSalaryButton;
        private Button ExitButton;
        
    }
}