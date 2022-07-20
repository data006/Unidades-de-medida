using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace UnidadesCS
{
	public partial class frmUnidadesCS : Form
	{



		public frmUnidadesCS()
		{
			InitializeComponent();
		}



		private CheckBox chkBoxes = null;
		private double dato = 0;
		private double resultado = 0;


		//Bloquear no numericos
		private void txtUnidades_KeyPress(object sender, KeyPressEventArgs e)
		{

			if ((txtUnidades.Text ?? "") == (string.Empty ?? ""))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Conversions.ToString(e.KeyChar) == ".") & !(Conversions.ToString(e.KeyChar) == "-");
			}
			else if (!txtUnidades.Text.Contains("."))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Conversions.ToString(e.KeyChar) == ".");
			}
			else if (!txtUnidades.Text.Contains("-"))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Conversions.ToString(e.KeyChar) == "-");
			}
			else if (txtUnidades.Text.Contains(".") & txtUnidades.Text.Contains("-"))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar);
			}

		}

			



		//LongitudIn
		private void chkMm_Click(object sender, EventArgs e)
		{

			// Desactivar los grp de salida no utiles
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpLongitudOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkMm.Checked == true)
			{
				if (chkCm.Checked == true)
				{
					chkCm.Checked = false;
				}

				if (chkM.Checked == true)
				{
					chkM.Checked = false;
				}

				if (chkKm.Checked == true)
				{
					chkKm.Checked = false;
				}

				if (chkIn.Checked == true)
				{
					chkIn.Checked = false;
				}

				if (chkFt.Checked == true)
				{
					chkFt.Checked = false;
				}

				if (chkYd.Checked == true)
				{
					chkYd.Checked = false;
				}

				if (chkMi.Checked == true)
				{
					chkMi.Checked = false;
				}

				if (grpLongitudOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpLongitudOut.Enabled = true;
					foreach (object Item in grpLongitudOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkMmOut.Enabled = false;
				}
			}

		}

		private void chkCm_Click(object sender, EventArgs e)
		{

			// Desactivar los grp de salida no utiles
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpLongitudOut.Enabled = true;



			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkCm.Checked == true)
			{
				if (chkMm.Checked == true)
				{
					chkMm.Checked = false;
				}

				if (chkM.Checked == true)
				{
					chkM.Checked = false;
				}

				if (chkKm.Checked == true)
				{
					chkKm.Checked = false;
				}

				if (chkIn.Checked == true)
				{
					chkIn.Checked = false;
				}

				if (chkFt.Checked == true)
				{
					chkFt.Checked = false;
				}

				if (chkYd.Checked == true)
				{
					chkYd.Checked = false;
				}

				if (chkMi.Checked == true)
				{
					chkMi.Checked = false;
				}

				if (grpLongitudOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpLongitudOut.Enabled = true;
					foreach (object Item in grpLongitudOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkCmOut.Enabled = false;
				}
			}

		}

		private void chkM_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpLongitudOut.Enabled = true;



			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkM.Checked == true)
			{
				if (chkMm.Checked == true)
				{
					chkMm.Checked = false;
				}

				if (chkCm.Checked == true)
				{
					chkCm.Checked = false;
				}

				if (chkKm.Checked == true)
				{
					chkKm.Checked = false;
				}

				if (chkIn.Checked == true)
				{
					chkIn.Checked = false;
				}

				if (chkFt.Checked == true)
				{
					chkFt.Checked = false;
				}

				if (chkYd.Checked == true)
				{
					chkYd.Checked = false;
				}

				if (chkMi.Checked == true)
				{
					chkMi.Checked = false;
				}

				if (grpLongitudOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpLongitudOut.Enabled = true;
					foreach (object Item in grpLongitudOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkMOut.Enabled = false;
				}
			}

		
		}

		private void chkKm_Click(object sender, EventArgs e)
		{

			// Desactivar los grp de salida no utiles
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpLongitudOut.Enabled = true;


			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkKm.Checked == true)
			{
				if (chkMm.Checked == true)
				{
					chkMm.Checked = false;
				}

				if (chkM.Checked == true)
				{
					chkM.Checked = false;
				}

				if (chkCm.Checked == true)
				{
					chkCm.Checked = false;
				}

				if (chkIn.Checked == true)
				{
					chkIn.Checked = false;
				}

				if (chkFt.Checked == true)
				{
					chkFt.Checked = false;
				}

				if (chkYd.Checked == true)
				{
					chkYd.Checked = false;
				}

				if (chkMi.Checked == true)
				{
					chkMi.Checked = false;
				}

				if (grpLongitudOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpLongitudOut.Enabled = true;
					foreach (object Item in grpLongitudOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkKmOut.Enabled = false;
				}
			}

		}

		private void chkIn_Click(object sender, EventArgs e)
		{

			// Desactivar los grp de salida no utiles
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpLongitudOut.Enabled = true;


			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkIn.Checked == true)
			{
				if (chkMm.Checked == true)
				{
					chkMm.Checked = false;
				}

				if (chkM.Checked == true)
				{
					chkM.Checked = false;
				}

				if (chkKm.Checked == true)
				{
					chkKm.Checked = false;
				}

				if (chkCm.Checked == true)
				{
					chkCm.Checked = false;
				}

				if (chkFt.Checked == true)
				{
					chkFt.Checked = false;
				}

				if (chkYd.Checked == true)
				{
					chkYd.Checked = false;
				}

				if (chkMi.Checked == true)
				{
					chkMi.Checked = false;
				}

				if (grpLongitudOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpLongitudOut.Enabled = true;
					foreach (object Item in grpLongitudOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkInOut.Enabled = false;
				}
			}

		}

		private void chkFt_Click(object sender, EventArgs e)
		{

			// Desactivar los grp de salida no utiles
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpLongitudOut.Enabled = true;


			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkFt.Checked == true)
			{
				if (chkMm.Checked == true)
				{
					chkMm.Checked = false;
				}

				if (chkM.Checked == true)
				{
					chkM.Checked = false;
				}

				if (chkKm.Checked == true)
				{
					chkKm.Checked = false;
				}

				if (chkIn.Checked == true)
				{
					chkIn.Checked = false;
				}

				if (chkCm.Checked == true)
				{
					chkCm.Checked = false;
				}

				if (chkYd.Checked == true)
				{
					chkYd.Checked = false;
				}

				if (chkMi.Checked == true)
				{
					chkMi.Checked = false;
				}

				if (grpLongitudOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpLongitudOut.Enabled = true;
					foreach (object Item in grpLongitudOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkFtOut.Enabled = false;
				}
			}

		}

		private void chkYd_Click(object sender, EventArgs e)
		{

			// Desactivar los grp de salida no utiles
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpLongitudOut.Enabled = true;


			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkYd.Checked == true)
			{
				if (chkMm.Checked == true)
				{
					chkMm.Checked = false;
				}

				if (chkM.Checked == true)
				{
					chkM.Checked = false;
				}

				if (chkKm.Checked == true)
				{
					chkKm.Checked = false;
				}

				if (chkIn.Checked == true)
				{
					chkIn.Checked = false;
				}

				if (chkFt.Checked == true)
				{
					chkFt.Checked = false;
				}

				if (chkCm.Checked == true)
				{
					chkCm.Checked = false;
				}

				if (chkMi.Checked == true)
				{
					chkMi.Checked = false;
				}

				if (grpLongitudOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpLongitudOut.Enabled = true;
					foreach (object Item in grpLongitudOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkYdOut.Enabled = false;
				}
			}

		}

		private void chkMi_Click(object sender, EventArgs e)
		{

			// Desactivar los grp de salida no utiles
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpLongitudOut.Enabled = true;


			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkMi.Checked == true)
			{
				if (chkMm.Checked == true)
				{
					chkMm.Checked = false;
				}

				if (chkM.Checked == true)
				{
					chkM.Checked = false;
				}

				if (chkKm.Checked == true)
				{
					chkKm.Checked = false;
				}

				if (chkIn.Checked == true)
				{
					chkIn.Checked = false;
				}

				if (chkFt.Checked == true)
				{
					chkFt.Checked = false;
				}

				if (chkYd.Checked == true)
				{
					chkYd.Checked = false;
				}

				if (chkCm.Checked == true)
				{
					chkCm.Checked = false;
				}

				if (grpLongitudOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpLongitudOut.Enabled = true;
					foreach (object Item in grpLongitudOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkMiOut.Enabled = false;
				}
			}

		}







		//MasaIn
		private void chkMg_Click(object sender, EventArgs e)
		{

			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpMasaOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkMg.Checked == true)
			{
				if (chkG.Checked == true)
				{
					chkG.Checked = false;
				}

				if (chkKg.Checked == true)
				{
					chkKg.Checked = false;
				}

				if (chkTon.Checked == true)
				{
					chkTon.Checked = false;
				}

				if (chkOz.Checked == true)
				{
					chkOz.Checked = false;
				}

				if (chkLb.Checked == true)
				{
					chkLb.Checked = false;
				}

				if (chkTonInglesa.Checked == true)
				{
					chkTonInglesa.Checked = false;
				}

				if (grpMasaOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpMasaOut.Enabled = true;
					foreach (object Item in grpMasaOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkMgOut.Enabled = false;
				}
			}

		}

		private void chkG_Click(object sender, EventArgs e)
		{

			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpMasaOut.Enabled = true;



			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkG.Checked == true)
			{
				if (chkMg.Checked == true)
				{
					chkMg.Checked = false;
				}

				if (chkKg.Checked == true)
				{
					chkKg.Checked = false;
				}

				if (chkTon.Checked == true)
				{
					chkTon.Checked = false;
				}

				if (chkOz.Checked == true)
				{
					chkOz.Checked = false;
				}

				if (chkLb.Checked == true)
				{
					chkLb.Checked = false;
				}

				if (chkTonInglesa.Checked == true)
				{
					chkTonInglesa.Checked = false;
				}

				if (grpMasaOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpMasaOut.Enabled = true;
					foreach (object Item in grpMasaOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkGOut.Enabled = false;
				}
			}

		}

		private void chkKg_Click(object sender, EventArgs e)
		{

			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpMasaOut.Enabled = true;



			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkKg.Checked == true)
			{
				if (chkMg.Checked == true)
				{
					chkMg.Checked = false;
				}

				if (chkG.Checked == true)
				{
					chkG.Checked = false;
				}

				if (chkTon.Checked == true)
				{
					chkTon.Checked = false;
				}

				if (chkOz.Checked == true)
				{
					chkOz.Checked = false;
				}

				if (chkLb.Checked == true)
				{
					chkLb.Checked = false;
				}

				if (chkTonInglesa.Checked == true)
				{
					chkTonInglesa.Checked = false;
				}

				if (grpMasaOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpMasaOut.Enabled = true;
					foreach (object Item in grpMasaOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkKgOut.Enabled = false;
				}
			}

		}

		private void chkTon_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpMasaOut.Enabled = true;



			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkTon.Checked == true)
			{
				if (chkMg.Checked == true)
				{
					chkMg.Checked = false;
				}

				if (chkKg.Checked == true)
				{
					chkKg.Checked = false;
				}

				if (chkG.Checked == true)
				{
					chkG.Checked = false;
				}

				if (chkOz.Checked == true)
				{
					chkOz.Checked = false;
				}

				if (chkLb.Checked == true)
				{
					chkLb.Checked = false;
				}

				if (chkTonInglesa.Checked == true)
				{
					chkTonInglesa.Checked = false;
				}

				if (grpMasaOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpMasaOut.Enabled = true;
					foreach (object Item in grpMasaOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkTonOut.Enabled = false;
				}
			}
		}

		private void chkOz_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpMasaOut.Enabled = true;



			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkOz.Checked == true)
			{
				if (chkMg.Checked == true)
				{
					chkMg.Checked = false;
				}

				if (chkKg.Checked == true)
				{
					chkKg.Checked = false;
				}

				if (chkTon.Checked == true)
				{
					chkTon.Checked = false;
				}

				if (chkG.Checked == true)
				{
					chkG.Checked = false;
				}

				if (chkLb.Checked == true)
				{
					chkLb.Checked = false;
				}

				if (chkTonInglesa.Checked == true)
				{
					chkTonInglesa.Checked = false;
				}

				if (grpMasaOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpMasaOut.Enabled = true;
					foreach (object Item in grpMasaOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkOzOut.Enabled = false;
				}
			}
		}

		private void chkLb_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpMasaOut.Enabled = true;



			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkLb.Checked == true)
			{
				if (chkMg.Checked == true)
				{
					chkMg.Checked = false;
				}

				if (chkKg.Checked == true)
				{
					chkKg.Checked = false;
				}

				if (chkTon.Checked == true)
				{
					chkTon.Checked = false;
				}

				if (chkOz.Checked == true)
				{
					chkOz.Checked = false;
				}

				if (chkG.Checked == true)
				{
					chkG.Checked = false;
				}

				if (chkTonInglesa.Checked == true)
				{
					chkTonInglesa.Checked = false;
				}

				if (grpMasaOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpMasaOut.Enabled = true;
					foreach (object Item in grpMasaOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkLbOut.Enabled = false;
				}
			}
		}

		private void chkTonInglesa_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpMasaOut.Enabled = true;



			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkTonInglesa.Checked == true)
			{
				if (chkMg.Checked == true)
				{
					chkMg.Checked = false;
				}

				if (chkKg.Checked == true)
				{
					chkKg.Checked = false;
				}

				if (chkTon.Checked == true)
				{
					chkTon.Checked = false;
				}

				if (chkOz.Checked == true)
				{
					chkOz.Checked = false;
				}

				if (chkLb.Checked == true)
				{
					chkLb.Checked = false;
				}

				if (chkG.Checked == true)
				{
					chkG.Checked = false;
				}

				if (grpMasaOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpMasaOut.Enabled = true;
					foreach (object Item in grpMasaOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkTonInglesaOut.Enabled = false;
				}
			}
		}






		//PresionIn
		private void chkPsi_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpMasaOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpPresionOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkPsi.Checked == true)
			{
				if (chkTorr.Checked == true)
				{
					chkTorr.Checked = false;
				}

				if (chkAtm.Checked == true)
				{
					chkAtm.Checked = false;
				}

				if (chkBar.Checked == true)
				{
					chkBar.Checked = false;
				}

				if (chkPa.Checked == true)
				{
					chkPa.Checked = false;
				}

				if (grpPresionOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpPresionOut.Enabled = true;
					foreach (object Item in grpPresionOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkPsiOut.Enabled = false;
				}
			}
		}

		private void chkTorr_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpMasaOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpPresionOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkTorr.Checked == true)
			{
				if (chkPsi.Checked == true)
				{
					chkPsi.Checked = false;
				}

				if (chkAtm.Checked == true)
				{
					chkAtm.Checked = false;
				}

				if (chkBar.Checked == true)
				{
					chkBar.Checked = false;
				}

				if (chkPa.Checked == true)
				{
					chkPa.Checked = false;
				}

				if (grpPresionOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpPresionOut.Enabled = true;
					foreach (object Item in grpPresionOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkTorrOut.Enabled = false;
				}
			}
		}

		private void chkAtm_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpMasaOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpPresionOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkAtm.Checked == true)
			{
				if (chkTorr.Checked == true)
				{
					chkTorr.Checked = false;
				}

				if (chkPsi.Checked == true)
				{
					chkPsi.Checked = false;
				}

				if (chkBar.Checked == true)
				{
					chkBar.Checked = false;
				}

				if (chkPa.Checked == true)
				{
					chkPa.Checked = false;
				}

				if (grpPresionOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpPresionOut.Enabled = true;
					foreach (object Item in grpPresionOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkAtmOut.Enabled = false;
				}
			}
		}

		private void chkBar_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpMasaOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpPresionOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkBar.Checked == true)
			{
				if (chkTorr.Checked == true)
				{
					chkTorr.Checked = false;
				}

				if (chkAtm.Checked == true)
				{
					chkAtm.Checked = false;
				}

				if (chkPsi.Checked == true)
				{
					chkPsi.Checked = false;
				}

				if (chkPa.Checked == true)
				{
					chkPa.Checked = false;
				}

				if (grpPresionOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpPresionOut.Enabled = true;
					foreach (object Item in grpPresionOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkBarOut.Enabled = false;
				}
			}
		}

		private void chkPa_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpMasaOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpPresionOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkPa.Checked == true)
			{
				if (chkTorr.Checked == true)
				{
					chkTorr.Checked = false;
				}

				if (chkAtm.Checked == true)
				{
					chkAtm.Checked = false;
				}

				if (chkBar.Checked == true)
				{
					chkBar.Checked = false;
				}

				if (chkPsi.Checked == true)
				{
					chkPsi.Checked = false;
				}

				if (grpPresionOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpPresionOut.Enabled = true;
					foreach (object Item in grpPresionOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkPaOut.Enabled = false;
				}
			}
		}





		//VelocidadIn
		private void chkMS_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpVelocidadOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkMS.Checked == true)
			{
				if (chkKMHR.Checked == true)
				{
					chkKMHR.Checked = false;
				}

				if (chkFTS.Checked == true)
				{
					chkFTS.Checked = false;
				}

				if (chkMIHR.Checked == true)
				{
					chkMIHR.Checked = false;
				}

				if (grpVelocidadOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpVelocidadOut.Enabled = true;
					foreach (object Item in grpVelocidadOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkMSOut.Enabled = false;
				}
			}
		}

		private void chkKMHR_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpVelocidadOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkKMHR.Checked == true)
			{
				if (chkMS.Checked == true)
				{
					chkMS.Checked = false;
				}

				if (chkFTS.Checked == true)
				{
					chkFTS.Checked = false;
				}

				if (chkMIHR.Checked == true)
				{
					chkMIHR.Checked = false;
				}

				if (grpVelocidadOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpVelocidadOut.Enabled = true;
					foreach (object Item in grpVelocidadOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkKMHROut.Enabled = false;
				}
			}
		}

		private void chkFTS_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpVelocidadOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkFTS.Checked == true)
			{
				if (chkKMHR.Checked == true)
				{
					chkKMHR.Checked = false;
				}

				if (chkMS.Checked == true)
				{
					chkMS.Checked = false;
				}

				if (chkMIHR.Checked == true)
				{
					chkMIHR.Checked = false;
				}

				if (grpVelocidadOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpVelocidadOut.Enabled = true;
					foreach (object Item in grpVelocidadOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkFTSOut.Enabled = false;
				}
			}
		}

		private void chkMIHR_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpVelocidadOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkMIHR.Checked == true)
			{
				if (chkKMHR.Checked == true)
				{
					chkKMHR.Checked = false;
				}

				if (chkFTS.Checked == true)
				{
					chkFTS.Checked = false;
				}

				if (chkMS.Checked == true)
				{
					chkMS.Checked = false;
				}

				if (grpVelocidadOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpVelocidadOut.Enabled = true;
					foreach (object Item in grpVelocidadOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkMIHROut.Enabled = false;
				}
			}
		}





		//TiempoIn
		private void chkS_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpTiempoOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkS.Checked == true)
			{
				if (chkMin.Checked == true)
				{
					chkMin.Checked = false;
				}

				if (chkHr.Checked == true)
				{
					chkHr.Checked = false;
				}

				if (chkDias.Checked == true)
				{
					chkDias.Checked = false;
				}

				if (grpTiempoOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpTiempoOut.Enabled = true;
					foreach (object Item in grpTiempoOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkSOut.Enabled = false;
				}
			}
		}

		private void chkMin_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpTiempoOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkMin.Checked == true)
			{
				if (chkS.Checked == true)
				{
					chkS.Checked = false;
				}

				if (chkHr.Checked == true)
				{
					chkHr.Checked = false;
				}

				if (chkDias.Checked == true)
				{
					chkDias.Checked = false;
				}

				if (grpTiempoOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpTiempoOut.Enabled = true;
					foreach (object Item in grpTiempoOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkMinOut.Enabled = false;
				}
			}
		}

		private void chkHr_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpTiempoOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkHr.Checked == true)
			{
				if (chkMin.Checked == true)
				{
					chkMin.Checked = false;
				}

				if (chkS.Checked == true)
				{
					chkS.Checked = false;
				}

				if (chkDias.Checked == true)
				{
					chkDias.Checked = false;
				}

				if (grpTiempoOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpTiempoOut.Enabled = true;
					foreach (object Item in grpTiempoOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkHrOut.Enabled = false;
				}
			}
		}

		private void chkDias_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpVolumenOut.Enabled = false;
			grpTiempoOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVolumen.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkDias.Checked == true)
			{
				if (chkMin.Checked == true)
				{
					chkMin.Checked = false;
				}

				if (chkHr.Checked == true)
				{
					chkHr.Checked = false;
				}

				if (chkS.Checked == true)
				{
					chkS.Checked = false;
				}

				if (grpTiempoOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpTiempoOut.Enabled = true;
					foreach (object Item in grpTiempoOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkDiasOut.Enabled = false;
				}
			}
		}






		//VolumenIn
		private void chkOzVol_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkOzVol.Checked == true)
			{
				if (chkL.Checked == true)
				{
					chkL.Checked = false;
				}

				if (chkPinta.Checked == true)
				{
					chkPinta.Checked = false;
				}

				if (chkCuarto.Checked == true)
				{
					chkCuarto.Checked = false;
				}

				if (chkMCubico.Checked == true)
				{
					chkMCubico.Checked = false;
				}

				if (chkML.Checked == true)
				{
					chkML.Checked = false;
				}

				if (chkGalon.Checked == true)
				{
					chkGalon.Checked = false;
				}

				if (grpVolumenOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpVolumenOut.Enabled = true;
					foreach (object Item in grpVolumenOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkOzVolOut.Enabled = false;
				}
			}
		}

		private void chkGalon_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkGalon.Checked == true)
			{
				if (chkL.Checked == true)
				{
					chkL.Checked = false;
				}

				if (chkPinta.Checked == true)
				{
					chkPinta.Checked = false;
				}

				if (chkCuarto.Checked == true)
				{
					chkCuarto.Checked = false;
				}

				if (chkMCubico.Checked == true)
				{
					chkMCubico.Checked = false;
				}

				if (chkOzVol.Checked == true)
				{
					chkOzVol.Checked = false;
				}

				if (chkML.Checked == true)
				{
					chkML.Checked = false;
				}

				if (grpVolumenOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpVolumenOut.Enabled = true;
					foreach (object Item in grpVolumenOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkGalonOut.Enabled = false;
				}
			}
		}

		private void chkPinta_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkPinta.Checked == true)
			{
				if (chkL.Checked == true)
				{
					chkL.Checked = false;
				}

				if (chkML.Checked == true)
				{
					chkML.Checked = false;
				}

				if (chkCuarto.Checked == true)
				{
					chkCuarto.Checked = false;
				}

				if (chkMCubico.Checked == true)
				{
					chkMCubico.Checked = false;
				}

				if (chkOzVol.Checked == true)
				{
					chkOzVol.Checked = false;
				}

				if (chkGalon.Checked == true)
				{
					chkGalon.Checked = false;
				}

				if (grpVolumenOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpVolumenOut.Enabled = true;
					foreach (object Item in grpVolumenOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkPintaOut.Enabled = false;
				}
			}
		}

		private void chkCuarto_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkCuarto.Checked == true)
			{
				if (chkL.Checked == true)
				{
					chkL.Checked = false;
				}

				if (chkPinta.Checked == true)
				{
					chkPinta.Checked = false;
				}

				if (chkML.Checked == true)
				{
					chkML.Checked = false;
				}

				if (chkMCubico.Checked == true)
				{
					chkMCubico.Checked = false;
				}

				if (chkOzVol.Checked == true)
				{
					chkOzVol.Checked = false;
				}

				if (chkGalon.Checked == true)
				{
					chkGalon.Checked = false;
				}

				if (grpVolumenOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpVolumenOut.Enabled = true;
					foreach (object Item in grpVolumenOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkCuartoOut.Enabled = false;
				}
			}
		}

		private void chkL_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkL.Checked == true)
			{
				if (chkML.Checked == true)
				{
					chkML.Checked = false;
				}

				if (chkPinta.Checked == true)
				{
					chkPinta.Checked = false;
				}

				if (chkCuarto.Checked == true)
				{
					chkCuarto.Checked = false;
				}

				if (chkMCubico.Checked == true)
				{
					chkMCubico.Checked = false;
				}

				if (chkOzVol.Checked == true)
				{
					chkOzVol.Checked = false;
				}

				if (chkGalon.Checked == true)
				{
					chkGalon.Checked = false;
				}

				if (grpVolumenOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpVolumenOut.Enabled = true;
					foreach (object Item in grpVolumenOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkLOut.Enabled = false;
				}
			}
		}

		private void chkML_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkML.Checked == true)
			{
				if (chkL.Checked == true)
				{
					chkL.Checked = false;
				}

				if (chkPinta.Checked == true)
				{
					chkPinta.Checked = false;
				}

				if (chkCuarto.Checked == true)
				{
					chkCuarto.Checked = false;
				}

				if (chkMCubico.Checked == true)
				{
					chkMCubico.Checked = false;
				}

				if (chkOzVol.Checked == true)
				{
					chkOzVol.Checked = false;
				}

				if (chkGalon.Checked == true)
				{
					chkGalon.Checked = false;
				}

				if (grpVolumenOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpVolumenOut.Enabled = true;
					foreach (object Item in grpVolumenOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkMLOut.Enabled = false;
				}
			}
		}

		private void chkMCubico_Click(object sender, EventArgs e)
		{
			// Desactivar los grp de salida no utiles
			grpLongitudOut.Enabled = false;
			grpMasaOut.Enabled = false;
			grpPresionOut.Enabled = false;
			grpVelocidadOut.Enabled = false;
			grpTiempoOut.Enabled = false;
			grpVolumenOut.Enabled = true;




			// Limpiar chks de entrada de otros grupos
			foreach (object Item in grpLongitud.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpMasa.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpPresion.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpVelocidad.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}

			foreach (object Item in grpTiempo.Controls)
			{
				if (Item is CheckBox)
				{
					chkBoxes = (CheckBox)Item;
					chkBoxes.Checked = false;
				}
			}


			// Desactivar chks del mismo grupo
			if (chkMCubico.Checked == true)
			{
				if (chkL.Checked == true)
				{
					chkL.Checked = false;
				}

				if (chkPinta.Checked == true)
				{
					chkPinta.Checked = false;
				}

				if (chkCuarto.Checked == true)
				{
					chkCuarto.Checked = false;
				}

				if (chkML.Checked == true)
				{
					chkML.Checked = false;
				}

				if (chkOzVol.Checked == true)
				{
					chkOzVol.Checked = false;
				}

				if (chkGalon.Checked == true)
				{
					chkGalon.Checked = false;
				}

				if (grpVolumenOut.Enabled == true)
				{

					// Activar grp util y desactivar la unidad de entrada en la salida
					grpVolumenOut.Enabled = true;
					foreach (object Item in grpVolumenOut.Controls)
					{
						if (Item is CheckBox)
						{
							chkBoxes = (CheckBox)Item;
							chkBoxes.Enabled = true;
						}
					}

					chkMCubicoOut.Enabled = false;
				}
			}
		}













		//CONVERTIDOR DE UNIDADES//////////////////////////////////////

		private void btnConvertir_Click(object sender, EventArgs e)
		{
			if (txtUnidades.Text.Contains("-"))
			{
				MessageBox.Show("Valor invalido");
				return;
			}
			else
			{
				dato = Conversion.Val(txtUnidades.Text);
				if (dato <= 0)
				{
					MessageBox.Show("Valor invalido");
					return;
				}
			}

			if (grpLongitudOut.Enabled == true)
			{
				if (chkMm.Checked == true)
				{
					if (chkCmOut.Checked == true)
					{
						resultado = dato / 10;
						MessageBox.Show("En Cm: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMOut.Checked == true)
					{
						resultado = dato / 1000;
						MessageBox.Show("En m: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkKmOut.Checked == true)
					{
						resultado = dato / 1000000;
						MessageBox.Show("En Km: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkInOut.Checked == true)
					{
						resultado = dato / 25.4;
						MessageBox.Show("En In: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkFtOut.Checked == true)
					{
						resultado = dato / 305;
						MessageBox.Show("En Ft: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkYdOut.Checked == true)
					{
						resultado = dato / 914;
						MessageBox.Show("En Yd: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMiOut.Checked == true)
					{
						resultado = dato / 1609000.0;
						MessageBox.Show("En Mi: " + Conversions.ToString(resultado));
						resultado = 0;
						dato = 0;
					}
				}
				else if (chkCm.Checked == true)
				{
					if (chkMmOut.Checked == true)
					{
						resultado = dato * 10;
						MessageBox.Show("En mm: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMOut.Checked == true)
					{
						resultado = dato / 100;
						MessageBox.Show("En m: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkKmOut.Checked == true)
					{
						resultado = dato / 100000;
						MessageBox.Show("En Km: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkInOut.Checked == true)
					{
						resultado = dato / 2.54;
						MessageBox.Show("En In: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkFtOut.Checked == true)
					{
						resultado = dato / 30.48;
						MessageBox.Show("En Ft: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkYdOut.Checked == true)
					{
						resultado = dato / 91.44;
						MessageBox.Show("En Yd: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMiOut.Checked == true)
					{
						resultado = dato / 160934;
						MessageBox.Show("En Mi: " + Conversions.ToString(resultado));
						resultado = 0;
						dato = 0;
					}
				}
				else if (chkM.Checked == true)
				{
					if (chkMmOut.Checked == true)
					{
						resultado = dato * 1000;
						MessageBox.Show("En mm: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkCmOut.Checked == true)
					{
						resultado = dato * 100;
						MessageBox.Show("En cm: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkKmOut.Checked == true)
					{
						resultado = dato / 1000;
						MessageBox.Show("En Km: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkInOut.Checked == true)
					{
						resultado = dato * 39.37;
						MessageBox.Show("En In: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkFtOut.Checked == true)
					{
						resultado = dato * 3.281;
						MessageBox.Show("En Ft: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkYdOut.Checked == true)
					{
						resultado = dato * 1.094;
						MessageBox.Show("En Yd: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMiOut.Checked == true)
					{
						resultado = dato / 1609;
						MessageBox.Show("En Mi: " + Conversions.ToString(resultado));
						resultado = 0;
						dato = 0;
					}
				}
				else if (chkKm.Checked == true)
				{
					if (chkMmOut.Checked == true)
					{
						resultado = dato * 1000000.0;
						MessageBox.Show("En mm: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkCmOut.Checked == true)
					{
						resultado = dato * 100000;
						MessageBox.Show("En cm: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMOut.Checked == true)
					{
						resultado = dato * 1000;
						MessageBox.Show("En m: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkInOut.Checked == true)
					{
						resultado = dato * 39370;
						MessageBox.Show("En In: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkFtOut.Checked == true)
					{
						resultado = dato * 3281;
						MessageBox.Show("En Ft: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkYdOut.Checked == true)
					{
						resultado = dato * 1094;
						MessageBox.Show("En Yd: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMiOut.Checked == true)
					{
						resultado = dato / 1.609;
						MessageBox.Show("En Mi: " + Conversions.ToString(resultado));
						resultado = 0;
						dato = 0;
					}
				}
				else if (chkIn.Checked == true)
				{
					if (chkMmOut.Checked == true)
					{
						resultado = dato * 25.4;
						MessageBox.Show("En mm: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkCmOut.Checked == true)
					{
						resultado = dato * 2.54;
						MessageBox.Show("En cm: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMOut.Checked == true)
					{
						resultado = dato / 39.37;
						MessageBox.Show("En m: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkKmOut.Checked == true)
					{
						resultado = dato / 39370;
						MessageBox.Show("En Km: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkFtOut.Checked == true)
					{
						resultado = dato / 12;
						MessageBox.Show("En Ft: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkYdOut.Checked == true)
					{
						resultado = dato / 36;
						MessageBox.Show("En Yd: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMiOut.Checked == true)
					{
						resultado = dato / 63360;
						MessageBox.Show("En Mi: " + Conversions.ToString(resultado));
						resultado = 0;
						dato = 0;
					}
				}
				else if (chkFt.Checked == true)
				{
					if (chkMmOut.Checked == true)
					{
						resultado = dato * 305;
						MessageBox.Show("En mm: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkCmOut.Checked == true)
					{
						resultado = dato * 30.48;
						MessageBox.Show("En cm: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMOut.Checked == true)
					{
						resultado = dato / 3.281;
						MessageBox.Show("En m: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkKmOut.Checked == true)
					{
						resultado = dato / 3281;
						MessageBox.Show("En Km: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkInOut.Checked == true)
					{
						resultado = dato * 12;
						MessageBox.Show("En In: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkYdOut.Checked == true)
					{
						resultado = dato / 3;
						MessageBox.Show("En Yd: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMiOut.Checked == true)
					{
						resultado = dato / 5280;
						MessageBox.Show("En Mi: " + Conversions.ToString(resultado));
						resultado = 0;
						dato = 0;
					}
				}
				else if (chkYd.Checked == true)
				{
					if (chkMmOut.Checked == true)
					{
						resultado = dato * 914;
						MessageBox.Show("En mm: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkCmOut.Checked == true)
					{
						resultado = dato * 91.44;
						MessageBox.Show("En cm: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMOut.Checked == true)
					{
						resultado = dato / 1.094;
						MessageBox.Show("En m: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkKmOut.Checked == true)
					{
						resultado = dato / 1094;
						MessageBox.Show("En Km: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkInOut.Checked == true)
					{
						resultado = dato * 36;
						MessageBox.Show("En In: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkFtOut.Checked == true)
					{
						resultado = dato * 3;
						MessageBox.Show("En Ft: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMiOut.Checked == true)
					{
						resultado = dato / 1760;
						MessageBox.Show("En Mi: " + Conversions.ToString(resultado));
						resultado = 0;
						dato = 0;
					}
				}
				else if (chkMi.Checked == true)
				{
					if (chkMmOut.Checked == true)
					{
						resultado = dato * 1609000.0;
						MessageBox.Show("En mm: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkCmOut.Checked == true)
					{
						resultado = dato * 160934;
						MessageBox.Show("En cm: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMOut.Checked == true)
					{
						resultado = dato * 1609;
						MessageBox.Show("En m: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkKmOut.Checked == true)
					{
						resultado = dato * 1.609;
						MessageBox.Show("En Km: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkInOut.Checked == true)
					{
						resultado = dato * 63360;
						MessageBox.Show("En In: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkFtOut.Checked == true)
					{
						resultado = dato * 5280;
						MessageBox.Show("En Ft: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkYdOut.Checked == true)
					{
						resultado = dato * 1760;
						MessageBox.Show("En Yd: " + Conversions.ToString(resultado));
						resultado = 0;
						dato = 0;
					}
				}
			}
			else if (grpMasaOut.Enabled == true)
			{
				if (chkMg.Checked == true)
				{
					if (chkGOut.Checked == true)
					{
						resultado = dato / 1000;
						MessageBox.Show("En g: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkKgOut.Checked == true)
					{
						resultado = dato / 1000000.0;
						MessageBox.Show("En kg: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkTonOut.Checked == true)
					{
						resultado = dato / 1000000000.0;
						MessageBox.Show("En Ton: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkOzOut.Checked == true)
					{
						resultado = dato / 28350;
						MessageBox.Show("En Oz: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkLbOut.Checked == true)
					{
						resultado = dato / 453592;
						MessageBox.Show("En Lb: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkTonInglesaOut.Checked == true)
					{
						resultado = dato / 907200000.0;
						MessageBox.Show("En Tonelada Corta: " + Conversions.ToString(resultado));
						resultado = 0;
						dato = 0;
					}
				}
				else if (chkG.Checked == true)
				{
					if (chkMgOut.Checked == true)
					{
						resultado = dato * 1000;
						MessageBox.Show("En mg: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkKgOut.Checked == true)
					{
						resultado = dato / 1000;
						MessageBox.Show("En kg: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkTonOut.Checked == true)
					{
						resultado = dato / 1000000.0;
						MessageBox.Show("En Ton: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkOzOut.Checked == true)
					{
						resultado = dato / 28.35;
						MessageBox.Show("En Oz: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkLbOut.Checked == true)
					{
						resultado = dato / 454;
						MessageBox.Show("En Lb: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkTonInglesaOut.Checked == true)
					{
						resultado = dato / 907185;
						MessageBox.Show("En Tonelada Corta: " + Conversions.ToString(resultado));
						resultado = 0;
						dato = 0;
					}
				}
				else if (chkKg.Checked == true)
				{
					if (chkMgOut.Checked == true)
					{
						resultado = dato * 1000000.0;
						MessageBox.Show("En mg: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkGOut.Checked == true)
					{
						resultado = dato * 1000;
						MessageBox.Show("En g: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkTonOut.Checked == true)
					{
						resultado = dato / 1000;
						MessageBox.Show("En Ton: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkOzOut.Checked == true)
					{
						resultado = dato * 35.274;
						MessageBox.Show("En Oz: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkLbOut.Checked == true)
					{
						resultado = dato * 2.205;
						MessageBox.Show("En Lb: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkTonInglesaOut.Checked == true)
					{
						resultado = dato / 907;
						MessageBox.Show("En Tonelada Corta: " + Conversions.ToString(resultado));
						resultado = 0;
						dato = 0;
					}
				}
				else if (chkTon.Checked == true)
				{
					if (chkMgOut.Checked == true)
					{
						resultado = dato * 1000000000.0;
						MessageBox.Show("En mg: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkGOut.Checked == true)
					{
						resultado = dato * 1000000.0;
						MessageBox.Show("En g: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkKgOut.Checked == true)
					{
						resultado = dato * 1000;
						MessageBox.Show("En kg: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkOzOut.Checked == true)
					{
						resultado = dato * 35274;
						MessageBox.Show("En Oz: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkLbOut.Checked == true)
					{
						resultado = dato * 2205;
						MessageBox.Show("En Lb: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkTonInglesaOut.Checked == true)
					{
						resultado = dato * 1.102;
						MessageBox.Show("En Tonelada Corta: " + Conversions.ToString(resultado));
						resultado = 0;
						dato = 0;
					}
				}
				else if (chkOz.Checked == true)
				{
					if (chkMgOut.Checked == true)
					{
						resultado = dato * 28350;
						MessageBox.Show("En mg: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkGOut.Checked == true)
					{
						resultado = dato * 28.35;
						MessageBox.Show("En g: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkKgOut.Checked == true)
					{
						resultado = dato / 35.274;
						MessageBox.Show("En kg: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkTonOut.Checked == true)
					{
						resultado = dato / 35274;
						MessageBox.Show("En Ton: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkLbOut.Checked == true)
					{
						resultado = dato / 16;
						MessageBox.Show("En Lb: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkTonInglesaOut.Checked == true)
					{
						resultado = dato / 32000;
						MessageBox.Show("En Tonelada Corta: " + Conversions.ToString(resultado));
						resultado = 0;
						dato = 0;
					}
				}
				else if (chkLb.Checked == true)
				{
					if (chkMgOut.Checked == true)
					{
						resultado = dato * 453592;
						MessageBox.Show("En mg: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkGOut.Checked == true)
					{
						resultado = dato * 454;
						MessageBox.Show("En g: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkKgOut.Checked == true)
					{
						resultado = dato / 2.205;
						MessageBox.Show("En kg: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkTonOut.Checked == true)
					{
						resultado = dato / 2205;
						MessageBox.Show("En Ton: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkOzOut.Checked == true)
					{
						resultado = dato * 16;
						MessageBox.Show("En Oz: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkTonInglesaOut.Checked == true)
					{
						resultado = dato / 2000;
						MessageBox.Show("En Tonelada Corta: " + Conversions.ToString(resultado));
						resultado = 0;
						dato = 0;
					}
				}
				else if (chkTonInglesa.Checked == true)
				{
					if (chkMgOut.Checked == true)
					{
						resultado = dato * 907200000.0;
						MessageBox.Show("En mg: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkGOut.Checked == true)
					{
						resultado = dato * 907185;
						MessageBox.Show("En g: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkKgOut.Checked == true)
					{
						resultado = dato * 907;
						MessageBox.Show("En kg: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkTonOut.Checked == true)
					{
						resultado = dato / 1.102;
						MessageBox.Show("En Ton: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkOzOut.Checked == true)
					{
						resultado = dato * 32000;
						MessageBox.Show("En Oz: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkLbOut.Checked == true)
					{
						resultado = dato * 2000;
						MessageBox.Show("En Lb: " + Conversions.ToString(resultado));
						resultado = 0;
						dato = 0;
					}
				}
			}
			else if (grpPresionOut.Enabled == true)
			{
				if (chkPsi.Checked == true)
				{
					if (chkTorrOut.Checked == true)
					{
						resultado = dato * 51.715;
						MessageBox.Show("En Torr: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkAtmOut.Checked == true)
					{
						resultado = dato / 14.696;
						MessageBox.Show("En Atm: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkBarOut.Checked == true)
					{
						resultado = dato / 14.504;
						MessageBox.Show("En Bar: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkPaOut.Checked == true)
					{
						resultado = dato * 6895;
						MessageBox.Show("En Pa: " + Conversions.ToString(resultado));
						resultado = 0;
					}
				}
				else if (chkTorr.Checked == true)
				{
					if (chkPsiOut.Checked == true)
					{
						resultado = dato / 51.715;
						MessageBox.Show("En Psi: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkAtmOut.Checked == true)
					{
						resultado = dato / 760;
						MessageBox.Show("En Atm: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkBarOut.Checked == true)
					{
						resultado = dato / 750;
						MessageBox.Show("En Bar: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkPaOut.Checked == true)
					{
						resultado = dato * 133;
						MessageBox.Show("En Pa: " + Conversions.ToString(resultado));
						resultado = 0;
					}
				}
				else if (chkAtm.Checked == true)
				{
					if (chkPsiOut.Checked == true)
					{
						resultado = dato * 14.696;
						MessageBox.Show("En Psi: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkTorrOut.Checked == true)
					{
						resultado = dato * 760;
						MessageBox.Show("En Torr: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkBarOut.Checked == true)
					{
						resultado = dato * 1.013;
						MessageBox.Show("En Bar: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkPaOut.Checked == true)
					{
						resultado = dato * 101325;
						MessageBox.Show("En Pa: " + Conversions.ToString(resultado));
						resultado = 0;
					}
				}
				else if (chkBar.Checked == true)
				{
					if (chkPsiOut.Checked == true)
					{
						resultado = dato * 14.696;
						MessageBox.Show("En Psi: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkTorrOut.Checked == true)
					{
						resultado = dato * 750;
						MessageBox.Show("En Torr: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkAtmOut.Checked == true)
					{
						resultado = dato / 1.013;
						MessageBox.Show("En Atm: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkPaOut.Checked == true)
					{
						resultado = dato * 100000;
						MessageBox.Show("En Pa: " + Conversions.ToString(resultado));
						resultado = 0;
					}
				}
				else if (chkPa.Checked == true)
				{
					if (chkPsiOut.Checked == true)
					{
						resultado = dato / 6895;
						MessageBox.Show("En Psi: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkTorrOut.Checked == true)
					{
						resultado = dato / 133;
						MessageBox.Show("En Torr: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkAtmOut.Checked == true)
					{
						resultado = dato / 101325;
						MessageBox.Show("En Atm: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkBarOut.Checked == true)
					{
						resultado = dato / 100000;
						MessageBox.Show("En Bar: " + Conversions.ToString(resultado));
						resultado = 0;
					}
				}
			}
			else if (grpVelocidadOut.Enabled == true)
			{
				if (chkMS.Checked == true)
				{
					if (chkKMHROut.Checked == true)
					{
						resultado = dato * 3.6;
						MessageBox.Show("En Km/Hr: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkFTSOut.Checked == true)
					{
						resultado = dato * 3.281;
						MessageBox.Show("En Ft/s: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMIHROut.Checked == true)
					{
						resultado = dato * 2.237;
						MessageBox.Show("En Mi/Hr: " + Conversions.ToString(resultado));
						resultado = 0;
					}
				}
				else if (chkKMHR.Checked == true)
				{
					if (chkMSOut.Checked == true)
					{
						resultado = dato / 3.6;
						MessageBox.Show("En m/s: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkFTSOut.Checked == true)
					{
						resultado = dato / 1.097;
						MessageBox.Show("En Ft/s: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMIHROut.Checked == true)
					{
						resultado = dato / 1.609;
						MessageBox.Show("En Mi/Hr: " + Conversions.ToString(resultado));
						resultado = 0;
					}
				}
				else if (chkFTS.Checked == true)
				{
					if (chkMSOut.Checked == true)
					{
						resultado = dato / 3.281;
						MessageBox.Show("En m/s: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkKMHROut.Checked == true)
					{
						resultado = dato * 1.097;
						MessageBox.Show("En km/Hr: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMIHROut.Checked == true)
					{
						resultado = dato / 1.467;
						MessageBox.Show("En Mi/Hr: " + Conversions.ToString(resultado));
						resultado = 0;
					}
				}
				else if (chkMIHR.Checked == true)
				{
					if (chkMSOut.Checked == true)
					{
						resultado = dato / 2.237;
						MessageBox.Show("En m/s: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkKMHROut.Checked == true)
					{
						resultado = dato * 1.609;
						MessageBox.Show("En km/Hr: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkFTSOut.Checked == true)
					{
						resultado = dato * 1.467;
						MessageBox.Show("En Ft/s: " + Conversions.ToString(resultado));
						resultado = 0;
					}
				}
			}
			else if (grpTiempoOut.Enabled == true)
			{
				if (chkS.Checked == true)
				{
					if (chkMinOut.Checked == true)
					{
						resultado = dato / 60;
						MessageBox.Show("En minutos: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkHrOut.Checked == true)
					{
						resultado = dato / 3600;
						MessageBox.Show("En horas: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkDiasOut.Checked == true)
					{
						resultado = dato / 86400;
						MessageBox.Show("En dias: " + Conversions.ToString(resultado));
						resultado = 0;
					}
				}
				else if (chkMin.Checked == true)
				{
					if (chkSOut.Checked == true)
					{
						resultado = dato * 60;
						MessageBox.Show("En segundos: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkHrOut.Checked == true)
					{
						resultado = dato / 60;
						MessageBox.Show("En horas: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkDiasOut.Checked == true)
					{
						resultado = dato / 1440;
						MessageBox.Show("En dias: " + Conversions.ToString(resultado));
						resultado = 0;
					}
				}
				else if (chkHr.Checked == true)
				{
					if (chkSOut.Checked == true)
					{
						resultado = dato * 3600;
						MessageBox.Show("En segundos: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMinOut.Checked == true)
					{
						resultado = dato * 60;
						MessageBox.Show("En minutos: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkDiasOut.Checked == true)
					{
						resultado = dato / 24;
						MessageBox.Show("En dias: " + Conversions.ToString(resultado));
						resultado = 0;
					}
				}
				else if (chkDias.Checked == true)
				{
					if (chkSOut.Checked == true)
					{
						resultado = dato * 86400;
						MessageBox.Show("En segundos: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMinOut.Checked == true)
					{
						resultado = dato * 1440;
						MessageBox.Show("En minutos: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkHrOut.Checked == true)
					{
						resultado = dato * 24;
						MessageBox.Show("En Horas: " + Conversions.ToString(resultado));
						resultado = 0;
					}
				}
			}
			else if (grpVolumenOut.Enabled == true)
			{
				if (chkML.Checked == true)
				{
					if (chkLOut.Checked == true)
					{
						resultado = dato / 1000;
						MessageBox.Show("En Litros: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkPintaOut.Checked == true)
					{
						resultado = dato / 568;
						MessageBox.Show("En Pinta Imperial: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkCuartoOut.Checked == true)
					{
						resultado = dato / 1137;
						MessageBox.Show("En Cuarto Imperial: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMCubicoOut.Checked == true)
					{
						resultado = dato / 1000000.0;
						MessageBox.Show("En metros cubicos: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkOzVolOut.Checked == true)
					{
						resultado = dato / 28.413;
						MessageBox.Show("En Onza liquida imperial: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkGalonOut.Checked == true)
					{
						resultado = dato / 4546;
						MessageBox.Show("En galones imperiales: " + Conversions.ToString(resultado));
						resultado = 0;
					}
				}
				else if (chkL.Checked == true)
				{
					if (chkMLOut.Checked == true)
					{
						resultado = dato * 1000;
						MessageBox.Show("En mililitros: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkPintaOut.Checked == true)
					{
						resultado = dato * 1.76;
						MessageBox.Show("En Pinta Imperial: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkCuartoOut.Checked == true)
					{
						resultado = dato / 1.137;
						MessageBox.Show("En Cuarto Imperial: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMCubicoOut.Checked == true)
					{
						resultado = dato / 1000;
						MessageBox.Show("En metros cubicos: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkOzVolOut.Checked == true)
					{
						resultado = dato * 35.195;
						MessageBox.Show("En Onza liquida imperial: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkGalonOut.Checked == true)
					{
						resultado = dato / 4.546;
						MessageBox.Show("En galones imperiales: " + Conversions.ToString(resultado));
						resultado = 0;
					}
				}
				else if (chkPinta.Checked == true)
				{
					if (chkMLOut.Checked == true)
					{
						resultado = dato * 568;
						MessageBox.Show("En mililitros: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkLOut.Checked == true)
					{
						resultado = dato / 1.76;
						MessageBox.Show("En Litros: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkCuartoOut.Checked == true)
					{
						resultado = dato / 2;
						MessageBox.Show("En Cuarto Imperial: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMCubicoOut.Checked == true)
					{
						resultado = dato / 1760;
						MessageBox.Show("En metros cubicos: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkOzVolOut.Checked == true)
					{
						resultado = dato * 20;
						MessageBox.Show("En Onza liquida imperial: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkGalonOut.Checked == true)
					{
						resultado = dato / 8;
						MessageBox.Show("En galones imperiales: " + Conversions.ToString(resultado));
						resultado = 0;
					}
				}
				else if (chkCuarto.Checked == true)
				{
					if (chkMLOut.Checked == true)
					{
						resultado = dato * 1137;
						MessageBox.Show("En mililitros: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkLOut.Checked == true)
					{
						resultado = dato * 1.137;
						MessageBox.Show("En Litros: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkPintaOut.Checked == true)
					{
						resultado = dato * 2;
						MessageBox.Show("En Pinta Imperial: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMCubicoOut.Checked == true)
					{
						resultado = dato / 880;
						MessageBox.Show("En metros cubicos: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkOzVolOut.Checked == true)
					{
						resultado = dato * 40;
						MessageBox.Show("En Onza liquida imperial: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkGalonOut.Checked == true)
					{
						resultado = dato / 4;
						MessageBox.Show("En galones imperiales: " + Conversions.ToString(resultado));
						resultado = 0;
					}
				}
				else if (chkMCubico.Checked == true)
				{
					if (chkMLOut.Checked == true)
					{
						resultado = dato * 1000000.0;
						MessageBox.Show("En mililitros: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkLOut.Checked == true)
					{
						resultado = dato * 1000;
						MessageBox.Show("En Litros: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkPintaOut.Checked == true)
					{
						resultado = dato * 1760;
						MessageBox.Show("En Pinta Imperial: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkCuartoOut.Checked == true)
					{
						resultado = dato * 880;
						MessageBox.Show("En cuarto imperial: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkOzVolOut.Checked == true)
					{
						resultado = dato * 35195;
						MessageBox.Show("En Onza liquida imperial: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkGalonOut.Checked == true)
					{
						resultado = dato * 220;
						MessageBox.Show("En galones imperiales: " + Conversions.ToString(resultado));
						resultado = 0;
					}
				}
				else if (chkOzVol.Checked == true)
				{
					if (chkMLOut.Checked == true)
					{
						resultado = dato * 28.413;
						MessageBox.Show("En mililitros: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkLOut.Checked == true)
					{
						resultado = dato * 35.195;
						MessageBox.Show("En Litros: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkPintaOut.Checked == true)
					{
						resultado = dato / 20;
						MessageBox.Show("En Pinta Imperial: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkCuartoOut.Checked == true)
					{
						resultado = dato / 40;
						MessageBox.Show("En cuarto imperial: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMCubicoOut.Checked == true)
					{
						resultado = dato / 35195;
						MessageBox.Show("En metros cubicos: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkGalonOut.Checked == true)
					{
						resultado = dato / 160;
						MessageBox.Show("En galones imperiales: " + Conversions.ToString(resultado));
						resultado = 0;
					}
				}
				else if (chkGalon.Checked == true)
				{
					if (chkMLOut.Checked == true)
					{
						resultado = dato * 4546;
						MessageBox.Show("En mililitros: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkLOut.Checked == true)
					{
						resultado = dato * 4.546;
						MessageBox.Show("En Litros: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkPintaOut.Checked == true)
					{
						resultado = dato * 8;
						MessageBox.Show("En Pinta Imperial: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkCuartoOut.Checked == true)
					{
						resultado = dato / 4;
						MessageBox.Show("En cuarto imperial: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkMCubicoOut.Checked == true)
					{
						resultado = dato / 220;
						MessageBox.Show("En metros cubicos: " + Conversions.ToString(resultado));
						resultado = 0;
					}

					if (chkOzVolOut.Checked == true)
					{
						resultado = dato * 160;
						MessageBox.Show("En onzas imperiales: " + Conversions.ToString(resultado));
						resultado = 0;
					}
				}
			}
		}

	}
}
