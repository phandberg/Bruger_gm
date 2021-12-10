
namespace Bruger_gm
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlon = new System.Windows.Forms.TextBox();
            this.AddPoint = new System.Windows.Forms.Button();
            this.ClearList = new System.Windows.Forms.Button();
            this.Route = new System.Windows.Forms.Button();
            this.interessepunkt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(544, 665);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(12, 12);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(519, 640);
            this.map.TabIndex = 1;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.map_Load);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "lat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtlat
            // 
            this.txtlat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlat.Location = new System.Drawing.Point(593, 87);
            this.txtlat.Name = "txtlat";
            this.txtlat.Size = new System.Drawing.Size(150, 22);
            this.txtlat.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(596, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Find placering";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "lon";
            // 
            // txtlon
            // 
            this.txtlon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlon.Location = new System.Drawing.Point(596, 156);
            this.txtlon.Name = "txtlon";
            this.txtlon.Size = new System.Drawing.Size(147, 22);
            this.txtlon.TabIndex = 6;
            // 
            // AddPoint
            // 
            this.AddPoint.Location = new System.Drawing.Point(595, 287);
            this.AddPoint.Name = "AddPoint";
            this.AddPoint.Size = new System.Drawing.Size(115, 29);
            this.AddPoint.TabIndex = 7;
            this.AddPoint.Text = "Add point";
            this.AddPoint.UseVisualStyleBackColor = true;
            this.AddPoint.Click += new System.EventHandler(this.AddPoint_Click);
            // 
            // ClearList
            // 
            this.ClearList.Location = new System.Drawing.Point(593, 378);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(115, 29);
            this.ClearList.TabIndex = 8;
            this.ClearList.Text = "ClearList";
            this.ClearList.UseVisualStyleBackColor = true;
            this.ClearList.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // Route
            // 
            this.Route.Location = new System.Drawing.Point(596, 462);
            this.Route.Name = "Route";
            this.Route.Size = new System.Drawing.Size(112, 34);
            this.Route.TabIndex = 9;
            this.Route.Text = "Route";
            this.Route.UseVisualStyleBackColor = true;
            this.Route.Click += new System.EventHandler(this.Route_Click);
            // 
            // interessepunkt
            // 
            this.interessepunkt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.interessepunkt.Location = new System.Drawing.Point(593, 529);
            this.interessepunkt.Name = "interessepunkt";
            this.interessepunkt.Size = new System.Drawing.Size(115, 37);
            this.interessepunkt.TabIndex = 10;
            this.interessepunkt.Text = "Interessepunkt";
            this.interessepunkt.UseVisualStyleBackColor = true;
            this.interessepunkt.Click += new System.EventHandler(this.interessepunkt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.interessepunkt);
            this.Controls.Add(this.Route);
            this.Controls.Add(this.ClearList);
            this.Controls.Add(this.AddPoint);
            this.Controls.Add(this.txtlon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtlat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlon;
        private System.Windows.Forms.Button AddPoint;
        private System.Windows.Forms.Button ClearList;
        private System.Windows.Forms.Button Route;
        private System.Windows.Forms.Button interessepunkt;
    }
}

