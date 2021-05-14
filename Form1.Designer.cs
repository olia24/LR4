namespace WindowsFormsApp1
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
            this.TB_ParamData = new System.Windows.Forms.TextBox();
            this.LB_Objects = new System.Windows.Forms.ListBox();
            this.B_DeleteObject = new System.Windows.Forms.Button();
            this.B_ClearList = new System.Windows.Forms.Button();
            this.B_NewObject = new System.Windows.Forms.Button();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_ParamData
            // 
            this.TB_ParamData.Enabled = false;
            this.TB_ParamData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TB_ParamData.Location = new System.Drawing.Point(0, 12);
            this.TB_ParamData.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.TB_ParamData.Multiline = true;
            this.TB_ParamData.Name = "TB_ParamData";
            this.TB_ParamData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_ParamData.Size = new System.Drawing.Size(4, 422);
            this.TB_ParamData.TabIndex = 0;
            // 
            // LB_Objects
            // 
            this.LB_Objects.BackColor = System.Drawing.SystemColors.Control;
            this.LB_Objects.FormattingEnabled = true;
            this.LB_Objects.Location = new System.Drawing.Point(0, 12);
            this.LB_Objects.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LB_Objects.Name = "LB_Objects";
            this.LB_Objects.Size = new System.Drawing.Size(4, 420);
            this.LB_Objects.TabIndex = 1;
            this.LB_Objects.SelectedIndexChanged += new System.EventHandler(this.LB_Objects_SelectedIndexChanged);
            // 
            // B_DeleteObject
            // 
            this.B_DeleteObject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_DeleteObject.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_DeleteObject.ForeColor = System.Drawing.Color.Black;
            this.B_DeleteObject.Location = new System.Drawing.Point(0, 94);
            this.B_DeleteObject.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.B_DeleteObject.Name = "B_DeleteObject";
            this.B_DeleteObject.Size = new System.Drawing.Size(0, 63);
            this.B_DeleteObject.TabIndex = 5;
            this.B_DeleteObject.Text = "Delete Object";
            this.B_DeleteObject.UseVisualStyleBackColor = true;
            this.B_DeleteObject.Click += new System.EventHandler(this.B_DeleteObject_Click);
            // 
            // B_ClearList
            // 
            this.B_ClearList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_ClearList.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_ClearList.ForeColor = System.Drawing.Color.Black;
            this.B_ClearList.Location = new System.Drawing.Point(0, 12);
            this.B_ClearList.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.B_ClearList.Name = "B_ClearList";
            this.B_ClearList.Size = new System.Drawing.Size(0, 59);
            this.B_ClearList.TabIndex = 6;
            this.B_ClearList.Text = "Clear List";
            this.B_ClearList.UseVisualStyleBackColor = true;
            this.B_ClearList.Click += new System.EventHandler(this.B_ClearList_Click);
            // 
            // B_NewObject
            // 
            this.B_NewObject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_NewObject.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_NewObject.ForeColor = System.Drawing.Color.Black;
            this.B_NewObject.Location = new System.Drawing.Point(0, 235);
            this.B_NewObject.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.B_NewObject.Name = "B_NewObject";
            this.B_NewObject.Size = new System.Drawing.Size(0, 71);
            this.B_NewObject.TabIndex = 7;
            this.B_NewObject.Text = "New Object";
            this.B_NewObject.UseVisualStyleBackColor = true;
            this.B_NewObject.Click += new System.EventHandler(this.B_NewObject_Click);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(WindowsFormsApp1.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(0F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.B_NewObject);
            this.Controls.Add(this.B_ClearList);
            this.Controls.Add(this.B_DeleteObject);
            this.Controls.Add(this.LB_Objects);
            this.Controls.Add(this.TB_ParamData);
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_ParamData;
        private System.Windows.Forms.ListBox LB_Objects;
        private System.Windows.Forms.Button B_DeleteObject;
        private System.Windows.Forms.Button B_ClearList;
        private System.Windows.Forms.Button B_NewObject;
        private System.Windows.Forms.BindingSource form1BindingSource;
    }
}

