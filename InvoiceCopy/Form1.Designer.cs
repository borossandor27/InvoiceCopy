
namespace InvoiceCopy
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_forras = new System.Windows.Forms.Label();
            this.label_Copy = new System.Windows.Forms.Label();
            this.label_Upload = new System.Windows.Forms.Label();
            this.label_err_path = new System.Windows.Forms.Label();
            this.label_log_path = new System.Windows.Forms.Label();
            this.checkBox_Validalas = new System.Windows.Forms.CheckBox();
            this.button_Change_forras = new System.Windows.Forms.Button();
            this.button_Change_Masolatok_helye = new System.Windows.Forms.Button();
            this.button_Change_upload_path = new System.Windows.Forms.Button();
            this.button_Change_notValid = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_view_forras = new System.Windows.Forms.Label();
            this.label_view_copyTo = new System.Windows.Forms.Label();
            this.label_view_upload = new System.Windows.Forms.Label();
            this.label_view_err = new System.Windows.Forms.Label();
            this.label_view_log = new System.Windows.Forms.Label();
            this.button_copy = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_counter_copy = new System.Windows.Forms.Label();
            this.label_counter_upload = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_forras
            // 
            this.label_forras.AutoSize = true;
            this.label_forras.Location = new System.Drawing.Point(207, 19);
            this.label_forras.Name = "label_forras";
            this.label_forras.Size = new System.Drawing.Size(145, 17);
            this.label_forras.TabIndex = 0;
            this.label_forras.Text = "Forrás tárolási  helye:";
            // 
            // label_Copy
            // 
            this.label_Copy.AutoSize = true;
            this.label_Copy.Location = new System.Drawing.Point(207, 61);
            this.label_Copy.Name = "label_Copy";
            this.label_Copy.Size = new System.Drawing.Size(164, 17);
            this.label_Copy.TabIndex = 0;
            this.label_Copy.Text = "Másolatok tárolási helye:";
            // 
            // label_Upload
            // 
            this.label_Upload.AutoSize = true;
            this.label_Upload.Location = new System.Drawing.Point(207, 103);
            this.label_Upload.Name = "label_Upload";
            this.label_Upload.Size = new System.Drawing.Size(103, 17);
            this.label_Upload.TabIndex = 0;
            this.label_Upload.Text = "Feltöltés helye:";
            // 
            // label_err_path
            // 
            this.label_err_path.AutoSize = true;
            this.label_err_path.Location = new System.Drawing.Point(207, 191);
            this.label_err_path.Name = "label_err_path";
            this.label_err_path.Size = new System.Drawing.Size(132, 17);
            this.label_err_path.TabIndex = 0;
            this.label_err_path.Text = "Nem valid-ok helye:";
            // 
            // label_log_path
            // 
            this.label_log_path.AutoSize = true;
            this.label_log_path.Location = new System.Drawing.Point(207, 233);
            this.label_log_path.Name = "label_log_path";
            this.label_log_path.Size = new System.Drawing.Size(96, 17);
            this.label_log_path.TabIndex = 0;
            this.label_log_path.Text = "Log fájl helye:";
            // 
            // checkBox_Validalas
            // 
            this.checkBox_Validalas.AutoSize = true;
            this.checkBox_Validalas.Location = new System.Drawing.Point(265, 145);
            this.checkBox_Validalas.Name = "checkBox_Validalas";
            this.checkBox_Validalas.Size = new System.Drawing.Size(214, 21);
            this.checkBox_Validalas.TabIndex = 1;
            this.checkBox_Validalas.Text = "Validálást kérek feltöltés előtt";
            this.checkBox_Validalas.UseVisualStyleBackColor = true;
            // 
            // button_Change_forras
            // 
            this.button_Change_forras.Location = new System.Drawing.Point(12, 12);
            this.button_Change_forras.Name = "button_Change_forras";
            this.button_Change_forras.Size = new System.Drawing.Size(153, 30);
            this.button_Change_forras.TabIndex = 2;
            this.button_Change_forras.Text = "Megnyitom";
            this.button_Change_forras.UseVisualStyleBackColor = true;
            this.button_Change_forras.Click += new System.EventHandler(this.button_Change_forras_Click);
            // 
            // button_Change_Masolatok_helye
            // 
            this.button_Change_Masolatok_helye.Location = new System.Drawing.Point(12, 54);
            this.button_Change_Masolatok_helye.Name = "button_Change_Masolatok_helye";
            this.button_Change_Masolatok_helye.Size = new System.Drawing.Size(153, 30);
            this.button_Change_Masolatok_helye.TabIndex = 2;
            this.button_Change_Masolatok_helye.Text = "Megnyitom";
            this.button_Change_Masolatok_helye.UseVisualStyleBackColor = true;
            this.button_Change_Masolatok_helye.Click += new System.EventHandler(this.button_Change_Masolatok_helye_Click);
            // 
            // button_Change_upload_path
            // 
            this.button_Change_upload_path.Location = new System.Drawing.Point(12, 96);
            this.button_Change_upload_path.Name = "button_Change_upload_path";
            this.button_Change_upload_path.Size = new System.Drawing.Size(153, 30);
            this.button_Change_upload_path.TabIndex = 2;
            this.button_Change_upload_path.Text = "Megnyitom";
            this.button_Change_upload_path.UseVisualStyleBackColor = true;
            this.button_Change_upload_path.Click += new System.EventHandler(this.button_Change_upload_path_Click);
            // 
            // button_Change_notValid
            // 
            this.button_Change_notValid.Location = new System.Drawing.Point(12, 184);
            this.button_Change_notValid.Name = "button_Change_notValid";
            this.button_Change_notValid.Size = new System.Drawing.Size(153, 30);
            this.button_Change_notValid.TabIndex = 2;
            this.button_Change_notValid.Text = "Megnyitom";
            this.button_Change_notValid.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 226);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 30);
            this.button5.TabIndex = 2;
            this.button5.Text = "Megnyitom";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(884, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Leállítás";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label_view_forras
            // 
            this.label_view_forras.AutoSize = true;
            this.label_view_forras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_view_forras.Location = new System.Drawing.Point(387, 19);
            this.label_view_forras.Name = "label_view_forras";
            this.label_view_forras.Size = new System.Drawing.Size(156, 20);
            this.label_view_forras.TabIndex = 4;
            this.label_view_forras.Text = "label_view_forras";
            // 
            // label_view_copyTo
            // 
            this.label_view_copyTo.AutoSize = true;
            this.label_view_copyTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_view_copyTo.Location = new System.Drawing.Point(387, 61);
            this.label_view_copyTo.Name = "label_view_copyTo";
            this.label_view_copyTo.Size = new System.Drawing.Size(59, 20);
            this.label_view_copyTo.TabIndex = 4;
            this.label_view_copyTo.Text = "label1";
            // 
            // label_view_upload
            // 
            this.label_view_upload.AutoSize = true;
            this.label_view_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_view_upload.Location = new System.Drawing.Point(387, 103);
            this.label_view_upload.Name = "label_view_upload";
            this.label_view_upload.Size = new System.Drawing.Size(59, 20);
            this.label_view_upload.TabIndex = 4;
            this.label_view_upload.Text = "label1";
            // 
            // label_view_err
            // 
            this.label_view_err.AutoSize = true;
            this.label_view_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_view_err.Location = new System.Drawing.Point(387, 191);
            this.label_view_err.Name = "label_view_err";
            this.label_view_err.Size = new System.Drawing.Size(59, 20);
            this.label_view_err.TabIndex = 4;
            this.label_view_err.Text = "label1";
            // 
            // label_view_log
            // 
            this.label_view_log.AutoSize = true;
            this.label_view_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_view_log.Location = new System.Drawing.Point(387, 233);
            this.label_view_log.Name = "label_view_log";
            this.label_view_log.Size = new System.Drawing.Size(59, 20);
            this.label_view_log.TabIndex = 4;
            this.label_view_log.Text = "label1";
            // 
            // button_copy
            // 
            this.button_copy.Location = new System.Drawing.Point(96, 319);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(237, 52);
            this.button_copy.TabIndex = 5;
            this.button_copy.Text = "Feltöltés indítása";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.ReadOnlyChecked = true;
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.button_copy_Click);
            // 
            // label_counter_copy
            // 
            this.label_counter_copy.AutoSize = true;
            this.label_counter_copy.ForeColor = System.Drawing.Color.Blue;
            this.label_counter_copy.Location = new System.Drawing.Point(486, 337);
            this.label_counter_copy.Name = "label_counter_copy";
            this.label_counter_copy.Size = new System.Drawing.Size(46, 17);
            this.label_counter_copy.TabIndex = 6;
            this.label_counter_copy.Text = "label1";
            // 
            // label_counter_upload
            // 
            this.label_counter_upload.AutoSize = true;
            this.label_counter_upload.ForeColor = System.Drawing.Color.Red;
            this.label_counter_upload.Location = new System.Drawing.Point(685, 337);
            this.label_counter_upload.Name = "label_counter_upload";
            this.label_counter_upload.Size = new System.Drawing.Size(46, 17);
            this.label_counter_upload.TabIndex = 7;
            this.label_counter_upload.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 401);
            this.Controls.Add(this.label_counter_upload);
            this.Controls.Add(this.label_counter_copy);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.label_view_log);
            this.Controls.Add(this.label_view_err);
            this.Controls.Add(this.label_view_upload);
            this.Controls.Add(this.label_view_copyTo);
            this.Controls.Add(this.label_view_forras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button_Change_notValid);
            this.Controls.Add(this.button_Change_upload_path);
            this.Controls.Add(this.button_Change_Masolatok_helye);
            this.Controls.Add(this.button_Change_forras);
            this.Controls.Add(this.checkBox_Validalas);
            this.Controls.Add(this.label_log_path);
            this.Controls.Add(this.label_err_path);
            this.Controls.Add(this.label_Upload);
            this.Controls.Add(this.label_Copy);
            this.Controls.Add(this.label_forras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PRES-470  -  DigitalStand SAP-ból feltöltés ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_forras;
        private System.Windows.Forms.Label label_Copy;
        private System.Windows.Forms.Label label_Upload;
        private System.Windows.Forms.Label label_err_path;
        private System.Windows.Forms.Label label_log_path;
        private System.Windows.Forms.CheckBox checkBox_Validalas;
        private System.Windows.Forms.Button button_Change_forras;
        private System.Windows.Forms.Button button_Change_Masolatok_helye;
        private System.Windows.Forms.Button button_Change_upload_path;
        private System.Windows.Forms.Button button_Change_notValid;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_view_forras;
        private System.Windows.Forms.Label label_view_copyTo;
        private System.Windows.Forms.Label label_view_upload;
        private System.Windows.Forms.Label label_view_err;
        private System.Windows.Forms.Label label_view_log;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_counter_copy;
        private System.Windows.Forms.Label label_counter_upload;
    }
}

