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
            this.button1 = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSysDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reviews";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.BookTickB.Location = new System.Drawing.Point(231, 306);
            this.BookTickB.Name = "BookTickB";
            this.BookTickB.Size = new System.Drawing.Size(75, 23);
            this.BookTickB.TabIndex = 37;
            this.BookTickB.Text = "Book Ticket";
            this.BookTickB.UseVisualStyleBackColor = true;
            this.BookTickB.Visible = false;
            // 
            // AllPlaysl
            // 
            this.AllPlaysl.AutoSize = true;
            this.AllPlaysl.Location = new System.Drawing.Point(38, 95);
            this.AllPlaysl.Name = "AllPlaysl";
            this.AllPlaysl.Size = new System.Drawing.Size(105, 13);
            this.AllPlaysl.TabIndex = 18;
            this.AllPlaysl.Text = "Please Select a date";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 306);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Enter Play Title ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Enter Play Date ";
            // 
            // PlaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 365);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playTitleTextBox);
            this.Controls.Add(this.BookTickB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.SearchDateB);
            this.Controls.Add(this.AllPlaysl);
            this.Controls.Add(this.AddBack);
            this.Controls.Add(this.button1);
            this.Name = "PlaysForm";
            this.Text = "Plays";
            this.Load += new System.EventHandler(this.PlaysForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketSysDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}