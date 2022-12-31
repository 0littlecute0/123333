using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace 地图交互
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Image ImageFromWebTest(string _url)
        {
            Image img = null;
            string url = _url;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            using (WebResponse response = request.GetResponse())
            {
                img = Image.FromStream(response.GetResponseStream());
            }
            return img;
        }
        double xmin = -180;
        double xmax = 180;
        double ymin = -180;
        double ymax = 180;
        double x0 = 0;
        double y0 = 0;
        double xo = 0;
        double yo = 0;
        int x1 = 0;
        int x2 = 0;
        int y1 = 0;
        int y2 = 0;

        private string constructURL()
        {
            string url1 = "http://sampleserver6.arcgisonline.com/arcgis/rest/services/SampleWorldCities/MapServer/export?bbox=";
            string url2 = "&bboxSR=4326&imageSR=4326&size=1000,500&dpi=96&format=png32&transparent=true&layers=show%3A0%2C1%2C2&f=image";
            string bboxString = xmin.ToString() + "," + ymin.ToString() + "," +
                xmax.ToString() + "," + ymax.ToString();
            string url_ = url1 + bboxString + url2;
            return url_;
        }


        private string constructJSONURL()
        {
            string url1 = "http://sampleserver6.arcgisonline.com/arcgis/rest/services/Earthquakes_Since1970/FeatureServer/0/query?f=geojson&returnGeometry=true&spatialRel=esriSpatialRelIntersects&";
            string url2 = "&geometryType=esriGeometryEnvelope&inSR=4326&outFields=*&returnCentroid=false&returnExceededLimitFeatures=false&maxRecordCountFactor=3&outSR=4326&resultType=tile&quantizationParameters=%7B%22mode%22%3A%22view%22%2C%22originPosition%22%3A%22upperLeft%22%2C%22tolerance%22%3A4891.969810250004%2C%22extent%22%3A%7B%22xmin%22%3A12523442.714237027%2C%22ymin%22%3A5009377.085698988%2C%22xmax%22%3A15028131.257085029%2C%22ymax%22%3A7514065.62854699%2C%22spatialReference%22%3A%7B%22wkid%22%3A102100%2C%22latestWkid%22%3A3857%7D%7D%7D";
            string bboxString = "geometry=" + xmin.ToString() + "," + ymin.ToString() + "," +
                xmax.ToString() + "," + ymax.ToString();
            return url1 + bboxString + url2;
        }

        /// <summary>
        /// 对输入的地址发送http请求，并将返回的字节流转换为字符串
        /// </summary>
        /// <param name="_url"></param>
        /// <returns></returns>
        private string GeoJSONTextFromStream(string _url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url);
            string result_Json = "";
            using (WebResponse response = request.GetResponse())
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                result_Json = reader.ReadToEnd();
            }
            return result_Json;
        }


        private void big_Click(object sender, EventArgs e)
        {
            xmin += 0.1 * (xmax - xmin);
            xmax -= 0.1 * (xmax - xmin);
            ymin += 0.1 * (ymax - ymin);
            ymax -= 0.1 * (ymax - ymin);
            string a = xmin.ToString();
            string b = xmax.ToString();
            string c = ymin.ToString();
            string d = ymax.ToString();
            Uri myurl = new Uri("http://sampleserver6.arcgisonline.com/arcgis/rest/services/SampleWorldCities/MapServer/export?bbox=" + a.ToString() + "%2C" + c.ToString() + "%2C" + b.ToString() + "%2C" + d.ToString() + "&bboxSR=&layers=&layerDefs=&size=&imageSR=&historicMoment=&format=png&transparent=false&dpi=&time=&timeRelation=esriTimeRelationOverlaps&layerTimeOptions=&dynamicLayers=&gdbVersion=&mapScale=&rotation=&datumTransformations=&layerParameterValues=&mapRangeValues=&layerRangeValues=&clipping=&spatialFilter=&f=image");
            pictureBox1.ImageLocation = myurl.ToString();
            this.Refresh();
        }

        private void small_Click(object sender, EventArgs e)
        {
            xmin -= 0.125 * (xmax - xmin);
            xmax += 0.125 * (xmax - xmin);
            ymin -= 0.125 * (ymax - ymin);
            ymax += 0.125 * (ymax - ymin);
            string a = xmin.ToString();
            string b = xmax.ToString();
            string c = ymin.ToString();
            string d = ymax.ToString();
            Uri myurl = new Uri("http://sampleserver6.arcgisonline.com/arcgis/rest/services/SampleWorldCities/MapServer/export?bbox=" + a.ToString() + "%2C" + c.ToString() + "%2C" + b.ToString() + "%2C" + d.ToString() + "&bboxSR=&layers=&layerDefs=&size=&imageSR=&historicMoment=&format=png&transparent=false&dpi=&time=&timeRelation=esriTimeRelationOverlaps&layerTimeOptions=&dynamicLayers=&gdbVersion=&mapScale=&rotation=&datumTransformations=&layerParameterValues=&mapRangeValues=&layerRangeValues=&clipping=&spatialFilter=&f=image");
            pictureBox1.ImageLocation = myurl.ToString();
            this.Refresh();
        }

        private void north_Click(object sender, EventArgs e)
        {
            ymin += 0.2 * (ymax - ymin);
            ymax += 0.2 * (ymax - ymin);
            string a = xmin.ToString();
            string b = xmax.ToString();
            string c = ymin.ToString();
            string d = ymax.ToString();
            Uri myurl = new Uri("http://sampleserver6.arcgisonline.com/arcgis/rest/services/SampleWorldCities/MapServer/export?bbox=" + a.ToString() + "%2C" + c.ToString() + "%2C" + b.ToString() + "%2C" + d.ToString() + "&bboxSR=&layers=&layerDefs=&size=&imageSR=&historicMoment=&format=png&transparent=false&dpi=&time=&timeRelation=esriTimeRelationOverlaps&layerTimeOptions=&dynamicLayers=&gdbVersion=&mapScale=&rotation=&datumTransformations=&layerParameterValues=&mapRangeValues=&layerRangeValues=&clipping=&spatialFilter=&f=image");
            pictureBox1.ImageLocation = myurl.ToString();
            this.Refresh();
        }

        private void south_Click(object sender, EventArgs e)
        {
            ymin -= 0.2 * (ymax - ymin);
            ymax -= 0.2 * (ymax - ymin);
            string a = xmin.ToString();
            string b = xmax.ToString();
            string c = ymin.ToString();
            string d = ymax.ToString();
            Uri myurl = new Uri("http://sampleserver6.arcgisonline.com/arcgis/rest/services/SampleWorldCities/MapServer/export?bbox=" + a.ToString() + "%2C" + c.ToString() + "%2C" + b.ToString() + "%2C" + d.ToString() + "&bboxSR=&layers=&layerDefs=&size=&imageSR=&historicMoment=&format=png&transparent=false&dpi=&time=&timeRelation=esriTimeRelationOverlaps&layerTimeOptions=&dynamicLayers=&gdbVersion=&mapScale=&rotation=&datumTransformations=&layerParameterValues=&mapRangeValues=&layerRangeValues=&clipping=&spatialFilter=&f=image");
            pictureBox1.ImageLocation = myurl.ToString();
            this.Refresh();
        }

        private void west_Click(object sender, EventArgs e)
        {
            xmin -= 0.2 * (xmax - xmin);
            xmax -= 0.2 * (xmax - xmin);
            string a = xmin.ToString();
            string b = xmax.ToString();
            string c = ymin.ToString();
            string d = ymax.ToString();
            Uri myurl = new Uri("http://sampleserver6.arcgisonline.com/arcgis/rest/services/SampleWorldCities/MapServer/export?bbox=" + a.ToString() + "%2C" + c.ToString() + "%2C" + b.ToString() + "%2C" + d.ToString() + "&bboxSR=&layers=&layerDefs=&size=&imageSR=&historicMoment=&format=png&transparent=false&dpi=&time=&timeRelation=esriTimeRelationOverlaps&layerTimeOptions=&dynamicLayers=&gdbVersion=&mapScale=&rotation=&datumTransformations=&layerParameterValues=&mapRangeValues=&layerRangeValues=&clipping=&spatialFilter=&f=image");
            pictureBox1.ImageLocation = myurl.ToString();
            this.Refresh();
        }

        private void east_Click(object sender, EventArgs e)
        {
            xmin += 0.2 * (xmax - xmin);
            xmax += 0.2 * (xmax - xmin);
            string a = xmin.ToString();
            string b = xmax.ToString();
            string c = ymin.ToString();
            string d = ymax.ToString();
            Uri myurl = new Uri("http://sampleserver6.arcgisonline.com/arcgis/rest/services/SampleWorldCities/MapServer/export?bbox=" + a.ToString() + "%2C" + c.ToString() + "%2C" + b.ToString() + "%2C" + d.ToString() + "&bboxSR=&layers=&layerDefs=&size=&imageSR=&historicMoment=&format=png&transparent=false&dpi=&time=&timeRelation=esriTimeRelationOverlaps&layerTimeOptions=&dynamicLayers=&gdbVersion=&mapScale=&rotation=&datumTransformations=&layerParameterValues=&mapRangeValues=&layerRangeValues=&clipping=&spatialFilter=&f=image");
            pictureBox1.ImageLocation = myurl.ToString();
            this.Refresh();
        }

        private void northwest_Click(object sender, EventArgs e)
        {
            xmin -= 0.2 * (xmax - xmin);
            xmax -= 0.2 * (xmax - xmin);
            ymin += 0.2 * (ymax - ymin);
            ymax += 0.2 * (ymax - ymin);
            string a = xmin.ToString();
            string b = xmax.ToString();
            string c = ymin.ToString();
            string d = ymax.ToString();
            Uri myurl = new Uri("http://sampleserver6.arcgisonline.com/arcgis/rest/services/SampleWorldCities/MapServer/export?bbox=" + a.ToString() + "%2C" + c.ToString() + "%2C" + b.ToString() + "%2C" + d.ToString() + "&bboxSR=&layers=&layerDefs=&size=&imageSR=&historicMoment=&format=png&transparent=false&dpi=&time=&timeRelation=esriTimeRelationOverlaps&layerTimeOptions=&dynamicLayers=&gdbVersion=&mapScale=&rotation=&datumTransformations=&layerParameterValues=&mapRangeValues=&layerRangeValues=&clipping=&spatialFilter=&f=image");
            pictureBox1.ImageLocation = myurl.ToString();
            this.Refresh();
        }

        private void northeast_Click(object sender, EventArgs e)
        {
            xmin += 0.2 * (xmax - xmin);
            xmax += 0.2 * (xmax - xmin);
            ymin += 0.2 * (ymax - ymin);
            ymax += 0.2 * (ymax - ymin);
            string a = xmin.ToString();
            string b = xmax.ToString();
            string c = ymin.ToString();
            string d = ymax.ToString();
            Uri myurl = new Uri("http://sampleserver6.arcgisonline.com/arcgis/rest/services/SampleWorldCities/MapServer/export?bbox=" + a.ToString() + "%2C" + c.ToString() + "%2C" + b.ToString() + "%2C" + d.ToString() + "&bboxSR=&layers=&layerDefs=&size=&imageSR=&historicMoment=&format=png&transparent=false&dpi=&time=&timeRelation=esriTimeRelationOverlaps&layerTimeOptions=&dynamicLayers=&gdbVersion=&mapScale=&rotation=&datumTransformations=&layerParameterValues=&mapRangeValues=&layerRangeValues=&clipping=&spatialFilter=&f=image");
            pictureBox1.ImageLocation = myurl.ToString();
            this.Refresh();
        }

        private void southwest_Click(object sender, EventArgs e)
        {
            xmin -= 0.2 * (xmax - xmin);
            xmax -= 0.2 * (xmax - xmin);
            ymin -= 0.2 * (ymax - ymin);
            ymax -= 0.2 * (ymax - ymin);
            string a = xmin.ToString();
            string b = xmax.ToString();
            string c = ymin.ToString();
            string d = ymax.ToString();
            Uri myurl = new Uri("http://sampleserver6.arcgisonline.com/arcgis/rest/services/SampleWorldCities/MapServer/export?bbox=" + a.ToString() + "%2C" + c.ToString() + "%2C" + b.ToString() + "%2C" + d.ToString() + "&bboxSR=&layers=&layerDefs=&size=&imageSR=&historicMoment=&format=png&transparent=false&dpi=&time=&timeRelation=esriTimeRelationOverlaps&layerTimeOptions=&dynamicLayers=&gdbVersion=&mapScale=&rotation=&datumTransformations=&layerParameterValues=&mapRangeValues=&layerRangeValues=&clipping=&spatialFilter=&f=image");
            pictureBox1.ImageLocation = myurl.ToString();
            this.Refresh();
        }

        private void southeast_Click(object sender, EventArgs e)
        {
            xmin += 0.2 * (xmax - xmin);
            xmax += 0.2 * (xmax - xmin);
            ymin -= 0.2 * (ymax - ymin);
            ymax -= 0.2 * (ymax - ymin);
            string a = xmin.ToString();
            string b = xmax.ToString();
            string c = ymin.ToString();
            string d = ymax.ToString();
            Uri myurl = new Uri("http://sampleserver6.arcgisonline.com/arcgis/rest/services/SampleWorldCities/MapServer/export?bbox=" + a.ToString() + "%2C" + c.ToString() + "%2C" + b.ToString() + "%2C" + d.ToString() + "&bboxSR=&layers=&layerDefs=&size=&imageSR=&historicMoment=&format=png&transparent=false&dpi=&time=&timeRelation=esriTimeRelationOverlaps&layerTimeOptions=&dynamicLayers=&gdbVersion=&mapScale=&rotation=&datumTransformations=&layerParameterValues=&mapRangeValues=&layerRangeValues=&clipping=&spatialFilter=&f=image");
            pictureBox1.ImageLocation = myurl.ToString();
            this.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X;
            y0 = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            double xx = Math.Abs(xmax - xmin) * (e.X - x0) / 400;
            double yy = Math.Abs(ymax - ymin) * (e.Y - y0) / 400;
            xmin -= xx;
            xmax -= xx;
            ymin += yy;
            ymax += yy;
            string a = xmin.ToString();
            string b = xmax.ToString();
            string c = ymin.ToString();
            string d = ymax.ToString();
            Uri myurl = new Uri("http://sampleserver6.arcgisonline.com/arcgis/rest/services/SampleWorldCities/MapServer/export?bbox=" + a.ToString() + "%2C" + c.ToString() + "%2C" + b.ToString() + "%2C" + d.ToString() + "&bboxSR=&layers=&layerDefs=&size=&imageSR=&historicMoment=&format=png&transparent=false&dpi=&time=&timeRelation=esriTimeRelationOverlaps&layerTimeOptions=&dynamicLayers=&gdbVersion=&mapScale=&rotation=&datumTransformations=&layerParameterValues=&mapRangeValues=&layerRangeValues=&clipping=&spatialFilter=&f=image");
            pictureBox1.ImageLocation = myurl.ToString();
            this.Refresh();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Focus();
        }

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {

            if (e.Delta >= 0)
            {
                xmin += 0.1 * (xmax - xmin);
                xmax -= 0.1 * (xmax - xmin);
                ymin += 0.1 * (ymax - ymin);
                ymax -= 0.1 * (ymax - ymin);
                string a = xmin.ToString();
                string b = xmax.ToString();
                string c = ymin.ToString();
                string d = ymax.ToString();
                Uri myurl = new Uri("http://sampleserver6.arcgisonline.com/arcgis/rest/services/SampleWorldCities/MapServer/export?bbox=" + a.ToString() + "%2C" + c.ToString() + "%2C" + b.ToString() + "%2C" + d.ToString() + "&bboxSR=&layers=&layerDefs=&size=&imageSR=&historicMoment=&format=png&transparent=false&dpi=&time=&timeRelation=esriTimeRelationOverlaps&layerTimeOptions=&dynamicLayers=&gdbVersion=&mapScale=&rotation=&datumTransformations=&layerParameterValues=&mapRangeValues=&layerRangeValues=&clipping=&spatialFilter=&f=image");
                pictureBox1.ImageLocation = myurl.ToString();
                this.Refresh();
            }
            else
            {
                xmin -= 0.125 * (xmax - xmin);
                xmax += 0.125 * (xmax - xmin);
                ymin -= 0.125 * (ymax - ymin);
                ymax += 0.125 * (ymax - ymin);
                string a = xmin.ToString();
                string b = xmax.ToString();
                string c = ymin.ToString();
                string d = ymax.ToString();
                Uri myurl = new Uri("http://sampleserver6.arcgisonline.com/arcgis/rest/services/SampleWorldCities/MapServer/export?bbox=" + a.ToString() + "%2C" + c.ToString() + "%2C" + b.ToString() + "%2C" + d.ToString() + "&bboxSR=&layers=&layerDefs=&size=&imageSR=&historicMoment=&format=png&transparent=false&dpi=&time=&timeRelation=esriTimeRelationOverlaps&layerTimeOptions=&dynamicLayers=&gdbVersion=&mapScale=&rotation=&datumTransformations=&layerParameterValues=&mapRangeValues=&layerRangeValues=&clipping=&spatialFilter=&f=image");
                pictureBox1.ImageLocation = myurl.ToString();
                this.Refresh();
            }
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            xo = (xmax + xmin) / 2;
            yo = (ymax + ymin) / 2;
            double xx = xmax - xmin;
            double yy = ymax - ymin;
            xo = (e.X * xx / 400) + xmin;
            yo = ymax - (e.Y * yy / 400);
            xmin = xo - 0.5 * xx;
            xmax = xo + 0.5 * xx;
            ymin = yo - 0.5 * yy;
            ymax = yo + 0.5 * yy;
            string a = xmin.ToString();
            string b = xmax.ToString();
            string c = ymin.ToString();
            string d = ymax.ToString();
            Uri myurl = new Uri("http://sampleserver6.arcgisonline.com/arcgis/rest/services/SampleWorldCities/MapServer/export?bbox=" + a.ToString() + "%2C" + c.ToString() + "%2C" + b.ToString() + "%2C" + d.ToString() + "&bboxSR=&layers=&layerDefs=&size=&imageSR=&historicMoment=&format=png&transparent=false&dpi=&time=&timeRelation=esriTimeRelationOverlaps&layerTimeOptions=&dynamicLayers=&gdbVersion=&mapScale=&rotation=&datumTransformations=&layerParameterValues=&mapRangeValues=&layerRangeValues=&clipping=&spatialFilter=&f=image");
            pictureBox1.ImageLocation = myurl.ToString();
            this.Refresh();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            xmin = -180;
            xmax = 180;
            ymin = -180;
            ymax = 180;
            string a = xmin.ToString();
            string b = xmax.ToString();
            string c = ymin.ToString();
            string d = ymax.ToString();
            Uri myurl = new Uri("http://sampleserver6.arcgisonline.com/arcgis/rest/services/SampleWorldCities/MapServer/export?bbox=" + a.ToString() + "%2C" + c.ToString() + "%2C" + b.ToString() + "%2C" + d.ToString() + "&bboxSR=&layers=&layerDefs=&size=&imageSR=&historicMoment=&format=png&transparent=false&dpi=&time=&timeRelation=esriTimeRelationOverlaps&layerTimeOptions=&dynamicLayers=&gdbVersion=&mapScale=&rotation=&datumTransformations=&layerParameterValues=&mapRangeValues=&layerRangeValues=&clipping=&spatialFilter=&f=image");
            pictureBox1.ImageLocation = myurl.ToString();
            this.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            location.Text = e.X + "," + e.Y + "," + xo + "," + yo + "," + xmin + "," + ymin + "," + xmax + "," + ymax;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string extent_ = "INIT=" + xmin.ToString() + "," + ymin.ToString() + "," + xmax.ToString() + "," + ymax.ToString();

            string outputPath = Application.StartupPath + "\\EXTENT.txt";
            System.IO.File.WriteAllText(outputPath, extent_);
        }

        private void json_Click(object sender, EventArgs e)
        {
            string allText = GeoJSONTextFromStream(constructJSONURL());
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt|Geojson files (*.geojson)|*.geojson|All files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, allText);
                MessageBox.Show("数据抓取已完成！");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 在Form_Load的时候检测一下，看看是否记录了地图范围，如果记录了，就读取并基于记录的范围初始化xmin,xmax,ymin,ymax
            string outputPath = Application.StartupPath + "\\EXTENT.txt";
            if (System.IO.File.Exists(outputPath)) //是否存在
            {
                string extent_ = System.IO.File.ReadAllText(outputPath);
                if (!string.IsNullOrEmpty(extent_)) //是否为空
                {
                    if (extent_.StartsWith("INIT=")) //是否我自己规定的格式
                    {
                        extent_ = extent_.Replace("INIT=", "");
                        string[] extentArray = extent_.Split(new char[] { ',' });
                        if (extentArray.Length > 3)
                        {
                            xmin = double.Parse(extentArray[0]);
                            ymin = double.Parse(extentArray[1]);
                            xmax = double.Parse(extentArray[2]);
                            ymax = double.Parse(extentArray[3]);
                        }
                    }
                }
            }
            //Image img_ = ImageFromWebTest(constructURL());
            //pictureBox1.Image = img_;
            //pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void saved_Click(object sender, EventArgs e)
        {
            string a = xmin.ToString();
            string b = xmax.ToString();
            string c = ymin.ToString();
            string d = ymax.ToString();
            Uri myurl = new Uri("http://sampleserver6.arcgisonline.com/arcgis/rest/services/SampleWorldCities/MapServer/export?bbox=" + a.ToString() + "%2C" + c.ToString() + "%2C" + b.ToString() + "%2C" + d.ToString() + "&bboxSR=&layers=&layerDefs=&size=&imageSR=&historicMoment=&format=png&transparent=false&dpi=&time=&timeRelation=esriTimeRelationOverlaps&layerTimeOptions=&dynamicLayers=&gdbVersion=&mapScale=&rotation=&datumTransformations=&layerParameterValues=&mapRangeValues=&layerRangeValues=&clipping=&spatialFilter=&f=image");
            pictureBox1.ImageLocation = myurl.ToString();
            this.Refresh();
        }

        DrawType _drawType = DrawType.None;

        private void line_Click(object sender, EventArgs e)
        {
            _drawType = DrawType.Line;
        }

        private void polyline_Click(object sender, EventArgs e)
        {
            _drawType = DrawType.Polyline;
        }

        private void polygon_Click(object sender, EventArgs e)
        {
            _drawType = DrawType.Polygon;
        }

        private void circle_Click(object sender, EventArgs e)
        {
            _drawType = DrawType.Circle;
        }

        private void sweep_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            pictureBox2.Refresh();
        }

        Line _line = null;
        Ellipse _Circle = null;
        //Point _firstPt;
        Polyline _pl = null;
        Polygon _pg = null;

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g1 = pictureBox2.CreateGraphics();
            Graphics g2 = pictureBox1.CreateGraphics();
            switch (_drawType)
            {
                case DrawType.None:
                    break;
                case DrawType.Line:
                    if (_line == null)
                    {
                        _line = new Line();
                        x1 = e.X;
                        y1 = e.Y;
                    }
                    else
                    {
                        x2 = e.X;
                        y2 = e.Y;
                        _line = null;
                        g1.DrawLine(System.Drawing.Pens.Red, x1, y1, x2, y2);
                        g2.DrawLine(System.Drawing.Pens.Red, x1, y1, x2, y2);
                    }
                    break;
                case DrawType.Circle:
                    if (_Circle == null)
                    {
                        _Circle = new Ellipse();
                        x1 = e.X;
                        y1 = e.Y;
                    }
                    else
                    {
                        x2 = e.X;
                        y2 = e.Y;
                        double r = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
                        float R = float.Parse(r.ToString());
                        float Width = 2 * R;
                        float Height = 2 * R;
                        _Circle = null;
                        g1.DrawEllipse(System.Drawing.Pens.Red, (x1 - R), (y1 - R), Width, Height);
                        g2.DrawEllipse(System.Drawing.Pens.Red, (x1 - R), (y1 - R), Width, Height);
                    }
                    break;
                case DrawType.Polyline:
                    _pl = new Polyline();
                    List<PointF> points1 = new List<PointF>();
                    points1.Add(new PointF(e.X, e.Y));
                    if (points1.Count > 1)
                        g1.DrawLines(System.Drawing.Pens.Red, points1.ToArray());
                    _pl = null;
                    break;
                case DrawType.Polygon:
                    _pg = new Polygon();
                    List<PointF> points2 = new List<PointF>();
                    points2.Add(new PointF(e.X, e.Y));
                    if (points2.Count > 1)
                        g1.DrawPolygon(System.Drawing.Pens.Red, points2.ToArray());
                    _pg = null;
                    break;
                default:
                    break;
            }
        }



        public Point pt { get; set; }

        public float myDouble { get; set; }

        List<System.Drawing.Rectangle> rects = new List<System.Drawing.Rectangle>();

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            string json_path = Application.StartupPath + "\\pt1.geojson";
            string json_content = System.IO.File.ReadAllText(json_path);

            JSONPointFeature abc = JsonConvert.DeserializeObject<JSONPointFeature>(json_content);

            System.Diagnostics.Debug.WriteLine(abc.type);


            JObject jo = JObject.Parse(json_content);

            JToken jt_features = jo["features"];

            for (int i = 0; i < jt_features.Count(); i++)
            {
                JToken j_t = jt_features[i];
                JToken j_tGeometry = j_t["geometry"];
                JToken j_pro = j_t["properties"];
                JToken j_tCoords = j_tGeometry["coordinates"];

                JToken j_pop = j_pro["Census2013"];
                double d_pop = Convert.ToDouble(j_pop.ToString());

                double x_ = Convert.ToDouble(j_tCoords[0].ToString());
                double y_ = Convert.ToDouble(j_tCoords[1].ToString());

                System.Diagnostics.Debug.WriteLine(x_.ToString() + "***" + y_.ToString());

                int x_int = Convert.ToInt32((x_ - xmin) / ((xmax - xmin) / this.Width));
                int y_int = Convert.ToInt32((ymax - y_) / ((ymax - ymin) / this.Height));

                System.Drawing.Rectangle rect_;

                //***课堂上的分级方法
                //if (d_pop < 1000)
                //{
                //    rect_ = new Rectangle(x_int, y_int, 10, 10);
                //}
                //else if (d_pop > 1000 && d_pop < 2000)
                //{
                //    rect_ = new Rectangle(x_int, y_int, 10, 40);
                //}
                //else
                //{
                //    rect_ = new Rectangle(x_int, y_int, 10, 60);
                //}

                //第二种数量表示方法

                rect_ = new System.Drawing.Rectangle(x_int, y_int, Convert.ToInt16(d_pop / 100), Convert.ToInt16(d_pop / 100));

                rects.Add(rect_);

            }

            Graphics gg = e.Graphics;
            Pen ppen = new Pen(Color.Orange);

            if (rects.Count > 0)
            {
                foreach (System.Drawing.Rectangle r in rects)
                {
                    gg.DrawRectangle(ppen, r);
                }
            }
            rects.Clear();
        }

    }

    public class JSONPointFeature
    {
        public string type { get; set; }
        public string name { get; set; }
        public List<JSONFeature> features { get; set; }

    }

    public class JSONFeature
    {
        public string type { get; set; }
        public object properties { get; set; }

        public JSONGEOMETRY geometry { get; set; }

    }

    public class JSONGEOMETRY
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }


}

