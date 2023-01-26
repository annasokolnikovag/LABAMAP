using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sokolnikova1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Checkpoint1_Click(object sender, EventArgs e)
        {
            name.Text = "МЦК Лужники";
            pictureBoxToilets.Visible = false; Toilets.Visible = false;
            pictureBoxDrinks.Visible = true; Drinks.Visible = true;
            pictureBoxEnergyBars.Visible = true;EnergyBars.Visible = true;
            pictureBoxInformation.Visible = false; Information.Visible = false;
            pictureBoxMedical.Visible = false; Medical.Visible = false;
            run1.Visible = false;
            //перемещение 
            pictureBoxEnergyBars.Location = new Point(675, 75);
            EnergyBars.Location = new Point(788, 99);
            pictureBoxDrinks.Location = new Point(675, 171);
            Drinks.Location = new Point(788, 194);
        }

        private void Checkpoint2_Click(object sender, EventArgs e)
        {
            name.Text = "Новодевичей монастырь";
            pictureBoxToilets.Visible = true; Toilets.Visible = true;
            pictureBoxDrinks.Visible = true; Drinks.Visible = true;
            pictureBoxEnergyBars.Visible = true; EnergyBars.Visible = true;
            pictureBoxInformation.Visible = true; Information.Visible = true;
            pictureBoxMedical.Visible = true; Medical.Visible = true;
            run1.Visible = false;
            //обратно перемещаем
            pictureBoxInformation.Location = new Point(675, 267);
            Information.Location = new Point(788, 289);
            pictureBoxMedical.Location = new Point(675, 171);
            Medical.Location = new Point(788, 194);
            pictureBoxEnergyBars.Location = new Point(675,363);
            EnergyBars.Location = new Point(788, 388);
            pictureBoxDrinks.Location = new Point(675, 459);
            Drinks.Location = new Point(788, 483);
        }

        private void Checkpoint3_Click(object sender, EventArgs e)
        {
            name.Text = "Метро Киевская";
            pictureBoxToilets.Visible = true; Toilets.Visible = true;
            pictureBoxDrinks.Visible = true; Drinks.Visible = true;
            pictureBoxEnergyBars.Visible = true; EnergyBars.Visible = true;
            pictureBoxInformation.Visible = false; Information.Visible = false;
            pictureBoxMedical.Visible = false; Medical.Visible = false;
            run1.Visible = false;
            //перемещение
            pictureBoxEnergyBars.Location = new Point(675, 171);
            EnergyBars.Location = new Point(788, 194);
            pictureBoxDrinks.Location = new Point(675, 267);
            Drinks.Location = new Point(788, 289);
        }

        private void Checkpoint4_Click(object sender, EventArgs e)
        {
            name.Text = "МИД";
            pictureBoxToilets.Visible = true; Toilets.Visible = true;
            pictureBoxDrinks.Visible = true; Drinks.Visible = true;
            pictureBoxEnergyBars.Visible = true; EnergyBars.Visible = true;
            pictureBoxInformation.Visible = false; Information.Visible = false;
            pictureBoxMedical.Visible = true; Medical.Visible = true;
            run1.Visible = false;
            //перемещение
            pictureBoxEnergyBars.Location = new Point(675, 267);
            EnergyBars.Location = new Point(788, 289);
            pictureBoxDrinks.Location = new Point(675, 363);
            Drinks.Location = new Point(788, 388);
        }

        private void Checkpoint5_Click(object sender, EventArgs e)
        {
            name.Text = "Парк Горького";
            pictureBoxToilets.Visible = true; Toilets.Visible = true;
            pictureBoxDrinks.Visible = true; Drinks.Visible = true;
            pictureBoxEnergyBars.Visible = true; EnergyBars.Visible = true;
            pictureBoxInformation.Visible = true; Information.Visible = true;
            pictureBoxMedical.Visible = false; Medical.Visible = false;
            run1.Visible = false;
            //перемещение
            pictureBoxInformation.Location = new Point(675, 171);
            Information.Location = new Point(788, 194);
            pictureBoxEnergyBars.Location = new Point(675, 267);
            EnergyBars.Location = new Point(788, 289);
            pictureBoxDrinks.Location = new Point(675, 363);
            Drinks.Location = new Point(788, 388);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            name.Text = "Здания РАН";
            pictureBoxToilets.Visible = true; Toilets.Visible = true;
            pictureBoxDrinks.Visible = true; Drinks.Visible = true;
            pictureBoxEnergyBars.Visible = true; EnergyBars.Visible = true;
            pictureBoxInformation.Visible = false; Information.Visible = false;
            pictureBoxMedical.Visible = false; Medical.Visible = false;
            run1.Visible = false;
            //перемещение
            pictureBoxEnergyBars.Location = new Point(675, 171);
            EnergyBars.Location = new Point(788, 194);
            pictureBoxDrinks.Location = new Point(675, 267);
            Drinks.Location = new Point(788, 289);
        }

        private void Checkpoint7_Click(object sender, EventArgs e)
        {
            name.Text = "Метро Воробевы горы";
            pictureBoxToilets.Visible = true; Toilets.Visible = true;
            pictureBoxDrinks.Visible = true; Drinks.Visible = true;
            pictureBoxEnergyBars.Visible = true; EnergyBars.Visible = true;
            pictureBoxInformation.Visible = true; Information.Visible = true;
            pictureBoxMedical.Visible = true; Medical.Visible = true;
            run1.Visible = false;
            //обратно
            pictureBoxInformation.Location = new Point(675, 267);
            Information.Location = new Point(788, 289);
            pictureBoxEnergyBars.Location = new Point(675, 363);
            EnergyBars.Location = new Point(788, 388);
            pictureBoxDrinks.Location = new Point(675, 459);
            Drinks.Location = new Point(788, 483);
        }

        private void Checkpoint8_Click(object sender, EventArgs e)
        {
            name.Text = "Стадион Лужники";
            pictureBoxToilets.Visible = true; Toilets.Visible = true;
            pictureBoxDrinks.Visible = true; Drinks.Visible = true;
            pictureBoxEnergyBars.Visible = true; EnergyBars.Visible = true;
            pictureBoxInformation.Visible = true; Information.Visible = true;
            pictureBoxMedical.Visible = true; Medical.Visible = true;
            run1.Visible = false;

            pictureBoxInformation.Location = new Point(675, 267);
            Information.Location = new Point(788, 289);
            pictureBoxEnergyBars.Location = new Point(675, 363);
            EnergyBars.Location = new Point(788, 388);
            pictureBoxDrinks.Location = new Point(675, 459);
            Drinks.Location = new Point(788, 483);
        }

        private void labelfinish_Click(object sender, EventArgs e)
        {
            name.Text = "ФИНИШ";
            run1.Visible = false;
            pictureBoxToilets.Visible = false; Toilets.Visible = false;
            pictureBoxDrinks.Visible = false; Drinks.Visible = false;
            pictureBoxEnergyBars.Visible = false; EnergyBars.Visible = false;
            pictureBoxInformation.Visible = false; Information.Visible = false;
            pictureBoxMedical.Visible = false; Medical.Visible = false;
            
        }

        private void start1_Click(object sender, EventArgs e)
        {
            name.Text = "Первый старт";
            run1.Visible = true;
            run1.Text = "Полный марафон 40 км";
            pictureBoxToilets.Visible = false; Toilets.Visible = false;
            pictureBoxDrinks.Visible = false; Drinks.Visible = false;
            pictureBoxEnergyBars.Visible = false; EnergyBars.Visible = false;
            pictureBoxInformation.Visible = false; Information.Visible = false;
            pictureBoxMedical.Visible = false; Medical.Visible = false;
        }

        private void start2_Click(object sender, EventArgs e)
        {
            name.Text = "Второй старт";
            run1.Visible = true;
            run1.Text = "Половинный марафон 20 км";
            pictureBoxToilets.Visible = false; Toilets.Visible = false;
            pictureBoxDrinks.Visible = false; Drinks.Visible = false;
            pictureBoxEnergyBars.Visible = false; EnergyBars.Visible = false;
            pictureBoxInformation.Visible = false; Information.Visible = false;
            pictureBoxMedical.Visible = false; Medical.Visible = false;
        }

        private void start3_Click(object sender, EventArgs e)
        {
            name.Text = "Третий старт";
            run1.Visible = true;
            run1.Text = "Веселый старт 5 км";
            pictureBoxToilets.Visible = false; Toilets.Visible = false;
            pictureBoxDrinks.Visible = false; Drinks.Visible = false;
            pictureBoxEnergyBars.Visible = false; EnergyBars.Visible = false;
            pictureBoxInformation.Visible = false; Information.Visible = false;
            pictureBoxMedical.Visible = false; Medical.Visible = false;
        }
    }
}
