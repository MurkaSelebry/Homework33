using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace Homework33
{
    public partial class Val : Form
    {
        public Val()
        {
            InitializeComponent();
            date_birthday.MinDate = new DateTime(DateTime.Now.Year-100, DateTime.Now.Month, DateTime.Now.Day);

        }
        public class AnswerData
        {
            public string _1name, _2name,_3name,county,city,phone;
            public string birthday;
            public bool isMale;

            public AnswerData(string name1, string name2, string name3, string county, string city, string phone, string birthday, bool isMale)
            {
                _1name = name1;
                _2name = name2;
                _3name = name3;
                this.county = county;
                this.city = city;
                this.phone = phone;
                this.birthday = birthday;
                this.isMale = isMale;
            }
        } 
        private void country_SelectedIndexChanged(object sender, EventArgs e)
        {
            city.Items.Clear();
            if (country.Items[country.SelectedIndex].ToString() == "Казахстан")
            {
                city.Items.AddRange(new string[] {"Астана","Алтай","Уральск"});
            }
            else if (country.Items[country.SelectedIndex].ToString() == "Россия")
            {
                city.Items.AddRange(new string[] { "Москва", "Санкт-Петербург","Новосибирск" });
            }
        }

        private void get_res_Click(object sender, EventArgs e)
        {
            AnswerData answerData = new AnswerData(_1name.Text, _2name.Text, _3name.Text, country.Items[country.SelectedIndex].ToString(), city.Items[city.SelectedIndex].ToString(),phone.Text, date_birthday.Value.ToString(), male.Checked);
            string fileName = "WeatherForecast.json";
            string jsonString = JsonSerializer.Serialize(answerData);
            File.WriteAllText(fileName, jsonString);
            
            MessageBox.Show(File.ReadAllText(fileName));
        }
    }
}
