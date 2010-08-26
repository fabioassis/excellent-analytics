﻿using System.Reflection;
using System.Net;
using Analytics;
using System.IO;
namespace WPFUIv2
{
    partial class About
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
            this.AboutEA = new System.Windows.Forms.Label();
            this.linkLabelAboutEA = new System.Windows.Forms.LinkLabel();
            this.FAQ = new System.Windows.Forms.Label();
            this.linkLabelFAQ = new System.Windows.Forms.LinkLabel();
            this.Release = new System.Windows.Forms.Label();
            this.linkLabelRelease = new System.Windows.Forms.LinkLabel();
            this.linkLabelFeedback = new System.Windows.Forms.LinkLabel();
            this.Contact = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AboutEA
            // 
            this.AboutEA.AutoSize = true;
            this.AboutEA.Location = new System.Drawing.Point(15, 60);
            this.AboutEA.Name = "AboutEA";
            this.AboutEA.Size = new System.Drawing.Size(434, 13);
            this.AboutEA.TabIndex = 0;
            this.AboutEA.Text = "Excellent Analytics is an open source initiative. For more information about the " +
                "project, visit:";
            // 
            // linkLabelAboutEA
            // 
            this.linkLabelAboutEA.AutoSize = true;
            this.linkLabelAboutEA.Location = new System.Drawing.Point(15, 73);
            this.linkLabelAboutEA.Name = "linkLabelAboutEA";
            this.linkLabelAboutEA.Size = new System.Drawing.Size(181, 13);
            this.linkLabelAboutEA.TabIndex = 1;
            this.linkLabelAboutEA.TabStop = true;
            this.linkLabelAboutEA.Tag = "";
            this.linkLabelAboutEA.Text = "http://excellentanalytics.com/about/";
            this.linkLabelAboutEA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAboutEA_LinkClicked);
            // 
            // FAQ
            // 
            this.FAQ.AutoSize = true;
            this.FAQ.Location = new System.Drawing.Point(15, 123);
            this.FAQ.Name = "FAQ";
            this.FAQ.Size = new System.Drawing.Size(174, 13);
            this.FAQ.TabIndex = 2;
            this.FAQ.Text = "For answers to your questions, visit:";
            // 
            // linkLabelFAQ
            // 
            this.linkLabelFAQ.AutoSize = true;
            this.linkLabelFAQ.Location = new System.Drawing.Point(15, 136);
            this.linkLabelFAQ.Name = "linkLabelFAQ";
            this.linkLabelFAQ.Size = new System.Drawing.Size(169, 13);
            this.linkLabelFAQ.TabIndex = 3;
            this.linkLabelFAQ.TabStop = true;
            this.linkLabelFAQ.Text = "http://excellentanalytics.com/faq/";
            this.linkLabelFAQ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFAQ_LinkClicked);
            // 
            // Release
            // 
            this.Release.AutoSize = true;
            this.Release.Location = new System.Drawing.Point(15, 188);
            this.Release.Name = "Release";
            this.Release.Size = new System.Drawing.Size(175, 13);
            this.Release.TabIndex = 4;
            this.Release.Text = "Information about the latest release:";
            // 
            // linkLabelRelease
            // 
            this.linkLabelRelease.AutoSize = true;
            this.linkLabelRelease.Location = new System.Drawing.Point(15, 201);
            this.linkLabelRelease.Name = "linkLabelRelease";
            this.linkLabelRelease.Size = new System.Drawing.Size(229, 13);
            this.linkLabelRelease.TabIndex = 5;
            this.linkLabelRelease.TabStop = true;
            this.linkLabelRelease.Text = "http://feeds.feedburner.com/excellentanalytics";
            this.linkLabelRelease.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRelease_LinkClicked);
            // 
            // linkLabelMail
            // 
            this.linkLabelFeedback.AutoSize = true;
            this.linkLabelFeedback.Location = new System.Drawing.Point(65, 327);
            this.linkLabelFeedback.Name = "linkLabelMail";
            this.linkLabelFeedback.Size = new System.Drawing.Size(169, 13);
            this.linkLabelFeedback.TabIndex = 6;
            this.linkLabelFeedback.TabStop = true;
            this.linkLabelFeedback.Text = "feedback@excellentanalytics.com";
            this.linkLabelFeedback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFeedback_LinkClicked);
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Location = new System.Drawing.Point(12, 327);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(47, 13);
            this.Contact.TabIndex = 7;
            this.Contact.Text = "Contact:";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(430, 327);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 8;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 9;

            string uri = "http://excellentanalytics.com/wp-content/themes/dfblog/version.php";
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(uri);
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            this.label1.Text = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.linkLabelFeedback);
            this.Controls.Add(this.linkLabelRelease);
            this.Controls.Add(this.Release);
            this.Controls.Add(this.linkLabelFAQ);
            this.Controls.Add(this.FAQ);
            this.Controls.Add(this.linkLabelAboutEA);
            this.Controls.Add(this.AboutEA);
            this.Name = "About";
            this.Text = "About Excellent Analytics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutEA;
        private System.Windows.Forms.LinkLabel linkLabelAboutEA;
        private System.Windows.Forms.Label FAQ;
        private System.Windows.Forms.LinkLabel linkLabelFAQ;
        private System.Windows.Forms.Label Release;
        private System.Windows.Forms.LinkLabel linkLabelRelease;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.LinkLabel linkLabelFeedback;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        

    }
}