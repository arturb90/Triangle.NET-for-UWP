﻿namespace MeshExplorer
{
    partial class FormMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSmooth = new MeshExplorer.Controls.DarkButton();
            this.btnMesh = new MeshExplorer.Controls.DarkButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNumSeg = new System.Windows.Forms.Label();
            this.lbNumSeg2 = new System.Windows.Forms.Label();
            this.lbNumTri = new System.Windows.Forms.Label();
            this.lbNumTri2 = new System.Windows.Forms.Label();
            this.lbNumVert = new System.Windows.Forms.Label();
            this.lbNumVert2 = new System.Windows.Forms.Label();
            this.flatTabControl1 = new MeshExplorer.Controls.DarkTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbMaxArea = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbMinAngle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.slMaxArea = new MeshExplorer.Controls.DarkSlider();
            this.slMinAngle = new MeshExplorer.Controls.DarkSlider();
            this.cbConvex = new MeshExplorer.Controls.DarkCheckBox();
            this.cbQuality = new MeshExplorer.Controls.DarkCheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbAngleMax = new System.Windows.Forms.Label();
            this.lbRatioMax = new System.Windows.Forms.Label();
            this.lbEdgeMax = new System.Windows.Forms.Label();
            this.lbAreaMax = new System.Windows.Forms.Label();
            this.lbAngleMin = new System.Windows.Forms.Label();
            this.lbRatioMin = new System.Windows.Forms.Label();
            this.lbEdgeMin = new System.Windows.Forms.Label();
            this.lbAreaMin = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.angleHistogram1 = new MeshExplorer.Controls.AngleHistogram();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbShortcuts = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fileMenuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuMQuality = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewMenuLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenuGen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenuPoly1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenuRandPts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenuCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.meshRenderer1 = new MeshExplorer.Controls.MeshRenderer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.splitContainer1.Panel1.Controls.Add(this.btnSmooth);
            this.splitContainer1.Panel1.Controls.Add(this.btnMesh);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.lbNumSeg);
            this.splitContainer1.Panel1.Controls.Add(this.lbNumSeg2);
            this.splitContainer1.Panel1.Controls.Add(this.lbNumTri);
            this.splitContainer1.Panel1.Controls.Add(this.lbNumTri2);
            this.splitContainer1.Panel1.Controls.Add(this.lbNumVert);
            this.splitContainer1.Panel1.Controls.Add(this.lbNumVert2);
            this.splitContainer1.Panel1.Controls.Add(this.flatTabControl1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel2.Controls.Add(this.meshRenderer1);
            this.splitContainer1.Size = new System.Drawing.Size(984, 612);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSmooth
            // 
            this.btnSmooth.Enabled = false;
            this.btnSmooth.Location = new System.Drawing.Point(150, 196);
            this.btnSmooth.Name = "btnSmooth";
            this.btnSmooth.Size = new System.Drawing.Size(126, 23);
            this.btnSmooth.TabIndex = 12;
            this.btnSmooth.Text = "Smooth";
            this.btnSmooth.UseVisualStyleBackColor = true;
            this.btnSmooth.Click += new System.EventHandler(this.btnSmooth_Click);
            // 
            // btnMesh
            // 
            this.btnMesh.Enabled = false;
            this.btnMesh.Location = new System.Drawing.Point(4, 196);
            this.btnMesh.Name = "btnMesh";
            this.btnMesh.Size = new System.Drawing.Size(126, 23);
            this.btnMesh.TabIndex = 12;
            this.btnMesh.Text = "Triangulate";
            this.btnMesh.UseVisualStyleBackColor = true;
            this.btnMesh.Click += new System.EventHandler(this.btnMesh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Segments:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Triangles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vertices:";
            // 
            // lbNumSeg
            // 
            this.lbNumSeg.ForeColor = System.Drawing.Color.White;
            this.lbNumSeg.Location = new System.Drawing.Point(95, 121);
            this.lbNumSeg.Name = "lbNumSeg";
            this.lbNumSeg.Size = new System.Drawing.Size(70, 13);
            this.lbNumSeg.TabIndex = 3;
            this.lbNumSeg.Text = "-";
            this.lbNumSeg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbNumSeg2
            // 
            this.lbNumSeg2.ForeColor = System.Drawing.Color.Gray;
            this.lbNumSeg2.Location = new System.Drawing.Point(182, 121);
            this.lbNumSeg2.Name = "lbNumSeg2";
            this.lbNumSeg2.Size = new System.Drawing.Size(70, 13);
            this.lbNumSeg2.TabIndex = 3;
            this.lbNumSeg2.Text = "-";
            this.lbNumSeg2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbNumTri
            // 
            this.lbNumTri.ForeColor = System.Drawing.Color.White;
            this.lbNumTri.Location = new System.Drawing.Point(95, 142);
            this.lbNumTri.Name = "lbNumTri";
            this.lbNumTri.Size = new System.Drawing.Size(70, 13);
            this.lbNumTri.TabIndex = 2;
            this.lbNumTri.Text = "-";
            this.lbNumTri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbNumTri2
            // 
            this.lbNumTri2.ForeColor = System.Drawing.Color.Gray;
            this.lbNumTri2.Location = new System.Drawing.Point(182, 142);
            this.lbNumTri2.Name = "lbNumTri2";
            this.lbNumTri2.Size = new System.Drawing.Size(70, 13);
            this.lbNumTri2.TabIndex = 2;
            this.lbNumTri2.Text = "-";
            this.lbNumTri2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbNumVert
            // 
            this.lbNumVert.ForeColor = System.Drawing.Color.White;
            this.lbNumVert.Location = new System.Drawing.Point(95, 100);
            this.lbNumVert.Name = "lbNumVert";
            this.lbNumVert.Size = new System.Drawing.Size(70, 13);
            this.lbNumVert.TabIndex = 4;
            this.lbNumVert.Text = "-";
            this.lbNumVert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbNumVert2
            // 
            this.lbNumVert2.ForeColor = System.Drawing.Color.Gray;
            this.lbNumVert2.Location = new System.Drawing.Point(182, 100);
            this.lbNumVert2.Name = "lbNumVert2";
            this.lbNumVert2.Size = new System.Drawing.Size(70, 13);
            this.lbNumVert2.TabIndex = 4;
            this.lbNumVert2.Text = "-";
            this.lbNumVert2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.flatTabControl1.Controls.Add(this.tabPage1);
            this.flatTabControl1.Controls.Add(this.tabPage2);
            this.flatTabControl1.Controls.Add(this.tabPage3);
            this.flatTabControl1.Location = new System.Drawing.Point(0, 224);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(280, 387);
            this.flatTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.lbMaxArea);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lbMinAngle);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.slMaxArea);
            this.tabPage1.Controls.Add(this.slMinAngle);
            this.tabPage1.Controls.Add(this.cbConvex);
            this.tabPage1.Controls.Add(this.cbQuality);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(272, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mesh Control";
            // 
            // lbMaxArea
            // 
            this.lbMaxArea.AutoSize = true;
            this.lbMaxArea.Location = new System.Drawing.Point(227, 61);
            this.lbMaxArea.Name = "lbMaxArea";
            this.lbMaxArea.Size = new System.Drawing.Size(13, 13);
            this.lbMaxArea.TabIndex = 14;
            this.lbMaxArea.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Maximum area";
            // 
            // lbMinAngle
            // 
            this.lbMinAngle.AutoSize = true;
            this.lbMinAngle.Location = new System.Drawing.Point(227, 39);
            this.lbMinAngle.Name = "lbMinAngle";
            this.lbMinAngle.Size = new System.Drawing.Size(19, 13);
            this.lbMinAngle.TabIndex = 14;
            this.lbMinAngle.Text = "20";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(8, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 33);
            this.label9.TabIndex = 14;
            this.label9.Text = "Use the convex mesh option, if the convex hull should be included in the output.";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DimGray;
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(8, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 33);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hint: maximum area values of 0 or 1 will be irgnored (no area constraints are set" +
    ").";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Minimum angle";
            // 
            // slMaxArea
            // 
            this.slMaxArea.BackColor = System.Drawing.Color.Transparent;
            this.slMaxArea.CriticalPercent = ((uint)(0u));
            this.slMaxArea.Location = new System.Drawing.Point(102, 58);
            this.slMaxArea.Maximum = 100;
            this.slMaxArea.Minimum = 0;
            this.slMaxArea.Name = "slMaxArea";
            this.slMaxArea.Size = new System.Drawing.Size(119, 18);
            this.slMaxArea.TabIndex = 13;
            this.slMaxArea.Text = "darkSlider1";
            this.slMaxArea.Value = 0;
            this.slMaxArea.ValueChanging += new System.EventHandler(this.slMaxArea_ValueChanging);
            // 
            // slMinAngle
            // 
            this.slMinAngle.BackColor = System.Drawing.Color.Transparent;
            this.slMinAngle.CriticalPercent = ((uint)(89u));
            this.slMinAngle.Location = new System.Drawing.Point(102, 36);
            this.slMinAngle.Maximum = 100;
            this.slMinAngle.Minimum = 0;
            this.slMinAngle.Name = "slMinAngle";
            this.slMinAngle.Size = new System.Drawing.Size(119, 18);
            this.slMinAngle.TabIndex = 13;
            this.slMinAngle.Text = "darkSlider1";
            this.slMinAngle.Value = 50;
            this.slMinAngle.ValueChanging += new System.EventHandler(this.slMinAngle_ValueChanging);
            // 
            // cbConvex
            // 
            this.cbConvex.BackColor = System.Drawing.Color.DimGray;
            this.cbConvex.Checked = false;
            this.cbConvex.Location = new System.Drawing.Point(11, 146);
            this.cbConvex.Name = "cbConvex";
            this.cbConvex.Size = new System.Drawing.Size(115, 17);
            this.cbConvex.TabIndex = 0;
            this.cbConvex.Text = "Convex mesh";
            this.cbConvex.UseVisualStyleBackColor = false;
            // 
            // cbQuality
            // 
            this.cbQuality.BackColor = System.Drawing.Color.DimGray;
            this.cbQuality.Checked = false;
            this.cbQuality.Location = new System.Drawing.Point(11, 13);
            this.cbQuality.Name = "cbQuality";
            this.cbQuality.Size = new System.Drawing.Size(115, 17);
            this.cbQuality.TabIndex = 0;
            this.cbQuality.Text = "Quality mesh";
            this.cbQuality.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.lbAngleMax);
            this.tabPage2.Controls.Add(this.lbRatioMax);
            this.tabPage2.Controls.Add(this.lbEdgeMax);
            this.tabPage2.Controls.Add(this.lbAreaMax);
            this.tabPage2.Controls.Add(this.lbAngleMin);
            this.tabPage2.Controls.Add(this.lbRatioMin);
            this.tabPage2.Controls.Add(this.lbEdgeMin);
            this.tabPage2.Controls.Add(this.lbAreaMin);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.angleHistogram1);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(272, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Statistic";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DarkGray;
            this.label13.Location = new System.Drawing.Point(196, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Maximum";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DarkGray;
            this.label12.Location = new System.Drawing.Point(106, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Minimum";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.DarkGray;
            this.label16.Location = new System.Drawing.Point(8, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Angle:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.DarkGray;
            this.label15.Location = new System.Drawing.Point(8, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Aspect ratio:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.DarkGray;
            this.label14.Location = new System.Drawing.Point(9, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Edge length:";
            // 
            // lbAngleMax
            // 
            this.lbAngleMax.ForeColor = System.Drawing.Color.White;
            this.lbAngleMax.Location = new System.Drawing.Point(176, 107);
            this.lbAngleMax.Name = "lbAngleMax";
            this.lbAngleMax.Size = new System.Drawing.Size(76, 13);
            this.lbAngleMax.TabIndex = 16;
            this.lbAngleMax.Text = "-";
            this.lbAngleMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRatioMax
            // 
            this.lbRatioMax.ForeColor = System.Drawing.Color.White;
            this.lbRatioMax.Location = new System.Drawing.Point(176, 84);
            this.lbRatioMax.Name = "lbRatioMax";
            this.lbRatioMax.Size = new System.Drawing.Size(76, 13);
            this.lbRatioMax.TabIndex = 13;
            this.lbRatioMax.Text = "-";
            this.lbRatioMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbEdgeMax
            // 
            this.lbEdgeMax.ForeColor = System.Drawing.Color.White;
            this.lbEdgeMax.Location = new System.Drawing.Point(176, 61);
            this.lbEdgeMax.Name = "lbEdgeMax";
            this.lbEdgeMax.Size = new System.Drawing.Size(76, 13);
            this.lbEdgeMax.TabIndex = 14;
            this.lbEdgeMax.Text = "-";
            this.lbEdgeMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbAreaMax
            // 
            this.lbAreaMax.ForeColor = System.Drawing.Color.White;
            this.lbAreaMax.Location = new System.Drawing.Point(176, 39);
            this.lbAreaMax.Name = "lbAreaMax";
            this.lbAreaMax.Size = new System.Drawing.Size(76, 13);
            this.lbAreaMax.TabIndex = 3;
            this.lbAreaMax.Text = "-";
            this.lbAreaMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbAngleMin
            // 
            this.lbAngleMin.ForeColor = System.Drawing.Color.White;
            this.lbAngleMin.Location = new System.Drawing.Point(94, 107);
            this.lbAngleMin.Name = "lbAngleMin";
            this.lbAngleMin.Size = new System.Drawing.Size(68, 13);
            this.lbAngleMin.TabIndex = 4;
            this.lbAngleMin.Text = "-";
            this.lbAngleMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRatioMin
            // 
            this.lbRatioMin.ForeColor = System.Drawing.Color.White;
            this.lbRatioMin.Location = new System.Drawing.Point(94, 84);
            this.lbRatioMin.Name = "lbRatioMin";
            this.lbRatioMin.Size = new System.Drawing.Size(68, 13);
            this.lbRatioMin.TabIndex = 1;
            this.lbRatioMin.Text = "-";
            this.lbRatioMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbEdgeMin
            // 
            this.lbEdgeMin.ForeColor = System.Drawing.Color.White;
            this.lbEdgeMin.Location = new System.Drawing.Point(94, 61);
            this.lbEdgeMin.Name = "lbEdgeMin";
            this.lbEdgeMin.Size = new System.Drawing.Size(68, 13);
            this.lbEdgeMin.TabIndex = 2;
            this.lbEdgeMin.Text = "-";
            this.lbEdgeMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbAreaMin
            // 
            this.lbAreaMin.ForeColor = System.Drawing.Color.White;
            this.lbAreaMin.Location = new System.Drawing.Point(94, 39);
            this.lbAreaMin.Name = "lbAreaMin";
            this.lbAreaMin.Size = new System.Drawing.Size(68, 13);
            this.lbAreaMin.TabIndex = 7;
            this.lbAreaMin.Text = "-";
            this.lbAreaMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(9, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Triangle area:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(8, 139);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Angle histogram:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Statistic:";
            // 
            // angleHistogram1
            // 
            this.angleHistogram1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.angleHistogram1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angleHistogram1.Location = new System.Drawing.Point(6, 157);
            this.angleHistogram1.Name = "angleHistogram1";
            this.angleHistogram1.Size = new System.Drawing.Size(260, 195);
            this.angleHistogram1.TabIndex = 0;
            this.angleHistogram1.Text = "angleHistogram1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.lbShortcuts);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(272, 358);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Shortcuts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Keyboard shortcuts";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(55, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 108);
            this.label7.TabIndex = 0;
            this.label7.Text = "File Open\r\nFile Save\r\nReload Input\r\n\r\nTriangulate / Refine\r\nSmooth\r\n\r\nShow Log";
            // 
            // lbShortcuts
            // 
            this.lbShortcuts.ForeColor = System.Drawing.Color.White;
            this.lbShortcuts.Location = new System.Drawing.Point(13, 37);
            this.lbShortcuts.Name = "lbShortcuts";
            this.lbShortcuts.Size = new System.Drawing.Size(36, 108);
            this.lbShortcuts.TabIndex = 0;
            this.lbShortcuts.Text = "F3\r\nF4\r\nF5\r\n\r\nF8\r\nF9\r\n\r\nF12";
            this.lbShortcuts.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu,
            this.toolsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(280, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fileMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuOpen,
            this.fileMenuSave,
            this.toolStripSeparator2,
            this.fileMenuQuit});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 24);
            this.fileMenu.Text = "File";
            // 
            // fileMenuOpen
            // 
            this.fileMenuOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileMenuOpen.Name = "fileMenuOpen";
            this.fileMenuOpen.Size = new System.Drawing.Size(103, 22);
            this.fileMenuOpen.Text = "Open";
            this.fileMenuOpen.Click += new System.EventHandler(this.fileMenuOpen_Click);
            // 
            // fileMenuSave
            // 
            this.fileMenuSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileMenuSave.Name = "fileMenuSave";
            this.fileMenuSave.Size = new System.Drawing.Size(103, 22);
            this.fileMenuSave.Text = "Save";
            this.fileMenuSave.Click += new System.EventHandler(this.fileMenuSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(100, 6);
            // 
            // fileMenuQuit
            // 
            this.fileMenuQuit.Name = "fileMenuQuit";
            this.fileMenuQuit.Size = new System.Drawing.Size(103, 22);
            this.fileMenuQuit.Text = "Quit";
            this.fileMenuQuit.Click += new System.EventHandler(this.fileMenuQuit_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMenuMQuality,
            this.toolStripSeparator1,
            this.viewMenuLog});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(44, 24);
            this.viewMenu.Text = "View";
            // 
            // viewMenuMQuality
            // 
            this.viewMenuMQuality.Enabled = false;
            this.viewMenuMQuality.Name = "viewMenuMQuality";
            this.viewMenuMQuality.Size = new System.Drawing.Size(154, 22);
            this.viewMenuMQuality.Text = "Mesh Quality ...";
            this.viewMenuMQuality.Click += new System.EventHandler(this.viewMenuMQuality_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // viewMenuLog
            // 
            this.viewMenuLog.Name = "viewMenuLog";
            this.viewMenuLog.Size = new System.Drawing.Size(154, 22);
            this.viewMenuLog.Text = "Show Log";
            this.viewMenuLog.Click += new System.EventHandler(this.viewMenuLog_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsMenuGen,
            this.toolsMenuCheck});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(46, 24);
            this.toolsMenu.Text = "Tools";
            // 
            // toolsMenuGen
            // 
            this.toolsMenuGen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsMenuPoly1,
            this.toolsMenuRandPts});
            this.toolsMenuGen.Name = "toolsMenuGen";
            this.toolsMenuGen.Size = new System.Drawing.Size(152, 22);
            this.toolsMenuGen.Text = "Generator";
            // 
            // toolsMenuPoly1
            // 
            this.toolsMenuPoly1.Name = "toolsMenuPoly1";
            this.toolsMenuPoly1.Size = new System.Drawing.Size(153, 22);
            this.toolsMenuPoly1.Text = "Star 1";
            this.toolsMenuPoly1.Click += new System.EventHandler(this.toolsMenuPoly1_Click);
            // 
            // toolsMenuRandPts
            // 
            this.toolsMenuRandPts.Name = "toolsMenuRandPts";
            this.toolsMenuRandPts.Size = new System.Drawing.Size(153, 22);
            this.toolsMenuRandPts.Text = "Random points";
            this.toolsMenuRandPts.Click += new System.EventHandler(this.toolsMenuRandPts_Click);
            // 
            // toolsMenuCheck
            // 
            this.toolsMenuCheck.Name = "toolsMenuCheck";
            this.toolsMenuCheck.Size = new System.Drawing.Size(152, 22);
            this.toolsMenuCheck.Text = "Check Mesh";
            this.toolsMenuCheck.Click += new System.EventHandler(this.toolsMenuCheck_Click);
            // 
            // meshRenderer1
            // 
            this.meshRenderer1.BackColor = System.Drawing.Color.Black;
            this.meshRenderer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meshRenderer1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meshRenderer1.Location = new System.Drawing.Point(0, 0);
            this.meshRenderer1.Name = "meshRenderer1";
            this.meshRenderer1.Size = new System.Drawing.Size(703, 612);
            this.meshRenderer1.TabIndex = 0;
            this.meshRenderer1.Text = "meshRenderer1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(984, 612);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "FormMain";
            this.Text = "Triangle.NET - Mesh Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.ResizeBeginHandler);
            this.ResizeEnd += new System.EventHandler(this.ResizeEndHandler);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.ResizeHandler);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Controls.MeshRenderer meshRenderer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem fileMenuSave;
        private Controls.DarkTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNumSeg2;
        private System.Windows.Forms.Label lbNumTri2;
        private System.Windows.Forms.Label lbNumVert2;
        private System.Windows.Forms.Label lbNumSeg;
        private System.Windows.Forms.Label lbNumTri;
        private System.Windows.Forms.Label lbNumVert;
        private Controls.DarkButton btnSmooth;
        private Controls.DarkButton btnMesh;
        private Controls.DarkCheckBox cbQuality;
        private Controls.AngleHistogram angleHistogram1;
        private Controls.DarkSlider slMinAngle;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbShortcuts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private Controls.DarkCheckBox cbConvex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Controls.DarkSlider slMaxArea;
        private System.Windows.Forms.Label lbMaxArea;
        private System.Windows.Forms.Label lbMinAngle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbAngleMax;
        private System.Windows.Forms.Label lbRatioMax;
        private System.Windows.Forms.Label lbEdgeMax;
        private System.Windows.Forms.Label lbAreaMax;
        private System.Windows.Forms.Label lbAngleMin;
        private System.Windows.Forms.Label lbRatioMin;
        private System.Windows.Forms.Label lbEdgeMin;
        private System.Windows.Forms.Label lbAreaMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenuMQuality;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem viewMenuLog;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenuGen;
        private System.Windows.Forms.ToolStripMenuItem toolsMenuPoly1;
        private System.Windows.Forms.ToolStripMenuItem toolsMenuRandPts;
        private System.Windows.Forms.ToolStripMenuItem toolsMenuCheck;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem fileMenuQuit;

    }
}

