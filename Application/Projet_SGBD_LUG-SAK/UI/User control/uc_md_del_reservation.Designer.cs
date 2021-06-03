﻿
namespace UI.User_control
{
    partial class uc_md_del_reservation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uc_btn_res_modify = new System.Windows.Forms.Button();
            this.uc_res_change_heur_deb = new System.Windows.Forms.ComboBox();
            this.uc_res_change_machine = new System.Windows.Forms.ComboBox();
            this.uc_res_change_nom = new System.Windows.Forms.ComboBox();
            this.uc_res_id = new System.Windows.Forms.TextBox();
            this.uc_res_change_date = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uc_btn_res_delet = new System.Windows.Forms.Button();
            this.uc_btn_res_cancel = new System.Windows.Forms.Button();
            this.uc_res_change_annul = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.uc_res_change_prevu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uc_res_change_heur_fin = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.res_binding_source = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.res_binding_source)).BeginInit();
            this.SuspendLayout();
            // 
            // uc_btn_res_modify
            // 
            this.uc_btn_res_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_btn_res_modify.Location = new System.Drawing.Point(4, 555);
            this.uc_btn_res_modify.Name = "uc_btn_res_modify";
            this.uc_btn_res_modify.Size = new System.Drawing.Size(110, 34);
            this.uc_btn_res_modify.TabIndex = 23;
            this.uc_btn_res_modify.Text = "Modify";
            this.uc_btn_res_modify.UseVisualStyleBackColor = true;
            // 
            // uc_res_change_heur_deb
            // 
            this.uc_res_change_heur_deb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.res_binding_source, "Res_hr_deb", true));
            this.uc_res_change_heur_deb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uc_res_change_heur_deb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_res_change_heur_deb.FormattingEnabled = true;
            this.uc_res_change_heur_deb.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.uc_res_change_heur_deb.Location = new System.Drawing.Point(94, 329);
            this.uc_res_change_heur_deb.Name = "uc_res_change_heur_deb";
            this.uc_res_change_heur_deb.Size = new System.Drawing.Size(121, 28);
            this.uc_res_change_heur_deb.TabIndex = 22;
            // 
            // uc_res_change_machine
            // 
            this.uc_res_change_machine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_res_change_machine.FormattingEnabled = true;
            this.uc_res_change_machine.Location = new System.Drawing.Point(94, 69);
            this.uc_res_change_machine.Name = "uc_res_change_machine";
            this.uc_res_change_machine.Size = new System.Drawing.Size(206, 28);
            this.uc_res_change_machine.TabIndex = 21;
            // 
            // uc_res_change_nom
            // 
            this.uc_res_change_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_res_change_nom.FormattingEnabled = true;
            this.uc_res_change_nom.Location = new System.Drawing.Point(94, 33);
            this.uc_res_change_nom.Name = "uc_res_change_nom";
            this.uc_res_change_nom.Size = new System.Drawing.Size(206, 28);
            this.uc_res_change_nom.TabIndex = 20;
            // 
            // uc_res_id
            // 
            this.uc_res_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.res_binding_source, "Res_ID", true));
            this.uc_res_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_res_id.Location = new System.Drawing.Point(94, 3);
            this.uc_res_id.Name = "uc_res_id";
            this.uc_res_id.Size = new System.Drawing.Size(100, 26);
            this.uc_res_id.TabIndex = 19;
            // 
            // uc_res_change_date
            // 
            this.uc_res_change_date.DataBindings.Add(new System.Windows.Forms.Binding("SelectionRange", this.res_binding_source, "Res_date", true));
            this.uc_res_change_date.Location = new System.Drawing.Point(94, 110);
            this.uc_res_change_date.Name = "uc_res_change_date";
            this.uc_res_change_date.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Heur:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Machine:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "NOM:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "RÉS - ID:";
            // 
            // uc_btn_res_delet
            // 
            this.uc_btn_res_delet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_btn_res_delet.Location = new System.Drawing.Point(190, 555);
            this.uc_btn_res_delet.Name = "uc_btn_res_delet";
            this.uc_btn_res_delet.Size = new System.Drawing.Size(110, 34);
            this.uc_btn_res_delet.TabIndex = 24;
            this.uc_btn_res_delet.Text = "Delete";
            this.uc_btn_res_delet.UseVisualStyleBackColor = true;
            // 
            // uc_btn_res_cancel
            // 
            this.uc_btn_res_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_btn_res_cancel.Location = new System.Drawing.Point(94, 595);
            this.uc_btn_res_cancel.Name = "uc_btn_res_cancel";
            this.uc_btn_res_cancel.Size = new System.Drawing.Size(110, 34);
            this.uc_btn_res_cancel.TabIndex = 25;
            this.uc_btn_res_cancel.Text = "Cancel";
            this.uc_btn_res_cancel.UseVisualStyleBackColor = true;
            this.uc_btn_res_cancel.Click += new System.EventHandler(this.uc_btn_res_cancel_Click);
            // 
            // uc_res_change_annul
            // 
            this.uc_res_change_annul.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.res_binding_source, "Res_est_annule", true));
            this.uc_res_change_annul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uc_res_change_annul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_res_change_annul.FormattingEnabled = true;
            this.uc_res_change_annul.Items.AddRange(new object[] {
            "OUI",
            "NON"});
            this.uc_res_change_annul.Location = new System.Drawing.Point(94, 415);
            this.uc_res_change_annul.Name = "uc_res_change_annul";
            this.uc_res_change_annul.Size = new System.Drawing.Size(121, 28);
            this.uc_res_change_annul.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-1, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 43);
            this.label8.TabIndex = 30;
            this.label8.Text = "Résér. est annulée:";
            // 
            // uc_res_change_prevu
            // 
            this.uc_res_change_prevu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.res_binding_source, "Res_est_prevenu", true));
            this.uc_res_change_prevu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uc_res_change_prevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_res_change_prevu.FormattingEnabled = true;
            this.uc_res_change_prevu.Items.AddRange(new object[] {
            "OUI",
            "NON"});
            this.uc_res_change_prevu.Location = new System.Drawing.Point(94, 458);
            this.uc_res_change_prevu.Name = "uc_res_change_prevu";
            this.uc_res_change_prevu.Size = new System.Drawing.Size(121, 28);
            this.uc_res_change_prevu.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-1, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 41);
            this.label7.TabIndex = 28;
            this.label7.Text = "Résér. est prevu:";
            // 
            // uc_res_change_heur_fin
            // 
            this.uc_res_change_heur_fin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.res_binding_source, "Res_hr_fin", true));
            this.uc_res_change_heur_fin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uc_res_change_heur_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_res_change_heur_fin.FormattingEnabled = true;
            this.uc_res_change_heur_fin.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.uc_res_change_heur_fin.Location = new System.Drawing.Point(94, 372);
            this.uc_res_change_heur_fin.Name = "uc_res_change_heur_fin";
            this.uc_res_change_heur_fin.Size = new System.Drawing.Size(121, 28);
            this.uc_res_change_heur_fin.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-1, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "Heur fin:";
            // 
            // res_binding_source
            // 
            this.res_binding_source.DataSource = typeof(DTO.RES);
            // 
            // uc_md_del_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uc_res_change_annul);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uc_res_change_prevu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uc_res_change_heur_fin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uc_btn_res_cancel);
            this.Controls.Add(this.uc_btn_res_delet);
            this.Controls.Add(this.uc_btn_res_modify);
            this.Controls.Add(this.uc_res_change_heur_deb);
            this.Controls.Add(this.uc_res_change_machine);
            this.Controls.Add(this.uc_res_change_nom);
            this.Controls.Add(this.uc_res_id);
            this.Controls.Add(this.uc_res_change_date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uc_md_del_reservation";
            this.Size = new System.Drawing.Size(305, 636);
            ((System.ComponentModel.ISupportInitialize)(this.res_binding_source)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uc_btn_res_modify;
        private System.Windows.Forms.ComboBox uc_res_change_heur_deb;
        private System.Windows.Forms.ComboBox uc_res_change_machine;
        private System.Windows.Forms.ComboBox uc_res_change_nom;
        private System.Windows.Forms.TextBox uc_res_id;
        private System.Windows.Forms.MonthCalendar uc_res_change_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uc_btn_res_delet;
        private System.Windows.Forms.Button uc_btn_res_cancel;
        private System.Windows.Forms.ComboBox uc_res_change_annul;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox uc_res_change_prevu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox uc_res_change_heur_fin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource res_binding_source;
    }
}
