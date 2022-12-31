namespace 地图交互
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.northwest = new System.Windows.Forms.Button();
            this.north = new System.Windows.Forms.Button();
            this.northeast = new System.Windows.Forms.Button();
            this.west = new System.Windows.Forms.Button();
            this.big = new System.Windows.Forms.Button();
            this.east = new System.Windows.Forms.Button();
            this.southwest = new System.Windows.Forms.Button();
            this.south = new System.Windows.Forms.Button();
            this.southeast = new System.Windows.Forms.Button();
            this.small = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clear = new System.Windows.Forms.Button();
            this.location = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.json = new System.Windows.Forms.Button();
            this.saved = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.Button();
            this.polyline = new System.Windows.Forms.Button();
            this.polygon = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.sweep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // northwest
            // 
            this.northwest.BackColor = System.Drawing.Color.Transparent;
            this.northwest.Location = new System.Drawing.Point(456, 74);
            this.northwest.Name = "northwest";
            this.northwest.Size = new System.Drawing.Size(80, 80);
            this.northwest.TabIndex = 1;
            this.northwest.Text = "↖";
            this.northwest.UseVisualStyleBackColor = false;
            this.northwest.Click += new System.EventHandler(this.northwest_Click);
            // 
            // north
            // 
            this.north.BackColor = System.Drawing.Color.Transparent;
            this.north.Location = new System.Drawing.Point(542, 74);
            this.north.Name = "north";
            this.north.Size = new System.Drawing.Size(80, 80);
            this.north.TabIndex = 2;
            this.north.Text = "↑";
            this.north.UseVisualStyleBackColor = false;
            this.north.Click += new System.EventHandler(this.north_Click);
            // 
            // northeast
            // 
            this.northeast.BackColor = System.Drawing.Color.Transparent;
            this.northeast.Location = new System.Drawing.Point(628, 74);
            this.northeast.Name = "northeast";
            this.northeast.Size = new System.Drawing.Size(80, 80);
            this.northeast.TabIndex = 3;
            this.northeast.Text = "↗";
            this.northeast.UseVisualStyleBackColor = false;
            this.northeast.Click += new System.EventHandler(this.northeast_Click);
            // 
            // west
            // 
            this.west.BackColor = System.Drawing.Color.Transparent;
            this.west.Location = new System.Drawing.Point(456, 160);
            this.west.Name = "west";
            this.west.Size = new System.Drawing.Size(80, 80);
            this.west.TabIndex = 4;
            this.west.Text = "←";
            this.west.UseVisualStyleBackColor = false;
            this.west.Click += new System.EventHandler(this.west_Click);
            // 
            // big
            // 
            this.big.BackColor = System.Drawing.Color.Transparent;
            this.big.Location = new System.Drawing.Point(542, 160);
            this.big.Name = "big";
            this.big.Size = new System.Drawing.Size(37, 80);
            this.big.TabIndex = 5;
            this.big.Text = "+";
            this.big.UseVisualStyleBackColor = false;
            this.big.Click += new System.EventHandler(this.big_Click);
            // 
            // east
            // 
            this.east.BackColor = System.Drawing.Color.Transparent;
            this.east.Location = new System.Drawing.Point(628, 160);
            this.east.Name = "east";
            this.east.Size = new System.Drawing.Size(80, 80);
            this.east.TabIndex = 6;
            this.east.Text = "→";
            this.east.UseVisualStyleBackColor = false;
            this.east.Click += new System.EventHandler(this.east_Click);
            // 
            // southwest
            // 
            this.southwest.BackColor = System.Drawing.Color.Transparent;
            this.southwest.Location = new System.Drawing.Point(456, 246);
            this.southwest.Name = "southwest";
            this.southwest.Size = new System.Drawing.Size(80, 80);
            this.southwest.TabIndex = 7;
            this.southwest.Text = "↙";
            this.southwest.UseVisualStyleBackColor = false;
            this.southwest.Click += new System.EventHandler(this.southwest_Click);
            // 
            // south
            // 
            this.south.BackColor = System.Drawing.Color.Transparent;
            this.south.Location = new System.Drawing.Point(542, 246);
            this.south.Name = "south";
            this.south.Size = new System.Drawing.Size(80, 80);
            this.south.TabIndex = 8;
            this.south.Text = "↓";
            this.south.UseVisualStyleBackColor = false;
            this.south.Click += new System.EventHandler(this.south_Click);
            // 
            // southeast
            // 
            this.southeast.BackColor = System.Drawing.Color.Transparent;
            this.southeast.Location = new System.Drawing.Point(628, 246);
            this.southeast.Name = "southeast";
            this.southeast.Size = new System.Drawing.Size(80, 80);
            this.southeast.TabIndex = 9;
            this.southeast.Text = "↘";
            this.southeast.UseVisualStyleBackColor = false;
            this.southeast.Click += new System.EventHandler(this.southeast_Click);
            // 
            // small
            // 
            this.small.BackColor = System.Drawing.Color.Transparent;
            this.small.Location = new System.Drawing.Point(585, 160);
            this.small.Name = "small";
            this.small.Size = new System.Drawing.Size(37, 80);
            this.small.TabIndex = 10;
            this.small.Text = "-";
            this.small.UseVisualStyleBackColor = false;
            this.small.Click += new System.EventHandler(this.small_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            this.pictureBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseWheel);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Transparent;
            this.clear.Location = new System.Drawing.Point(542, 332);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(80, 80);
            this.clear.TabIndex = 12;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(456, 12);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(252, 21);
            this.location.TabIndex = 13;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.Location = new System.Drawing.Point(456, 332);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(80, 80);
            this.save.TabIndex = 14;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // json
            // 
            this.json.BackColor = System.Drawing.Color.Transparent;
            this.json.Location = new System.Drawing.Point(628, 332);
            this.json.Name = "json";
            this.json.Size = new System.Drawing.Size(80, 80);
            this.json.TabIndex = 15;
            this.json.Text = "json";
            this.json.UseVisualStyleBackColor = false;
            this.json.Click += new System.EventHandler(this.json_Click);
            // 
            // saved
            // 
            this.saved.BackColor = System.Drawing.Color.Transparent;
            this.saved.Location = new System.Drawing.Point(456, 45);
            this.saved.Name = "saved";
            this.saved.Size = new System.Drawing.Size(252, 23);
            this.saved.TabIndex = 16;
            this.saved.Text = "saved";
            this.saved.UseVisualStyleBackColor = false;
            this.saved.Click += new System.EventHandler(this.saved_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(837, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 400);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.line.Location = new System.Drawing.Point(714, 74);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(80, 80);
            this.line.TabIndex = 19;
            this.line.Text = "line";
            this.line.UseVisualStyleBackColor = false;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // polyline
            // 
            this.polyline.BackColor = System.Drawing.Color.Transparent;
            this.polyline.Location = new System.Drawing.Point(714, 160);
            this.polyline.Name = "polyline";
            this.polyline.Size = new System.Drawing.Size(80, 80);
            this.polyline.TabIndex = 20;
            this.polyline.Text = "polyline";
            this.polyline.UseVisualStyleBackColor = false;
            this.polyline.Click += new System.EventHandler(this.polyline_Click);
            // 
            // polygon
            // 
            this.polygon.BackColor = System.Drawing.Color.Transparent;
            this.polygon.Location = new System.Drawing.Point(714, 246);
            this.polygon.Name = "polygon";
            this.polygon.Size = new System.Drawing.Size(80, 80);
            this.polygon.TabIndex = 21;
            this.polygon.Text = "polygon";
            this.polygon.UseVisualStyleBackColor = false;
            this.polygon.Click += new System.EventHandler(this.polygon_Click);
            // 
            // circle
            // 
            this.circle.BackColor = System.Drawing.Color.Transparent;
            this.circle.Location = new System.Drawing.Point(714, 332);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(80, 80);
            this.circle.TabIndex = 22;
            this.circle.Text = "circle";
            this.circle.UseVisualStyleBackColor = false;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // sweep
            // 
            this.sweep.BackColor = System.Drawing.Color.Transparent;
            this.sweep.Location = new System.Drawing.Point(714, 12);
            this.sweep.Name = "sweep";
            this.sweep.Size = new System.Drawing.Size(80, 56);
            this.sweep.TabIndex = 23;
            this.sweep.Text = "sweep";
            this.sweep.UseVisualStyleBackColor = false;
            this.sweep.Click += new System.EventHandler(this.sweep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 426);
            this.Controls.Add(this.sweep);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.polygon);
            this.Controls.Add(this.polyline);
            this.Controls.Add(this.line);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.saved);
            this.Controls.Add(this.json);
            this.Controls.Add(this.save);
            this.Controls.Add(this.location);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.small);
            this.Controls.Add(this.southeast);
            this.Controls.Add(this.south);
            this.Controls.Add(this.southwest);
            this.Controls.Add(this.east);
            this.Controls.Add(this.big);
            this.Controls.Add(this.west);
            this.Controls.Add(this.northeast);
            this.Controls.Add(this.north);
            this.Controls.Add(this.northwest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button northwest;
        private System.Windows.Forms.Button north;
        private System.Windows.Forms.Button northeast;
        private System.Windows.Forms.Button west;
        private System.Windows.Forms.Button big;
        private System.Windows.Forms.Button east;
        private System.Windows.Forms.Button southwest;
        private System.Windows.Forms.Button south;
        private System.Windows.Forms.Button southeast;
        private System.Windows.Forms.Button small;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button json;
        private System.Windows.Forms.Button saved;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.Button polyline;
        private System.Windows.Forms.Button polygon;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button sweep; 
    }
}

