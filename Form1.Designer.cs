
namespace Database
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Middlename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Birth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.CheckBox();
            this.Femail = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.ButtonRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Name = "label1";
            // 
            // Nname
            // 
            resources.ApplyResources(this.Nname, "Nname");
            this.Nname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Nname.Name = "Nname";
            this.Nname.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Name = "label3";
            // 
            // Surname
            // 
            resources.ApplyResources(this.Surname, "Surname");
            this.Surname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Surname.Name = "Surname";
            this.Surname.TextChanged += new System.EventHandler(this.Surname_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Name = "label4";
            // 
            // Middlename
            // 
            resources.ApplyResources(this.Middlename, "Middlename");
            this.Middlename.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Middlename.Name = "Middlename";
            this.Middlename.TextChanged += new System.EventHandler(this.Middlename_TextChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Name = "label5";
            // 
            // Birth
            // 
            resources.ApplyResources(this.Birth, "Birth");
            this.Birth.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Birth.Name = "Birth";
            this.Birth.TextChanged += new System.EventHandler(this.Birth_TextChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Name = "label6";
            // 
            // Male
            // 
            resources.ApplyResources(this.Male, "Male");
            this.Male.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Male.Name = "Male";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // Femail
            // 
            resources.ApplyResources(this.Femail, "Femail");
            this.Femail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Femail.Name = "Femail";
            this.Femail.UseVisualStyleBackColor = true;
            this.Femail.CheckedChanged += new System.EventHandler(this.Femail_CheckedChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Name = "label7";
            // 
            // Phone
            // 
            resources.ApplyResources(this.Phone, "Phone");
            this.Phone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Phone.Name = "Phone";
            this.Phone.TextChanged += new System.EventHandler(this.Phone_TextChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Name = "label8";
            // 
            // Email
            // 
            resources.ApplyResources(this.Email, "Email");
            this.Email.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Email.Name = "Email";
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // ButtonRegistration
            // 
            resources.ApplyResources(this.ButtonRegistration, "ButtonRegistration");
            this.ButtonRegistration.Name = "ButtonRegistration";
            this.ButtonRegistration.UseVisualStyleBackColor = true;
            this.ButtonRegistration.Click += new System.EventHandler(this.ButtonRegistration_Click);
            // 
            // RegForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(205)))));
            this.Controls.Add(this.ButtonRegistration);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Femail);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Birth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Middlename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "RegForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Middlename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Birth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Male;
        private System.Windows.Forms.CheckBox Femail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Button ButtonRegistration;
    }
}

