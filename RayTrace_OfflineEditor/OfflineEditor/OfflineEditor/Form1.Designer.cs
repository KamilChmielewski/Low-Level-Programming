namespace OfflineEditor
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
            this.CreateObject = new System.Windows.Forms.Button();
            this.CreateJSONButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PosX = new System.Windows.Forms.NumericUpDown();
            this.PositionY = new System.Windows.Forms.Label();
            this.PosY = new System.Windows.Forms.NumericUpDown();
            this.PositionZ = new System.Windows.Forms.Label();
            this.PosZ = new System.Windows.Forms.NumericUpDown();
            this.VelZ = new System.Windows.Forms.NumericUpDown();
            this.VelocityZ = new System.Windows.Forms.Label();
            this.VelY = new System.Windows.Forms.NumericUpDown();
            this.VelocityY = new System.Windows.Forms.Label();
            this.VelX = new System.Windows.Forms.NumericUpDown();
            this.VelocityX = new System.Windows.Forms.Label();
            this.SurfaceB = new System.Windows.Forms.Label();
            this.SurfaceR = new System.Windows.Forms.Label();
            this.SurfR = new System.Windows.Forms.NumericUpDown();
            this.SurfaceG = new System.Windows.Forms.Label();
            this.SurfG = new System.Windows.Forms.NumericUpDown();
            this.SurfB = new System.Windows.Forms.NumericUpDown();
            this.EmissionColB = new System.Windows.Forms.NumericUpDown();
            this.EmissionB = new System.Windows.Forms.Label();
            this.EmissionColG = new System.Windows.Forms.NumericUpDown();
            this.EmissionG = new System.Windows.Forms.Label();
            this.EmissionColR = new System.Windows.Forms.NumericUpDown();
            this.EmissionR = new System.Windows.Forms.Label();
            this.ReflectionNum = new System.Windows.Forms.NumericUpDown();
            this.ReflectionLabel = new System.Windows.Forms.Label();
            this.TransparencyNum = new System.Windows.Forms.NumericUpDown();
            this.TransparencyLabel = new System.Windows.Forms.Label();
            this.RaduisNum = new System.Windows.Forms.NumericUpDown();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.RadiusIncrementNum = new System.Windows.Forms.NumericUpDown();
            this.RadiusIncrementLabel = new System.Windows.Forms.Label();
            this.ObjectDetailsTexBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.JsonOutputTextBox = new System.Windows.Forms.RichTextBox();
            this.RemoveObjectButton = new System.Windows.Forms.Button();
            this.RemoveSphereLabel = new System.Windows.Forms.Label();
            this.RemoveSphereIndex = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PosZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurfR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurfG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurfB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmissionColB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmissionColG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmissionColR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReflectionNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransparencyNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaduisNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusIncrementNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveSphereIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateObject
            // 
            this.CreateObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateObject.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.CreateObject.Location = new System.Drawing.Point(12, 492);
            this.CreateObject.Name = "CreateObject";
            this.CreateObject.Size = new System.Drawing.Size(104, 40);
            this.CreateObject.TabIndex = 0;
            this.CreateObject.Text = "Create Sphere";
            this.CreateObject.UseVisualStyleBackColor = true;
            this.CreateObject.Click += new System.EventHandler(this.CreateSphere);
            // 
            // CreateJSONButton
            // 
            this.CreateJSONButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateJSONButton.Location = new System.Drawing.Point(122, 492);
            this.CreateJSONButton.Name = "CreateJSONButton";
            this.CreateJSONButton.Size = new System.Drawing.Size(104, 40);
            this.CreateJSONButton.TabIndex = 1;
            this.CreateJSONButton.Text = "Create JSON";
            this.CreateJSONButton.UseVisualStyleBackColor = true;
            this.CreateJSONButton.Click += new System.EventHandler(this.CreateJSON);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "PositionX";
            // 
            // PosX
            // 
            this.PosX.DecimalPlaces = 3;
            this.PosX.Location = new System.Drawing.Point(71, 7);
            this.PosX.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.PosX.Minimum = new decimal(new int[] {
            2000000,
            0,
            0,
            -2147483648});
            this.PosX.Name = "PosX";
            this.PosX.Size = new System.Drawing.Size(54, 20);
            this.PosX.TabIndex = 3;
            this.PosX.ValueChanged += new System.EventHandler(this.PostionXChanged);
            // 
            // PositionY
            // 
            this.PositionY.Location = new System.Drawing.Point(131, 7);
            this.PositionY.Name = "PositionY";
            this.PositionY.Size = new System.Drawing.Size(57, 27);
            this.PositionY.TabIndex = 4;
            this.PositionY.Text = "PositionY";
            // 
            // PosY
            // 
            this.PosY.DecimalPlaces = 3;
            this.PosY.Location = new System.Drawing.Point(204, 5);
            this.PosY.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.PosY.Minimum = new decimal(new int[] {
            2000000,
            0,
            0,
            -2147483648});
            this.PosY.Name = "PosY";
            this.PosY.Size = new System.Drawing.Size(61, 20);
            this.PosY.TabIndex = 5;
            this.PosY.ValueChanged += new System.EventHandler(this.PostionYChanged);
            // 
            // PositionZ
            // 
            this.PositionZ.Location = new System.Drawing.Point(284, 5);
            this.PositionZ.Name = "PositionZ";
            this.PositionZ.Size = new System.Drawing.Size(57, 27);
            this.PositionZ.TabIndex = 6;
            this.PositionZ.Text = "PositionZ";
            // 
            // PosZ
            // 
            this.PosZ.DecimalPlaces = 3;
            this.PosZ.Location = new System.Drawing.Point(347, 5);
            this.PosZ.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.PosZ.Minimum = new decimal(new int[] {
            2000000,
            0,
            0,
            -2147483648});
            this.PosZ.Name = "PosZ";
            this.PosZ.Size = new System.Drawing.Size(61, 20);
            this.PosZ.TabIndex = 7;
            this.PosZ.ValueChanged += new System.EventHandler(this.PositionZChanged);
            // 
            // VelZ
            // 
            this.VelZ.DecimalPlaces = 3;
            this.VelZ.Location = new System.Drawing.Point(347, 31);
            this.VelZ.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.VelZ.Minimum = new decimal(new int[] {
            2000000,
            0,
            0,
            -2147483648});
            this.VelZ.Name = "VelZ";
            this.VelZ.Size = new System.Drawing.Size(61, 20);
            this.VelZ.TabIndex = 13;
            this.VelZ.ValueChanged += new System.EventHandler(this.VelocityZChanged);
            // 
            // VelocityZ
            // 
            this.VelocityZ.Location = new System.Drawing.Point(284, 31);
            this.VelocityZ.Name = "VelocityZ";
            this.VelocityZ.Size = new System.Drawing.Size(57, 27);
            this.VelocityZ.TabIndex = 12;
            this.VelocityZ.Text = "VelocityZ";
            // 
            // VelY
            // 
            this.VelY.DecimalPlaces = 3;
            this.VelY.Location = new System.Drawing.Point(204, 31);
            this.VelY.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.VelY.Minimum = new decimal(new int[] {
            2000000,
            0,
            0,
            -2147483648});
            this.VelY.Name = "VelY";
            this.VelY.Size = new System.Drawing.Size(61, 20);
            this.VelY.TabIndex = 11;
            this.VelY.ValueChanged += new System.EventHandler(this.VelocityYChanged);
            // 
            // VelocityY
            // 
            this.VelocityY.Location = new System.Drawing.Point(131, 33);
            this.VelocityY.Name = "VelocityY";
            this.VelocityY.Size = new System.Drawing.Size(57, 27);
            this.VelocityY.TabIndex = 10;
            this.VelocityY.Text = "VelocityY";
            // 
            // VelX
            // 
            this.VelX.DecimalPlaces = 3;
            this.VelX.Location = new System.Drawing.Point(71, 33);
            this.VelX.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.VelX.Minimum = new decimal(new int[] {
            2000000,
            0,
            0,
            -2147483648});
            this.VelX.Name = "VelX";
            this.VelX.Size = new System.Drawing.Size(54, 20);
            this.VelX.TabIndex = 9;
            this.VelX.ValueChanged += new System.EventHandler(this.VelocityXChanged);
            // 
            // VelocityX
            // 
            this.VelocityX.Location = new System.Drawing.Point(12, 33);
            this.VelocityX.Name = "VelocityX";
            this.VelocityX.Size = new System.Drawing.Size(57, 27);
            this.VelocityX.TabIndex = 8;
            this.VelocityX.Text = "VelocityX";
            // 
            // SurfaceB
            // 
            this.SurfaceB.Location = new System.Drawing.Point(284, 58);
            this.SurfaceB.Name = "SurfaceB";
            this.SurfaceB.Size = new System.Drawing.Size(57, 27);
            this.SurfaceB.TabIndex = 19;
            this.SurfaceB.Text = "Surface B";
            // 
            // SurfaceR
            // 
            this.SurfaceR.Location = new System.Drawing.Point(12, 60);
            this.SurfaceR.Name = "SurfaceR";
            this.SurfaceR.Size = new System.Drawing.Size(57, 27);
            this.SurfaceR.TabIndex = 15;
            this.SurfaceR.Text = "Surface R";
            // 
            // SurfR
            // 
            this.SurfR.DecimalPlaces = 3;
            this.SurfR.Location = new System.Drawing.Point(71, 60);
            this.SurfR.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.SurfR.Minimum = new decimal(new int[] {
            2000000,
            0,
            0,
            -2147483648});
            this.SurfR.Name = "SurfR";
            this.SurfR.Size = new System.Drawing.Size(54, 20);
            this.SurfR.TabIndex = 16;
            this.SurfR.ValueChanged += new System.EventHandler(this.SurfaceRChanged);
            // 
            // SurfaceG
            // 
            this.SurfaceG.Location = new System.Drawing.Point(131, 60);
            this.SurfaceG.Name = "SurfaceG";
            this.SurfaceG.Size = new System.Drawing.Size(57, 27);
            this.SurfaceG.TabIndex = 17;
            this.SurfaceG.Text = "Surface G";
            // 
            // SurfG
            // 
            this.SurfG.DecimalPlaces = 3;
            this.SurfG.Location = new System.Drawing.Point(204, 58);
            this.SurfG.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.SurfG.Minimum = new decimal(new int[] {
            2000000,
            0,
            0,
            -2147483648});
            this.SurfG.Name = "SurfG";
            this.SurfG.Size = new System.Drawing.Size(61, 20);
            this.SurfG.TabIndex = 18;
            this.SurfG.ValueChanged += new System.EventHandler(this.SurfaceGChanged);
            // 
            // SurfB
            // 
            this.SurfB.DecimalPlaces = 3;
            this.SurfB.Location = new System.Drawing.Point(347, 58);
            this.SurfB.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.SurfB.Minimum = new decimal(new int[] {
            2000000,
            0,
            0,
            -2147483648});
            this.SurfB.Name = "SurfB";
            this.SurfB.Size = new System.Drawing.Size(61, 20);
            this.SurfB.TabIndex = 20;
            this.SurfB.ValueChanged += new System.EventHandler(this.SurfaceBChanged);
            // 
            // EmissionColB
            // 
            this.EmissionColB.DecimalPlaces = 3;
            this.EmissionColB.Location = new System.Drawing.Point(347, 84);
            this.EmissionColB.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.EmissionColB.Minimum = new decimal(new int[] {
            2000000,
            0,
            0,
            -2147483648});
            this.EmissionColB.Name = "EmissionColB";
            this.EmissionColB.Size = new System.Drawing.Size(61, 20);
            this.EmissionColB.TabIndex = 26;
            this.EmissionColB.ValueChanged += new System.EventHandler(this.EmissionBChanged);
            // 
            // EmissionB
            // 
            this.EmissionB.Location = new System.Drawing.Point(284, 84);
            this.EmissionB.Name = "EmissionB";
            this.EmissionB.Size = new System.Drawing.Size(65, 27);
            this.EmissionB.TabIndex = 25;
            this.EmissionB.Text = "Emission B";
            // 
            // EmissionColG
            // 
            this.EmissionColG.DecimalPlaces = 3;
            this.EmissionColG.Location = new System.Drawing.Point(204, 84);
            this.EmissionColG.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.EmissionColG.Minimum = new decimal(new int[] {
            2000000,
            0,
            0,
            -2147483648});
            this.EmissionColG.Name = "EmissionColG";
            this.EmissionColG.Size = new System.Drawing.Size(61, 20);
            this.EmissionColG.TabIndex = 24;
            this.EmissionColG.ValueChanged += new System.EventHandler(this.EmissionGChanged);
            // 
            // EmissionG
            // 
            this.EmissionG.Location = new System.Drawing.Point(131, 86);
            this.EmissionG.Name = "EmissionG";
            this.EmissionG.Size = new System.Drawing.Size(70, 27);
            this.EmissionG.TabIndex = 23;
            this.EmissionG.Text = "Emission G";
            // 
            // EmissionColR
            // 
            this.EmissionColR.DecimalPlaces = 3;
            this.EmissionColR.Location = new System.Drawing.Point(71, 86);
            this.EmissionColR.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.EmissionColR.Minimum = new decimal(new int[] {
            2000000,
            0,
            0,
            -2147483648});
            this.EmissionColR.Name = "EmissionColR";
            this.EmissionColR.Size = new System.Drawing.Size(54, 20);
            this.EmissionColR.TabIndex = 22;
            this.EmissionColR.ValueChanged += new System.EventHandler(this.EmissionRChanged);
            // 
            // EmissionR
            // 
            this.EmissionR.Location = new System.Drawing.Point(12, 86);
            this.EmissionR.Name = "EmissionR";
            this.EmissionR.Size = new System.Drawing.Size(64, 27);
            this.EmissionR.TabIndex = 21;
            this.EmissionR.Text = "Emission R";
            // 
            // ReflectionNum
            // 
            this.ReflectionNum.DecimalPlaces = 3;
            this.ReflectionNum.Location = new System.Drawing.Point(347, 110);
            this.ReflectionNum.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.ReflectionNum.Minimum = new decimal(new int[] {
            2000000,
            0,
            0,
            -2147483648});
            this.ReflectionNum.Name = "ReflectionNum";
            this.ReflectionNum.Size = new System.Drawing.Size(61, 20);
            this.ReflectionNum.TabIndex = 32;
            this.ReflectionNum.ValueChanged += new System.EventHandler(this.ReflectionHasChanged);
            // 
            // ReflectionLabel
            // 
            this.ReflectionLabel.Location = new System.Drawing.Point(284, 110);
            this.ReflectionLabel.Name = "ReflectionLabel";
            this.ReflectionLabel.Size = new System.Drawing.Size(65, 27);
            this.ReflectionLabel.TabIndex = 31;
            this.ReflectionLabel.Text = "Reflection";
            // 
            // TransparencyNum
            // 
            this.TransparencyNum.DecimalPlaces = 3;
            this.TransparencyNum.Location = new System.Drawing.Point(204, 112);
            this.TransparencyNum.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.TransparencyNum.Minimum = new decimal(new int[] {
            2000000,
            0,
            0,
            -2147483648});
            this.TransparencyNum.Name = "TransparencyNum";
            this.TransparencyNum.Size = new System.Drawing.Size(61, 20);
            this.TransparencyNum.TabIndex = 30;
            this.TransparencyNum.ValueChanged += new System.EventHandler(this.TransparencyHasChanged);
            // 
            // TransparencyLabel
            // 
            this.TransparencyLabel.Location = new System.Drawing.Point(131, 113);
            this.TransparencyLabel.Name = "TransparencyLabel";
            this.TransparencyLabel.Size = new System.Drawing.Size(80, 27);
            this.TransparencyLabel.TabIndex = 29;
            this.TransparencyLabel.Text = "Transparency";
            // 
            // RaduisNum
            // 
            this.RaduisNum.DecimalPlaces = 3;
            this.RaduisNum.Location = new System.Drawing.Point(71, 113);
            this.RaduisNum.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.RaduisNum.Minimum = new decimal(new int[] {
            2000000,
            0,
            0,
            -2147483648});
            this.RaduisNum.Name = "RaduisNum";
            this.RaduisNum.Size = new System.Drawing.Size(54, 20);
            this.RaduisNum.TabIndex = 28;
            this.RaduisNum.ValueChanged += new System.EventHandler(this.RadiusHasChanged);
            // 
            // radiusLabel
            // 
            this.radiusLabel.Location = new System.Drawing.Point(12, 113);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(64, 27);
            this.radiusLabel.TabIndex = 27;
            this.radiusLabel.Text = "Radius";
            // 
            // RadiusIncrementNum
            // 
            this.RadiusIncrementNum.DecimalPlaces = 3;
            this.RadiusIncrementNum.Location = new System.Drawing.Point(100, 164);
            this.RadiusIncrementNum.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.RadiusIncrementNum.Minimum = new decimal(new int[] {
            2000000,
            0,
            0,
            -2147483648});
            this.RadiusIncrementNum.Name = "RadiusIncrementNum";
            this.RadiusIncrementNum.Size = new System.Drawing.Size(61, 20);
            this.RadiusIncrementNum.TabIndex = 34;
            this.RadiusIncrementNum.ValueChanged += new System.EventHandler(this.RadiusIncrementHasChanged);
            // 
            // RadiusIncrementLabel
            // 
            this.RadiusIncrementLabel.Location = new System.Drawing.Point(8, 164);
            this.RadiusIncrementLabel.Name = "RadiusIncrementLabel";
            this.RadiusIncrementLabel.Size = new System.Drawing.Size(91, 27);
            this.RadiusIncrementLabel.TabIndex = 33;
            this.RadiusIncrementLabel.Text = "Radius Increment";
            // 
            // ObjectDetailsTexBox
            // 
            this.ObjectDetailsTexBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ObjectDetailsTexBox.Location = new System.Drawing.Point(414, 18);
            this.ObjectDetailsTexBox.Name = "ObjectDetailsTexBox";
            this.ObjectDetailsTexBox.Size = new System.Drawing.Size(351, 524);
            this.ObjectDetailsTexBox.TabIndex = 35;
            this.ObjectDetailsTexBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(772, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "JSON OUTPUT";
            // 
            // JsonOutputTextBox
            // 
            this.JsonOutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JsonOutputTextBox.Location = new System.Drawing.Point(771, 18);
            this.JsonOutputTextBox.Name = "JsonOutputTextBox";
            this.JsonOutputTextBox.Size = new System.Drawing.Size(301, 524);
            this.JsonOutputTextBox.TabIndex = 37;
            this.JsonOutputTextBox.Text = "";
            this.JsonOutputTextBox.TextChanged += new System.EventHandler(this.JsonOutputTextBox_TextChanged);
            // 
            // RemoveObjectButton
            // 
            this.RemoveObjectButton.Location = new System.Drawing.Point(1, 214);
            this.RemoveObjectButton.Name = "RemoveObjectButton";
            this.RemoveObjectButton.Size = new System.Drawing.Size(115, 36);
            this.RemoveObjectButton.TabIndex = 38;
            this.RemoveObjectButton.Text = "Remove Sphere";
            this.RemoveObjectButton.UseVisualStyleBackColor = true;
            this.RemoveObjectButton.Click += new System.EventHandler(this.RemoveObject);
            // 
            // RemoveSphereLabel
            // 
            this.RemoveSphereLabel.Location = new System.Drawing.Point(119, 214);
            this.RemoveSphereLabel.Name = "RemoveSphereLabel";
            this.RemoveSphereLabel.Size = new System.Drawing.Size(127, 23);
            this.RemoveSphereLabel.TabIndex = 39;
            this.RemoveSphereLabel.Text = "RemoveSphereAtIndex";
            // 
            // RemoveSphereIndex
            // 
            this.RemoveSphereIndex.Location = new System.Drawing.Point(239, 212);
            this.RemoveSphereIndex.Name = "RemoveSphereIndex";
            this.RemoveSphereIndex.Size = new System.Drawing.Size(44, 20);
            this.RemoveSphereIndex.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Spheres Created";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1075, 544);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RemoveSphereIndex);
            this.Controls.Add(this.RemoveSphereLabel);
            this.Controls.Add(this.RemoveObjectButton);
            this.Controls.Add(this.JsonOutputTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ObjectDetailsTexBox);
            this.Controls.Add(this.RadiusIncrementNum);
            this.Controls.Add(this.RadiusIncrementLabel);
            this.Controls.Add(this.ReflectionNum);
            this.Controls.Add(this.ReflectionLabel);
            this.Controls.Add(this.TransparencyNum);
            this.Controls.Add(this.TransparencyLabel);
            this.Controls.Add(this.RaduisNum);
            this.Controls.Add(this.radiusLabel);
            this.Controls.Add(this.EmissionColB);
            this.Controls.Add(this.EmissionB);
            this.Controls.Add(this.EmissionColG);
            this.Controls.Add(this.EmissionG);
            this.Controls.Add(this.EmissionColR);
            this.Controls.Add(this.EmissionR);
            this.Controls.Add(this.SurfB);
            this.Controls.Add(this.SurfaceB);
            this.Controls.Add(this.SurfG);
            this.Controls.Add(this.SurfaceG);
            this.Controls.Add(this.SurfR);
            this.Controls.Add(this.SurfaceR);
            this.Controls.Add(this.VelZ);
            this.Controls.Add(this.VelocityZ);
            this.Controls.Add(this.VelY);
            this.Controls.Add(this.VelocityY);
            this.Controls.Add(this.VelX);
            this.Controls.Add(this.VelocityX);
            this.Controls.Add(this.PosZ);
            this.Controls.Add(this.PositionZ);
            this.Controls.Add(this.PosY);
            this.Controls.Add(this.PositionY);
            this.Controls.Add(this.PosX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreateJSONButton);
            this.Controls.Add(this.CreateObject);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PosZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurfR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurfG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurfB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmissionColB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmissionColG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmissionColR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReflectionNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransparencyNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaduisNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusIncrementNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveSphereIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateObject;
        private System.Windows.Forms.Button CreateJSONButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown PosX;
        private System.Windows.Forms.Label PositionY;
        private System.Windows.Forms.NumericUpDown PosY;
        private System.Windows.Forms.Label PositionZ;
        private System.Windows.Forms.NumericUpDown PosZ;
        private System.Windows.Forms.NumericUpDown VelZ;
        private System.Windows.Forms.Label VelocityZ;
        private System.Windows.Forms.NumericUpDown VelY;
        private System.Windows.Forms.Label VelocityY;
        private System.Windows.Forms.NumericUpDown VelX;
        private System.Windows.Forms.Label VelocityX;
        private System.Windows.Forms.Label SurfaceB;
        private System.Windows.Forms.Label SurfaceR;
        private System.Windows.Forms.NumericUpDown SurfR;
        private System.Windows.Forms.Label SurfaceG;
        private System.Windows.Forms.NumericUpDown SurfG;
        private System.Windows.Forms.NumericUpDown SurfB;
        private System.Windows.Forms.NumericUpDown EmissionColB;
        private System.Windows.Forms.Label EmissionB;
        private System.Windows.Forms.NumericUpDown EmissionColG;
        private System.Windows.Forms.Label EmissionG;
        private System.Windows.Forms.NumericUpDown EmissionColR;
        private System.Windows.Forms.Label EmissionR;
        private System.Windows.Forms.NumericUpDown ReflectionNum;
        private System.Windows.Forms.Label ReflectionLabel;
        private System.Windows.Forms.NumericUpDown TransparencyNum;
        private System.Windows.Forms.Label TransparencyLabel;
        private System.Windows.Forms.NumericUpDown RaduisNum;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.NumericUpDown RadiusIncrementNum;
        private System.Windows.Forms.Label RadiusIncrementLabel;
        private System.Windows.Forms.RichTextBox ObjectDetailsTexBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox JsonOutputTextBox;
        private System.Windows.Forms.Button RemoveObjectButton;
        private System.Windows.Forms.Label RemoveSphereLabel;
        private System.Windows.Forms.NumericUpDown RemoveSphereIndex;
        private System.Windows.Forms.Label label4;
    }
}

