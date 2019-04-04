using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HomeWork_190326
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipment> equipments = new List<Equipment>();

            Program program = new Program();
            string[] equipmentStrings = program.ReadAllLines("./equipment.csv");

            for(int i = 1; i < equipmentStrings.Length; i++)
            {
                string[] info = program.ExtractEquipmentInfo(equipmentStrings[i]);
                //program.ShowEquipmetInfo(info);
                Equipment newEquipment = Equipment.GreateEquipmentFromInfo(info);
                newEquipment.ShowSpec();
                equipments.Add(newEquipment);
            }

            Character c1 = new Character("李太白", 500, 600);
            Character c2 = new Character("灭霸", 2000, 1500);

            c1.Equip(equipments[4],true);
            c2.Equip(equipments[4],false);

            c1.Attack(c2);
            c2.Attack(c1);

            Console.ReadKey();
        }

        string[] ReadAllLines(string path)
        {
            string[] ret = File.ReadAllLines(path);
            return ret;
        }

        string[] ExtractEquipmentInfo(string equipmentString)
        {
            string[] ret = equipmentString.Split(',');
            return ret;
        }

        void ShowEquipmetInfo(string[] info)
        {
            int id = int.Parse(info[0]);
            string name = info[1];
            int atk = int.Parse(info[2]);
            int def = int.Parse(info[3]);
            int price = int.Parse(info[4]);
            string desc = info[5];

            Console.WriteLine("id={0},name={1},atk={2},def={3},price={4},desc={5}", id, name, atk, def, price, desc);
        }
    }
}
