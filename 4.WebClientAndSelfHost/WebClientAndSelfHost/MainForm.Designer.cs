namespace WebClientAndSelfHost
{
    partial class MainForm
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
            this.btnGetRequest = new System.Windows.Forms.Button();
            this.gbGetMethod = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPostRequest = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstNamePost = new System.Windows.Forms.TextBox();
            this.txtLastNamePost = new System.Windows.Forms.TextBox();
            this.btnSendRequestPost = new System.Windows.Forms.Button();
            this.gbGetMethod.SuspendLayout();
            this.gbPostRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetRequest
            // 
            this.btnGetRequest.Location = new System.Drawing.Point(224, 19);
            this.btnGetRequest.Name = "btnGetRequest";
            this.btnGetRequest.Size = new System.Drawing.Size(175, 36);
            this.btnGetRequest.TabIndex = 0;
            this.btnGetRequest.Text = "Відправити запит";
            this.btnGetRequest.UseVisualStyleBackColor = true;
            this.btnGetRequest.Click += new System.EventHandler(this.btnTestServer_Click);
            // 
            // gbGetMethod
            // 
            this.gbGetMethod.Controls.Add(this.label2);
            this.gbGetMethod.Controls.Add(this.label1);
            this.gbGetMethod.Controls.Add(this.txtFirstName);
            this.gbGetMethod.Controls.Add(this.txtLastName);
            this.gbGetMethod.Controls.Add(this.btnGetRequest);
            this.gbGetMethod.Location = new System.Drawing.Point(27, 21);
            this.gbGetMethod.Name = "gbGetMethod";
            this.gbGetMethod.Size = new System.Drawing.Size(405, 123);
            this.gbGetMethod.TabIndex = 1;
            this.gbGetMethod.TabStop = false;
            this.gbGetMethod.Text = "Запрос методом GET";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(14, 35);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(196, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Прізвище";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(14, 78);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(196, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ім\'я";
            // 
            // gbPostRequest
            // 
            this.gbPostRequest.Controls.Add(this.label3);
            this.gbPostRequest.Controls.Add(this.label4);
            this.gbPostRequest.Controls.Add(this.txtFirstNamePost);
            this.gbPostRequest.Controls.Add(this.txtLastNamePost);
            this.gbPostRequest.Controls.Add(this.btnSendRequestPost);
            this.gbPostRequest.Location = new System.Drawing.Point(27, 166);
            this.gbPostRequest.Name = "gbPostRequest";
            this.gbPostRequest.Size = new System.Drawing.Size(405, 123);
            this.gbPostRequest.TabIndex = 2;
            this.gbPostRequest.TabStop = false;
            this.gbPostRequest.Text = "Запрос методом POST";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ім\'я";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Прізвище";
            // 
            // txtFirstNamePost
            // 
            this.txtFirstNamePost.Location = new System.Drawing.Point(14, 78);
            this.txtFirstNamePost.Name = "txtFirstNamePost";
            this.txtFirstNamePost.Size = new System.Drawing.Size(196, 20);
            this.txtFirstNamePost.TabIndex = 2;
            // 
            // txtLastNamePost
            // 
            this.txtLastNamePost.Location = new System.Drawing.Point(14, 35);
            this.txtLastNamePost.Name = "txtLastNamePost";
            this.txtLastNamePost.Size = new System.Drawing.Size(196, 20);
            this.txtLastNamePost.TabIndex = 2;
            // 
            // btnSendRequestPost
            // 
            this.btnSendRequestPost.Location = new System.Drawing.Point(224, 19);
            this.btnSendRequestPost.Name = "btnSendRequestPost";
            this.btnSendRequestPost.Size = new System.Drawing.Size(175, 36);
            this.btnSendRequestPost.TabIndex = 0;
            this.btnSendRequestPost.Text = "Відправити запит";
            this.btnSendRequestPost.UseVisualStyleBackColor = true;
            this.btnSendRequestPost.Click += new System.EventHandler(this.btnSendRequestPost_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 380);
            this.Controls.Add(this.gbPostRequest);
            this.Controls.Add(this.gbGetMethod);
            this.Name = "MainForm";
            this.Text = "Тестування SelfHosting";
            this.gbGetMethod.ResumeLayout(false);
            this.gbGetMethod.PerformLayout();
            this.gbPostRequest.ResumeLayout(false);
            this.gbPostRequest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetRequest;
        private System.Windows.Forms.GroupBox gbGetMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox gbPostRequest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstNamePost;
        private System.Windows.Forms.TextBox txtLastNamePost;
        private System.Windows.Forms.Button btnSendRequestPost;
    }
}

