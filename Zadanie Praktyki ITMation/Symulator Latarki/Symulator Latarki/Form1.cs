using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symulator_Latarki
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            
            InitializeComponent();
        }

      static class Flashlight
        {
            private static Random rnd = new Random();
            private static List<Battery> BatteriesNew = new List<Battery>();
            private static List<Battery> BatteriesUsed = new List<Battery>();
            private static bool isIn = false;
            private static bool isFlashlightOn = false;

            static Flashlight()
            {
                for (int i=1;i<=10;i++)
                {   
                    Battery b = new Battery(rnd.Next(85,101));
                    
                    BatteriesNew.Add(b);
                }
            }
            
           public static int GetBatteriesCount()
            {
                return BatteriesUsed.Count;
            }

            public static void InsertBatteries()
            {
                BatteriesUsed.Add(BatteriesNew.ElementAt(0));
                BatteriesNew.RemoveAt(0);
            }

            public static int GetVoltage(int index)
            {
                return BatteriesUsed.ElementAt(index).GetVoltage();
            }

            public static void RemoveBatteries()
            {
                BatteriesNew.Add(BatteriesUsed.ElementAt(BatteriesUsed.Count-1));
                BatteriesUsed.RemoveAt(BatteriesUsed.Count-1);

            }

            public static bool IsBulbIn()
            {
                return isIn;
            }
           
            public static void SetBulb()
            {
                isIn = true;
            }

            public static void TurnOff()
            {
                isFlashlightOn = false;
            }

            public static void TurnOn()
            {
                isFlashlightOn = true;
            }

            public static bool PowerSupply()
            {
                int licznik = 0;
                foreach(Battery b in BatteriesUsed)
                {
                    if (b.GetVoltage() >= 15) licznik++;
                }
                if (licznik >= 2) return true;
                else return false;
            }

            public static void updateBatteryStatus(int bulbPower, int index)
            {
                BatteriesUsed.ElementAt(index).SetVoltage(bulbPower);
            }
        }

         class Battery 
        {
            private int voltage;
            

            public Battery(int voltage)
            {
                this.voltage = voltage;
            }
            public int GetVoltage()
            {
                return voltage;
            }

            public void SetVoltage(int bulbPower)
            {
                voltage -= bulbPower;
            }
            
        }

        public static class Bulb
        {
            static int power;


            static Bulb()
            {
                power = 1;
            }

            public static void SetBulbPower(int level)
            {
                power = level;
            }

            public static int GetBulbPower()
            {
                return power;
            }
        }

        private void buttonON_Click(object sender, EventArgs e)
        {
            if (textBoxState.Text != "ON")
            {
                if (Flashlight.IsBulbIn() && Flashlight.GetBatteriesCount() >= 2 && Flashlight.PowerSupply())
                {
                    Flashlight.TurnOn();
                    textBoxState.Text = "ON";
                    for (int i = 0; i < Flashlight.GetBatteriesCount(); i++)
                    {
                        switch (i + 1)
                        {
                            case 1:
                                Flashlight.updateBatteryStatus(Bulb.GetBulbPower(), i);
                                textBoxBattery1.Text = Flashlight.GetVoltage(i).ToString() + " %";
                                break;
                            case 2:
                                Flashlight.updateBatteryStatus(Bulb.GetBulbPower(), i);
                                textBoxBattery2.Text = Flashlight.GetVoltage(i).ToString() + " %";
                                break;
                            case 3:
                                Flashlight.updateBatteryStatus(Bulb.GetBulbPower(), i);
                                textBoxBattery3.Text = Flashlight.GetVoltage(i).ToString() + " %";
                                break;

                        }
                    }
                }
                if (!Flashlight.IsBulbIn())
                {
                    MessageBox.Show("Nie włożono żarówki do latarki.", "Niepoprawne uruchomienie latarki.");
                }
                if (Flashlight.GetBatteriesCount() < 2)
                {
                    MessageBox.Show("Niewystarczająca ilość baterii.", "Niepoprawne uruchomienie latarki");
                }
                if (Flashlight.GetBatteriesCount() >= 2 && !Flashlight.PowerSupply())
                {
                    MessageBox.Show("Zbyt niskie napięcie w bateriach.", "Wymień baterie");
                }

            }
            else MessageBox.Show("Latarka jest już włączona", "Informacja");
        }
        

        private void buttonOFF_Click(object sender, EventArgs e)
        {
            Flashlight.TurnOff();
            textBoxState.Text = "OFF";
        }

        private void buttonRemoveTheBattery_Click(object sender, EventArgs e)
        {
            if (Flashlight.GetBatteriesCount() > 0)
            {
                Flashlight.RemoveBatteries();
                switch (Flashlight.GetBatteriesCount()+1)
                {
                    case 1:
                        textBoxBattery1.Text = null;
                        break;
                    case 2:
                        textBoxBattery2.Text = null;
                        break;
                    case 3:
                        textBoxBattery3.Text = null;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wyciągnięto wszystkie baterie.");
            }

        }

        private void buttonInsertTheBatteries_Click(object sender, EventArgs e)
        {
            if (Flashlight.GetBatteriesCount() < 3)
            {
                Flashlight.InsertBatteries();
                switch (Flashlight.GetBatteriesCount())
                {
                    case 1:
                        textBoxBattery1.Text = Flashlight.GetVoltage(Flashlight.GetBatteriesCount() - 1).ToString() + " %";
                        break;
                    case 2:
                        textBoxBattery2.Text = Flashlight.GetVoltage(Flashlight.GetBatteriesCount() - 1).ToString() + " %";
                        break;
                    case 3:
                        textBoxBattery3.Text = Flashlight.GetVoltage(Flashlight.GetBatteriesCount() - 1).ToString() + " %";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Włożono wszystkie baterie.","Informacja");
            }
            
        }

        private void buttonInsertLightBulb_Click(object sender, EventArgs e)
        {
           if(!Flashlight.IsBulbIn())
            {
                Flashlight.SetBulb();
            }
            else
            {
                MessageBox.Show("Żarówka jest już włożona.","Informacja");
            }
        }

        private void buttonReplaceTheBulb_Click(object sender, EventArgs e)
        {
            bool parser;
            int output;
            parser = Int32.TryParse(textBoxSelectBulbPower.Text, out output);
            if (parser && output > 0 && output <= 10)
            {
                Bulb.SetBulbPower(output);
            }
            else
            {
                MessageBox.Show("Źle wprowadzone dane","Błąd");
            }
        }
    }
}
