namespace TicketBookingSystem
{
    partial class PlaysForm
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
            this.ReviewsReadb = new System.Windows.Forms.Button();
            this.AddBack = new System.Windows.Forms.Button();
            this.SearchDateB = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.ticketSysDBDataSet = new TicketBookingSystem.TicketSysDBDataSet();
            this.playsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playsTableAdapter = new TicketBookingSystem.TicketSysDBDataSetTableAdapters.PlaysTableAdapter();
            this.playsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BookTickB = new System.Windows.Forms.Button();
            this.AllPlaysl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.playTitleTextBox = new System.Windows.Forms.TextBox();
            this.PlayTitlel = new System.Windows.Forms.Label();
            this.PlayDatel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SearchGenrel = new System.Windows.Forms.Label();
            this.SearchGenreb = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckValuel = new System.Windows.Forms.Label();
            this.ReviewTextBox = new System.Windows.Forms.TextBox();
            this.BookTimel = new System.Windows.Forms.Label();
            this.Currentl = new System.Windows.Forms.Label();
            this.BookDatel = new System.Windows.Forms.Label();
            this.BookTitlel = new System.Windows.Forms.Label();
            this.CurrTotal = new System.Windows.Forms.Label();
            this.OAPUpDn = new System.Windows.Forms.NumericUpDown();
            this.ChildUpDn = new System.Windows.Forms.NumericUpDown();
            this.StandardUpDn = new System.Windows.Forms.NumericUpDown();
            this.OAPPl = new System.Windows.Forms.Label();
            this.ChildPl = new System.Windows.Forms.Label();
            this.StandardPl = new System.Windows.Forms.Label();
            this.OAPl = new System.Windows.Forms.Label();
            this.Childl = new System.Windows.Forms.Label();
            this.Standardl = new System.Windows.Forms.Label();
            this.RadioBandC = new System.Windows.Forms.RadioButton();
            this.RadioBandB = new System.Windows.Forms.RadioButton();
            this.RadioBandA = new System.Windows.Forms.RadioButton();
            this.BookConfb = new System.Windows.Forms.Button();
            this.TimeBox = new System.Windows.Forms.ComboBox();
            this.ReviewsWriteB = new System.Windows.Forms.Button();
            this.ConfirmReview = new System.Windows.Forms.Button();
            this.DeleteReviewBox = new System.Windows.Forms.TextBox();
            this.DeleteReviewb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSysDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playsBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OAPUpDn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildUpDn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StandardUpDn)).BeginInit();
            this.SuspendLayout();
            // 
            // ReviewsReadb
            // 
            this.ReviewsReadb.Location = new System.Drawing.Point(295, 306);
            this.ReviewsReadb.Name = "ReviewsReadb";
            this.ReviewsReadb.Size = new System.Drawing.Size(92, 23);
            this.ReviewsReadb.TabIndex = 1;
            this.ReviewsReadb.Text = "Read Reviews";
            this.ReviewsReadb.UseVisualStyleBackColor = true;
            this.ReviewsReadb.Visible = false;
            this.ReviewsReadb.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddBack
            // 
            this.AddBack.Location = new System.Drawing.Point(387, 287);
            this.AddBack.Name = "AddBack";
            this.AddBack.Size = new System.Drawing.Size(75, 23);
            this.AddBack.TabIndex = 17;
            this.AddBack.Text = "Back";
            this.AddBack.UseVisualStyleBackColor = true;
            this.AddBack.Visible = false;
            this.AddBack.Click += new System.EventHandler(this.AddBack_Click);
            // 
            // SearchDateB
            // 
            this.SearchDateB.Location = new System.Drawing.Point(387, 135);
            this.SearchDateB.Name = "SearchDateB";
            this.SearchDateB.Size = new System.Drawing.Size(75, 23);
            this.SearchDateB.TabIndex = 32;
            this.SearchDateB.Text = "Search";
            this.SearchDateB.UseVisualStyleBackColor = true;
            this.SearchDateB.Click += new System.EventHandler(this.SearchDateB_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(262, 95);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 34;
            this.dateTimePicker2.Value = new System.DateTime(2019, 3, 20, 0, 0, 0, 0);
            // 
            // ticketSysDBDataSet
            // 
            this.ticketSysDBDataSet.DataSetName = "TicketSysDBDataSet";
            this.ticketSysDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playsBindingSource
            // 
            this.playsBindingSource.DataMember = "Plays";
            this.playsBindingSource.DataSource = this.ticketSysDBDataSet;
            // 
            // playsTableAdapter
            // 
            this.playsTableAdapter.ClearBeforeFill = true;
            // 
            // playsBindingSource1
            // 
            this.playsBindingSource1.DataMember = "Plays";
            this.playsBindingSource1.DataSource = this.ticketSysDBDataSet;
            // 
            // BookTickB
            // 
            this.BookTickB.Location = new System.Drawing.Point(214, 306);
            this.BookTickB.Name = "BookTickB";
            this.BookTickB.Size = new System.Drawing.Size(75, 23);
            this.BookTickB.TabIndex = 37;
            this.BookTickB.Text = "Book Ticket";
            this.BookTickB.UseVisualStyleBackColor = true;
            this.BookTickB.Visible = false;
            this.BookTickB.Click += new System.EventHandler(this.BookTickB_Click_1);
            // 
            // AllPlaysl
            // 
            this.AllPlaysl.Location = new System.Drawing.Point(18, 123);
            this.AllPlaysl.MaximumSize = new System.Drawing.Size(3000, 3000);
            this.AllPlaysl.Name = "AllPlaysl";
            this.AllPlaysl.Size = new System.Drawing.Size(350, 180);
            this.AllPlaysl.TabIndex = 18;
            this.AllPlaysl.Text = "Please Select a date";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 308);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.Visible = false;
            // 
            // playTitleTextBox
            // 
            this.playTitleTextBox.Location = new System.Drawing.Point(262, 32);
            this.playTitleTextBox.Name = "playTitleTextBox";
            this.playTitleTextBox.Size = new System.Drawing.Size(200, 20);
            this.playTitleTextBox.TabIndex = 38;
            // 
            // PlayTitlel
            // 
            this.PlayTitlel.AutoSize = true;
            this.PlayTitlel.Location = new System.Drawing.Point(278, 16);
            this.PlayTitlel.Name = "PlayTitlel";
            this.PlayTitlel.Size = new System.Drawing.Size(81, 13);
            this.PlayTitlel.TabIndex = 39;
            this.PlayTitlel.Text = "Enter Play Title ";
            // 
            // PlayDatel
            // 
            this.PlayDatel.AutoSize = true;
            this.PlayDatel.Location = new System.Drawing.Point(278, 79);
            this.PlayDatel.Name = "PlayDatel";
            this.PlayDatel.Size = new System.Drawing.Size(84, 13);
            this.PlayDatel.TabIndex = 40;
            this.PlayDatel.Text = "Enter Play Date ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Drama",
            "Comedy",
            "Classical",
            "Opera",
            "Pantomime",
            "Tragedy"});
            this.comboBox2.Location = new System.Drawing.Point(23, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(184, 21);
            this.comboBox2.TabIndex = 41;
            // 
            // SearchGenrel
            // 
            this.SearchGenrel.AutoSize = true;
            this.SearchGenrel.Location = new System.Drawing.Point(20, 15);
            this.SearchGenrel.Name = "SearchGenrel";
            this.SearchGenrel.Size = new System.Drawing.Size(88, 13);
            this.SearchGenrel.TabIndex = 42;
            this.SearchGenrel.Text = "Search By Genre";
            // 
            // SearchGenreb
            // 
            this.SearchGenreb.Location = new System.Drawing.Point(132, 58);
            this.SearchGenreb.Name = "SearchGenreb";
            this.SearchGenreb.Size = new System.Drawing.Size(75, 23);
            this.SearchGenreb.TabIndex = 43;
            this.SearchGenreb.Text = "Search";
            this.SearchGenreb.UseVisualStyleBackColor = true;
            this.SearchGenreb.Click += new System.EventHandler(this.SearchGenreb_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CheckValuel);
            this.panel1.Controls.Add(this.ReviewTextBox);
            this.panel1.Controls.Add(this.BookTimel);
            this.panel1.Controls.Add(this.Currentl);
            this.panel1.Controls.Add(this.BookDatel);
            this.panel1.Controls.Add(this.BookTitlel);
            this.panel1.Controls.Add(this.CurrTotal);
            this.panel1.Controls.Add(this.OAPUpDn);
            this.panel1.Controls.Add(this.ChildUpDn);
            this.panel1.Controls.Add(this.StandardUpDn);
            this.panel1.Controls.Add(this.OAPPl);
            this.panel1.Controls.Add(this.ChildPl);
            this.panel1.Controls.Add(this.StandardPl);
            this.panel1.Controls.Add(this.OAPl);
            this.panel1.Controls.Add(this.Childl);
            this.panel1.Controls.Add(this.Standardl);
            this.panel1.Controls.Add(this.RadioBandC);
            this.panel1.Controls.Add(this.RadioBandB);
            this.panel1.Controls.Add(this.RadioBandA);
            this.panel1.Controls.Add(this.BookConfb);
            this.panel1.Location = new System.Drawing.Point(12, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 161);
            this.panel1.TabIndex = 44;
            this.panel1.Visible = false;
            // 
            // CheckValuel
            // 
            this.CheckValuel.AutoSize = true;
            this.CheckValuel.Location = new System.Drawing.Point(175, 145);
            this.CheckValuel.Name = "CheckValuel";
            this.CheckValuel.Size = new System.Drawing.Size(34, 13);
            this.CheckValuel.TabIndex = 59;
            this.CheckValuel.Text = "Value";
            // 
            // ReviewTextBox
            // 
            this.ReviewTextBox.Location = new System.Drawing.Point(9, -2);
            this.ReviewTextBox.Multiline = true;
            this.ReviewTextBox.Name = "ReviewTextBox";
            this.ReviewTextBox.Size = new System.Drawing.Size(355, 160);
            this.ReviewTextBox.TabIndex = 47;
            this.ReviewTextBox.Visible = false;
            // 
            // BookTimel
            // 
            this.BookTimel.AutoSize = true;
            this.BookTimel.Location = new System.Drawing.Point(232, 6);
            this.BookTimel.Name = "BookTimel";
            this.BookTimel.Size = new System.Drawing.Size(34, 13);
            this.BookTimel.TabIndex = 57;
            this.BookTimel.Text = "14:00";
            // 
            // Currentl
            // 
            this.Currentl.AutoSize = true;
            this.Currentl.Location = new System.Drawing.Point(8, 135);
            this.Currentl.Name = "Currentl";
            this.Currentl.Size = new System.Drawing.Size(44, 13);
            this.Currentl.TabIndex = 56;
            this.Currentl.Text = "Current:";
            // 
            // BookDatel
            // 
            this.BookDatel.AutoSize = true;
            this.BookDatel.Location = new System.Drawing.Point(141, 6);
            this.BookDatel.Name = "BookDatel";
            this.BookDatel.Size = new System.Drawing.Size(30, 13);
            this.BookDatel.TabIndex = 55;
            this.BookDatel.Text = "Date";
            // 
            // BookTitlel
            // 
            this.BookTitlel.AutoSize = true;
            this.BookTitlel.Location = new System.Drawing.Point(8, 6);
            this.BookTitlel.Name = "BookTitlel";
            this.BookTitlel.Size = new System.Drawing.Size(27, 13);
            this.BookTitlel.TabIndex = 45;
            this.BookTitlel.Text = "Title";
            // 
            // CurrTotal
            // 
            this.CurrTotal.AutoSize = true;
            this.CurrTotal.Location = new System.Drawing.Point(55, 135);
            this.CurrTotal.Name = "CurrTotal";
            this.CurrTotal.Size = new System.Drawing.Size(41, 13);
            this.CurrTotal.TabIndex = 54;
            this.CurrTotal.Text = "Current";
            // 
            // OAPUpDn
            // 
            this.OAPUpDn.Location = new System.Drawing.Point(178, 107);
            this.OAPUpDn.Name = "OAPUpDn";
            this.OAPUpDn.Size = new System.Drawing.Size(30, 20);
            this.OAPUpDn.TabIndex = 53;
            this.OAPUpDn.ValueChanged += new System.EventHandler(this.OAPUpDn_ValueChanged);
            // 
            // ChildUpDn
            // 
            this.ChildUpDn.Location = new System.Drawing.Point(90, 107);
            this.ChildUpDn.Name = "ChildUpDn";
            this.ChildUpDn.Size = new System.Drawing.Size(30, 20);
            this.ChildUpDn.TabIndex = 52;
            this.ChildUpDn.ValueChanged += new System.EventHandler(this.ChildUpDn_ValueChanged);
            // 
            // StandardUpDn
            // 
            this.StandardUpDn.Location = new System.Drawing.Point(9, 107);
            this.StandardUpDn.Name = "StandardUpDn";
            this.StandardUpDn.Size = new System.Drawing.Size(30, 20);
            this.StandardUpDn.TabIndex = 51;
            this.StandardUpDn.ValueChanged += new System.EventHandler(this.StandardUpDn_ValueChanged);
            // 
            // OAPPl
            // 
            this.OAPPl.AutoSize = true;
            this.OAPPl.Location = new System.Drawing.Point(175, 87);
            this.OAPPl.Name = "OAPPl";
            this.OAPPl.Size = new System.Drawing.Size(50, 13);
            this.OAPPl.TabIndex = 50;
            this.OAPPl.Text = "Standard";
            // 
            // ChildPl
            // 
            this.ChildPl.AutoSize = true;
            this.ChildPl.Location = new System.Drawing.Point(87, 87);
            this.ChildPl.Name = "ChildPl";
            this.ChildPl.Size = new System.Drawing.Size(50, 13);
            this.ChildPl.TabIndex = 49;
            this.ChildPl.Text = "Standard";
            // 
            // StandardPl
            // 
            this.StandardPl.AutoSize = true;
            this.StandardPl.Location = new System.Drawing.Point(6, 87);
            this.StandardPl.Name = "StandardPl";
            this.StandardPl.Size = new System.Drawing.Size(50, 13);
            this.StandardPl.TabIndex = 48;
            this.StandardPl.Text = "Standard";
            // 
            // OAPl
            // 
            this.OAPl.AutoSize = true;
            this.OAPl.Location = new System.Drawing.Point(186, 74);
            this.OAPl.Name = "OAPl";
            this.OAPl.Size = new System.Drawing.Size(29, 13);
            this.OAPl.TabIndex = 47;
            this.OAPl.Text = "OAP";
            // 
            // Childl
            // 
            this.Childl.AutoSize = true;
            this.Childl.Location = new System.Drawing.Point(96, 74);
            this.Childl.Name = "Childl";
            this.Childl.Size = new System.Drawing.Size(30, 13);
            this.Childl.TabIndex = 46;
            this.Childl.Text = "Child";
            // 
            // Standardl
            // 
            this.Standardl.AutoSize = true;
            this.Standardl.Location = new System.Drawing.Point(6, 74);
            this.Standardl.Name = "Standardl";
            this.Standardl.Size = new System.Drawing.Size(50, 13);
            this.Standardl.TabIndex = 45;
            this.Standardl.Text = "Standard";
            // 
            // RadioBandC
            // 
            this.RadioBandC.AutoSize = true;
            this.RadioBandC.Location = new System.Drawing.Point(202, 34);
            this.RadioBandC.Name = "RadioBandC";
            this.RadioBandC.Size = new System.Drawing.Size(90, 17);
            this.RadioBandC.TabIndex = 3;
            this.RadioBandC.TabStop = true;
            this.RadioBandC.Text = "Band C Seats";
            this.RadioBandC.UseVisualStyleBackColor = true;
            this.RadioBandC.CheckedChanged += new System.EventHandler(this.RadioBandC_CheckedChanged);
            // 
            // RadioBandB
            // 
            this.RadioBandB.AutoSize = true;
            this.RadioBandB.Location = new System.Drawing.Point(105, 34);
            this.RadioBandB.Name = "RadioBandB";
            this.RadioBandB.Size = new System.Drawing.Size(90, 17);
            this.RadioBandB.TabIndex = 2;
            this.RadioBandB.TabStop = true;
            this.RadioBandB.Text = "Band B Seats";
            this.RadioBandB.UseVisualStyleBackColor = true;
            this.RadioBandB.CheckedChanged += new System.EventHandler(this.RadioBandB_CheckedChanged);
            // 
            // RadioBandA
            // 
            this.RadioBandA.AutoSize = true;
            this.RadioBandA.Checked = true;
            this.RadioBandA.Location = new System.Drawing.Point(9, 34);
            this.RadioBandA.Name = "RadioBandA";
            this.RadioBandA.Size = new System.Drawing.Size(90, 17);
            this.RadioBandA.TabIndex = 1;
            this.RadioBandA.TabStop = true;
            this.RadioBandA.Text = "Band A Seats";
            this.RadioBandA.UseVisualStyleBackColor = true;
            this.RadioBandA.CheckedChanged += new System.EventHandler(this.RadioBandA_CheckedChanged);
            // 
            // BookConfb
            // 
            this.BookConfb.Location = new System.Drawing.Point(291, 135);
            this.BookConfb.Name = "BookConfb";
            this.BookConfb.Size = new System.Drawing.Size(75, 23);
            this.BookConfb.TabIndex = 0;
            this.BookConfb.Text = "Confirm";
            this.BookConfb.UseVisualStyleBackColor = true;
            this.BookConfb.Click += new System.EventHandler(this.BookConfb_Click);
            // 
            // TimeBox
            // 
            this.TimeBox.FormattingEnabled = true;
            this.TimeBox.Location = new System.Drawing.Point(12, 332);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(184, 21);
            this.TimeBox.TabIndex = 45;
            this.TimeBox.Visible = false;
            // 
            // ReviewsWriteB
            // 
            this.ReviewsWriteB.Location = new System.Drawing.Point(295, 335);
            this.ReviewsWriteB.Name = "ReviewsWriteB";
            this.ReviewsWriteB.Size = new System.Drawing.Size(93, 23);
            this.ReviewsWriteB.TabIndex = 46;
            this.ReviewsWriteB.Text = "Write Review";
            this.ReviewsWriteB.UseVisualStyleBackColor = true;
            this.ReviewsWriteB.Visible = false;
            this.ReviewsWriteB.Click += new System.EventHandler(this.ReviewsWriteB_Click);
            // 
            // ConfirmReview
            // 
            this.ConfirmReview.Location = new System.Drawing.Point(387, 316);
            this.ConfirmReview.Name = "ConfirmReview";
            this.ConfirmReview.Size = new System.Drawing.Size(75, 23);
            this.ConfirmReview.TabIndex = 58;
            this.ConfirmReview.Text = "Confirm";
            this.ConfirmReview.UseVisualStyleBackColor = true;
            this.ConfirmReview.Visible = false;
            this.ConfirmReview.Click += new System.EventHandler(this.ConfirmReview_Click);
            // 
            // DeleteReviewBox
            // 
            this.DeleteReviewBox.Location = new System.Drawing.Point(12, 95);
            this.DeleteReviewBox.Name = "DeleteReviewBox";
            this.DeleteReviewBox.Size = new System.Drawing.Size(200, 20);
            this.DeleteReviewBox.TabIndex = 59;
            this.DeleteReviewBox.Visible = false;
            // 
            // DeleteReviewb
            // 
            this.DeleteReviewb.Location = new System.Drawing.Point(218, 93);
            this.DeleteReviewb.Name = "DeleteReviewb";
            this.DeleteReviewb.Size = new System.Drawing.Size(92, 23);
            this.DeleteReviewb.TabIndex = 60;
            this.DeleteReviewb.Text = "Delete Review";
            this.DeleteReviewb.UseVisualStyleBackColor = true;
            this.DeleteReviewb.Visible = false;
            this.DeleteReviewb.Click += new System.EventHandler(this.DeleteReviewb_Click);
            // 
            // PlaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 365);
            this.Controls.Add(this.DeleteReviewb);
            this.Controls.Add(this.DeleteReviewBox);
            this.Controls.Add(this.ConfirmReview);
            this.Controls.Add(this.ReviewsWriteB);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchGenreb);
            this.Controls.Add(this.SearchGenrel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.PlayDatel);
            this.Controls.Add(this.PlayTitlel);
            this.Controls.Add(this.playTitleTextBox);
            this.Controls.Add(this.BookTickB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.SearchDateB);
            this.Controls.Add(this.AllPlaysl);
            this.Controls.Add(this.AddBack);
            this.Controls.Add(this.ReviewsReadb);
            this.Name = "PlaysForm";
            this.Text = "Plays";
            this.Load += new System.EventHandler(this.PlaysForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketSysDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playsBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OAPUpDn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildUpDn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StandardUpDn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ReviewsReadb;
        private System.Windows.Forms.Button AddBack;
        private System.Windows.Forms.Button SearchDateB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private TicketSysDBDataSet ticketSysDBDataSet;
        private System.Windows.Forms.BindingSource playsBindingSource;
        private TicketSysDBDataSetTableAdapters.PlaysTableAdapter playsTableAdapter;
        private System.Windows.Forms.BindingSource playsBindingSource1;
        private System.Windows.Forms.Button BookTickB;
        private System.Windows.Forms.Label AllPlaysl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox playTitleTextBox;
        private System.Windows.Forms.Label PlayTitlel;
        private System.Windows.Forms.Label PlayDatel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label SearchGenrel;
        private System.Windows.Forms.Button SearchGenreb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RadioBandC;
        private System.Windows.Forms.RadioButton RadioBandB;
        private System.Windows.Forms.RadioButton RadioBandA;
        private System.Windows.Forms.Button BookConfb;
        private System.Windows.Forms.Label CurrTotal;
        private System.Windows.Forms.NumericUpDown OAPUpDn;
        private System.Windows.Forms.NumericUpDown ChildUpDn;
        private System.Windows.Forms.NumericUpDown StandardUpDn;
        private System.Windows.Forms.Label OAPPl;
        private System.Windows.Forms.Label ChildPl;
        private System.Windows.Forms.Label StandardPl;
        private System.Windows.Forms.Label OAPl;
        private System.Windows.Forms.Label Childl;
        private System.Windows.Forms.Label Standardl;
        private System.Windows.Forms.Label BookDatel;
        private System.Windows.Forms.Label BookTitlel;
        private System.Windows.Forms.Label Currentl;
        private System.Windows.Forms.Label BookTimel;
        private System.Windows.Forms.ComboBox TimeBox;
        private System.Windows.Forms.Button ReviewsWriteB;
        private System.Windows.Forms.TextBox ReviewTextBox;
        private System.Windows.Forms.Button ConfirmReview;
        private System.Windows.Forms.Label CheckValuel;
        private System.Windows.Forms.TextBox DeleteReviewBox;
        private System.Windows.Forms.Button DeleteReviewb;
    }
}