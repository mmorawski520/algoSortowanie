
namespace zad
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.labelChoosenFile = new System.Windows.Forms.Label();
            this.btnSeeSortedData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rndNum1 = new System.Windows.Forms.Button();
            this.rndNum2 = new System.Windows.Forms.Button();
            this.rndNum3 = new System.Windows.Forms.Button();
            this.quickSort1 = new System.Windows.Forms.Button();
            this.quickSort2 = new System.Windows.Forms.Button();
            this.quickSort3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.generateFileBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.heapsort3 = new System.Windows.Forms.Button();
            this.heapsort2 = new System.Windows.Forms.Button();
            this.heapsort1 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.mergesort3 = new System.Windows.Forms.Button();
            this.mergesort2 = new System.Windows.Forms.Button();
            this.mergesort1 = new System.Windows.Forms.Button();
            this.textboxAmountOfNumbers = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.TextBox();
            this.max = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnInsertionSort1);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(353, 177);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(59, 13);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "scoreLabel";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnInsertionSort2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(199, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnInsertionSort3);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(24, 25);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.Text = "open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // labelChoosenFile
            // 
            this.labelChoosenFile.AutoSize = true;
            this.labelChoosenFile.Location = new System.Drawing.Point(21, 9);
            this.labelChoosenFile.Name = "labelChoosenFile";
            this.labelChoosenFile.Size = new System.Drawing.Size(98, 13);
            this.labelChoosenFile.TabIndex = 6;
            this.labelChoosenFile.Text = "Choosen file : none";
            // 
            // btnSeeSortedData
            // 
            this.btnSeeSortedData.Location = new System.Drawing.Point(24, 83);
            this.btnSeeSortedData.Name = "btnSeeSortedData";
            this.btnSeeSortedData.Size = new System.Drawing.Size(75, 51);
            this.btnSeeSortedData.TabIndex = 7;
            this.btnSeeSortedData.Text = "click me to see sorted data";
            this.btnSeeSortedData.UseVisualStyleBackColor = true;
            this.btnSeeSortedData.Click += new System.EventHandler(this.btnSeeSortedData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(329, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 53);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertion sort";
            // 
            // rndNum1
            // 
            this.rndNum1.Location = new System.Drawing.Point(87, 19);
            this.rndNum1.Name = "rndNum1";
            this.rndNum1.Size = new System.Drawing.Size(75, 23);
            this.rndNum1.TabIndex = 9;
            this.rndNum1.Text = "rndNum1";
            this.rndNum1.UseVisualStyleBackColor = true;
            this.rndNum1.Click += new System.EventHandler(this.rndNum1_Click);
            // 
            // rndNum2
            // 
            this.rndNum2.Location = new System.Drawing.Point(168, 19);
            this.rndNum2.Name = "rndNum2";
            this.rndNum2.Size = new System.Drawing.Size(75, 23);
            this.rndNum2.TabIndex = 10;
            this.rndNum2.Text = "rndNum2";
            this.rndNum2.UseVisualStyleBackColor = true;
            this.rndNum2.Click += new System.EventHandler(this.rndNum2_Click);
            // 
            // rndNum3
            // 
            this.rndNum3.Location = new System.Drawing.Point(6, 19);
            this.rndNum3.Name = "rndNum3";
            this.rndNum3.Size = new System.Drawing.Size(75, 23);
            this.rndNum3.TabIndex = 11;
            this.rndNum3.Text = "rndNum3";
            this.rndNum3.UseVisualStyleBackColor = true;
            this.rndNum3.Click += new System.EventHandler(this.rndNum3_Click);
            // 
            // quickSort1
            // 
            this.quickSort1.Location = new System.Drawing.Point(6, 19);
            this.quickSort1.Name = "quickSort1";
            this.quickSort1.Size = new System.Drawing.Size(75, 23);
            this.quickSort1.TabIndex = 12;
            this.quickSort1.Text = "quickSort1";
            this.quickSort1.UseVisualStyleBackColor = true;
            this.quickSort1.Click += new System.EventHandler(this.quickSort1_Click);
            // 
            // quickSort2
            // 
            this.quickSort2.Location = new System.Drawing.Point(87, 19);
            this.quickSort2.Name = "quickSort2";
            this.quickSort2.Size = new System.Drawing.Size(75, 23);
            this.quickSort2.TabIndex = 13;
            this.quickSort2.Text = "quickSort2";
            this.quickSort2.UseVisualStyleBackColor = true;
            this.quickSort2.Click += new System.EventHandler(this.quickSort2_Click);
            // 
            // quickSort3
            // 
            this.quickSort3.Location = new System.Drawing.Point(168, 19);
            this.quickSort3.Name = "quickSort3";
            this.quickSort3.Size = new System.Drawing.Size(75, 23);
            this.quickSort3.TabIndex = 14;
            this.quickSort3.Text = "quickSort3";
            this.quickSort3.UseVisualStyleBackColor = true;
            this.quickSort3.Click += new System.EventHandler(this.quickSort3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rndNum3);
            this.groupBox2.Controls.Add(this.rndNum1);
            this.groupBox2.Controls.Add(this.rndNum2);
            this.groupBox2.Location = new System.Drawing.Point(340, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 57);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bubble sort";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.quickSort1);
            this.groupBox3.Controls.Add(this.quickSort2);
            this.groupBox3.Controls.Add(this.quickSort3);
            this.groupBox3.Location = new System.Drawing.Point(346, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 74);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quick sort";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textboxAmountOfNumbers);
            this.groupBox4.Controls.Add(this.generateFileBtn);
            this.groupBox4.Location = new System.Drawing.Point(368, 305);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // generateFileBtn
            // 
            this.generateFileBtn.Location = new System.Drawing.Point(7, 20);
            this.generateFileBtn.Name = "generateFileBtn";
            this.generateFileBtn.Size = new System.Drawing.Size(75, 23);
            this.generateFileBtn.TabIndex = 0;
            this.generateFileBtn.Text = "generate file";
            this.generateFileBtn.UseVisualStyleBackColor = true;
            this.generateFileBtn.Click += new System.EventHandler(this.generateFileBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.heapsort3);
            this.groupBox5.Controls.Add(this.heapsort2);
            this.groupBox5.Controls.Add(this.heapsort1);
            this.groupBox5.Location = new System.Drawing.Point(123, 305);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "HeapSort";
            // 
            // heapsort3
            // 
            this.heapsort3.Location = new System.Drawing.Point(7, 49);
            this.heapsort3.Name = "heapsort3";
            this.heapsort3.Size = new System.Drawing.Size(75, 23);
            this.heapsort3.TabIndex = 2;
            this.heapsort3.Text = "button6";
            this.heapsort3.UseVisualStyleBackColor = true;
            this.heapsort3.Click += new System.EventHandler(this.heapsort3_Click);
            // 
            // heapsort2
            // 
            this.heapsort2.Location = new System.Drawing.Point(88, 20);
            this.heapsort2.Name = "heapsort2";
            this.heapsort2.Size = new System.Drawing.Size(75, 23);
            this.heapsort2.TabIndex = 1;
            this.heapsort2.Text = "button5";
            this.heapsort2.UseVisualStyleBackColor = true;
            this.heapsort2.Click += new System.EventHandler(this.heapsort2_Click);
            // 
            // heapsort1
            // 
            this.heapsort1.Location = new System.Drawing.Point(6, 19);
            this.heapsort1.Name = "heapsort1";
            this.heapsort1.Size = new System.Drawing.Size(75, 23);
            this.heapsort1.TabIndex = 0;
            this.heapsort1.Text = "button4";
            this.heapsort1.UseVisualStyleBackColor = true;
            this.heapsort1.Click += new System.EventHandler(this.heapsort1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.mergesort3);
            this.groupBox6.Controls.Add(this.mergesort2);
            this.groupBox6.Controls.Add(this.mergesort1);
            this.groupBox6.Location = new System.Drawing.Point(123, 184);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "MergeSort";
            // 
            // mergesort3
            // 
            this.mergesort3.Location = new System.Drawing.Point(7, 50);
            this.mergesort3.Name = "mergesort3";
            this.mergesort3.Size = new System.Drawing.Size(75, 23);
            this.mergesort3.TabIndex = 2;
            this.mergesort3.Text = "button6";
            this.mergesort3.UseVisualStyleBackColor = true;
            this.mergesort3.Click += new System.EventHandler(this.mergesort3_Click);
            // 
            // mergesort2
            // 
            this.mergesort2.Location = new System.Drawing.Point(89, 20);
            this.mergesort2.Name = "mergesort2";
            this.mergesort2.Size = new System.Drawing.Size(75, 23);
            this.mergesort2.TabIndex = 1;
            this.mergesort2.Text = "button5";
            this.mergesort2.UseVisualStyleBackColor = true;
            this.mergesort2.Click += new System.EventHandler(this.mergesort2_Click);
            // 
            // mergesort1
            // 
            this.mergesort1.Location = new System.Drawing.Point(7, 20);
            this.mergesort1.Name = "mergesort1";
            this.mergesort1.Size = new System.Drawing.Size(75, 23);
            this.mergesort1.TabIndex = 0;
            this.mergesort1.Text = "button4";
            this.mergesort1.UseVisualStyleBackColor = true;
            this.mergesort1.Click += new System.EventHandler(this.mergesort1_Click);
            // 
            // textboxAmountOfNumbers
            // 
            this.textboxAmountOfNumbers.Location = new System.Drawing.Point(7, 52);
            this.textboxAmountOfNumbers.Name = "textboxAmountOfNumbers";
            this.textboxAmountOfNumbers.Size = new System.Drawing.Size(100, 20);
            this.textboxAmountOfNumbers.TabIndex = 1;
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(502, 327);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(100, 20);
            this.min.TabIndex = 20;
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(502, 356);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(100, 20);
            this.max.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSeeSortedData);
            this.Controls.Add(this.labelChoosenFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label labelChoosenFile;
        private System.Windows.Forms.Button btnSeeSortedData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button rndNum1;
        private System.Windows.Forms.Button rndNum2;
        private System.Windows.Forms.Button rndNum3;
        private System.Windows.Forms.Button quickSort1;
        private System.Windows.Forms.Button quickSort2;
        private System.Windows.Forms.Button quickSort3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button generateFileBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button heapsort3;
        private System.Windows.Forms.Button heapsort2;
        private System.Windows.Forms.Button heapsort1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button mergesort3;
        private System.Windows.Forms.Button mergesort2;
        private System.Windows.Forms.Button mergesort1;
        private System.Windows.Forms.TextBox textboxAmountOfNumbers;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.TextBox max;
    }
}

