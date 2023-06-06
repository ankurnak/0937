using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l16
{
    public partial class Form1 : Form
    {
        private const int ArrayLength = 5;
        private string[] stringArray;
        public Form1()
        {
            InitializeComponent();
            InitializeStringArray();
        }
        private void InitializeStringArray()
        {
            stringArray = new string[ArrayLength];
            for (int i = 0; i < ArrayLength; i++)
            {
                stringArray[i] = string.Empty;
            }
        }

        private void UpdateArrayLabel()
        {
            arrayLabel.Text = string.Join(", ", stringArray);
        }

        private void CheckIndex(int index)
        {
            if (index < 0 || index >= ArrayLength)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
        }

        private void SetStringAtIndex(int index, string value)
        {
            CheckIndex(index);
            stringArray[index] = value;
        }

        private string GetStringAtIndex(int index)
        {
            CheckIndex(index);
            return stringArray[index];
        }

        private string[] ConcatenateArrays(string[] array1, string[] array2)
        {
            return array1.Concat(array2).ToArray();
        }

        private string[] MergeArrays(string[] array1, string[] array2)
        {
            return array1.Union(array2).ToArray();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(indexTextBox.Text);
                string value = valueTextBox.Text;
                SetStringAtIndex(index, value);
                UpdateArrayLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(indexTextBox.Text);
                string value = GetStringAtIndex(index);
                MessageBox.Show(value, "Value at Index");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string[] secondArray = new string[ArrayLength];
                for (int i = 0; i < ArrayLength; i++)
                {
                    secondArray[i] = string.Empty;
                }

                string[] resultArray = ConcatenateArrays(stringArray, secondArray);
                MessageBox.Show(string.Join(", ", resultArray), "Concatenated Array");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string[] secondArray = new string[ArrayLength];
                for (int i = 0; i < ArrayLength; i++)
                {
                    secondArray[i] = string.Empty;
                }

                string[] resultArray = MergeArrays(stringArray, secondArray);
                MessageBox.Show(string.Join(", ", resultArray), "Merged Array");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
