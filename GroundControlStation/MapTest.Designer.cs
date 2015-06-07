namespace GroundControlStation
{
    partial class MapTest
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
            this.GMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // GMapControl1
            // 
            this.GMapControl1.Bearing = 0F;
            this.GMapControl1.CanDragMap = true;
            this.GMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.GMapControl1.GrayScaleMode = false;
            this.GMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.GMapControl1.LevelsKeepInMemmory = 5;
            this.GMapControl1.Location = new System.Drawing.Point(12, 12);
            this.GMapControl1.MarkersEnabled = true;
            this.GMapControl1.MaxZoom = 10;
            this.GMapControl1.MinZoom = 2;
            this.GMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.GMapControl1.Name = "GMapControl1";
            this.GMapControl1.NegativeMode = false;
            this.GMapControl1.PolygonsEnabled = true;
            this.GMapControl1.RetryLoadTile = 0;
            this.GMapControl1.RoutesEnabled = true;
            this.GMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.GMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.GMapControl1.ShowTileGridLines = false;
            this.GMapControl1.Size = new System.Drawing.Size(490, 359);
            this.GMapControl1.TabIndex = 0;
            this.GMapControl1.Zoom = 5D;
            // 
            // MapTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 383);
            this.Controls.Add(this.GMapControl1);
            this.Name = "MapTest";
            this.Text = "MapTest";
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl GMapControl1;
    }
}