using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AutosMieten
{
    public partial class RocketForm : Form
    {
        static string connectionString; //connectionstring wird als string deklariert
        MySqlConnection con = new MySqlConnection(connectionString); //con wird initialisiert
        MySqlCommand cmd; //cmd wird als MySqlCommand deklariert

        public RocketForm()
        {
            InitializeComponent();
            connectionString = @"host=localhost;user=root;database=carsharing"; //connnectionstring
        }

        private void AusleihButton_Click(object sender, EventArgs e)
        {
            //Autos buchen Funktion
            Rent();
            //Startzeit wird hunzugefügt
            startTimeTextBox.Text = dateTimePicker2.Value.ToString();
        }

        private void CarListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             autoTextBox.Text = CarListBox.SelectedItem.ToString(); //Der Text in der Autotextbox wird gleich dem ausgewählten Item in der CarlistBox gesetzt
        }

        private void SyncButton_Click(object sender, EventArgs e)
        {
            //CarListBox aktualisieren Funktion
            Sync();
        }

        private void HinzufügenButton_Click(object sender, EventArgs e)
        {
            //Auto hinzufügen Funktion
            AddCar();
        }

        private void AddCar()
        {
            // Autos werden hinzugefügt
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO fahrzeug SET Name='" + nameTextBox.Text + "',Gangschaltart=" + gangschaltartTextBox.Text + ",Marke='" + markeTextBox.Text + "',Treibstoff=" + treibstoffTextBox + ",Leistung=" + leistungTextBox + ",Anhängerkupplung=" + anhängekuppelTextBox.Text + ",Sitzplätze" + sitzplätzeTextBox.Text + ",Kofferraumgröße=" + kofferraumgrößeTextBox.Text + ",Autoklasse='" + klasseTextBox.Text + "'";
            cmd.CommandText = "INSERT INTO standort SET Postleitzahl=" + postleitzahlTextBox + ",Stadt='" + stadtTextBox + "',Straße='" + straßeTextBox.Text + "'";

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Reset();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }

        }
        private void Sync()
        {
            //CarListBox soll mit dem Select Statement aktualisiert werden 
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Name FROM fahrzeug";
            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                Clear();

                while (reader.Read())
                {
                    CarListBox.Items.Add(reader["Name"]).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void Reset()
        {
            //Textboxen werden nach dem hinzufügen geleert
            nameTextBox.Text = "";
            gangschaltartTextBox.Text = "";
            markeTextBox.Text = "";
            treibstoffTextBox.Text = "";
            leistungTextBox.Text = "";
            anhängekuppelTextBox.Text = "";
            sitzplätzeTextBox.Text = "";
            postleitzahlTextBox.Text = "";
            kofferraumgrößeTextBox.Text = "";
            stadtTextBox.Text = "";
            klasseTextBox.Text = "";
            straßeTextBox.Text = "";
        }
        private void Clear()
        {
            CarListBox.Items.Clear();
        }
        private void Rent()
        {
            //Buchung wird mit allen Attributen eingefügt in die SQLDatenbank
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO buchung SET Username='" + usernameTextBox.Text + "',Start='" + startTimeTextBox.Text + "',Fahrzeug-ID=" + CarListBox.SelectedItem + ",Ende='" + endTimetextBox.Text + "'";
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Reset();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        private void ZurückgebenButton_Click(object sender, EventArgs e)
        {
            //Endzeit wird festgelegt Fahrzeug-Id wird aus der Buchungstabelle gelöscht

            endTimetextBox.Text = dateTimePicker2.Value.ToString();
            cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM buchung WHERE fahrzeug-ID='" + CarListBox.SelectedItem + "'";
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
