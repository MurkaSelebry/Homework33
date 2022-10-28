using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace Homework33
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
      //  [STAThread]
        public class AnswerData
        {
            public string name1, name2, name3, county, city, phone;
            public string birthday;
            public bool isMale;

            public AnswerData(string name1, string name2, string name3, string county, string city, string phone, string birthday, bool isMale)
            {
                this.name1 = name1;
                this.name2 = name2;
                this.name3 = name3;
                this.county = county;
                this.city = city;
                this.phone = phone;
                this.birthday = birthday;
                this.isMale = isMale;
            }

        }
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Val());       
            AnswerData answerData = new AnswerData("1", "2", "3", "4", "5", "6", "7", true);
            string fileName = "WeatherForecast.json";
            string jsonString = JsonSerializer.Serialize(answerData);
            File.WriteAllText(fileName, jsonString);
            MessageBox.Show(File.ReadAllText(fileName));

        }
    }
}
