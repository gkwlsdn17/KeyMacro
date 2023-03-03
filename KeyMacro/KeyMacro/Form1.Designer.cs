namespace KeyMacro
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.column_num = new System.Windows.Forms.ColumnHeader();
            this.column_key = new System.Windows.Forms.ColumnHeader();
            this.column_delay = new System.Windows.Forms.ColumnHeader();
            this.column_repeat = new System.Windows.Forms.ColumnHeader();
            this.button_add = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.textBox_delay = new System.Windows.Forms.TextBox();
            this.textBox_repeat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_read = new System.Windows.Forms.Button();
            this.button_saveAs = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_update = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_num,
            this.column_key,
            this.column_delay,
            this.column_repeat});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(350, 593);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // column_num
            // 
            this.column_num.Text = "순서";
            this.column_num.Width = 40;
            // 
            // column_key
            // 
            this.column_key.Text = "키";
            this.column_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_key.Width = 110;
            // 
            // column_delay
            // 
            this.column_delay.Text = "키 딜레이";
            this.column_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_delay.Width = 100;
            // 
            // column_repeat
            // 
            this.column_repeat.Text = "반복주기";
            this.column_repeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_repeat.Width = 100;
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_add.Location = new System.Drawing.Point(469, 347);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(56, 39);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "추가";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_del
            // 
            this.button_del.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_del.Location = new System.Drawing.Point(369, 12);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(105, 39);
            this.button_del.TabIndex = 2;
            this.button_del.Text = "삭제";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_save.Location = new System.Drawing.Point(479, 12);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(104, 39);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "저장";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(368, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "키 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(368, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "딜레이: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(368, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "반복주기:";
            // 
            // textBox_key
            // 
            this.textBox_key.Location = new System.Drawing.Point(410, 238);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(149, 23);
            this.textBox_key.TabIndex = 7;
            this.textBox_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_delay
            // 
            this.textBox_delay.Location = new System.Drawing.Point(434, 277);
            this.textBox_delay.Name = "textBox_delay";
            this.textBox_delay.Size = new System.Drawing.Size(125, 23);
            this.textBox_delay.TabIndex = 8;
            this.textBox_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_repeat
            // 
            this.textBox_repeat.Location = new System.Drawing.Point(452, 316);
            this.textBox_repeat.Name = "textBox_repeat";
            this.textBox_repeat.Size = new System.Drawing.Size(107, 23);
            this.textBox_repeat.TabIndex = 9;
            this.textBox_repeat.Text = "0";
            this.textBox_repeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(434, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "사용방법";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 150);
            this.label5.TabIndex = 11;
            this.label5.Text = "키: 1, 2, 3, a, b, c, F1, F2 등 가능\r\n     조합도 가능\r\n     특수키 및 조합은 도움말 참고\r\n\r\n딜레이: ms 기" +
    "준\r\nex) 1000ms -> 1s\r\n     30000ms -> 30s\r\n\r\n반복주기: s 기준\r\n\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(560, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "s";
            // 
            // button_read
            // 
            this.button_read.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_read.Location = new System.Drawing.Point(479, 102);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(104, 39);
            this.button_read.TabIndex = 14;
            this.button_read.Text = "불러오기";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // button_saveAs
            // 
            this.button_saveAs.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_saveAs.Location = new System.Drawing.Point(479, 57);
            this.button_saveAs.Name = "button_saveAs";
            this.button_saveAs.Size = new System.Drawing.Size(104, 39);
            this.button_saveAs.TabIndex = 15;
            this.button_saveAs.Text = "다른이름으로\r\n저장";
            this.button_saveAs.UseVisualStyleBackColor = true;
            this.button_saveAs.Click += new System.EventHandler(this.button_saveAs_Click);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_start.Location = new System.Drawing.Point(369, 170);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(214, 39);
            this.button_start.TabIndex = 16;
            this.button_start.Text = "시작";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_help
            // 
            this.button_help.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_help.Location = new System.Drawing.Point(368, 102);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(104, 39);
            this.button_help.TabIndex = 17;
            this.button_help.Text = "도움말";
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_update.Location = new System.Drawing.Point(531, 347);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(52, 39);
            this.button_update.TabIndex = 18;
            this.button_update.Text = "수정";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_clear.Location = new System.Drawing.Point(369, 57);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(105, 39);
            this.button_clear.TabIndex = 19;
            this.button_clear.Text = "초기화";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 617);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_saveAs);
            this.Controls.Add(this.button_read);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_repeat);
            this.Controls.Add(this.textBox_delay);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "키 매크로";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private ColumnHeader column_num;
        private ColumnHeader column_key;
        private ColumnHeader column_delay;
        private ColumnHeader column_repeat;
        private Button button_add;
        private Button button_del;
        private Button button_save;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_key;
        private TextBox textBox_delay;
        private TextBox textBox_repeat;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button_read;
        private Button button_saveAs;
        private Button button_start;
        private Button button_help;
        private System.Windows.Forms.Timer timer1;
        private Button button_update;
        private Button button_clear;
    }
}