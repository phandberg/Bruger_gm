using System;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Windows.Forms;
using System.Collections.Generic;
using GMap.NET.MapProviders;
using System.Drawing;
using MySqlConnector;

namespace Bruger_gm
{
    public partial class Form1 : Form
    {
        List<PointLatLng> _points;
        
        public Form1()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"ApiKey";
            //GMapProviders.BingMap.ClientKey = @"Mya6wzEFiLwDFSyDwAdB~4xWOvXPHnFaKTTS0gu-Pdg~Ar6en1ewDglicu-sI6JYN1AR1wScesxT1-gj5WX7NaiBAffFdJvWvi6UfZQB_PiJ";
            map.DragButton = MouseButtons.Left;
            //map.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            map.MapProvider = GMapProviders.GoogleMap;
            //map.MapProvider = GMapProviders.BingMap;

            //Virker pt. kun, når input er med komma og ikke punktum ...
            double lat = Convert.ToDouble(txtlat.Text);
            double lon = Convert.ToDouble(txtlon.Text);

            //var lat = txtlat;
            //var lon = txtlon;
            map.Position = new GMap.NET.PointLatLng(lat, lon);
            map.MinZoom = 1;
            map.MaxZoom = 18;
            map.Zoom = 17;
            
            PointLatLng point = new PointLatLng(lat, lon);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);

            marker.ToolTipText = "Det er nemt, at lave sådan en tekst,\nmen jeg kan ikke få foto i";
            GMapOverlay markers = new GMapOverlay("markers");
            
            markers.Markers.Add(marker);

            map.Overlays.Add(markers);
        }

        private void map_Load(object sender, EventArgs e)
        {

        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            _points.Clear();
        }

        private void AddPoint_Click(object sender, EventArgs e)
        {
            _points.Add(new PointLatLng(Convert.ToDouble(txtlat.Text), Convert.ToDouble(txtlon.Text)));
           
        }

        private void Route_Click(object sender, EventArgs e)
        {
           
            GDirections myDirections;
            var route = GMapProviders.GoogleMap.GetDirections(out myDirections, _points[0], _points[1], false, false, true, false, true);

            //var route = BingMapProvider.Instance.GetRoute(_points[0], _points[1], false, true, 17);
            //var route = GoogleMapProvider.Instance.GetRoute(_points[0], _points[1], false, true, 17);
           
            Console.WriteLine("punkt 1:" + _points[0] + "punkt 2:" + _points[1]);

            var r = new GMapRoute(myDirections.Route, "route");
            
            r.Stroke = new Pen(Color.Red, 3);
            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            map.Overlays.Add(routes);

            double distance = r.Distance;
            MessageBox.Show(distance.ToString());

        }

        private void interessepunkt_Click(object sender, EventArgs e)
        {
         /*   // Connection string
            string ConnectionString = "datasource=den1.mysql1.gear.host;port=3306;username=christiansoe;password=Fb3MH9!?Iw3k";

            //Query String
            string QueryString = ;
            //Connection declaretion
            MySqlConnection connection; //VIRKER IKKE MED FINALLY

            try
            {
                //Connection obj
                connection = new MySqlConnection(ConnectionString);

                //Command obj
                MySqlCommand command = new MySqlCommand(QueryString, connection);

                //Opens connection
                connection.Open();

                //Excecute command, DB is populated
                command.ExecuteReader();

                Console.WriteLine("Save Data");

                //Closes connection
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                //skal lukke forbindelse her hvis crash??
            } */
        }
    }
}
