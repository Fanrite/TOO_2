using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace TOO_2
{
    class Aircraft
    {
        private string TypeMachine { get; set; }
        private int Weight { get; set; }
        private int AmountEngine { get; set; }

        public Aircraft ()
        {
            this.TypeMachine = Interaction.InputBox("Введіть тип літака", "Введення");
            this.Weight = Convert.ToInt32(Interaction.InputBox("Введіть массу літака", "Введення"));
            this.AmountEngine = Convert.ToInt32(Interaction.InputBox("Введіть кількість двигунів літака", "Введення"));
        }

        public Aircraft (string TypeMachine, int Weight, int AmountEngine)
        {
            this.TypeMachine = TypeMachine;
            this.Weight = Weight;
            this.AmountEngine = AmountEngine;
        }

        private string GetWeight ()
        {
            if (Weight <= 7) return "Легкий";
            else if (Weight <= 136) return "Середній";
            else return "Важкий";
        }

        private string GetEngie ()
        {
            return $"{AmountEngine}-Двигунний";
        }

        public void ShowInfo ()
        {
            MessageBox.Show($"Данні літака:\nТип: {TypeMachine}\nВага: {Weight} ({GetWeight()})\nДвигун: {GetEngie()}", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
