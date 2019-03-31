/*
 * Создано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 29.03.2019
 * Время: 9:51
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace dateBase
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            string login = this.textBox1.Text;
            string pass = this.textBox2.Text;

            Db db = new Db();
            var result = db.DateBase(login, pass);

            if (login == result)
            {
                Main main = new Main();
                main.Show();
                main.label3.Text = login;
                this.Hide();
               
            }
                
            

            


           

            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
