/*
 * Created by SharpDevelop.
 * User: Matheus
 * Date: 05/09/2022
 * Time: 03:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms; 

namespace JogoHeroi2022_v0
{
	
	public class Cenario: PictureBox
	{
		public Cenario()
		{
		SizeMode = PictureBoxSizeMode.StretchImage;
			Width = 1230;
			Height = 510;
			Load(imagem);
		}
		public string imagem = "Fundo.gif";
	}
}
