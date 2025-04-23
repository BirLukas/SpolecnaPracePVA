namespace SpolecnaPracePVACode
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
            CocktailImage = new PictureBox();
            NewCocktailBtn = new Button();
            Heading = new Label();
            NameLabel = new Label();
            GlassLabel = new Label();
            CategoryLabel = new Label();
            AlcoholicLabel = new Label();
            InstructionsLabel = new Label();
            IngredientsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)CocktailImage).BeginInit();
            SuspendLayout();
            // 
            // CocktailImage
            // 
            CocktailImage.BackgroundImageLayout = ImageLayout.Center;
            CocktailImage.Location = new Point(11, 9);
            CocktailImage.Name = "CocktailImage";
            CocktailImage.Size = new Size(280, 280);
            CocktailImage.TabIndex = 0;
            CocktailImage.TabStop = false;
            // 
            // NewCocktailBtn
            // 
            NewCocktailBtn.BackColor = Color.Yellow;
            NewCocktailBtn.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            NewCocktailBtn.Location = new Point(11, 295);
            NewCocktailBtn.Name = "NewCocktailBtn";
            NewCocktailBtn.Size = new Size(280, 37);
            NewCocktailBtn.TabIndex = 1;
            NewCocktailBtn.Text = "New random cocktail!";
            NewCocktailBtn.UseVisualStyleBackColor = false;
            NewCocktailBtn.Click += NewCocktailBtn_Click;
            // 
            // Heading
            // 
            Heading.AutoSize = true;
            Heading.Font = new Font("Segoe UI", 14F);
            Heading.Location = new Point(297, 9);
            Heading.Name = "Heading";
            Heading.Size = new Size(342, 32);
            Heading.TabIndex = 2;
            Heading.Text = "Information about the cocktail:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 12F);
            NameLabel.Location = new Point(297, 48);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(73, 28);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Name: ";
            // 
            // GlassLabel
            // 
            GlassLabel.AutoSize = true;
            GlassLabel.Font = new Font("Segoe UI", 12F);
            GlassLabel.Location = new Point(297, 76);
            GlassLabel.Name = "GlassLabel";
            GlassLabel.Size = new Size(66, 28);
            GlassLabel.TabIndex = 4;
            GlassLabel.Text = "Glass: ";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Segoe UI", 12F);
            CategoryLabel.Location = new Point(297, 104);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(101, 28);
            CategoryLabel.TabIndex = 5;
            CategoryLabel.Text = "Category: ";
            // 
            // AlcoholicLabel
            // 
            AlcoholicLabel.AutoSize = true;
            AlcoholicLabel.Font = new Font("Segoe UI", 12F);
            AlcoholicLabel.Location = new Point(297, 132);
            AlcoholicLabel.Name = "AlcoholicLabel";
            AlcoholicLabel.Size = new Size(102, 28);
            AlcoholicLabel.TabIndex = 6;
            AlcoholicLabel.Text = "Alcoholic: ";
            // 
            // InstructionsLabel
            // 
            InstructionsLabel.AutoSize = true;
            InstructionsLabel.Font = new Font("Segoe UI", 12F);
            InstructionsLabel.Location = new Point(297, 213);
            InstructionsLabel.Name = "InstructionsLabel";
            InstructionsLabel.Size = new Size(122, 28);
            InstructionsLabel.TabIndex = 7;
            InstructionsLabel.Text = "Instructions: ";
            // 
            // IngredientsLabel
            // 
            IngredientsLabel.AutoSize = true;
            IngredientsLabel.Font = new Font("Segoe UI", 12F);
            IngredientsLabel.Location = new Point(297, 160);
            IngredientsLabel.Name = "IngredientsLabel";
            IngredientsLabel.Size = new Size(114, 28);
            IngredientsLabel.TabIndex = 8;
            IngredientsLabel.Text = "Ingredients:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 344);
            Controls.Add(IngredientsLabel);
            Controls.Add(InstructionsLabel);
            Controls.Add(AlcoholicLabel);
            Controls.Add(CategoryLabel);
            Controls.Add(GlassLabel);
            Controls.Add(NameLabel);
            Controls.Add(Heading);
            Controls.Add(NewCocktailBtn);
            Controls.Add(CocktailImage);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)CocktailImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox CocktailImage;
        private Button NewCocktailBtn;
        private Label Heading;
        private Label NameLabel;
        private Label GlassLabel;
        private Label CategoryLabel;
        private Label AlcoholicLabel;
        private Label InstructionsLabel;
        private Label IngredientsLabel;
    }
}
