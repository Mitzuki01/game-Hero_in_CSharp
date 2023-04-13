/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 05/09/2022
 * Time: 00:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Drawing;
	
namespace JogoHeroi2022_v0
{
	
	public class Personagem: PictureBox
	{
		public Personagem()
		{
			this.BackColor = Color.Transparent;
			this.SizeMode = PictureBoxSizeMode.StretchImage;
			this.Load(imagem);
		}
		public int hp = 100;
		public int atk = 37;
		public int def = 50;
		public int speed = 16;
	
		public string imagem = "PersonagemH.gif";
	}
}
