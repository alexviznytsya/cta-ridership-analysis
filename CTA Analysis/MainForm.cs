//
// CTA Ridership Analysis.
//
// Alex Viznytsya
// Fall 2017
//

using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace CTA_Analysis
{
    public partial class MainForm : Form
    {
        private string databaseFilename;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dbFilename = "CTA.mdf";
            string version = "MSSQLLocalDB";
            string connectionInfo = String.Format(@"Data Source=(LocalDB)\{0}; 
                                                    AttachDbFilename=|DataDirectory|\{1}; 
                                                    Integrated Security=True;", version, dbFilename);

            SqlConnection db = null;

            try
            {
                db = new SqlConnection(connectionInfo);
                db.Open();
            }
            catch
            {
            }
            finally
            {
                if (db != null && db.State == ConnectionState.Open)
                {
                    db.Close();
                }
            }
        }

        private void clearStopsSelectionFields()
        {
            this.handicap.Clear();
            this.direction.Clear();
            this.location.Clear();
            this.lineNames.Items.Clear();
            this.lineNames.Refresh();
        }

        private void clearStationSelectionFields()
        {
            this.percentageRidership.Clear();
            this.stationStopNames.Items.Clear();
            this.stationStopNames.Refresh();
            this.weekday.Clear();
            this.saturday.Clear();
            this.saturday.Clear();
            clearStopsSelectionFields();
        }

        private void clearForm()
        {
            this.totalRidership.Clear();
            this.averageRidership.Clear();
            clearStationSelectionFields();
        }

        private DataSet getDataSetFromSQLQuery(string sql)
        {
            string version = "MSSQLLocalDB";
            string connectionInfo = String.Format(@"Data Source=(LocalDB)\{0}; 
                                                    AttachDbFilename=|DataDirectory|\{1}; 
                                                    Integrated Security=True;", version, databaseFilename);

            SqlConnection db = new SqlConnection(connectionInfo);
            db.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            cmd.CommandText = sql;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            da.Dispose();
            db.Close();
            return ds;
        }

        private void loadStations()
        {
            this.Cursor = Cursors.WaitCursor;
            clearForm();

            string sqlQuery = string.Format(@"SELECT Name 
                                              FROM Stations 
                                              ORDER BY Name ASC;");

            DataSet ds = getDataSetFromSQLQuery(sqlQuery);

            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                this.stationNames.Items.Add(Convert.ToString(row["Name"]));

            }

            this.stationNames.SelectedIndex = 0;

            this.numOfStations.Text = Convert.ToString(ds.Tables["TABLE"].Rows.Count);

            this.Cursor = Cursors.Default;
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databaseFilename = "CTA.mdf";
            loadStations();
        }

        private void stationNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            clearStationSelectionFields();

            string sqlSafeStationName = this.stationNames.Text.Replace("'", "''");

            string sqlQuery = string.Format(@"SELECT SUM(convert(bigint, DailyTotal)) AS Total, Count(*) numOFDays, TypeOfDay
                                              FROM Riderships, Stations
                                              WHERE Riderships.StationID = Stations.StationID AND Stations.Name = '{0}'
                                              GROUP BY TypeOfDay
                                              ORDER BY TypeOfDay ASC;", sqlSafeStationName);

            string sqlQuery2 = string.Format(@"SELECT SUM(convert(bigint, DailyTotal)) as Total
                                              FROM Riderships;");

            string sqlQuery3 = string.Format(@"SELECT Stops.Name
                                              FROM Stops, Stations
                                              WHERE Stops.StationID = Stations.StationID AND Stations.Name = '{0}'
                                              ORDER BY Stops.Name ASC;", sqlSafeStationName);

            DataSet ds = getDataSetFromSQLQuery(sqlQuery);
            DataSet ds2 = getDataSetFromSQLQuery(sqlQuery2);
            DataSet ds3 = getDataSetFromSQLQuery(sqlQuery3);

            long weekDaySum = Convert.ToInt64(ds.Tables["Table"].Select("TypeOfDay = 'W'")[0][0]);
            long saturdaySum = Convert.ToInt64(ds.Tables["Table"].Select("TypeOfDay = 'A'")[0][0]);
            long holidaySum = Convert.ToInt64(ds.Tables["Table"].Select("TypeOfDay = 'U'")[0][0]);

            long totalRidershipsForStation = weekDaySum + saturdaySum + holidaySum;
            long totalNumOfDaysForStation = Convert.ToInt64(ds.Tables["Table"].Select("TypeOfDay = 'W'")[0][1]) +
                                           Convert.ToInt64(ds.Tables["Table"].Select("TypeOfDay = 'A'")[0][1]) +
                                           Convert.ToInt64(ds.Tables["Table"].Select("TypeOfDay = 'U'")[0][1]);

            long totalRiderships = Convert.ToInt64(ds2.Tables["Table"].Rows[0][0]);

            this.totalRidership.Text = string.Format("{0:#,##0}", totalRidershipsForStation);
            this.averageRidership.Text = string.Format("{0:#,##0}/day", totalRidershipsForStation / totalNumOfDaysForStation);
            this.percentageRidership.Text = string.Format("{0:0.00}%", (Convert.ToDouble(totalRidershipsForStation) / totalRiderships) * 100);

            this.weekday.Text = string.Format("{0:#,##0}", weekDaySum);
            this.saturday.Text = string.Format("{0:#,##0}", saturdaySum);
            this.holiday.Text = string.Format("{0:#,##0}", holidaySum);

            foreach (DataRow row in ds3.Tables["TABLE"].Rows)
            {
                this.stationStopNames.Items.Add(Convert.ToString(row["Name"]));
            }
            
            if(this.stationStopNames.Items.Count > 1)
            {
                this.stationStopNames.SelectedIndex = 0;
            }

            this.Cursor = Cursors.Default;
        }

        private void stationStopNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            clearStopsSelectionFields();

            string sqlSafeStationStopName = this.stationStopNames.Text.Replace("'", "''");

            string sqlQuery = string.Format(@"SELECT ADA, Direction, Latitude, Longitude
                                              FROM Stops
                                              WHERE Name = '{0}';", sqlSafeStationStopName);

            string sqlQuery2 = string.Format(@"SELECT Lines.Color
                                               FROM Lines, StopDetails, Stops
                                               WHERE Lines.LineID = StopDetails.LineID AND
                                                     StopDetails.StopID = Stops.StopID AND
                                                     Stops.Name = '{0}'
                                               ORDER BY Lines.Color ASC;", sqlSafeStationStopName);

            DataSet ds = getDataSetFromSQLQuery(sqlQuery);
            DataSet ds2 = getDataSetFromSQLQuery(sqlQuery2);

            String handicap;
            if (Convert.ToBoolean(ds.Tables["Table"].Rows[0][0]))
            {
                handicap = "Yes";
            } else
            {
                handicap = "No";
            }

            String direction = ds.Tables["Table"].Rows[0][1].ToString();
            String location = String.Format("({0}, {1})", ds.Tables["Table"].Rows[0][2], ds.Tables["Table"].Rows[0][3]);

            this.handicap.Text = handicap;
            this.direction.Text = direction;
            this.location.Text = location;

            foreach (DataRow row in ds2.Tables["TABLE"].Rows)
            {
                this.lineNames.Items.Add(Convert.ToString(row["Color"]));
            }

            this.Cursor = Cursors.Default;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void top10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if(databaseFilename.Length > 0)
            {
                Top10Form top10Form = new Top10Form();

                string sqlQuery = string.Format(@"SELECT Stations.Name, SUM(convert(bigint, Riderships.DailyTotal)) AS Total
                                                  FROM Stations, Riderships
                                                  WHERE Stations.StationID = Riderships.StationID
                                                  GROUP BY Stations.Name
                                                  ORDER BY Total DESC;");

                DataSet ds = getDataSetFromSQLQuery(sqlQuery);
                DataTable dt = new DataTable();

                dt.Columns.AddRange(new DataColumn[2] { new DataColumn("Name"), new DataColumn("Total")});

                for (int i = 0; i < 10; i++)
                {
                    dt.ImportRow(ds.Tables["TABLE"].Rows[i]);
                }
                top10Form.setDataGrid(dt);

                top10Form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please load database first.");
            }

            this.Cursor = Cursors.Default;
        }
    }
}
