using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.Xml.XPath;
using System.Text.RegularExpressions;
using ClipMaster;
using System.Net.Sockets;
using System.Net;
namespace FileEdit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DropBox_DragEnter(object sender, DragEventArgs e)
        {
            //コントロール内にドラッグされたとき実行される
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {//ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                e.Effect = DragDropEffects.Copy;
                DDlabel.Visible = false;
            }
            else
            {
                //ファイル以外は受け付けない
                e.Effect = DragDropEffects.None;
            }
        }

        private void DropBox_DragDrop(object sender, DragEventArgs e)
        {
            //コントロール内にドロップされたとき実行される
            //ドロップされたすべてのファイル名を取得する
            string[] fileName =
                (string[]) e.Data.GetData(DataFormats.FileDrop, false);
            
            //ListBoxに追加する
            DropBox.Items.AddRange(fileName.Where(fn => !DropBox.Items.Contains(fn)).ToArray());
        }

        private void DropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DDlabel.Visible = DropBox.Items.Count == 0;
            if (DropBox.SelectedItem == null) return;
            string path = DropBox.SelectedItem.ToString();
            if(File.Exists(path)){
                BodyBox.Text = string.Join("\r\n", File.ReadAllLines(path));
            }
        }

        private void BodyBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void xmlSortBtn_Click(object sender, EventArgs e)
        {
            xmlSortAndSave((elm,path) =>
            {
                string newPath = Regex.Replace(path, @"\.(.+?)$", "_rep.$1");
                File.WriteAllText(newPath, elm.ToString());
            });
        }

        private XDocument SortXML(XDocument targetXdoc)
        {
            if (targetXdoc.XPathSelectElements("./*/*").Count() == 0) return targetXdoc;
            var sortedElems = targetXdoc.XPathSelectElements("./*/*").OrderBy(ele => ele.ToString());
            
            XDocument sortedXdoc = new XDocument(targetXdoc);
            foreach (var elem in sortedElems)
            {
                sortedXdoc.Add(SortXML(new XDocument(elem)));
            }
            return sortedXdoc;
        }

        private void xmlSortAndSave(Action<XDocument,string> saveAct)
        {
            if (DropBox.SelectedItem == null) return;
            string path = DropBox.SelectedItem.ToString();
            if (File.Exists(path))
            {
                try
                {
                    
                    XDocument hoge = SortXML(XDocument.Parse(File.ReadAllText(path)));
                    //hoge.Elements()
                    //var sortedChild = hoge.Nodes().OrderBy(ele => ele.ToString());
                    //hoge.RemoveNodes();
                    //XElement fuga = XElement.Parse(File.ReadAllText(path));
                    //fuga.RemoveNodes();
                    //foreach (var ele in sortedChild) fuga.Add(ele);
                    saveAct(hoge, path);
                }
                catch (XmlException er)
                {
                    MessageBox.Show(er.Message);
                }
                finally
                {

                }
            }
        }
        private void xmlSortAltBtn_Click(object sender, EventArgs e)
        {
            xmlSortAndSave((elm, path) =>
            {
                SaveFileDialog sfd = new SaveFileDialog();
                string newPath = Regex.Replace(Path.GetFileName(path), @"\.(.+?)$", "_rep.$1");
                sfd.FileName = newPath;
                sfd.InitialDirectory = Path.GetDirectoryName(path);
                sfd.Title = "保存先のファイルを選択してください";
                sfd.RestoreDirectory = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(elm.ToString());
                    xml.Save(sfd.FileName);
                    //File.WriteAllText(sfd.FileName, elm.ToString());
                }
                else
                {
                    MessageBox.Show("保存しませんでした。");
                }
                
            });
        }

        private void ClipMaster_Click(object sender, EventArgs e)
        {
            ClipForm cf = null;
            cf = new ClipForm();
            cf.SizeChanged += Form_SizeChanged;
            cf.FormClosed += (fcSender, fcE) =>
            {
                Show();
            };
            cf.Show();
            Hide();
        }

        private void DropBox_DragLeave(object sender, EventArgs e)
        {
            DDlabel.Visible = DropBox.Items.Count == 0;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon.Visible = false;
        }

        private void Form_SizeChanged(object sender, EventArgs e)
        {
            Form fm = sender as Form;
            if(fm.WindowState == FormWindowState.Minimized) {
                fm.Hide();
                notifyIcon.Tag = fm;
                contextMenu.Items.Clear();
                contextMenu.Items.Add($"{fm.Name} を開く", null, NotifyIcon_DoubleClick);
                contextMenu.Items.Add("終了", null, (s, ea) => fm.Close());
                Application.ApplicationExit += Application_ApplicationExit;
                notifyIcon.Visible = true;
                notifyIcon.DoubleClick += NotifyIcon_DoubleClick;

            }else
            {
                Application.ApplicationExit -= Application_ApplicationExit;
                notifyIcon.Visible = false;
            }
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            notifyIcon.DoubleClick -= NotifyIcon_DoubleClick;
            if (notifyIcon.Tag == null) return;
            Form fm = notifyIcon.Tag as Form;
            fm.Show();
            fm.WindowState = FormWindowState.Normal;
            notifyIcon.Tag = null;
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            Application.ApplicationExit -= Application_ApplicationExit;
            if (notifyIcon != null) notifyIcon.Visible = false;
        }

        private void pdfbutton_Click(object sender, EventArgs e)
        {
            foreach(var hoge in DropBox.Items)
            {
                if (File.Exists(hoge.ToString()))
                {
                    File.Copy(hoge.ToString(), hoge.ToString() + ".pdf");
                }
            }   
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
