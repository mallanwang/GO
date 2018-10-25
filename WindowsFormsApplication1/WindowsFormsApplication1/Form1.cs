using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FastReport;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string file = Application.StartupPath + @"\Chinese (Simplified).frl";
            FastReport.Utils.Res.LoadLocale(file);

            DataTable Dt = new DataTable();
            Dt.Columns.Add("序列号");
            Dt.Columns.Add("品名");
            Dt.Columns.Add("克重");
            Dt.Columns.Add("幅宽");
            Dt.Columns.Add("机台");
            Dt.Columns.Add("长度");
            Dt.Columns.Add("批号");
            Dt.Columns.Add("筒号");
            Dt.Columns.Add("令数");
            Dt.Columns.Add("压力");
            Dt.Columns.Add("接头");
            Dt.Columns.Add("生产日期");
            Dt.Columns.Add("注解");
            Dt.Columns.Add("高度");
            Dt.Columns.Add("件号");
            Dt.Columns.Add("数量");
            Dt.Columns.Add("拖号");
            Dt.Columns.Add("班次");
            Dt.Columns.Add("净重");
            Dt.Columns.Add("毛重");
            DataRow row = Dt.NewRow();
            row["序列号"] = "C050302016304000018500#01170201101001026";
            row["品名"] = "1234567890";
            row["克重"] = "1234567890";
            row["幅宽"] = "1234567890";
            row["机台"] = "1234567890";
            row["长度"] = "1234567890";
            row["批号"] = "1234567890";
            row["筒号"] = "1234567890";
            row["令数"] = "1234567890";
            row["压力"] = "1234567890";
            row["接头"] = "1234567890";
            row["生产日期"] = "1234567890";
            row["注解"] = "1234567890";
            row["高度"] = "1234567890";
            row["件号"] = "1234567890";
            row["数量"] = "1234567890";
            row["拖号"] = "1234567890";
            row["净重"] = "1234567890";
            row["毛重"] = "1234567890";
            row["班次"] = "1234567890";
            Dt.Rows.Add(row);

            this.designerControl1.Report = report1;
            report1.RegisterData(Dt, "BRIMOSC_DYHistory");
            report1.Prepare();
            report1.Design();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //string printname = "Generic / Text Only";
                //PrintDialog printDialog = new PrintDialog();
                //if (printDialog.ShowDialog() == DialogResult.OK)
                //{
                //    printname = printDialog.PrinterSettings.PrinterName;
                //}
                //else
                //{
                //    return;
                //}

                report1.Load(Application.StartupPath + @"\普通合格证A4.frx");
                //(report1.FindObject("TM") as TextObject).Text = "654321";
                //DataTable dt = new DataTable();
                //dt.Columns.Add("测试1");
                //dt.Columns.Add("测试2");
                //DataRow row = dt.NewRow();
                //row["测试1"] = "测试65432112345678";
                //row["测试2"] = "TW100001";
                //dt.Rows.Add(row);
                DataTable Dt = new DataTable();
                Dt.Columns.Add("序列号");
                Dt.Columns.Add("品名");
                Dt.Columns.Add("克重");
                Dt.Columns.Add("幅宽");
                Dt.Columns.Add("机台");
                Dt.Columns.Add("长度");
                Dt.Columns.Add("批号");
                Dt.Columns.Add("筒号");
                Dt.Columns.Add("令数");
                Dt.Columns.Add("压力");
                Dt.Columns.Add("接头");
                Dt.Columns.Add("生产日期");
                Dt.Columns.Add("注解");
                Dt.Columns.Add("高度");
                Dt.Columns.Add("件号");
                Dt.Columns.Add("数量");
                Dt.Columns.Add("拖号");
                Dt.Columns.Add("班次");
                Dt.Columns.Add("净重");
                Dt.Columns.Add("毛重");
                DataRow row = Dt.NewRow();
                row["序列号"] = "C050302016304000018500#01170201101001026";
                row["品名"] = "1234567890";
                row["克重"] = "1234567890";
                row["幅宽"] = "1234567890";
                row["机台"] = "1234567890";
                row["长度"] = "1234567890";
                row["批号"] = "1234567890";
                row["筒号"] = "1234567890";
                row["令数"] = "1234567890";
                row["压力"] = "1234567890";
                row["接头"] = "1234567890";
                row["生产日期"] = "1234567890";
                row["注解"] = "1234567890";
                row["高度"] = "1234567890";
                row["件号"] = "1234567890";
                row["数量"] = "1234567890";
                row["拖号"] = "1234567890";
                row["净重"] = "1234567890";
                row["毛重"] = "1234567890";
                row["班次"] = "1234567890";
                //row["品名"] = tbx_PINMING.Text.Trim();
                //row["幅宽"] = tbx_FUKUAN.Text.Trim();
                //row["机台"] = tbx_HGJiTai.Text.Trim();
                //row["长度"] = tbx_HGChangDu.Text.Trim();
                //row["批号"] = tbx_PIHAO.Text.Trim();
                //row["筒号"] = tbx_TONGHAO.Text.Trim();
                //row["令数"] = tbx_LINGSHU.Text.Trim();
                //row["压力"] = tbx_YALI.Text.Trim();
                //row["接头"] = tbx_JIETOU.Text.Trim();
                //row["生产日期"] = tbx_SHENGCHANRIQI.Text.Trim();
                //row["注解"] = tbx_ZHUJIE.Text.Trim();
                //row["高度"] = tbx_GAODU.Text.Trim();
                //row["件号"] = tbx_JIANHAO.Text.Trim();
                //row["数量"] = tbx_SHULIANG.Text.Trim();
                //row["拖号"] = tbx_TUOPANHAO.Text.Trim();
                //row["净重"] = tbx_JingZhong.Text.Trim();
                //row["毛重"] = tbx_MaoZhong.Text.Trim();
                //row["班次"] = tbx_BC.Text.Trim();
                Dt.Rows.Add(row);
                report1.RegisterData(Dt, "BRIMOSC_DYHistory");
                report1.Prepare();
                report1.ShowPrepared();
                //report1.Show();
                //打印
                //report1.PrintSettings.Printer = printname;
                //report1.PrintSettings.ShowDialog = false;
                //report1.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        FastReport.Report report1 = new FastReport.Report();
        private void button2_Click(object sender, EventArgs e)
        {
            string filename = Application.StartupPath + @"\test2.frx";
            report1.Save(filename);  
        }
    }
}
