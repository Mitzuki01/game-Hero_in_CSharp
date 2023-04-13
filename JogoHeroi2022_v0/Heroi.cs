/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 05/09/2022
 * Time: 00:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace JogoHeroi2022_v0
{
	
	public class Heroi: Personagem 
	{
		public Heroi()
		{
			this.Height = 150;
			this.Width = 150;
			this.Left = 150;
			this.Top = 150;
			this.speed = 26;
			
		}
		
		public int xp = 0;
		public int nivel = 0;
		
		public int sentido = -1; // pode ser 1 ou -1 
		int contCenario = 0;
		
		public string imagemDir = "PersonagemH.gif";
		public string imagemEsq = "PersonagemEsq.gif";
		
		public void Dir()
		{ 
			Left += speed;
			if(sentido !=1)
			{
				sentido = 1;
				Load(imagemDir);
			}
			if (Left > MainForm.fundo.Width - this.Width)
			{
			Left = 0;
			contCenario ++;
			if (contCenario > 2) contCenario = 0;
			MainForm.fundo.Load("cenerio"+ contCenario + ".gif");	
		}
	}
	
	
			
		public void Esquerda(){
			if ( Left  > 0)
			this.Left -= this.speed;
		}
		
		public void Direita(){
			if (Left < 550)
			this.Left += this.speed;
		}
		
		public void Cima(){
			if (Top > 0)
			this.Top -= this.speed;
		}
		public void Baixo(){
			if (Top < 250)
			this.Top += this.speed;
		}
	}
}
