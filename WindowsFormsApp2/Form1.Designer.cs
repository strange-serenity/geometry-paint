namespace WindowsFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button calculateAreaButton;
        private System.Windows.Forms.ListBox shapeList;
        private System.Windows.Forms.Panel canvas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createButton = new System.Windows.Forms.Button();
            this.calculateAreaButton = new System.Windows.Forms.Button();
            this.shapeList = new System.Windows.Forms.ListBox();
            this.radioButtonTriangle = new System.Windows.Forms.RadioButton();
            this.radioButtonDiamond = new System.Windows.Forms.RadioButton();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonCircle = new System.Windows.Forms.RadioButton();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.labelRadius = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.Panel();
            this.coordinatesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(12, 12);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(200, 23);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Створити нову фігуру";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // calculateAreaButton
            // 
            this.calculateAreaButton.Location = new System.Drawing.Point(12, 41);
            this.calculateAreaButton.Name = "calculateAreaButton";
            this.calculateAreaButton.Size = new System.Drawing.Size(200, 23);
            this.calculateAreaButton.TabIndex = 1;
            this.calculateAreaButton.Text = "Обчислити площу";
            this.calculateAreaButton.UseVisualStyleBackColor = true;
            this.calculateAreaButton.Click += new System.EventHandler(this.calculateAreaButton_Click);
            // 
            // shapeList
            // 
            this.shapeList.FormattingEnabled = true;
            this.shapeList.Location = new System.Drawing.Point(12, 242);
            this.shapeList.Name = "shapeList";
            this.shapeList.Size = new System.Drawing.Size(200, 303);
            this.shapeList.TabIndex = 9;
            // 
            // radioButtonTriangle
            // 
            this.radioButtonTriangle.Location = new System.Drawing.Point(12, 82);
            this.radioButtonTriangle.Name = "radioButtonTriangle";
            this.radioButtonTriangle.Size = new System.Drawing.Size(87, 24);
            this.radioButtonTriangle.TabIndex = 2;
            this.radioButtonTriangle.TabStop = true;
            this.radioButtonTriangle.Text = "Трикутник";
            this.radioButtonTriangle.UseVisualStyleBackColor = true;
            this.radioButtonTriangle.CheckedChanged += new System.EventHandler(this.radioButtonTriangle_CheckedChanged);
            // 
            // radioButtonDiamond
            // 
            this.radioButtonDiamond.Location = new System.Drawing.Point(125, 82);
            this.radioButtonDiamond.Name = "radioButtonDiamond";
            this.radioButtonDiamond.Size = new System.Drawing.Size(87, 24);
            this.radioButtonDiamond.TabIndex = 3;
            this.radioButtonDiamond.TabStop = true;
            this.radioButtonDiamond.Text = "Ромб";
            this.radioButtonDiamond.UseVisualStyleBackColor = true;
            this.radioButtonDiamond.CheckedChanged += new System.EventHandler(this.radioButtonDiamond_CheckedChanged);
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.Location = new System.Drawing.Point(12, 112);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(97, 24);
            this.radioButtonRectangle.TabIndex = 4;
            this.radioButtonRectangle.TabStop = true;
            this.radioButtonRectangle.Text = "Прямокутник";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            this.radioButtonRectangle.CheckedChanged += new System.EventHandler(this.radioButtonRectangle_CheckedChanged);
            // 
            // radioButtonCircle
            // 
            this.radioButtonCircle.Location = new System.Drawing.Point(125, 112);
            this.radioButtonCircle.Name = "radioButtonCircle";
            this.radioButtonCircle.Size = new System.Drawing.Size(87, 24);
            this.radioButtonCircle.TabIndex = 5;
            this.radioButtonCircle.TabStop = true;
            this.radioButtonCircle.Text = "Коло";
            this.radioButtonCircle.UseVisualStyleBackColor = true;
            this.radioButtonCircle.CheckedChanged += new System.EventHandler(this.radioButtonCircle_CheckedChanged);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(69, 154);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(143, 20);
            this.textBoxWidth.TabIndex = 6;
            // 
            // labelWidth
            // 
            this.labelWidth.Location = new System.Drawing.Point(12, 157);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(51, 17);
            this.labelWidth.TabIndex = 7;
            this.labelWidth.Text = "Width";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(69, 180);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(143, 20);
            this.textBoxHeight.TabIndex = 7;
            // 
            // labelHeight
            // 
            this.labelHeight.Location = new System.Drawing.Point(12, 183);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(51, 17);
            this.labelHeight.TabIndex = 7;
            this.labelHeight.Text = "Height";
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(69, 206);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(143, 20);
            this.textBoxRadius.TabIndex = 8;
            // 
            // labelRadius
            // 
            this.labelRadius.Location = new System.Drawing.Point(12, 209);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(51, 17);
            this.labelRadius.TabIndex = 7;
            this.labelRadius.Text = "Radius";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 556);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 25);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Зберегти список";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 587);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(200, 25);
            this.buttonLoad.TabIndex = 11;
            this.buttonLoad.Text = "Завантажити список";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // canvas
            // 
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(225, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(600, 600);
            this.canvas.TabIndex = 3;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            // 
            // coordinatesLabel
            // 
            this.coordinatesLabel.Location = new System.Drawing.Point(719, 618);
            this.coordinatesLabel.Name = "coordinatesLabel";
            this.coordinatesLabel.Size = new System.Drawing.Size(106, 23);
            this.coordinatesLabel.TabIndex = 12;
            this.coordinatesLabel.Text = "X: 0 Y: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(839, 641);
            this.Controls.Add(this.coordinatesLabel);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelRadius);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.textBoxRadius);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.radioButtonCircle);
            this.Controls.Add(this.radioButtonDiamond);
            this.Controls.Add(this.radioButtonRectangle);
            this.Controls.Add(this.radioButtonTriangle);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.calculateAreaButton);
            this.Controls.Add(this.shapeList);
            this.Controls.Add(this.canvas);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label coordinatesLabel;

        private System.Windows.Forms.Button buttonLoad;

        private System.Windows.Forms.Button buttonSave;

        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Label labelRadius;

        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelHeight;

        private System.Windows.Forms.RadioButton radioButtonTriangle;
        private System.Windows.Forms.RadioButton radioButtonDiamond;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonCircle;
    }
}
