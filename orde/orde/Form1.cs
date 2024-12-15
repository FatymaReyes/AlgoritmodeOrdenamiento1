using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orde
{
    public partial class Form1 : Form
    {
        Metodo_ordenamiento metodo_Ordenamiento;
        public Form1()
        {
            InitializeComponent();
            metodo_Ordenamiento = new Metodo_ordenamiento();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSeleccion_Click_1(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = metodo_Ordenamiento.ParseNumbers(TextBox1.Text);
                numbers = metodo_Ordenamiento.SelectionSort(numbers);
                TextBox1.Text = metodo_Ordenamiento.DisplayNumbers(numbers);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBurbuja_Click(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = metodo_Ordenamiento.ParseNumbers(TextBox1.Text);
                numbers = metodo_Ordenamiento.BubbleSort(numbers);
                TextBox1.Text = metodo_Ordenamiento.DisplayNumbers(numbers);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnInsercion_Click(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = metodo_Ordenamiento.ParseNumbers(TextBox1.Text);
                numbers = metodo_Ordenamiento.InsertionSort(numbers);
                TextBox1.Text = metodo_Ordenamiento.DisplayNumbers(numbers);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCombinacion_Click(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = metodo_Ordenamiento.ParseNumbers(TextBox1.Text);
                numbers = metodo_Ordenamiento.MergeSort(numbers);
                TextBox1.Text = metodo_Ordenamiento.DisplayNumbers(numbers);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnRapida_Click(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = metodo_Ordenamiento.ParseNumbers(TextBox1.Text);
                numbers = metodo_Ordenamiento.QuickSort(numbers);
                TextBox1.Text = metodo_Ordenamiento.DisplayNumbers(numbers);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void BtnMonton_Click(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = metodo_Ordenamiento.ParseNumbers(TextBox1.Text);
                numbers = metodo_Ordenamiento.HeapSort(numbers);
                TextBox1.Text = metodo_Ordenamiento.DisplayNumbers(numbers);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBinaria_Click(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = metodo_Ordenamiento.ParseNumbers(TextBox1.Text);
                numbers = metodo_Ordenamiento.HeapSort(numbers);
                TextBox1.Text = metodo_Ordenamiento.DisplayNumbers(numbers);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLineal_Click(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = metodo_Ordenamiento.ParseNumbers(TextBox1.Text);
                numbers = metodo_Ordenamiento.HeapSort(numbers);
                TextBox1.Text = metodo_Ordenamiento.DisplayNumbers(numbers);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
