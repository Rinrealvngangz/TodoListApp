namespace ToDoListApp
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkbox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.PanelContro = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelContro.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkbox1
            // 
            this.checkbox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkbox1.CheckedState.BorderRadius = 0;
            this.checkbox1.CheckedState.BorderThickness = 0;
            this.checkbox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox1.Location = new System.Drawing.Point(28, 17);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(27, 35);
            this.checkbox1.TabIndex = 3;
            this.checkbox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkbox1.UncheckedState.BorderRadius = 0;
            this.checkbox1.UncheckedState.BorderThickness = 0;
            this.checkbox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // PanelContro
            // 
            this.PanelContro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PanelContro.Controls.Add(this.label1);
            this.PanelContro.Controls.Add(this.checkbox1);
            this.PanelContro.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PanelContro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContro.Location = new System.Drawing.Point(0, 0);
            this.PanelContro.Name = "PanelContro";
            this.PanelContro.ShadowDecoration.Enabled = true;
            this.PanelContro.ShadowDecoration.Parent = this.PanelContro;
            this.PanelContro.Size = new System.Drawing.Size(468, 66);
            this.PanelContro.TabIndex = 6;
            this.PanelContro.MouseLeave += new System.EventHandler(this.PanelContro_MouseLeave);
            this.PanelContro.MouseHover += new System.EventHandler(this.PanelContro_MouseHover);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelContro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(468, 66);
            this.PanelContro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CheckBox checkbox1;
        private Guna.UI2.WinForms.Guna2Panel PanelContro;
        private System.Windows.Forms.Label label1;
    }
}
