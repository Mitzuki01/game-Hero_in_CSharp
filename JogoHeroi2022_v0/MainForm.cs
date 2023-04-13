/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 04/09/2022
 * Time: 23:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JogoHeroi2022_v0
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
		    InitializeComponent();
			//centralizando botão iniciar
			button1.Left = (this.Width - button1.Width)/2;
		}
		
		
		//Criando objetos do jogo
		Heroi heroi = new Heroi();
		//Cenario scene = new Cenario();
		public static Cenario fundo = new Cenario();
		
		void Button1Click(object sender, EventArgs e)
		{
			button1.Visible = false;	
			button1.Enabled = false;
			this.KeyPreview = true; // habilita o uso no teclado sob o mainForm
			
			//Configurar cenario 
			fundo.Parent = this;
			fundo.Load("Fundo.gif");
			fundo.Width = Width;
			fundo.Height = Height-36;
			
			heroi.Parent = fundo;
	
		}
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			e.Handled = e.SuppressKeyPress = true; // para evitar o som de alertas do windows 
			// verificar tecla pressionada 
			if(e.KeyCode==Keys.A) heroi.Esquerda();
			if(e.KeyCode==Keys.S) heroi.Baixo();
			if(e.KeyCode==Keys.D) heroi.Direita();
			if(e.KeyCode==Keys.W) heroi.Cima();
		}
		
		
		
	}
}
