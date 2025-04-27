
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ASI___L2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			panel1.Hide();
			panel2.Hide();
			panel3.Hide();
			panel4.Hide();
		}
		
		int toInt(string n)
		{
			return int.Parse(n);
		}
		
		double toDouble(string n)
		{
			return Convert.ToDouble(n);
		}
		
		// a. Sumar dos valores enteros y mostrar el resultado.
		//	¿Qué cambios haría para sumar valores reales?
		
		void Button1Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)) {
				MessageBox.Show("Sin datos", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			
			// bool isValid = !int.TryParse(textBox1.Text, out int resultado_1);
			
			// if (isValid) {
			//	MessageBox.Show("Necesito un número", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			//	return;
			// }
			
			//if (!int.TryParse(textBox2.Text, out int resultado_2)) {
				//MessageBox.Show("Necesito un número 2", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				//return;
			//}
			
			rta.Text = (toInt(textBox1.Text) + toInt(textBox2.Text)).ToString();
		}
		
		
		// b. Obtener el promedio de 4 valores reales y mostrarlos por pantalla.	
		
		void Button2Click(object sender, EventArgs e)
		{
			double a = toDouble(textBox3.Text);
			double b = toDouble(textBox4.Text);
			double c = toDouble(textBox5.Text);
			double d = toDouble(textBox6.Text);
			
			// double rta = (a + b + c + d) / 4;
			// string rta2 = rta.ToString();
				
			textBox7.Text = ((a + b + c + d) / 4).ToString();
		}
		
		// c. Calcular el precio final de un producto, sabiendo que si el precio inicial es mayor a $50 mil se hará un descuento de 25%, de lo contrario no se aplica descuento.
		
		void Button3Click(object sender, EventArgs e)
		{
			double _precio = toDouble(precio.Text);
			double _descuento = toDouble(descuento.Text);
			
			double _total = _precio;
			
			if (_precio > 50000) {
				double _subtotal = _precio * (_descuento / 100);
				_total = _precio - _subtotal;
			}
			
			totalPrecio.Text = _total.ToString();
			// totalPrecio.Text = (_precio > 50000 ? _precio * 0.75 : _precio).ToString();
		}
		
		// d. Obtener el mes correspondiente al ingresar un número entero entre 1 y 12. Si se ingresa un valor fuera de este rango debe indicar un error.
		// DateTime		
		// e. Obtener las raíces de una ecuación cuadrática, incluya la posibilidad de obtener raíces complejas.  
		// f. Indicar cuál de n valores enteros ingresados es el mayor y cuál es el menor. 
		// g. Obtener la suma de n números reales. 
		
		List<double> numeros = new List<double>();
		void Button43Click(object sender, EventArgs e)
		{
			double aux = toDouble(textBox8.Text);
			numeros.Add(aux);
			
			// double total = 0;
			//for (int i = 0; i < numeros.Count; i++) {
			//	total = total + numeros[i];
			// }
			
			textBox9.Text = numeros.Sum().ToString();
		}
		
		// h. Obtener el promedio de n valores ingresados.
		int index = 0;
		void Button4Click(object sender, EventArgs e)
		{
			index = index + 1;
			double aux = toDouble(textBox8.Text);
			numeros.Add(aux);
			
			double total = numeros.Sum() / index;
			
			textBox9.Text = total.ToString();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			panel1.Show();
			panel2.Hide();
			panel3.Hide();
			panel4.Hide();
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			panel1.Hide();
			panel2.Show();
			panel3.Hide();
			panel4.Hide();
		}
	}
		
}
