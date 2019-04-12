namespace Markov_Chains
{
    partial class MainForm
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonWordFirst = new System.Windows.Forms.Button();
            this.buttonWordThird = new System.Windows.Forms.Button();
            this.buttonWordSecond = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput.Location = new System.Drawing.Point(12, 12);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(498, 30);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(516, 11);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(116, 67);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonWordFirst
            // 
            this.buttonWordFirst.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWordFirst.Location = new System.Drawing.Point(12, 48);
            this.buttonWordFirst.Name = "buttonWordFirst";
            this.buttonWordFirst.Size = new System.Drawing.Size(162, 30);
            this.buttonWordFirst.TabIndex = 2;
            this.buttonWordFirst.UseVisualStyleBackColor = true;
            this.buttonWordFirst.Click += new System.EventHandler(this.buttonWordFirst_Click);
            // 
            // buttonWordThird
            // 
            this.buttonWordThird.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWordThird.Location = new System.Drawing.Point(348, 48);
            this.buttonWordThird.Name = "buttonWordThird";
            this.buttonWordThird.Size = new System.Drawing.Size(162, 30);
            this.buttonWordThird.TabIndex = 3;
            this.buttonWordThird.UseVisualStyleBackColor = true;
            this.buttonWordThird.Click += new System.EventHandler(this.buttonWordThird_Click);
            // 
            // buttonWordSecond
            // 
            this.buttonWordSecond.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWordSecond.Location = new System.Drawing.Point(180, 48);
            this.buttonWordSecond.Name = "buttonWordSecond";
            this.buttonWordSecond.Size = new System.Drawing.Size(162, 30);
            this.buttonWordSecond.TabIndex = 4;
            this.buttonWordSecond.UseVisualStyleBackColor = true;
            this.buttonWordSecond.Click += new System.EventHandler(this.buttonWordSecond_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 86);
            this.Controls.Add(this.buttonWordSecond);
            this.Controls.Add(this.buttonWordThird);
            this.Controls.Add(this.buttonWordFirst);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxInput);
            this.Name = "MainForm";
            this.Text = "Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonWordFirst;
        private System.Windows.Forms.Button buttonWordThird;
        private System.Windows.Forms.Button buttonWordSecond;
    }
}

