﻿namespace Parte004
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.lista = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lista
			// 
			this.lista.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.lista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lista.Dock = System.Windows.Forms.DockStyle.Right;
			this.lista.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lista.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lista.FormattingEnabled = true;
			this.lista.ItemHeight = 29;
			this.lista.Location = new System.Drawing.Point(300, 0);
			this.lista.Name = "lista";
			this.lista.Size = new System.Drawing.Size(500, 505);
			this.lista.Sorted = true;
			this.lista.TabIndex = 0;
			this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 66);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(272, 64);
			this.button1.TabIndex = 1;
			this.button1.Text = "Adicionar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(13, 13);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(271, 35);
			this.txtNome.TabIndex = 2;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 136);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(272, 64);
			this.button2.TabIndex = 3;
			this.button2.Text = "Logar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 206);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(272, 64);
			this.button3.TabIndex = 4;
			this.button3.Text = "Remover Item";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(13, 276);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(272, 64);
			this.button4.TabIndex = 5;
			this.button4.Text = "Remover Item do Índice";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(12, 346);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(272, 64);
			this.button5.TabIndex = 6;
			this.button5.Text = "Quantidade de Items";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 505);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lista);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lista;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
	}
}

