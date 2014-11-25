using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using IADAL;
using mshtml;
using SubSonic.Query;
using System.Windows.Forms.DataVisualization;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;


namespace IACollector {
    public partial class Form1 : Form {

        //cosine Analysis
        public List<HeadingvsHeadinginSamePageCosine> lwothAscending;
        public List<HeadingvsHeadinginSamePageCosine> lwothDescending;

        public List<HeadingvsHeadinginSamePageCosinesTUB> lwothTUBSAscending;
        public List<HeadingvsHeadinginSamePageCosinesTUB> lwothTUBSDescending;

        public List<LinkWithHeading> lwthAscending;
        public List<LinkWithHeading> lwthDescending;

        public List<LinkWithHeadingTUB> lwthTUBAscending;
        public List<LinkWithHeadingTUB> lwthTUBDescending;

        public List<CosineLinkLinkWithHeading> linklinkhdngAscending;
        public List<CosineLinkLinkWithHeading> linklinkhdngDescending;

        public List<CosineLinkLinkWithHeadingTUB> linklinkhdngTUBSAscending;
        public List<CosineLinkLinkWithHeadingTUB> linklinkhdngTUBSDescending;

        public List<CosineLinkLinkWithoutHeadingTUB> linklinkwothhdngTUBSAscending;
        public List<CosineLinkLinkWithoutHeadingTUB> linklinkwothhdngTUBSDescending;

        public List<Paragraph> paraAscending;
        public List<Paragraph> paraDescending;

        public List<ParagraphTUB> paraTUBSAscending;
        public List<ParagraphTUB> paraTUBSDescending;


        //TVL Analysis
        public List<LinkWithHeading> lwhTVLAscending;
        public List<LinkWithHeading> lwhTVLDescending;

        public List<LinkWithoutHeading> lwohTVLAscending;
        public List<LinkWithoutHeading> lwohTVLDescending;

        public List<LinkWithoutHeadingTUB> lwohTUBSTVLAscending;
        public List<LinkWithoutHeadingTUB> lwohTUBSTVLDescending;

        public List<Heading> hdngAscending;
        public List<Heading> hdngDescending;

        public List<HeadingTUBSTVL> hdngTUBSAscending;
        public List<HeadingTUBSTVL> hdngTUBSDescending;

        public List<LinkWithHeadingTUB> linkwithhdngTUBSAscending;
        public List<LinkWithHeadingTUB> linkwithhdngTUBSDescending;

        public String navigatedWebPageId = "";
        public String previousWebpageId = "";

        public String dropDown2SelectionText = "";

        public Form1() {


            //maximizing the display

            // WindowState = FormWindowState.Maximized;
            // FormBorderStyle = FormBorderStyle.None;
            // TopMost = true;

            InitializeComponent();


        }


        private void Form1_Load(object sender, EventArgs e) {


            // Folowing lines of code loads data into the tables. This is automatically generated code 
            this.headingTUBSTVLTableAdapter.Fill(this.infoArchDataSet1.HeadingTUBSTVL);
            this.headingTableAdapter.Fill(this.infoArchDataSet1.Heading);
            this.linkWithoutHeadingTUBSTableAdapter.Fill(this.infoArchDataSet1.LinkWithoutHeadingTUBS);
            this.linkWithoutHeadingTableAdapter.Fill(this.infoArchDataSet1.LinkWithoutHeading);
            this.paragraphTUBSTableAdapter.Fill(this.infoArchDataSet1.ParagraphTUBS);
            this.paragraphTableAdapter.Fill(this.infoArchDataSet1.Paragraph);
            this.cosineLinkLinkWithoutHeadingTUBSTableAdapter.Fill(this.infoArchDataSet1.CosineLinkLinkWithoutHeadingTUBS);
            this.cosineLinkLinkWithHeadingTUBSTableAdapter.Fill(this.infoArchDataSet1.CosineLinkLinkWithHeadingTUBS);
            this.cosineLinkLinkWithHeadingTableAdapter.Fill(this.infoArchDataSet1.CosineLinkLinkWithHeading);
            this.linkWithHeadingTUBSTableAdapter.Fill(this.infoArchDataSet1.LinkWithHeadingTUBS);
            this.linkWithHeadingTableAdapter.Fill(this.infoArchDataSet1.LinkWithHeading);
            this.headingvsHeadinginSamePageCosinesTUBSTableAdapter.Fill(this.infoArchDataSet1.HeadingvsHeadinginSamePageCosinesTUBS);
            this.headingvsHeadinginSamePageCosinesTableAdapter.Fill(this.infoArchDataSet1.HeadingvsHeadinginSamePageCosines);

            //loading values in combobox
            comboBox1.AllowDrop = true;
            comboBox1.Text = "Choose type of analysis";
            comboBox1.Items.Add("Cosine Analysis");
            comboBox1.Items.Add("Term Vector Length Analsyis");

            //hiding objects
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            webBrowser1.Visible = false;
            treeView1.Visible = false;


            webBrowser1.ScriptErrorsSuppressed = true;

            //settings for datagridview1
            dataGridView1.ReadOnly = true;
            dataGridView1.BackgroundColor = Color.Honeydew;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);


            dataGridView1.Name = "DataBase Information";
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.Teal;
            dataGridView1.Location = new System.Drawing.Point(406, 12);
            dataGridView1.Size = new System.Drawing.Size(481, 302);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            //for datagridview2
            dataGridView2.ReadOnly = true;
            dataGridView2.BackgroundColor = Color.Honeydew;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView2.Name = "DataBase Information";
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView2.GridColor = Color.Black;
            dataGridView2.Location = new System.Drawing.Point(406, 12);
            dataGridView2.Size = new System.Drawing.Size(481, 302);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //for datagridview3
            dataGridView3.ReadOnly = true;
            dataGridView3.BackgroundColor = Color.Honeydew;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView3.Name = "DataBase Information";
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView3.GridColor = Color.Black;
            dataGridView3.Location = new System.Drawing.Point(406, 12);
            dataGridView3.Size = new System.Drawing.Size(481, 302);
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //for datagridview4
            dataGridView4.ReadOnly = true;
            dataGridView4.BackgroundColor = Color.Honeydew;
            dataGridView4.BorderStyle = BorderStyle.None;
            dataGridView4.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView4.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView4.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView4.Name = "DataBase Information";
            dataGridView4.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView4.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView4.GridColor = Color.Black;
            dataGridView4.Location = new System.Drawing.Point(406, 12);
            dataGridView4.Size = new System.Drawing.Size(481, 302);
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            //for datagridview5
            dataGridView5.ReadOnly = true;
            dataGridView5.BackgroundColor = Color.Honeydew;
            dataGridView5.BorderStyle = BorderStyle.None;
            dataGridView5.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView5.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView5.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView5.Name = "DataBase Information";
            dataGridView5.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView5.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView5.GridColor = Color.Black;
            dataGridView5.Location = new System.Drawing.Point(406, 12);
            dataGridView5.Size = new System.Drawing.Size(481, 302);
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //for datagridview6
            dataGridView6.ReadOnly = true;
            dataGridView6.BackgroundColor = Color.Honeydew;
            dataGridView6.BorderStyle = BorderStyle.None;
            dataGridView6.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView6.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView6.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView6.Name = "DataBase Information";
            dataGridView6.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView6.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView6.GridColor = Color.Black;
            dataGridView6.Location = new System.Drawing.Point(406, 12);
            dataGridView6.Size = new System.Drawing.Size(481, 302);
            dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //for datagridview7
            dataGridView7.ReadOnly = true;
            dataGridView7.BackgroundColor = Color.Honeydew;
            dataGridView7.BorderStyle = BorderStyle.None;
            dataGridView7.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView7.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView7.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView7.Name = "DataBase Information";
            dataGridView7.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView7.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView7.GridColor = Color.Black;
            dataGridView7.Location = new System.Drawing.Point(406, 12);
            dataGridView7.Size = new System.Drawing.Size(481, 302);
            dataGridView7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //for datagridview8
            dataGridView8.ReadOnly = true;
            dataGridView8.BackgroundColor = Color.Honeydew;
            dataGridView8.BorderStyle = BorderStyle.None;
            dataGridView8.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView8.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView8.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView8.Name = "DataBase Information";
            dataGridView8.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView8.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView8.GridColor = Color.Black;
            dataGridView8.Location = new System.Drawing.Point(406, 12);
            dataGridView8.Size = new System.Drawing.Size(481, 302);
            dataGridView8.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            //for datagridview9
            dataGridView9.ReadOnly = true;
            dataGridView9.BackgroundColor = Color.Honeydew;
            dataGridView9.BorderStyle = BorderStyle.None;
            dataGridView9.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView9.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView9.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView9.Name = "DataBase Information";
            dataGridView9.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView9.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView9.GridColor = Color.Black;
            dataGridView9.Location = new System.Drawing.Point(406, 12);
            dataGridView9.Size = new System.Drawing.Size(481, 302);
            dataGridView9.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //for datagridview10
            dataGridView10.ReadOnly = true;
            dataGridView10.BackgroundColor = Color.Honeydew;
            dataGridView10.BorderStyle = BorderStyle.None;
            dataGridView10.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView10.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView10.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView10.Name = "DataBase Information";
            dataGridView10.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView10.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView10.GridColor = Color.Black;
            dataGridView10.Location = new System.Drawing.Point(406, 12);
            dataGridView10.Size = new System.Drawing.Size(481, 302);
            dataGridView10.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //for datagridview11
            dataGridView11.ReadOnly = true;
            dataGridView11.BackgroundColor = Color.Honeydew;
            dataGridView11.BorderStyle = BorderStyle.None;
            dataGridView11.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView11.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView11.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView11.Name = "DataBase Information";
            dataGridView11.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView11.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView11.GridColor = Color.Black;
            dataGridView11.Location = new System.Drawing.Point(406, 12);
            dataGridView11.Size = new System.Drawing.Size(481, 302);
            dataGridView11.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //for datagridview12
            dataGridView12.ReadOnly = true;
            dataGridView12.BackgroundColor = Color.Honeydew;
            dataGridView12.BorderStyle = BorderStyle.None;
            dataGridView12.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView12.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView12.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView12.Name = "DataBase Information";
            dataGridView12.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView12.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView12.GridColor = Color.Black;
            dataGridView12.Location = new System.Drawing.Point(406, 12);
            dataGridView12.Size = new System.Drawing.Size(481, 302);
            dataGridView12.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //for datagridview13
            dataGridView13.ReadOnly = true;
            dataGridView13.BackgroundColor = Color.Honeydew;
            dataGridView13.BorderStyle = BorderStyle.None;
            dataGridView13.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView13.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView13.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView13.Name = "DataBase Information";
            dataGridView13.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView13.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView13.GridColor = Color.Black;
            dataGridView13.Location = new System.Drawing.Point(406, 12);
            dataGridView13.Size = new System.Drawing.Size(481, 302);
            dataGridView13.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //for datagridview14
            dataGridView14.ReadOnly = true;
            dataGridView14.BackgroundColor = Color.Honeydew;
            dataGridView14.BorderStyle = BorderStyle.None;
            dataGridView14.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView14.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView14.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView14.Name = "DataBase Information";
            dataGridView14.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView14.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView14.GridColor = Color.Black;
            dataGridView14.Location = new System.Drawing.Point(406, 12);
            dataGridView14.Size = new System.Drawing.Size(481, 302);
            dataGridView14.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //for datagridview15
            dataGridView15.ReadOnly = true;
            dataGridView15.BackgroundColor = Color.Honeydew;
            dataGridView15.BorderStyle = BorderStyle.None;
            dataGridView15.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView15.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView15.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView15.Name = "DataBase Information";
            dataGridView15.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView15.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView15.GridColor = Color.Black;
            dataGridView15.Location = new System.Drawing.Point(406, 12);
            dataGridView15.Size = new System.Drawing.Size(481, 302);
            dataGridView15.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //hiding all the dataGirids as they overlap each other
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            dataGridView7.Visible = false;
            dataGridView8.Visible = false;
            dataGridView9.Visible = false;
            dataGridView10.Visible = false;
            dataGridView11.Visible = false;
            dataGridView12.Visible = false;
            dataGridView13.Visible = false;
            dataGridView14.Visible = false;
            dataGridView15.Visible = false;

            button1.Visible = false;



        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

            //when either the "cosine" or the "TVL" entry is selected in Combobox1 items listing changes in in combobox2
            if (comboBox1.SelectedItem.ToString() == "Cosine Analysis") {
                //MessageBox.Show("It is Cosine Analysis");

                comboBox2.Items.Clear();
                comboBox2.AllowDrop = true;
                comboBox2.Text = "Choose analysis Subtype";
                comboBox2.Items.Add("Heading with headings under same page for entire website Cosine");
                comboBox2.Items.Add("Heading with headings under same page for TUBS Cosine");
                comboBox2.Items.Add("Link with heading entire website Cosine");
                comboBox2.Items.Add("Link with heading TUBS Cosine");
                comboBox2.Items.Add("Link with all links under heading for entire website Cosine");
                comboBox2.Items.Add("Link with all links under heading for TUBS Cosine");
                comboBox2.Items.Add("Link with all links without heading for TUBS Cosine");
                comboBox2.Items.Add("Paragraph with heading for entire website Cosine");
                comboBox2.Items.Add("Paragraph with heading TUBS Cosine");

            }


            else if (comboBox1.SelectedItem.ToString() == "Term Vector Length Analsyis") {
                //MessageBox.Show("It is Term Vector Length Analsyis");
                comboBox2.Items.Clear();
                comboBox2.AllowDrop = true;
                comboBox2.Text = "Choose analysis Subtype";
                comboBox2.Items.Add("Links with heading for entire website TVL");
                comboBox2.Items.Add("Links without heading for entire website TVL");
                comboBox2.Items.Add("Links without heading TUBS TVL");
                comboBox2.Items.Add("Headings entire website TVL");
                comboBox2.Items.Add("Headings TUBS TVL");
                comboBox2.Items.Add("Links with heading TUBS TVL");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {

            label1.Visible = true;
            label1.ForeColor = Color.SteelBlue;
            label1.Text = "Load Analysis by Clicking WebPageID";
            label2.ForeColor = Color.Red;
            label3.ForeColor = Color.Blue;
            button1.Visible = true;

            webBrowser1.Visible = true;

            if (comboBox2.SelectedItem.ToString() == "Heading with headings under same page for entire website Cosine") {
                dropDown2SelectionText = "Heading with headings under same page for entire website Cosine";
                dataGridView2.Visible = false; dataGridView3.Visible = false; dataGridView4.Visible = false; dataGridView5.Visible = false; dataGridView6.Visible = false; dataGridView7.Visible = false; dataGridView8.Visible = false; dataGridView9.Visible = false; dataGridView10.Visible = false; dataGridView11.Visible = false; dataGridView12.Visible = false; dataGridView13.Visible = false; dataGridView14.Visible = false; dataGridView15.Visible = false;
                dataGridView1.Show();
            }

            else if (comboBox2.SelectedItem.ToString() == "Heading with headings under same page for TUBS Cosine") {
                dropDown2SelectionText = "Heading with headings under same page for TUBS Cosine";
                dataGridView1.Visible = false; dataGridView3.Visible = false; dataGridView4.Visible = false; dataGridView5.Visible = false; dataGridView6.Visible = false; dataGridView7.Visible = false; dataGridView8.Visible = false; dataGridView9.Visible = false; dataGridView10.Visible = false; dataGridView11.Visible = false; dataGridView12.Visible = false; dataGridView13.Visible = false; dataGridView14.Visible = false; dataGridView15.Visible = false;
                dataGridView2.Show();
            }

            else if (comboBox2.SelectedItem.ToString() == "Link with heading entire website Cosine") {
                dropDown2SelectionText = "Link with heading entire website Cosine";
                dataGridView1.Visible = false; dataGridView2.Visible = false; dataGridView4.Visible = false; dataGridView5.Visible = false; dataGridView6.Visible = false; dataGridView7.Visible = false; dataGridView8.Visible = false; dataGridView9.Visible = false; dataGridView10.Visible = false; dataGridView11.Visible = false; dataGridView12.Visible = false; dataGridView13.Visible = false; dataGridView14.Visible = false; dataGridView15.Visible = false;

                dataGridView3.Show();
            }

            else if (comboBox2.SelectedItem.ToString() == "Link with heading TUBS Cosine") {
                dropDown2SelectionText = "Link with heading TUBS Cosine";
                dataGridView1.Visible = false; dataGridView2.Visible = false; dataGridView3.Visible = false; dataGridView5.Visible = false; dataGridView6.Visible = false; dataGridView7.Visible = false; dataGridView8.Visible = false; dataGridView9.Visible = false; dataGridView10.Visible = false; dataGridView11.Visible = false; dataGridView12.Visible = false; dataGridView13.Visible = false; dataGridView14.Visible = false; dataGridView15.Visible = false;

                dataGridView4.Show();
            }

            else if (comboBox2.SelectedItem.ToString() == "Link with all links under heading for entire website Cosine") {
                dropDown2SelectionText = "Link with all links under heading for entire website Cosine";
                dataGridView1.Visible = false; dataGridView2.Visible = false; dataGridView3.Visible = false; dataGridView4.Visible = false; dataGridView6.Visible = false; dataGridView7.Visible = false; dataGridView8.Visible = false; dataGridView9.Visible = false; dataGridView10.Visible = false; dataGridView11.Visible = false; dataGridView12.Visible = false; dataGridView13.Visible = false; dataGridView14.Visible = false; dataGridView15.Visible = false;

                dataGridView5.Show();
            }


            else if (comboBox2.SelectedItem.ToString() == "Link with all links under heading for TUBS Cosine") {
                dropDown2SelectionText = "Link with all links under heading for TUBS Cosine";
                dataGridView1.Visible = false; dataGridView2.Visible = false; dataGridView3.Visible = false; dataGridView4.Visible = false; dataGridView5.Visible = false; dataGridView7.Visible = false; dataGridView8.Visible = false; dataGridView9.Visible = false; dataGridView10.Visible = false; dataGridView11.Visible = false; dataGridView12.Visible = false; dataGridView13.Visible = false; dataGridView14.Visible = false; dataGridView15.Visible = false;

                dataGridView6.Show();
            }

            else if (comboBox2.SelectedItem.ToString() == "Link with all links without heading for TUBS Cosine") {
                dropDown2SelectionText = "Link with all links without heading for TUBS Cosine";
                dataGridView1.Visible = false; dataGridView2.Visible = false; dataGridView3.Visible = false; dataGridView4.Visible = false; dataGridView5.Visible = false; dataGridView6.Visible = false; dataGridView8.Visible = false; dataGridView9.Visible = false; dataGridView10.Visible = false; dataGridView11.Visible = false; dataGridView12.Visible = false; dataGridView13.Visible = false; dataGridView14.Visible = false; dataGridView15.Visible = false;

                dataGridView7.Show();
            }

            else if (comboBox2.SelectedItem.ToString() == "Paragraph with heading for entire website Cosine") {
                dropDown2SelectionText = "Paragraph with heading for entire website Cosine";
                dataGridView1.Visible = false; dataGridView2.Visible = false; dataGridView3.Visible = false; dataGridView4.Visible = false; dataGridView5.Visible = false; dataGridView6.Visible = false; dataGridView7.Visible = false; dataGridView9.Visible = false; dataGridView10.Visible = false; dataGridView11.Visible = false; dataGridView12.Visible = false; dataGridView13.Visible = false; dataGridView14.Visible = false; dataGridView15.Visible = false;

                dataGridView8.Show();
            }

            else if (comboBox2.SelectedItem.ToString() == "Paragraph with heading TUBS Cosine") {
                dropDown2SelectionText = "Paragraph with heading TUBS Cosine";
                dataGridView1.Visible = false; dataGridView2.Visible = false; dataGridView3.Visible = false; dataGridView4.Visible = false; dataGridView5.Visible = false; dataGridView6.Visible = false; dataGridView7.Visible = false; dataGridView8.Visible = false; dataGridView10.Visible = false; dataGridView11.Visible = false; dataGridView12.Visible = false; dataGridView13.Visible = false; dataGridView14.Visible = false; dataGridView15.Visible = false;

                dataGridView9.Show();
            }


            else if (comboBox2.SelectedItem.ToString() == "Links with heading for entire website TVL") {
                dropDown2SelectionText = "Links with heading for entire website TVL";
                dataGridView1.Visible = false; dataGridView2.Visible = false; dataGridView3.Visible = false; dataGridView4.Visible = false; dataGridView5.Visible = false; dataGridView6.Visible = false; dataGridView7.Visible = false; dataGridView8.Visible = false; dataGridView9.Visible = false; dataGridView11.Visible = false; dataGridView12.Visible = false; dataGridView13.Visible = false; dataGridView14.Visible = false; dataGridView15.Visible = false;

                dataGridView10.Show();
            }


            else if (comboBox2.SelectedItem.ToString() == "Links without heading for entire website TVL") {
                dropDown2SelectionText = "Links without heading for entire website TVL";
                dataGridView1.Visible = false; dataGridView2.Visible = false; dataGridView3.Visible = false; dataGridView4.Visible = false; dataGridView5.Visible = false; dataGridView6.Visible = false; dataGridView7.Visible = false; dataGridView8.Visible = false; dataGridView9.Visible = false; dataGridView10.Visible = false; dataGridView12.Visible = false; dataGridView13.Visible = false; dataGridView14.Visible = false; dataGridView15.Visible = false;

                dataGridView11.Show();
            }

            else if (comboBox2.SelectedItem.ToString() == "Links without heading TUBS TVL") {
                dropDown2SelectionText = "Links without heading TUBS TVL";
                dataGridView1.Visible = false; dataGridView2.Visible = false; dataGridView3.Visible = false; dataGridView4.Visible = false; dataGridView5.Visible = false; dataGridView6.Visible = false; dataGridView7.Visible = false; dataGridView8.Visible = false; dataGridView9.Visible = false; dataGridView10.Visible = false; dataGridView11.Visible = false; dataGridView13.Visible = false; dataGridView14.Visible = false; dataGridView15.Visible = false;

                dataGridView12.Show();
            }

            else if (comboBox2.SelectedItem.ToString() == "Headings entire website TVL") {
                dropDown2SelectionText = "Headings entire website TVL";
                dataGridView1.Visible = false; dataGridView2.Visible = false; dataGridView3.Visible = false; dataGridView4.Visible = false; dataGridView5.Visible = false; dataGridView6.Visible = false; dataGridView7.Visible = false; dataGridView8.Visible = false; dataGridView9.Visible = false; dataGridView10.Visible = false; dataGridView11.Visible = false; dataGridView12.Visible = false; dataGridView14.Visible = false; dataGridView15.Visible = false;

                dataGridView13.Show();
            }

            else if (comboBox2.SelectedItem.ToString() == "Headings TUBS TVL") {
                dropDown2SelectionText = "Headings TUBS TVL";
                dataGridView1.Visible = false; dataGridView2.Visible = false; dataGridView3.Visible = false; dataGridView4.Visible = false; dataGridView5.Visible = false; dataGridView6.Visible = false; dataGridView7.Visible = false; dataGridView8.Visible = false; dataGridView9.Visible = false; dataGridView10.Visible = false; dataGridView11.Visible = false; dataGridView12.Visible = false; dataGridView13.Visible = false; dataGridView15.Visible = false;


                dataGridView14.Show();
            }

            else if (comboBox2.SelectedItem.ToString() == "Links with heading TUBS TVL") {
                dropDown2SelectionText = "Links with heading TUBS TVL";
                dataGridView1.Visible = false; dataGridView2.Visible = false; dataGridView3.Visible = false; dataGridView4.Visible = false; dataGridView5.Visible = false; dataGridView6.Visible = false; dataGridView7.Visible = false; dataGridView8.Visible = false; dataGridView9.Visible = false; dataGridView10.Visible = false; dataGridView11.Visible = false; dataGridView12.Visible = false; dataGridView13.Visible = false; dataGridView14.Visible = false;

                dataGridView15.Show();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            dataGridView1.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.Automatic;

            //Return if column headers were clicked
            if (e.RowIndex == -1) {
                return;
            }
            //only handle the clicks from webpageID column
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {
                String webpageId = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                WebPage wp = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webpageId));

                if (wp != null) {
                    webBrowser1.Navigate("file:///C:/AliTeesInternetWebpages/newpages/" + wp.WebPageId + ".html");
                }

            }

            /*
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("headingid")) {

                String he = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                WebPage wp = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webpageId));
                Form2 f2 = new Form2();
               f2.fillDataGridView( 
            
            }
                 */

        }


        private void webBrowser1_Navigating_1(object sender, WebBrowserNavigatingEventArgs e) {
            if (e.Url.ToString().Contains("about:blank") || e.Url.ToString().Contains("www") || e.Url.ToString().Contains("http") || e.Url.AbsoluteUri.Contains("@")) {
                e.Cancel = true;
                //webBrowser1.Stop();
                //webBrowser1.Refresh();
            }

            else {

                int x = e.Url.AbsoluteUri.LastIndexOf('/');
                int y = e.Url.AbsoluteUri.LastIndexOf(".html");
                navigatedWebPageId = e.Url.AbsoluteUri.Substring(e.Url.AbsoluteUri.LastIndexOf('/') + 1);
                navigatedWebPageId = navigatedWebPageId.Remove(navigatedWebPageId.IndexOf(".html"));

            }
        }



        public void populateTreeView(int navigatedWebPageId) {

            treeView1.Nodes.Clear();

            TreeNode headingTVLNode = treeView1.Nodes.Add("Heading TVL");
            TreeNode LinkWithHeadingTVLNode = treeView1.Nodes.Add("Link Under Heading TVL");
            TreeNode LinkWithoutHeadingTVLNode = treeView1.Nodes.Add("Link Without Heading TVL");
            TreeNode LinkwitHeadingCosineNode = treeView1.Nodes.Add("Link With Heading Cosine");
            TreeNode HeadingwitHeadingCosineNode = treeView1.Nodes.Add("Heading With Headings Under Same Page Cosine");
            TreeNode LinkWithAllLinksUnderHeadignCosineNode = treeView1.Nodes.Add("Link With All Links Under Heading Cosine");
            TreeNode LinkWithLinkWithoutHeadingCosineNode = treeView1.Nodes.Add("TUBS pages only - Link With All Links Without Heading Cosine");
            TreeNode paragraphWithHeadingCosineNode = treeView1.Nodes.Add("Paragraph With Heading Cosine");


            List<Heading> hdng = Heading.All().Where(x => x.WebPageId == navigatedWebPageId).ToList();
            for (int i = 0; i < hdng.Count; i++) {
                headingTVLNode.Nodes.Add(hdng[i].VectorTermLength.ToString() + " = " + hdng[i].HeadingText.ToString());
            }


            List<LinkWithHeading> linkwithhdng = LinkWithHeading.All().Where(x => x.WebPageId == navigatedWebPageId).ToList();
            for (int i = 0; i < linkwithhdng.Count; i++) {
                LinkWithHeadingTVLNode.Nodes.Add(linkwithhdng[i].VectorTermLength.ToString() + " = " + linkwithhdng[i].LinkAnchorText.ToString());
            }


            //Those links without any heading TVL
            List<LinkWithoutHeading> linkwithouthdng = LinkWithoutHeading.All().Where(x => x.WebPageId == navigatedWebPageId).ToList();
            for (int i = 0; i < linkwithouthdng.Count; i++) {
                LinkWithoutHeadingTVLNode.Nodes.Add(linkwithouthdng[i].VectorTermLength.ToString() + " = " + linkwithouthdng[i].LinkAnchorText.ToString());
            }


            //link with its heading Cosines

            for (int i = 0; i < linkwithhdng.Count; i++) {
                Heading temphdng = Heading.SingleOrDefault(x => x.HeadingId == linkwithhdng[i].HeadingId);
                LinkwitHeadingCosineNode.Nodes.Add(linkwithhdng[i].CosineValueLinkHeading.ToString() + " = " + linkwithhdng[i].LinkAnchorText.ToString() + " vs " + temphdng.HeadingText);
            }

            List<HeadingvsHeadinginSamePageCosine> hdnghdngSamePage = HeadingvsHeadinginSamePageCosine.All().Where(x => x.WebpageId == navigatedWebPageId).ToList();
            for (int i = 0; i < hdnghdngSamePage.Count; i++) {
                HeadingwitHeadingCosineNode.Nodes.Add(hdnghdngSamePage[i].CosineValueHeadingvsHeading.ToString() + " = " + hdnghdngSamePage[i].HeadingXLinkText + " vs " + hdnghdngSamePage[i].HeadingYLInkText);
            }

            List<CosineLinkLinkWithHeading> cosineLinkLinkWithHeading = CosineLinkLinkWithHeading.All().Where(x => x.WebpageId == navigatedWebPageId).ToList();
            for (int i = 0; i < cosineLinkLinkWithHeading.Count; i++) {

                String LinkXText = linkwithhdng.SingleOrDefault(x => x.LinkId == cosineLinkLinkWithHeading[i].LinkXId).ToString();
                String LinkYText = linkwithhdng.SingleOrDefault(x => x.LinkId == cosineLinkLinkWithHeading[i].LinkYId).ToString();
                LinkWithAllLinksUnderHeadignCosineNode.Nodes.Add(cosineLinkLinkWithHeading[i].CosineValueLinkLinkWithHeading.ToString() + " = " + LinkXText + " vs " + LinkYText);
            }


            List<CosineLinkLinkWithoutHeadingTUB> cosineLinkLinkWithoutHeadingTUB = CosineLinkLinkWithoutHeadingTUB.All().Where(x => x.WebPageId == navigatedWebPageId).ToList();
            for (int i = 0; i < cosineLinkLinkWithoutHeadingTUB.Count; i++) {

                String LinkXText = linkwithouthdng.SingleOrDefault(x => x.LinkId == cosineLinkLinkWithoutHeadingTUB[i].LinkXId).ToString();
                String LinkYText = linkwithouthdng.SingleOrDefault(x => x.LinkId == cosineLinkLinkWithoutHeadingTUB[i].LinkYId).ToString();
                LinkWithLinkWithoutHeadingCosineNode.Nodes.Add(cosineLinkLinkWithHeading[i].CosineValueLinkLinkWithHeading.ToString() + " = " + LinkXText + " vs " + LinkYText);
            }


            List<Paragraph> para = Paragraph.All().Where(x => x.WebPageId == navigatedWebPageId).ToList();
            for (int i = 0; i < para.Count; i++) {
                Heading tempparahdng = Heading.SingleOrDefault(x => x.HeadingId == para[i].HeadingId);
                paragraphWithHeadingCosineNode.Nodes.Add(para[i].CosineValueParagraphHeading.ToString() + " = " + para[i].ParaText.ToString() + " vs " + tempparahdng.HeadingText);
            }




        }


        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e) {

            treeView1.Visible = true;


            //thefollowing if check blocks multiple loads of the same pageID
            if (previousWebpageId == "" || previousWebpageId != navigatedWebPageId) {
                populateTreeView(int.Parse(navigatedWebPageId));
                previousWebpageId = navigatedWebPageId;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            //Return if column headers were clicked
            if (e.RowIndex == -1) {
                return;
            }

            if (dataGridView2.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {
                String webpageId = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                WebPage wp = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webpageId));
                if (wp != null) {
                    webBrowser1.Navigate("file:///C:/AliTeesInternetWebpages/newpages/" + wp.WebPageId + ".html");
                }
            }

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //Return if column headers were clicked
            if (e.RowIndex == -1) {
                return;
            }
            if (dataGridView3.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {
                String webpageId = dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                WebPage wp = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webpageId));
                if (wp != null) {
                    webBrowser1.Navigate("file:///C:/AliTeesInternetWebpages/newpages/" + wp.WebPageId + ".html");
                }
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //Return if column headers were clicked
            if (e.RowIndex == -1) {
                return;
            }
            if (dataGridView4.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {
                String webpageId = dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                WebPage wp = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webpageId));
                if (wp != null) {
                    webBrowser1.Navigate("file:///C:/AliTeesInternetWebpages/newpages/" + wp.WebPageId + ".html");
                }
            }
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //Return if column headers were clicked
            if (e.RowIndex == -1) {
                return;
            }
            if (dataGridView5.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {
                String webpageId = dataGridView5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                WebPage wp = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webpageId));
                if (wp != null) {
                    webBrowser1.Navigate("file:///C:/AliTeesInternetWebpages/newpages/" + wp.WebPageId + ".html");
                }
            }
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //Return if column headers were clicked
            if (e.RowIndex == -1) {
                return;
            }
            if (dataGridView6.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {
                String webpageId = dataGridView6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                WebPage wp = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webpageId));
                if (wp != null) {
                    webBrowser1.Navigate("file:///C:/AliTeesInternetWebpages/newpages/" + wp.WebPageId + ".html");
                }
            }
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //Return if column headers were clicked
            if (e.RowIndex == -1) {
                return;
            }
            if (dataGridView7.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {
                String webpageId = dataGridView7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                WebPage wp = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webpageId));
                if (wp != null) {
                    webBrowser1.Navigate("file:///C:/AliTeesInternetWebpages/newpages/" + wp.WebPageId + ".html");
                }
            }
        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //Return if column headers were clicked
            if (e.RowIndex == -1) {
                return;
            }
            if (dataGridView8.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {
                String webpageId = dataGridView8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                WebPage wp = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webpageId));
                if (wp != null) {
                    webBrowser1.Navigate("file:///C:/AliTeesInternetWebpages/newpages/" + wp.WebPageId + ".html");
                }
            }
        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //Return if column headers were clicked
            if (e.RowIndex == -1) {
                return;
            }
            if (dataGridView9.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {
                String webpageId = dataGridView9.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                WebPage wp = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webpageId));
                if (wp != null) {
                    webBrowser1.Navigate("file:///C:/AliTeesInternetWebpages/newpages/" + wp.WebPageId + ".html");
                }
            }
        }

        private void dataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //Return if column headers were clicked
            if (e.RowIndex == -1) {
                return;
            }
            if (dataGridView10.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {
                String webpageId = dataGridView10.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                WebPage wp = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webpageId));
                if (wp != null) {
                    webBrowser1.Navigate("file:///C:/AliTeesInternetWebpages/newpages/" + wp.WebPageId + ".html");
                }
            }
        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //Return if column headers were clicked
            if (e.RowIndex == -1) {
                return;
            }
            if (dataGridView11.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {
                String webpageId = dataGridView11.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                WebPage wp = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webpageId));
                if (wp != null) {
                    webBrowser1.Navigate("file:///C:/AliTeesInternetWebpages/newpages/" + wp.WebPageId + ".html");
                }
            }
        }

        private void dataGridView12_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //Return if column headers were clicked
            if (e.RowIndex == -1) {
                return;
            }
            if (dataGridView12.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {
                String webpageId = dataGridView12.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                WebPage wp = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webpageId));
                if (wp != null) {
                    webBrowser1.Navigate("file:///C:/AliTeesInternetWebpages/newpages/" + wp.WebPageId + ".html");
                }
            }
        }

        private void dataGridView13_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //Return if column headers were clicked
            if (e.RowIndex == -1) {
                return;
            }
            if (dataGridView13.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {
                String webpageId = dataGridView13.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                WebPage wp = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webpageId));
                if (wp != null) {
                    webBrowser1.Navigate("file:///C:/AliTeesInternetWebpages/newpages/" + wp.WebPageId + ".html");
                }
            }
        }

        private void dataGridView14_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //Return if column headers were clicked
            if (e.RowIndex == -1) {
                return;
            }
            if (dataGridView14.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {
                String webpageId = dataGridView14.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                WebPage wp = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webpageId));
                if (wp != null) {
                    webBrowser1.Navigate("file:///C:/AliTeesInternetWebpages/newpages/" + wp.WebPageId + ".html");
                }
            }
        }

        private void dataGridView15_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //Return if column headers were clicked
            if (e.RowIndex == -1) {
                return;
            }
            if (dataGridView15.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {
                String webpageId = dataGridView15.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                WebPage wp = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webpageId));
                if (wp != null) {
                    webBrowser1.Navigate("file:///C:/AliTeesInternetWebpages/newpages/" + wp.WebPageId + ".html");
                }
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e) {

            dataGridView1[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Green;
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e) {

            dataGridView2[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Green;
        }

        private void dataGridView2_CellLeave(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView2.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
        }



        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView3[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Green;
        }

        private void dataGridView3_CellLeave(object sender, DataGridViewCellEventArgs e) {
            dataGridView3.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;

        }

        private void dataGridView4_CellEnter(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView4[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Green;
        }

        private void dataGridView4_CellLeave(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView4.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
        }

        private void dataGridView5_CellEnter(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView5[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Green;
        }

        private void dataGridView5_CellLeave(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView5.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
        }

        private void dataGridView6_CellEnter(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView6[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Green;
        }

        private void dataGridView6_CellLeave(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView6.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
        }

        private void dataGridView7_CellEnter(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView7[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Green;
        }

        private void dataGridView7_CellLeave(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView7.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
        }

        private void dataGridView8_CellEnter(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView8[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Green;
        }

        private void dataGridView8_CellLeave(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView8.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
        }

        private void dataGridView9_CellEnter(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView9[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Green;
        }

        private void dataGridView9_CellLeave(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView9.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
        }


        private void dataGridView10_CellEnter(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView10[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Green;
        }

        private void dataGridView10_CellLeave(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView10.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
        }

        private void dataGridView11_CellEnter(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView11[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Green;
        }

        private void dataGridView11_CellLeave(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView11.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
        }

        private void dataGridView12_CellEnter(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView12[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Green;
        }

        private void dataGridView12_CellLeave(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView12.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
        }

        private void dataGridView13_CellEnter(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView13[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Green;
        }

        private void dataGridView13_CellLeave(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView13.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
        }

        private void dataGridView14_CellEnter(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView14[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Green;
        }

        private void dataGridView14_CellLeave(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView14.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
        }

        private void dataGridView15_CellEnter(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView15[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Green;
        }

        private void dataGridView15_CellLeave(object sender, DataGridViewCellEventArgs e) {
            this.dataGridView15.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
        }


        private void dataGridView2_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e) {

            //Return if column headers were clicked
            if (e.RowIndex == -1 || e.ColumnIndex == -1 || dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value==null ) {
                return;
            }
            //MessageBox.Show(dataGridView2.Columns[e.ColumnIndex].ToString());

            if (dataGridView2.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("head") && dataGridView2.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("id")) {

                String hdngId = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!String.IsNullOrEmpty(hdngId)) {
                    Heading hdngToolTip = Heading.SingleOrDefault(x => x.HeadingId == int.Parse(hdngId));

                    if (hdngToolTip != null) {

                        dataGridView2.Columns[e.ColumnIndex].ToolTipText = hdngToolTip.HeadingText.ToString();
                        label2.Visible = true;
                        label2.Text = hdngToolTip.HeadingText.ToString();

                    }
                }
            }



            if (dataGridView2.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {

               
                    String webId = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    if (!String.IsNullOrEmpty(webId)) {
                        WebPage webToolTip = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webId));

                        if (webToolTip != null) {

                            dataGridView2.Columns[e.ColumnIndex].ToolTipText = webToolTip.Title.ToString();
                            label3.Visible = true;
                            label3.Text = webToolTip.Title.ToString();

                        }
                    }
               



            }

        }

        private void dataGridView3_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e) {
            //Return if column headers were clicked
            if (e.RowIndex == -1 || e.ColumnIndex == -1 || dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) {
                return;
            }
            //MessageBox.Show(dataGridView2.Columns[e.ColumnIndex].ToString());

            if (dataGridView3.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("head") && dataGridView3.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("id")) {

                String hdngId = dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!String.IsNullOrEmpty(hdngId)) {
                    Heading hdngToolTip = Heading.SingleOrDefault(x => x.HeadingId == int.Parse(hdngId));

                    if (hdngToolTip != null) {

                        dataGridView3.Columns[e.ColumnIndex].ToolTipText = hdngToolTip.HeadingText.ToString();
                        label2.Visible = true;
                        label2.Text = hdngToolTip.HeadingText.ToString();

                    }
                }

            }

            if (dataGridView3.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {

                String webId = dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!String.IsNullOrEmpty(webId)) {
                    WebPage webToolTip = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webId));

                    if (webToolTip != null) {

                        dataGridView3.Columns[e.ColumnIndex].ToolTipText = webToolTip.Title.ToString();
                        label3.Visible = true;
                        label3.Text = webToolTip.Title.ToString();

                    }
                }

            }


        }

        private void dataGridView4_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e) {
            //Return if column headers were clicked
            if (e.RowIndex == -1 || e.ColumnIndex == -1 || dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) {
                return;
            }
            //MessageBox.Show(dataGridView2.Columns[e.ColumnIndex].ToString());

            if (dataGridView4.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("head") && dataGridView4.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("id") ) {

                String hdngId = dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!String.IsNullOrEmpty(hdngId)) {
                    Heading hdngToolTip = Heading.SingleOrDefault(x => x.HeadingId == int.Parse(hdngId));

                    if (hdngToolTip != null) {

                        dataGridView4.Columns[e.ColumnIndex].ToolTipText = hdngToolTip.HeadingText.ToString();
                        label2.Visible = true;
                        label2.Text = hdngToolTip.HeadingText.ToString();

                    }
                }
            }

            if (dataGridView4.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {

                String webId = dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!String.IsNullOrEmpty(webId)) {
                    WebPage webToolTip = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webId));

                    if (webToolTip != null) {

                        dataGridView4.Columns[e.ColumnIndex].ToolTipText = webToolTip.Title.ToString();
                        label3.Visible = true;
                        label3.Text = webToolTip.Title.ToString();

                    }
                }

            }


        }

        private void dataGridView10_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e) {
            //Return if column headers were clicked
            if (e.RowIndex == -1 || e.ColumnIndex == -1 || dataGridView10.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) {
                return;
            }
            //MessageBox.Show(dataGridView2.Columns[e.ColumnIndex].ToString());

            if (dataGridView10.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("head") && dataGridView10.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("id")) {

                String hdngId = dataGridView10.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!String.IsNullOrEmpty(hdngId)) {
                    Heading hdngToolTip = Heading.SingleOrDefault(x => x.HeadingId == int.Parse(hdngId));

                    if (hdngToolTip != null) {

                        dataGridView10.Columns[e.ColumnIndex].ToolTipText = hdngToolTip.HeadingText.ToString();
                        label2.Visible = true;
                        label2.Text = hdngToolTip.HeadingText.ToString();

                    }
                }

            }
            if (dataGridView10.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {

                String webId = dataGridView10.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!String.IsNullOrEmpty(webId)) {
                    WebPage webToolTip = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webId));

                    if (webToolTip != null) {

                        dataGridView10.Columns[e.ColumnIndex].ToolTipText = webToolTip.Title.ToString();
                        label3.Visible = true;
                        label3.Text = webToolTip.Title.ToString();

                    }

                }

            }

        }

        private void dataGridView15_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e) {
            //Return if column headers were clicked
            if (e.RowIndex == -1 || e.ColumnIndex == -1 || dataGridView15.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) {
                return;
            }
            //MessageBox.Show(dataGridView2.Columns[e.ColumnIndex].ToString());

            if (dataGridView15.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("head") && dataGridView15.Columns[e.ColumnIndex].HeaderText.ToLower().Contains("id")) {

                String hdngId = dataGridView15.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!String.IsNullOrEmpty(hdngId)) {
                    Heading hdngToolTip = Heading.SingleOrDefault(x => x.HeadingId == int.Parse(hdngId));

                    if (hdngToolTip != null) {

                        dataGridView15.Columns[e.ColumnIndex].ToolTipText = hdngToolTip.HeadingText.ToString();
                        label3.Visible = true;
                        label3.Text = hdngToolTip.HeadingText.ToString();

                    }
                }

            }
            if (dataGridView15.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {

                String webId = dataGridView15.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!String.IsNullOrEmpty(webId)) {
                    WebPage webToolTip = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webId));

                    if (webToolTip != null) {

                        dataGridView15.Columns[e.ColumnIndex].ToolTipText = webToolTip.Title.ToString();
                        label3.Visible = true;
                        label3.Text = webToolTip.Title.ToString();

                    }
                }

            }

        }

        private void dataGridView1_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e) {

            if (e.RowIndex == -1 || e.ColumnIndex == -1 || dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) {
                return;
            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {

                String webId = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!String.IsNullOrEmpty(webId)) {
                    WebPage webToolTip = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webId));

                    if (webToolTip != null) {

                        dataGridView11.Columns[e.ColumnIndex].ToolTipText = webToolTip.Title.ToString();
                        label2.Visible = true;
                        label2.Text = webToolTip.Title.ToString();

                    }
                }

            }
        }

        private void dataGridView5_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e) {
            if (e.RowIndex == -1 || e.ColumnIndex == -1 || dataGridView5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) {
                return;
            }
            if (dataGridView5.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {

                String webId = dataGridView5.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!String.IsNullOrEmpty(webId)) {
                    WebPage webToolTip = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webId));

                    if (webToolTip != null) {

                        dataGridView5.Columns[e.ColumnIndex].ToolTipText = webToolTip.Title.ToString();
                        label3.Visible = true;
                        label3.Text = webToolTip.Title.ToString();

                    }
                }

            }
        }

        private void dataGridView6_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e) {
            if (e.RowIndex == -1 || e.ColumnIndex == -1 || dataGridView6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) {
                return;
            }
            if (dataGridView6.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {

                String webId = dataGridView6.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!String.IsNullOrEmpty(webId)) {
                    WebPage webToolTip = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webId));

                    if (webToolTip != null) {

                        dataGridView6.Columns[e.ColumnIndex].ToolTipText = webToolTip.Title.ToString();
                        label2.Visible = true;
                        label2.Text = webToolTip.Title.ToString();

                    }

                }

            }
        }

        private void dataGridView7_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e) {

            if (e.RowIndex == -1 || e.ColumnIndex == -1 || dataGridView7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) {
                return;
            }
            if (dataGridView7.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {

                String webId = dataGridView7.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!String.IsNullOrEmpty(webId)) {
                    WebPage webToolTip = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webId));

                    if (webToolTip != null) {

                        dataGridView7.Columns[e.ColumnIndex].ToolTipText = webToolTip.Title.ToString();
                        label3.Visible = true;
                        label3.Text = webToolTip.Title.ToString();

                    }
                }

            }
        }

        private void dataGridView8_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e) {
            if (e.RowIndex == -1 || e.ColumnIndex == -1 || dataGridView8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) {
                return;
            }
            if (dataGridView8.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {

                String webId = dataGridView8.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!String.IsNullOrEmpty(webId)) {
                    WebPage webToolTip = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webId));

                    if (webToolTip != null) {

                        dataGridView8.Columns[e.ColumnIndex].ToolTipText = webToolTip.Title.ToString();
                        label3.Visible = true;
                        label3.Text = webToolTip.Title.ToString();

                    }
                }

            }
        }

        private void dataGridView9_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e) {
            if (e.RowIndex == -1 || e.ColumnIndex == -1 || dataGridView9.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) {
                return;
            }
            if (dataGridView9.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {

                String webId = dataGridView9.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!String.IsNullOrEmpty(webId)) {
                    WebPage webToolTip = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webId));

                    if (webToolTip != null) {

                        dataGridView9.Columns[e.ColumnIndex].ToolTipText = webToolTip.Title.ToString();
                        label2.Visible = true;
                        label2.Text = webToolTip.Title.ToString();

                    }
                }

            }
        }

        private void dataGridView11_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e) {
            if (e.RowIndex == -1 || e.ColumnIndex == -1 || dataGridView11.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) {
                return;
            }
            if (dataGridView11.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {

                String webId = dataGridView11.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!String.IsNullOrEmpty(webId)) {
                    WebPage webToolTip = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webId));

                    if (webToolTip != null) {

                        dataGridView11.Columns[e.ColumnIndex].ToolTipText = webToolTip.Title.ToString();
                        label3.Visible = true;
                        label3.Text = webToolTip.Title.ToString();

                    }
                }

            }
        }

        private void dataGridView12_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e) {
            if (e.RowIndex == -1 || e.ColumnIndex == -1 || dataGridView12.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) {
                return;
            }
            if (dataGridView12.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {

                String webId = dataGridView12.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!String.IsNullOrEmpty(webId)) {
                    WebPage webToolTip = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webId));

                    if (webToolTip != null) {

                        dataGridView12.Columns[e.ColumnIndex].ToolTipText = webToolTip.Title.ToString();
                        label3.Visible = true;
                        label3.Text = webToolTip.Title.ToString();

                    }
                }

            }
        }

        private void dataGridView13_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e) {
            if (e.RowIndex == -1 || e.ColumnIndex == -1 || dataGridView13.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) {
                return;
            }
            if (dataGridView13.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {

                String webId = dataGridView13.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!String.IsNullOrEmpty(webId)) {
                    WebPage webToolTip = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webId));

                    if (webToolTip != null) {

                        dataGridView13.Columns[e.ColumnIndex].ToolTipText = webToolTip.Title.ToString();
                        label3.Visible = true;
                        label3.Text = webToolTip.Title.ToString();

                    }
                }

            }
        }

        private void dataGridView14_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e) {
            if (e.RowIndex == -1 || e.ColumnIndex == -1 || dataGridView14.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) {
                return;
            }
            if (dataGridView14.Columns[e.ColumnIndex].HeaderText.ToLower().StartsWith("web")) {

                String webId = dataGridView14.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!String.IsNullOrEmpty(webId)) {
                    WebPage webToolTip = WebPage.SingleOrDefault(x => x.WebPageId == int.Parse(webId));

                    if (webToolTip != null) {

                        dataGridView14.Columns[e.ColumnIndex].ToolTipText = webToolTip.Title.ToString();
                        label3.Visible = true;
                        label3.Text = webToolTip.Title.ToString();

                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e) {
            Form2 f2 = new Form2();
         

            if (dropDown2SelectionText == "Heading with headings under same page for entire website Cosine") {

                List<HeadingvsHeadinginSamePageCosine> items = HeadingvsHeadinginSamePageCosine.All().ToList();
                List<double> d = new List<double>();

                foreach (var x in items) {
                    if (x.CosineValueHeadingvsHeading == "") { continue; }
                    d.Add(double.Parse(x.CosineValueHeadingvsHeading));
                }

                SortedDictionary<double, int> histogram = new SortedDictionary<double, int>();
                foreach (var d1 in d) {
                    if (histogram.ContainsKey(d1)) {
                        histogram[d1]++;
                    }
                    else {
                        histogram[d1] = 1;
                    }
                }

                ArrayList key = new ArrayList();
                foreach (var hist1 in histogram) {
                    key.Add(hist1.Key);
                }
                ArrayList value = new ArrayList();
                foreach (var hist1 in histogram) {
                    value.Add(hist1.Value);
                }

                f2.TopMost = true; f2.Show();
                f2.UpdateConrol(histogram, key, value, f2, dropDown2SelectionText);

            }





            if (dropDown2SelectionText == "Heading with headings under same page for TUBS Cosine") {

                List<HeadingvsHeadinginSamePageCosinesTUB> items = HeadingvsHeadinginSamePageCosinesTUB.All().ToList();
                List<double> d = new List<double>();

                foreach (var x in items) {
                    if (x.CosineValueHeadingvsHeading == "") { continue; }
                    d.Add(double.Parse(x.CosineValueHeadingvsHeading));
                }

                SortedDictionary<double, int> histogram = new SortedDictionary<double, int>();
                foreach (var d1 in d) {
                    if (histogram.ContainsKey(d1)) {
                        histogram[d1]++;
                    }
                    else {
                        histogram[d1] = 1;
                    }
                }

                ArrayList key = new ArrayList();
                foreach (var hist1 in histogram) {
                    key.Add(hist1.Key);
                }
                ArrayList value = new ArrayList();
                foreach (var hist1 in histogram) {
                    value.Add(hist1.Value);
                }

                f2.TopMost = true; f2.Show();
                f2.UpdateConrol(histogram, key, value, f2, dropDown2SelectionText);

            }








            if (dropDown2SelectionText == "Link with heading entire website Cosine") {

                List<LinkWithHeading> items = LinkWithHeading.All().ToList();
                List<double> d = new List<double>();

                foreach (var x in items) {
                    if (x.CosineValueLinkHeading == "") { continue; }
                    d.Add(double.Parse(x.CosineValueLinkHeading));
                }

                SortedDictionary<double, int> histogram = new SortedDictionary<double, int>();
                foreach (var d1 in d) {
                    if (histogram.ContainsKey(d1)) {
                        histogram[d1]++;
                    }
                    else {
                        histogram[d1] = 1;
                    }
                }

                ArrayList key = new ArrayList();
                foreach (var hist1 in histogram) {
                    key.Add(hist1.Key);
                }
                ArrayList value = new ArrayList();
                foreach (var hist1 in histogram) {
                    value.Add(hist1.Value);
                }

                f2.TopMost = true; f2.Show();
                f2.UpdateConrol(histogram, key, value, f2, dropDown2SelectionText);

            }




            if (dropDown2SelectionText == "Link with heading TUBS Cosine") {

                List<LinkWithHeadingTUB> items = LinkWithHeadingTUB.All().ToList();
                List<double> d = new List<double>();

                foreach (var x in items) {
                    if (x.CosineValueLinkHeading== "") { continue; }
                    d.Add(double.Parse(x.CosineValueLinkHeading));
                }

                SortedDictionary<double, int> histogram = new SortedDictionary<double, int>();
                foreach (var d1 in d) {
                    if (histogram.ContainsKey(d1)) {
                        histogram[d1]++;
                    }
                    else {
                        histogram[d1] = 1;
                    }
                }

                ArrayList key = new ArrayList();
                foreach (var hist1 in histogram) {
                    key.Add(hist1.Key);
                }
                ArrayList value = new ArrayList();
                foreach (var hist1 in histogram) {
                    value.Add(hist1.Value);
                }

                f2.TopMost = true; f2.Show();
                f2.UpdateConrol(histogram, key, value, f2, dropDown2SelectionText);

            }





            if (dropDown2SelectionText == "Link with all links under heading for entire website Cosine") {

                List<CosineLinkLinkWithHeading> items = CosineLinkLinkWithHeading.All().ToList();
                List<double> d = new List<double>();

                foreach (var x in items) {
                    if (x.CosineValueLinkLinkWithHeading == "") { continue; }
                    d.Add(double.Parse(x.CosineValueLinkLinkWithHeading));
                }

                SortedDictionary<double, int> histogram = new SortedDictionary<double, int>();
                foreach (var d1 in d) {
                    if (histogram.ContainsKey(d1)) {
                        histogram[d1]++;
                    }
                    else {
                        histogram[d1] = 1;
                    }
                }

                ArrayList key = new ArrayList();
                foreach (var hist1 in histogram) {
                    key.Add(hist1.Key);
                }
                ArrayList value = new ArrayList();
                foreach (var hist1 in histogram) {
                    value.Add(hist1.Value);
                }

                f2.TopMost = true; f2.Show();
                f2.UpdateConrol(histogram, key, value, f2, dropDown2SelectionText);

            }





            if (dropDown2SelectionText == "Link with all links under heading for TUBS Cosine") {

                List<CosineLinkLinkWithHeadingTUB> items = CosineLinkLinkWithHeadingTUB.All().ToList();
                List<double> d = new List<double>();

                foreach (var x in items) {
                    if (x.CosineValueLinkLinkWithHeading == "") { continue; }
                    d.Add(double.Parse(x.CosineValueLinkLinkWithHeading));
                }

                SortedDictionary<double, int> histogram = new SortedDictionary<double, int>();
                foreach (var d1 in d) {
                    if (histogram.ContainsKey(d1)) {
                        histogram[d1]++;
                    }
                    else {
                        histogram[d1] = 1;
                    }
                }

                ArrayList key = new ArrayList();
                foreach (var hist1 in histogram) {
                    key.Add(hist1.Key);
                }
                ArrayList value = new ArrayList();
                foreach (var hist1 in histogram) {
                    value.Add(hist1.Value);
                }

                f2.TopMost = true; f2.Show();
                f2.UpdateConrol(histogram, key, value, f2, dropDown2SelectionText);

            }





            if (dropDown2SelectionText == "Link with all links without heading for TUBS Cosine") {

                List<CosineLinkLinkWithoutHeadingTUB> items = CosineLinkLinkWithoutHeadingTUB.All().ToList();
                List<double> d = new List<double>();

                foreach (var x in items) {
                    if (x.CosineValueLinkLinkWithoutHeading == "") { continue; }
                    d.Add(double.Parse(x.CosineValueLinkLinkWithoutHeading));
                }

                SortedDictionary<double, int> histogram = new SortedDictionary<double, int>();
                foreach (var d1 in d) {
                    if (histogram.ContainsKey(d1)) {
                        histogram[d1]++;
                    }
                    else {
                        histogram[d1] = 1;
                    }
                }

                ArrayList key = new ArrayList();
                foreach (var hist1 in histogram) {
                    key.Add(hist1.Key);
                }
                ArrayList value = new ArrayList();
                foreach (var hist1 in histogram) {
                    value.Add(hist1.Value);
                }

                f2.TopMost = true; f2.Show();
                f2.UpdateConrol(histogram, key, value, f2, dropDown2SelectionText);

            }







            if (dropDown2SelectionText == "Paragraph with heading for entire website Cosine") {

                List<Paragraph> items = Paragraph.All().ToList();
                List<double> d = new List<double>();

                foreach (var x in items) {
                    if (x.CosineValueParagraphHeading == "") { continue; }
                    d.Add(double.Parse(x.CosineValueParagraphHeading));
                }

                SortedDictionary<double, int> histogram = new SortedDictionary<double, int>();
                foreach (var d1 in d) {
                    if (histogram.ContainsKey(d1)) {
                        histogram[d1]++;
                    }
                    else {
                        histogram[d1] = 1;
                    }
                }

                ArrayList key = new ArrayList();
                foreach (var hist1 in histogram) {
                    key.Add(hist1.Key);
                }
                ArrayList value = new ArrayList();
                foreach (var hist1 in histogram) {
                    value.Add(hist1.Value);
                }

                f2.TopMost = true; f2.Show();
                f2.UpdateConrol(histogram, key, value, f2, dropDown2SelectionText);

            }




            if (dropDown2SelectionText == "Paragraph with heading TUBS Cosine") {

                List<ParagraphTUB> items = ParagraphTUB.All().ToList();
                List<double> d = new List<double>();

                foreach (var x in items) {
                    if (x.CosineValueParagraphHeading == "") { continue; }
                    d.Add(double.Parse(x.CosineValueParagraphHeading));
                }

                SortedDictionary<double, int> histogram = new SortedDictionary<double, int>();
                foreach (var d1 in d) {
                    if (histogram.ContainsKey(d1)) {
                        histogram[d1]++;
                    }
                    else {
                        histogram[d1] = 1;
                    }
                }

                ArrayList key = new ArrayList();
                foreach (var hist1 in histogram) {
                    key.Add(hist1.Key);
                }
                ArrayList value = new ArrayList();
                foreach (var hist1 in histogram) {
                    value.Add(hist1.Value);
                }

                f2.TopMost = true; f2.Show();
                f2.UpdateConrol(histogram, key, value, f2, dropDown2SelectionText);

            }





           

           


            if (dropDown2SelectionText== "Links with heading for entire website TVL") {

                List<LinkWithHeading> items = LinkWithHeading.All().ToList();
                List<double> d = new List<double>();

                foreach (var x in items) {
                    if (x.VectorTermLength == "") { continue; }
                    d.Add(double.Parse(x.VectorTermLength));
                }

                SortedDictionary<double, int> histogram = new SortedDictionary<double, int>();
                foreach (var d1 in d) {
                    if (histogram.ContainsKey(d1)) {
                        histogram[d1]++;
                    }
                    else {
                        histogram[d1] = 1;
                    }
                }

                ArrayList key = new ArrayList();
                foreach (var hist1 in histogram) {
                    key.Add(hist1.Key);
                }
                ArrayList value = new ArrayList();
                foreach (var hist1 in histogram) {
                    value.Add(hist1.Value);
                }

                f2.TopMost = true; f2.Show();
                f2.UpdateConrol(histogram, key, value, f2, dropDown2SelectionText);

            }






            if (dropDown2SelectionText == "Links without heading for entire website TVL") {

                List<LinkWithoutHeading> items = LinkWithoutHeading.All().ToList();
                List<double> d = new List<double>();

                foreach (var x in items) {
                    if (x.VectorTermLength == "") { continue; }
                    d.Add(double.Parse(x.VectorTermLength));
                }

                SortedDictionary<double, int> histogram = new SortedDictionary<double, int>();
                foreach (var d1 in d) {
                    if (histogram.ContainsKey(d1)) {
                        histogram[d1]++;
                    }
                    else {
                        histogram[d1] = 1;
                    }
                }

                ArrayList key = new ArrayList();
                foreach (var hist1 in histogram) {
                    key.Add(hist1.Key);
                }
                ArrayList value = new ArrayList();
                foreach (var hist1 in histogram) {
                    value.Add(hist1.Value);
                }

                f2.TopMost = true; f2.Show();
                f2.UpdateConrol(histogram, key, value, f2, dropDown2SelectionText);

            }





            if (dropDown2SelectionText == "Links without heading TUBS TVL") {

                List<LinkWithoutHeadingTUB> items = LinkWithoutHeadingTUB.All().ToList();
                List<double> d = new List<double>();

                foreach (var x in items) {
                    if (x.VectorTermLength == "") { continue; }
                    d.Add(double.Parse(x.VectorTermLength));
                }

                SortedDictionary<double, int> histogram = new SortedDictionary<double, int>();
                foreach (var d1 in d) {
                    if (histogram.ContainsKey(d1)) {
                        histogram[d1]++;
                    }
                    else {
                        histogram[d1] = 1;
                    }
                }

                ArrayList key = new ArrayList();
                foreach (var hist1 in histogram) {
                    key.Add(hist1.Key);
                }
                ArrayList value = new ArrayList();
                foreach (var hist1 in histogram) {
                    value.Add(hist1.Value);
                }

                f2.TopMost = true; f2.Show();
                f2.UpdateConrol(histogram, key, value, f2, dropDown2SelectionText);

            }





            if (dropDown2SelectionText == "Headings entire website TVL") {

                List<Heading> items = Heading.All().ToList();
                List<double> d = new List<double>();


                foreach (var x in items) {
                    if (x.VectorTermLength == "") { continue; }


                    d.Add(double.Parse(x.VectorTermLength));


                }

                SortedDictionary<double, int> histogram = new SortedDictionary<double, int>();
                foreach (var d1 in d) {
                    if (histogram.ContainsKey(d1)) {
                        histogram[d1]++;
                    }
                    else {
                        histogram[d1] = 1;
                    }
                }


                ArrayList key = new ArrayList();
                foreach (var hist1 in histogram) {

                    key.Add(hist1.Key);
                }
                ArrayList value = new ArrayList();
                foreach (var hist1 in histogram) {

                    value.Add(hist1.Value);
                }

                f2.TopMost = true;
                f2.Show();

                f2.UpdateConrol(histogram, key, value, f2, dropDown2SelectionText);


            }


            if (dropDown2SelectionText == "Headings TUBS TVL") {

                List<HeadingTUBSTVL> items = HeadingTUBSTVL.All().ToList();
                List<double> d = new List<double>();

                foreach (var x in items) {
                    if (x.VectorTermLength == "") { continue; }
                    d.Add(double.Parse(x.VectorTermLength));
                }

                SortedDictionary<double, int> histogram = new SortedDictionary<double, int>();
                foreach (var d1 in d) {
                    if (histogram.ContainsKey(d1)) {
                        histogram[d1]++;
                    }
                    else {
                        histogram[d1] = 1;
                    }
                }

                ArrayList key = new ArrayList();
                foreach (var hist1 in histogram) {
                    key.Add(hist1.Key);
                }
                ArrayList value = new ArrayList();
                foreach (var hist1 in histogram) {
                     value.Add(hist1.Value);
                }

                f2.TopMost = true;f2.Show();
                f2.UpdateConrol(histogram, key, value, f2, dropDown2SelectionText);
                
            }

            if (dropDown2SelectionText == "Links with heading TUBS TVL") {

                List<LinkWithHeadingTUB> items = LinkWithHeadingTUB.All().ToList();
                List<double> d = new List<double>();

                foreach (var x in items) {
                    if (x.VectorTermLength == "") { continue; }
                    d.Add(double.Parse(x.VectorTermLength));
                }

                SortedDictionary<double, int> histogram = new SortedDictionary<double, int>();
                foreach (var d1 in d) {
                    if (histogram.ContainsKey(d1)) {
                        histogram[d1]++;
                    }
                    else {
                        histogram[d1] = 1;
                    }
                }

                ArrayList key = new ArrayList();
                foreach (var hist1 in histogram) {
                    key.Add(hist1.Key);
                }
                ArrayList value = new ArrayList();
                foreach (var hist1 in histogram) {
                    value.Add(hist1.Value);
                }

                f2.TopMost = true; f2.Show();
                f2.UpdateConrol(histogram, key, value, f2, dropDown2SelectionText);

            }







            if (dropDown2SelectionText == "") {
                MessageBox.Show("Please make a Selection");
            }

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }








    }
}





