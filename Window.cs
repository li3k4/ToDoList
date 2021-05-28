using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DataBaseMySQL
{
	public partial class Window : Form
	{
		private MySqlConnectionStringBuilder conString = new MySqlConnectionStringBuilder();

		public Window()
		{
			InitializeComponent();
			conString.Server = "127.0.0.1";         //сервер подключения
			conString.Database = "mydb";   //название базы данных
			conString.UserID = "root";              //имя пользователя
			conString.Password = "rootLiza";	//пароль

			readDataFromDB();
		}

		/// <summary>
		/// Проверяет входные данные на заполнение
		/// </summary>
		/// <param name="data">Данные</param>
		/// <returns>Результат проверки</returns>
		private bool requiredValidator(string[] data)
		{
			if((data == null)
				|| (data.Length == 0))
			{
				return false;
			}

			for(int i = 0; i < data.Length; i++)
			{
				if((data[i] == null)
					|| (data[i].Length == 0))
				{
					return false;
				}
			}

			return true;
		}

		/// <summary>
		/// Проверка корректности даты
		/// </summary>
		/// <param name="date">Дата</param>
		/// <returns>Результат проверки</returns>
		private bool checkDate(string date)
		{
			if ((date == null)
				|| (date.Length == 0)
				|| (date.Split(new char[] { '.' }).Length != 3))
			{
				return false;
			}

			string[] dateArray = date.Split(new char[] { '.' });

			foreach(string element in dateArray){
				if (element.Length == 0)
					return false;
				try
				{
					int.Parse(element);
				}catch(Exception){
					return false;
				}
			}

			if((dateArray[2].Length != 4)
				|| (dateArray[0].Length != 2)
				|| (dateArray[1].Length != 2)
				|| (int.Parse(dateArray[1]) > 12)
				|| (int.Parse(dateArray[1]) == 0)
				|| (int.Parse(dateArray[0]) > 31)
				|| (int.Parse(dateArray[0]) == 0)){
				return false;
			}

			return true;
		}

		private void _btnAdd_Click(object sender, EventArgs e)
		{
			if((!requiredValidator(new string[]
			{
				_txtDate.Text,
				_cmbDone.Text,
				_txtTask.Text
			})) || (!checkDate(_txtDate.Text))){
				MessageBox.Show("Ошибка!", "Входные данные не корректны!");
				return;
			}

			try
			{
				//экземпляр объекта для подключения к базе данных
				MySqlConnection connection = new MySqlConnection();
				connection.ConnectionString = conString.ConnectionString;
				connection.Open(); //открытие подключения

				string sql = "INSERT INTO table1 (date, done, task) " +
							 "VALUES (@date, @done, @task);";	//команда для добавления данных в базу данных

				try
				{
					//создание команды mysql
					MySqlCommand cmd = connection.CreateCommand();
					cmd.CommandText = sql;	//текст команды

					//добавление параметров в команду:
					cmd.Parameters.AddWithValue("@date", _txtDate.Text);
					cmd.Parameters.AddWithValue("@done", (_cmbDone.Text.Equals("Выполнено")) ? true : false);
					cmd.Parameters.AddWithValue("@task", _txtTask.Text);

					//выполнение команды
					cmd.ExecuteNonQuery();
				}
				catch (Exception g)
				{
					MessageBox.Show(g.Message);
					MessageBox.Show("Не удалось добавить данные в базу данных!", "Ошибка!");
				}

				connection.Close();
			}catch(Exception)
			{
				MessageBox.Show("Не удалось подключиться к базе данных!", "Ошибка!");
				return;
			}

			int maxId = 0;

			for(int i = 0; i < _dataGridView.Rows.Count; i++)
            {
				int value = int.Parse(_dataGridView.Rows[i].Cells[0].Value.ToString());

				if (maxId < value)
                {
					maxId = value;
                }
            }

			int count = maxId + 1;

			_dataGridView.Rows.Add(count,
			  _txtDate.Text, _cmbDone.Text, _txtTask.Text);
		}

		private void _btnUpdate_Click(object sender, EventArgs e)
		{
			if ((!requiredValidator(new string[]
		    {
				_txtId.Text,
				_txtDate.Text,
				_cmbDone.Text,
				_txtTask.Text
	     	})) || (!checkDate(_txtDate.Text)))
	 		{
				MessageBox.Show("Ошибка!", "Входные данные не корректны!");
				return;
			}

            try
            {
				int res = Int32.Parse(_txtId.Text);
				if(res <= 0)
                {
					MessageBox.Show("Error! Id uncorrect!");
					return;
                }
			} catch(Exception)
            {
				MessageBox.Show("Error! Id uncorrect!");
				return;
            }

			try
			{
				//экземпляр объекта для подключения к базе данных
				MySqlConnection connection = new MySqlConnection();
				connection.ConnectionString = conString.ConnectionString;
				connection.Open(); //открытие подключения

				string sql = "UPDATE table1 " +
						   	 "SET date = @date, done = @done, task = @task " +
							 "WHERE id = @id;";

				string[] split = _txtDate.Text.Split(new char[] { '.' });
				string date = split[2] + '-' + split[1] + '-' + split[0];

				try
				{
					//создание команды mysql
					MySqlCommand cmd = connection.CreateCommand();
					cmd.CommandText = sql;  //текст команды

					//добавление параметров в команду:
					cmd.Parameters.AddWithValue("@id", _txtId.Text);
					cmd.Parameters.AddWithValue("@date", date);
					cmd.Parameters.AddWithValue("@done", (_cmbDone.Text.Equals("Выполнено")) ? true : false);
					cmd.Parameters.AddWithValue("@task", _txtTask.Text);

					//выполнение команды
					cmd.ExecuteNonQuery();
				}
				catch (Exception)
				{
					MessageBox.Show("Не удалось обновить данные из базы данных!", "Ошибка!");
				}

				connection.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Не удалось подключиться к базе данных!", "Ошибка!");
				return;
			}

			readDataFromDB();
		}


		/// <summary>
		/// Чтение данных из таблицы
		/// </summary>
		public void readDataFromDB()
		{
			_dataGridView.Rows.Clear();

			try
			{
				//экземпляр объекта для подключения к базе данных
				MySqlConnection connection = new MySqlConnection();
				connection.ConnectionString = conString.ConnectionString;
				connection.Open(); //открытие подключения

				string sql = "SELECT * FROM table1;"; //команда для чтения данных из таблицы

				try
				{
					//создание команды mysql
					MySqlCommand cmd = connection.CreateCommand();
					cmd.CommandText = sql;  //текст команды
				
					MySqlDataReader sqlReader = cmd.ExecuteReader();
					if (sqlReader.HasRows)
					{
						while (sqlReader.Read())
						{
							_dataGridView.Rows.Add(
								sqlReader.GetString(0).ToString(),
								sqlReader.GetValue(1).ToString().Split(new char[] { ' ' })[0],
								((sqlReader.GetValue(2).ToString().Equals("1"))? "Выполнено" : "Не выполнено"),
								sqlReader.GetValue(3).ToString());
						}
					}
				}
				catch (Exception)
				{
					MessageBox.Show("Не удалось добавить данные в базу данных!", "Ошибка!");
				}

				connection.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Не удалось подключиться к базе данных!", "Ошибка!");
				return;
			}
		}

        private void _btnDelete_Click(object sender, EventArgs e)
        {

			if ((!requiredValidator(new string[]
			{
				_txtId.Text,
		
			 })))
			{
				MessageBox.Show("Ошибка!", "Входные данные не корректны!");
				return;
			}

			try
			{
				int res = Int32.Parse(_txtId.Text);
				if (res <= 0)
				{
					MessageBox.Show("Error! Id uncorrect!");
					return;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Error! Id uncorrect!");
				return;
			}

			try
			{
				//экземпляр объекта для подключения к базе данных
				MySqlConnection connection = new MySqlConnection();
				connection.ConnectionString = conString.ConnectionString;
				connection.Open(); //открытие подключения

				string sql = "DELETE FROM table1 WHERE id = @id; " +
							"UPDATE table1 SET id = id - 1 	" +
							"WHERE id > @id; ";

				try
				{
					//создание команды mysql
					MySqlCommand cmd = connection.CreateCommand();
					cmd.CommandText = sql;  //текст команды

					//добавление параметров в команду:
					cmd.Parameters.AddWithValue("@id", _txtId.Text);

					//выполнение команды
					cmd.ExecuteNonQuery();
				}
				catch (Exception)
				{
					MessageBox.Show("Не удалось удалить данные из базы данных!", "Ошибка!");
				}

				connection.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Не удалось подключиться к базе данных!", "Ошибка!");
				return;
			}

			readDataFromDB();
		}
    }
}
