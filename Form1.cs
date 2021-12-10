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
            //GMapProviders.GoogleMap.ApiKey = @"ApiKey";
            GMapProviders.BingMap.ClientKey = @"Mya6wzEFiLwDFSyDwAdB~4xWOvXPHnFaKTTS0gu-Pdg~Ar6en1ewDglicu-sI6JYN1AR1wScesxT1-gj5WX7NaiBAffFdJvWvi6UfZQB_PiJ";
            map.DragButton = MouseButtons.Left;
            //map.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            //map.MapProvider = GMapProviders.GoogleMap;
            map.MapProvider = GMapProviders.BingMap;

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
            //_points.Add(new PointLatLng(txtlat.Text, txtlon.Text);
        }

        private void Route_Click(object sender, EventArgs e)
        {
            //var start = _points[0];
            //var slut = _points[1];
            //GDirections routedir = null;

            //var route = GMap.NET.MapProviders.BingHybridMapProvider.Instance.GetRoute(_points[0], _points[1], true, true, 17);
            var route = BingMapProvider.Instance.GetRoute(_points[0], _points[1], true, true, 17);
            //var route = GoogleMapProvider.Instance.GetRoute(_points[0], _points[1], false, true, 17);
            //MapRoute route = new GoogleMapProviderBase.GetRoute(_points[0], _points[1], false, true, 17);
            //MapRoute route = GoogleMapProvider.Instance.GetDirections(out routedir, _points[0], _points[1], false, false, true, false, true);
            var r = new GMapRoute(route.Points, "FirstTour");
            r.Stroke = new Pen(Color.Red, 3);
            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            map.Overlays.Add(routes);
        }

        private void interessepunkt_Click(object sender, EventArgs e)
        {

        }
    }
}
