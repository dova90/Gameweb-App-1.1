﻿namespace GameWeb
{
    partial class AddGameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGameForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gameName = new System.Windows.Forms.TextBox();
            this.add_countryButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.countriesChoice = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.genresBox = new System.Windows.Forms.CheckedListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gameName);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 73);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Title";
            // 
            // gameName
            // 
            this.gameName.Location = new System.Drawing.Point(13, 36);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(233, 20);
            this.gameName.TabIndex = 0;
            this.gameName.Validating += new System.ComponentModel.CancelEventHandler(this.name_Validating);
            this.gameName.Validated += new System.EventHandler(this.name_Validated);
            // 
            // add_countryButton
            // 
            this.add_countryButton.Location = new System.Drawing.Point(146, 396);
            this.add_countryButton.Name = "add_countryButton";
            this.add_countryButton.Size = new System.Drawing.Size(136, 42);
            this.add_countryButton.TabIndex = 4;
            this.add_countryButton.Text = "Add Game";
            this.add_countryButton.UseVisualStyleBackColor = true;
            this.add_countryButton.Click += new System.EventHandler(this.add_countryButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.countriesChoice);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 61);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // countriesChoice
            // 
            this.countriesChoice.FormattingEnabled = true;
            this.countriesChoice.Location = new System.Drawing.Point(13, 28);
            this.countriesChoice.Name = "countriesChoice";
            this.countriesChoice.Size = new System.Drawing.Size(233, 21);
            this.countriesChoice.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.genresBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 217);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Genre";
            // 
            // genresBox
            // 
            this.genresBox.FormattingEnabled = true;
            this.genresBox.Location = new System.Drawing.Point(13, 19);
            this.genresBox.Name = "genresBox";
            this.genresBox.Size = new System.Drawing.Size(233, 184);
            this.genresBox.TabIndex = 0;
            this.genresBox.Validating += new System.ComponentModel.CancelEventHandler(this.genresBox_Validating);
            this.genresBox.Validated += new System.EventHandler(this.genresBox_Validated);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(294, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.add_countryButton);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddGameForm";
            this.Text = "Add Game";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button add_countryButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox countriesChoice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox genresBox;
        private System.Windows.Forms.TextBox gameName;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}