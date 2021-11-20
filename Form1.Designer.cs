
namespace Trabalho_de_Substituição_do_PI
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
            this.label_numeros = new System.Windows.Forms.Label();
            this.num_1 = new System.Windows.Forms.TextBox();
            this.num_2 = new System.Windows.Forms.TextBox();
            this.button_maior = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button_menor = new System.Windows.Forms.RadioButton();
            this.button_soma = new System.Windows.Forms.RadioButton();
            this.button_media = new System.Windows.Forms.RadioButton();
            this.button_close = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_numeros
            // 
            this.label_numeros.AutoSize = true;
            this.label_numeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numeros.Location = new System.Drawing.Point(27, 29);
            this.label_numeros.Name = "label_numeros";
            this.label_numeros.Size = new System.Drawing.Size(146, 18);
            this.label_numeros.TabIndex = 0;
            this.label_numeros.Text = "Digite Dois Números";
            // 
            // num_1
            // 
            this.num_1.Location = new System.Drawing.Point(195, 29);
            this.num_1.Name = "num_1";
            this.num_1.Size = new System.Drawing.Size(40, 20);
            this.num_1.TabIndex = 1;
            // 
            // num_2
            // 
            this.num_2.Location = new System.Drawing.Point(256, 29);
            this.num_2.Name = "num_2";
            this.num_2.Size = new System.Drawing.Size(40, 20);
            this.num_2.TabIndex = 2;
            // 
            // button_maior
            // 
            this.button_maior.AutoSize = true;
            this.button_maior.Location = new System.Drawing.Point(30, 83);
            this.button_maior.Name = "button_maior";
            this.button_maior.Size = new System.Drawing.Size(91, 17);
            this.button_maior.TabIndex = 3;
            this.button_maior.TabStop = true;
            this.button_maior.Text = "Maior Número";
            this.button_maior.UseVisualStyleBackColor = true;
            this.button_maior.CheckedChanged += new System.EventHandler(this.button_maior_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(332, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button_menor
            // 
            this.button_menor.AutoSize = true;
            this.button_menor.Location = new System.Drawing.Point(30, 106);
            this.button_menor.Name = "button_menor";
            this.button_menor.Size = new System.Drawing.Size(95, 17);
            this.button_menor.TabIndex = 5;
            this.button_menor.TabStop = true;
            this.button_menor.Text = "Menor Número";
            this.button_menor.UseVisualStyleBackColor = true;
            this.button_menor.CheckedChanged += new System.EventHandler(this.button_menor_CheckedChanged);
            // 
            // button_soma
            // 
            this.button_soma.AutoSize = true;
            this.button_soma.Location = new System.Drawing.Point(30, 129);
            this.button_soma.Name = "button_soma";
            this.button_soma.Size = new System.Drawing.Size(52, 17);
            this.button_soma.TabIndex = 6;
            this.button_soma.TabStop = true;
            this.button_soma.Text = "Soma";
            this.button_soma.UseVisualStyleBackColor = true;
            this.button_soma.CheckedChanged += new System.EventHandler(this.button_soma_CheckedChanged);
            // 
            // button_media
            // 
            this.button_media.AutoSize = true;
            this.button_media.Location = new System.Drawing.Point(30, 152);
            this.button_media.Name = "button_media";
            this.button_media.Size = new System.Drawing.Size(54, 17);
            this.button_media.TabIndex = 7;
            this.button_media.TabStop = true;
            this.button_media.Text = "Média";
            this.button_media.UseVisualStyleBackColor = true;
            this.button_media.CheckedChanged += new System.EventHandler(this.button_media_CheckedChanged);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(30, 186);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(52, 23);
            this.button_close.TabIndex = 8;
            this.button_close.Text = "Sair";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.Location = new System.Drawing.Point(209, 63);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(73, 16);
            this.label_result.TabIndex = 9;
            this.label_result.Text = "Resultado:";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(209, 84);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(17, 16);
            this.result.TabIndex = 10;
            this.result.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 237);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_media);
            this.Controls.Add(this.button_soma);
            this.Controls.Add(this.button_menor);
            this.Controls.Add(this.button_maior);
            this.Controls.Add(this.num_2);
            this.Controls.Add(this.num_1);
            this.Controls.Add(this.label_numeros);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_numeros;
        private System.Windows.Forms.TextBox num_1;
        private System.Windows.Forms.TextBox num_2;
        private System.Windows.Forms.RadioButton button_maior;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RadioButton button_menor;
        private System.Windows.Forms.RadioButton button_soma;
        private System.Windows.Forms.RadioButton button_media;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label result;
    }
}

