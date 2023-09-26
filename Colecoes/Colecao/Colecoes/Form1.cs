﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			Lista.Items.Clear();

			// Array
			string[] nomes = new string[3];
			nomes[0] = "Guilherme";
			nomes[1] = "Ana";
			nomes[2] = "Gabriel";

			// Lista Genérica
			List<string> nomes2 = new List<string>();

			nomes2.Add("Eduardo");
			nomes2.Add("Fabiana");
			nomes2.AddRange(nomes);
			string item = nomes2[3];

			//if (nomes2.Remove("Eduardo"))
			//{
			//	MessageBox.Show("Eduardo removido");
			//}
			//else
			//{
			//	MessageBox.Show("Não foi possível remover.");
			//}

			//         if (nomes2.Contains("Gustavo"))
			//         {
			//	MessageBox.Show("Contém");
			//         }
			//else
			//{
			//	MessageBox.Show("Não contém");
			//}

			//MessageBox.Show("Numero de elementos: " + nomes2.Count);

			//nomes2.Sort();

			//MessageBox.Show("Fabiana está no indíce: " + nomes2.IndexOf("Fabiana"));

			//nomes2.Insert(2, "João");

			//nomes2.RemoveAt(1);

			//nomes2.Clear();

			nomes2.Add("Guilherme");

			foreach (string nome in nomes2)
			{
				Lista.Items.Add(nome);
			}
		}

		private void btnHashSet_Click(object sender, EventArgs e)
		{
			Lista.Items.Clear();

			HashSet<string> veiculos = new HashSet<string>()
			{
				"Carro", "Moto", "Avião", "Helicóptero", "Barco"
			};

			//MessageBox.Show(veiculos.ElementAt(2));

			//         if (veiculos.Add("Moto"))
			//         {
			//	MessageBox.Show("Item adicionado");
			//         }
			//else
			//{
			//	MessageBox.Show("Item não adicionado");
			//}

			//         if (veiculos.Contains("Carro"))
			//         {
			//	MessageBox.Show("Contém.");
			//}
			//else
			//{
			//	MessageBox.Show("Não contém.");
			//}

			// veiculos.Remove("");
			// int num = veiculos.Count;
			// veiculos.Clear();

			//MessageBox.Show(veiculos.First());
			//MessageBox.Show(veiculos.Last());

			foreach (string item in veiculos)
			{
				Lista.Items.Add(item);
			}
		}

		private void btnDictionary_Click(object sender, EventArgs e)
		{
			Dictionary<int, string> alunos = new Dictionary<int, string>()
			{
				{ 150, "Gabriel" },
				{ 200, "Ana" },
				{ 80, "Gabriel" }
			};

			alunos.Add(100, "Guilherme");

            foreach (KeyValuePair<int, string> item in alunos)
            {
				Lista.Items.Add(item.Key + " = " + item.Value);
            }
        }
	}
}
