using System;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Windows.Forms;
using System.Collections.Generic;
using GMap.NET.MapProviders;
using System.Drawing;

namespace Bruger_gm
{
    /*
     Programmet bruger Nuget-pakken GMap.Net.Windows
    */
    public partial class Form1 : Form
    {
        //Opretter liste
        List<PointLatLng> _points;

        public Form1()
        {
            InitializeComponent();

            //Constructor
            _points = new List<PointLatLng>();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AddPoint_Click(object sender, EventArgs e)
        {
            //Tilføjer punkt til listen ud fra indtastede koordinater
            _points.Add(new PointLatLng(Convert.ToDouble(txtlat.Text), Convert.ToDouble(txtlon.Text)));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Fungerer uden ApiKey, men muligvis nødvendig, hvis vi skal lave mere avancerede ting
            GMapProviders.GoogleMap.ApiKey = @"ApiKey";

            //Giver mulighed for at rykke kortet med musen
            map.DragButton = MouseButtons.Left;
            //Den valgte kortudbyder
            map.MapProvider = GMapProviders.GoogleMap;

            //For loop der itererer gennem listen og sætter markører på alle tre punkter
            for (int i = 0; i < _points.Count; i++)
            {

                //Virker pt. kun, når input er med komma og ikke punktum ...
                double lat = Convert.ToDouble(txtlat.Text);
                double lon = Convert.ToDouble(txtlon.Text);

                //Finder placeringen på kortet ud fra koordinater
                map.Position = new GMap.NET.PointLatLng(lat, lon);
                map.MinZoom = 1;
                map.MaxZoom = 18;
                map.Zoom = 16; //Aktuel zoomlevel

                PointLatLng point = new PointLatLng(lat, lon);
                //Bruger koordinaterne fra listen
                point = _points[i];

                //Vælg markørtype
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.purple_small);

                //marker.ToolTipText = "Det er nemt, at lave sådan en tekst,\nmen jeg kan ikke få foto i";

                //Opret et overlay til markører
                GMapOverlay markers = new GMapOverlay("markers");
                //Tilføj markør til overlay
                markers.Markers.Add(marker);
                //Tilføj overlay til kort
                map.Overlays.Add(markers);
            }


        }


        private void map_Load(object sender, EventArgs e)
        {

        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            //Sletter listen
            _points.Clear();
        }



        private void Route_Click(object sender, EventArgs e)
        {
            //For loop der beregner afstand mellem de to første punkter og dernæst de to sidste punkter
            for (int i = 0; i < _points.Count - 1; i++)
            {
                //Metode i nuget-pakken, der udregner ruten
                GDirections myDirections;
                var route = GMapProviders.GoogleMap.GetDirections(out myDirections, _points[i], _points[i+1], false, false, true, false, true);

                //Tegner ruten - men virker ikke pt.
                var r = new GMapRoute(myDirections.Route, "route");
                r.Stroke = new Pen(Color.Red, 3);
                var routes = new GMapOverlay("routes");
                routes.Routes.Add(r);
                map.Overlays.Add(routes);

                //Udregner længden mellem punkterne
                double distance = r.Distance;
                double tid = distance / .08;
                MessageBox.Show("Afstand i km: " + distance.ToString() + " Tid: " + tid + " min.");
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
