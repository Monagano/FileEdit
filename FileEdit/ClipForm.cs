using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

namespace ClipMaster
{
    public partial class ClipForm : Form
    {
        [DllImport("user32.dll")]
        extern static int RegisterHotKey(IntPtr HWnd, int ID, int MOD_KEY, int KEY);
        [DllImport("user32.dll")]
        extern static int UnregisterHotKey(IntPtr HWnd, int ID);
        [DllImport("kernel32", EntryPoint = "GlobalAddAtomA")]
        static extern short GlobalAddAtom(string lpString);

        const int MOD_ALT = 0x0001;
        const int MOD_SHIFT = 0x0004;

        private int atomId = 0;

        private Dictionary<string, Func<string, string>> ReplaceStrFuncDic;

        public class shortcutData
        {
            public string key;
            public string title;
            public string body;
            public shortcutData(string key, string title, string body)
            {
                this.key = key;
                this.title = title;
                this.body = body;
            }
            public shortcutData() { }
        }

        public class dollarData
        {
            public DateTime dt;
            public string mainStr;
            public string dollarTitle;
            public dollarData(string dollarTitle, string mainStr)
                : this(dollarTitle, mainStr, DateTime.Now)
            {
            }
            public dollarData(string dollarTitle, string mainStr, DateTime dt)
            {
                this.dollarTitle = dollarTitle;
                this.mainStr = mainStr;
                this.dt = dt;
            }
            public dollarData() { }
        }

        [Serializable]
        public class UserData
        {
            public List<shortcutData> scList;
            public List<dollarData> dollarList;
            public UserData()
            {
                scList = new List<shortcutData>();
                dollarList = new List<dollarData>();
            }
        }

        UserData userData;

        public ClipForm()
        {
            ReplaceStrFuncDic = new Dictionary<string, Func<string, string>>();
            new string[] { "$base", "$space", "$reason", "$name", "$time" }.ToList()
                .ForEach(key => ReplaceStrFuncDic.Add(key, s => s));
            ReplaceStrFuncDic.Add("$crlf", str => str.Replace("$crlf", "\r\n"));
            ReplaceStrFuncDic.Add("$lfonly", str => str.Replace("$lfonly", "\n"));

            InitializeComponent();
            textBox1.Enter+= (sender, e) => textBox1.ImeMode = ImeMode.Disable;

            nameTextBox.Text = "JSL";
            atomId = GlobalAddAtom("GlobalHotKey ");
            RegisterHotKey(Handle, atomId, MOD_ALT | MOD_SHIFT, (int)Keys.Z);
            Closed += (sender, e) =>
            {
                UnregisterHotKey(Handle, atomId);
            };
            textBox1.KeyDown += MainForm_KeyDown;
            //this.Controls.Cast<Control>().ToList().ForEach(c=>c.KeyDown += MainForm_KeyDown);

            if (!LoadXML("command.xml"))
            {
                userData = new UserData();
                userData.scList.AddRange(new shortcutData[]{
                    new shortcutData("D1","","// $time{yyyy.MM.dd} $name $reason START"),
                    new shortcutData("D2","","// $time{yyyy.MM.dd} $name $reason END"),
                    new shortcutData("D3","","// $time{yyyy.MM.dd} $name 3rd IE11表示対応"),
                    new shortcutData("D4","","$space// $time{yyyy.MM.dd} $reason -->\r\n$base\r\n$space// $time{yyyy.MM.dd} $reason <--"),
                    new shortcutData("Q","","<!-- $time{yyyy.MM.dd} $name $reason START -->"),
                    new shortcutData("W","","<!-- $time{yyyy.MM.dd} $name $reason END   -->"),
                    new shortcutData("E","","<!-- $time{yyyy.MM.dd} $name 3rd IE11表示対応 -->"),
                    new shortcutData("R","", "// $reason --->\r\n$base\r\n// $reason <---"),
                    new shortcutData("A","","/* $time{yyyy.MM.dd} $name $reason START */"),
                    new shortcutData("S","","/* $time{yyyy.MM.dd} $name $reason END */"),
                    new shortcutData("D","","/* $time{yyyy.MM.dd} $name 3rd IE11表示対応 */"),
                    new shortcutData("F","","$space/* $time{yyyy.MM.dd} $name $reason START */\r\n$base\r\n$space/* $time{yyyy.MM.dd} $name $reason END */")
                });
            }
            SetScDgv();
        }

        private bool LoadXML(string path)
        {
            if (File.Exists(path))
            {
                XmlSerializer xs = new XmlSerializer(typeof(UserData));
                using (FileStream fs = File.OpenRead(path))
                {
                    userData = (xs.Deserialize(fs) as UserData);
                }
                dollarCombo.Items.Clear();
                dollarCombo.Items.AddRange(userData.dollarList.OrderBy(d => d.dt).Select(d => d.mainStr).ToArray());
                SetScDgv();
                return true;
            }
            return false;
        }

        private void SetScDgv()
        {
            dgvBody.Rows.Clear();
            userData.scList.ForEach(scd => dgvBody.Rows.Add(ClmExec, scd.key, scd.title, scd.body));
        }

        /// <summary>
        /// Shift+ALT+Zをキャッチしてウィンドウをアクティブにする
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            short mwprm = (short)m.WParam;
            if (mwprm == atomId)
            {
                Clipboard.Clear();
                int i = 1;
                while (!(Clipboard.ContainsText() || i > 5))
                {
                    SendKeys.SendWait("^c");
                    System.Threading.Thread.Sleep(100);
                    i++;
                }
                string memBase = "";
                string memSpace = "";
                if (Clipboard.ContainsText())
                {
                    memBase = Clipboard.GetText(TextDataFormat.UnicodeText);
                    memSpace = Regex.Match(memBase, "^([\x20\t]+).+").Groups[1].Value;
                }
                ReplaceStrFuncDic["$base"] = str => str.Replace("$base", memBase);
                ReplaceStrFuncDic["$space"] = str => str.Replace("$space", memSpace);

                updatePreview();
                if(!Visible)Show();
                WindowState = FormWindowState.Normal;
                Activate();
                textBox1.Focus();
                
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            shortcutData hitShortCut = userData.scList.FirstOrDefault(sc => sc.key == e.KeyCode.ToString());
            if (hitShortCut == null) return;
            ExecPaste(hitShortCut);
        }
        private void ExecPaste(shortcutData hitShortCut)
        {
            WindowState = FormWindowState.Minimized;
            string result = makeText(hitShortCut.body);
            Clipboard.SetText(result, TextDataFormat.Text);
            SendKeys.Send("^v");
            if (userData.dollarList.Exists(d => d.mainStr == dollarCombo.Text))
                userData.dollarList.First(d => d.mainStr == dollarCombo.Text).dt = DateTime.Now;
            else
                userData.dollarList.Add(new dollarData("", dollarCombo.Text));
            userData.dollarList.Sort((x,y)=>x.dt.CompareTo(y.dt));
            //d => d.dt);
            dollarCombo.Items.Clear();
            dollarCombo.Items.AddRange(userData.dollarList.Select(d => d.mainStr).ToArray());
        }
        private string makeText(string body)
        {
            ReplaceStrFuncDic["$name"] = str => str.Replace("$name", nameTextBox.Text);
            ReplaceStrFuncDic["$reason"] = str => str.Replace("$reason", dollarCombo.Text);
            ReplaceStrFuncDic["$time"] = str =>
            {
                Match match = Regex.Match(str, @"\$time{(.+?)}");
                if (!match.Success) return str;
                return str.Replace(match.Groups[0].Value, DateTime.Now.ToString(match.Groups[1].Value));
            };
            return ReplaceStrFuncDic.Values.Aggregate(body, (mem, func) => func(mem));
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(userData.GetType());
            if (File.Exists("command.xml"))
            {
                File.Copy("command.xml", $"command{DateTime.Now:yyyyMMddHHmmss}.xml");
                File.Delete("command.xml");
            }
            using (FileStream fs = File.OpenWrite("command.xml"))
            {
                xs.Serialize(fs, userData);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            userData.scList.Clear();
            userData.scList.AddRange(dgvBody.Rows.Cast<DataGridViewRow>()
                .Where(row => row.Cells[ClmKey.Index].Value?.ToString()?.Length > 0)
                .Select(row =>
                {
                    string key = row.Cells[ClmKey.Index].Value.ToString();
                    string title = row.Cells[ClmTitle.Index].Value?.ToString() ?? "";
                    string body = row.Cells[ClmBody.Index].Value?.ToString() ?? "";
                    return new shortcutData(key, title, body);
                }));

        }

        private void dgvBody_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex != ClmKey.Index) return;

            string key = dgvBody[e.ColumnIndex, e.RowIndex].Value?.ToString() ?? "";
            if (key != "" && dgvBody.Rows.Cast<DataGridViewRow>()
                .Any(dgvR => (dgvR.Cells[ClmKey.Index].Value?.ToString()?.Contains(key) ?? false) && dgvR.Index != e.RowIndex))
            {
                MessageBox.Show($"一意性制約違反：キー列の値が重複しています。 値：{key}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvBody[e.ColumnIndex, e.RowIndex].Value = "";
            }

        }

        private void dgvBody_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvBody.CurrentCell.RowIndex == -1) return;
            if (dgvBody.CurrentCell.ColumnIndex != ClmKey.Index) return;

            dgvBody.CurrentCell.Value = e.KeyCode.ToString();

        }

        private void dgvBody_SelectionChanged(object sender, EventArgs e)
        {
            updatePreview();
            // 
        }
        private void updatePreview()
        {
            if (dgvBody.CurrentCell.RowIndex == -1 || dgvBody.Rows[dgvBody.CurrentCell.RowIndex].Cells[ClmBody.Index].Value == null) return;
            previewRichText.Text = makeText(dgvBody.Rows[dgvBody.CurrentCell.RowIndex].Cells[ClmBody.Index].Value.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            updatePreview();
        }

        private void dollarCombo_TextChanged(object sender, EventArgs e)
        {
            updatePreview();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XMLファイル(*.xml)|*.xml";
            ofd.Title = Path.GetDirectoryName(Application.ExecutablePath);
            ofd.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            if (ofd.ShowDialog() == DialogResult.OK)
                LoadXML(ofd.FileName);
        }

        private void dgvBody_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex != ClmExec.Index) return;
            string keyStr = dgvBody[ClmKey.Index, e.RowIndex].Value?.ToString();
            shortcutData hitShortCut = userData.scList.FirstOrDefault(sc => sc.key == keyStr);
            if (hitShortCut == null) return;
            ExecPaste(hitShortCut);

        }

        /// <summary>
        /// 右クリックメニュー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBody_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.Button != MouseButtons.Right) return;
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("編集", FileEdit.Properties.Resources.edit16, (s, ev) => {
                string body = dgvBody[ClmBody.Index, e.RowIndex].Value.ToString().Replace("$crlf", "\r\n");
                if (body == null) return;
                editClipForm editFm = new editClipForm(body);
                if (editFm.ShowDialog(this) == DialogResult.OK)
                    dgvBody[ClmBody.Index, e.RowIndex].Value = editFm.result.Replace("\r\n", "$crlf");
            });
            menu.Show(Cursor.Position);
        }
    }
}
