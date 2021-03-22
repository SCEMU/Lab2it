namespace ITPractic2
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.imageList2 = new System.Windows.Forms.ImageList(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(98, 34);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(141, 20);
      this.textBox1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(24, 37);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(68, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Введите X >";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(24, 75);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(99, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Результат работы";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(27, 102);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(212, 84);
      this.textBox2.TabIndex = 3;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(129, 70);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(110, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "Вычислить";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // imageList1
      // 
      this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
      this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::ITPractic2.Properties.Resources.Снимок;
   
      this.pictureBox1.Location = new System.Drawing.Point(254, 111);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(166, 75);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // imageList2
      // 
      
      this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
     
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(421, 218);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox1);
      this.Name = "Form1";
      this.Text = "Решала";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
      this.Resize += new System.EventHandler(this.Form1_Resize);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.ImageList imageList2;
  }
}

