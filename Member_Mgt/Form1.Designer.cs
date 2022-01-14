namespace Member_Mgt
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.idx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mem_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mem_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mem_gen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mem_bdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_mem = new System.Windows.Forms.ListView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idx
            // 
            this.idx.Text = "";
            this.idx.Width = 26;
            // 
            // mem_id
            // 
            this.mem_id.Text = "아이디";
            this.mem_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mem_id.Width = 130;
            // 
            // mem_name
            // 
            this.mem_name.Text = "이름";
            this.mem_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mem_name.Width = 125;
            // 
            // mem_gen
            // 
            this.mem_gen.Text = "성별";
            this.mem_gen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mem_gen.Width = 75;
            // 
            // mem_bdate
            // 
            this.mem_bdate.Text = "생년월일";
            this.mem_bdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mem_bdate.Width = 80;
            // 
            // list_mem
            // 
            this.list_mem.BackColor = System.Drawing.Color.White;
            this.list_mem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idx,
            this.mem_id,
            this.mem_name,
            this.mem_gen,
            this.mem_bdate});
            this.list_mem.FullRowSelect = true;
            this.list_mem.HideSelection = false;
            this.list_mem.Location = new System.Drawing.Point(8, 8);
            this.list_mem.MultiSelect = false;
            this.list_mem.Name = "list_mem";
            this.list_mem.Size = new System.Drawing.Size(440, 426);
            this.list_mem.TabIndex = 0;
            this.list_mem.UseCompatibleStateImageBehavior = false;
            this.list_mem.View = System.Windows.Forms.View.Details;
            this.list_mem.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.list_mem_ColumnWidthChanging);
            this.list_mem.SelectedIndexChanged += new System.EventHandler(this.list_mem_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_add.Location = new System.Drawing.Point(454, 8);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(40, 40);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_del.Location = new System.Drawing.Point(454, 54);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(40, 40);
            this.btn_del.TabIndex = 2;
            this.btn_del.Text = "-";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(454, 100);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(40, 40);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "↵";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_reset.Location = new System.Drawing.Point(454, 146);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(40, 40);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "↻";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(501, 442);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.list_mem);
            this.Location = new System.Drawing.Point(500, 100);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원관리";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader idx;
        private System.Windows.Forms.ColumnHeader mem_id;
        private System.Windows.Forms.ColumnHeader mem_name;
        private System.Windows.Forms.ColumnHeader mem_gen;
        private System.Windows.Forms.ColumnHeader mem_bdate;
        private System.Windows.Forms.ListView list_mem;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_reset;
    }
}

